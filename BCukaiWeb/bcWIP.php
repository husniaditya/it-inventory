<?php
require("header.php");
require "Lib/tcpdf/PDF.php";

if ($koolajax->isCallback == false)
    unset($_SESSION["searchQuery"]);
?>
<div id="page-wrapper">   
    <div class="row">
        <div class="col-lg-12">
            <h1 class="page-header" style="font-size: 25px;">BC Posisi Barang Dalam Proses</h1>
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
    <div class="panel-default" >
        <?php
        if (isset($_POST["btnPreview"]) || isset($_POST["btnCSV"] ) || isset($_POST["btnPDF"] )) {
            $tglAwal = new DateTime($_POST["tglAwal"]);
            $period = $tglAwal->format("ym");
            $awal = $tglAwal->format("d/m/Y");
            $tglAwal = $tglAwal->format("Ymd");
            $tglAkhir = new DateTime($_POST["tglAkhir"]);
            $akhir = $tglAkhir->format("d/m/Y");
            $tglAkhir = $tglAkhir->format("Ymd");

            $query = "select @num := @num + 1 AS no, tmp.* from ( select x.inv as inv, x.invname, round((sum(s_awal) + sum(qdebet) - sum(qkredit)),2) as qwipbin, x.unit, ";
            $query .= " ((round((sum(s_awal) + sum(qdebet) - sum(qkredit)),2))/konversi.konversi) as qty2, '-' as ket ";
            $query .= " from ( ";
            $query .= " select name as invname,inv,'' as loc,unit2, date(" . $tglAwal . ") as date, ''  as jurnal, ";
            $query .= "  'BALANCE'  as rem, sum(qlast) as s_awal,  0 as qdebet, 0 as qkredit, ";
            $query .= "       0 as qadjust, 0  as qopn, ' ' as dk,unit,1 as urut,nodsg ";
            $query .= "  from  ( ";
            $query .= "     select rin.inv,inv.name, rin.qlast, rin.vlast,rin.nodsg,inv.unit2,inv.unit ";
            $query .= "       from rin left outer join inv on rin.inv=inv.inv ";
            $query .= "      where rin.period='" . $period . "' and left(rin.inv,1)='4'";
            $query .= "     union all ";
            $query .= "     select ind.inv,inv.name, qty*if(dk='D',1,-1) as qlast , val*if(dk='D',1,-1) as vlast,ind.nodsg,inv.unit2,inv.unit ";
            $query .= "       from ind left outer join inv on ind.inv=inv.inv ";
            $query .= "      where ind.period='" . $period . "' and ind.date < " . $tglAwal . "";
            $query .= "       and left(ind.inv,1)='4'";
            $query .= "  ) as oawal  group by inv,nodsg ";
            $query .= "  union all ";
            $query .= " select inv.name as invname, ind.inv, '' as loc,inv.unit2, ";
            $query .= "       ind.date as date, ind.jurnal as jurnal, ifnull(ind.rem,'') as rem, 0 as s_awal, ";
            $query .= "       if (ind.dk='D', ind.qty , 0) as qdebet, ";
            $query .= "       if (ind.dk='K', ind.qty , 0) as qkredit, ";
            $query .= "       0 as qadjust, ";
            $query .= "       if (ind.dk='D' and ind.subjurnal='OPN', ind.qty ,if (ind.dk='K' and ind.subjurnal='OPN',-ind.qty,0)) as qopn, ";
            $query .= "       ind.dk as dk, inv.unit, if (ind.subjurnal='OPN' , 2 , 1)  as urut,ind.nodsg ";
            $query .= "       from ind ";
            $query .= "       left outer join inv on ind.inv=inv.inv ";
            $query .= "       where (ind.date>=" . $tglAwal . " and ind.date<adddate(" . $tglAkhir . ",1)) ";
            $query .= "       and  left(ind.inv,1) = '4' ";
            $query .= " ) as x ";
          
            $query .= " left outer join konversi on x.inv=konversi.inv and konversi.unit=x.unit2 and konversi.unit in ('POUCH','JRG','DOS','BOTOL','BOX') ";             
            $query .= " group by inv order by inv ) ";
            $query .= " as tmp left outer JOIN (SELECT @num :=0) AS n ON 1=1";

            $_SESSION["searchQuery"] = $query;
        } else {
            if (isset($_SESSION["searchQuery"])) {
                $query = $_SESSION["searchQuery"];
            }
        }

        if (isset($_POST["btnPreview"]) || isset($_SESSION["searchQuery"]) ) {
            
            echo '<p><strong>LAPORAN POSISI BARANG DALAM PROSES (WIP)</strong></p>';
            echo '<p>KAWASAN BERIKAT PT. BARAMUDA BAHARI</p>';
            echo '<p>LAPORAN POSISI BARANG DALAM PROSES (WIP)</p>';
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
            $grid->MasterTable->AddColumn($column);

            $column = new GridBoundColumn();
            $column->HeaderText = "NAMA BARANG";
            $column->DataField = "invname";
            $column->AllowExporting = true;
            $column->Valign = "top";
            $column->Width = "300px";
            $column->Wrap = true;
            $grid->MasterTable->AddColumn($column);
            
            $column = new GridBoundColumn();
            $column->HeaderText = "SAT";
            $column->DataField = "unit";
            $column->AllowExporting = true;
            $column->Valign = "top";
            $column->Width = "50px";
            $column->Wrap = true;
            $grid->MasterTable->AddColumn($column);

            $column = new gridnumbercolumn();
            $column->HeaderText = "JUMLAH";
            $column->DataField = "qwipbin";
            $column->Valign = "top";
            $column->Width = "100px";
            $column->Align = "right";
            $grid->MasterTable->AddColumn($column);

            $column = new GridBoundColumn();
            $column->HeaderText = "UNIT PACKING";
            $column->DataField = "qty2";
            $column->Valign = "top";
            $column->Width = "100px";
            $column->Wrap = true;
            $grid->MasterTable->AddColumn($column);

            $column = new GridBoundColumn();
            $column->HeaderText = "KET";
            $column->DataField = "ket";
            $column->Valign = "top";
            $grid->MasterTable->AddColumn($column);

            echo ShowGrid($grid, false);
        }
      
        if (isset($_POST["btnCSV"])) {
           
            $fetch = mysql_query($query, $db_con) or
                    die(mysql_error());
            $num = Mysql_num_rows($fetch);

            if ($num > 0) {
                $html = "<table id='expTab' class='table table-striped table-bordered'>";
                $html .= "<tr><p><strong>LAPORAN POSISI BARANG DALAM PROSES (WIP)</strong></p>";
                $html .= "<p>KAWASAN BERIKAT PT. BARAMUDA BAHARI</p>";
                $html .= "<p>LAPORAN POSISI BARANG DALAM PROSES (WIP)</p>";
                $html .= "<p>PERIODE : " . $awal . " - " . $akhir . "</p></tr>";
                                              
                $html .= "<tr>"
                . "<th>NO</th><th>KODE BARANG</th><th>NAMA BARANG</th>"
                . "<th>SATUAN</th><th>JUMLAH</th><th>UNIT PACKING</th>"
                . "<th>KET</th>"
                . "</tr>";
                for ($i = 0; $i < $num; $i++) {
                    $row = mysql_fetch_row($fetch);
                    $html .= "<tr>";
                    $html .= "<td>$row[0]</td>";
                    $html .= "<td>$row[1]</td>";
                    $html .= "<td>$row[2]</td>";
                    $html .= "<td>$row[4]</td>";
                    $html .= "<td>$row[3]</td>";
                    $html .= "<td>$row[5]</td>";
                    $html .= "<td>$row[6]</td>";
                    $html .= "</tr>";
                }
                $html .= "</table>";
            }
            
            ob_clean();
            header("Content-type: application/vnd-ms-excel");
            header("Content-Disposition: attachment; filename=BC_Posisi_Barang_Dalam_Proses.xls");
                
            echo $html;            
        }
        
        if(isset($_POST["btnPDF"] )){
            ob_clean();
  
            require_once dirname(__FILE__) . '/Lib/tcpdf/tcpdf.php';
            require_once dirname(__FILE__) . '/Lib/tcpdf/config/lang/eng.php';

            $pdf = new PDF("L", PDF_UNIT, "A4", true, 'UTF-8', false); 
            $pdf->SetFont('times', '', 10, '', 'false');
            // add a page
            $pdf->AddPage();
            
            $header = '<br /><br /><h2><strong>LAPORAN POSISI BARANG DALAM PROSES (WIP)</strong></h2>';
            $header .= '<h3>KAWASAN BERIKAT PT. BARAMUDA BAHARI</h3>';
            $header .= '<h3>LAPORAN POSISI BARANG DALAM PROSES (WIP)</h3>';
            $header .= "<h3>PERIODE : " . $awal . " - " . $akhir . "</h3><br /><br />";
                        
            $sql = mysql_query($query);
            $sData = array();
            $num = 0;
            while($row = mysql_fetch_assoc($sql)){
                $sData[$num]['no'] = $row['no'];
                $sData[$num]['inv'] = $row['inv'];
                $sData[$num]['invname'] = $row['invname'];
                $sData[$num]['unit'] = $row['unit'];
                $sData[$num]['qwipbin'] = $row['qwipbin'];
                $sData[$num]['qty2'] = $row['qty2'];
                $sData[$num]['ket'] = $row['ket'];
                $num++;
            }
            
            $tablehead = array('NO', 'NAMA BARANG', 'KODE BARANG', 'SATUAN',
                'JUMLAH', 'UNIT PACKING', 'KET');
            
            $pdf->writeHTML($header, true, false, true, false, '');
            
            $pdf->wipTbl($tablehead, $sData);
       
            $pdf->Output('BC_Posisi_Barang_Dalam_Proses.pdf', 'D');     
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