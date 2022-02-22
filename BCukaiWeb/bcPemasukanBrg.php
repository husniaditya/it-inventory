<?php
require("header.php");
require "Lib/tcpdf/PDF.php";

if ($koolajax->isCallback == false)
    unset($_SESSION["searchQuery"]);
    $jnsA="";
    $jnsZ="";

    $jns_inputA = BuildComboBox($db_con, "SELECT jnsp AS jnsA, remmark FROM jnsp;", "jnsA", GetPOST("jnsA", $jnsA), true, false, true);
    $jns_inputZ = BuildComboBox($db_con, "SELECT jnsp AS jnsZ, remmark FROM jnsp;", "jnsZ", GetPOST("jnsZ", $jnsZ), true, false, true);
?>

    <!-- Modal -->
    <!-- Supplier A-->
    <div class="modal fade" id="mdlSupA" tabindex="-1" role="dialog" aria-labelledby="mdlSupA" aria-hidden="true">
        <div class="modal-dialog" style="width:800px">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                    <h4 class="modal-title" id="mdlSupA">Lookup Supplier</h4>
                </div>
                <div class="modal-body">
                    <table id="lookupSA" class="table table-bordered table-hover table-striped">
                        <thead>
                            <tr>
                                <th>Kode</th>
                                <th>Supplier</th>
                            </tr>
                        </thead>
                        <tbody>
                            <?php
                           $sql = mysql_query('SELECT sub AS Kode, name AS Supplier FROM sub WHERE group_ = 1 AND aktif = 1;');
                            while ($r = mysql_fetch_array($sql)) {
                                ?>
                                <tr class="pilihSA" datasupl="<?php echo $r['Kode']; ?>">
                                    <td><?php echo $r['Kode']; ?></td>
                                    <td><?php echo $r['Supplier']; ?></td>
                                </tr>
                                <?php
                            }
                            ?>
                        </tbody>
                    </table>  
                </div>
            </div>
        </div>
    </div>

    <!-- Supplier Z-->
    <div class="modal fade" id="mdlSupZ" tabindex="-1" role="dialog" aria-labelledby="mdlSupZ" aria-hidden="true">
        <div class="modal-dialog" style="width:800px">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                    <h4 class="modal-title" id="mdlSupZ">Lookup Supplier</h4>
                </div>
                <div class="modal-body">
                    <table id="lookupSZ" class="table table-bordered table-hover table-striped">
                        <thead>
                            <tr>
                                <th>Kode</th>
                                <th>Supplier</th>
                            </tr>
                        </thead>
                        <tbody>
                            <?php
                           $sql = mysql_query('SELECT sub AS Kode, name AS Supplier FROM sub WHERE group_ = 1 AND aktif = 1;');
                            while ($r = mysql_fetch_array($sql)) {
                                ?>
                                <tr class="pilihSZ" datasupl="<?php echo $r['Kode']; ?>">
                                    <td><?php echo $r['Kode']; ?></td>
                                    <td><?php echo $r['Supplier']; ?></td>
                                </tr>
                                <?php
                            }
                            ?>
                        </tbody>
                    </table>  
                </div>
            </div>
        </div>
    </div>


    <!-- Doc A -->    
    <div class="modal fade" id="mdlDocA" tabindex="-1" role="dialog" aria-labelledby="mdlDocA" aria-hidden="true">
        <div class="modal-dialog" style="width:800px">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                    <h4 class="modal-title" id="mdlDocA">Lookup Doc Bea Cukai</h4>
                </div>
                <div class="modal-body">
                    <table id="lookupDA" class="table table-bordered table-hover table-striped">
                        <thead>
                            <tr>
                                <th>No Dokumen</th>
                                <th>Tanggal</th>
                                <th>Keterangan</th>
                            </tr>
                        </thead>
                        <tbody>
                            <?php
                            for($i = 0; $i < count($_SESSION['docSession']); $i++){
                                ?>
                                 <tr class="pilihDA" datadoc="<?php echo $_SESSION['docSession']['NoDokumen']; ?>">
                                    <td><?php echo $_SESSION['docSession'][$i]['NoDokumen']; ?></td>
                                    <td><?php echo $_SESSION['docSession'][$i]['Tanggal']; ?></td>
                                    <td><?php echo $_SESSION['docSession'][$i]['Keterangan']; ?></td>
                                </tr>
                                <?php
                            }
                            ?> 
                        </tbody>
                    </table>  
                </div>
            </div>
        </div>
    </div>

    <!-- Doc Z -->    
    <div class="modal fade" id="mdlDocZ" tabindex="-1" role="dialog" aria-labelledby="mdlDocZ" aria-hidden="true">
        <div class="modal-dialog" style="width:800px">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                    <h4 class="modal-title" id="mdlDocZ">Lookup Doc Bea Cukai</h4>
                </div>
                <div class="modal-body">
                    <table id="lookupDZ" class="table table-bordered table-hover table-striped">
                        <thead>
                            <tr>
                                <th>No Dokumen</th>
                                <th>Tanggal</th>
                                <th>Keterangan</th>
                            </tr>
                        </thead>
                        <tbody>
                             <?php
                            for($i = 0; $i < count($_SESSION['docSession']); $i++){
                                ?>
                                 <tr class="pilihDZ" datadoc="<?php echo $_SESSION['docSession']['NoDokumen']; ?>">
                                    <td><?php echo $_SESSION['docSession'][$i]['NoDokumen']; ?></td>
                                    <td><?php echo $_SESSION['docSession'][$i]['Tanggal']; ?></td>
                                    <td><?php echo $_SESSION['docSession'][$i]['Keterangan']; ?></td>
                                </tr>
                                <?php
                            }
                            ?> 
                        </tbody>
                    </table>  
                </div>
            </div>
        </div>
    </div>

    <!-- Persediaan A -->    
    <div class="modal fade" id="mdlInvA" tabindex="-1" role="dialog" aria-labelledby="mdlInvA" aria-hidden="true">
        <div class="modal-dialog" style="width:800px">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                    <h4 class="modal-title" id="mdlInvA">Lookup Persediaan</h4>
                </div>
                <div class="modal-body">
                    <table id="lookupIA" class="table table-bordered table-hover table-striped">
                        <thead>
                            <tr>
                                <th>Kode</th>
                                <th>Persediaan</th>
                            </tr>
                        </thead>
                        <tbody>
                            <?php
                            $sql = mysql_query('SELECT bcin.inv AS Kode, inv.name AS Persediaan FROM (select distinct inv from bcmasuk) bcin left join inv on bcin.inv=inv.inv ;');
                            while ($r = mysql_fetch_array($sql)) {
                                ?>
                                <tr class="pilihIA" datainv="<?php echo $r['Kode']; ?>">
                                    <td><?php echo $r['Kode']; ?></td>
                                    <td><?php echo $r['Persediaan']; ?></td>
                                </tr>
                                <?php
                            }
                            ?>
                        </tbody>
                    </table>  
                </div>
            </div>
        </div>
    </div>

    <!-- Persediaan Z -->    
    <div class="modal fade" id="mdlInvZ" tabindex="-1" role="dialog" aria-labelledby="mdlInvZ" aria-hidden="true">
        <div class="modal-dialog" style="width:800px">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                    <h4 class="modal-title" id="mdlInvZ">Lookup Persediaan</h4>
                </div>
                <div class="modal-body">
                    <table id="lookupIZ" class="table table-bordered table-hover table-striped">
                        <thead>
                            <tr>
                                <th>Kode</th>
                                <th>Persediaan</th>
                            </tr>
                        </thead>
                        <tbody>
                            <?php
                            $sql = mysql_query('SELECT bcin.inv AS Kode, inv.name AS Persediaan FROM (select distinct inv from bcmasuk) bcin left join inv on bcin.inv=inv.inv ;'); while ($r = mysql_fetch_array($sql)) {
                                ?>
                                <tr class="pilihIZ" datainv="<?php echo $r['Kode']; ?>">
                                    <td><?php echo $r['Kode']; ?></td>
                                    <td><?php echo $r['Persediaan']; ?></td>
                                </tr>
                                <?php
                            }
                            ?>
                        </tbody>
                    </table>  
                </div>
            </div>
        </div>
    </div>
    <!-- modal -->
    
