<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<%@ page import="java.io.*"%>
<%
boolean flg=false;
session.setAttribute("keyinfo","0");
String username  = (String)session.getAttribute("username");%>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">


<script type="text/javascript">
function fun(fg)
{    	
    	document.contact_form.action="download.jsp";

if(fg)
alert("output will be less than percentage value given,press ok for output else press resummarization button");


}
</script>
</head>

<body background="image/TEST.jpg" style="background-repeat:no-repeat; background-position:center">
<FORM name="contact_form" METHOD=POST>
<center><table bgcolor="red" cellpadding=2 cellspacing=0 border=0 width="100%" height="10%">
<tr><td align="Left"><a STYLE="text-decoration:none" href="actionkeyword.jsp"><font face="Century Gothic,arial" size=4 color="white"><b>| Back |</b></font></a>
<a STYLE="text-decoration:none" href="index.jsp"><font face="Century Gothic,arial" size=4 color="white"><b>| Home |</b></font></a>
<a STYLE="text-decoration:none" href="logout.jsp"><font face="Century Gothic,arial" size=4 color="white"><b>| Logout |</b></font></a></td>
<td align="right"><font face="Century Gothic,arial" size=5 color="white"><b>| WELCOME TO SOMMARIO |</b></font></td></tr></table>
<marquee behavior="alternate" bgcolor="pink">MINE INFORMATION, EXTRACT KNOWLEDGE</marquee>

<%out.println("<title>Welcome, "+username+"</title>");
out.println("<br><br><font face='verdana,arial' size=5 color='blue'><b> User Name     : "+username+"</b></font> ");%>
<br><br>
<center><table cellpadding=30 cellspacing=20 border=40>
<tr><td bgcolor="red"><table cellpadding=0 cellspacing=0 border=0 width=100%><tr><td bgcolor="blue" align=center style="padding:2;padding-bottom:4"><b><font size=5 color="white">Select Output Format</font></b></tr>
<tr></tr><tr><td bgcolor="white" style="padding:5">        
   
        
<table>
<tr><td>&nbsp;&nbsp;&nbsp;<INPUT TYPE="radio" NAME="radios" VALUE=".doc" checked></td><td><font face="verdana,arial" size=3>.Doc &nbsp;&nbsp;&nbsp;</font>
<INPUT TYPE="radio" NAME="radios" VALUE=".txt"></td><td><font face="verdana,arial" size=3>.txt &nbsp;&nbsp;&nbsp;</font>
<INPUT TYPE="radio" NAME="radios" VALUE=".pdf"></td><td><font face="verdana,arial" size=3>.pdf&nbsp;&nbsp;&nbsp;</font></td></tr>
<tr><td colspan=2><font face="verdana,arial" size=-1>&nbsp;</font></td></tr>
</table>
        

<%

int length=0,line=0,targetline=0;
float percent=0;

String Uoutfile = (String)session.getAttribute("Uoutfile");
String ext = (String)session.getAttribute("ext");
String Percentage = (String)session.getAttribute("percentage");
String Inputfile = (String)session.getAttribute("WebOutputPath")+"/"+Uoutfile+ext+"final";

try {

File file = new File(Inputfile+".txt");
BufferedReader in = new BufferedReader(new FileReader(file));
float Lcnt=0,percen=Float.valueOf(Percentage);	    		

 while (in.readLine() != null)
 {
	Lcnt++; 
 }

		
			
			percent = ((Lcnt*percen) / 100);			

				float p = (float)Math.pow(10,0);
				percent = percent * p;
				float tmp = Math.round(percent);
				
				percent = tmp/p;
				
				if(percent < Lcnt)
				{
				flg=true;
					//out.println("aa");
				}
				//out.println("bb");
				
		//}
	//}			
	
   } catch (Exception e) {
	// TODO: handle exception
	
}




%>

<%out.println("<INPUT TYPE='submit' VALUE='Download' onclick ='fun("+flg+");'>"); %>            
    

</td></tr></table>
</td></tr>
</table>    

<br><br>


<br><br><br><br><br><center><table bgcolor="red" cellpadding=2 cellspacing=0 border=0 width="100%" height="5%">
<tr><td align="center">
<a STYLE="text-decoration:none" href="EnterKeyWord.jsp"><font face="Century Gothic,arial" size=3 color="white"><b>| Re-Summarization |</b></font></a><a STYLE="text-decoration:none" href="Upload.jsp"><font face="Century Gothic,arial" size=3 color="white"><b>| Re-Load |</b></font></a></tr></table>    
</FORM>
    </BODY>
</html>