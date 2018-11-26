
<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
    <%@ page import="java.io.*" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">

<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">


</head>
<body background="image/TEST.jpg" style="background-repeat:no-repeat; background-position:center">
<center><table bgcolor="red" cellpadding=2 cellspacing=0 border=0 width="100%" height="10%">
<tr><td align="Left"><a STYLE="text-decoration:none" href="loginaction.jsp"><font face="Century Gothic,arial" size=4 color="white"><b>| Back |</b></font></a>
<a STYLE="text-decoration:none" href="index.jsp"><font face="Century Gothic,arial" size=4 color="white"><b>| Home |</b></font></a>
<a STYLE="text-decoration:none" href="logout.jsp"><font face="Century Gothic,arial" size=4 color="white"><b>| Logout |</b></font></a></td>
<td align="right"><font face="Century Gothic,arial" size=5 color="white"><b>|WELCOME TO SOMMARIO |</b></font></td></tr></table>
<marquee behavior="alternate" bgcolor="pink"> MINE INFORMATION, EXTRACT KNOWLEDGE</marquee>
<%session.setAttribute("loginfo","0"); %>
<%
try
{
	//to get the content type information from JSP Request Header
	String contentType = request.getContentType();
String username = (String)session.getAttribute("username");
//out.println("User :"+username);
	//here we are checking the content type is not equal to Null and
 //as well as the passed data from mulitpart/form-data is greater than or
 //equal to 0
    if((username != null)||(username.equalsIgnoreCase("")))
    {
    	
	if ((contentType != null) && (contentType.indexOf("multipart/form-data") >= 0)) {
 		DataInputStream in = new DataInputStream(request.
getInputStream());
		//we are taking the length of Content type data
		int formDataLength = request.getContentLength();
		byte dataBytes[] = new byte[formDataLength];
		int byteRead = 0;
		int totalBytesRead = 0;
		//this loop converting the uploaded file into byte code
		while (totalBytesRead < formDataLength) {
			byteRead = in.read(dataBytes, totalBytesRead, 
formDataLength);
			totalBytesRead += byteRead;
			}

		String file = new String(dataBytes);
		//for saving the file name
		String saveFile = file.substring(file.indexOf("filename=\"") + 10);
		saveFile = saveFile.substring(0, saveFile.indexOf("\n"));
		saveFile = saveFile.substring(saveFile.lastIndexOf("\\")
 + 1,saveFile.indexOf("\""));
		int lastIndex = contentType.lastIndexOf("=");
		String boundary = contentType.substring(lastIndex + 1,
contentType.length());
		int pos;
		//extracting the index of file 
		pos = file.indexOf("filename=\"");
		pos = file.indexOf("\n", pos) + 1;
		pos = file.indexOf("\n", pos) + 1;
		pos = file.indexOf("\n", pos) + 1;
		int boundaryLocation = file.indexOf(boundary, pos) - 4;
		int startPos = ((file.substring(0, pos)).getBytes()).length;
		int endPos = ((file.substring(0, boundaryLocation))
.getBytes()).length;

		// creating a new file with the same name and writing the 
//content in new file
        String path = request.getRealPath("/");
		
		String pathUser= path+username;
		File chkdir = new File(pathUser);
		boolean flag = chkdir.exists();
		if(!flag)
		{
			new File(pathUser).mkdir();
		}
		FileOutputStream fileOut = new FileOutputStream(pathUser+"/out"+saveFile);
		String sessionstring = pathUser+"/out"+saveFile;
		session.setAttribute("WebOutputPath",pathUser);
		session.setAttribute("WebOutputName",saveFile);
		session.setAttribute("WebInputFile",sessionstring);
		fileOut.write(dataBytes, startPos, (endPos - startPos));
		fileOut.flush();
		fileOut.close();

		%><Br>
		<%
		out.println("<title>Welcome, "+username+"</title>");
		out.println("<font face='verdana,arial' size=6 color='blue'><b>User Name: "+username+"</b></font> ");
		  out.println("<br><br><br><br><br><br><font face='verdana,arial' size=5 color='green'><b>You have successfully uploaded the file by the name of: "+saveFile+"</b></font> ");%>
		  <br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><center><table bgcolor="red" cellpadding=2 cellspacing=0 border=0 width="100%" height="5%">
<tr><td align="center">
<a STYLE="text-decoration:none" href="EnterKeyWord.jsp"><font face="Century Gothic,arial" size=3 color="white"><b>Click here for Summarization</b></font></a>
		<%
		}
    }//end of user if
    else
    {%>
    
    	<form method="POST" action="index.jsp">
    	<br><br><a  STYLE="text-decoration:none" href="login.jsp"><font face="Century Gothic,arial" size=3 color="blue"><b>Click Here to Login...</b></font></a>

</form>
   <% }
    }
    catch(Exception e)
    {
    }
    
%>