<%@page language="java" import="java.sql.*"
contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<jsp:useBean id="db" class="database.DataConnect"></jsp:useBean>
<p align="center">
	<b><font face="Segoe WP Semibold" size="+1">Device Details</font> </b>
</p>

<form method="get" action="devicedetailval.jsp">
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
					</select>
					</td>
					<td><input type="submit" name="submit" value="Get">
					</td>
				</tr>
			</tbody>
		</table>
	</center>
</form>
