<%@page import="java.sql.*" language="java"
	contentType="text/html; charset=ISO-8859-1" pageEncoding="ISO-8859-1"%><jsp:useBean
	id="db" class="database.DataConnect"></jsp:useBean>
<%
	boolean dbconnect=false;
	dbconnect=db.connect();
  	if(dbconnect!=true){%>
<jsp:forward page="devicereg.jsp">
	<jsp:param name="error" value="Problem in database connection" />
</jsp:forward>
<% }

String devicename = request.getParameter("devicename");
String deviceid = request.getParameter("deviceid");
String devicetype=request.getParameter("devicetype") ;
String quantity=request.getParameter("quantity") ;
String manufacturer= request.getParameter("manufacturer") ;
String purchasedate=request.getParameter("purchasedate") ;

String sql="insert into device values('"+devicename+"','"+devicetype+"','"+quantity+"','"+manufacturer+"','"+purchasedate+"','"+deviceid+"')";
int r=db.update(sql);
if(r!=0)
{ %>
<p id="addmsg">Device added sucessfully</p>
<% } else  {%>
<p id="addmsg">Device addition is failed</p>
<%} %>


