<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Login Page</title>
</head>
<body background="image/TEST.jpg" style="background-repeat:no-repeat; background-position:center">

<center>

<table bgcolor="red" cellpadding=2 cellspacing=0 border=0 width="100%" height="10%">

<tr>
<td align="Left"><a STYLE="text-decoration:none" href="index.jsp"><font face="Century Gothic,arial" size=4 color="white"><b>| Home |</b></font></a>
<a STYLE="text-decoration:none" href="C:\Documents and Settings\db2admin\Desktop\ast\ast.html"><font face="Century Gothic,arial" size=4 color="white"><b>| Help |</b></font></a></td>
<td align="right"><font face="Century Gothic,arial" size=5 color="white"><b>| WELCOME TO SOMMARIO |</b></font></td>

</tr></table>
<marquee behavior="alternate" bgcolor="pink">MINE INFORMATION, EXTRACT KNOWLEDGE</marquee>

<br><br>

<TABLE height=100%" width=100%>

 <TR height=60% >		

<td height=100%>
<table cellpadding=30 cellspacing=20 border=40>
<tr><td bgcolor="blue"><table cellpadding=0 cellspacing=0 border=0 width=100%><tr><td bgcolor="blue" align=center style="padding:2;padding-bottom:4"><b><font size=7 color="white">Welcome to login</font></b></tr>
<tr><td bgcolor="red" style="padding:5">
<form method="post" action="loginaction.jsp">

<center>

<table> 
<tr><td><font face="verdana,arial" size=5>Login:</font></td><td><input type="text" name="username"></td></tr>
<tr><td><font face="verdana,arial" size=5>Password:</font></td><td><input type="password" name="password"></td></tr>
<tr><td><font face="verdana,arial" size=3>&nbsp;</font></td><td align="center"><font face="verdana,arial" size=5><input type="submit" value="Submit" name="B1"></font></td></tr>
<tr><td colspan=2><font face="verdana,arial" size=3>&nbsp;</font></td></tr>

<tr><td colspan=2><font face="verdana,arial" size=-1>Not member yet? Click <a href="registration.jsp">here</a> to register.</font></td></tr>
</table></center>
</form>
</td></tr></table></td></tr></table><BR><BR>
<marquee bgcolor=yellow width=350 height=20 direction=right behavior=alternate scrollamount=5> SOFTWARE DEVELOPED BY TRIUNFADORS </marquee>
<%session.setAttribute("loginfo","1"); %>
</td></TR></TABLE></center></body>
</html>