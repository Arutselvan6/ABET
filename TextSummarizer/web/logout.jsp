<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<%@page import="java.sql.*"%>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Logout</title>
</head>
<body background="image/TEST.jpg" style="background-repeat:no-repeat; background-position:center">

<center><table bgcolor="red" cellpadding=2 cellspacing=0 border=0 width="100%" height="10%">
<tr><td align="Left">
<a STYLE="text-decoration:none" href="index.jsp"><font face="Century Gothic,arial" size=4 color="white"><b>| Home |</b></font></a>
<td align="right"><font face="Century Gothic,arial" size=5 color="white"><b>| WELCOME TO SOMMARIO |</b></font></td></tr></table>
<marquee behavior="alternate" bgcolor="pink">MINE INFORMATION, EXTRACT KNOWLEDGE</marquee>



<%
String username = (String)session.getAttribute("username");

try{
	Class.forName("com.mysql.jdbc.Driver");

	Connection connection =	DriverManager.getConnection("jdbc:mysql://localhost/SUMMARI","root","");
	Statement statement;
	
	statement = connection.createStatement();
					
	   statement.executeUpdate("DROP TABLE "+username);

}catch (Exception e) {
			
	}
session.invalidate();

out.println("<center><br><br><br><br><br><br><br><br><font face='verdana,arial' size=8 color='yellow'><b>Successfull Logout! </b></font></center> ");%>


</body>
</html>