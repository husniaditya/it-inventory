<?php

require('tcpdf.php');

class PDF extends TCPDF {
    
    function masukbrgTbl($header, $data) {
        $w = array(8, 22, 27, 27, 26, 22, 30, 30, 33, 15, 15, 30);

        $i = 0;
        foreach ($header as $col) {
            //$this->Cell($w[$i], 12, $col, 1, 'LR', false);
            $x_axis = $this->Getx();
            $this->vcell($w[$i], 12, $x_axis, $col);
            $i++;
        }
        $this->Ln();

        // Data
        foreach ($data as $row) {
            $i = 0;
            foreach ($row as $col) {
                $x_axis = $this->Getx();
                $this->vcell($w[$i], 12, $x_axis, $col);

                $i++;
            }
            $this->Ln();
        }
    }
    
    function keluarbrgTbl($header, $data) {
        $w = array(8, 21, 27, 27, 23, 22, 15, 30, 28, 30, 10, 13, 30);

        $i = 0;
        foreach ($header as $col) {
            //$this->Cell($w[$i], 12, $col, 1, 'LR', false);
            $x_axis = $this->Getx();
            $this->vcell($w[$i], 12, $x_axis, $col);
            $i++;
        }
        $this->Ln();

        // Data
        foreach ($data as $row) {
            $i = 0;
            foreach ($row as $col) {
                $x_axis = $this->Getx();
                $this->vcell($w[$i], 12, $x_axis, $col);

                $i++;
            }
            $this->Ln();
        }
    }
    
    function wipTbl($header, $data) {
        $w = array(10, 50, 50, 25, 25, 50, 20);

        $i = 0;
        foreach ($header as $col) {
            //$this->Cell($w[$i], 12, $col, 1, 'LR', false);
            $x_axis = $this->Getx();
            $this->vcell($w[$i], 12, $x_axis, $col);
            $i++;
        }
        $this->Ln();

        // Data
        foreach ($data as $row) {
            $i = 0;
            foreach ($row as $col) {
                $x_axis = $this->Getx();
                $this->vcell($w[$i], 12, $x_axis, $col);

                $i++;
            }
            $this->Ln();
        }
    }
    
    function brgscrapTbl($header, $data) {
        $w = array(10, 28, 30, 10, 25, 25, 28, 25, 25, 25, 35, 10, 5);

        $i = 0;
        foreach ($header as $col) {
            //$this->Cell($w[$i], 12, $col, 1, 'LR', false);
            $x_axis = $this->Getx();
            $this->vcell($w[$i], 12, $x_axis, $col);
            $i++;
        }
        $this->Ln();

        // Data
        foreach ($data as $row) {
            $i = 0;
            foreach ($row as $col) {
                $x_axis = $this->Getx();
                $this->vcell($w[$i], 12, $x_axis, $col);

                $i++;
            }
            $this->Ln();
        }
    }

    function mutasiMesinTbl($header, $data) {
        $w = array(10, 28, 28, 10, 25, 25, 28, 27, 25, 30, 15, 27);

        $i = 0;
        foreach ($header as $col) {
            //$this->Cell($w[$i], 12, $col, 1, 'LR', false);
            $x_axis = $this->Getx();
            $this->vcell($w[$i], 12, $x_axis, $col);
            $i++;
        }
        $this->Ln();

        // Data
        foreach ($data as $row) {
            $i = 0;
            foreach ($row as $col) {
                $x_axis = $this->Getx();
                $this->vcell($w[$i], 20, $x_axis, $col);

                $i++;
            }
            $this->Ln();
        }
    }    

    function vcell($c_width, $c_height, $x_axis, $text) {
        $w_w = $c_height / 3;
        $w_w_1 = $w_w + 2;
        $w_w1 = $w_w + $w_w + $w_w + 3;
        // $w_w2=$w_w+$w_w+$w_w+$w_w+3;// for 3 rows wrap
        $len = strlen($text); // check the length of the cell and splits the text         
        if ($len > 12) {
            //check width of column, if enough just go with it
            $sp = $c_width % $len;            
            if (($c_width >= 25 || $sp > 0)){
                $w_text = str_split($text, 12); // splits the text into length of 7 and saves in a array since we need wrap cell of two cell we took $w_text[0], $w_text[1] alone.
                // if we need wrap cell of 3 row then we can go for    $w_text[0],$w_text[1],$w_text[2]
                $this->SetX($x_axis);
                $this->Cell($c_width, $w_w_1, $w_text[0], '', '', '');
                $this->SetX($x_axis);
                $this->Cell($c_width, $w_w1, $w_text[1], '', '', '');
                $this->SetX($x_axis);
                //$this->Cell($c_width,$w_w2,$w_text[2],'','','');// for 3 rows wrap but increase the $c_height it is very important.
                //$this->SetX($x_axis);
                $this->Cell($c_width, $c_height, '', 'LTRB', 0, 'L', 0);
            }
            else {
                $this->SetX($x_axis);
                $this->Cell($c_width, $c_height, $text, 'LTRB', 0, 'L', 0);
            }
        }
        else if(($c_width%$len)> $len){
            $w_text = str_split($text, 7); // splits the text into length of 7 and saves in a array since we need wrap cell of two cell we took $w_text[0], $w_text[1] alone.
            // if we need wrap cell of 3 row then we can go for    $w_text[0],$w_text[1],$w_text[2]
            $this->SetX($x_axis);
            $this->Cell($c_width, $w_w_1, $w_text[0], '', '', '');
            $this->SetX($x_axis);
            $this->Cell($c_width, $w_w1, $w_text[1], '', '', '');
            $this->SetX($x_axis);
            //$this->Cell($c_width,$w_w2,$w_text[2],'','','');// for 3 rows wrap but increase the $c_height it is very important.
            //$this->SetX($x_axis);
            $this->Cell($c_width, $c_height, '', 'LTRB', 0, 'L', 0);
        }
        else {
            $this->SetX($x_axis);
            $this->Cell($c_width, $c_height, $text, 'LTRB', 0, 'L', 0);
        }
    }

}
