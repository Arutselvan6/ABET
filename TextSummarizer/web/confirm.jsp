<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">

<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Insert title here</title>
</head>
<body background="image/TEST.jpg" style="background-repeat:no-repeat; background-position:center">
<% 
String uname= request.getParameter("username");
String pass= request.getParameter("password");
String mailid= request.getParameter("Emailid");
%>

<form method="POST" action="login.jsp">
<center><table bgcolor="red" cellpadding=2 cellspacing=0 border=0 width="100%" height="10%">
<tr><td align="Left"><a STYLE="text-decoration:none" href="registration.jsp"><font face="Century Gothic,arial" size=4 color="white"><b>| Back |</b></font></a>
<a STYLE="text-decoration:none" href="index.jsp"><font face="Century Gothic,arial" size=4 color="white"><b>| Home |</b></font></a></td>
<td align="right"><font face="Century Gothic,arial" size=5 color="white"><b>| WELCOME TO SOMMARIO |</b></font></td></tr></table><br>

<jsp:useBean id="reg" class="com.Registration"></jsp:useBean>
<%
if(uname.equals("")||pass.equals("")||mailid.equals(""))
{	
	out.println("<font face='verdana,arial' size=6 color='yellow'><b>Enter the All Fileds</b></font>");
}
else if(reg.UserAdd(uname,pass,mailid,"SUMMARI"))
  {	
	
	out.println("<center><table><tr><td><font face='verdana,arial' size=3>Username:</font></td>");
	out.println("<td><font face='verdana,arial' size=4><input type='text' disabled='disabled' name='username' value="+uname+"></font></td></tr>");
	out.println("<tr><td><font face='verdana,arial' size=3>Password:</font></td>");
	out.println("<td><font face='verdana,arial' size=4><input type='text' disabled='disabled' name='password' value="+pass+"></font></td></tr>");
	out.println("<tr><td><font face='verdana,arial' size=3>Email:</font></td>");
	out.println("<td><font face='verdana,arial' size=4><input type='text' disabled='disabled' name='mail' value="+mailid+"></font></td></tr>");
	out.println("</table></center><br><br>");
	  
	out.println("<font face='verdana,arial' size=7 color='Green'><b>Register Successfully</b></font>");
	  
  }
  else
  {
	  out.println("<font face='verdana,arial' size=5 color='Red'><b>Register UnSuccessfully</b></font>");
  }  
%>

<p><input type="submit" value="<< Login >>" name="B1"></p>
</center></form>
 

</body>
</html>