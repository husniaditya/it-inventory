<?php
require("header.php");
require "Lib/tcpdf/PDF.php";

if ($koolajax->isCallback == false)
    unset($_SESSION["searchQuery"]);
?>
<div id="page-wrapper">   
    <div class="row">
        <div class="col-lg-12">
            <h1 class="page-header" style="font-size: 25px;">BC Pengeluaran Sisa Pengemas</h1>
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
            $tglAwal = new DateTime($_POST["tglAwal"]);
            $period = $tglAwal->format("ym");
            $awal = $tglAwal->format("d/m/Y");
            $tglAwal = $tglAwal->format("Ymd");
            $tglAkhir = new DateTime($_POST["tglAkhir"]);
            $akhir = $tglAkhir->format("d/m/Y");
            $tglAkhir = $tglAkhir->format("Ymd");

            $query = "select @num := @num + 1 AS no, y.inv,y.name,y.unit ";
            $query .= " from (select inv.inv as inv,inv.name as name,inv.unit as unit,SUM(sjd.qty1) AS jumlah,okd.price AS harga,sjd.qty1*okd.price AS total,date(sjh.date) AS tanggal FROM sjh,sjd,okd,inv WHERE sjh.sjh = sjd.sjh AND sjd.okl = okd.okl AND sjd.inv = inv.inv AND sjh.date BETWEEN '20191101' AND '20191125' AND (inv.inv = '1011020083' OR inv.inv = '711030006')) as y";
            $query .= "      JOIN (SELECT @num :=0) AS n ON 1=1";

            $_SESSION["searchQuery"] = $query;
        }
        else {
            if (isset($_SESSION["searchQuery"])) {
                $query = $_SESSION["searchQuery"];
            }
        }

        if (isset($_POST["btnPreview"]) || isset($_SESSION["searchQuery"]) ) {
            
            echo '<p><strong>LAPORAN BC PENGELUARAN SISA PENGEMAS</strong></p>';
            echo '<p>KAWASAN BERIKAT Wage Biro Technic</p>';
            echo '<p>LAPORAN BC PENGELUARAN SISA PENGEMAS</p>';
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
            $column->DataField = "name";
            $column->AllowExporting = true;
            $column->Valign = "top";
            $column->Width = "50px";
            $grid->MasterTable->AddColumn($column);

            $column = new GridBoundColumn();
            $column->HeaderText = "SAT";
            $column->DataField = "unit";
            $column->AllowExporting = true;
            $column->Valign = "top";
            $column->Width = "50px";
            $column->Wrap = true;
            $grid->MasterTable->AddColumn($column);

            echo ShowGrid($grid, false);
        }
       
        if (isset($_POST["btnCSV"])) {
            $fetch = mysql_query($query, $db_con) or
                    die(mysql_error());
            $dnum = Mysql_num_rows($fetch);

            if ($dnum > 0) {
                $html = "<table id='expTab' class='table table-striped table-bordered'>";
                $html .= '<p><strong>LAPORAN BC PENGELUARAN SISA PENGEMAS</strong></p>';
                $html .= '<p>KAWASAN BERIKAT Wage Biro Technic</p>';
                $html .= '<p>LAPORAN BC PENGELUARAN SISA PENGEMAS</p>';
                
                $html .= "<tr>"                        
                . "<th>NO</th><th>KODE BARANG</th><th>NAMA BARANG</th>"
                . "<th>SATUAN</th><th>SALDO AWAL</th><th>PEMASUKAN</th>"
                . "<th>PENGELUARAN</th><th>ADJUSTMENT</th><th>SALDO BUKU</th>"
                . "<th>STOCK OPNAME</th><th>SELISIH</th><th>KET</th>"
                . "</tr>";
                for ($i = 0; $i < $dnum; $i++) {
                    $row = mysql_fetch_row($fetch);
                    $html .= "<tr>";
                    $html .= "<td>$row[0]</td>";
                    $html .= "<td>$row[1]</td>";
                    $html .= "<td>$row[2]</td>";
                    $html .= "<td>$row[3]</td>";
                    $html .= "<td>$row[10]</td>";
                    $html .= "<td>$row[12]</td>";
                    $html .= "<td>$row[13]</td>";
                    $html .= "<td>$row[7]</td>";
                    $html .= "<td>$row[14]</td>";
                    $html .= "<td>$row[8]</td>";
                    $html .= "<td>$row[9]</td>";
                    $html .= "<td>$row[11]</td>";
                    $html .= "</tr>";
                }
                $html .= "</table>";
            }
            
            ob_clean();
            header("Content-type: application/vnd-ms-excel");
            header("Content-Disposition: attachment; filename=BC_Mutasi_Mesin_Alat.xls");
                
            echo $html;                                
        }
        
        if(isset($_POST["btnPDF"])){ 
            ob_clean();
  
            require_once dirname(__FILE__) . '/Lib/tcpdf/tcpdf.php';
            require_once dirname(__FILE__) . '/Lib/tcpdf/config/lang/eng.php';

            $pdf = new PDF("L", PDF_UNIT, "A4", true, 'UTF-8', false); 
            $pdf->SetFont('times', '', 9, '', 'false');

            // add a page
            $pdf->AddPage();
            
            $sql = mysql_query($query);
            $sData = array();
            $num = 0;
            while($row = mysql_fetch_assoc($sql)){
                $sData[$num]['no'] = $row['no'];
                $sData[$num]['kodebrg'] = $row['akt'];
                $sData[$num]['namabrg'] = $row['name'];
                $sData[$num]['sat'] = $row['unit'];
                $sData[$num]['saldoawal'] = $row['saldoawal'];
                $sData[$num]['pemasukan'] = $row['masuk'];
                $sData[$num]['pengeluaran'] = $row['keluar'];
                $sData[$num]['adjust'] = $row['jin'];
                $sData[$num]['saldoakhir'] = $row['glast'];
                $sData[$num]['opname'] = $row['opn'];
                $sData[$num]['selisih'] = $row['selisih'];
                $sData[$num]['ket'] = $row['remark'];
                $num++;
            }
            
            $tablehead = array('NO', 'KODE BARANG', 'NAMA BARANG', 'SAT', 'SALDO AWAL',
                'PEMASUKAN', 'PENGELUARAN', 'ADJUSTMENT', 'SALDO BUKU', 'STOK OPNAME', 
                'SELISIH', 'KET');
            
            $header = '<br /><h2><strong>LAPORAN BC PENGELUARAN SISA PENGEMAS</strong></h2>';
            $header .= '<h3>KAWASAN BERIKAT Wage Biro Technic</h3>';
            $header .= '<h3>LAPORAN BC PENGELUARAN SISA PENGEMAS</h3p>';
            $header .= "<h3>PERIODE : " . $awal . " - " . $akhir . "</h3><br /><br />";
                       
            $pdf->writeHTML($header, true, false, true, false, '');
            
            $pdf->mutasiMesinTbl($tablehead, $sData);
       
            $pdf->Output('BC_Mutasi_Mesin_Alat.pdf', 'D');            
        }
        ?>	      
    </div>

    <script src="js/jquery-1.11.2.min.js"></script>
    <script src="bootstrap/js/bootstrap.js"></script>
    <script src="datatables/jquery.dataTables.js"></script>
    <script src="datatables/dataTables.bootstrap.js"></script>
</div>
<?php
require("footer.php");
?>