<%@ page language="java" import="java.sql.*" %>

<%
	String driver = "com.mysql.jdbc.Driver";
	Class.forName(driver).newInstance();
	

	Connection con=null;
	ResultSet rst=null;
	Statement stmt=null;

	
      String first_name = request.getParameter("FIRST_NAME");
      String last_name = request.getParameter("LAST_NAME");
      String age = request.getParameter("AGE");
      String address = request.getParameter("Address");
      String state = request.getParameter("STATE");
      String city = request.getParameter("CITY");
      String pincode = request.getParameter("PINCODE");
      String contactno = request.getParameter("CONTACTNO");
      String email_id = request.getParameter("EMAIL_ID");
     
	 out.println(first_name);
	
	try{
		Connection Conn=DriverManager.getConnection("jdbc:mysql://localhost/phs","root","");
		System.out.println("hello");
	
		PreparedStatement Stmt=Conn.prepareStatement("INSERT into CLIENT(FIRST_NAME,LAST_NAME,AGE,ADDRESS,STATE,CITY,PINCODE,CONTACTNO,EMAIL_ID) VALUES('"+first_name+"','"+last_name+"','"+age+"','"+address+"','"+state+"','"+city+"','"+pincode+"','"+contactno+"','"+email_id+"')");
		Stmt.executeUpdate();
	   System.out.println(" YOUR Request has successfully accepted and we will contact you soon...");
       out.println(" YOUR Request has successfully accepted and we will contact you soon...");
	}
	catch(Exception e){
		System.out.println(e.getMessage());
	}
	
	
%>