//Page.java

import java.lang.*;
import java.io.*;
import java.util.*;
import java.awt.*;
import java.awt.image.*;
import javax.imageio.*;

public class Page
{
	private Vector Strokes;
	
	//constructor
	public Page()
	{
		Strokes=new Vector();
	}
	
	//get functions
	public int get_nStrokes()
	{
		return(Strokes.size());
	}
	
	public Stroke getStroke(int tIndex)
	{
		Stroke tStroke=new Stroke();
		
		if(tIndex>=0&&tIndex<=Strokes.size()-1)
		{
			tStroke=(Stroke)Strokes.get(tIndex);
		}
		
		return(tStroke);
	}
	
	//internal methods
	public static String readLine(FileInputStream tfin)
	{
		String tans="";
		
		try
		{
			int ch=0,i;
			while(true)
			{
				ch=tfin.read();
				if(ch==-1)
				{
					tans="";
					break;
				}
				if(ch==13||ch==10)
				{
					break;
				}
				tans+=(char)ch;
			}
			if(ch==13) tfin.read();
		}
		catch(Exception err)
		{
			System.out.println("Error: "+err);
			System.exit(-1);
		}
		
		return(tans);
	}
	
	//methods
	public void addStroke(Stroke tStroke)
	{
		Strokes.add(tStroke);
	}
	
	public void removeStroke(int tIndex)
	{
		if(tIndex>=0&&tIndex<=Strokes.size()-1)
		{
			Strokes.remove(tIndex);
		}
	}
	
	public void removeAllStrokes()
	{
		while(Strokes.size()!=0)
		{
			for(int t=0;t<=Strokes.size()-1;t++)
			{
				removeStroke(t);
			}
		}
	}
	
	public void saveAsText(String tFilePath)
	{
		try
		{
			FileOutputStream fout=new FileOutputStream(tFilePath);
			
			fout.write((get_nStrokes()+"\r\n").getBytes());
			for(int t=0;t<get_nStrokes();t++)
			{
				Stroke tStroke=getStroke(t);
				fout.write((tStroke.get_nPoints()+"\r\n").getBytes());
				
				for(int j=0;j<tStroke.get_nPoints();j++)
				{
					Point tPoint=tStroke.getPoint(j);
					fout.write((tPoint.getX()+" "+tPoint.getY()+" "+tPoint.getDirection()+"\r\n").getBytes());
				}
			}
			
			fout.close();
		}
		catch(Exception err)
		{
			System.out.println("Error: "+err);
			System.exit(-1);
		}
	}

	public void saveAsImage(String tFilePath)
	{
		//create buffered image
		BufferedImage buffimg1=new BufferedImage(420,410,BufferedImage.TYPE_INT_RGB);
		Graphics2D g=buffimg1.createGraphics();
		
		//draw points on buffered image
		g.setColor(new Color(255,255,255));
		for(int t=0;t<get_nStrokes();t++)
		{
			Stroke tStroke=getStroke(t);
			
			if(tStroke.get_nPoints()==1)
			{
				Point p1=tStroke.getPoint(0);
				g.drawRect(p1.getX(),p1.getY(),1,1);
			}
			else if(tStroke.get_nPoints()>1)
			{
				for(int j=0;j<tStroke.get_nPoints()-1;j++)
				{
					Point p1=tStroke.getPoint(j);
					Point p2=tStroke.getPoint(j+1);
					g.drawLine(p1.getX(),p1.getY(),p2.getX(),p2.getY());
				}
			}
		}
		
		//write script image
		try
		{
			ImageIO.write(buffimg1,"JPEG",new File(tFilePath));
		}
		catch(Exception err)
		{
			System.out.println("Error: "+err.getMessage());
			System.exit(-1);
		}
	}
	
	public void saveFeature(String tFilePath)
	{
		try
		{
			FileOutputStream fout=new FileOutputStream(tFilePath);
			
			FeatureVector tFeatureVector=new FeatureVector();
			tFeatureVector.setCurrentPage(this);
			tFeatureVector.ComputeVector();
			
			for(int t=0;t<12;t++)
			{
				fout.write((tFeatureVector.getFeature(t)+"\r\n").getBytes());
			}
			
			fout.close();
		}
		catch(Exception err)
		{
			System.out.println("Error: "+err.getMessage());
			System.exit(-1);
		}
	}
	
	public FeatureVector getFeatureVector()
	{
		FeatureVector tFeatureVector=new FeatureVector();
		tFeatureVector.setCurrentPage(this);
		tFeatureVector.ComputeVector();
		return(tFeatureVector);
	}
	
