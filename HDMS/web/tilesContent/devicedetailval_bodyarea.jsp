<%@page import="java.sql.*" language="java"
	contentType="text/html; charset=ISO-8859-1" pageEncoding="ISO-8859-1"%><jsp:useBean
	id="db" class="database.DataConnect"></jsp:useBean>
<%
db.connect();
String devicename=request.getParameter("devicename");
ResultSet rs=db.execute("SELECT * FROM DEVICE WHERE DEVICENAME='"+devicename+"'");
System.out.println("query loaded successfully");
String name= null;
String name2= null;
String name3= null;
String name4= null;
String name5= null;
String name6= null;


while(rs.next())
{ name=rs.getString(1);
  name2=rs.getString(2);
  name3=rs.getString(3);
  name4=rs.getString(4);
  name5=rs.getString(5);
  name6=rs.getString(6);
  
  
}

if(name != null)
{
	%>
<form>



	<center>
		<u><font size="+2">Device Details</font> </u><br>
		<br>
		<table border="0" cellpadding="5" cellspacing="5" style="border-bottom-width: 1px; border-color: teal">
			<tbody>
				<tr>
					<td><b>Device Name</b></td>
					<td style="border-color: teal; border-width: 1px"><%= name%>
					</td>
				</tr>
				<tr>
					<td valign="top" ><b>Device Type</b></td>
					<td style="border-width: 1px"><%=name2%>
					</td>
				</tr>
				<tr>
					<td><b>Quantity</b></td>
					<td style="border-width: 1px"><%=name3%></td>
				</tr>
				<tr>
					<td><b>Manufacturer</b></td>
					<td style="border-width: 1px"><%=name4%></td>
				</tr>
				<tr>
					<td><b>Purchase Date</b></td>
					<td style="border-width: 1px"><%=name5%></td>
				</tr>
				<tr>
					<td><b>DeviceID</b></td>
					<td style="border-width: 1px"><%=name6%></td>
				</tr>
				<tr>
					<td></td>
					<td></td>
				</tr>
			</tbody>
		</table>
	</center>
</form>
<% 
}
else
	
	out.println("No Device Detail Available");
%>
