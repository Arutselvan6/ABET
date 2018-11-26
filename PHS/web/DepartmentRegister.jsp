<%@ page language="java" import="java.sql.*" %>

<%
	String driver = "com.mysql.jdbc.Driver";
	Class.forName(driver).newInstance();
	

	Connection con=null;
	ResultSet rst=null;
	Statement stmt=null;

	
      String patientname = request.getParameter("PATIENTNAME");
      String registrationid = request.getParameter("REGISTRATIONID");
      String preferdoctor = request.getParameter("PREFERDOCTOR");
     
	 out.println(patientname);
	
	try{
		Connection Conn=DriverManager.getConnection("jdbc:mysql://localhost/phs","root","");
		System.out.println("hello");
	
		PreparedStatement Stmt=Conn.prepareStatement("INSERT into DEPARTMENT(PATIENTNAME,REGISTRATIONID,PREFERDOCTOR) VALUES('"+patientname+"','"+registrationid+"','"+preferdoctor+"')");
		Stmt.executeUpdate();
	   System.out.println("Your case has taken Successfully ");
       out.println(" Your case has taken Successfully");
	}
	catch(Exception e){
		System.out.println(e.getMessage());
	}
	
	
%>