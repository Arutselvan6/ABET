<%@ page language="java" import="java.sql.*" %>

<%
	String driver = "com.mysql.jdbc.Driver";
	Class.forName(driver).newInstance();
	

	Connection con=null;
	ResultSet rst=null;
	Statement stmt=null;

	
      String wardallotment = request.getParameter("WARDALLOTMENT");
      String testforpatient = request.getParameter("TESTFORPATIENT");
      String report = request.getParameter("REPORT");
      String prescription = request.getParameter("PRESCRIPTION");
     
	 out.println(wardallotment);
	
	try{
		Connection Conn=DriverManager.getConnection("jdbc:mysql://localhost/phs","root","");
		System.out.println("hello");
	
		PreparedStatement Stmt=Conn.prepareStatement("INSERT into DOCTOR(WARDALLOTMENT,TESTFORPATIENT,REPORT,PRESCRIPTION) VALUES('"+wardallotment+"','"+testforpatient+"','"+report+"','"+prescription+"')");
		Stmt.executeUpdate();
	   System.out.println(" Ward has Alloted for patient And follow the Prescription sincerly ");
       out.println("  Ward has Alloted for patient And follow the Prescription sincerly ");
	}
	catch(Exception e){
		System.out.println(e.getMessage());
	}
	
	
%>