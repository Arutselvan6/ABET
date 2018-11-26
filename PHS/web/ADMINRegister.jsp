<%@ page language="java" import="java.sql.*" %>

<%
	String driver = "com.mysql.jdbc.Driver";
	Class.forName(driver).newInstance();
	

	Connection con=null;
	ResultSet rst=null;
	Statement stmt=null;

	
      String patientname = request.getParameter("PATIENTNAME");
      String fathername = request.getParameter("FATHERNAME");
      String gender = request.getParameter("Gender");
      String address = request.getParameter("Address");
      String age = request.getParameter("Age");
      String contactnumber = request.getParameter("CONTACTNUMBER");
     
	 out.println(patientname);
	
	try{
		Connection Conn=DriverManager.getConnection("jdbc:mysql://localhost/phs","root","");
		System.out.println("hello");
	
		PreparedStatement Stmt=Conn.prepareStatement("INSERT into ADDMITING(PATIENTNAME,FATHERNAME,GENDER,ADDRESS,AGE,CONTACTNUMBER) VALUES('"+patientname+"','"+fathername+"','"+gender+"','"+address+"','"+age+"','"+contactnumber+"')");
		Stmt.executeUpdate();
	   System.out.println(" Record has Successfully Stored...");
       out.println(" Record has Successfully Stored...");
	}
	catch(Exception e){
		System.out.println(e.getMessage());
	}
	
	
%>