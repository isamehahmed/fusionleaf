<?php

// ************************** Functions **************************

// Page load time output
$starttime = time()+microtime();

// Function to output the time to load the page
function PtimerStop()
{
   global $starttime;
   $endtime = time()+microtime();
   $totaltime = round($endtime - $starttime,4);
   return '<div class="center well">This page took ' . $totaltime . ' seconds to load.</div>';
}

// Function to determine the number of subdirectories based off URL address (www.fusionleaf.com vs localhost)
function nav_up($s,$c)
{
	if ($c==0) return $s;
	else return dirname(nav_up($s,$c-1));
}

// File_Array class provides an easy way to read and write variables to a file
class file_array
{
	private $file;			// File name
	private $stack = array(); 	// Array
	private $changed=false;		// Change indicator

	function __construct($f){ $this->setfile($f); $this->read(); }
	function __destruct()	{ $this->save(); }
	private function setfile($f) 	{ $this->file = $f; }
	function getfile() 	{ return $this->file; }
	private function save()	{ if ($this->stack && $this->changed) { file_put_contents($this->file,json_encode($this->stack)); }
					else if (!$this->stack) { if (file_exists($this->file)) { unlink($this->file); } } }
	private function read()	{ if (file_exists($this->file)) $this->stack = json_decode(file_get_contents($this->file),true); }
	function add($key, $val){ $this->stack[$key]=$val; $this->changed=true; }
	function del($key)	{ unset($this->stack[$key]); $this->changed=true; }
	function get($key)	{ if (isset($this->stack[$key])) { return $this->stack[$key]; }
					else { return false; } }
	function clean()	{ $this->stack=false; $this->changed=true; }
	function show()		{ return print_array($this->stack); }
	function grab()		{ return $this->stack; }
}


// ************************** Variables **************************

/* ****** Environment Variables ****** */
if (strtoupper(substr(PHP_OS, 0, 3)) === 'WIN') define("IS_WIN_OS",true);
else define("IS_WIN_OS",false);
if (IS_WIN_OS)
{
	define("NEWLINE","\r\n");
	// Don't use sys_get_temp_dir
	define("DIR_SEP",'\\');
	define("CMS_ROOT",str_replace('/',DIR_SEP,$_SERVER['DOCUMENT_ROOT']));
	define('CMS_OS','windows');
}
else
{
	define("NEWLINE","\n");
	// Don't use sys_get_temp_dir
	define("DIR_SEP",'/');
	define("CMS_ROOT",$_SERVER['DOCUMENT_ROOT']);
	define('CMS_OS','linux');
}

/* ****** Webserver Variables ****** */
if (isset($_SERVER['ORIG_SCRIPT_FILENAME'])) // Available in Lighttp
{
	// Default home path
	define("HOMEPATH",str_replace('index.php','',$_SERVER['ORIG_SCRIPT_FILENAME']));
}
else
{
	// Default home path
	define("HOMEPATH",str_replace('index.php','',$_SERVER['SCRIPT_FILENAME']));
}


$levels = count(explode('.',$_SERVER['HTTP_HOST']));
define("FLS_ROOT", dirname(nav_up(CMS_ROOT,$levels)));

// Folders
//define("FLS_ROOT", dirname(dirname(dirname(dirname(CMS_ROOT)))));
define("CMS_HIDDEN",CMS_ROOT.DIR_SEP."_hidden");
define("CMS_THEME",CMS_ROOT.DIR_SEP."theme");
define("CMS_PHP_SCRIPT",CMS_HIDDEN.DIR_SEP."php_script");
define("CMS_CACHE",CMS_HIDDEN.DIR_SEP."cache");
define("MYSQL_BIN", FLS_ROOT.DIR_SEP."app".DIR_SEP."mysql".DIR_SEP."bin");

// Files
define('CMS_FILE_VERSION',CMS_HIDDEN.DIR_SEP.'version');
define('CMS_FILE_SITE',CMS_HIDDEN.DIR_SEP.'site');
define('CMS_FILE_INCLUDE',CMS_HIDDEN.DIR_SEP.'indexinc.php');
if (ini_get('error_log')!='') define('CMS_ERROR_PHP',dirname(ini_get('error_log')).DIR_SEP.'cms_errors.html');
else define('CMS_ERROR_PHP',sys_get_temp_dir().DIR_SEP.'cms_errors.html');

// Files for backup
define('CMS_SCRIPT_DEFINE',CMS_PHP_SCRIPT.DIR_SEP.'define.php');
define('CMS_SCRIPT_SETUP',CMS_PHP_SCRIPT.DIR_SEP.'setup.php');

// Memcache
if (extension_loaded('memcache'))
{
	define('MEMCACHE_SERVER','127.0.0.1');
	define('MEMCACHE_PORT',11211);
	define('MEMCACHE_ADD_FLAG',false);
	define('MEMCACHE_ADD_TIMEOUT',60);
	define('SETTING_MEMCACHE','enable');
}

