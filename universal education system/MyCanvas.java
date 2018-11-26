//MyCanvas.java

import java.lang.*;
import java.io.*;
import java.util.*;
import java.awt.*;
import java.awt.image.*;
import java.awt.event.*;
import javax.swing.*;
import java.util.Vector.*;

public class MyCanvas extends JPanel implements MouseMotionListener,MouseListener
{
	//members
	private String Title;
	private Vector vpCurrentPage;
	private int DrawingInterval;
	private boolean Enabled;
	
	//internal members
	private int TitleHeight=22;
	private long TimeStart;
	private long TimeEnd;
	
	//drawing declarations
	boolean drawing=false;
	int startx,starty;

	//constructor
	public MyCanvas()
	{
		Title="";
		vpCurrentPage=new Vector();
                Page pNewPage = new Page();
                vpCurrentPage.add(pNewPage);
		DrawingInterval=0;
		Enabled=false;
		
		this.addMouseMotionListener(this);
		this.addMouseListener(this);
	}
	
	//get functions
	public String getTitle()
	{
		return(Title);
	}
	
	public Page getCurrentPage()
	{
		int iSize;
		iSize = vpCurrentPage.size() - 1;
		return((Page)vpCurrentPage.get(iSize));
	}
	public Vector getCurrentPageVector()
	{
		return vpCurrentPage;
	}
	public int getDrawingInterval()
	{
		return(DrawingInterval);
	}
	
	public boolean getEnabled()
	{
		return(Enabled);
	}
	
	//set functions
	public void setTitle(String tTitle)
	{
		Title=tTitle;
		repaint();
	}
	
	public void setDrawingInterval(int tDrawingInterval)
	{
		DrawingInterval=tDrawingInterval;
		repaint();
	}
	
	public void setEnabled(boolean tEnabled)
	{
		Enabled=tEnabled;
		repaint();
	}
	
	public void setCurrentPage(Page tPage)
	{
		int iSize;
		iSize = vpCurrentPage.size() - 1;
		vpCurrentPage.set(iSize,tPage);
		repaint();
	}
	
	//events
	protected void paintComponent(Graphics g)
	{
		super.paintComponent(g);
		int iSize;
		iSize = vpCurrentPage.size() - 1;
                Page pCurrentPage = (Page)vpCurrentPage.get(iSize);
                try
                    {   
                        //draw title
                        if(Enabled==true) g.setColor(new Color(0,0,128)); else g.setColor(new Color(128,128,128));
			g.setFont(new Font("Verdana",Font.BOLD,12));
			
			String tstr=Title;
			tstr+=": "+pCurrentPage.get_nStrokes()+" Strokes, ";
			
			int tCount=0;
			if(pCurrentPage.get_nStrokes()>0) tCount=(pCurrentPage.getStroke(pCurrentPage.get_nStrokes()-1)).get_nPoints();
			tstr+=tCount+" Points";
			g.drawString(tstr,4,16);
			
			//draw points
			if(Enabled==true) g.setColor(new Color(0,0,0)); else g.setColor(new Color(128,128,128));
			for(int t=0;t<pCurrentPage.get_nStrokes();t++)
			{
				Stroke tStroke=pCurrentPage.getStroke(t);
				
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
			
			//draw border
			g.setColor(new Color(0,0,0));
			g.drawRect(0,0,getWidth()-1,getHeight()-1);
			g.drawLine(0,TitleHeight,getWidth()-1,TitleHeight);
		}
		catch(Exception err)
		{
			System.out.println("Error: "+err);
			System.exit(-1);
		}
	}

	//mousemotionlistener events
	public void mouseDragged(MouseEvent evt)
	{
		int iSize;
		iSize = vpCurrentPage.size() - 1;
                Page pCurrentPage = (Page)vpCurrentPage.get(iSize);
		if(drawing==true)
		{
			int tx=evt.getX();
			int ty=evt.getY();

			if(ty>=TitleHeight)
			{
				TimeEnd=System.currentTimeMillis();
				long TimeTaken1=TimeEnd-TimeStart;
	
				if(TimeTaken1>=DrawingInterval)
				{
					//add point to current stroke
					int tcount=pCurrentPage.getStroke(pCurrentPage.get_nStrokes()-1).get_nPoints();
					int prevx=pCurrentPage.getStroke(pCurrentPage.get_nStrokes()-1).getPoint(tcount-1).getX();
					int tdirection=prevx<tx?Globals.LR:Globals.RL;
					pCurrentPage.getStroke(pCurrentPage.get_nStrokes()-1).addPoint(new Point(tx,ty,tdirection));
					repaint();
					
					startx=tx;
					starty=ty;
					TimeStart=System.currentTimeMillis();
				}
			}
		}
	}
	
	public void mouseMoved(MouseEvent evt)
	{
		//
	}
	
	//mouselistener events
	public void mouseClicked(MouseEvent evt)
	{
		//
	}
	
	public void mouseEntered(MouseEvent evt)
	{
		//
	}
	
	public void mouseExited(MouseEvent evt)
	{
		//
	}
	
	public void mousePressed(MouseEvent evt)
	{
		int iSize;
		Page pCurrentPage;
		if(Enabled==true)
		{
			int tx=evt.getX();
			int ty=evt.getY();
			
			if(ty>=TitleHeight)
			{
				drawing=true;
				startx=tx;
				starty=ty;
				TimeStart=System.currentTimeMillis();
				
				//add new stroke
				Stroke tStroke=new Stroke();
				tStroke.addPoint(new Point(startx,starty,0));
				//Page pNewPage = new Page();
				//vpCurrentPage.add(pNewPage);
                                iSize = vpCurrentPage.size() - 1;
                                pCurrentPage = (Page)vpCurrentPage.get(iSize);
				pCurrentPage.addStroke(tStroke);
				repaint();
			}
		}
	}
	
	public void mouseReleased(MouseEvent evt)
	{
		drawing=false;
	}
	
	//methods
	public void Clear()
	{
		int iSize;
		iSize = vpCurrentPage.size() - 1;
                Page pCurrentPage = (Page)vpCurrentPage.get(iSize);
                pCurrentPage.removeAllStrokes();
                repaint();
	}
}
