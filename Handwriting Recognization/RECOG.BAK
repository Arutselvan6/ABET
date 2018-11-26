#include<graphics.h>
#include<iostream.h>
#include<process.h>
#include<string.h>
#include<stdlib.h>
#include<stdio.h>
#include<conio.h>
#include<dos.h>
#include<io.h>
#include<fcntl.h>
#include<sys\stat.h>

#define BGIpath "\recogn"
#define CFGFILE "3dlaser.cfg"

// define key
#define UPKEY 0x48
#define DOWNKEY 0x50
#define LEFTKEY 0x4b
#define RIGHTKEY 0x4d

const int MAX=150;
const int scale=10;
const int offsetx=10,offsety=80;//10,80,10+150,80+150
const int dis_offx=10+470,dis_offy=80;
const int dis_datax=10+230,dis_datay=80;
int main_menu_status_cha,main_menu_status_cur;		// variable for changed status & current status
int no1,no2,no3,no4,no5;

char	title[80]	=" C h a r a c t e r  R e c o g n i z a t i o n   ";
char	menu1[40]	=" Character Recognization ",
		menu_1[40]	=" _         ",
		menu2[40]	=" About ... ",
		menu_2[40]	=" _         ",
		menu3[40]	=" EXIT ! ",
		menu_3[40]	="  _     ",
		menu4[40]	=" ",
		menu_4[40]	=" ",
		menu5[40]	=" ",
		menu_5[40]	=" ";
char	shortcut_menu_1	='a',
		shortcut_menu_2	='d',
		shortcut_menu_3	='u',
		shortcut_menu_4	='o',
		shortcut_menu_5	='x';

char	screen_r	= 6,
		screen_g	= 8,
		screen_b	=10;

char	animation	=1;

int maintxtcolor=WHITE;
int mainbgcolor=BLACK;

int gmode,errorcode,gdriver=DETECT;
int xx,yy;						// variable for maximum pixel
int cur_x,cur_y;           // variable for current coordinate
char coord_buf[80];				// variable for coordinate buffer to display
int mnx,mny,mxx,mxy;
int image_data[scale][scale];
int image_save[scale][scale];
int stat_cha='h',stat_cur='h';
char buffer[80];

void main_menu();
void main_menu_status_window();
void init_graphic();
unsigned far getpixel(int x,int y);
void init_mouse();
void show_mouse();
void hide_mouse();
void move_mouse(int x,int y);
void recog();
void status_window();
void recog_screen();
void scanline(unsigned int *bufsize);
void check_text();
void open_file(unsigned int bufsize);
void teach___(unsigned int bufsize);
int file_exists(char *filename);
void about();
void about_screen();

// function prototype for screen effect
void heading(int r,int g,int b);
void border(int x1,int y1,int x2,int y2,int color);
void splash_text(int ax,int ay,int splash_tail,int time_d,int co1,int co2,char *text_buf);
void frame(int ax,int ay,int bx,int by,int co1,int co2,int co3);
void push_frame(int ax,int ay,int bx,int by,int co1,int co2);
void frame_line(int ax,int ay,int bx,int by,int co1,int co2,int co3);
void push_frame_line(int ax,int ay,int bx,int by,int co1,int co2);
void shadow(int ax,int ay,char *tex);
void shadowy(int ax,int ay,char *tex);
void coord(int x,int y);

// function prototype for prompt for exit
int yes_no();

void main()
{
	char choice;
	int key;
	unsigned int size;
	int option,status=1;
	int quit=0,ButtonStatus,x,y;
	void *arrow;

	init_graphic();
	main_menu();
	init_mouse();

	show_mouse();
	move_mouse(30,20);

	no1=no2=no3=no4=no5=0;
	main_menu_status_cur=1;
	main_menu_status_cha=0;

	while(!quit)
	{
		while(kbhit())
		{
			key=getch();
			if (key==80)
			{
				if (status==3)
				status=1;
				else
				status++;
			}
			else
			if (key==72)
			{
				if (status==1)
				status=3;
				else
				status--;
			}
			else
			if (key==27)
			{
				if (status!=3)
					status=3;
			}
			else
			if (key==13)
			{
				ButtonStatus=1;
			}

			switch(status)
			{
				case 1 :	move_mouse(320,150);
							option=0;
							break;
				case 2 :	move_mouse(320,250);
							option=0;
							break;
				case 3 :	move_mouse(320,350);
							option=0;
							break;
			}
		}

		_AX=3;
		geninterrupt(0X33);
		x=_CX;
		y=_DX;

		if (key!=13)
			ButtonStatus=_BX;
		else
			key=0;

//		coord(x,y);

		if (x>200&&x<xx-200&&y>160&&y<180)
		{
			if (option!=1)
			{
				hide_mouse();
				push_frame_line(200,160,xx-200,180,WHITE,DARKGRAY);
				show_mouse();
				option=1;
			}
		}
		else
		if (x>200&&x<xx-200&&y>160+40&&y<180+40)
		{
			if (option!=2)
			{
				hide_mouse();
				push_frame_line(200,160+40,xx-200,180+40,WHITE,DARKGRAY);
				show_mouse();
				option=2;
			}
		}
		else
		if (x>200&&x<xx-200&&y>160+80&&y<180+80)
		{
			if (option!=3)
			{
				hide_mouse();
				push_frame_line(200,160+80,xx-200,180+80,WHITE,DARKGRAY);
				show_mouse();
				option=3;
			}
		}
		else
		{
			if(option)
				hide_mouse();
			switch(option)
			{
				case 1	:
							push_frame_line(200,160,xx-200,180,DARKGRAY,WHITE);
							break;
				case 2	:
							push_frame_line(200,160+40,xx-200,180+40,DARKGRAY,WHITE);
							break;
				case 3	:
							push_frame_line(200,160+80,xx-200,180+80,DARKGRAY,WHITE);
							break;
			}
			if(option)
				show_mouse();
			status=0;
			option=0;
			//continue;
		}

		if (ButtonStatus)
		{
			hide_mouse();
			switch(option)
			{
				case 1 :	delay(100);
							push_frame_line(200,160,xx-200,180,DARKGRAY,WHITE);
							delay(100);
							push_frame_line(200,160,xx-200,180,WHITE,DARKGRAY);
							delay(100);
							mnx=0;mny=0;mxx=0;mxy=0;
							recog();
							break;

				case 2 : delay(100);
							push_frame_line(200,160+40,xx-200,180+40,DARKGRAY,WHITE);
							delay(100);
							push_frame_line(200,160+40,xx-200,180+40,WHITE,DARKGRAY);
							delay(100);
							cleardevice();
							about();
							break;

				case 3 :	delay(100);
							push_frame_line(200,160+80,xx-200,180+80,DARKGRAY,WHITE);
							delay(100);
							push_frame_line(200,160+80,xx-200,180+80,WHITE,DARKGRAY);
							delay(100);
							quit=yes_no();
							if (!quit)
							{
								main_menu();
								show_mouse();
							}
							else
							{
								cleardevice();
								closegraph();
								clrscr();
								exit(0);
							}
				default:	show_mouse();
							continue;
			}
			// end switch
			if (!quit)
			{
				main_menu();
				show_mouse();
				status=1;
				option=0;
			}
		}
		else
		{
			main_menu_status_cha=option;
			if(main_menu_status_cha!=main_menu_status_cur)
			{
				hide_mouse();
				main_menu_status_window();
				show_mouse();
			}
		}
		// end if (ButtonStatus)
	}
	// end while (!quit)
}
// end void main()

