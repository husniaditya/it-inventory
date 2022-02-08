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
    header("Location: login.php?url=" . $_SERVER['PHP_SELF']);
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

        <title>CAS - Bonded Zone PT. Baramuda Bahari</title>
        <link rel="icon" href="images/Icon.ico">   

        <!-- Bootstrap Core CSS -->
        <link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">

        <!-- MetisMenu CSS -->
        <link href="vendor/metisMenu/metisMenu.min.css" rel="stylesheet">

        <!-- Custom CSS -->
        <link href="dist/css/sb-admin-2.css" rel="stylesheet">

        <!-- Custom Fonts -->
        <link href="vendor/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css">
        
        <!-- DataTables Lookup -->        
        <link rel="stylesheet" href="datatables/dataTables.bootstrap.css"/>
        
    </head>
    <body>
        <?php echo $koolajax->Render(); ?>        
        <div id="wrapper">
            <!-- Navigation -->
            <nav class="navbar navbar-default navbar-static-top" role="navigation" style="margin-bottom: 0">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>                
                <?php
                if (IsUserAlreadyLogin() && stripos($_SERVER['PHP_SELF'], "login.php") == false) {
                    ?>
                    <a class="navbar-brand" href="default.php">CAS - Bonded Zone PT. Baramuda Bahari</a>
                </div>
                <!-- /.navbar-header -->

                <ul class="nav navbar-top-links navbar-right">
                        <!-- /.dropdown user -->
                        <li class="dropdown">
                            <a class="dropdown-toggle" data-toggle="dropdown" href="#">
                                <i class="fa fa-user fa-fw"></i> <i class="fa fa-caret-down"></i>
                            </a>
                            <ul class="dropdown-menu dropdown-user">
                                <li><a href="login.php"><i class="fa fa-sign-out fa-fw"></i> Logout</a>
                                </li>
                            </ul>
                            <!-- /.dropdown-user -->
                        </li>
                    </ul>

                    <div class="navbar-default sidebar" role="navigation">
                        <div class="sidebar-nav navbar-collapse">
                            <ul class="nav" id="side-menu">                        
                                <li>
                                    <a href="default.php"><i class="glyphicon glyphicon-home"></i> Home</a>
                                </li>
                                <li>
                                    <a href="bcPemasukanBrg.php">BC Pemasukan Barang</a>                            
                                </li>
                                <li>
                                    <a href="bcPengeluaranBrg.php">BC Pengeluaran Barang</a>
                                </li>
                                <li>
                                    <a href="bcWIP.php">BC Posisi Barang Dalam Proses (WIP)</a>
                                </li>
                                <li>
                                    <a href="bcMutasiBahanBaku.php">BC Pertanggung Jawaban Mutasi Bahan Baku</a>
                                </li>
                                <li>
                                    <a href="bcMutasiBrgJadi.php">BC Pertanggung Jawaban Mutasi Barang Jadi</a>
                                </li>                                            
                                <li>
                                    <a href="bcMutasiMesin.php">BC Pertanggung Jawaban Mutasi  Mesin & Alat</a>
                                </li>                                
                                <li>
                                    <a href="bcMutasiBrgScrap.php">BC Pertanggung Jawaban Mutasi Barang Scrap</a>
                                </li>
                            </ul>
                        </div>
                        <!-- /.sidebar-collapse -->
                    </div>
                    <!-- /.navbar-static-side -->

                    <?php
                }
                ?>    
            </nav>
                       



