<%@page language="java" import="java.sql.*" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>

<script type="text/javascript">
	function validlogin()
{

    if (document.loginform.username.value == "")
    {
        alert ( "Please enter USERNAME." );
		document.loginform.username.focus();
        return false;
    }
	 if (document.loginform.password.value == "")
    {
        alert ( "Please enter PASSWORD." );
		document.loginform.password.focus();
        return false;
    }
    if (document.loginform.types.value == "Select")
    {
        alert ( "Please select your TYPE." );
		document.loginform.types.focus();
        return false;
    }
	return true;
}
	
	</script>



<table align="center">
	<tr>
		<td><h2>
				<font color="white">.</font>
			</h2> <font color="white"> .</font>
			<h2>
				<font color="white">.</font>
			</h2></td>
	</tr>
</table>

<form name="loginform" onsubmit="return validlogin()" method="post"
	action="validate.jsp">

	<table width="300px" align="center"
		style="background-color: #003366; border-color: #0080c0; border-width: 4px; border-style: solid"
		bgcolor="#0080ff">
		<tr>
			<td colspan="2" align="center"><b><font color="white">Login
						Authentication</font> </b></td>
		</tr>
		<tr>
			<td colspan="2">&nbsp;</td>
		</tr>
		<tr>
			<td><b> <font color="white">Username</font> </b></td>
			<td><input type="text" name="username" value=""></td>
		</tr>
		<tr>
			<td><font color="white"><b>Password</b>
			</font>
			</td>
			<td><input type="password" name="password" value=""></td>
		</tr>

		<tr>
			<td><b><font color="white">Type</font> </b>
			</td>
			<td><select name="types"><option value="Doctor">Doctor</option>
					<option value="Medical Personnel">Medical Personnel</option>
					<option value="Finance Deptt">Finance Deptt.</option>
					<option value="Select" selected>Select</option>
			</select></td>
		</tr>
		<tr>
			<td></td>
			<td valign="middle"><input type="submit" name="submit"
				value="Login"></td>
		</tr>
		<tr>
			<td colspan="2"><b><font color="red">New user: </font> <a
					href="register.jsp"><font color="teal" size="3"
						face="@Arial Unicode MS">Register
				</a> </font><font color="#ff8000" size="3" face="@Arial Unicode MS"> </font><font
					color="yellow" size="3" face="@Arial Unicode MS"> </font><font
					color="teal" size="3" face="@Arial Unicode MS"> </font><font
					color="aqua" size="3" face="@Arial Unicode MS"> </font> </b>
			</td>
		</tr>
	</table>
</form>