void main_menu()
{
	int text_length;
	int text_line;
	int cx,cy;

	struct palettetype pal;

	cleardevice();
	heading(screen_r,screen_g,screen_b);//5,10,12);
	setbkcolor(mainbgcolor);

/*	getpalette(&pal);
	for (int i=0;i<pal.size;i++)
	setrgbpalette(pal.colors[i],i*60,i*50,i*50);*/

//	frame(3,3,xx-3,yy-3,LIGHTGRAY,DARKGRAY,mainbkcolor);
//	push_frame(3+3,3+3,xx-3-3,yy-3-3,DARKGRAY,LIGHTGRAY);

	//	main menu screen

	// display title
	border(xx/2-250,55-15,xx/2+250,55+15,BLACK);
	settextstyle(0,HORIZ_DIR,1);
	setcolor(WHITE);
	settextstyle(DEFAULT_FONT,HORIZ_DIR,1);
	settextjustify(CENTER_TEXT,CENTER_TEXT);
	text_length=textwidth(title);
	text_length-=8;
	splash_text(xx/2-text_length/2+1,55+2,6,35,BROWN,WHITE,title);
	splash_text(xx/2-text_length/2-1,55-0,0,8,WHITE,0,title);
//	outtextxy(xx/2,60,title);

	frame_line(100,130,xx-100,300,WHITE,DARKGRAY,LIGHTGRAY);

	push_frame_line(200,160,xx-200,180,DARKGRAY,WHITE);
	setcolor(BLACK);
	outtextxy(xx/2,170,menu1);
	//	recognization text button

	push_frame_line(200,160+40,xx-200,180+40,DARKGRAY,WHITE);
	setcolor(BLACK);
	outtextxy(xx/2,170+40,menu2);
	//	about button

	push_frame_line(200,160+80,xx-200,180+80,DARKGRAY,WHITE);
	setcolor(BLACK);
	outtextxy(xx/2,170+80,menu3);
	//	exit button

	// display status column
	frame(22,390,xx-22,390+67,LIGHTBLUE,BLUE,BLACK);
	push_frame(22+3,390+3,xx-22-3,390+67-3,BLUE,LIGHTBLUE);
	cx=427;
	cy=390;
	setcolor(BLUE);
	line(cx+1,cy+3-3,cx+1,cy+67-3+3);
	line(cx+2,cy+3-2,cx+2,cy+67-3+2);
	line(cx+3,cy+3-1,cx+3,cy+67-3+1);
	setcolor(LIGHTBLUE);
	line(cx-0,cy+3-3,cx-0,cy+67-3+3);
	line(cx-1,cy+3-2,cx-1,cy+67-3+2);
	line(cx-2,cy+3-1,cx-2,cy+67-3+1);

	settextstyle(DEFAULT_FONT,HORIZ_DIR,1);
	settextjustify(LEFT_TEXT,RIGHT_TEXT);
	shadowy(450,400,"Developed by :");
	shadowy(470,410," joy and arindam ");
	shadowy(450,430,"project guide:");
	shadowy(480,440,"Ms Archana");
	settextstyle(0,0,1);

}
// end void main_menu()

// function for user friendly
void main_menu_status_window()
{
	settextjustify(CENTER_TEXT,CENTER_TEXT);
	setfillstyle(SOLID_FILL,BLACK);
	bar(10+10+5,330+60+5,xx-10-200-5,yy-10-10-5);
	main_menu_status_cur=main_menu_status_cha;
	switch(main_menu_status_cha)
	{
		case 1	:
						//	display entering text recognization software help
						shadowy(10+10+410/2,330+60+5+5,"HELP : Character Recognization Program");
						shadowy(10+10+410/2,330+60+20+5,"Click the button to use the software");
						shadowy(10+10+410/2,330+60+35+5,"for character recognition");

						setcolor(WHITE);
						outtextxy(xx/2,170,menu1);
						no1=1;

						setcolor(BLACK);
						if(no2)
						{
							outtextxy(xx/2,170+40,menu2);
							no2=0;
						}
						if(no3)
						{
							outtextxy(xx/2,170+80,menu3);
							no3=0;
						}
						break;
		case 2	:
						//	display about author help
						shadowy(10+10+410/2,330+60+5+5,"HELP : About the Software");
						shadowy(10+10+410/2,330+60+20+5,"Click the button to read information");
						shadowy(10+10+410/2,330+60+35+5,"about the Project and the team members");

						setcolor(WHITE);
						outtextxy(xx/2,170+40,menu2);
						no2=1;

						setcolor(BLACK);
						if(no1)
						{
							outtextxy(xx/2,170,menu1);
							no1=0;
						}
						if(no3)
						{
							outtextxy(xx/2,170+80,menu3);
							no3=0;
						}
						break;
		case 3	:
						//	display exit program help
						shadowy(10+10+410/2,330+60+5+5,"HELP : Exit Program ...");
						shadowy(10+10+410/2,330+60+20+5,"Click the button to quit");
						shadowy(10+10+410/2,330+60+35+5,"this program.");
						setcolor(WHITE);
						outtextxy(xx/2,170+80,menu3);
						no3=1;

						setcolor(BLACK);
						if(no1)
						{
							outtextxy(xx/2,170,menu1);
							no1=0;
						}
						if(no2)
						{
							outtextxy(xx/2,170+40,menu2);
							no2=0;
						}
						break;
		case 4	:
						//	display edit preferernce help
						shadowy(10+10+410/2,330+60+5+5,"HELP : Option");
						shadowy(10+10+410/2,330+60+20+5,"Click the button to edit the");
						shadowy(10+10+410/2,330+60+35+5,"preference of text and colour.");
						setcolor(WHITE);
						outtextxy(320,200+90+0,menu4);
						no4=1;

						setcolor(BLACK);
						if(no1)
						{
							outtextxy(320,200+0,menu1);
							no1=0;
						}
						if(no2)
						{
							outtextxy(320,200+30+0,menu2);
							no2=0;
						}
						if(no3)
						{
							outtextxy(320,200+60+0,menu3);
							no3=0;
						}
						if(no5)
						{
							outtextxy(320,200+120+0,menu5);
							no5=0;
						}
						break;
		default	:
						//	display status window

						shadowy(10+10+410/2,330+60+20+5," Move the mouse pointer ");
						shadowy(10+10+410/2,330+60+35+5," to select menu button ");


						setcolor(BLACK);

						if(no1)
						{
							outtextxy(xx/2,170,menu1);
							no1=0;
						}
						if(no2)
						{
							outtextxy(xx/2,170+40,menu2);
							no2=0;
						}
						if(no3)
						{
							outtextxy(xx/2,170+80,menu3);
							no3=0;
						}
						if(no4)
						{
							outtextxy(xx/2,170+0,menu4);
							no4=0;
						}
						if(no5)
						{
							outtextxy(xx/2,170+0,menu5);
							no5=0;
						}

	}
	settextjustify(LEFT_TEXT,RIGHT_TEXT);
}
// end void main_menu_status_window()

