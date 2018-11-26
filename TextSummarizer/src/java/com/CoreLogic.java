package com;

import java.io.*;

import org.apache.poi.hwpf.HWPFDocument;
import org.apache.poi.hwpf.extractor.WordExtractor;
import org.apache.poi.poifs.filesystem.POIFSFileSystem;

import java.sql.*;

import java.util.ArrayList;
import java.util.Iterator; 
import java.util.Map; 


import com.lowagie.text.Document; 
import com.lowagie.text.DocumentException; 
import com.lowagie.text.Paragraph; 
import com.lowagie.text.pdf.PRIndirectReference; 
import com.lowagie.text.pdf.PRStream; 
import com.lowagie.text.pdf.PRTokeniser; 
import com.lowagie.text.pdf.PdfDictionary; 
import com.lowagie.text.pdf.PdfName; 
import com.lowagie.text.pdf.PdfReader; 


public class CoreLogic {
	
	int MainCount=0, InFline=0,OutFline=0;
	//start of method to document to text
	String res ="",LineIndex="";
	public String ContDoc2Txt(String Rfilename, String Wfilename, String keyw, String Uname, int fileflag )
    {      		
		POIFSFileSystem fs = null;
		File Wfile = null;
    	BufferedWriter output = null; 
    	File file = null;
    	BufferedReader in = null;
		try
		{
			  Wfile = new File(Wfilename+".txt");
			  output = new BufferedWriter(new FileWriter(Wfile));
		
		
		if(fileflag==1) // if for doc file
		{

          fs = new POIFSFileSystem(new FileInputStream(Rfilename));                    
          HWPFDocument doc = new HWPFDocument(fs); 
		  WordExtractor we = new WordExtractor(doc); 
		  String[] paragraphs = we.getParagraphText();
		  		  
		  for( int i=0; i<paragraphs.length; i++ )
		  	{	                                 
                String[] Pline =  paragraphs[i].split("\\.");
                InFline =Pline.length;
             for( int j=0; j<InFline; j++ )
		  	{           	 
               
                	output.write(StopWord(Pline[j])+".");
                    output.newLine();
    			
		  	}
		  	}
			} // else if for txt file
			else if(fileflag==2)
			{
				file = new File(Rfilename);
				in = new BufferedReader(new FileReader(file));
				String line, fullline="";	    		
				
				 while (( line = in.readLine()) != null)
				 {
					 fullline =fullline+" "+line;
				 }
	    			String[] Pline =  fullline.split("\\.");
	    			InFline =Pline.length;
	    			for( int j=0; j<InFline; j++ )
	    		  	{
	                    output.write(StopWord(Pline[j])+".");
	                    output.newLine();	        			
	    		  	}		
				        
				in.close();
			} 
		
		
		// else if for html file
			else if(fileflag==4)
			{
				StringBuilder sb = new StringBuilder();
			     BufferedReader br = new BufferedReader(new FileReader(Rfilename));
			     String line;
			     while ( (line=br.readLine()) != null) {
			       sb.append(line);
			       }
			     String fullline = sb.toString().replaceAll("\\<.*?>","");
			     
			     String[] Pline =  fullline.split("\\.");
	    			InFline =Pline.length;
	    			for( int j=0; j<InFline; j++ )
	    		  	{
	    				System.out.println("LINE numer :: "+InFline);
	    				System.out.println("LINE :: "+Pline[j]);
	    				output.write(StopWord(Pline[j])+".");
	                    output.newLine();	        			
	    		  	}		
	    			//System.out.println("LINE 2345 :: "+Pline.length);
				br.close();
			}
		
		
		//  else if for pdf
			else if(fileflag==3)
			{
				Document document = new Document();
				try { 
		           
		             

		            document.open(); 
		            //my escapade 
		            PdfReader reader = new PdfReader(Rfilename); 
		            Map info = reader.getInfo(); 
		             
		                        String key; 
		                        String value; 
		                        for (Iterator i = info.keySet().iterator(); i.hasNext();) { 
		                                key = (String) i.next(); 
		                                value = (String) info.get(key); 
		             
		                        } 
		                        if (reader.getMetadata() != null) { 
		             
		                              new String(reader.getMetadata()); 
		                        } 
		                       
		                        PdfDictionary page = reader.getPageN(1); 
		                        PRIndirectReference objectReference = (PRIndirectReference) page.get(PdfName.CONTENTS); 
		                        PRStream stream = (PRStream) PdfReader.getPdfObject(objectReference); 
		                        byte[] streamBytes = PdfReader.getStreamBytes(stream); 
		                        		                         
		                        PRTokeniser tokenizer = new PRTokeniser(streamBytes); 
		                        FileOutputStream stream2=new FileOutputStream(Wfilename+".txt"); 
		                        StringBuffer strbufe = new StringBuffer(); 
		                        while (tokenizer.nextToken()) { 
		                                if (tokenizer.getTokenType() == PRTokeniser.TK_STRING) {		                                        
		                                        strbufe.append(tokenizer.getStringValue()); 
		                                         
		                                } 
		                        } 
		                        String test=StopWord(strbufe.toString())+"."; 
		                        String[] Pline = test.split("\\."); 
		                        
		                        InFline =Pline.length;
		                        System.out.println("INFLINE SIZE  ::   "+InFline);
		                        for( int j=0; j<Pline.length; j++ )
		    	    		  	{
		                        	System.out.println("PDF FILE DATA  ::   "+Pline[j]);
		                        	StringReader reader1 =  new StringReader(Pline[j]+"."); 
		                        	int t; 
		                        	while((t=reader1.read())>0)
		                        	{
		                        		stream2.write(t);
		                        	}	
		                        	document.add(new Paragraph(" "));
		                        	
		                        	
		    	    		  	}
		                        	
		                        	
		                        } 
		         catch (FileNotFoundException fnfe) { 
		            
		            //fnfe.printStackTrace(); 
		        } catch (DocumentException de) { 
		            
		          //  de.printStackTrace(); 
		        }
		        catch (ArrayIndexOutOfBoundsException e) { 		            
			          //  e.printStackTrace(); 
		        	
			        }
		        finally
		        {
		        	document.close();
		        }
			}
		
		  	output.close();
		  	res = "s"; 
		  	res = Find(Wfilename+".txt", Wfilename+"final"+".txt", keyw, Uname);
		  	res = res+":"+MainCount+":"+LineIndex;
         }
         catch(Exception e)
         { 
         // e.printStackTrace();
         // res = e.toString()+":0";
         }
         return res;
    }
	//end of method to document to text
	
