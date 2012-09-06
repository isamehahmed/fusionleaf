<?php
// ************************** Globals **************************
// Define variables for PHP and the CMS
require_once('_hidden/php_script/define.php');

// ************************** Locals **************************
// Either setup the website for the first time or load the database/site settings
initial_setup();

// Ensure the database is configured for the correct environment
db_prepare();

// Connect to memcache
if (extension_loaded('memcache') && constant_test('SETTING_MEMCACHE','enable'))
{
	// Connect to memcache
	$memcache = new Memcache;

	if (!@$memcache->connect(MEMCACHE_SERVER, MEMCACHE_PORT)) unset($memcache);
}

// Get the secure DB functions
eval(simpleDB("SELECT method FROM php_methods WHERE name='cms_database' LIMIT 1",true));

// Load and evaluate the 3 CMS preloads
$qry = "SELECT method,name,post FROM php_methods WHERE name=? OR name=? OR name=? ORDER BY name LIMIT 3";
$params = array('cms_preload_error','cms_preload_define','cms_preload_session');
$result = query($qry, $params);
foreach($result as $row) { eval($row['method']); }

// ************************** Pager **************************
// Uncomment this to recache each page load
//$_SESSION['recache']=true;

// If the indexinc.php doesn't exist or an admin called a recache
if (!file_exists(CMS_FILE_INCLUDE) || isset($_SESSION['recache']))
{
	// Unset recache so it is only called once
	if (isset($_SESSION['recache'])) unset($_SESSION['recache']);

	$result_define = query("SELECT name, current_value FROM site_setting", array());
	foreach ($result_define as $row)
	{
		define($row['name'],$row['current_value'],true);
	}

	$result_define = query("SELECT name, color FROM site_color", array());
	foreach ($result_define as $row)
	{
		define($row['name'],$row['color']);
	}

	cache_file(CMS_FILE_INCLUDE, catch_output(method_retrieve('cms_backbone')));
	cache_file('js'.DIR_SEP.'javascript.js', method_retrieve("script_javascript"));
	cache_file('js'.DIR_SEP.'jquery.js', method_retrieve("script_jquery"));

	$writing = '';
	$writing .= method_retrieve('style_default');
	$writing .= NEWLINE;
	$writing .= '$output = <<< OUTPUT';
	$writing .= NEWLINE;
	$writing .= NEWLINE;
	$writing .= method_retrieve('style_html');
	$writing .= NEWLINE;
	$writing .= NEWLINE;
	$writing .= 'OUTPUT;';
	$writing .= NEWLINE;
	$writing .= 'echo $output;';
	$writing .= NEWLINE;
	$writing .= NEWLINE;

	cache_file('style'.DIR_SEP.'style.css', catch_output($writing));
}
include CMS_FILE_INCLUDE;

// Page load time output (won't load on Style.css stuff)
if (function_exists('br') && function_exists('isGroupMember'))
{
	if (isGroupMember(1) && constant_test('SETTING_PHP_VARIABLES','show'))
	{
		echo '<div class="container-fluid">';
		echo PtimerStop();
		echo catch_output(method_retrieve('cms_verbose'));
		echo '</div>';
	}
}

// ************************** Clean **************************
// Keep the tmp folder clean of error logs
//if (file_exists(CMS_ERROR_PHP)) unlink(CMS_ERROR_PHP);
//if (file_exists(ini_get('error_log'))) unlink(ini_get('error_log'));

?>