void init_graphic()
{
	initgraph(&gdriver,&gmode,BGIpath);
	errorcode=graphresult();

	if (errorcode!=grOk)
	{
		printf("Graphics error. %s\n",grapherrormsg(errorcode));
		printf("Press any key to HALT.");
		getch();
		exit(1);
	}
	xx=getmaxx();
	yy=getmaxy();
}
// end void init_graphic()

void init_mouse()
{
	char status;

	_AX=0;
	geninterrupt(0X33);
	status=_AX;
	if (status!=-1)
		return;
}
// end void init_mouse()

void show_mouse()
{
	_AX=1;
	geninterrupt(0X33);
}
// end void show_mouse()

void hide_mouse()
{
	_AX=2;
	geninterrupt(0X33);
}
// end void hide_mouse()

void move_mouse(int x,int y)
{
	_AX=4;
	_CX=x;
	_DX=y;
	geninterrupt(0X33);
}
// end void move_mouse()

// function for graphic
void heading(int r,int g,int b)
{
	int i,ht=0,wt=16;

	for (i=0; i<6; i++)
	{
		setrgbpalette(i,i*r,i*g,i*b);
		setfillstyle(SOLID_FILL,i);
		bar(wt-1,0,wt+1,yy);
		bar(0,wt-1,xx,wt+1);
		bar(ht+xx-16-1,0,ht+xx-16+1,yy);
		bar(0,yy-16-1+ht,xx,yy-16+1+ht);
		ht+=3;
		wt-=3;
	}
	setcolor(1);
}
// end void heading(int r,int g,int b)

// function for graphic
void border(int x1,int y1,int x2,int y2,int color)
{
	int i,ht=0;

	setfillstyle(SOLID_FILL,color);
	bar(x1+3,y1+3,x2-3,y2-3);

	for (i=0; i<6; i++)
	{
		setcolor(i);
		line(x1-ht+5,y1+5,x1-ht+5,y2-5);
		line(x1+5,y1-ht+5,x2-5,y1-ht+5);
		line(x1+5,y2+ht-5,x2-5,y2+ht-5);
		line(x2+ht-5,y1+5,x2+ht-5,y2-5);
		arc(x1+5,y1+5,90,180,i);
		arc(x2-5,y1+5,0,90,i);
		arc(x2-5,y2-5,270,0,i);
		arc(x1+5,y2-5,180,270,i);

		ht++;
	}
}
// end void border(int x1,int y1,int x2,int y2,int color)

void frame(int ax,int ay,int bx,int by,int co1,int co2,int co3)
{
	setfillstyle(1,co3);
	bar(ax,ay,bx,by);

	setcolor(co1);
	rectangle(ax-1,ay-1,bx+1,by+1);
	rectangle(ax-2,ay-2,bx+2,by+2);
	rectangle(ax-3,ay-3,bx+3,by+3);

	setcolor(co2);
	line(bx+1,ay-1,bx+1,by+3);
	line(bx+2,ay-2,bx+2,by+3);
	line(bx+3,ay-3,bx+3,by+3);
	setcolor(co2);
	line(ax-1,by+1,bx+3,by+1);
	line(ax-2,by+2,bx+3,by+2);
	line(ax-3,by+3,bx+3,by+3);

}
// end void frame(int ax,int ay,int bx,int by,int co1,int co2,int co3)

void push_frame(int ax,int ay,int bx,int by,int co1,int co2)
{
	setcolor(co1);
	rectangle(ax-1,ay-1,bx+1,by+1);
	rectangle(ax-2,ay-2,bx+2,by+2);
	rectangle(ax-3,ay-3,bx+3,by+3);

	setcolor(co2);
	line(bx+1,ay-1,bx+1,by+3);
	line(bx+2,ay-2,bx+2,by+3);
	line(bx+3,ay-3,bx+3,by+3);
	setcolor(co2);
	line(ax-1,by+1,bx+3,by+1);
	line(ax-2,by+2,bx+3,by+2);
	line(ax-3,by+3,bx+3,by+3);

}
// end void push_frame(int ax,int ay,int bx,int by,int co1,int co2)

void frame_line(int ax,int ay,int bx,int by,int co1,int co2,int co3)
{
	setfillstyle(1,co3);
	bar(ax,ay,bx,by);

	setcolor(co1);
	rectangle(ax-1,ay-1,bx+1,by+1);

	setcolor(co2);
	line(bx+1,ay-1,bx+1,by+1);
	setcolor(co2);
	line(ax-1,by+1,bx+1,by+1);

}
// end void frame_line(int ax,int ay,int bx,int by,int co1,int co2,int co3)

void push_frame_line(int ax,int ay,int bx,int by,int co1,int co2)
{
	setcolor(co1);
	rectangle(ax-1,ay-1,bx+1,by+1);

	setcolor(co2);
	line(bx+1,ay-0,bx+1,by+1);
	setcolor(co2);
	line(ax-1,by+1,bx+1,by+1);

}
// end void push_frame_line(int ax,int ay,int bx,int by,int co1,int co2)

void shadow(int ax,int ay,char *tex)
{
	setcolor(DARKGRAY);
	outtextxy(ax+2,ay+2,tex);
	setcolor(WHITE);
	outtextxy(ax,ay,tex);
}
// end void shadow(int ax,int ay,char *tex)

void shadowy(int ax,int ay,char *tex)
{
	setcolor(DARKGRAY);
	outtextxy(ax+2,ay+2,tex);
	setcolor(YELLOW);
	outtextxy(ax,ay,tex);
}
// end void shadowy(int ax,int ay,char *tex)

// function for screen effect
void splash_text(int ax,int ay,int splash_tail,int time_d,int co1,int co2,char *text_buf)
{
	char buf[50];

	for(int i=0;text_buf[i];i++)
	{
		setcolor(co2);
		sprintf(buf,"%c",text_buf[i]);
		outtextxy(ax+i*8,ay,buf);

		if((i-splash_tail)>=0)
		{
			setcolor(co1);
			sprintf(buf,"%c",text_buf[i-splash_tail]);
			outtextxy(ax+(i-splash_tail)*8,ay,buf);
		}
		delay(animation*time_d);
	}
	for(int j=0;j<splash_tail;j++)
	{
		setcolor(co1);
		sprintf(buf,"%c",text_buf[i-splash_tail+j]);
		outtextxy(ax+(i-splash_tail+j)*8,ay,buf);
		delay(animation*time_d);
	}
}
// end void splash_text(int ax,int ay,int splash_tail,int time_d,int co1,int co2,char *text_buf)

