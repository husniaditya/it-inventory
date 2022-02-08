<?php
require("header.php");

unset($_SESSION["name"]);
unset($_SESSION["role"]);

?>
<div id="page-wrapper">
    <div class="row">
        <div class="col-lg-12">
            <h1 class="page-header">Login</h1>
        </div>
        <!-- /.col-lg-12 -->
    </div>
    <!-- /.row -->
    <div class="row">
        <div class="col-lg-12">
        <form class="form-horizontal" role="form" method="post" action="login.php">
            <div class="form-group">
                <label for="username" class="col-sm-1 control-label">Username</label>
                    <div class="col-sm-2">
                        <input type="text" class="form-control" id="username" name="txtUserID" placeholder="Username" value="">
                    </div>
            </div>
            <div class="form-group">
                <label for="password" class="col-sm-1 control-label">Password</label>
                    <div class="col-sm-2">
                        <input type="password" class="form-control" id="password" name="txtPassword" placeholder="Password" value="">
                    </div>
            </div>
            <div class="form-group">
                <div class="col-sm-10 col-sm-offset-1">
                    <input id="submit" name="btnLogin" type="submit" value="Login" class="btn btn-success">
                </div>
            </div>
            <div class="form-group">
            <div class="col-sm-10 col-sm-offset-1">
            <?php
            if (!empty($_POST["btnLogin"])) {
                $result = mysql_query("SELECT `user`, `name` FROM `usr` WHERE `user`='" . $_POST["txtUserID"] . "' and `pswd`='" .
                        $_POST["txtPassword"] . "'", $db_con);
                if (mysql_num_rows($result) == 0) {
                    echo MessageBox("alert alert-danger", "ERROR", "User ID atau Password yang anda masukkan salah!");
                } else {
                    $row = mysql_fetch_assoc($result);
                    $_SESSION["userid"] = $_POST["txtUserID"];
                    $_SESSION["name"] = $row["name"];
                    getParamData();
                    
                    if (isset($_GET["url"]))
                        header("Location: " . $_GET["url"]);
                    else
                        header("Location: default.php");
                }
            }
            ?>
            </div>
            </div>
        </form>
<?php
require("footer.php");
?>