package com;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;

public class Registration {
	
	public boolean UserAdd(String Uname, String Pword,String mail,String schema) {
		// TODO Auto-generated method stub
		boolean f=false;
		try {
			
			String[] test = mail.split("@");
						
			if(test.length==2)
			{
				String[] test1= test[1].split("\\.");
				if(test1.length==2)
				{
					Class.forName("com.mysql.jdbc.Driver");
					Connection connection =
					DriverManager.getConnection("jdbc:mysql://localhost/SUMMARI","root","");
					Statement statement;			
					statement = connection.createStatement();
					statement.executeUpdate("insert into USERDETAIL values('"+Uname+"','"+Pword+"','"+mail+"')");
					
					f= true;		
					
				}			
				
			}
			else
			{
				f= false;
			}
			
		   } catch (Exception e) {
			// TODO: handle exception
			e.printStackTrace();
			return false;
		}
		   return f;
	}
	
	
	
	public boolean FindUser(String Uname, String Pword,String schema) {
		// TODO Auto-generated method stub
		
		try {
			boolean flag=false;
			Class.forName("com.mysql.jdbc.Driver");
			Connection connection =
			DriverManager.getConnection("jdbc:mysql://localhost/SUMMARI","root","");
			Statement statement;
			ResultSet rs;
			statement = connection.createStatement();
			rs = statement.executeQuery("SELECT username,password FROM USERDETAIL where username='"+Uname+"'");
			while(rs.next())
			{
				if(Uname.equals(rs.getString(1)) && Pword.equals(rs.getString(2)))				
					flag = true;
				else
					flag=false;
			}
			return flag;
			
		   } catch (Exception e) {
			// TODO: handle exception
			e.printStackTrace();
			return false;
		}
	}

}