void recog()
{
	int quit=0,key,ButtonStatus,x,y;
	unsigned int bufsize;

//	init_graphic();
	cleardevice();

	recog_screen();

	while(!quit)
	{
		show_mouse();
		while(kbhit())
		{
			key=getch();
			if (key==27)
			{
				move_mouse(xx-10-140,yy-10-15);
				delay(100);
				ButtonStatus=1;
			}
			else if (key=='c')
			{
				move_mouse(xx-10-140,yy-10-45);
				delay(100);
				ButtonStatus=1;
			}
			else if (key=='r')
			{
				move_mouse(xx-10-140,yy-10-75);
				delay(100);
				ButtonStatus=1;
			}
			else if (key=='t')
			{
				move_mouse(xx-10-140,yy-10-105);
				delay(100);
				ButtonStatus=1;
			}
			else if (key=='o')
			{
				move_mouse(xx-10-140,yy-10-135);
				delay(100);
				ButtonStatus=1;
			}
		}

		_AX=3;
		geninterrupt(0X33);
		x=_CX;
		y=_DX;

		if (key!=27&&key!='c'&&key!='r'&&key!='t'&&key!='o')
			ButtonStatus=_BX;
		else
			key=0;

		if (ButtonStatus)
		{
			hide_mouse();
			settextjustify(1,1);

			if (x>10+6&&y>80+6&&x<10+150-6&&y<80+150-6)
			{
				setcolor(BLACK);
				circle(x,y,1);
				circle(x,y,2);
				circle(x,y,3);
				circle(x,y,4);
				circle(x,y,5);
//				setfillstyle(1,BLACK);
//				floodfill(x,y,BLACK);
			}
			else
		     /*	if (x>(xx-10-150)&&y>(yy-10-145)&&x<(xx-10-10)&&y<(yy-10-130))
			{
				delay(100);
				push_frame(xx-10-150,yy-10-145,xx-10-10,yy-10-130,DARKGRAY,WHITE);
				delay(100);
				frame(xx-10-150,yy-10-145,xx-10-10,yy-10-130,WHITE,DARKGRAY,LIGHTGRAY);
				setcolor(BLACK);
				outtextxy(xx-10-150+70,yy-10-145+8,"Open File");
				delay(100);
				open_file(bufsize);
			}
			else */
			if (x>(xx-10-150)&&y>(yy-10-115)&&x<(xx-10-10)&&y<(yy-10-100))
			{
				delay(100);
				push_frame(xx-10-150,yy-10-115,xx-10-10,yy-10-100,DARKGRAY,WHITE);
				delay(100);
				frame(xx-10-150,yy-10-115,xx-10-10,yy-10-100,WHITE,DARKGRAY,LIGHTGRAY);
				setcolor(BLACK);
				outtextxy(xx-10-150+70,yy-10-115+8,"Teach ...");
				delay(100);
				scanline(&bufsize);
				teach___(bufsize);
			}
			else
			if (x>(xx-10-150)&&y>(yy-10-85)&&x<(xx-10-10)&&y<(yy-10-70))
			{
				delay(100);
				push_frame(xx-10-150,yy-10-85,xx-10-10,yy-10-70,DARKGRAY,WHITE);
				delay(100);
				frame(xx-10-150,yy-10-85,xx-10-10,yy-10-70,WHITE,DARKGRAY,LIGHTGRAY);
				setcolor(BLACK);
				outtextxy(xx-10-150+70,yy-10-85+8,"Recognize Text");
				delay(100);
				check_text();
			}
			else
			if (x>(xx-10-150)&&y>(yy-10-55)&&x<(xx-10-10)&&y<(yy-10-40))
			{
				delay(100);
				push_frame(xx-10-150,yy-10-55,xx-10-10,yy-10-40,DARKGRAY,WHITE);
				delay(100);
				frame(xx-10-150,yy-10-55,xx-10-10,yy-10-40,WHITE,DARKGRAY,LIGHTGRAY);
				setcolor(BLACK);
				outtextxy(xx-10-150+70,yy-10-55+8,"Clear Screen");
				delay(100);

				setfillstyle(SOLID_FILL,WHITE);
				bar(10,80,10+150,80+150);

//				cleardevice();
//				recog_screen();
			}
			else
			if (x>(xx-10-150)&&y>(yy-10-25)&&x<(xx-10-10)&&y<(yy-10-10))
			{
				delay(100);
				push_frame(xx-10-150,yy-10-25,xx-10-10,yy-10-10,DARKGRAY,WHITE);
				delay(100);
				frame(xx-10-150,yy-10-25,xx-10-10,yy-10-10,WHITE,DARKGRAY,LIGHTGRAY);
				setcolor(BLACK);
				outtextxy(xx-10-150+70,yy-10-25+8,"Return to MENU");
				delay(100);
				cleardevice();
				return;
			}
		}
		else
		{
			if (x>(xx-10-150)&&y>(yy-10-145)&&x<(xx-10-10)&&y<(yy-10-130))
				stat_cha='o';
			else
			if (x>(xx-10-150)&&y>(yy-10-115)&&x<(xx-10-10)&&y<(yy-10-100))
				stat_cha='t';
			else
			if (x>(xx-10-150)&&y>(yy-10-85)&&x<(xx-10-10)&&y<(yy-10-70))
				stat_cha='r';
			else
			if (x>(xx-10-150)&&y>(yy-10-55)&&x<(xx-10-10)&&y<(yy-10-40))
				stat_cha='c';
			else
			if (x>(xx-10-150)&&y>(yy-10-25)&&x<(xx-10-10)&&y<(yy-10-10))
				stat_cha='m';
			else
				stat_cha='h';

			if(stat_cha!=stat_cur)
				status_window();
		}
	}
}
// end void recog()

void status_window()
{
	settextjustify(1,1);
	setfillstyle(SOLID_FILL,BLACK);
	bar(10+10+5,330+60+5,xx-10-200-5,yy-10-10-5);
	stat_cur=stat_cha;
	switch(stat_cha)
	{
		case 'o'	:
						shadowy(10+10+410/2,330+60+5+5,"HELP : Open File");
						shadowy(10+10+410/2,330+60+20+5,"Click the Open button to open FILE");
						shadowy(10+10+410/2,330+60+35+5,"then type in your FILENAME");

						//	display open help
						break;
		case 't'	:
						shadowy(10+10+410/2,330+60+5+5,"HELP : Teach ...");
						shadowy(10+10+410/2,330+60+20+5,"Click the Teach button to TEACH");
						shadowy(10+10+410/2,330+60+35+5,"then type in your teach CHARACTER");

						//	display teach help
						break;
		case 'r'	:
						shadowy(10+10+410/2,330+60+5+5,"HELP : Recognize Text");
						shadowy(10+10+410/2,330+60+20+5,"Click the Recognize button to recognize text");
						shadowy(10+10+410/2,330+60+35+5,"then the recognized text will display at above");

						//	display recognize help
						break;
		case 'c'	:
						shadowy(10+10+410/2,330+60+5+5,"HELP : Clear");
						shadowy(10+10+410/2,330+60+20+5,"Click the clear button to CLEAR screen");
						shadowy(10+10+410/2,330+60+35+5,"then conticue to draw");

						//	display clear help
						break;
		case 'm'	:
						shadowy(10+10+410/2,330+60+5+5,"HELP : Return to MENU");
						shadowy(10+10+410/2,330+60+20+5,"Click the button to");
						shadowy(10+10+410/2,330+60+35+5,"then it will go back to MAIN MENU");

						//	display return to menu help
						break;
		default	:

						shadowy(10+10+410/2,330+60+20+5," Move the mouse to the Draw Area,");
						shadowy(10+10+410/2,330+60+35+5," then drag the mouse when you want to draw.");

						//	display status window
	}
}
// end void status_window()

