<%@page import="java.sql.*" language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<jsp:useBean id="db" class="database.DataConnect"></jsp:useBean>
<p align="center">
	<b>Device Available !</b>
</p>
<p align="center">
	<font size="+1" color="white">.</font><font size="+1"> </font>
</p>
<p></p>
<%
db.connect();
String deviceid=request.getParameter("deviceid");
ResultSet rs=db.execute("SELECT DEVICENAME FROM DEVICE");
System.out.println("query loaded successfully");
%><ol><%while(rs.next())
{ 

%>
	<li><a href="${pageContext.request.contextPath}/devicedetailval.jsp?devicename=<%=rs.getString("devicename")%>&amp;submit=Get"><%=rs.getString("devicename")%></a></li>

<%
}%><ol><%
%>
