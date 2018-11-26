<%@page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>

<%@taglib uri="http://java.sun.com/jsp/jstl/fmt" prefix="fmt"%>
<script type="text/javascript">
	function validdreg()
{

    if (document.devicereg.devicename.value == "")
    {
        alert ( "Please enter your Device Name." );
		document.devicereg.devicename.focus();
        return false;
    }
	 if (document.devicereg.deviceid.value == "")
    {
        alert ( "Please enter deviceid." );
		document.devicereg.deviceid.focus();
        return false;
    }
    if (document.devicereg.devicetype.value == "")
    {
        alert ( "Please enter device type." );
		document.devicereg.devicetype.focus();
        return false;
    }
    if (document.devicereg.quantity.value == "")
    {
        alert ( "Please enter quantity." );
		document.devicereg.quantity.focus();
        return false;
    }
    if (document.devicereg.manufacturer.value == "")
    {
        alert ( "Please enter device manufacturer." );
		document.devicereg.manufacturer.focus();
        return false;
    }
    if (document.devicereg.purchasedate.value == "")
    {
        alert ( "Please enter device purchase date." );
		document.devicereg.purchasedate.focus();
        return false;
    }
    
	return true;
}
	
	</script>

<p
	align="center">
	<b>Device Registration Form 
	</b>
</p>
<form action="devregval.jsp" name="devicereg" onsubmit="return validdreg()" method="post">
	<center>
		<table border="0" cellpadding="2" cellspacing="10">
			<tbody>
				<tr>
					<td>Device Name</td>
					<td><input type="text" name="devicename" size="30" maxlength="20">
					</td>
				</tr>
				<tr>
					<td valign="top">Device ID</td>
					<td><input type="text" name="deviceid" size="30" maxlength="50">
					</td>
				</tr>
				<tr>
					<td>Device Type</td>
					<td><input type="text" name="devicetype" size="30"
						maxlength="20">
					</td>
				</tr>
				<tr>
					<td>Quantity</td>
					<td><input type="text" name="quantity" size="30" maxlength="2">
					</td>
				</tr>
				<tr>
					<td>Manufacturer</td>
					<td><input type="text" name="manufacturer" size="30"
						maxlength="20"></td>
				</tr>
				<tr>
					<td>Purchase Date <font color="teal"></font><font size="-1"
						color="red">(YYYY-MM-DD)</font>
					</td>
					<td><input type="text" name="purchasedate" size="30" maxlength="20">
					</td>
				</tr>
				<tr>
					<td></td>
					<td></td>
				</tr>
				<tr>
					<td></td>
					<td><input type="submit" name="submit" value="submit">
					</td>
				</tr>
			</tbody>
		</table>
	</center>
</form>

