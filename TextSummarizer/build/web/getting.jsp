<%@page import="java.sql.*"%>
<%
   String words = request.getParameter("words");

try {
		
		Class.forName("com.mysql.jdbc.Driver");
		Connection connection =	DriverManager.getConnection("jdbc:mysql://localhost/SUMMARI","root","");
		Statement statement;
		
		statement = connection.createStatement();
		ResultSet rs = statement.executeQuery("SELECT * FROM DIC WHERE wording LIKE '%"+words+"%' order by wording asc");
		while(rs.next())
		{
			
			out.println(rs.getString("wording"));		
		}			
		
	   } catch (Exception e) {
		// TODO: handle exception
		System.out.println("Error geting :: "+e);
		//e.printStackTrace();
		//return e.toString()+":0";
	}
%>