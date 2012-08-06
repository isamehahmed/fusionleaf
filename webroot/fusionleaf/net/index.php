<?php
// Permanent redirection
header("HTTP/1.1 301 Moved Permanently");
if (isset($_SERVER['HTTP_HOST'])) header("Location: http://www.".$_SERVER['HTTP_HOST']);
exit();
?>