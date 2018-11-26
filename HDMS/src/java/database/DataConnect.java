package database;

import java.sql.*;

public class DataConnect {

	String URL = "jdbc:mysql://localhost/hdms";
	  String Driver = "com.mysql.jdbc.Driver"; 
	 static Connection Con;
	 public DataConnect(){ }
	 public boolean connect() throws ClassNotFoundException,SQLException{ 
         Class.forName(Driver); 
         Con = DriverManager.getConnection(URL,"root",""); 
         return true; 
       }

	 public void close() throws SQLException{ 
	        Con.close(); 
	       }
	  public ResultSet execute(String sql) throws SQLException{

          Statement s = Con.createStatement(); 
          ResultSet r = s.executeQuery(sql); 
          return (r == null) ? null : r; 
          }

public int update(String sql) throws SQLException{                     
         Statement s = Con.createStatement();
         int r = s.executeUpdate(sql);
         return (r == 0) ? 0 : r; 
      }
public ResultSet insert(String sql) throws SQLException{ 
	 Statement s = Con.createStatement();
 int a = s.executeUpdate(sql,Statement.RETURN_GENERATED_KEYS);
     ResultSet r = s.getGeneratedKeys();
    return (r == null) ? null : r; 
 }

}

