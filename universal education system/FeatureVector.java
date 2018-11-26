//Feature.java

import java.lang.*;
import java.io.*;

public class FeatureVector
{
	private Page CurrentPage;
	private double Features[];
	private int nFeatures=12;
	
	//constructor
	public FeatureVector()
	{
		Features=new double[nFeatures];
		for(int t=0;t<nFeatures;t++) Features[t]=0.0f;
	}
	
	//get functions
	public Page getCurrentPage()
	{
		return(CurrentPage);
	}
	
	public double getFeature(int tIndex)
	{
		double tFeature=0.0;
		
		if(tIndex>=0&&tIndex<=11)
		{
			tFeature=Features[tIndex];
		}
		
		return(tFeature);
	}
	
	//set functions
	public void setCurrentPage(Page tCurrentPage)
	{
		CurrentPage=tCurrentPage;
	}
	
	//methods
	public int HID()
	{
		int tsum=0;
		
	
		for(int i=0;i<CurrentPage.get_nStrokes();i++)
		{
			tsum+=CurrentPage.hdir_interstroke(i,i+1);
		}
	
		return(tsum);
	}


        public int no_of_strokes()
	{
		int n_strokes=CurrentPage.get_nStrokes();
	
		return(n_strokes);
	}


	
	public double ASL()
	{
		double tans;
		int i,tsum=0;
	
		for(i=0;i<CurrentPage.get_nStrokes();i++) tsum=tsum+CurrentPage.length(i);
		tans=CurrentPage.get_nStrokes()==0?0:tsum/CurrentPage.get_nStrokes();
	
		return(tans);
	}
	
	public double ShirorekhaStrength()
	{
		double tans=0.0f;
	
		int tmax=0;
		for(int t=0;t<CurrentPage.get_nStrokes();t++)
		{
			int twidth=CurrentPage.width(t);
			if(tmax<twidth) tmax=twidth;
		}
		tans=(double)tmax;
	
		return(tans);
	}
	
	public double ShirorekhaConfidence()
	{
		double tans,maxans=0.0;
		int t,tval;
	
		//largest of shirorekha confidence of all strokes
		for(t=0;t<CurrentPage.get_nStrokes();t++)
		{
			tval=CurrentPage.sumwidth();
			tans=tval==0?0:(double)CurrentPage.width(t)/tval;
			tval=CurrentPage.sumheight();
			tans=tans*(tval==0?0:(double)CurrentPage.avgy(t)/tval);
			if(CurrentPage.width(t)!=0) tans=tans*(1-(double)(CurrentPage.height(t)/CurrentPage.width(t)));
			if(t==0) maxans=tans;
			else if(maxans<tans) maxans=tans;
		}
	
		maxans=maxans<0.0f?0.0f:maxans;
		return(maxans);
	}
	
	public double StrokeDensity()
	{
		double tans;
		int tval;
	
		tval=CurrentPage.sumwidth();
		tans=tval==0?0:(double)CurrentPage.get_nStrokes()/tval;
	
		return(tans);
	}
	
	public double AspectRatio()
	{
		double tans;
		int tval;
	
		tval=CurrentPage.sumheight();
		tans=tval==0?0:(double)CurrentPage.sumwidth()/tval;
	
		return(tans);
	}
	
	public int DistanceRL()
	{
		int tans=0,t;
	
		for(t=0;t<CurrentPage.get_nStrokes();t++) tans=tans+CurrentPage.distancerlcount(t);
	
		return(tans);
	}
	
	public int DistanceBT()
	{
		int tans=0,t;
	
		for(t=0;t<CurrentPage.get_nStrokes();t++) tans=tans+CurrentPage.distancebtcount(t);
	
		return(tans);
	}
	
	public int ReverseDistance()
	{
		int tans=0;
	
		tans=DistanceRL()+DistanceBT();
	
		return(tans);
	}
	
	public double AHD()
	{
		double tans=0.0f;
		int t;
	
		for(t=0;t<CurrentPage.get_nStrokes();t++) tans=tans+CurrentPage.hdir_intrastroke(t);
		tans=CurrentPage.get_nStrokes()==0?0:tans/CurrentPage.get_nStrokes();
	
		return(tans);
	}
	
	public double AVD()
	{
		double tans=0.0f;
		int t;
	
		for(t=0;t<CurrentPage.get_nStrokes();t++) tans=tans+CurrentPage.vdir_intrastroke(t);
		tans=CurrentPage.get_nStrokes()==0?0:tans/CurrentPage.get_nStrokes();
	
		return(tans);
	}
	
	public int VID()
	{
		int i,tsum=0;
	
		for(i=0;i<CurrentPage.get_nStrokes()-1;i++) tsum=tsum+CurrentPage.vdir_interstroke(i,i+1);
	
		return(tsum);
	}
	
	public double VarianceSL()
	{
		double tans=0.0f;
		int tmean,tsum=0,t,x;
	
		for(t=0;t<CurrentPage.get_nStrokes();t++) tsum=tsum+CurrentPage.length(t);
		tmean=CurrentPage.get_nStrokes()==0?0:tsum/CurrentPage.get_nStrokes();
	
		tsum=0;
		for(t=0;t<CurrentPage.get_nStrokes();t++)
		{
			x=CurrentPage.length(t);
			tsum=tsum+((x-tmean)*(x-tmean));
		}
		tans=(CurrentPage.get_nStrokes()-1)==0?0:tsum/(CurrentPage.get_nStrokes()-1);
	
		return(tans);
	}
	
	void ComputeVector()
	{
		Features[0]=(double)HID();
		Features[1]=ASL();
		Features[2]=ShirorekhaStrength();
		Features[3]=ShirorekhaConfidence();
		Features[4]=StrokeDensity();
		Features[5]=AspectRatio();
		Features[6]=(double)ReverseDistance();
		Features[7]=AHD();
		Features[8]=AVD();
		Features[9]=(double)VID();
		Features[10]=VarianceSL();
                Features[11]=(double)no_of_strokes();
	}
	
}
