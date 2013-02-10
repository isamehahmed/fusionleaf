<?php

$total_pages = 7;

// Define variables for PHP and the CMS
require_once('_hidden/php_script/define.php');

// This prevents the session from having problems on first login
ini_set('session.name', 'FLSETUP');

if(!isset($_SESSION)) session_start();

function cleanUp()
{
	unset($_SESSION);
	unset($_POST);
	session_destroy();
	session_start();
}

function final_action()
{
	if (isset($_SESSION['step'])) unset($_SESSION['step']);
	if (isset($_SESSION['finish'])) unset($_SESSION['finish']);

	$set = new file_array(CMS_FILE_SITE);
	foreach ($_SESSION as $key=>$val)
	{
		$set->add($key,$val);
	}
	$set->add('recorded_root',$_SERVER['DOCUMENT_ROOT']);

	if ($set->get('db_database')===false)
	{
		if ($set->get('recorded_domain')===false) $site_n = $_SERVER['HTTP_HOST'];
		else
		{
			$arr = explode('.',$set->get('recorded_domain'));
			if (count($arr)==3) $site_n = $arr[1];
			else $site_n = $_SERVER['HTTP_HOST'];
		}

		// Remove any periods or dashes
		$site_n = str_replace(array('.','-'),'',$site_n);

		// If the database name is too long (SQL usernames are limited to 16 chars), take a substring
		if (strlen($site_n)>=12) $db_name = substr($site_n,0,11);
		else $db_name = $site_n;

		// Append a random character to make it hard to brute force the SQL accounts
		$db_name = $db_name.rand(1,9999);
		$set->add('db_database',$db_name);

		$set->add('db_write_username',$db_name.'w');
		$set->add('db_write_password',md5(uniqid(rand(), TRUE)));
		$set->add('db_read_username',$db_name.'r');
		$set->add('db_read_password',md5(uniqid(rand(), TRUE)));
	}
	if ($set->get('unique_id')===false)
	{
		$set->add('unique_id','93a0f790450c2d24f07b8d59cf52c891');
	}

	cleanUp();
	header("Location: index.php");
	exit;
}

function build_content($arr)
{
	global $total_pages;
	if (count($arr)==5)
	{
		$title = $arr[0]. ' ('.$_SESSION['step'].'/'.$total_pages.')';
		$instructions = $arr[1];
		$setting = $arr[2];
		$setting_id = $arr[3];
		if (isset($_SESSION[$setting_id])) $default_val = $_SESSION[$setting_id];
		else $default_val = $arr[4];

		$default_val = htmlentities($default_val, ENT_QUOTES, "UTF-8");

		if (strpos($setting_id,'password')!==false) $type = 'password';
		else $type = 'text';

		return <<< OUTPUT
			<h3>{$title}</h3><br />
			<p>{$instructions}</p>
			<br />
			<p><b>{$setting}</b></p><input type="{$type}" id="{$setting_id}" name="{$setting_id}" 
			value="{$default_val}" tabindex="1" />
OUTPUT;
	}
	else if (count($arr)==2)
	{
		$title = $arr[0]. ' ('.$_SESSION['step'].'/'.$total_pages.')';
		$instructions = $arr[1];
		return <<< OUTPUT
			<h3>{$title}</h3><br />
			<p>{$instructions}</p>
OUTPUT;
	}
}

if (isset($_POST['start_over']))
{
	cleanUp();
}

$set = new file_array(CMS_FILE_SITE);

if (isset($_POST))
{
	if (isset($_POST['dummy_optional'])) unset($_POST['dummy_optional']);

	if (isset($_POST['finish']))
	{
		final_action();
	}
	else if (isset($_SESSION['step']))
	{
		if (isset($_POST['submit_n'])) $_SESSION['step']=intval($_POST['submit_n']);
		else if (isset($_POST['submit_p'])) $_SESSION['step']=intval($_POST['submit_p']);
	}
	
	if (isset($_POST['submit_p'])) unset($_POST['submit_p']);
	else if (isset($_POST['submit_n'])) unset($_POST['submit_n']);
	else if (isset($_POST['start_over'])) unset($_SESSION['start_over']);
	else if (isset($_POST['new_db']))
	{
		
		$set->del('setup');
		$set->del('db_database');
		unset($_POST['new_db']);
		unset($_SESSION['setup']);

	}
	else if (!isset($_POST['finish'])) $_SESSION['step']=1;
	
	foreach($_POST as $key=>$val) $_SESSION[$key]=$val;
}

if (!isset($_SESSION['step'])) $_SESSION['step']=1;
else
{
	if ($_SESSION['step'] > count($_SESSION)) $_SESSION['step']=1;
}

if ($_SESSION['step']==1)
{	
	if (file_exists(CMS_FILE_SITE))
	{
		$_SESSION = $set->grab();
		$_SESSION['step']=1;
	}
}

