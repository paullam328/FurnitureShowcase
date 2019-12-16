# FurnitureShowcase
A  showcase of furniture, extracted info from mySQL database using REST API called by PHP, aka. Unity Full-Stack Development.
Also featuring: In-game user interface, navigation and cursor system

## PHP server: 
You need to install PHP in your computer first, then set the PHP directory to environmental path.
Then, run the command: php -S localhost: 8000 at the directory Assets\Scripts\php.
The server will be deployed at localhost port 8000.

## SQL server:
This is a local SQL server, so table isn't available publicly.  Ran by MySQL Workbench at port 3306.
Hostname, servername and password are in Assets\Scripts\php\ServerHandler.php.
SQL queries to build the table and insert the rows are in Assets\Scripts\sql\sql_cmds.sql
