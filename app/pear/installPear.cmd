@ECHO OFF

ECHO Press enter to install PEAR for PHP
PAUSE

REM php go-pear.phar
pear update-channels
pear upgrade
pear channel-discover pear.phpunit.de
pear channel-discover pear.symfony-project.com
pear clear-cache
pear install --alldeps phpunit/PHPUnit

ECHO Installation complete
PAUSE