void recog_screen()
{
//	int text_length;

	mainbgcolor=LIGHTGRAY;

	setbkcolor(BLACK);
	frame(6,6,xx-6,yy-6,WHITE,DARKGRAY,mainbgcolor);
	frame_line(10+1,10+1,xx-10-1,10-1+60,WHITE,DARKGRAY,mainbgcolor);
	push_frame_line(10,10,xx-10,10+60,DARKGRAY,WHITE);
	setfillstyle(SOLID_FILL,BLACK);
	bar(25,25,615,55);
	push_frame_line(25,25,615,55,DARKGRAY,WHITE);
	settextjustify(LEFT_TEXT,CENTER_TEXT);
	settextstyle(0,0,1);
	shadowy(xx/2-150/2,40,"guide:Ms Archana");
	strcpy(buffer,"Character Recognization");
//	text_length=strlen(buffer);
	splash_text(40+1,40+2,6,35,BROWN,WHITE,buffer);
	splash_text(40-1,40+0,0,8,WHITE,0,buffer);
	settextjustify(CENTER_TEXT,CENTER_TEXT);
	shadowy(xx-120,35,"    Design By    ");
	shadowy(xx-120,45,"Team joy and arindam");
	// header area

	setcolor(BLACK);
	setfillstyle(SOLID_FILL,WHITE);
	bar(10,80,10+150,80+150);
	rectangle(10-1,80-1,10+150+1,80+150+1);
	settextjustify(1,1);
	shadowy(10+75,80+150+10,"Draw Area");
	//	display draw area
/*
setcolor(BLACK);
	setfillstyle(SOLID_FILL,WHITE);
	bar(10+230,80,10+150+230,80+150);
	rectangle(10+230,80,10+150+230,80+150);
	settextjustify(1,1);
	shadowy(10+230+75,80+150+10,"Data Area");
  */		//	display data area

	setcolor(BLACK);
	setfillstyle(SOLID_FILL,WHITE);
	bar(10+470,80,10+150+470,80+150);
	rectangle(10+470,80,10+150+470,80+150);
	settextjustify(1,1);
	shadowy(10+470+75,80+150+10,"Display Teach Area");
	//	display teach area

//	frame(10,300,xx-10,yy-10,LIGHTGREEN,GREEN,LIGHTBLUE);
//	push_frame(10+3,300+3,xx-10-3,yy-10-3,GREEN,LIGHTGREEN);
	frame_line(10,300,xx-10,yy-10,WHITE,DARKGRAY,mainbgcolor);
	push_frame_line(10+2,300+2,xx-10-2,yy-10-2,DARKGRAY,WHITE);
	//	lower window

	setfillstyle(SOLID_FILL,BLACK);
	bar(20,260,xx-20,290);
	push_frame_line(20,260,xx-20,290,DARKGRAY,WHITE);

	setfillstyle(SOLID_FILL,BLACK);
	bar(10+10,300+10,xx-10-320,yy-10-90);
	push_frame_line(10+10,300+10,xx-10-320,yy-10-90,DARKGRAY,WHITE);
	//	display text area in lower window

	bar(10+10,330+60,xx-10-200,yy-10-10);
	push_frame_line(10+10,330+60,xx-10-200,yy-10-10,DARKGRAY,WHITE);
	settextjustify(1,1);
	shadowy(10+10+410/2,330+60+5+5," Thanks for using this software ");
	shadowy(10+10+410/2,330+60+20+5," Move the mouse to the Draw Area,");
	shadowy(10+10+410/2,330+60+35+5," then drag the mouse when you want to draw.");

	//	display status window

  //	frame(xx-10-150,yy-10-145,xx-10-10,yy-10-130,WHITE,DARKGRAY,LIGHTGRAY);
    //	setcolor(BLACK);
      //	outtextxy(xx-10-150+70,yy-10-145+8,"Open File");
	//	open file button

	frame(xx-10-150,yy-10-115,xx-10-10,yy-10-100,WHITE,DARKGRAY,LIGHTGRAY);
	setcolor(BLACK);
	outtextxy(xx-10-150+70,yy-10-115+8,"Teach ...");
	//	Teach ... button

	frame(xx-10-150,yy-10-85,xx-10-10,yy-10-70,WHITE,DARKGRAY,LIGHTGRAY);
	setcolor(BLACK);
	outtextxy(xx-10-150+70,yy-10-85+8,"Recognize Text");
	//	recognize text button

	frame(xx-10-150,yy-10-55,xx-10-10,yy-10-40,WHITE,DARKGRAY,LIGHTGRAY);
	setcolor(BLACK);
	outtextxy(xx-10-150+70,yy-10-55+8,"Clear Screen");
	//	clear screen button

	frame(xx-10-150,yy-10-25,xx-10-10,yy-10-10,WHITE,DARKGRAY,LIGHTGRAY);
	setcolor(BLACK);
	outtextxy(xx-10-150+70,yy-10-25+8,"Return to MENU");
	//	return to menu button

	mainbgcolor=BLACK;
}
// end void recog_screen()

void scanline(unsigned int *bufsize)
{
	int s_x,s_y,l_x,l_y;
	int i,j,x1_;
	int x1,x2,y1,y2;
	int off_s_x,off_s_y;

	mnx=MAX;
	mny=MAX;
	mxx=0;
	mxy=0;

	*bufsize=sizeof(image_save);

/*	for(i=0;i<MAX;i++)
	for(j=0;j<MAX;j++)
		image[i][j]=(unsigned int)(malloc(*bufsize));
	allocmem(sizeof(image), &(unsigned int)image[0][0]);
*/

	for(int jj=0;jj<MAX;jj++)
	for(int ii=0;ii<MAX;ii++)
	{
		if(getpixel(ii+offsetx,jj+offsety)==BLACK)
		{
			if (ii<mnx)
				mnx=ii;
			if (jj<mny)
				mny=jj;
			if (ii>mxx)
				mxx=ii;
			if (jj>mny)
				mxy=jj;
		}
	}

	x1=mnx;
	x2=mxx;
	y1=mny;
	y2=mxy;

	l_x=x2-x1;
	l_y=y2-y1;

	l_x+=6;
	l_y+=6;

	s_x=l_x/scale;
	s_y=l_y/scale;
	off_s_x=s_x;
	off_s_y=s_y;

	/* read the image */

	for (int b=0;b<scale;b++)
	{
		x1_=0;
		for (int a=0;a<scale;a++)
		{
			for (int j=0;j<s_y;j++)
			for (int i=0;i<s_x;i++)
			{
				if (a==scale-1)
					s_x=off_s_x+(l_x%scale);
				else
					s_x=off_s_x;

				if (b==scale-1)
					s_y=off_s_y+(l_y%scale);
				else
					s_y=off_s_y;

/*	gotoxy(1,1);
	cout<<"\n\n";
	cout<<"s_x="<<s_x<<"\t"<<"s_y="<<s_y<<"\t";
	cout<<"l_x="<<l_x<<"\t"<<"l_y="<<l_y<<"\t"<<"scale="<<scale<<"\t";
	cout<<"x1="<<x1<<"\t"<<"x2="<<x2<<"\t"<<"y1="<<y1<<"\t"<<"y2="<<y2<<"\t";*/

				image_save[a][b]=getpixel(i+x1+x1_+offsetx,j+y1+offsety);
//				putpixel(i+x1+x1_+offsetx,j+y1+offsety,RED);

				if ((image_save[a][b])==BLACK)
				{
					i=s_x;
					j=s_y;
				}
			}
/*			if ((l_x%scale)&&(i==s_x-1))
				x1_+=l_x%scale;
			else*/
				x1_+=s_x;
		}
/*		if ((l_y%scale)&&(j==s_y-1))
			y1+=l_y%scale;
		else*/
			y1+=s_y;
	}

	/* display the image */

	for (int m=0;m<scale;m++)
	for (int n=0;n<scale;n++)
	{
		if ((image_save[n][m])==BLACK)
		{
			setcolor(BLACK);
			circle(n*MAX/scale+dis_offx+1+3+4,m*MAX/scale+dis_offy+1+3+4,4);
//			putpixel(n+dis_offx+10,m+dis_offy+10,BLACK);
		}
		if ((image_save[n][m])==WHITE)
		{
			setcolor(WHITE);
			circle(n*MAX/scale+dis_offx+1+3+4,m*MAX/scale+dis_offy+1+3+4,4);
//			putpixel(n+dis_offx+10,m+dis_offy+10,LIGHTBLUE);
		}

		if(image_save[n][m]==BLACK)
			image_save[n][m]=1+'0';
		else
		if(image_save[n][m]==WHITE)
			image_save[n][m]=0+'0';
	}
}
// end void scanline(unsigned int *bufsize)

