<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN"><%@page
	language="java" import="java.sql.*" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<html>
<head>
<title>validate</title>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<jsp:useBean id="db" class="database.DataConnect"></jsp:useBean>
</head>
<body>
<%
		db.connect();
		String username=request.getParameter("username");
		String password=request.getParameter("password");
		String types=request.getParameter("types");
		session.setAttribute("username", request.getParameter("username"));
		ResultSet rs=db.execute("SELECT USERNAME FROM USERS WHERE USERNAME='"+username+"' AND PASSWORD='"+password+"' AND TYPES='"+types+"'");
		System.out.println("query execute, loaded successfully");
		String name= null;
		while(rs.next())
		{ name=rs.getString(1);
		}

		if(name != null && types.equals("Doctor"))
		{
			String redirectURL = "doctor.jsp";
			response.sendRedirect(redirectURL);
		}
		else if(name != null && types.equals("Medical Personnel"))
		{
			String redirectURL = "medpers.jsp";
			response.sendRedirect(redirectURL);
		}

		else if(name != null && types.equals("Finance Deptt"))
		{
			String redirectURL = "findeptt.jsp";
			response.sendRedirect(redirectURL);
		}
		else
			out.println("Check your USERNAME, PASSWORD and TYPE !!");
		%>

</body>
</html>