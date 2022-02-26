<?php

require('tcpdf.php');

class PDF extends TCPDF {
    
    function masukbrgTbl($header, $data) {
        $w = array(8, 10, 30, 10, 13, 20, 16, 20, 16, 18, 13, 35, 13, 10, 20, 20);

        $i = 0;
        foreach ($header as $col) {
            //$this->Cell($w[$i], 12, $col, 1, 'LR', false);
            $x_axis = $this->Getx();
            $this->vcell($w[$i], 10, $x_axis, $col);
            $i++;
        }
        $this->Ln();

        // Data
        foreach ($data as $row) {
            $i = 0;
            foreach ($row as $col) {
                $x_axis = $this->Getx();
                $this->vcell($w[$i], 10, $x_axis, $col);

                $i++;
            }
            $this->Ln();
        }
    }
    
    function keluarbrgTbl($header, $data) {
        $w = array(8, 10, 30, 12, 13, 19, 14, 18, 14, 20, 13, 45, 10, 10, 23, 17);

        $i = 0;
        foreach ($header as $col) {
            //$this->Cell($w[$i], 12, $col, 1, 'LR', false);
            $x_axis = $this->Getx();
            $this->vcell($w[$i], 10, $x_axis, $col, 0);
            $i++;
        }
        $this->Ln();

        // Data
        foreach ($data as $row) {
            $i = 0;
            foreach ($row as $col) {
                $x_axis = $this->Getx();
                $this->vcell($w[$i], 10, $x_axis, $col, $i);

                $i++;
            }
            $this->Ln();
        }
    }
    
    function wipTbl($header, $data) {
        $w = array(10, 25, 70, 15, 25, 25, 75);

        $i = 0;
        foreach ($header as $col) {
            //$this->Cell($w[$i], 12, $col, 1, 'LR', false);
            $x_axis = $this->Getx();
            $this->vcell($w[$i], 10, $x_axis, $col);
            $i++;
        }
        $this->Ln();

        // Data
        foreach ($data as $row) {
            $i = 0;
            foreach ($row as $col) {
                $x_axis = $this->Getx();
                $this->vcell($w[$i], 10, $x_axis, $col);

                $i++;
            }
            $this->Ln();
        }
    }
    
    function brgscrapTbl($header, $data) {
        $w = array(10, 19, 80, 10, 18, 18, 18, 18, 18, 18, 18, 18, 15);

        $i = 0;
        foreach ($header as $col) {
            //$this->Cell($w[$i], 12, $col, 1, 'LR', false);
            $x_axis = $this->Getx();
            $this->vcell($w[$i], 10, $x_axis, $col);
            $i++;
        }
        $this->Ln();

        // Data
        foreach ($data as $row) {
            $i = 0;
            foreach ($row as $col) {
                $x_axis = $this->Getx();
                $this->vcell($w[$i], 10, $x_axis, $col);

                $i++;
            }
            $this->Ln();
        }
    }

    function mutasiMesinTbl($header, $data) {
        $w = array(10, 24, 60, 10, 18, 18, 18, 18, 18, 18, 18, 35);

        $i = 0;
        foreach ($header as $col) {
            //$this->Cell($w[$i], 12, $col, 1, 'LR', false);
            $x_axis = $this->Getx();
            $this->vcell($w[$i], 10, $x_axis, $col);
            $i++;
        }
        $this->Ln();

        // Data
        foreach ($data as $row) {
            $i = 0;
            foreach ($row as $col) {
                $x_axis = $this->Getx();
                $this->vcell($w[$i], 10, $x_axis, $col);

                $i++;
            }
            $this->Ln();
        }
    }    

    function vcell($c_width, $c_height, $x_axis, $text, $i) {
        $w_w = $c_height / 3;
        $w_w_1 = $w_w + 2;
        $w_w1 = $w_w + $w_w + $w_w + 3;
        // $w_w2=$w_w+$w_w+$w_w+$w_w+3;// for 3 rows wrap
        $len = strlen($text); // check the length of the cell and splits the text     
        //check width of column, if enough just go with it
        if ($len > 5) {
            if ($i == 13 || $i == 15) {
                $this->SetX($x_axis);
                $this->MultiCell($c_width,$c_height,$text,1,'R',0,0, '', '', true, 0, false, true, $c_height, 'M');
            } else {
                $this->SetX($x_axis);
                $this->MultiCell($c_width,$c_height,$text,1,'C',0,0, '', '', true, 0, false, true, $c_height, 'M');
            }
        }
        else {
            if ($i == 13 || $i == 15) {
                $this->SetX($x_axis);
                $this->Cell($c_width, 10, $text, 1, 0, 'R', 0);
            } else {
                $this->SetX($x_axis);
                $this->Cell($c_width, 10, $text, 1, 0, 'C', 0);
            }
        }
    }

}
