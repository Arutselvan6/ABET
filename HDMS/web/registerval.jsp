<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN"><%@page import="java.sql.*" 
	language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<html>
<head>
<title>registerval</title>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<meta name="GENERATOR" content="Rational® Application Developer for WebSphere® Software">
<style type="text/css"">
	#addmsg{color:#fff;font-size:25px; margin:100px 100px 100px 100px}</style><jsp:useBean
	id="db" class="database.DataConnect"></jsp:useBean>
</head>
<body>
<%
	boolean dbconnect=false;
	dbconnect=db.connect();
  	if(dbconnect!=true){%>
 <jsp:forward page="index.jsp">
 <jsp:param name="error" value="Problem in database connection" />
</jsp:forward><% }

String first_name = request.getParameter("first_name");
String last_name = request.getParameter("last_name");
String username=request.getParameter("doctorid") ;
String password=request.getParameter("password") ;
String gender= request.getParameter("gender") ;
String specialisation=request.getParameter("specialisation") ;
String emailid=request.getParameter("emailid") ;
String phone=request.getParameter("phone") ;
String address=request.getParameter("address") ;
String city=request.getParameter("city") ;
String States=request.getParameter("States") ;
String country=request.getParameter("country") ;

String sql="insert into doctors values('"+first_name+"','"+last_name+"','"+username+"','"+password+"','"+gender+"','"+specialisation+"','"+emailid+"','"+address+"','"+phone+"','"+city+"','"+States+"','"+country+"')";
int r=db.update(sql);
sql="insert into users values('"+username+"','"+password+"')";
int r1=db.update(sql);
if((r!=0)&&(r1!=0))
{ %>
<p id="addmsg">member added sucessfully </p>
<% } else  {%> <p id="addmsg">member addition  is failed</p>
<%} %>

</body>
</html>