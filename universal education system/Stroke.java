//Stroke.java

import java.lang.*;
import java.io.*;
import java.util.*;

public class Stroke
{
	private ArrayList Points;
	
	//constructor
	public Stroke()
	{
		Points=new ArrayList();
	}
	
	//get functions
	public int get_nPoints()
	{
		return(Points.size());
	}
	
	public Point getPoint(int tIndex)
	{
		Point tPoint=new Point();
		
		if(tIndex>=0&&tIndex<=Points.size()-1)
		{
			tPoint=(Point)Points.get(tIndex);
		}
		
		return(tPoint);
	}
	
	//set functions
	public void setPoint(int tIndex,Point tPoint)
	{
		if(tIndex>=0&&tIndex<=Points.size()-1)
		{
			Points.set(tIndex,tPoint);
		}
	}
	
	//methods
	public void addPoint(Point tPoint)
	{
		Point pt1=new Point(tPoint.getX(),tPoint.getY(),tPoint.getDirection());
		Points.add(pt1);
	}
	//remove points
	public Point removePoint(int tIndex)
	{
		Point pt1=(Point)Points.get(tIndex);
		Point tPoint=new Point(pt1.getX(),pt1.getY());
		Points.remove(tIndex);
		return(tPoint);
	}
	
	public Point removePoint(Point tPoint)
	{
		Point pt2=new Point();
		
		for(int t=0;t<=Points.size()-1;t++)
		{
			if(tPoint.isEquals(getPoint(t))==true)
			{
				Point pt1=(Point)Points.get(t);
				pt2=new Point(pt1.getX(),pt1.getY());
				removePoint(t);
				break;
			}
		}
		
		return(pt2);
	}
	
	public void removeAllPoints()
	{
		while(Points.size()!=0)
		{
			for(int t=0;t<=Points.size()-1;t++)
			{
				removePoint(t);
			}
		}
	}
	
	public String toString()
	{
		String tStr="";
		
		for(int t=0;t<=Points.size()-1;t++)
		{
			tStr+=((Point)Points.get(t)).toString()+"\n";
		}
		
		return(tStr);
	}
}
