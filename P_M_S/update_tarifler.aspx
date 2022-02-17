<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="update_tarifler.aspx.cs" Inherits="P_M_S.update_tarifler" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">

<style type="text/css">

       body{
		background: #eeeeee;
		font-family: 'Open Sans', sans-serif;
	}
    .form-inline {
        display: inline-block;
    }
	.navbar-header.col {
		padding: 0 !important;
	}	
	.navbar {
		font-size: 14px;
		background: #fff;
		padding-left: 16px;
		padding-right: 16px;
		border-bottom: 1px solid #d6d6d6;
		box-shadow: 0 0 4px rgba(0,0,0,.1);		
	}
	.navbar .navbar-brand {
		color: #555;
		padding-left: 0;
		font-size: 20px;
		padding-right: 50px;
		font-family: 'Raleway', sans-serif;
		text-transform: uppercase;
	}
	.navbar .navbar-brand b {
		font-weight: bold;
		color: #f04f01;
	}
	.navbar ul.nav li {
		font-size: 96%;
		font-weight: bold;		
		text-transform: uppercase;
	}
	.navbar ul.nav li.active a, .navbar ul.nav li.active a:hover, .navbar ul.nav li.active a:focus {
		color: #f04f01 !important;
		background: transparent !important;
	}
	.search-box {
        position: relative;
    }
	.search-box input.form-control, .search-box .btn {
		font-size: 14px;
		border-radius: 2px !important;
	}
	.search-box .input-group-btn {
		padding-left: 4px;		
	}
	.search-box input.form-control:focus {
		border-color: #f04f01;
		box-shadow: 0 0 8px rgba(240,79,1,0.2);
	}
	.search-box .btn-primary, .search-box .btn-primary:active {
		font-weight: bold;
		background: #f04f01;
		border-color: #f04f01;
		text-transform: uppercase;
		min-width: 90px;
	}
	.search-box .btn-primary:focus {
		outline: none;
		background: #eb4e01;
		box-shadow: 0 0 8px rgba(240,79,1,0.2);
	}
	.search-box .btn span {
		transform: scale(0.9);
		display: inline-block;
	}
	.navbar .nav-item i {
		font-size: 18px;
	}
	.navbar .dropdown-item i {
		font-size: 16px;
		min-width: 22px;
	}
	.navbar .nav-item.open > a {
		background: none !important;
	}
	.navbar .dropdown-menu {
		border-radius: 1px;
		border-color: #e5e5e5;
		box-shadow: 0 2px 8px rgba(0,0,0,.05);
	}
	.navbar .dropdown-menu li a {
		color: #777;
		padding: 8px 20px;
		line-height: normal;
		font-size: 14px;
	}
	.navbar .dropdown-menu li a:hover, .navbar .dropdown-menu li a:active {
		color: #333;
	}
	.navbar .navbar-form {
		border: none;
	}
	@media (min-width: 992px){
		.form-inline .input-group .form-control {
			width: 225px;			
		}
	}
	@media (max-width: 992px){
		.form-inline {
			display: block;
		}
	}








	body {
		color: #999;
		background: #fafafa;
		font-family: 'Roboto', sans-serif;
	}
	.form-control {
        min-height: 41px;
		box-shadow: none;
		border-color: #e6e6e6;
	}
	.form-control:focus {
		border-color: #00c1c0;
	}
    .form-control, .btn {        
        border-radius: 3px;
    }
	.signup-form {
		width: 425px;
		margin: 0 auto;
		padding: 30px 0;
	}
	.signup-form h2 {
		color: #333;
		font-weight: bold;
        margin: 0 0 25px;
    }
    .signup-form form {
    	margin-bottom: 15px;
        background: #fff;
		border: 1px solid #f4f4f4;
        box-shadow: 0px 2px 2px rgba(0, 0, 0, 0.3);
        padding: 40px 50px;
    }
	.signup-form .form-group {
		margin-bottom: 20px;
	}
	.signup-form label {
		font-weight: normal;
		font-size: 13px;
	}
	.signup-form input[type="checkbox"] {
		margin-top: 2px;
	}    
    .signup-form .btn {        
        font-size: 16px;
        font-weight: bold;
		background: #00c1c0;
		border: none;
		min-width: 140px;
        outline: none !important;
    }
	.signup-form .btn:hover, .signup-form .btn:focus {
		background: #00b3b3;
	}
	.signup-form a {
		color: #00c1c0;
		text-decoration: none;
	}	
	.signup-form a:hover {
		text-decoration: underline;
	}
</style>
</head>
<body>
    <form id="form1" runat="server">
            <nav class="navbar navbar-default navbar-expand-lg navbar-light">
	<div class="navbar-header d-flex col">
		<a class="navbar-brand" href="#">Admin<b>Səhifəsi</b></a>  		
		<button type="button" data-target="#navbarCollapse" data-toggle="collapse" class="navbar-toggle navbar-toggler ml-auto">
			<span class="navbar-toggler-icon"></span>
			<span class="icon-bar"></span>
			<span class="icon-bar"></span>
			<span class="icon-bar"></span>
		</button>
	</div>
	<!-- Collection of nav links, forms, and other content for toggling -->
	<div id="navbarCollapse" class="collapse navbar-collapse justify-content-start">
		<ul class="nav navbar-nav">
					
			
	</div>
</nav>






       <div class="signup-form">
    <form action="/examples/actions/confirmation.php" method="post">
		<h2>Tariflər</h2>
        <div class="form-group">
            <asp:TextBox ID="saat_id" placeholder="Saat" CssClass="form-control" runat="server"></asp:TextBox>
        	<%--<input type="text" id="user_id" class="form-control" name="username" placeholder="İstifadəçi Adı"  required="required">--%>
        </div>
         <div class="form-group">
             <asp:TextBox ID="gun_id" placeholder="gün" CssClass="form-control" runat="server"></asp:TextBox>
        	<%--<input type="text" id="addres_id" class="form-control" name="username" placeholder="Ünvan" required="required">--%>
        </div>

        <div class="form-group">
        	<%--<input type="email" id="mail_id" class="form-control" name="email" placeholder="Email" required="required">--%>
            <asp:TextBox ID="hefte_id" placeholder="Həftə" CssClass="form-control" runat="server"></asp:TextBox>
        </div>

            <div class="form-group">
                 <asp:TextBox ID="ay_id" placeholder="Ay" CssClass="form-control" runat="server"></asp:TextBox>
                <%--<input type="text" id="mf_id" class="form-control" name="male_female" placeholder="Gender: M və ya F" required="required">--%>
            </div>       
       
		<div class="form-group">
             <asp:Button ID="Save" CssClass="btn btn-secondary" runat="server" Text="Submit" OnClick="Entire_Click"/>
            <%--<button type="submit" id="save_id" class="btn btn-primary btn-lg" onclick="Save_Click">Yadda Saxla</button>--%>
        </div>
    </form>
	
</div>
    </form>
</body>
    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>
</html>