	//start of method for find keyword 
	public String Find(String InfileN, String OutfileN, String keyW, String Uname)
    {
    try
    { 
    	FileInputStream fstream = null;
        DataInputStream in = null;
        BufferedReader br = null;
        File fileW = null;
        BufferedWriter output = null;
        System.out.println("hai Key :: "+keyW);
        String[] keys = keyW.split(",");  
        //int[] count= new int[keys.length];
        ArrayList<Integer>  count = new ArrayList<Integer>();
        
    	
    fstream = new FileInputStream(InfileN);    
    in = new DataInputStream(fstream);
    br = new BufferedReader(new InputStreamReader(in));
    fileW = new File(OutfileN);
    output = new BufferedWriter(new FileWriter(fileW));
        
    String str;    
    
    
    System.out.println("hai string length :: "+keys.length);
    
    while ((str = br.readLine()) != null)
    {
    	boolean fl=true;
    	String[] strspl=str.split(" ");
    	int tcont=0;  
    
    for(int i=0;i<keys.length;i++)
    {    	
    	    
      for(int k=0;k<strspl.length;k++)
      {
    	  if(strspl[k].equalsIgnoreCase(keys[i])||strspl[k].equalsIgnoreCase(keys[i]+","))
    	  {
    		  tcont++;
    		  fl=false;
    	  }
      }
      
    }    
    
    if(!fl)
      	{
    	String[] strsplit = str.split("\\."); 
    	for(int lin=0;lin<strsplit.length;lin++)
    	{
      		output.write(strsplit[lin]+".");
          	output.newLine();          	
    	}
    	count.add(tcont);         
      	OutFline++; 

      	}
    }    
    for(int s=0;s<count.size();s++)
    {
    	MainCount =MainCount+(Integer)count.get(s);
    	LineIndex = LineIndex+"@"+(Integer)count.get(s);
    }
    
    System.out.println("MainCount ="+MainCount);  
      in.close();
      output.close();
    }
    catch (Exception e)
    {
      //e.printStackTrace();
    }
    
    
    return "ss";
  }
	//end of method for find keyword 
	
	
	//start of method for insert the key counting o DB  	
	public int Insertkeycount(String schema,String Uname,String Infile,String outfile,String keyW, String percentage) {
		// TODO Auto-generated method stub

		try{
			
			
			Class.forName("com.mysql.jdbc.Driver");
		
			Connection connection =	DriverManager.getConnection("jdbc:mysql://localhost/SUMMARI","root","");
			Statement statement;
			
			statement = connection.createStatement();
			try{
			if(!statement.execute("select * from "+Uname))
				{
					statement.executeUpdate("CREATE TABLE "+Uname+" ( INCOUNT INTEGER, OUTCOUNT INTEGER, KEYW VARCHAR (255), PERCEN VARCHAR (255))" ) ;					
				}
			   statement.executeUpdate("insert into "+Uname+" values("+InFline+","+OutFline+",'"+keyW+"','"+percentage+"')");
			   statement.executeUpdate("insert into SUMMARIZATION values('"+Uname+"','"+Infile+"','"+outfile+"','"+keyW+"',"+MainCount+")");
			
		    }
			catch (SQLException e) {
				statement.executeUpdate("CREATE TABLE "+Uname+" ( INCOUNT INTEGER, OUTCOUNT INTEGER, KEYW VARCHAR (255), PERCEN VARCHAR (255))" ) ;
				statement.executeUpdate("insert into "+Uname+" values("+InFline+","+OutFline+",'"+keyW+"','"+percentage+"')");
   			    statement.executeUpdate("insert into SUMMARIZATION values('"+Uname+"','"+Infile+"','"+outfile+"','"+keyW+"',"+MainCount+")");
			
			
		}
		}catch (Exception e) {
					
			//e.printStackTrace();
			//return e.toString()+":0";
		}
					
		   return InFline;
	}	
	
