# FusionLeaf Stack In-Depth #

**FusionLeaf Stack** allows **FusionLeaf CMS** and many other PHP applications to run on a Windows computer. **FusionLeaf Stack** is a package of open source software that includes a web server (Nginx), database (MySQL), PHP language, and object caching system (Memcached). Once extracted, **FusionLeaf Studio.exe** can configure, start, monitor, and stop all of the software listed above so you have total control over each one.

## The Difference ##
  * **Simple:** No installation required
  * **Fast:** Nginx is quick, lightweight, and powerful
  * **Configurable:** Supports load balancing, provides a GUI to control each of the applications individually
  * **Flexible:** Supports multiple websites through dynamic configurations for PHP and Nginx
  * **Automation for PHP:** Quickly install PEAR and PHPUnit without hassle
  * **Free:** Licensed under the Apache License, Version 2.0

## Instructions ##
  1. Extract the contents to any folder
  1. Run FusionLeaf Studio.exe
  1. Click Start to turn on MySQL, Nginx, Memcached, and the PHP gateway with the default settings
  1. Test the configuration by clicking Browser -> http://localhost

## Popular Application Testing (Drupal, WordPress, SQL Buddy, phpMyAdmin, etc.) ##
  1. Run FusionLeaf Studio.exe
  1. Click **Automation** -> **FusionLeaf** -> **Remove CMS from Localhost folder** -> Click **OK**
  1. Click **Open Folder** -> **Webroot**
  1. Double click on the **localhost** folder
  1. Delete **index.php**
  1. Copy the extracted files from any PHP application into the **localhost** folder
  1. Click Start
Note: It is best to start with SQL Buddy so you can change the default database password

## Default MySQL Database Settings ##
  * Database Name: test
  * Username: root
  * Password: (blank)

## Optional Startup Parameters ##

The following parameters can be specified when you start **FusionLeaf Studio.exe**:
```
/help			Show Help
/minimize		Minimize application
/startall		Start all services
/php_thread:#		Set PHP with # thread(s)
/php_max_requests:#	Set PHP with # of max requests before recycle
/php_port:#		Set PHP port
/nginx_port:#		Set Nginx port
/mysql_port:#		Set MySQL port
/memcached_port:#	Set Memcached port
/start_nginx		Start Nginx
/start_php		Start PHP
/start_mysql		Start MySQL
/start_memcached	Start Memcached
```
## Folders ##
  * \app - contains binaries for MySQL, Nginx, Memcached, PHP, PEAR for PHP, and PHPUnit for PHP
  * \config - contains custom configurations for MySQL (my.ini), Nginx (nginx.conf), and PHP (php.ini)
  * \doc - contains changelog.txt with version numbers
  * \src - contains C# source code for FusionLeaf Studio.exe
  * \weblog - future location for all CMS logs
  * \webroot - contains the web file structure used by Nginx and FusionLeaf CMS

## Files ##
  * LICENSE.txt - contains the Apache v2.0 license under which FusionLeaf Studio is licensed
  * NOTICE.txt - contains the software aggregated with FusionLeaf Studio
  * README.txt - this file
  * RELEASE.txt - the version number

## Included Software ##
  * MySQL
  * Nginx
  * Memcached
  * PHP
  * Apache
  * PEAR for PHP
  * PHPUnit for PHP
  * FusionLeaf Studio.exe
  * FusionLeaf CMS

## Notes ##
  * MySQL binaries are unmodified, but exclude files to make the distribution smaller
  * Nginx binaries are unmodified
  * PHP binaries are unmodified, but exclude files to make the distribution smaller
  * Apache binaries are unmodified, but exclude files to make the distribution smaller

## Compatibility ##
  * The \app folder holds official binaries so the contents of each folder (mysql,nginx,php,apache) can be deleted and filled with binaries downloaded from their respective sites (mysql.com,nginx.org,php.net,httpd.apache.org)

## Configuration ##
  * The \config folder holds highly test and dynamic configurations for MySQL, Nginx, PHP, Apache
  * Each configuration has variables which are replaced by values provided by FusionLeaf Studio.exe
  * Any changes made to the configurations will apply the next time MySQL, Nginx, PHP, Apache are started

## Technical Notes ##
  * Nginx uses a highly dynamic configuration which supports multiple websites without restarting itself
  * The \webroot folder contains two websites: localhost (\webroot\localhost) and www.fusionleaf.net (\webroot\fusionleaf\net\www)
  * index.php in \webroot\fusionleaf\net folder redirects domains without the www prefix to include the www prefix: fusionleaf.net redirects to www.fusionleaf.net

## Website Simulation ##
To simulate a domain like www.fusionleaf.net, add the domain name to your system hosts file to view it locally:
  1. Copy C:\windows\system32\drivers\etc\hosts to your desktop
  1. Open the hosts file in Notepad
  1. Add the following lines to the bottom of the hosts file:
    * 127.0.0.1		fusionleaf.net
    * 127.0.0.1		www.fusionleaf.net
  1. Save the modified hosts file
  1. Copy the modified hosts file back to: C:\windows\system32\drivers\etc\hosts
  1. Close your web browser if open
  1. Run FusionLeaf Studio.exe
  1. Click the Start button
  1. Open your web browser to: http://fusionleaf.net
  1. The browser will redirect to: http://www.fusionleaf.net
  1. The following will display on the page: Hello FusionLeaf world!

## Quick Solutions ##
  * Unblock all files on Windows Vista or Windows 7 if prompted
  * Allow MySQL, Nginx, Memcached, PHP, Apache through the firewall if prompted

## Required Software ##
**Note:** **FusionLeaf Stack** requires the following software to be installed. Most computers already have the C++ Runtime and .NET Framework 2.0.
  * Microsoft 2008 C++ Runtime (x86) - http://www.microsoft.com/en-us/download/details.aspx?id=29
  * Microsoft 2008 C++ Runtime (x64) - http://www.microsoft.com/en-us/download/details.aspx?id=15336
  * Microsoft .NET Framework 2.0 Service Pack 2 - http://www.microsoft.com/en-us/download/details.aspx?id=1639