<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
    <%@page import="java.sql.*"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">

<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<%
String uname,pass;
if("1".equals((String)session.getAttribute("loginfo")))
{
	 uname= request.getParameter("username");
	 pass= request.getParameter("password");	
}
else
{
	uname=(String)session.getAttribute("username"); 
	pass= (String)session.getAttribute("password");;
}

%>


</head>
<body background="image/TEST.jpg" style="background-repeat:no-repeat; background-position:center">


<center><table bgcolor="red" cellpadding=2 cellspacing=0 border=0 width="100%" height="10%">
<tr><td align="Left"><a STYLE="text-decoration:none" href="login.jsp"><font face="Century Gothic,arial" size=4 color="white"><b>| Back |</b></font></a>
<a STYLE="text-decoration:none" href="index.jsp"><font face="Century Gothic,arial" size=4 color="white"><b>| Home |</b></font></a>
<a STYLE="text-decoration:none" href="logout.jsp"><font face="Century Gothic,arial" size=4 color="white"><b>| Logout |</b></font></a></td>
<td align="right"><font face="Century Gothic,arial" size=5 color="white"><b>| WELCOME TO SOMMARIO |</b></font></td></tr></table>
<marquee behavior="alternate" bgcolor="pink"> MINE INFORMATION, EXTRACT KNOWLEDGE</marquee>

<jsp:useBean id="reg" class="com.Registration"></jsp:useBean>
<%

if(reg.FindUser(uname,pass,"SUMMARI"))
  {
	  out.println("<title>Welcome, "+uname+"</title>");
	  //out.println("user"+uname);
	  //out.println("pass"+pass);
	  out.println("<font face='verdana,arial' size=6 color='blue'><b>Login Successfull </b></font> ");
	  session.setAttribute("username",uname);
	  session.setAttribute("password",pass);
	  
	  
  %>
  <br><br><FORM  ENCTYPE="multipart/form-data" ACTION="Upload.jsp" METHOD=POST>
<br><br><br><font face="Century Gothic,arial" size=6 color="yellow"><b>choose to upload  : </b></font>
<input type="file" style="width:200px" style="height:50px" name="F1"><br><br><br>
<font face="Century Gothic,arial" size=5 color="yellow"> NOTE: If your Input file format is pdf, that file must have one page without image</font>
<br><br><INPUT TYPE="submit" style="width:150px" style="height:50px" VALUE="Send File" ><br><br><br><br><br><br><br><br><br><br><br><br><br>
</FORM>  
	
  <%} 
  
  else
  {
	  out.println("<title>Login UnSuccessfull</title>");
	  out.println("<font face='verdana,arial' size=6 color='red'><b>Login UnSuccessfull </b></font> ");
	  out.println("<br><br><font face='verdana,arial' size=5 color='blue'><b>User Name: "+uname+"</b></font> ");%>
	  <br><br><br><br><a  STYLE="text-decoration:none" href="login.jsp"><font face="Century Gothic,arial" size=7 color="green"><b>Login</b></font></a>
	  
	  <%}  
%>

</body>
</html>