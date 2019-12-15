<?php
    $hostname = 'localhost';
    $username = 'showcasedemo';
    $password = 'demoShowcase';
    $database = 'showcasedemo';

    $secretKey = "mySecretKey"; # change this val to match val stored in C#

    #connect:
    try {
        $dbh = new PDO('mysql:host='. $hostname . ';dbname='. $database, $username, $password);
    } catch (PDOException $e) {
        echo '<h1>An error has occured.</h1><pre>', $e->getMessage() ,'</pre>';
    }

    #get data:
    if (isset($_POST['id']))
    {
        $id = $_POST['id'];
        $val = $dbh->prepare('SELECT * FROM furniture WHERE id=:id');
            try {
                $val->execute($_POST);
                $sth = $val->fetchAll(PDO::FETCH_ASSOC); 
                print_r($sth);
            } catch (Exception $e) {
                echo '<h1>An error has occured.</h1><pre>', $e->getMessage() ,'</pre>';
            }
    }
    else
    {
        echo 'no id supplied';
    }
?>