<%@page import="java.sql.*" language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%><jsp:useBean id="db"
	class="database.DataConnect"></jsp:useBean>
	
	<script type="text/javascript">
	function validdreq()
{

    if (document.devicerequest.devicename.value == "none")
    {
        alert ( "Please enter your Device Name." );
		document.devicerequest.devicename.focus();
        return false;
    }
	 if (document.devicerequest.quantity.value == "")
    {
        alert ( "Please enter your quantity." );
		document.devicerequest.quantity.focus();
        return false;
    }
    if (document.devicerequest.appointment.value == "")
    {
        alert ( "Please enter appointment date." );
		document.devicerequest.appointment.focus();
        return false;
    }
    if (document.devicerequest.usageduration.value == "")
    {
        alert ( "Please enter usage duration." );
		document.devicerequest.usageduration.focus();
        return false;
    }
    
	return true;
}
	
	</script>
	
	
<p align="center">
	<font size="+2"> Device Request !</font><font size="+1"> </font>
</p>
<p></p>
<p>
	<font color="white">.</font><br>
</p>
<form method="post" name="devicerequest" onsubmit="return validdreq()" action="drdreqval.jsp">
<center>
	<table border="0" cellpadding="5" cellspacing="5">
		<tbody>
			<tr>
				<td>Device Name</td>
				<td><select name="devicename"><option value="none">Select</option>
						<%
				db.connect();
				ResultSet rs=db.execute("SELECT DEVICENAME FROM DEVICE");
				System.out.println("query loaded successfully");
				while(rs.next())
				{ 
			%><option value="<%=rs.getString("devicename")%>"><%=rs.getString("devicename")%></option>
						<%
 }
     %>
				</select></td>
			</tr>
				<tr>
					<td>Username</td>
					<td><input type="text" name="username" size="20" readonly value='<%= session.getAttribute( "username" ) %>'>
					</td>
				</tr>
				<tr>
				<td>Quantity</td>
				<td><input type="text" name="quantity" size="20" maxlength="5">
				</td>
			</tr>
			<tr>
				<td>Device Appointment Date<font size="-1" color="red">(YYYY-MM-DD)</font>
				</td>
				<td><input type="text" name="appointment" size="20"
					maxlength="10"></td>
			</tr>
			<tr>
				<td>Device Usage Duration <font size="-1" color="red">(Hours)</font>
				</td>
				<td><input type="text" name="usageduration" size="20"
					maxlength="5"></td>
			</tr>
			<tr>
				<td></td>
				<td><input type="submit" name="submit" value="submit">
				</td>
			</tr>
			<tr>
				<td></td>
				<td></td>
			</tr>
			<tr>
				<td></td>
				<td></td>
			</tr>
			<tr>
				<td></td>
				<td></td>
			</tr>
		</tbody>
	</table></form>
</center>
<p></p>

