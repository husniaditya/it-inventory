<?php
require("header.php");
require "Lib/tcpdf/PDF.php";

if ($koolajax->isCallback == false)
    unset($_SESSION["searchQuery"]);
?>

    <!-- Modal -->
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
                            $sql = mysql_query('SELECT inv AS Kode, name AS Persediaan FROM inv WHERE flag = 0 ;');
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
                            $sql = mysql_query('SELECT inv AS Kode, name AS Persediaan FROM inv WHERE flag = 0;'); 
                            while ($r = mysql_fetch_array($sql)) {
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
            <h1 class="page-header" style="font-size: 25px;">BC Mutasi Barang Scrap</h1>
        </div>
    </div>

    <!-- /.search -->  
    <div class="row">
        <form method="post">	
            <div class="form-group" style="position: relative; left:20px;">
                <div class="row">
                    <div class="col-sm-1">
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
                    <div class="col-sm-1">
                        <label for="varchar">Persediaan</label>
                    </div>
                    <div class="col-sm-2">
                        <div class="input-group input-group-sm">
                            <input type="text" class="form-control" name="txtInvA" id="txtInvA" />
                            <span class="input-group-btn"><button type="button" class="btn btn-primary" data-toggle="modal" data-target="#mdlInvA"><i class="glyphicon glyphicon-search"></i></button></span>                        </span>
                        </div>
                    </div>
                    <div class="col-sm-2">
                        <div class="input-group input-group-sm">
                            <input type="text" class="form-control" name="txtInvZ" id="txtInvZ" />
                            <span class="input-group-btn"><button type="button" class="btn btn-primary" data-toggle="modal" data-target="#mdlInvZ"><i class="glyphicon glyphicon-search"></i></button></span>
                        </div>
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
        if (isset($_POST["btnPreview"])|| isset($_POST["btnCSV"] ) || isset($_POST["btnPDF"] )) {
            $tglAwal = new DateTime($_POST["tglAwal"]);
            $awal = $tglAwal->format("d/m/Y");
            $tglAwal = $tglAwal->format("Ymd");            
            $tglAkhir = new DateTime($_POST["tglAkhir"]);
            $akhir = $tglAkhir->format("d/m/Y");
            $tglAkhir = $tglAkhir->format("Ymd");

            $query = "select @num := @num + 1 AS no, tmp.* from ( select inv,remark,loc,qlast,vlast,sum(D) as D,sum(K) as K, sum(saldo) as saldo,unit,0 as jin,0 as opn,'-' as ket  from ( ";
            $query .= " select jid.inv,jin.loc,jid.remark, sum(qty*if(dk='D',1,-1)) as qlast , sum(val*if(dk='D',1,-1)) as vlast, ";
            $query .= " 0 as D,0 as K, qty*if(dk='D',1,-1) as saldo,jid.unit ";
            $query .= " from jid,jin ";
            $query .= " where  jin.jin=jid.jin and jin.date < " . $tglAkhir . " and jin.group_ = 6 ";
            if ($_POST["txtInvA"] == "") {
                if ($_POST["txtInvZ"] == "")
                    $query .= " AND (jid.inv BETWEEN '' and 'zzz') ";
                else
                    $query .= " AND (jid.inv BETWEEN '" . $_POST["txtInvA"] . "' and '" . $_POST["txtInvZ"] . "') ";
            }
            else {
                if ($_POST["invZ"] == "")
                    $query .= " AND (jid.inv BETWEEN '" . $_POST["txtInvA"] . "' and '" . $_POST["txtInvA"] . "') ";
                else
                    $query .= " AND (jid.inv BETWEEN '" . $_POST["txtInvA"] . "' and '" . $_POST["txtInvZ"] . "') ";
            }
           
            $query .= " union all ";
            $query .= " select jid.inv,jin.loc,jid.remark, 0 as qlast , 0 as vlast,if(jid.dk='D',jid.qty,0) as D,if(jid.dk='K',jid.qty,0) as K, qty*if(dk='D',1,-1) as ";
            $query .= " saldo,jid.unit ";
            $query .= "  from jid,jin ";            
            $query .= "  where  jin.jin=jid.jin and jin.group_ = 6 ";
            if ($_POST["inv"] == "") {
                if ($_POST["invZ"] == "")
                    $query .= " AND (jid.inv BETWEEN '' and 'zzz') ";
                else
                    $query .= " AND (jid.inv BETWEEN '" . $_POST["txtInvA"] . "' and '" . $_POST["txtInvZ"] . "') ";
            }
            else {
                if ($_POST["invZ"] == "")
                    $query .= " AND (jid.inv BETWEEN '" . $_POST["txtInvA"] . "' and '" . $_POST["txtInvA"] . "') ";
                else
                    $query .= " AND (jid.inv BETWEEN '" . $_POST["txtInvA"] . "' and '" . $_POST["txtInvZ"] . "') ";
            }
            
            $query .= " and jin.date >= " . $tglAwal . " and jin.date < adddate(" . $tglAkhir . ",1) ";
            $query .= ") as tscrap where inv is not null group by trim(inv) ";
            $query .= "union all ";
            $query .= "select sjrd.inv,sjrd.remark,sjrd.loc,0 as qlast,0 as vlast, sum(sjrd.qty) as D,sum(sjrd.qty) as K, 0 as saldo, inv.unit ,0 as jin,0 as opn,'-' as ket";
            $query .= "  from sjrd,sjr,inv ";
            $query .= "  where sjrd.sjr=sjr.sjr and (sjrd.inv='911010001'  and trim(sjrd.loc)='TSBE') and sjrd.inv=inv.inv ";
            $query .= "   and sjr.date >= '" . $tglAwal . "' and sjr.date< adddate(" . $tglAkhir . ",1) ";
            if ($_POST["inv"] == "") {
                if ($_POST["invZ"] == "")
                    $query .= " AND (sjrd.inv BETWEEN '' and 'zzz') ";
                else
                    $query .= " AND (sjrd.inv BETWEEN '" . $_POST["txtInvA"] . "' and '" . $_POST["txtInvZ"] . "') ";
            }
            else {
                if ($_POST["invZ"] == "")
                    $query .= " AND (sjrd.inv BETWEEN '" . $_POST["txtInvA"] . "' and '" . $_POST["txtInvA"] . "') ";
                else
                    $query .= " AND (sjrd.inv BETWEEN '" . $_POST["txtInvA"] . "' and '" . $_POST["txtInvZ"] . "') ";
            }
           
            $query .= "  group by inv ) ";            
            $query .= " as tmp left outer JOIN (SELECT @num :=0) AS n ON 1=1";

            $_SESSION["searchQuery"] = $query;
        } else {
            if (isset($_SESSION["searchQuery"])) {
                $query = $_SESSION["searchQuery"];
            }
        }

        if (isset($_POST["btnPreview"]) || isset($_SESSION["searchQuery"])) {
            
            echo '<p><strong>LAPORAN PERTANGGUNG JAWABAN MUTASI BARANG SCRAP</strong></p>';
            echo '<p>KAWASAN BERIKAT PT. KARYAINDAH ALAM SEJAHTERA</p>';
            echo '<p>LAPORAN PERTANGGUNG JAWABAN MUTASI BARANG SCRAP</p>';
            echo '<p>PERIODE : ' .$awal. ' - ' .$akhir. '</p>';
            
            $ds = new MySQLDataSource($db_con);
            $ds->SelectCommand = $query;

            $grid = new KoolGrid("grid");
            $grid->DataSource = $ds;
            $grid->AllowInserting = false;
            $grid->AllowEditing = false;
            $grid->AllowDeleting = false;
            $grid->MasterTable->ShowFunctionPanel = false;
            
            $column = new GridBoundColumn();
            $column->HeaderText = "NO";
            $column->DataField = "no";
            $column->Width = "20px";
            $column->Valign = "top";
            $column->Wrap = true;
            $grid->MasterTable->AddColumn($column);

            $column = new GridBoundColumn();
            $column->HeaderText = "KODE BARANG";
            $column->DataField = "inv";
            $column->AllowExporting = true;
            $column->Valign = "top";
            $column->Wrap = true;
            $grid->MasterTable->AddColumn($column);

            $column = new GridBoundColumn();
            $column->HeaderText = "NAMA BARANG";
            $column->DataField = "remark";
            $column->AllowExporting = true;
            $column->Valign = "top";
            $column->Width = "80px";
            $grid->MasterTable->AddColumn($column);

            $column = new GridBoundColumn();
            $column->HeaderText = "SAT";
            $column->DataField = "unit";
            $column->AllowExporting = true;
            $column->Valign = "top";
            $column->Width = "50px";
            $grid->MasterTable->AddColumn($column);

            $column = new gridnumbercolumn();
            $column->HeaderText = "SALDO AWAL";
            $column->DataField = "saldo";
            $column->Valign = "top";
            $column->Width = "100px";
            $column->Wrap = true;
            $column->Align = "right";
            $column->DecimalNumber = "2";
            $column->DecimalPoint = ",";
            $column->ThousandSeperate = ".";
            $grid->MasterTable->AddColumn($column);

            $column = new gridnumbercolumn();
            $column->HeaderText = "PEMASUKAN";
            $column->DataField = "D";
            $column->Valign = "top";
            $column->Width = "100px";
            $column->Align = "right";
            $column->DecimalNumber = "2";
            $column->DecimalPoint = ",";
            $column->ThousandSeperate = ".";
            $grid->MasterTable->AddColumn($column);

            $column = new gridnumbercolumn();
            $column->HeaderText = "PENGELUARAN";
            $column->DataField = "K";
            $column->Valign = "top";
            $column->Width = "100px";
            $column->Align = "right";
            $column->DecimalNumber = "2";
            $column->DecimalPoint = ",";
            $column->ThousandSeperate = ".";
            $grid->MasterTable->AddColumn($column);

            $column = new gridnumbercolumn();
            $column->HeaderText = "ADJUSTMENT";
            $column->DataField = "jin";
            $column->Width = "100px";
            $column->Valign = "top";
            $column->Wrap = true;
            $column->Align = "right";
            $column->DecimalNumber = "2";
            $column->DecimalPoint = ",";
            $column->ThousandSeperate = ".";
            $grid->MasterTable->AddColumn($column);

            $column = new gridnumbercolumn();
            $column->HeaderText = "SALDO BUKU";
            $column->DataField = "qlast";
            $column->Valign = "top";
            $column->Width = "100px";
            $column->Align = "right";
            $column->DecimalNumber = "2";
            $column->DecimalPoint = ",";
            $column->ThousandSeperate = ".";
            $grid->MasterTable->AddColumn($column);

            $column = new GridBoundColumn();
            $column->HeaderText = "STOCK OPNAME";
            $column->DataField = "opn";
            $column->Valign = "top";
            $column->Wrap = true;
            $grid->MasterTable->AddColumn($column);

            $column = new GridBoundColumn();
            $column->HeaderText = "SELISIH";
            $column->DataField = "unit";
            $column->Valign = "top";
            $grid->MasterTable->AddColumn($column);

            $column = new GridBoundColumn();
            $column->HeaderText = "KET";
            $column->DataField = "ket";
            $column->Valign = "top";
            $column->Wrap = true;
            $grid->MasterTable->AddColumn($column);

            echo ShowGrid($grid, false);
        }
     
        if (isset($_POST["btnCSV"])) {
            $fetch = mysql_query($query, $db_con) or
                    die(mysql_error());
            $num = Mysql_num_rows($fetch);

            if ($num > 0) {
                $html = "<table id='expTab' class='table table-striped table-bordered'>";
                $html .= '<p><strong>LAPORAN PERTANGGUNG JAWABAN MUTASI BARANG SCRAP</strong></p>';
                $html .= '<p>KAWASAN BERIKAT PT. KARYAINDAH ALAM SEJAHTERA</p>';
                $html .= '<p>LAPORAN PERTANGGUNG JAWABAN MUTASI BARANG SCRAP</p>';
                $html .= "<p>PERIODE : " . $awal . " - " . $akhir . "</p></tr>";
                                
                $html .= "<tr>"
                . "<th>NO</th><th>KODE BARANG</th><th>NAMA BARANG</th>"
                . "<th>SATUAN</th><th>SALDO AWAL</th><th>PEMASUKAN</th>"
                . "<th>PENGELUARAN</th><th>ADJUSTMENT</th><th>SALDO BUKU</th>"
                . "<th>STOCK OPNAME</th><th>SELISIH</th><th>KET</th>"
                . "</tr>";
                for ($i = 0; $i < $num; $i++) {
                    $row = mysql_fetch_row($fetch);
                    $html .= "<tr>";
                    $html .= "<td>$row[0]</td>";
                    $html .= "<td>$row[1]</td>";
                    $html .= "<td>$row[2]</td>";
                    $html .= "<td>$row[9]</td>";
                    $html .= "<td>$row[8]</td>";
                    $html .= "<td>$row[6]</td>";
                    $html .= "<td>$row[7]</td>";
                    $html .= "<td>$row[10]</td>";
                    $html .= "<td>$row[4]</td>";
                    $html .= "<td>$row[11]</td>";
                    $html .= "<td>$row[9]</td>";
                    $html .= "<td>$row[12]</td>";
                    $html .= "</tr>";
                }
                $html .= "</table>";
                
                ob_clean();
                header("Content-type: application/vnd-ms-excel");
                header("Content-Disposition: attachment; filename=BC_Mutasi_Barang_Scrap.xls");
                    
                echo $html;
            }
        }
        
        if (isset($_POST["btnPDF"])) {
            ob_clean();
  
            require_once dirname(__FILE__) . '/Lib/tcpdf/tcpdf.php';
            require_once dirname(__FILE__) . '/Lib/tcpdf/config/lang/eng.php';

            $pdf = new PDF("L", PDF_UNIT, "A4", true, 'UTF-8', false); 
            $pdf->SetFont('times', '', 9, '', 'false');
            // add a page
            $pdf->AddPage();
            
            $header = '<br /><br /><h2><strong>LAPORAN PERTANGGUNG JAWABAN MUTASI BARANG SCRAP</strong></h2>';
            $header .= '<h3>KAWASAN BERIKAT PT. KARYAINDAH ALAM SEJAHTERA</h3>';
            $header .= '<h3>LAPORAN PERTANGGUNG JAWABAN MUTASI BARANG SCRAP</h3>';
            $header .= "<h3>PERIODE : " . $awal . " - " . $akhir . "</h3><br /><br /><br />";
                        
            $sql = mysql_query($query);
            $sData = array();
            $num = 0;
            while($row = mysql_fetch_assoc($sql)){
                $sData[$num]['no'] = $row['no'];
                $sData[$num]['inv'] = $row['inv'];
                $sData[$num]['remark'] = $row['remark'];
                $sData[$num]['unit'] = $row['unit'];
                $sData[$num]['saldo'] = $row['saldo'];
                $sData[$num]['D'] = $row['D'];
                $sData[$num]['K'] = $row['K'];
                $sData[$num]['jin'] = $row['jin'];
                $sData[$num]['qlast'] = $row['qlast'];
                $sData[$num]['opn'] = $row['opn'];
                $sData[$num]['unit'] = $row['unit'];
                $sData[$num]['ket'] = $row['ket'];
                $num++;
            }
            
            $tablehead = array('NO', 'KODE BARANG', 'NAMA BARANG', 'SAT',
                'SALDO AWAL', 'PEMASUKAN', 'PENGELUARAN', 'ADJUSTMENT',
                'SALDO BUKU', 'STOK OPNAME', 'SELISIH', 'KET');
            
            $pdf->writeHTML($header, true, false, true, false, '');
            
            $pdf->brgscrapTbl($tablehead, $sData);
       
            $pdf->Output('BC_Mutasi_Barang_Scrap', 'D');     
        }
        
        ?>	      
    </div>

    <script src="js/jquery-1.11.2.min.js"></script>
    <script src="bootstrap/js/bootstrap.js"></script>
    <script src="datatables/jquery.dataTables.js"></script>
    <script src="datatables/dataTables.bootstrap.js"></script>

   
    <script type="text/javascript">
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