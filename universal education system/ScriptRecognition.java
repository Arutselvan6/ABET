//ScriptRecognition.java

import java.lang.*;
import java.io.*;
import java.util.*;
import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import javax.swing.event.*;

public class ScriptRecognition implements ActionListener,ListSelectionListener
{
	//ui declarations
	String strTitle="Universal Education System";
	JFrame frmMain=new JFrame(strTitle);
	MyCanvas canvas1=new MyCanvas();
	JList lstScriptTypes=new JList();
	JScrollPane spScriptTypes=new JScrollPane(lstScriptTypes);
	JButton btNewScript=new JButton("New Script");
	JButton btEndScript=new JButton("End Script");
	JButton btSaveScript=new JButton("Save Script");
	JButton btClearScript=new JButton("Clear Script");
	JButton btRecognize=new JButton("Recognize");
	JButton btViewScript=new JButton("View Script");
	JButton btDeleteAllScripts=new JButton("Delete All Scripts");
	
	//system declarations
	String strScriptTypes[]={"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","X","Y","Z","RAM","PANKAJ","Recognition"};
	int CurrentScript=0;
	
	//constructor
	public ScriptRecognition()
	{
		//ui definitions
		frmMain.setDefaultLookAndFeelDecorated(true);
		frmMain.setResizable(true);
		frmMain.setBounds(200,200,940,680);
		frmMain.getContentPane().setLayout(null);
		frmMain.setLocationRelativeTo(null);
                frmMain.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		
		canvas1.setBounds(20,20,620,610);
		canvas1.setTitle("Script");
		canvas1.setDrawingInterval(20);
		frmMain.getContentPane().add(canvas1);
		//setting values for script list
		setScriptList();
		lstScriptTypes.addListSelectionListener(this);
		lstScriptTypes.setSelectedIndex(0);
		spScriptTypes.setBounds(frmMain.getWidth()-180,20,160,295);
		spScriptTypes.setColumnHeaderView(new JLabel("Script Type:"));
		frmMain.getContentPane().add(spScriptTypes);
		
		btNewScript.setBounds(frmMain.getWidth()-180,375,160,20);       
		btNewScript.addActionListener(this);
		frmMain.getContentPane().add(btNewScript);
		
		btEndScript.setBounds(frmMain.getWidth()-180,400,160,20);        
		btEndScript.addActionListener(this);
		btEndScript.setEnabled(false);
		frmMain.getContentPane().add(btEndScript);
		
		btClearScript.setBounds(frmMain.getWidth()-180,440,160,20);       
		btClearScript.addActionListener(this);
		btClearScript.setEnabled(false);
		frmMain.getContentPane().add(btClearScript);
		
		btSaveScript.setBounds(frmMain.getWidth()-180,465,160,20);        
		btSaveScript.addActionListener(this);
		btSaveScript.setEnabled(false);
		frmMain.getContentPane().add(btSaveScript);
		
		btRecognize.setBounds(frmMain.getWidth()-180,505,160,20);        
		btRecognize.addActionListener(this);
		btRecognize.setEnabled(false);
		frmMain.getContentPane().add(btRecognize);
		
		btViewScript.setBounds(frmMain.getWidth()-180,530,160,20);        
		btViewScript.addActionListener(this);
		frmMain.getContentPane().add(btViewScript);
		
		btDeleteAllScripts.setBounds(frmMain.getWidth()-180,555,160,20);     
		btDeleteAllScripts.addActionListener(this);
		frmMain.getContentPane().add(btDeleteAllScripts);
		
		frmMain.setVisible(true);
	}
	
