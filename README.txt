          *********************
          * FusionLeaf Studio *
          *      v1.0.4.0     *
          *     2012/08/05    *
          *********************

Available from: http://sourceforge.net/projects/fusionleaf
Homepage: http://www.fusionleaf.com

This distribution contains the following:
* MySQL
* Nginx
* PHP
* Memcached
* FusionLeaf Studio.exe
* FusionLeaf CMS

The source for FusionLeaf Studio.exe is in the folder: \src

Instructions:
1. Extract the contents to any folder
2. Run FusionLeaf Studio.exe
3. Click Start to turn on MySQL, Nginx, and the PHP gateway with the default settings
4. Test the configuration by clicking Browser -> http://localhost

Folders:
\app - contains binaries for MySQL, Nginx, and PHP
\config - contains custom configurations for MySQL (my.ini), Nginx (nginx.conf), and PHP (php.ini)
\doc - contains changelog.txt with version numbers for each application included
\src - contains C# source code for FusionLeaf Studio.exe
\webroot - contains the web file structure used by Nginx and FusionLeaf CMS

Files:
* LICENSE.txt - contains the Apache v2.0 license under which FusionLeaf Studio is licensed
* NOTICE.txt - contains the software aggregated with FusionLeaf Studio
* README.txt - this file

Notes:
* MySQL binaries are unmodified, but exclude files to make the distribution smaller 
* Nginx binaries are unmodified
* PHP binaries are unmodified, but exclude files to make the distribution smaller 

Compatibility:
* The \app folder holds official binaries so the contents of each folder (mysql,nginx,php) can be 
deleted and filled with binaries downloaded from their respective sites (mysql.com,nginx.org,php.net)

Configuration:
* The \config folder holds highly test and dynamic configurations for MySQL, Nginx, and PHP
* Each configuration has variables which are replaced by values provided by FusionLeaf Studio.exe
* Any changes made to the configurations will apply the next time MySQL, Nginx, or PHP are started

Technical Notes:
* Nginx uses a highly dynamic configuration which supports multiple websites without restarting itself
* The \webroot folder contains two websites: localhost (\webroot\localhost) and www.fusionleaf.net (\webroot\fusionleaf\net\www)
* index.php in \webroot\fusionleaf\net folder redirects domains without the www prefix to include 
the www prefix: fusionleaf.net redirects to www.fusionleaf.net

Website Testing:
* www.fusionleaf.net can be added to your hosts file and viewed locally
1. Copy C:\windows\system32\drivers\etc\hosts to your desktop
2. Open the hosts file in Notepad
3. Add the following lines to the bottom of the hosts file:
127.0.0.1		fusionleaf.net
127.0.0.1		www.fusionleaf.net
4. Save the modified hosts file
5. Copy the modified hosts file back to: C:\windows\system32\drivers\etc\hosts
6. Close your web browser if open
7. Run FusionLeaf Studio.exe
8. Click the Start button
9. Open your web browser to: http://fusionleaf.net
* The browser will redirect to: http://www.fusionleaf.net
* The following will display on the page: Hello FusionLeaf world!

* Try testing FusionLeaf Studio by dropping the files from http://sqlbuddy.com or http://www.mybb.com into the \webroot\localhost folder

Quick Solutions:
* Unblock all files on Windows Vista or Windows 7 if prompted
* Allow MySQL, Nginx, and PHP through the firewall if prompted