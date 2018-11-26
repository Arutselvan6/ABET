<%@page import="java.sql.*"%>
<%@page import="com.lowagie.text.Paragraph"%>
<%@page import="com.lowagie.text.pdf.PdfWriter"%>
<%@page import="com.lowagie.text.Document"%>


<%@ page import="java.io.*"%>
<!--Assumes that file name is in the request objects query Parameter -->




<%

String Uname  = (String)session.getAttribute("username");
String type="";
ServletOutputStream op=null;

try {
if(request.getParameter("radios") != null) {
    if(request.getParameter("radios").equals(".doc")) {
        type="application/msword";
    }
    
    else if(request.getParameter("radios").equals(".txt")) {
    	type="text/plain";
    }
    
    else if(request.getParameter("radios").equals(".pdf")) {
    	type="application/pdf";
    }
    
}

//read the file name.
	
	String keyword = (String)session.getAttribute("keyword");
	String Uoutfile = (String)session.getAttribute("Uoutfile");
	String Percentage = (String)session.getAttribute("percentage");
	String ext = (String)session.getAttribute("ext");
	String Inputfile = (String)session.getAttribute("WebOutputPath")+"/"+Uoutfile+ext+"final";
	String WebInputFile =(String)session.getAttribute("WebOutputPath")+"/FinalResult.txt";
	System.out.println("<br>"+WebInputFile);
	System.out.println("<br> uout->"+Inputfile);
		
	response.setContentType (type);
	
	response.setHeader ("Content-Disposition", "attachment; filename=\"Result."+request.getParameter("radios")+"\"");
	
	
	int length=0,line=0,targetline=0;
	float percent=0;
	
	
	
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
					
			//}
		//}			
		
	   } catch (Exception e) {
		// TODO: handle exception
		
	}
		
	   
	String tt=Inputfile+".txt";
	   File tfile =new File(tt);
		BufferedReader tin = new BufferedReader(new FileReader(tfile));
		BufferedWriter toutput = new BufferedWriter(new FileWriter(WebInputFile));
		
		   System.out.println(percent);
		   System.out.println(targetline);
		
		try
		{

			for(int i=0;i<percent;i++)
			 {
				 toutput.write(tin.readLine());
				 toutput.newLine();	
				 //System.out.println("DATA IN THE FILE ::: "+tin.readLine());
				 
			 }
		}
		catch(NullPointerException ne)
		{
			
		}
		finally
		{
			toutput.close();
		}
		 
	
	
	op = response.getOutputStream();
	
	File f = new File (WebInputFile);
	byte[] bbuf = new byte[WebInputFile.length()];
    DataInputStream in = new DataInputStream(new FileInputStream(f));
        
        Document document = new Document();
        PdfWriter.getInstance(document, new FileOutputStream(Inputfile+".pdf"));
        String value="";
		
		

        			while ((in != null) && ((length = in.read(bbuf)) != -1)) 
					{  
        				if(type.equalsIgnoreCase("application/pdf"))
        				{   
        					document.open();
        					value += new String (bbuf);       					
        					
        				}
        				else
        				{        					
        					op.write(bbuf,0,length);
        				}
  					
					}
        			if(type.equalsIgnoreCase("application/pdf"))
    				{
        				WebInputFile=Inputfile+".pdf";
        				File f1 = new File (WebInputFile);
        				byte[] bbuf1 = new byte[WebInputFile.length()];
        		        DataInputStream in1 = new DataInputStream(new FileInputStream(f1));
        		        int length1=0;
        				document.add(new Paragraph(value));
        				document.close();
        				while ((in1 != null) && ((length1 = in1.read(bbuf1)) != -1)) 
						{
        					op.write(bbuf1,0,length1);
						}
    				}


            		} catch (Exception ioe) {
            			//ioe.printStackTrace(System.out);
            			ioe.printStackTrace();
            		}
           
            		op.flush();
            		op.close();
            		//in.close();	*/
	
            		
            %>