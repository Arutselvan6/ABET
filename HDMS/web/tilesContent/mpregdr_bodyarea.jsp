<%@page import="java.sql.*" language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<jsp:useBean id="db" class="database.DataConnect"></jsp:useBean>
<%
db.connect();
ResultSet rs=db.execute("SELECT DOCTORID,FIRST_NAME,GENDER,SPECIALISATION,PHONE FROM DOCTORS");
System.out.println("query loaded successfully");
%><p align="center">DOCTORS PROFILE !</p><p>
<table align="center" cellspacing="0px" cellpadding="5px" border="1">
	<tr>
	 <th>DOCTOR ID</th>
	 <th>FIRST NAME</th>
	 <th>GENDER</th>
	 <th>SPECIALISATION</th>
	 <th>PHONE</th>
	</tr>

<%
while(rs.next())
{ 
%><tr>
	<td><%=rs.getString(1)%></td>
	<td><%=rs.getString(2)%></td>
	<td><%=rs.getString(3)%></td>
	<td><%=rs.getString(4)%></td>
	<td><%=rs.getString(5)%></td>
</tr>
<%
}
%>
</table></p><%
%>

