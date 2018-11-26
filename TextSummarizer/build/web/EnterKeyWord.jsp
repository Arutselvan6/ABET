<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<link rel="stylesheet" type="text/css" href="balloontip.css" />

<script type="text/javascript" src="balloontip.js">
</script>
<style type="text/css" media="screen">
body {
font: 11px arial;
}
.suggest_link {
background-color: #FFFFFF;
padding: 2px 6px 2px 6px;
}
.suggest_link_over {
background-color: #3366CC;
padding: 2px 6px 2px 6px;
}
#search_suggest {
position: absolute;
background-color: #FFFFFF;
text-align: left;
border: 1px solid #000000;
}
</style>
<script language="JavaScript" type="text/javascript" src="ajax_search.js"></script>

</head>
<body background="image/TEST.jpg" style="background-repeat:no-repeat; background-position:center">
<div id="keywordball" class="balloonstyle" style="width: 550px; background-color: lightyellow">
Enter the keyword along with comma eg:project,load,real
</div>
<div id="percentball" class="balloonstyle" style="width: 350px; background-color: lightyellow">
Enter the percentage	
</div>
<div id="outfileball" class="balloonstyle" style="width: 350px; background-color: lightyellow">
Enter the output filename
</div>

<center><table bgcolor="red" cellpadding=2 cellspacing=0 border=0 width="100%" height="10%">
<tr><td align="Left"><a STYLE="text-decoration:none" href="loginaction.jsp"><font face="Century Gothic,arial" size=4 color="white"><b>| Back |</b></font></a>
<a STYLE="text-decoration:none" href="index.jsp"><font face="Century Gothic,arial" size=4 color="white"><b>| Home |</b></font></a>
<a STYLE="text-decoration:none" href="logout.jsp"><font face="Century Gothic,arial" size=4 color="white"><b>| Logout |</b></font></a></td>
<td align="right"><font face="Century Gothic,arial" size=5 color="white"><b>| WELCOME TO SOMMARIO |</b></font></td></tr></table>
<marquee behavior="alternate" bgcolor="pink"> MINE INFORMATION, EXTRACT KNOWLEDGE</marquee>

<%
    try{
	String username  = (String)session.getAttribute("username");
	String WebInputFile  =(String)session.getAttribute("WebInputFile");
    
	if((username != null)||(username.equalsIgnoreCase("")))
	{
		if((WebInputFile == null)||(WebInputFile.equalsIgnoreCase("")))
		{
			out.println("input File is empty <form method='POST' action='index.jsp'><input type='submit' value='Click here to Login' name='B1'></form>");
		}
		else{
			out.println("<title>Welcome, "+username+"</title>");
		
			out.println("<br><br><font face='verdana,arial' size=6 color='blue'><b>User Name: "+username+"</b></font> ");
			//out.println("<br><br><font face='verdana,arial' size=2 color='#342826'><b>Output File Path: </b></font> ");			  
			//out.println("<font face='verdana,arial' size=3 color='#C8BBBE'><b>: "+WebInputFile+"</b></font> ");%>
			
		    <br><br>
		    
		    <form action="actionkeyword.jsp" method="post">
		    <TABLE height=100%" width=100%>

 <TR height=60% >		

<td height=100%>
<table cellpadding=10 cellspacing=0 border=40>
		    
		    	<tr><td><font face="Century Gothic,arial" size=6 color="yellow"><b>Enter the Keyword</b></font><br><br></td></tr>
		    	<tr><td><input type="text" size=60 name="keyword"  id="txtSearch" onkeyup="searchSuggest();" autocomplete="off"><div id="search_suggest">
</div>			&nbsp;&nbsp; <a href="#" STYLE="text-decoration:none" rel="keywordball">  ?</a></td></tr>
		    
		    
		    	<tr><td><font face="Century Gothic,arial" size=6 color="yellow"><b>Percentage Value</b></font><br><br></td></tr>
		    	<tr><td><input type="text" size=60 name="percentage"><a href="#" STYLE="text-decoration:none" rel="percentball">  ?</a></td>
		    </tr>
		    
		    	<tr><td><font face="Century Gothic,arial" size=6 color="yellow"><b>Output File Name</b></font><br><br></td></tr>
		    	<tr><td><input type="text" size=60 name="Uoutfile"><a href="#" STYLE="text-decoration:none" rel="outfileball">  ?</a></td>
		    </tr>
		     
		    	<tr><td></td></tr>
		    	<tr><td><input type="submit" name="sumbutton" value="summarization"></td></tr>
		    
		    </table>
		    		    
		    <%			
		}
	}
	else
	    {%>
	    
	    	<form method="POST" action="index.jsp">
	<br><br><a  STYLE="text-decoration:none" href="login.jsp"><font face="Century Gothic,arial" size=8 color="blue"><b>Click Here to Login...</b></font></a>
	</form>
	   <% }
    }//long try
    catch(Exception e)
    {
    	out.println("input File is empty <form method='POST' action='index.jsp'><br><br><a  STYLE='text-decoration:none' href='login.jsp'><font face='Century Gothic,arial' size=5 color='blue'><b>Click Here to Login...</b></font></a></form>");
    }
	%>
	<%session.setAttribute("keyinfo","1"); %>
</body>
</html>