$next = '<button tabindex="2" style="float: left;" id="nothing" class="btn btn-primary" type="submit" name="submit_n" value="'.($_SESSION['step']+1).'" title="Click once to go to the next page">Next</button>';
$previous = '<button tabindex="3" id="nothing" class="btn" type="submit" name="submit_p" value="'.($_SESSION['step']-1).'" title="Click once to go to the previous page">Previous</button>';
$over = '<button tabindex="4" style="float: right;" id="nothing" class="btn btn-danger" type="submit" name="start_over" title="Click once to start over">Start Over</button>';
$new_db = '<div class="buttons"><button tabindex="4" style="float: right;" id="nothing" class="btn btn-success" type="submit" name="new_db" title="Click once to create a new database">New Database</button></div><br />';
$finish = '';

switch ($_SESSION['step']) {
case 1:

if ($set->get('setup')!==false)
{
	$mysqli = @new mysqli($_SESSION['db_host'], $_SESSION['db_root_username'],$_SESSION['db_root_password'], $_SESSION['db_database']);

	if ($mysqli->connect_error) $msg = '';
	else $msg = '<br /><br /><b>*** An existing database was already found! It will be used for your new website. ***</b>'.$new_db;
} else $msg = '';

	$content = build_content(
	array('Welcome to FusionLeaf',
	"Thank you for choosing FusionLeaf! Let's jump right in. On the next couple of pages, you will be asked 
		a series of questions. Answer each one and your website will be set up in no time! ".$msg,
	'What is the domain name of your website?',
	'recorded_domain',
	$_SERVER['HTTP_HOST']));

	$previous=''; break;
case 2:
	$content = build_content(array('Choose a Title',
	'Every site needs a good title. Pick something that will be searchable.',
	'What is the title of your website?',
	'site_title',
	''));break;

case 3:
	$content = build_content(array('Choose a Database',
	'FusionLeaf is designed to work very well with MySQL. An IP address or hostname is required to connect to the database.',
	'On which server is your MySQL database location? (Default is 127.0.0.1)',
	'db_host',
	'127.0.0.1'));break;

case 4:
	$content = build_content(array('Database Port',
	'MySQL usually listens on a port. A port is essentially the room number if your database server was a giant hotel.',
	'What is the MySQL port? (Default is 3306)',
	'db_port',
	3306));break;

case 5:
	$content = build_content(array('Database Admin',
	'In order to connect and use MySQL, an account with administrative privileges is required. ',
	'What is the MySQL username?',
	'db_root_username',
	'root'));break;

case 6:
	$content = build_content(array('Database Admin Password',
	'In order to connect and use MySQL, an account with administrative privileges is required. ',
	'What is the MySQL password?',
	'db_root_password',
	''));break;

default:
$content = build_content(array('Finished!','Your website is ready for use!'));
$finish = '<button style="float: left;" tabindex="2" id="nothing" class="btn btn-success" type="submit" name="finish" title="Click once to finish">Finish</button>';
$next='';
}

echo <<< OUTPUT
<!DOCTYPE html>
<html lang="en">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
<title>FusionLeaf Setup</title>
<META NAME="ROBOTS" CONTENT="NOINDEX, NOFOLLOW">
<link rel="stylesheet" type="text/css" media="screen" href="/style/style.css" />
<link href="/inc/bootstrap/css/bootstrap.min.css" rel="stylesheet" class="simpleswitch">

    <style>

        body {

        padding-top: 60px; /* 60px to make the container go all the way to the bottom of the topbar */

        padding-bottom: 40px;

      }



    </style>



</head>

<body>

<div class="row-fluid">
	<div class="span4"></div>
	<div class="span4 well"  style="text-align:center;">

	<form id="setupfrm" onsubmit="return validateForm()" method="post">
	{$content}
	<br /><br />
	<div class="buttons">{$finish}{$next}{$previous}{$over}</div>
	<div class="clear"></div>
	<input type="text" style="visibility:hidden;display:none;" name="dummy_optional"></input>
	</form>

</div>
	<div class="span4"></div>
</div>


<!--<table width="100%" height="100%"><tr>
<td align="center" valign="middle" style="padding: 50px;">



</td>
</tr>
</table>-->

<script>
var fi = document.getElementsByTagName("input");

    for (var i = 0 ; i < fi.length ; i++)
    {
	var opt1 = fi[i].getAttribute("name");
        if (opt1 != "dummy_optional")
        {
		fi[i].focus();
        }
    }

function validateForm()
{	
    var tbs = document.getElementsByTagName("input");
    for (var i = 0 ; i < tbs.length ; i++)
    {
	var opt1 = tbs[i].getAttribute("name");
	var opt2 = tbs[i].getAttribute("type");
        if (opt1.indexOf("_optional") == -1 && opt2.toLowerCase() != "hidden")
        {
            if (tbs[i].value==null || tbs[i].value=="")
            {
            	alert("Please fill out all the fields");
		return false;
            }
        }
    }
}
</script>

<div class="container-fluid">

	<hr>

	<footer>

		<p class="pull-left">Powered by FusionLeaf </p>

		<div class="pull-right">PC Precision LLC  &#169; 2012 </div>

	</footer>

</div>


<div style="padding-top: 10px;"></div></body>

</html>
OUTPUT;

//print_r($_SESSION).'<br /><br />';
//if (isset($_POST)) print_r($_POST);

?>