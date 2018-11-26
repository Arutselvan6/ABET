<%@page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%><p align="center">
	<br> <b>New Finance Deptt. Official Registration Form</b>
</p>

<center>
	<table border="0" width="500" cellspacing="5">
		<tbody>
			<tr>
				<td>First Name</td>
				<td><input type="text" name="first_name" size="20">
				</td>
			</tr>
			<tr>
				<td>Last Name</td>
				<td><input type="text" name="last_name" size="20">
				</td>
			</tr>
			<tr>
				<td>Finance Deptt. ID</td>
				<td><input type="text" name="doctorid" size="20">
				</td>
			</tr>
			<tr>
				<td>Password</td>
				<td><input type="password" name="password" size="20">
				</td>
			</tr>
			<tr>
				<td>Gender</td>
				<td><input type="radio" name="Gender" value="male" checked>
					Male</td>
			</tr>
			<tr>
				<td></td>
				<td><input type="radio" name="Gender" value="female">
					Female</td>
			</tr>
			<tr>
				<td>Email ID</td>
				<td><input type="text" name="emailid" size="20">
				</td>
			</tr>
			<tr>
				<td>Phone</td>
				<td><input type="text" name="phone" size="20">
				</td>
			</tr>
			<tr>
				<td>Address</td>
				<td><input type="text" name="address" size="20">
				</td>
			</tr>
			<tr>
				<td>City</td>
				<td><select name="city"><option>New Delhi</option>
						<option>Mumbai</option>
						<option>Kolkata</option>
						<option>Chennai</option>
				</select>
				</td>
			</tr>
			<tr>
				<td>State</td>
				<td><select name="States"><option>Bihar</option>
						<option>Maharashtra</option>
						<option>Tamil Nadu</option>
				</select>
				</td>
			</tr>
			<tr>
				<td>Country</td>
				<td><select name="country"><option>India</option>
						<option>Pakistan</option>
						<option>USA</option>
						<option>UK</option>
				</select>
				</td>
			</tr>
			<tr>
				<td></td>
				<td><input type="submit" name="submit" value="Register">
				</td>
			</tr>
		</tbody>
	</table>
	<br>
</center>