<div id="page-wrapper">   
    <div class="row">
        <div class="col-lg-12">
            <h1 class="page-header" style="font-size: 25px;">BC Pemasukan Barang</h1>
        </div>
    </div>

    <!-- /.search -->  
    <div class="row">
        <form method="post">	
            <div class="form-group" style="position: relative; left:20px;">
                <div class="row">
                    <div class="col-md-1">
                        <label for="varchar">Tanggal</label>
                    </div>
                    <div class="col-sm-2">
                        <?php echo(CreateDatePicker("tglAwal", "")); ?>                      
                    </div>
                    <div class="col-sm-2">
                        <?php echo(CreateDatePicker("tglAkhir", "")); ?>                       
                    </div>                    
                </div>
                <br />
                <div class="row">
                    <div class="col-md-1">
                        <label for="varchar">Supplier</label>
                    </div>
                    <div class="col-sm-2">
                        <div class="input-group input-group-sm">
                            <input type="text" class="form-control" name="txtSupA" id="txtSupA" />
                            <span class="input-group-btn">
                                <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#mdlSupA"><i class="glyphicon glyphicon-search"></i></button>
                            </span>  
                        </div>
                    </div>
                    <div class="col-sm-2">
                        <div class="input-group input-group-sm">
                            <input type="text" class="form-control" name="txtSupZ" id="txtSupZ"  />
                            <span class="input-group-btn">
                                <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#mdlSupZ"><i class="glyphicon glyphicon-search"></i></button>
                            </span>     
                        </div>
                    </div>                    
                    <div class="col-md-1">
                        <label for="varchar">Persediaan</label>
                    </div>
                    <div class="col-sm-2">
                        <div class="input-group input-group-sm">
                            <input type="text" class="form-control" name="txtInvA" id="txtInvA" />
                            <span class="input-group-btn">
                                <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#mdlInvA"><i class="glyphicon glyphicon-search"></i></button>
                            </span>  
                        </div>
                    </div>
                    <div class="col-sm-2">
                        <div class="input-group input-group-sm">
                            <input type="text" class="form-control" name="txtInvZ" id="txtInvZ"  />
                            <span class="input-group-btn">
                                <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#mdlInvZ"><i class="glyphicon glyphicon-search"></i></button>
                            </span>    
                        </div>
                    </div>  
                </div>
                <br />
                <div class="row">
                    <div class="col-md-1">
                        <label for="varchar">Doc. No Bea Cukai</label>
                    </div>
                    <div class="col-sm-2">
                        <div class="input-group input-group-sm">
                            <input type="text" class="form-control" name="txtDocA" id="txtDocA"  />
                         <!--   <span class="input-group-btn">
                                <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#mdlDocA"><i class="glyphicon glyphicon-search"></i></button>
                            </span>    
                         -->
                        </div>
                    </div>
                    <div class="col-sm-2">
                        <div class="input-group input-group-sm">
                            <input type="text" class="form-control" name="txtDocZ" id="txtDocZ"  />
                         <!--   <span class="input-group-btn">
                                <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#mdlDocZ"><i class="glyphicon glyphicon-search"></i></button>
                            </span> -->
                        </div>
                    </div>  
                    <div class="col-md-1">
                        <label for="varchar">Jenis Doc Pabean</label>
                    </div>
                    <div class="col-sm-2">
                        <?php echo $jns_inputA; ?>
                    </div>
                    <div class="col-sm-2">
                        <?php echo $jns_inputZ; ?>               
                    </div> 
                </div>
                <br /><br />
                <div class="row">       
                    <div class="col-sm-4 col-sm-offset-1">
                        <input id="btnPreview" name="btnPreview" type="submit" value="Preview" class="btn btn-primary">&nbsp;
                        <input id="btnCSV" name="btnCSV" type="submit" value="Export to Excel" class="btn btn-primary">&nbsp;
                        <input id="btnPDF" name="btnPDF" type="submit" value="Export to PDF" class="btn btn-primary">
                    </div> 
                </div>
            </div>
        </form>
    </div>
    <hr />
    <div class="panel-default">
        <?php
        if (isset($_POST["btnPreview"]) || isset($_POST["btnCSV"] ) || isset($_POST["btnPDF"] )) {
            $tglAwal  = new DateTime($_POST["tglAwal"]);
            $period   = $tglAwal->format("ym");
            $awal     = $tglAwal->format("d/m/Y");
            $tglAwal  = $tglAwal->format("Ymd");
            $tglAkhir = new DateTime($_POST["tglAkhir"]);
            $akhir    = $tglAkhir->format("d/m/Y");
            $tglAkhir = $tglAkhir->format("Ymd");

            $query = "SELECT @num := @num + 1 AS no,
                            temp.*
                        from (select jenis,
                                    bcmasuk.nodoc,
                                    nopen,
                                    datedoc,
                                    lpb,
                                    lpbdate,
                                    lph.lph AS lph,
                                    lph.date AS lphdate,
                                    supplier,
                                    bcmasuk.inv,
                                    bcmasuk.remark,
                                    bcmasuk.unit,
                                    bcmasuk.qty,
                                    nodsg,
                                    bcmasuk.val,
                                    bcmasuk.sub
                        FROM bcmasuk";
            $query .= "      JOIN (SELECT @num :=0) AS n ON 1=1";
            $query .= "      left JOIN lph on bcmasuk.lpb = lph.spb";
            $query .= "      left JOIN lpd on lph.lph = lpd.lph";
            $query .= "      WHERE lpbdate >=" . $tglAwal . " and lpbdate < adddate(" . $tglAkhir . ",1) and bcmasuk.nodoc != ''";

            if ($_POST["txtSupA"] == "") {
                if ($_POST["txtSupZ"] == "")
                    $query .= "AND (bcmasuk.sub BETWEEN '' and 'zzz') ";
                else
                    $query .= "AND (bcmasuk.sub BETWEEN '" . $_POST["txtSupZ"] . "' and '" . $_POST["txtSupZ"] . "') ";
            }
            else {
                if ($_POST["txtSupZ"] == "")
                    $query .= "AND (bcmasuk.sub BETWEEN '" . $_POST["txtSupA"] . "' and '" . $_POST["txtSupA"] . "') ";
                else
                    $query .= "AND (bcmasuk.sub BETWEEN '" . $_POST["txtSupA"] . "' and '" . $_POST["txtSupZ"] . "') ";
            }

            if ($_POST["txtInvA"] == "") {
                if ($_POST["txtInvZ"] == "")
                    $query .= "AND (bcmasuk.inv BETWEEN '' and 'zzz') ";
                else
                    $query .= "AND (bcmasuk.inv BETWEEN '" . $_POST["txtInvA"] . "' and '" . $_POST["txtInvZ"] . "') ";
            }
            else {
                if ($_POST["txtInvZ"] == "")
                    $query .= "AND (bcmasuk.inv BETWEEN '" . $_POST["txtInvA"] . "' and '" . $_POST["txtInvA"] . "') ";
                else
                    $query .= "AND (bcmasuk.inv BETWEEN '" . $_POST["txtInvA"] . "' and '" . $_POST["txtInvZ"] . "') ";
            }

            if ($_POST["txtDocA"] == "") {
                if ($_POST["txtDocZ"] == "")
                    $query .= "AND (bcmasuk.nodoc BETWEEN '' and 'zzz') ";
                else
                    $query .= "AND (bcmasuk.nodoc BETWEEN '" . $_POST["txtDocA"] . "' and '" . $_POST["txtDocZ"] . "') ";
            }
            else {
                if ($_POST["txtDocZ"] == "")
                    $query .= "AND (bcmasuk.nodoc BETWEEN '" . $_POST["txtDocA"] . "' and '" . $_POST["txtDocA"] . "') ";
                else
                    $query .= "AND (bcmasuk.nodoc BETWEEN '" . $_POST["txtDocA"] . "' and '" . $_POST["txtDocZ"] . "') ";
            }

            if ($_POST["jnsA"] == "") {
                if ($_POST["jnsZ"] == "")
                    $query .= "AND (bcmasuk.jenis BETWEEN '' and 'zzz')";
                else
                    $query .= "AND (bcmasuk.jenis BETWEEN '" . $_POST["jnsA"] . "' and '" . $_POST["jnsZ"] . "') ";
            }
            else {
                if ($_POST["jnsZ"] == "")
                    $query .= "AND (bcmasuk.jenis BETWEEN '" . $_POST["jnsA"] . "' and '" . $_POST["jnsA"] . "') ";
                else
                    $query .= "AND (bcmasuk.jenis BETWEEN '" . $_POST["jnsA"] . "' and '" . $_POST["jnsZ"] . "') ";
            }
         $query .= " order by date(bcmasuk.lpbdate), bcmasuk.lpb, bcmasuk.inv) as temp left outer JOIN (SELECT @num :=0) AS n ON 1=1";
            
         $_SESSION["searchQuery"] = $query;
        }
        else {
            if (isset($_SESSION["searchQuery"])) {
                $query = $_SESSION["searchQuery"];
            }
        }

        if (isset($_POST["btnPreview"]) || isset($_SESSION["searchQuery"])) {
            
            echo '<p><strong>LAPORAN PEMASUKAN BARANG PER DOKUMEN PELABUHAN</strong></p>';
            echo '<p>KAWASAN BERIKAT Wage Biro Technic</p>';
            echo '<p>LAPORAN PEMASUKAN BARANG PER DOKUMEN PELABUHAN</p>';
            echo "<p>PERIODE : " . $awal . " - " . $akhir . "</p></tr>";
            
            $ds = new MySQLDataSource($db_con);
            $ds->SelectCommand = $query;

            $grid = new KoolGrid("grid");
            $grid->DataSource = $ds;
            $grid->AllowInserting = false;
            $grid->AllowEditing = false;
            $grid->AllowDeleting = false;
            $grid->AllowResizing = FALSE;
            $grid->ColumnWrap = true;
            $grid->MasterTable->ShowFunctionPanel = false;

            $column = new GridBoundColumn();
            $column->HeaderText = "NO";
            $column->DataField = "no";
            $column->Width =  "40px";
            $column->Align = "center";
            $column->AllowExporting = true;
            $column->Valign = "middle";
            $grid->MasterTable->AddColumn($column);
            
            $column = new GridBoundColumn();
            $column->HeaderText = "JENIS DOKUMEN";
            $column->DataField = "jenis";
            $column->Width =  "50px";
            $column->Align = "center";
            $column->AllowExporting = true;
            $column->Valign = "middle";
            $grid->MasterTable->AddColumn($column);

            $column = new GridBoundColumn();
            $column->HeaderText = "NO DOKUMEN PABEAN";
            $column->DataField = "nodoc";
            $column->Width =  "50px";
            $column->Align = "center";
            $column->AllowExporting = true;
            $column->Valign = "middle";
            $grid->MasterTable->AddColumn($column);

            $column = new GridBoundColumn();
            $column->HeaderText = "NO PENDAFTARAN";
            $column->DataField = "nopen";
            $column->Width =  "50px";
            $column->Align = "center";
            $column->AllowExporting = true;
            $column->Valign = "middle";
            $grid->MasterTable->AddColumn($column);

            $column = new GridDateTimeColumn();
            $column->HeaderText = "TGL DOK. PABEAN";
            $column->DataField = "datedoc";
            $column->FormatString = "d-m-Y";
            $column->Valign = "middle";
            $column->Width = "100px";
            $column->Align = "center";
            $grid->MasterTable->AddColumn($column);

            $column = new GridBoundColumn();
            $column->HeaderText = "NO BUKTI PENERIMAAN";
            $column->DataField = "lpb";
            $column->Valign = "middle";
            $column->Width = "100px";
            $column->Align = "center";
            $grid->MasterTable->AddColumn($column);

            $column = new GridDateTimeColumn();
            $column->HeaderText = "TGL BUKTI PENERIMAAN";
            $column->DataField = "lpbdate";
            $column->FormatString = "d-m-Y";
            $column->Valign = "middle";
            $column->Width = "100px";
            $column->Align = "center";
            $grid->MasterTable->AddColumn($column);

            $column = new GridBoundColumn();
            $column->HeaderText = "NO LPB";
            $column->DataField = "lph";
            $column->Valign = "middle";
            $column->Width = "100px";
            $column->Align = "center";
            $grid->MasterTable->AddColumn($column);

            $column = new GridDateTimeColumn();
            $column->HeaderText = "TGL LPB";
            $column->DataField = "lphdate";
            $column->FormatString = "d-m-Y";
            $column->Valign = "middle";
            $column->Width = "100px";
            $column->Align = "center";
            $grid->MasterTable->AddColumn($column);

            $column = new GridBoundColumn();
            $column->HeaderText = "PEMASOK/PENGIRIM";
            $column->DataField = "supplier";
            $column->Width = "200px";
            $column->Valign = "middle";
            $grid->MasterTable->AddColumn($column);

            $column = new GridBoundColumn();
            $column->HeaderText = "KODE BARANG";
            $column->DataField = "inv";
            $column->Width = "70px";
            $column->Valign = "middle";
            $column->Align = "center";
            $grid->MasterTable->AddColumn($column);

            $column = new GridBoundColumn();
            $column->HeaderText = "NAMA BARANG";
            $column->DataField = "remark";
            $column->Valign = "middle";
            $column->Width = "400px";
            $grid->MasterTable->AddColumn($column);

            $column = new GridBoundColumn();
            $column->HeaderText = "SAT";
            $column->DataField = "unit";
            $column->Width = "30px";
            $column->Valign = "middle";
            $grid->MasterTable->AddColumn($column);
            
            $column = new gridnumbercolumn();
            $column->HeaderText = "QTY";
            $column->DataField = "qty";
            $column->Align = "right";
            $column->DecimalNumber = "2";
            $column->DecimalPoint = ",";
            $column->ThousandSeperate = ".";
            $column->Width = "100px";
            $grid->MasterTable->AddColumn($column);
            
            $column = new GridBoundColumn();
            $column->HeaderText = "KODE BATCH";
            $column->DataField = "nodsg";
            $column->Width = "70px";
            $column->Valign = "middle";
            $column->Align = "center";
            $grid->MasterTable->AddColumn($column);

            $column = new gridnumbercolumn();
            $column->HeaderText = "NILAI BARANG";
            $column->DataField = "val";
            $column->Align = "right";
            $column->DecimalNumber = "2";
            $column->DecimalPoint = ",";
            $column->ThousandSeperate = ".";
            $column->Width = "100px";
            $grid->MasterTable->AddColumn($column);
            
            echo ShowGrid($grid, false);
        }
      
        if (isset($_POST["btnCSV"]) ) {
            $fetch = mysql_query($query, $db_con) or
                    die(mysql_error());
            $num = Mysql_num_rows($fetch);
            $exHtml = "";

            if ($num > 0) {
                $exHtml = "<table id='expTab' class='table table-striped table-bordered'>";
                $exHtml .= '<p><strong>LAPORAN PEMASUKAN BARANG PER DOKUMEN PELABUHAN</strong></p>';
                $exHtml .= '<p>KAWASAN BERIKAT Wage Biro Technic</p>';
                $exHtml .= '<p>LAPORAN PEMASUKAN BARANG PER DOKUMEN PELABUHAN</p>';
                $exHtml .= "<p>PERIODE : " . $awal . " - " . $akhir . "</p></tr>";
                                
                $exHtml .= "<tr>"
                   . "<th>NO</th>"
                   . "<th>JENIS DOKUMEN</th>"
                   . "<th>NO DOKUMEN PABEAN</th>"
                   . "<th>NO PENDAFTARAN</th>"
                   . "<th>TGL DOK. PABEAN</th>"
                   . "<th>NO BUKTI PEMASUKAN</th>"
                   . "<th>TGL BUKTI PEMASUKAN</th>"
                   . "<th>NO LPB</th>"
                   . "<th>TGL LPB</th>"
                   . "<th>PEMBELI/PENERIMA</th>"
                   . "<th>KODE BARANG</th>"
                   . "<th>NAMA BARANG</th>"
                   . "<th>SATUAN</th>"
                   . "<th>QTY</th>"
                   . "<th>KODE BATCH</th>"
                   . "<th>NILAI BARANG</th>"
                . "</tr>";
                for ($i = 0; $i < $num; $i++) {
                    $row = mysql_fetch_row($fetch);
                    $exHtml .= "<tr>";
                    $exHtml .= "<td>$row[0]</td>";
                    $exHtml .= "<td>$row[1]</td>";
                    $exHtml .= "<td>'$row[2]</td>";
                    $exHtml .= "<td>'$row[3]</td>";
                    $exHtml .= "<td>$row[4]</td>";
                    $exHtml .= "<td>$row[5]</td>";
                    $exHtml .= "<td>$row[6]</td>";
                    $exHtml .= "<td>$row[7]</td>";
                    $exHtml .= "<td>$row[8]</td>";
                    $exHtml .= "<td>$row[9]</td>";                  
                    $exHtml .= "<td>$row[10]</td>";
                    $exHtml .= "<td>$row[11]</td>";
                    $exHtml .= "<td>$row[12]</td>";
                    $exHtml .= "<td>$row[13]</td>";
                    $exHtml .= "<td>$row[14]</td>";
                    $exHtml .= "<td>$row[15]</td>";
                    $html .= "</tr>";
                }
                $exHtml .= "</table>";
            }
            
            ob_clean();
            header("Content-type: application/vnd-ms-excel");
            header("Content-Disposition: attachment; filename=BC_Pemasukan_Barang.xls");

            echo $exHtml;            
        }
        
        if(isset($_POST["btnPDF"])){
            ob_clean();
  
            require_once dirname(__FILE__) . '/Lib/tcpdf/tcpdf.php';
            require_once dirname(__FILE__) . '/Lib/tcpdf/config/lang/eng.php';

            $pdf = new PDF("L", PDF_UNIT, "A4", true, 'UTF-8', false); 
            $pdf->SetFont('times', '', 10, '', 'false');
            // add a page
            $pdf->AddPage();
            
            $header = '<br /><br /><h2><strong>LAPORAN PEMASUKAN BARANG PER DOKUMEN PELABUHAN</strong></h2>';
            $header .= '<h3>KAWASAN BERIKAT Wage Biro Technic</h3>';
            $header .= '<h3>LAPORAN PEMASUKAN BARANG PER DOKUMEN PELABUHAN</h3>';
            $header .= "<h3>PERIODE : " . $awal . " - " . $akhir . "</h3><br /><br />";
                        
            $sql = mysql_query($query);
            $sData = array();
            $num = 0;
            while($row = mysql_fetch_assoc($sql)){
                $sData[$num]['no'] = $row['no'];
                $sData[$num]['jenis'] = $row['jenis'];
                $sData[$num]['nodoc'] = $row['nodoc'];
                $sData[$num]['nopen'] = $row['nopen'];
                $sData[$num]['datedoc'] = $row['datedoc'];
                $sData[$num]['lpb'] = $row['lpb'];
                $sData[$num]['lpbdate'] = $row['lpbdate'];
                $sData[$num]['lph'] = $row['lph'];
                $sData[$num]['lphdate'] = $row['lphdate'];
                $sData[$num]['supplier'] = $row['supplier'];
                $sData[$num]['inv'] = $row['inv'];
                $sData[$num]['remark'] = $row['remark'];
                $sData[$num]['qty'] = $row['qty'];
                $sData[$num]['unit'] = $row['unit'];
                $sData[$num]['nodsg'] = $row['nodsg'];
                $sData[$num]['val'] = $row['val'];
                $num++;
            }
            
            $tablehead = array('NO', 'JENIS DOK', 'NO DOK PABEAN', 'NO PENDAFTARAN', 'TGL DOK PABEAN',
                'NO.PENERIMAAN', 'TGL PENERIMAAN', 'NO.LPB', 'TGL LPB', 'PEMASOK/PENGIRIM',
                'KODE BARANG', 'NAMA BARANG', 'QTY', 'SAT','KODE BATCH', 'NILAI BARANG');
            
            $pdf->writeHTML($header, true, false, true, false, '');
            
            $pdf->masukbrgTbl($tablehead, $sData);
            ob_end_clean();
            $pdf->Output('BC_Pemasukan_Barang.pdf', 'D');            
        }
                       
        ?>	      
    </div>

    <script src="js/jquery-1.11.2.min.js"></script>
    <script src="bootstrap/js/bootstrap.js"></script>
    <script src="datatables/jquery.dataTables.js"></script>
    <script src="datatables/dataTables.bootstrap.js"></script>

    <script type="text/javascript">
        $(document).on('click', '.pilihSA', function (e) {
            document.getElementById("txtSupA").value = $(this).attr('datasupl');
            $('#mdlSupA').hide();
            $('body').removeClass('modal-open');
            $('.modal-backdrop').remove();
        });
      
        $(function () {
            $("#lookupSA").dataTable();
        });

        $(document).on('click', '.pilihSZ', function (e) {
            document.getElementById("txtSupZ").value = $(this).attr('datasupl');
            $('#mdlSupZ').hide();
            $('body').removeClass('modal-open');
            $('.modal-backdrop').remove();
        });

        $(function () {
            $("#lookupSZ").dataTable();
        });

        $(document).on('click', '.pilihDA', function (e) {
            document.getElementById("txtDocA").value = $(this).attr('datadoc');
            $('#mdlDocA').hide();
            $('body').removeClass('modal-open');
            $('.modal-backdrop').remove();
        });

        $(function () {
            $("#lookupDA").dataTable();
        });

        $(document).on('click', '.pilihDZ', function (e) {
            document.getElementById("txtDocZ").value = $(this).attr('datadoc');
            $('#mdlDocZ').hide();
            $('body').removeClass('modal-open');
            $('.modal-backdrop').remove();
        });

        $(function () {
            $("#lookupDZ").dataTable();
        });

        $(document).on('click', '.pilihIA', function (e) {
            document.getElementById("txtInvA").value = $(this).attr('datainv');
            $('#mdlInvA').hide();
            $('body').removeClass('modal-open');
            $('.modal-backdrop').remove();
        });

        $(function () {
            $("#lookupIA").dataTable();
        });

        $(document).on('click', '.pilihIZ', function (e) {
            document.getElementById("txtInvZ").value = $(this).attr('datainv');
            $('#mdlInvZ').hide();
            $('body').removeClass('modal-open');
            $('.modal-backdrop').remove();
        });

        $(function () {
            $("#lookupIZ").dataTable();
        });
                            
    </script> 
</div>
<?php
require("footer.php");
?>