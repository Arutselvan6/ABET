<%@page language="java" import="java.sql.*" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%><jsp:useBean id="db"
	class="database.DataConnect"></jsp:useBean><p align="center">
	<b>Requested Devices</b>
</p>

<%
db.connect();
ResultSet rs=db.execute("SELECT USERNAME,DEVICENAME,QUANTITY,APPOINTMENT,USAGEDURATION FROM DEVICEREQ ORDER BY USERNAME");
System.out.println("query loaded successfully");
%><p>
<table align="center" cellspacing="0px" cellpadding="5px" border="1">
	<tr>
	 <th>DOCTOR ID</th>
	 <th>DEVICE NAME</th>
	 <th>QUANTITY</th>
	 <th>APPOINTMENT</th>
	 <th>USAGE DURATION (Hour)</th>
	</tr>
<%
while(rs.next())
{ 

%>
	<tr>
	<td><%=rs.getString(1)%></td>
	<td><%=rs.getString(2)%></td>
	<td align="center"><%=rs.getString(3)%></td>
	<td align="center"><%=rs.getString(4)%></td>
	<td align="center"><%=rs.getString(5)%></td>
</tr>
<%
} %></table></p>

