<%@ page language="java" import="java.sql.*" %>

<%
	String driver = "com.mysql.Driver";
	Class.forName(driver).newInstance();
	

	Connection con=null;
	ResultSet rst=null;
	Statement stmt=null;

	
      String category = request.getParameter("CATEGORY");
      String name = request.getParameter("NAME");
      String phone = request.getParameter("PHONE");
      String nationality = request.getParameter("NATIONALITY");
      String e_mail = request.getParameter("E_MAIL");
      String message = request.getParameter("MESSAGE");
      
	
	
	try{
		Connection Conn=DriverManager.getConnection("jdbc:mysql://localhost/phs","root","");
		System.out.println("hello");
	
		PreparedStatement Stmt=Conn.prepareStatement("INSERT into FEED(CATEGORY,NAME,PHONE,NATIONALITY,E_MAIL,MESSAGE) VALUES('"+category+"','"+name+"','"+phone+"','"+nationality+"','"+e_mail+"','"+message+"')");
		Stmt.executeUpdate();
	   System.out.println(" Thank you in advance for sharing your opinions with us and we assure you that we will utilise your opinions to develop processes to serve you better");
       out.println(" Thank you in advance for sharing your opinions with us and we assure you that we will utilise your opinions to develop processes to serve you better");
	}
	catch(Exception e){
		System.out.println(e.getMessage());
	}
	
	
%>