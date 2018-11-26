<%@page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%><p align="center">
	<script type="text/javascript">
	function validdrreg()
{

    if (document.drregisterform.first_name.value == "")
    {
        alert ( "Please enter your First Name." );
		document.drregisterform.first_name.focus();
        return false;
    }
	 if (document.drregisterform.last_name.value == "")
    {
        alert ( "Please enter your Last Name." );
		document.drregisterform.last_name.focus();
        return false;
    }
    if (document.drregisterform.doctorid.value == "")
    {
        alert ( "Please enter your DoctorID." );
		document.drregisterform.doctorid.focus();
        return false;
    }
    if (document.drregisterform.password.value == "")
    {
        alert ( "Please enter your Password." );
		document.drregisterform.password.focus();
        return false;
    }
    if (document.drregisterform.types.value == "")
    {
        alert ( "Please select your Type." );
		document.drregisterform.types.focus();
        return false;
    }
    if (document.drregisterform.specialisation.value == "none")
    {
        alert ( "Please select your Specialisation." );
		document.drregisterform.specialisation.focus();
        return false;
    }
    var x=document.drregisterform.emailid.value;
	var atpos=x.indexOf("@");
	var dotpos=x.lastIndexOf(".");
	if (atpos<1 || dotpos<atpos+2 || dotpos+2>=x.length)
  	{
 	 alert("Not a valid e-mail address");
  		return false;
 	 }
 	 if (document.drregisterform.phone.value == "")
    {
        alert ( "Please enter your Phone no." );
		document.drregisterform.phone.focus();
        return false;
    }
    if (document.drregisterform.address.value == "")
    {
        alert ( "Please enter your Address." );
		document.drregisterform.address.focus();
        return false;
    }
    if (document.drregisterform.city.value == "")
    {
        alert ( "Please select your city." );
		document.drregisterform.city.focus();
        return false;
    }
    if (document.drregisterform.States.value == "")
    {
        alert ( "Please select your State." );
		document.drregisterform.States.focus();
        return false;
    }
    if (document.drregisterform.country.value == "")
    {
        alert ( "Please select your country." );
		document.drregisterform.country.focus();
        return false;
    }
	return true;
}
	
	</script>
	<b>Doctor Registration Form</b>
</p>
<p align="center"></p>
<center>
	<form name="drregisterform" onsubmit="return validdrreg()" method="post" action="drregisterval.jsp"><table border="0" width="324" cellspacing="2" cellpadding="5">
			<tbody >
				<tr>
					<td width="139">First Name</td>
					<td width="172"><input type="text" name="first_name" size="20"
						maxlength="20"></td>
				</tr>
				<tr>
					<td width="139">Last Name</td>
					<td width="172"><input type="text" name="last_name" size="20"
						maxlength="10"></td>
				</tr>
				<tr>
					<td width="139">Doctor ID</td>
					<td width="172"><input type="text" name="doctorid" size="20"
						maxlength="10"></td>
				</tr>
				<tr>
					<td width="139">Password</td>
					<td width="172"><input type="password" name="password"
						size="20" maxlength="10"></td>
				</tr>
				<tr>
					<td width="139">Type</td>
					<td width="172"><select name="types"><option
								value="Medical Personnel">Medical Personnel</option>
							<option value="Doctor">Doctor</option>
							<option value="Finance Deptt">Finance Deptt</option>
							<option selected>Select</option>
					</select>
					</td>
				</tr>
				<tr>
					<td width="139">Gender</td>
					<td style="width: 194px" width="172"><input type="radio"
						name="gender" value="male" checked>Male <input type="radio"
						name="gender" value="female">Female</td>
				</tr>
				<tr>
					<td width="139">Specialisation</td>
					<td width="172"><select name="specialisation"><option
								value="Heart Surgeon">Heart Surgeon</option>
							<option value="Brain Surgeon">Brain Surgeon</option>
							<option value="Dentist">Dentist</option>
							<option value="none" selected>Select</option>
					</select></td>
				</tr>
				<tr>
					<td width="139">Email ID</td>
					<td width="172"><input type="text" name="emailid" size="20"
						maxlength="20"></td>
				</tr>
				<tr>
					<td width="139" style="width: 139px">Phone</td>
					<td width="172"><input type="text" name="phone" size="20"
						maxlength="10"></td>
				</tr>
				<tr>
					<td width="139">Address</td>
					<td width="172" style="width: 172px"><input type="text"
						name="address" size="20" maxlength="30"></td>
				</tr>
				<tr>
					<td width="139">City</td>
					<td width="172"><select name="city"><option
								value="New Delhi">New Delhi</option>
							<option value="Mumbai">Mumbai</option>
							<option value="Kolkata">Kolkata</option>
							<option value="Chennai">Chennai</option>
							<option value="" selected>Select</option>
					</select></td>
				</tr>
				<tr>
					<td width="139">State</td>
					<td width="172"><select name="States"><option
								value="Bihar">Bihar</option>
							<option value="Maharashtra">Maharashtra</option>
							<option value="Tamil Nadu">Tamil Nadu</option>
							<option value="West Bengal">West Bengal</option>
							<option value="" selected>Select</option>
					</select></td>
				</tr>
				<tr>
					<td width="139">Country</td>
					<td width="172"><select name="country"><option
								value="India">India</option>
							<option value="Pakistan">Pakistan</option>
							<option value="USA">USA</option>
							<option value="UK">UK</option>
							<option value="" selected>Select</option>
					</select></td>
				</tr>
				<tr>
					<td width="139"></td>
					<td width="172"><input type="submit" name="submit"
						value="Register"></td>
				</tr>
			</tbody>
		</table>
		<br></form>
</center>

