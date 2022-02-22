<?php
require("header.php");

unset($_SESSION["name"]);
unset($_SESSION["role"]);
?>
<div class="row col-md-4 col-md-offset-4 kotak color-navy" style="color: white;border-radius: 20px;">
    <div>
        <div class="col-lg-12" align="center">
            <h2 class="page-header">WIS - Bonded Zone</h2>
            <img class="img-responsive" id="foto" src="images/icon.png" style="height: 20%;">
            <br>
            <form method="post" action="login.php">
                <div class="form-group glow">
                    <div class="input-group">
                        <span class="input-group-addon"><span class="glyphicon glyphicon-user"></span></span>
                        <input type="text" class="form-control" id="username" name="txtUserID" placeholder="Username" value="">
                    </div>
                </div>
                <div class="form-group glow">
                    <div class="input-group">
                        <span class="input-group-addon"><span class="glyphicon glyphicon-lock"></span></span>
                        <input type="password" class="form-control" id="password" name="txtPassword" placeholder="Password" value="">
                    </div>
                </div>
                <div class="form-group glow">
                    <div>
                        <input id="submit" name="btnLogin" type="submit" value="Login" class="btn btn-primary btn-lg btn-block">
                    </div>
                </div>
                <br>
                <div class="form-group">
                    <div class="col-sm-12 col-sm-offset-1">
                    <?php
                    if (!empty($_POST["btnLogin"])) 
                    {
                        $result = mysql_query("SELECT `user`, `name` FROM `usr` WHERE `user`='" . $_POST["txtUserID"] . "' and `pswd`='" .
                                $_POST["txtPassword"] . "'", $db_con);
                        
                        if (mysql_num_rows($result) == 0) 
                        {
                            echo MessageBox("alert alert-danger", "ERROR", "User ID atau Password yang anda masukkan salah!");
                        }
                        else 
                        {
                            $row = mysql_fetch_assoc($result);
                            $_SESSION["userid"] = $_POST["txtUserID"];
                            $_SESSION["name"]   = $row["name"];
                            getParamData();
                            
                            if (isset($_GET["url"]))
                                header("Location: " . $_GET["url"]);
                            else
                                header("Location: default");
                        }
                    }
                    ?>
                    </div>
                </div>
            </form>
<?php
require("footer.php");
?>