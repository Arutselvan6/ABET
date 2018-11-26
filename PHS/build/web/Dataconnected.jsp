<%@ page import="java.sql.*" %> 
<%@ page import="java.io.*" %> 
<html> 
<head> 
    <title>data successfully saved</title>
</head> 
<body>
<% // get parameters from the request
    String Username = request.getParameter("Username");
    String Password = request.getParameter("Password");
   Statement statement = null;
            
   // declare a connection by using Connection interface 
   Connection connection = null;
   try {
   /* Create string of connection url within specified format 
   with machine name, 
   port number and database name. Here machine name id 
   localhost and database name is TEST. */
   String connectionURL = "jdbc:mysql://localhost/phs";

   // Load JBBC driver "com.ibm.db2.jdbc.DB2Driver" by newInstance() method. 
   Class.forName("com.mysql.jdbc.Driver").newInstance();
   /* Create a connection by using getConnection() 
   method that takes parameters of string type connection url, user 
   name and password to connect to database. */
   connection = DriverManager.getConnection(connectionURL, "root", "");
   statement = connection.createStatement();
   String QueryString = "INSERT INTO TEST (Username,Password,) VALUES ('" + Username + "','" + 
   Password + "')";
   int UQ = statement.executeUpdate(QueryString);
   if (UQ > 0) {
%><font color="green" size="5" >Congratulations !</font>

<TABLE style="background-color: #ECE5B6;" WIDTH="30%">
    <tr>
    <tr>
        <td>UserName</td>
        <td><%=Username%></td>
    </tr>
    <tr>
        <td>Password</td>
        <td><%= Password%></td>
    </tr>
    
    <tr><td></td><td align="right">
            <A HREF="Admiting.jsp">
            <font size="4" color="blue">go to Admiting</font></A>
        </td>
    </tr>
</TABLE>   
<%	}
} catch (Exception ex) {
%>
<FONT size="+3" color="red"></b>
    <%
                out.println("Unable to connect to database.");
            } finally {
                statement.close();
                connection.close();
            }
    %>
</FONT>
</body> 
</html>