	public void loadPage(String tPath)
	{
		try
		{
			removeAllStrokes();
			
			FileInputStream fin=new FileInputStream(tPath);
			
			int nStrokes=Integer.parseInt(readLine(fin));
			for(int t=0;t<nStrokes;t++)
			{
				Stroke tStroke=new Stroke();
				
				int nPoints=Integer.parseInt(readLine(fin));
				for(int j=0;j<nPoints;j++)
				{
					String tstr=readLine(fin);
					String[] tarr=StringUtils.split(tstr," ");
					
					Point tPoint=new Point();
					tPoint.setX(Integer.parseInt(tarr[0]));
					tPoint.setY(Integer.parseInt(tarr[1]));
					tPoint.setDirection(Integer.parseInt(tarr[2]));
					
					tStroke.addPoint(tPoint);
				}
				
				addStroke(tStroke);
			}
			
			fin.close();
		}
		catch(Exception err)
		{
			System.out.println("Error: "+err.getMessage());
			System.exit(-1);
		}
	}
	
	int hdir_interstroke(int tstrokeid1,int tstrokeid2)
	{
		int tans;
		tans=getStroke(tstrokeid1).getPoint(0).getX()<getStroke(tstrokeid2).getPoint(0).getX()?1:-1;
		return(tans);
	}
	
	int vdir_interstroke(int tstrokeid1,int tstrokeid2)
	{
		int tans;
		tans=avgy(tstrokeid1)<avgy(tstrokeid2)?1:-1;
		return(tans);
	}
	
	int hdir_intrastroke(int tstrokeid)
	{
		int tans;
		tans=getStroke(tstrokeid).getPoint(0).getX()<getStroke(tstrokeid).getPoint(getStroke(tstrokeid).get_nPoints()-1).getX()?1:-1;
		return(tans);
	}
	
	int vdir_intrastroke(int tstrokeid)
	{
		int tans;
		tans=getStroke(tstrokeid).getPoint(0).getY()<getStroke(tstrokeid).getPoint(getStroke(tstrokeid).get_nPoints()-1).getY()?1:-1;
		return(tans);
	}
	
	int length(int tstrokeid)
	{
		return(getStroke(tstrokeid).get_nPoints());
	}
	
	int width(int tstrokeid)
	{
		int tx1,tx2;
		tx1=getStroke(tstrokeid).getPoint(0).getX();
		tx2=getStroke(tstrokeid).getPoint(getStroke(tstrokeid).get_nPoints()-1).getX();
		return(Math.abs(tx1-tx2));
	}
	
	int height(int tstrokeid)
	{
		int ty1,ty2;
		ty1=getStroke(tstrokeid).getPoint(0).getY();
		ty2=getStroke(tstrokeid).getPoint(getStroke(tstrokeid).get_nPoints()-1).getY();
		return(Math.abs(ty1-ty2));
	}
	
	int sumwidth()
	{
		int i,tsumwidth=0;
		for(i=0;i<Strokes.size();i++) tsumwidth=tsumwidth+width(i);
		return(tsumwidth);
	}
	
	int sumheight()
	{
		int i,tsumheight=0;
		for(i=0;i<Strokes.size();i++) tsumheight=tsumheight+height(i);
		return(tsumheight);
	}
	
	int sumx(int tstrokeid)
	{
		int t,tsum=0;
		for(t=0;t<getStroke(tstrokeid).get_nPoints();t++)
		{
			tsum+=getStroke(tstrokeid).getPoint(t).getX();
		}
		return(tsum);
	}
	
	int sumy(int tstrokeid)
	{
		int t,tsum=0;
		for(t=0;t<getStroke(tstrokeid).get_nPoints();t++)
		{
			tsum+=getStroke(tstrokeid).getPoint(t).getY();
		}
		return(tsum);
	}
	
	double avgx(int tstrokeid)
	{
		double tans;
		int tval;
	
		tval=getStroke(tstrokeid).get_nPoints();
		tans=tval==0?0:sumx(tstrokeid)/tval;
		return(tans);
	}
	
	double avgy(int tstrokeid)
	{
		double tans;
		int tval;
	
		tval=getStroke(tstrokeid).get_nPoints();
		tans=tval==0?0:sumy(tstrokeid)/tval;
		return(tans);
	}
	
	int distancerlcount(int tstrokeid)
	{
		int t,tsum=0,tdirection;
		for(t=0;t<getStroke(tstrokeid).get_nPoints();t++)
		{
			tdirection=getStroke(tstrokeid).getPoint(t).getDirection();
			if(tdirection==Globals.NW||tdirection==Globals.W||tdirection==Globals.SW) tsum=tsum+1;
		}
		return(tsum);
	}
	
	int distancebtcount(int tstrokeid)
	{
		int t,tsum=0,tdirection;
		for(t=0;t<getStroke(tstrokeid).get_nPoints();t++)
		{
			tdirection=getStroke(tstrokeid).getPoint(t).getDirection();
			if(tdirection==Globals.NW||tdirection==Globals.N||tdirection==Globals.NE) tsum=tsum+1;
		}
		return(tsum);
	}
}