	//start of method for insert the key counting o DB  	
	public String Chart(String Uname, String Infile) {
		// TODO Auto-generated method stub
		String Chatval =""; 
		try {
			
			Class.forName("com.mysql.jdbc.Driver");
			Connection connection =	DriverManager.getConnection("jdbc:mysql://localhost/SUMMARI","root","");
			Statement statement;
			
			statement = connection.createStatement();
			ResultSet rs = statement.executeQuery("SELECT DISTINCT keyword,count FROM SUMMARIZATION where Uname='"+Uname+"' and in_file='"+Infile+"'order by count desc");
			while(rs.next())
			{
				Chatval = Chatval+","+rs.getString("keyword")+"@"+(String)rs.getString("count");
			}			
			
		   } catch (Exception e) {
			// TODO: handle exception
			
			//e.printStackTrace();
			//return e.toString()+":0";
		}
		   return Chatval;
	}
	
	
	
	public String Chart1(String Uname) {
		// TODO Auto-generated method stub
		String Chatval =""; 
		try {
			
			Class.forName("com.mysql.jdbc.Driver");
			Connection connection =	DriverManager.getConnection("jdbc:mysql://localhost/SUMMARI","root","");
			Statement statement;
			
			statement = connection.createStatement();
			ResultSet rs = statement.executeQuery("SELECT DISTINCT * FROM "+Uname+" order by outcount desc");
			while(rs.next())
			{
				
				float Incunt = rs.getInt("incount");
				float outcunt = rs.getInt("outcount");
				String key = rs.getString("keyw");
				float percen = rs.getInt("percen");
				
				float percent = ((Incunt*percen) / 100);			

				float p = (float)Math.pow(10,0);
				percent = percent * p;
				float tmp = Math.round(percent);
				
				percent = tmp/p;
				
					Chatval = Chatval+"@"+key;
				
				
			}			
			
		   } catch (Exception e) {
			// TODO: handle exception
			
			//e.printStackTrace();
			//return e.toString()+":0";
		}
		   return Chatval;
	}
	
	
	
	
	//start of method for Stopword finding
	public String StopWord(String strline)
	{
		
		String strReturn="";
		String[] strL=strline.split(" ");
     	
		
		try {
			
			Class.forName("com.mysql.jdbc.Driver");
			Connection connection =	DriverManager.getConnection("jdbc:mysql://localhost/SUMMARI","root","");
			Statement statement;
			
			statement = connection.createStatement();
			ResultSet rs ;
			for(int i=0;i<strL.length;i++)
	     	{
			rs= statement.executeQuery("SELECT Swords FROM STOPWORDS where Swords='"+strL[i]+"'");
			
			if(!rs.next())
			{
					strReturn +=" "+strL[i];
							     		
	     	}
			}			
			
		   } catch (Exception e) {
			// TODO: handle exception
			
			//e.printStackTrace();
			//return e.toString()+":0";
		}
		
		
     	return strReturn;
	}
	
}
