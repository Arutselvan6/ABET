//Point.java

import java.lang.*;
import java.io.*;

public class Point
{
	private int X;
	private int Y;
	private int Direction;
	
	//constructor
	public Point()
	{
		X=0;
		Y=0;
	}
	
	public Point(int tX,int tY)
	{
		X=tX;
		Y=tY;
	}
	
	public Point(int tX,int tY,int tDirection)
	{
		X=tX;
		Y=tY;
		Direction=tDirection;
	}
	
	//get functions
	public int getX()
	{
		return(X);
	}
	
	public int getY()
	{
		return(Y);
	}
	
	public int getDirection()
	{
		return(Direction);
	}
	
	//set functions
	public void setX(int tX)
	{
		X=tX;
	}
	
	public void setY(int tY)
	{
		Y=tY;
	}
	
	public void setDirection(int tDirection)
	{
		Direction=tDirection;
	}
	
	//methods
	public boolean isEquals(Point tPoint)
	{
		boolean flag=false;
		
		if(X==tPoint.getX()&&Y==tPoint.getY())
		{
			flag=true;
		}
		
		return(flag);
	}
	
	public boolean isBetween(Point p1,Point p2)
	{
		boolean flag=false;
		
		if(X>=p1.getX()&&X<=p2.getX())
		{
			if(Y>=p1.getY()&&Y<=p2.getY())
			{
				flag=true;
			}
		}
		
		return(flag);
	}
	
	public String toString()
	{
		String tStr="";
		
		tStr="("+X+","+Y+")";
		
		return(tStr);
	}
}
