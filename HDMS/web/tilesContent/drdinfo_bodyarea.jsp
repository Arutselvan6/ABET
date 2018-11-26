<%@page import="java.sql.*" language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%><jsp:useBean id="db"
	class="database.DataConnect"></jsp:useBean>
<p align="center">Device Details</p>
<p></p>
<p></p>

<form method="post" action="drdinfoval.jsp">
	<center>
		<table border="0" cellpadding="5" cellspacing="5">
			<tbody>
				<tr>
					<td>Device Detail</td>
					<td><select name="devicename"><option value="none"
								selected>Select</option>
							<%
				db.connect();
				String deviceid=request.getParameter("deviceid");
				ResultSet rs=db.execute("SELECT DEVICENAME FROM DEVICE");
				System.out.println("query loaded successfully");
				while(rs.next())
				{ 
			%><option value="<%=rs.getString("devicename")%>"><%=rs.getString("devicename")%></option>
							<%
 }
     %>
					</select></td>
					<td><input type="submit" name="submit" value="Get"></td>
				</tr>
			</tbody>
		</table>
	</center>
</form>
