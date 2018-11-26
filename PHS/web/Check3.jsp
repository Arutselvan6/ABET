<%@page import="java.sql.*" language="java" contentType="text/html;
charset=ISO-8859-1" pageEncoding="ISO-8859-1"%>
 
 
<title>LOGIN3 CHECK3_PAGE</title>
 
 
 
<%
Class.forName("com.mysql.jdbc.Driver");
System.out.println("driver loaded successfully");
Connection Conn=DriverManager.getConnection("jdbc:mysql://localhost/phs","root","");
String user=request.getParameter("user");
String pass=request.getParameter("pass");
if(user!=null){
System.out.println("hiii You are Loged in As:"+user);
}
PreparedStatement Stmt=Conn.prepareStatement("SELECT USERNAME FROM LOGIN3 WHERE USERNAME='"+user+"' AND PASSWORD='"+pass+"'");
System.out.println("Statement loaded successfully");
Stmt.executeQuery();
ResultSet rs=Stmt.getResultSet();
System.out.println("query execute loaded successfully");

String USERNAME=null;

String error=null;

while(rs.next())
{ USERNAME=rs.getString(1);
  
  System.out.println("hello");
  
  }
System.out.println("hiiii");

if(USERNAME == null)
{%><jsp:forward page="Login3.jsp">  <jsp:param name="error" value="wrong username or password" /></jsp:forward>
<%} 
else
    
	%><jsp:forward page="Doctor.jsp"/> <%
%>