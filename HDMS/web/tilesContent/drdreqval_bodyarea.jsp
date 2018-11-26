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
String username = request.getParameter("username");
String quantity=request.getParameter("quantity") ;
String appointment= request.getParameter("appointment") ;
String usageduration=request.getParameter("usageduration") ;

String sql="insert into devicereq values('"+devicename+"','"+username+"','"+quantity+"','"+appointment+"','"+usageduration+"')";
int r=db.update(sql);
if(r!=0)
{ %>
<p id="addmsg">Device request sent sucessfully</p>
<% } else  {%>
<p id="addmsg">Device request failed</p>
<%} %>
