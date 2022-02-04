<?php

$SERVER = "192.168.15.200";//"localhost";
$DATABASE = "cas_kias";
$USER = "root";
$PASSWORD = "database";

$db_con = null;

set_time_limit(0);

function OpenDB() {
    global $db_con, $SERVER, $USER, $PASSWORD, $DATABASE;

    $db_con = mysql_connect($SERVER, $USER, $PASSWORD);
    if (!$db_con) {
        die("Could not connect: " . mysql_error());
    }

    $db_selected = mysql_select_db($DATABASE, $db_con);
    if (!$db_selected) {
        die("Can't use " . $DATABASE . " : " . mysql_error());
    }
}

function CloseDB() {
    global $db_con;

    mysql_close($db_con);
}

function IsUserAlreadyLogin() {
    if (empty($_SESSION["name"]))
        return false;
    else
        return true;
}

function getParamData(){    
    //supplier
    $sql = mysql_query('SELECT sub AS Kode, name AS Supplier FROM sub WHERE group_ = 1 AND aktif = 1;');
    $sData = array();
    $num = 0;
    while($row = mysql_fetch_assoc($sql)){
        $sData[$num]['Kode'] = $row['Kode'];
        $sData[$num]['Supplier'] = $row['Supplier'];
        $num++;
    }
    $_SESSION['supSession'] = $sData;
    
    //document
    $sql = mysql_query('SELECT no_bc AS NoDokumen, DATE_FORMAT(datedoc, \'%c/%d/%Y\') AS Tanggal, remmark AS Keterangan FROM docpd limit 1;');
    $dData = array();
    $num = 0;
    while($row = mysql_fetch_assoc($sql)){
        $dData[$num]['NoDokumen'] = $row['NoDokumen'];
        $dData[$num]['Tanggal'] = $row['Tanggal'];
        $dData[$num]['Keterangan'] = $row['Keterangan'];
        $num++;
    }
    $_SESSION['docSession'] = $dData;
    
    //inv
    $sql = mysql_query('SELECT inv AS Kode, name AS Persediaan FROM inv WHERE flag = 0;');
    $iData = array();
    $num = 0;
    while($row = mysql_fetch_assoc($sql)){
        $iData[$num]['Kode'] = $row['Kode'];
        $iData[$num]['Persediaan'] = $row['Persediaan'];
        $num++;
    }
    $_SESSION['invSession'] = $iData;    
}

function MessageBox($alert, $title, $message) {
    $html = "<div class='$alert' style='width:500px;'>" .
            "<span class='glyphicon glyphicon-exclamation-sign' aria-hidden='true'></span>" .
            "<strong>$title : </strong>$message" .
            "<div>";
    return $html;
}

function imprtpdf($header, $table, $title){
    ob_clean();
  
    require_once dirname(__FILE__) . '/Lib/tcpdf/tcpdf.php';
    require_once dirname(__FILE__) . '/Lib/tcpdf/config/lang/eng.php';
       
    $pdf = new TCPDF("L", PDF_UNIT, "A4", true, 'UTF-8', false); 
    
    // add a page
    $pdf->AddPage();
	
    // output the HTML content
    $html = "<style> "
        . "table { "
        . "border-collapse: collapse; "
        . "} "
        . "th, td { "
        . " border: 1px solid black; " 
        . "padding: 10px; "
        . "text-align: left; "
        . "}"
        . "</style>";
    $html .= $table;
    
    $pdf->writeHTML($header, true, false, true, false, '');
    $pdf->writeHTML($html, true, false, true, false, '');
    $pdf->Output($title, 'D');
}

function ShowGrid($grid, $autoGenerate) {
    $grid->scriptFolder = "KoolGrid";
    $grid->AjaxEnabled = true;
    if ($autoGenerate)
        $grid->AutoGenerateColumns = true;
    $grid->MasterTable->Pager = new GridPrevNextAndNumericPager();
    $grid->MasterTabel->Pager-> PageSize = 40;
    $grid->MasterTable->Pager->PageSizeOptions = "40, 60, 80";
    $grid->scriptFolder = "KoolGrid";
    $grid->styleFolder = "KoolGrid/styles/default";
    $grid->AllowFiltering = true;
    $grid->AllowSorting = true;
    $grid->RowAlternative = true;
    $grid->AllowResizing = true;
    $grid->AllowGrouping = true;
    $grid->MasterTable->ShowGroupPanel = true;
    $grid->Process();

    return $grid->Render();
}

function BuildComboBox($db_con, $query, $field, $selectedValue, $ajaxUpdate, $disabled = false, $withEmpty = false) {
    $result = mysql_query($query, $db_con);
    $cbo_input = "<select id='" . $field . "' name='" . $field . "' ";
    if ($ajaxUpdate)
        $cbo_input .= "onchange='do_update()' ";
    if ($disabled)
        $cbo_input .= "disabled='disabled' ";
    $cbo_input .= ">";
    if ($withEmpty)
        $cbo_input .= "<option value=''>ALL</option>";
    while ($row = mysql_fetch_assoc($result)) {
        $cbo_input .= "<option value='" . $row[$field] . "' ";
        if ($selectedValue == $row[$field])
            $cbo_input .= "selected ";
        $cbo_input .= ">" . $row[$field] . "</option>";
    }
    $cbo_input .= "</select>";
    mysql_free_result($result);

    return $cbo_input;
}
function GetPOST($name, $empty) {
    if (isset($_POST[$name]))
        return $_POST[$name];
    else
        return $empty;
}

function CreateDatePicker($id, $value) {
    $dp = new KoolDatePicker($id);
    $dp->scriptFolder = "KoolCalendar";
    $dp->styleFolder = "KoolCalendar/styles/default";
    $dp->DateFormat = "d M Y";

    if ($value == "") {
        $date = new DateTime();
        $value = $date->format('d M Y');
        $dp->Value = $value;
    } else if ($value == " ") {
        /* space means I want an empty value */
    } else {
        $dp->Value = $value;
    }

    $dp->Init();
    return $dp->Render();
}

?>

