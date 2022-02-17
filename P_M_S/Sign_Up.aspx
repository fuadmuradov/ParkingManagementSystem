<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sign_Up.aspx.cs" Inherits="P_M_S.Sign_Up" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">

<style type="text/css">
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
       <div class="signup-form">
    <form action="/examples/actions/confirmation.php" method="post">
		<h2>Sign Up</h2>
        <div class="form-group">
            <asp:TextBox ID="user_id" placeholder="İstifadəçi Adı" CssClass="form-control" runat="server"></asp:TextBox>
        	<%--<input type="text" id="user_id" class="form-control" name="username" placeholder="İstifadəçi Adı"  required="required">--%>
        </div>
         <div class="form-group">
             <asp:TextBox ID="address_id" placeholder="Ünvan" CssClass="form-control" runat="server"></asp:TextBox>
        	<%--<input type="text" id="addres_id" class="form-control" name="username" placeholder="Ünvan" required="required">--%>
        </div>

        <div class="form-group">
        	<%--<input type="email" id="mail_id" class="form-control" name="email" placeholder="Email" required="required">--%>
            <asp:TextBox ID="mail_id" placeholder="Email" CssClass="form-control" runat="server"></asp:TextBox>
        </div>

            <div class="form-group">
                 <asp:TextBox ID="mf_id" placeholder="Gender" CssClass="form-control" runat="server"></asp:TextBox>
                <%--<input type="text" id="mf_id" class="form-control" name="male_female" placeholder="Gender: M və ya F" required="required">--%>
            </div>    

		<div class="form-group">
           <%-- <input type="password" id="pswrd_id" class="form-control" name="password" placeholder="Şifrə" required="required">--%>
             <asp:TextBox ID="pswrd_id" placeholder="Şifrə" TextMode="Password" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
		    
        <div class="form-group">
			<label class="checkbox-inline"><input type="checkbox" required="required"> I accept the <a href="#">Terms of Use</a> &amp; <a href="#">Privacy Policy</a></label>
		</div>
		<div class="form-group">
             <asp:Button ID="Save" CssClass="btn btn-primary btn-lg" runat="server" Text="Submit" OnClick="Save_Click" />
            <%--<button type="submit" id="save_id" class="btn btn-primary btn-lg" onclick="Save_Click">Yadda Saxla</button>--%>
        </div>
    </form>
	<div class="text-center">Hesabınız var? <a href="#">Daxil Ol</a></div>
</div>
    </form>
</body>
    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>
</html>