// Disable errors before going live		// DEV
// Report all errors except E_NOTICE
error_reporting( -1 );
ini_set( 'display_errors', 1 );

// Turn off all error reporting			// PROD
//error_reporting(0);
//ini_set( 'log_errors', 1 );

// Counter Variables
$sql_counter_out = 0;
$sql_counter_in = 0;


// ************************** Functions that Require Global Variables **************************

// Test a constant
function constant_test($constant,$value)
{
	if (defined($constant) && constant($constant)==$value) return true;
	else return false;
}

// Either go to the setup page or set the global variables from the setup file
function initial_setup()
{
	$set = new file_array(CMS_FILE_SITE);
	$check = $set->get('recorded_root');
	if ($check != $_SERVER['DOCUMENT_ROOT'])
	{
		if (!file_exists(CMS_ROOT.DIR_SEP.'setup.php'))
		{
			copy(CMS_HIDDEN.DIR_SEP.'php_script'.DIR_SEP.'setup.php', CMS_ROOT.DIR_SEP.'setup.php');
		}
		header("Location: setup.php");
		exit;
	}
	else if (file_exists(CMS_ROOT.DIR_SEP.'setup.php'))
	{
		unlink(CMS_ROOT.DIR_SEP.'setup.php');
		if (file_exists(CMS_FILE_INCLUDE)) unlink(CMS_FILE_INCLUDE);
	}

	$arr = $set->grab();
	foreach($arr as $key=>$val) if (!defined(strtoupper($key))) define(strtoupper($key), $val);
}

// If the OS changed, rerun setup
function db_prepare()
{
	$set = new file_array(CMS_FILE_SITE);
	if ($set->get('setup')!=CMS_OS)
	{
		$mysqli = @new mysqli(DB_HOST, DB_ROOT_USERNAME, '', DB_DATABASE);
		$files = glob(CMS_HIDDEN.DIR_SEP."mysql_backup".DIR_SEP."*.sql");
	
		if (!count($files)) die('No restore found!');
	
		if (IS_WIN_OS)
		{
			// Set the path and extension
			$exe_path = MYSQL_BIN.DIR_SEP;
			$exe_ext = '.exe';	
		}
		else
		{
			// Set the path and extension
			$exe_path = '';
			$exe_ext = '';
		}
	
		// Reset the password to blank
		//if ($mysqli->connect_error)
		//{
		    exec("\"".$exe_path."mysql".$exe_ext."\" --user ".DB_ROOT_USERNAME." -p".DB_ROOT_PASSWORD." -h 127.0.0.1 -e \"use mysql; update user set password=PASSWORD('') where User='".DB_ROOT_USERNAME."'; FLUSH PRIVILEGES;\"");
		//}	
		//die('ok');
		exec("\"".$exe_path."mysql".$exe_ext."\" --user ".DB_ROOT_USERNAME." -h 127.0.0.1 -e \"drop database ".DB_DATABASE.";\"");
		exec("\"".$exe_path."mysql".$exe_ext."\" --user ".DB_ROOT_USERNAME." -h 127.0.0.1 -e \"create database ".DB_DATABASE.";\"");
		
		exec("\"".$exe_path."mysql".$exe_ext."\" --user ".DB_ROOT_USERNAME." -h 127.0.0.1 -e \"CREATE USER '".DB_WRITE_USERNAME."'@'localhost' IDENTIFIED BY '".DB_WRITE_PASSWORD."';\"");
		exec("\"".$exe_path."mysql".$exe_ext."\" --user ".DB_ROOT_USERNAME." -h 127.0.0.1 -e \"CREATE USER '".DB_READ_USERNAME."'@'localhost' IDENTIFIED BY '".DB_READ_PASSWORD."';\"");
		
		exec("\"".$exe_path."mysql".$exe_ext."\" --user ".DB_ROOT_USERNAME." -h 127.0.0.1 -e \"GRANT ALL ON ".DB_DATABASE.".* TO '".DB_WRITE_USERNAME."'@'localhost';\"");
		exec("\"".$exe_path."mysql".$exe_ext."\" --user ".DB_ROOT_USERNAME." -h 127.0.0.1 -e \"GRANT SELECT ON ".DB_DATABASE.".* TO '".DB_READ_USERNAME."'@'localhost';\"");
		
		exec("\"".$exe_path."mysql".$exe_ext."\" --user ".DB_ROOT_USERNAME." -h 127.0.0.1 -e \"FLUSH PRIVILEGES;\"");
		
		// Get the newest file (at the bottom)
		$r = $files[count($files)-1];
		
		exec("\"".$exe_path."mysql".$exe_ext."\" --user ".DB_ROOT_USERNAME." -h 127.0.0.1 ".DB_DATABASE." < \"$r\"");
		exec("\"".$exe_path."mysqladmin".$exe_ext."\" -u ".DB_ROOT_USERNAME." password ".DB_ROOT_PASSWORD);
		
		//echo "Database restored: <a href='http://".$_SERVER['HTTP_HOST']."'>Continue</a>";
	
		// Mark the install as complete
		$set->add('setup',CMS_OS);
		if (file_exists(CMS_FILE_INCLUDE)) unlink(CMS_FILE_INCLUDE);
	
		header("Location: http://".$_SERVER['HTTP_HOST']);
		exit;
	}
}