void check_text()
{
	int handle,per_match;
	char data[20],*FileName,*ext,sample[3],cor_text[3];
	int m,n;
	unsigned int bufsize;
	char backup_num='\0',rec_num='\0';
	char rec_sam[3];
	int per_max,no_file,total_file;
//	char path[2];

	setfillstyle(SOLID_FILL,BLACK);
	bar(30-5,265-2,200+100,265+8);
	bar(30-5,278-2,30+300,278+8);
	scanline(&bufsize);
	FileName="data";
	ext=".rec";
	backup_num='0';
//	path[0]='\\';
//	path[1]='\0';
	cor_text[0]='0';
	cor_text[1]='\0';
	sample[0]='0';
	sample[1]='\0';
	per_max=0;
	total_file=0;

	for (m=0;m<scale;m++)
	for (n=0;n<scale;n++)
	{
		if(image_save[n][m]=='1')
			image_save[n][m]=BLACK;
		else
		if(image_save[n][m]=='0')
			image_save[n][m]=WHITE;
	}

	do
	{
		per_match=0;
		for(int i=0;i<20;i++)
			data[i]='\0';
		if(backup_num!=cor_text[0])
		{
			backup_num=cor_text[0];
			sample[0]='0';
			sample[1]='\0';
		}
//		strcpy(data,BGIpath);
//		strcat(data,path);
//		strcat(data,cor_text);
		strcpy(data,cor_text);
		strcat(data,FileName);
		strcat(data,sample);
		strcat(data,ext);

//		gotoxy(25,18);
//		cout<<"Opening ... : "<<data<<" file \t";
//		getch();

		if ((handle=open(data,O_RDWR|O_TEXT,S_IWRITE|S_IREAD))==-1)
		{
//			printf("Error Opening File\n");
			no_file=1;//return;
		}
		else if ((read(handle,image_data,bufsize)) == -1)
		{
			outtextxy(30,278,"Read Failed. ");
//			printf("Read Failed.\n");
			no_file=1;//return;
		}
		else
		{
			no_file=0;
			total_file++;
		}
		close(handle);

		/* display the image */

		if(!no_file)
		for (m=0;m<scale;m++)
		for (n=0;n<scale;n++)
		{
			if(image_data[n][m]=='1')
				image_data[n][m]=BLACK;
			else
			if(image_data[n][m]=='0')
				image_data[n][m]=WHITE;

		//	setcolor(image_data[n][m]);
		   //	circle(n*MAX/scale+dis_datax+1+3+4,m*MAX/scale+dis_datay+1+3+4,4);

			if(image_save[n][m]==image_data[n][m])
			{
				per_match++;
			}
		}

//		gotoxy(1,cor_text_num+2);
//		cout<<"per macth = "<<per_match<<"%";

		if(per_max<per_match)
		{
			per_max=per_match;
			rec_num=cor_text[0];
			strcpy(rec_sam,sample);
		}

		if( (((cor_text[0]<='z')&&(cor_text[0]>='a'))
				||
			  ((cor_text[0]<='9')&&(cor_text[0]>='0')))
				&&
			  (atoi(sample)<=99&&!no_file) )
		{
			int num;
			num=atoi(sample)+1;
			sample[0]='\0';
			sample[1]='\0';
			itoa(num,sample,10);
		}
		else
		if(cor_text[0]=='9')
		{
			cor_text[0]='a';
		}
		else
		if((cor_text[0]<'9'||cor_text[0]>='0')&&no_file)
		{
			++cor_text[0];
		}
		else
		if((cor_text[0]<'z'||cor_text[0]>='a')&&no_file)
		{
			++cor_text[0];
		}

	}while( ((cor_text[0]<='z')&&(cor_text[0]>='a'))
				||
			  ((cor_text[0]<='9')&&(cor_text[0]>='0'))
				||
			  (!no_file) );

	setfillstyle(SOLID_FILL,BLACK);
	bar(10+10+5,300+10+5,xx-10-320-5,yy-10-90-5);
	settextjustify(0,2);
//	gotoxy(5,21);
	sprintf(buffer,"Percent Macth MAX = %d\%  ",per_max);
	shadow(30,320,buffer);

	if(per_max<80)
       {
	sprintf(buffer,"not sufficient match");
	shadow(30,340,buffer);
	sprintf(buffer,"please teach the system");
	shadow(30,350,buffer);
	sprintf(buffer,"the new letter");
	shadow(30,360,buffer);
	   }
//	gotoxy(5,22);
else
       {
	sprintf(buffer,"Recognized letter = %c ",rec_num);
	shadow(30,340,buffer);
	  }
//	gotoxy(5,23);
    /*	sprintf(buffer,"Total Data file   = %d files ",total_file);
	shadow(30,360,buffer);
      */
	cor_text[0]=rec_num;
	cor_text[1]='\0';
	strcpy(sample,rec_sam);

		for(int i=0;i<10;i++)
			data[i]='\0';
		strcpy(data,cor_text);
		strcat(data,FileName);
		strcat(data,sample);
		strcat(data,ext);

		if ((handle=open(data,O_RDWR|O_TEXT,S_IWRITE|S_IREAD))==-1)
		{
			sprintf(buffer,"Error: %s ",strerror(errno));
			buffer[strlen(buffer)-2]='\0';
			outtextxy(30,278,buffer);
//			printf("Error Opening File\n");
//			return;
		}

		if ((read(handle,image_data,bufsize)) == -1)
		{
			sprintf(buffer,"Error: %s ",strerror(errno));
			buffer[strlen(buffer)-2]='\0';
			outtextxy(30,278,buffer);
//			printf("Read Failed.\n");
//			return;
		}
		close(handle);

		for (m=0;m<scale;m++)
		for (n=0;n<scale;n++)
		{
			if(image_data[n][m]=='1')
				image_data[n][m]=BLACK;
			else
			if(image_data[n][m]=='0')
				image_data[n][m]=WHITE;

			setcolor(image_data[n][m]);
		  //	circle(n*MAX/scale+dis_datax+1+3+4,m*MAX/scale+dis_datay+1+3+4,4);
		}
}
// end void check_text()

