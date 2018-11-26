<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" 

"http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">

</head>
<body background="image/TEST.jpg" style="background-repeat:no-repeat; background-position:center">
<center><table bgcolor="red" cellpadding=2 cellspacing=0 border=0 width="100%" 

height="10%">
<tr><td align="Left"><a STYLE="text-decoration:none" href="EnterKeyWord.jsp"><font 

face="Century Gothic,arial" size=4 color="white"><b>| Back |</b></font></a>
<a STYLE="text-decoration:none" href="index.jsp"><font face="Century Gothic,arial" size=4 

color="white"><b>| Home |</b></font></a>
<a STYLE="text-decoration:none" href="logout.jsp"><font face="Century Gothic,arial" size=4 

color="white"><b>| Logout |</b></font></a></td>
<td align="right"><font face="Century Gothic,arial" size=5 color="white"><b>| sommario |</b></font></td></tr></table>

<marquee behavior="alternate" bgcolor="pink"> MINE INFORMATION, EXTRACT KNOWLEDGE</marquee>

<%    
	String outputFileNameWrite = null;
    	 String username ="";
    	 String keyword="";
    	 String percentage="";
    	 String Uoutfile="";   	 
    	 
    	 int fileflag=0;
    		username = (String)session.getAttribute("username");
    		String WebInputFile =(String)session.getAttribute("WebInputFile");
    		
    	    if((username != null)||(username.equalsIgnoreCase("")))
    		{
    			if((WebInputFile == null)||(WebInputFile.equalsIgnoreCase("")))
    			{
    				out.println("input File is empty <form method='POST' action='login.jsp'><input type='submit' value='Click here to Login' name='B1'></form>");
    			}
    			else{
    			  // main process   
    			  if("1".equals((String)session.getAttribute("keyinfo")))
    				{
    	    			keyword = request.getParameter("keyword");
    	    			Uoutfile = request.getParameter("Uoutfile");
    	    			percentage = request.getParameter("percentage");
    		
    	   			 session.setAttribute("keyword",keyword);
    	   			session.setAttribute("percentage",percentage);
    	   			session.setAttribute("Uoutfile",Uoutfile);
    			   
    			    String temp = (String)session.getAttribute("WebOutputName");
    			    String[] ext  = temp.split("\\."); 
    			    session.setAttribute("ext",ext[0]);
    			    if(ext[1].equalsIgnoreCase("doc"))
    			    {
    			    	fileflag = 1;
    			    	//out.println("<br>file flag ext:: "+ext[1]);
    			    }
    			    else if(ext[1].equalsIgnoreCase("txt"))
    			    {
    			    	fileflag = 2;
    			    	//out.println("<br>file flag ext:: "+ext[1]);
    			    }
    			    else if(ext[1].equalsIgnoreCase("pdf"))
    			    {
    			    	fileflag = 3;
    			    	//out.println("<br>file flag ext:: "+ext[1]);
    			    }
    			    else if(ext[1].equalsIgnoreCase("html"))
    			    {
    			    	fileflag = 4;
    			    	//out.println("<br>file flag ext:: "+ext[1]);
    			    }
    			    outputFileNameWrite =  (String)session.getAttribute("WebOutputPath")+"/"+Uoutfile+ext[0];
    			    
    			    %>
    			    
    			    <jsp:useBean id="logic" class="com.CoreLogic"></jsp:useBean>
    			    
    			    <%    			    
    			    String[] cunt = logic.ContDoc2Txt(WebInputFile,outputFileNameWrite,keyword,username, fileflag).split(":");
    			    //out.println(" key size ::  "+cunt.length);
    			    //for(int ii=0;ii<cunt.length;ii++)
        			    //out.println(" key splet ::  "+cunt[ii]);

					int InFcunt =logic.Insertkeycount("summari",username,WebInputFile,outputFileNameWrite+"final"+".txt",keyword,percentage);
					session.setAttribute("cnt",cunt[1]);
					session.setAttribute("LineIndex",cunt[2]);
					session.setAttribute("InFcunt",InFcunt);
    			    }    			    
    		else
    		{
    			keyword =(String)session.getAttribute("keyword");
    			percentage =(String)session.getAttribute("percentage");
    		}
    			    
    			    
    			  out.println("<title>Welcome, "+username+"</title>");
    				  out.println("<br><br><br><font face='verdana,arial' size=5 color='blue'><b> User Name     : "+username+"</b></font> ");
    				  out.println("<br><br><br><font face='verdana,arial' size=6 color='yellow'><b>User's Keyword: "+keyword+"</b></font> ");
    				  out.println("<br><br><br><font face='verdana,arial' size=6 color='yellow'><b>User's Percentage: "+percentage+"</b></font> ");
    				  out.println("<br><br><br><font face='verdana,arial' size=6 color='yellow'><b>Keyword Count : "+(String)session.getAttribute("cnt")+"</b></font> ");
    				  
    				  String[] LineIndex = session.getAttribute("LineIndex").toString().split("@");
    				  
    				  out.println("<br><br><font face='verdana,arial' size=3 color='DarkGray'><b> </b></font> ");
    				  for(int li=1;li<LineIndex.length;li++)
    				  {
    					 //out.println("<br><br><font face='verdana,arial' size=3 color='DarkGray'><b>Line "+li+": "+LineIndex[li]+"</b></font> ");
    				  }
    				  
    				  
    				  
    				  %>
    				  
    				  
    				  
    				  
    			
    			    
<br><br><br><br><br><br><center><table bgcolor="red" cellpadding=2 cellspacing=0 border=0 width="100%" height="5%">
<tr><td align="center">
<a STYLE="text-decoration:none" href="downoption.jsp"><font face="Century Gothic,arial" size=3 color="white"><b>| Output File Download |</b></font></a></tr></table>
 

<% 

//<a STYLE="text-decoration:none" href="chart.jsp"><font face="Century Gothic,arial" size=2>
//color="white"><b>| Chart |</b></font></a>
//<a STYLE="text-decoration:none" href="chart1.jsp"><font face="Century Gothic,arial" size=2 

//color="white"><b>| Chart1 |</b></font></a></td>
//</tr></table>    
  //out.println("<br><br>|<a href = 'downoption.jsp'>Output File Download</a>||<a href = 'chart.jsp'>Chart</a>||<a href = 'chart1.jsp'>Chart1</a>||<a href= 'logout.jsp'>Logout</a>|");
    			
    		}
        	    }
    	    else
    	    {
    	    	%>    	    	
      	    
    	    	
<form method="POST" action="login.jsp"><br><br>
    	<p><input type="submit" value="Click here to Login" name="B1"></p>
    	</form>
    	   <%    	    	
    	    }    

%>