function dbExecute($stmt, $verbose, $dbconnection)
{// Executes a mySQL statement and handles errors, return false in an error
	try
	{
  		// Execute the statement
    	if (!@mysqli_stmt_execute($stmt))
    	{
    		// If the statement caused an error, throw an error
    		throw new Exception (mysqli_errno($dbconnection).": ".mysqli_error($dbconnection));
    	}
    	
    	return true;
	}
	catch (Exception $e)
	{
		// If the output should be verbose
		if ($verbose)
		{
			$output = "Statement error: ".$e->getMessage();
			print_r($output);
		} 
	}
	return false;
}

function simpleDB($qry, $verbose, $write=false)
{// Returns the single value from a query, return false in an error

	// Handle memcache
	global $memcache;
	if (isset($memcache) && !$write)
	{
		// Create a lookup key for memcache
		$memcache_key = md5($qry);
		
		// Lookup value in memcache
		$result = $memcache->get($memcache_key);
		
		// If memcache doesn't have the result
		if($result)
		{
			return $result;
		}
	}

	if ($write) $dbconnection = mysqli_connect(DB_HOST,DB_WRITE_USERNAME,DB_WRITE_PASSWORD,DB_DATABASE,DB_PORT) or die("Problem connecting: ".mysqli_error());
	else $dbconnection = mysqli_connect(DB_HOST,DB_READ_USERNAME,DB_READ_PASSWORD,DB_DATABASE,DB_PORT) or die("Problem connecting: ".mysqli_error());

  	//echo mysqli_info($dbconnection);
  	//echo mysql_error($dbconnection);
  	//echo mysqli_connect_errno;

  	//print_r($dbconnection);

  	// Prepare the SQL statement
  	$stmt = mysqli_prepare($dbconnection, $qry);

  	$return = false;
  	
  	// Execute the statement	    
  	if (dbExecute($stmt, $verbose, $dbconnection))
  	{
  		// Store the result
	    mysqli_stmt_store_result($stmt);
	    
	    // Count the number of rows
	    $rowcount = mysqli_stmt_num_rows($stmt);
	    
	    // If SQL is using SELECT, return the results
	    if (strpos($qry,'ELECT'))
	    {
		    try
		    {
			    // Bind the result
			    if (!@mysqli_stmt_bind_result($stmt, $a))
			    {
	        		// If the statement caused an error, throw an error
	    			throw new Exception (mysqli_errno($dbconnection).": ".mysqli_error($dbconnection));
			    }
			    
				// If a record is returned
			    if ( $rowcount > 0 )
			  	{
					while ($stmt->fetch())
					{
			        	// Return the first variable
						$return = stripslashes($a);
					}
				}
				else $return = false;
		    }
	  		catch (Exception $e)
			{
				// If the output should be verbose
				if ($verbose)
				{
					$output = "Query error: ".$qry." - ".$e->getMessage();
					print_r($output);
				} 
			}
	    }
  	}

	// Close the connection
  	mysqli_close($dbconnection);
  	
	// Handle memcache
	if (isset($memcache) && !$write)
	{
		$memcache->set($memcache_key,$result,MEMCACHE_ADD_FLAG,MEMCACHE_ADD_TIMEOUT);
	}

    return $return;
}

function method_retrieve($name, $like=false, $table='php_methods', $post=false)
{
	if ($like) $qry = "SELECT method,name,post FROM $table WHERE name LIKE ?";
	else $qry = "SELECT method,name,post FROM $table WHERE name=? LIMIT 1";
	$params = array($name);

	// Connect to memcache
	global $memcache;
	$result = null;

	if (isset($memcache))
	{
		// Create a lookup key for memcache
		$memcache_key = md5($qry.implode($params));
		
		// Lookup value in memcache
		$result = $memcache->get($memcache_key);
	}

	// If memcache doesn't have the result, just increment the counter
	if($result == null)
	{
		global $sql_counter_out;
		$sql_counter_out += 1;
	}

	// Run the SQL, ignore the memcache above, it's already taken care of in query()
	$result = query($qry, $params);
	
	// If the method exists
	if (count($result)==1 && !$like)
	{		
		if ($post) $value = $result[0]['post'];
		else $value = $result[0]['method'];		
		return $value;
	}
	else
	{
		if ($like) return $result;
		else return false;
	}
}

function cache_file($name,$text)
{
	$handle = fopen($name, "w");
	fwrite($handle, $text);
	fclose($handle);
}

function catch_output($m)
{
	ob_start();
	eval($m);
	$result = ob_get_contents();
	ob_end_clean();
	return $result;
}

?>