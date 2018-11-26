//KNN.java

import java.lang.*;
import java.io.*;

public class KNN
{
	//find euclidean distance between two feature vectors
	public static double findDistance(FeatureVector fvector1,FeatureVector fvector2)
	{
		double tsum=0.0;
		
		for(int t=0;t<12;t++)
		{
			double tval=fvector1.getFeature(t)-fvector2.getFeature(t);
			tsum=tsum+(tval*tval);
		}
		double tans=Math.sqrt(tsum);
		
		return(tans);
	}
}