void open_file(unsigned int bufsize)
{
	char FileName[12];//,*path;
	int handle;

	setfillstyle(SOLID_FILL,BLACK);
	bar(30-5,265-2,200+100,265+8);
	bar(30-5,278-2,30+300,278+8);
	setcolor(WHITE);
	settextjustify(0,2);
	outtextxy(30,265,"Enter File Name : ");
	gotoxy(1,1);
	outtextxy(200,265,"_");
//	gets(FileName);
	for(int j=0;j<12;j++)
		FileName[j]='\0';

	int i=0;
	while(FileName[i-1]!=13&&i<9)
	{
		if(FileName[i-1]=='\0')
		{
			outtextxy(30,278,"BAD input character !!! ");
			return;
		}
		FileName[i++]=getche();
		if((FileName[i-1]=='\b')&&(i==1))
			FileName[--i]='\0';
		else
		if(FileName[i-1]=='\b')
		{
			FileName[i-1]='\0';
			FileName[i-2]='\0';
			i-=2;
		}
		bar(200-5,265-2,200+100,265+8);
		outtextxy(200,265,FileName);
		outtextxy(200+textwidth(FileName),265,"_");
	}
	FileName[i-1]='\0';
	bar(200-5,265-2,200+100,265+8);
	outtextxy(200,265,FileName);
//	puts(BGIpath);
//	strcpy(path,BGIpath);
//	strcat(path,FileName);
//	strcat(path,".rec");
//	strcpy(FileName,path);
	strcat(FileName,".rec");
//	settextjustify(1,1);

	if ((handle=open(FileName,O_RDWR|O_TEXT,S_IWRITE|S_IREAD))==-1)
	{
		sprintf(buffer,"Error: %s ",strerror(errno));
		buffer[strlen(buffer)-2]='\0';
		outtextxy(30,278,buffer);
//		sprintf(buffer,"Error Opening File. ");
//		outtextxy(30,278,buffer);
		return;
	}

	if ((read(handle,image_save,bufsize)) == -1)
	{
		outtextxy(30,278,"Read Failed. ");
//		printf("Read Failed.\n");
		return;
	}
	close(handle);

	/* display the image */

	for (int m=0;m<scale;m++)
	for (int n=0;n<scale;n++)
	{
		if(image_save[n][m]=='1')
			image_save[n][m]=BLACK;
		else
		if(image_save[n][m]=='0')
			image_save[n][m]=WHITE;

		setcolor(image_save[n][m]);
		circle(n*MAX/scale+dis_offx+1+3+4,m*MAX/scale+dis_offy+1+3+4,4);
//		putpixel(n+dis_offx+1,m+dis_offy+1,image_save[n][m]);
	}
}
// end void open_file(unsigned int bufsize)

void teach___(unsigned int bufsize)
{
	char data[20];
	int handle;
	char sample[3],FileName[3];//,*path='\0';

	sample[0]='0';
	sample[1]='\0';
	FileName[0]='\0';
	FileName[1]='\0';
	setfillstyle(SOLID_FILL,BLACK);
	bar(30-5,265-2,200+100,265+8);
	bar(30-5,278-2,30+300,278+8);
	setcolor(WHITE);
	settextjustify(0,2);
	outtextxy(30,265,"Enter TEACH letter: ");
	gotoxy(1,1);
	FileName[0]=getche();
	outtextxy(200,265,FileName);

	if(!FileName[0]||FileName[0]=='\r'||FileName[0]==27)
	{
		outtextxy(30,278,"Please key in LETTER to teach ...");
//		cout<<" Please key in NUMBER to teach ...";
		return;
	}
	for(int i=0;i<20;i++)
		data[i]='\0';
//	strcpy(path,BGIpath+'\\');
//	strcat(path,FileName);
//	strcat(path,".rec");
//	strcpy(FileName,path);
	strcpy(data,FileName);
	strcat(data,"data");
	strcat(data,sample);
	strcat(data,".rec");
	while(file_exists(data))
	{
		if(atoi(sample)>=99)
			return;
		int num;
		num=atoi(sample)+1;
		sample[0]='\0';
		sample[1]='\0';
		itoa(num,sample,10);
		strcpy(data,FileName);
		strcat(data,"data");
		strcat(data,sample);
		strcat(data,".rec");
	}

	if (!file_exists(data))
	{
		if ((handle=open(data,O_CREAT|O_RDWR|O_BINARY,S_IWRITE|S_IREAD))==-1)
		{
			sprintf(buffer,"Error: %s ",strerror(errno));
			buffer[strlen(buffer)-2]='\0';
			outtextxy(30,278,buffer);
			return;
		}
		write(handle,image_save,bufsize);
		close(handle);
	}
}
// end void teach___(unsigned int bufsize)

int file_exists(char *filename)
{
  return (access(filename, 0) == 0);
}
// end int file_exists(char *filename)

void about()
{
	int quit=0,ButtonStatus;

	about_screen();
	show_mouse();

	while(!quit)
	{
		while(kbhit())
		{
			hide_mouse();
			cleardevice();
			return;
		}

		_AX=3;
		geninterrupt(0X33);
		ButtonStatus=_BX;

		if (ButtonStatus)
		{
			hide_mouse();
			cleardevice();
			return;
		}
	}
}
// end void about()