	//events
	public void actionPerformed(ActionEvent evt)
	{
		if(evt.getSource()==btNewScript)
		{
			canvas1.Clear();
			canvas1.setEnabled(true);
			
			lstScriptTypes.setEnabled(false);
			btNewScript.setEnabled(false);
			btEndScript.setEnabled(true);
			btClearScript.setEnabled(true);
			
			if(CurrentScript<=25)
			{
				btSaveScript.setEnabled(true);
			}
			else
			{
				btRecognize.setEnabled(true);
			}
		}
		else if(evt.getSource()==btEndScript)
		{
			canvas1.Clear();
			canvas1.setEnabled(false);

			lstScriptTypes.setEnabled(true);
			btNewScript.setEnabled(true);
			btEndScript.setEnabled(false);
			btClearScript.setEnabled(false);
			btSaveScript.setEnabled(false);
			btRecognize.setEnabled(false);
		}
		else if(evt.getSource()==btClearScript)
		{
			canvas1.Clear();
		}
		else if(evt.getSource()==btSaveScript)
		{
			//save points ,counting script counts
			int tCount=findScriptCount(CurrentScript);
			String tPath="scripts\\"+strScriptTypes[CurrentScript]+"\\page"+tCount+".txt";
			canvas1.getCurrentPage().saveAsText(tPath);
			setScriptList();
			
			//save image
			tPath="scripts\\"+strScriptTypes[CurrentScript]+"\\page"+tCount+".jpg";
			canvas1.getCurrentPage().saveAsImage(tPath);
			
			//save feature
			tPath="scripts\\"+strScriptTypes[CurrentScript]+"\\feature"+tCount+".txt";
			canvas1.getCurrentPage().saveFeature(tPath);
			
			JOptionPane.showMessageDialog(null,"New Script Saved.");
		}
		else if(evt.getSource()==btRecognize)
		{
			int tScriptType=-1;
			int tCount=0;
			double MinDistance=0.0;
			
			for(int t=0;t<26;t++)
			{
				for(int j=0;j<Globals.MaxScripts;j++)
				{
					//delete script file, implementation of nearest neighbour algm
					String tPath="scripts\\"+strScriptTypes[t]+"\\page"+j+".txt";
					if(new File(tPath).exists()==true)
					{
						Page tPage=new Page();
						tPage.loadPage(tPath);
						
						if(tCount==0)
						{
							MinDistance=KNN.findDistance(tPage.getFeatureVector(),canvas1.getCurrentPage().getFeatureVector());
							tScriptType=t;
						}
						else
						{
							double tdistance=KNN.findDistance(tPage.getFeatureVector(),canvas1.getCurrentPage().getFeatureVector());
							if(MinDistance>tdistance)
							{
								MinDistance=tdistance;
								tScriptType=t;
							}
						}
						
						tCount+=1;
					}
				}
			}
			
			if(tScriptType==-1)// matched language
			{
				JOptionPane.showMessageDialog(null,"No Scripts Found.");
			}
			else
			{
				JOptionPane.showMessageDialog(null,"Matched: "+strScriptTypes[tScriptType]);
			}
		}
		else if(evt.getSource()==btViewScript)//view script
		{
			if(findScriptCount(CurrentScript)==0)
			{
				JOptionPane.showMessageDialog(null,"No Saved Scripts in "+strScriptTypes[CurrentScript]+".");
				return;
			}
			
			Object tObject=JOptionPane.showInputDialog("Enter Script Number:","1");
			if(tObject instanceof String)
			{
				int tScriptNo=Integer.parseInt((String)tObject);
				String tPath="scripts\\"+strScriptTypes[CurrentScript]+"\\page"+(tScriptNo-1)+".txt";

				Page tPage=new Page();
				tPage.loadPage(tPath);
				canvas1.setCurrentPage(tPage);
			}
		}
		else if(evt.getSource()==btDeleteAllScripts)//deleteing allscript
		{
			int tChoice=JOptionPane.showConfirmDialog(null,"Sure to Delete ?",strTitle,JOptionPane.YES_NO_OPTION,JOptionPane.QUESTION_MESSAGE);
			if(tChoice==JOptionPane.NO_OPTION) return;
			deleteAllScripts();
			setScriptList();
			JOptionPane.showMessageDialog(null,"All Scripts Deleted.");
		}
	}
	
	public void valueChanged(ListSelectionEvent evt)
	{
		if(evt.getSource()==lstScriptTypes)
		{
			if(lstScriptTypes.isSelectionEmpty()==false)
			{
				CurrentScript=lstScriptTypes.getSelectedIndex();
				canvas1.setTitle(strScriptTypes[CurrentScript]);
				
				btViewScript.setEnabled(CurrentScript!=26);
			}
		}
	}
	
	//internal methods vector declaration
	private void setScriptList()
	{
		Vector tVector=new Vector();
		for(int t=0;t<strScriptTypes.length;t++)
		{
			String tstr="";
			if(t<=25) tstr=" ("+findScriptCount(t)+")";
			tVector.add(strScriptTypes[t]+tstr);
		}
		lstScriptTypes.setListData(tVector);
	}
	
	private int findScriptCount(int tScriptID)
	{
		int tCount=0;
		
		for(int t=0;t<Globals.MaxScripts;t++)
		{
			String tPath="scripts\\"+strScriptTypes[tScriptID]+"\\page"+t+".txt";
			
			if(new File(tPath).exists()==false)
			{
				tCount=t;
				break;
			}
		}
		
		return(tCount);
	}
	
	private void deleteAllScripts()//deleting script method declaration.
	{
		for(int t=0;t<26;t++)
		{
			for(int j=0;j<Globals.MaxScripts;j++)
			{
				//delete script file
				String tPath="scripts\\"+strScriptTypes[t]+"\\page"+j+".txt";
				if(new File(tPath).exists()==true) new File(tPath).delete();
				
				//delete script image
				tPath="scripts\\"+strScriptTypes[t]+"\\page"+j+".jpg";
				if(new File(tPath).exists()==true) new File(tPath).delete();
				
				//delete script feature
				tPath="scripts\\"+strScriptTypes[t]+"\\feature"+j+".txt";
				if(new File(tPath).exists()==true) new File(tPath).delete();
			}
		}
	}
	
	//methods
	public static void main(String args[])
	{
		new ScriptRecognition();
	}
}
