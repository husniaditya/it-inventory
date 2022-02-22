<?php
session_start();
ob_start();

include("global.php");
require "KoolAjax/koolajax.php";
require "KoolGrid/koolgrid.php";
require "KoolComboBox/koolcombobox.php";
require "KoolCalendar/koolcalendar.php";

OpenDB();
if (!IsUserAlreadyLogin() && stripos($_SERVER['PHP_SELF'], "login.php") == false) {
    header("Location: login?url=" . $_SERVER['PHP_SELF']);
    return;
}

$koolajax->scriptFolder = "KoolAjax";
?>
<html lang="en">
    <head>
        <meta charset="utf-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <meta name="description" content="">
        <meta name="author" content="">
        <title>WIS | Bonded Zone</title>
        <link rel="icon" href="images/icon.png">   
        <link href="dist/css/sb-admin-2.css" rel="stylesheet">
        <link rel="stylesheet" href="datatables/dataTables.bootstrap.css"/>
        <link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">
        <link href="vendor/metisMenu/metisMenu.min.css" rel="stylesheet">
        <link href="vendor/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css">

        <style type="text/css">
        .kotak{ 
            margin-top: 50px;
            border: 1px solid #ddd;
            border-radius: 20px;
        }

        .kotak .input-group{
            margin-bottom: 20px;
        }

        .color-lightbrown{
            background-color: #c9c4bf;
        }

        .color-navy{
            background-color: #28324B;
        }

        .color-orange{
            background-color: #ff9a2e;
        }

        body{
            background-color: #c9c4bf;
            font-family:Trebuchet MS;
        }

        hr{
            border-color: #a8a39e;
        }

        a{
            color: #3D3D3D;
            transition: all .3s ease-in-out;
        }
        a:hover { 
            transform: translateX(8px);
        }
        .glow{
            transition: all .3s ease-in-out;
        }
        .glow:hover { 
            transform: scale(1.03);
        }
        </style>
        
    </head>
    <body>
        <?php 
        echo $koolajax->Render();
        if (IsUserAlreadyLogin() && stripos($_SERVER['PHP_SELF'], "login.php") == false) 
        {
        ?>     
            <div id="wrapper">
                <nav class="navbar navbar-default navbar-static-top" id="sidebar" role="navigation" style="border-color: transparent;">
                    <div class="navbar-header">
                        <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                            <span class="sr-only">Toggle navigation</span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                        </button>                
                        <a class="navbar-brand" href="default">WIS | Bonded Zone</a>
                    </div>

                    <ul class="nav navbar-top-links navbar-right">
                        <li align="center">
                            <a href="login"> <i class="fa fa-power-off"></i> <br><small>Logout</small></a>
                        </li>
                    </ul>
                </nav>
                <div class="sidebar" role="navigation">
                    <div class="sidebar-nav navbar-collapse">
                        <ul class="nav" id="side-menu">                        
                            <li><a href="default"><i class="glyphicon glyphicon-home"></i> Home</a></li>
                            <li><a href="bcPemasukanBrg">BC Pemasukan Barang</a></li>
                            <li><a href="bcPengeluaranBrg">BC Pengeluaran Barang</a></li>
                            <li><a href="bcWIP">BC Posisi Barang Dalam Proses (WIP)</a></li>
                            <li><a href="bcMutasiBahanBaku">BC Pertanggung Jawaban Mutasi Bahan Baku</a></li>
                            <li><a href="bcMutasiBrgJadi">BC Pertanggung Jawaban Mutasi Barang Jadi</a></li>
                            <li><a href="bcMutasiMesin">BC Pertanggung Jawaban Mutasi  Mesin & Alat</a></li>                                
                            <li><a href="bcMutasiBrgScrap">BC Pertanggung Jawaban Mutasi Barang Scrap</a></li>
                        </ul>
                    </div>
                </div>
        <?php
        }
        ?>
                       



