<%@page import="java.sql.*" language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%><p align="center">
	<b>Available Devices
	</b></p>
<p></p>

<div align="left"><jsp:useBean id="db"
		class="database.DataConnect"></jsp:useBean>
	<%
db.connect();
ResultSet rs=db.execute("SELECT DEVICENAME FROM DEVICE");
System.out.println("query loaded successfully");
%><ol><% 
while(rs.next())
{ 

%>
		<li><a href="${pageContext.request.contextPath}/devicedetailval.jsp?devicename=<%=rs.getString("devicename")%>&amp;submit=Get"><%=rs.getString("devicename")%></a></li>
	
	<%
}%><ol><%


%>
</div>