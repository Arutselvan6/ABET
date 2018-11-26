<%@ page language="java" import="java.sql.*" %>

<%
	String driver = "com.mysql.jdbc.Driver";
	Class.forName(driver).newInstance();
	

	Connection con=null;
	ResultSet rst=null;
	Statement stmt=null;

	
      String patientname = request.getParameter("PATIENTNAME");
      String registrationid = request.getParameter("REGISTRATIONID");
      String totalamount = request.getParameter("TOTALAMOUNT");
      
	 out.println(patientname);
	
	try{
		Connection Conn=DriverManager.getConnection("jdbc:mysql://localhost/phs","root","");
		System.out.println("hello");
	
		PreparedStatement Stmt=Conn.prepareStatement("INSERT into BILLING(PATIENTNAME,REGISTRATIONID,TOTALAMOUNT) VALUES('"+patientname+"','"+registrationid+"','"+totalamount+"')");
		Stmt.executeUpdate();
	   System.out.println("    Your payment has sucessfully paid ");
       out.println("       Your payment has sucessfully paid ");
	}
	catch(Exception e){
		System.out.println(e.getMessage());
	}
	
	
%>