// function for sub menu screen
void about_screen()
{
	int text_length;
	int text_line;

	// display background
	cleardevice();
	heading(screen_r,screen_g,screen_b);//5,10,12);
	setbkcolor(BLACK);

	// display title
	border(xx/2-200,55-15,xx/2+200,55+15,BLACK);
	settextstyle(0,HORIZ_DIR,1);
	setcolor(WHITE);
	settextstyle(0,HORIZ_DIR,1);
	settextjustify(CENTER_TEXT,CENTER_TEXT);
	text_length=textwidth(menu1);
	text_length-=8;
	splash_text(xx/2-text_length/2+1,55+2,6,35,BROWN,WHITE,menu1);
	splash_text(xx/2-text_length/2-1,55-0,0,8,WHITE,0,menu1);
	settextjustify(LEFT_TEXT,RIGHT_TEXT);
//	delay(animation*1000);

	// display text window
//	frame(30,100,xx-30,100+60,LIGHTBLUE,BLUE,BLACK);
//	push_frame(30+3,100+3,xx-30-3,100+60-3,BLUE,LIGHTBLUE);
//	shadowy(30+3+5,100+3+5,"This program could translate U16 file into DXF file. ");

	// display text window
	frame(30,100,xx-30,yy-40,LIGHTGRAY,DARKGRAY,BLACK);
	push_frame(30+3,100+3,xx-30-3,yy-40-3,DARKGRAY,LIGHTGRAY);

	text_line=0;
	settextjustify(CENTER_TEXT,RIGHT_TEXT);
	shadowy(xx/2,100+3+5+text_line++*15,"DR M.G.R EDUCATIONAL AND RESEARCH INSTITUTE");

	shadowy(xx/2,100+3+5+text_line++*15,"B.Tech, Computer Science and Engineering");

	settextjustify(CENTER_TEXT,RIGHT_TEXT);
	shadowy(xx/2,100+3+1+text_line++*15,"______________________________________________________________________");

	shadowy(xx/2,100+3+5+text_line++*15,"Major Project");
	shadowy(xx/2,100+3+5+text_line++*15,"- Character Recognition -");

	settextjustify(CENTER_TEXT,RIGHT_TEXT);
	shadowy(xx/2,100+3+1+text_line++*15,"______________________________________________________________________");

	settextjustify(LEFT_TEXT,RIGHT_TEXT);
	shadowy(50+3+5,100+3+5+text_line++*15,"This program is built for recognization of inputed data in the form");
	shadowy(50+3+5,100+3+5+text_line++*15,"of handwritten text from user, into recognized character and to ");
	shadowy(50+3+5,100+3+5+text_line++*15,"improve recognization by teaching new character into the database");
	shadowy(50+3+5,100+3+5+text_line++*15,"on recognization.");

	settextjustify(CENTER_TEXT,RIGHT_TEXT);
	shadowy(xx/2,100+3+1+text_line++*15,"______________________________________________________________________");

	settextjustify(LEFT_TEXT,RIGHT_TEXT);
	shadowy(100+3+5,100+3+5+text_line++*15,"");
	shadowy(100+3+5,100+3+5+text_line++*15,"PROJECT BY             :JOY MALAKAR(E05BCS1068) ,");
	shadowy(100+3+5,100+3+5+text_line++*15,"                        ARINDAM CHANDA(EO5BCS1025    ");
	shadowy(100+3+5,100+3+5+text_line++*15,"                            ");
	shadowy(100+3+5,100+3+5+text_line++*15,"PROJECT GUIDE           :MS ARCHANA ");
	shadowy(100+3+5,100+3+5+text_line++*15,"                            ");

	settextjustify(RIGHT_TEXT,RIGHT_TEXT);
	shadow(xx-30,yy-30,"Press any key or click to quit this screen...");
	settextjustify(LEFT_TEXT,RIGHT_TEXT);
}
// end void about_screen()

// function for monitoring coordinate
void coord(int x,int y)
{
	setcolor(WHITE);
	setfillstyle(SOLID_FILL,BLACK);
	settextjustify(LEFT_TEXT,RIGHT_TEXT);

	if((cur_x!=x)||(cur_y!=y))
	{
		cur_x=x;
		cur_y=y;
		sprintf(coord_buf," x = %d ",x);
		static
		int coord_length=textwidth(coord_buf);

		bar(xx-20-coord_length,20,xx-20,20+20);
		outtextxy(xx-20-coord_length,20,coord_buf);
		sprintf(coord_buf," y = %d ",y);
		outtextxy(xx-20-coord_length,20+10,coord_buf);
	}
}
// end void coord(int x,int y)

// function for prompt for exit
int yes_no()
{
	char quit=0;
	char cur_op,option='\0';
	char key;
	int status,button_status;
	int x,y;

	// display message box
	frame(640/2-150,480/2-30,640/2+150,480/2+30,LIGHTGREEN,GREEN,LIGHTBLUE);
	push_frame(640/2+3-150,480/2+3-30,640/2-3+150,480/2-3+30,GREEN,LIGHTGREEN);
	// display yes button
	frame(640/2-100,480/2+0,640/2-10,480/2+14,WHITE,DARKGRAY,LIGHTGRAY);
	// display no button
	frame(640/2+10,480/2+0,640/2+100,480/2+14,WHITE,DARKGRAY,LIGHTGRAY);
	setcolor(BLACK);
	settextjustify(CENTER_TEXT,CENTER_TEXT);
	settextstyle(DEFAULT_FONT,HORIZ_DIR,1);
	outtextxy(640/2,480/2-15,"Are You Sure ?");
	outtextxy(640/2-55,480/2+7,"Yes");
	outtextxy(640/2+55,480/2+7,"No");
	outtextxy(640/2-55,480/2+7+1,"_  ");
	outtextxy(640/2+55,480/2+7+1,"_ ");

	show_mouse();

	while(!quit)	//	while start
	{
		while(kbhit())
		{
			key=getch();

			if((key==LEFTKEY))
			{
				status='y';
			}
			else
			if((key==RIGHTKEY))
			{
				status='n';
			}
			else
			if(key=='\r')
			{
				button_status=1;
			}
			else
			if(key=='y')
			{
				status='y';
				button_status=1;
			}
			else
			if(key=='n')
			{
				status='n';
				button_status=1;
			}
			else
			if(key==27)
			{
				status='n';
				button_status=1;
			}

			switch(status)
			{
				case 'y' :	move_mouse(640/2-55,480/2+7);
								option=0;
								break;
				case 'n' :	move_mouse(640/2+55,480/2+7);
								option=0;
								break;
			}
		}

		_AX=3;
		geninterrupt(0X33);
		x=_CX;
		y=_DX;
		if ((key!='\r')&&(key!=27)&&(key!='y')&&(key!='n'))
			button_status=_BX;
		else
			key=0;

		if((y>480/2+0)&&(y<480/2+14))
		{
			if((x>640/2-100)&&(x<640/2-10))
			{
				if(option!='y')
					option='y';
			}
			else
			if((x>640/2+10)&&(x<640/2+100))
			{
				if(option!='n')
					option='n';
			}
			else
			{
				if(option!='\0')
					option=0;
			}
		}
		else
		{
			if(option!='\0')
				option=0;
		}

		if(button_status==1)				// if button status start
		{
			hide_mouse();
			switch(option)
			{
				case 'y'	:	// exit
								return 1;
				case 'n'	:	// remain
								quit=1;
								break;
				default	:  // waiting
								show_mouse();
								break;
			}
		}										// if button status end
		else
		{
			if(cur_op!=option)			// if current option changed
			{
				cur_op=option;
				setcolor(WHITE);
				hide_mouse();
				switch(option)
				{
					case 'y'	:	// highlight yes
									outtextxy(640/2-55,480/2+7,"Yes");
									setcolor(BLACK);
									outtextxy(640/2+55,480/2+7,"No");
									break;
					case 'n' :	// highlight no
									outtextxy(640/2+55,480/2+7,"No");
									setcolor(BLACK);
									outtextxy(640/2-55,480/2+7,"Yes");
									break;
					default	:	// clear highlight
									setcolor(BLACK);
									outtextxy(640/2-55,480/2+7,"Yes");
									outtextxy(640/2+55,480/2+7,"No");
				}
				show_mouse();
			}									// if current option changed
		}
	}              //	while end
	settextjustify(LEFT_TEXT,RIGHT_TEXT);
	return 0;
}
// end int yes_no()


