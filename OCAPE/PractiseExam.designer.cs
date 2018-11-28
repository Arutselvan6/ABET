namespace WindowsFormsApplication1
{
    partial class PractiseExam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTimeRemaining = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblIndex = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelAnschk = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.lblExplanationChk6 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.chk5 = new System.Windows.Forms.CheckBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.chk4 = new System.Windows.Forms.CheckBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.chk3 = new System.Windows.Forms.CheckBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.chk2 = new System.Windows.Forms.CheckBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.panelAnsRdb = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.lblExplanationRdb6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rdb5 = new System.Windows.Forms.RadioButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.rdb4 = new System.Windows.Forms.RadioButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rdb3 = new System.Windows.Forms.RadioButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.rdb2 = new System.Windows.Forms.RadioButton();
            this.panel9 = new System.Windows.Forms.Panel();
            this.rdb1 = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.pexamTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelAnschk.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panelAnsRdb.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblTimeRemaining);
            this.panel1.Controls.Add(this.lblTimer);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblCount);
            this.panel1.Controls.Add(this.lblIndex);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1190, 79);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1015, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Show Answer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTimeRemaining
            // 
            this.lblTimeRemaining.AutoSize = true;
            this.lblTimeRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeRemaining.Location = new System.Drawing.Point(714, 25);
            this.lblTimeRemaining.Name = "lblTimeRemaining";
            this.lblTimeRemaining.Size = new System.Drawing.Size(139, 18);
            this.lblTimeRemaining.TabIndex = 26;
            this.lblTimeRemaining.Text = "TIme Remaining :";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(871, 23);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(86, 24);
            this.lblTimer.TabIndex = 25;
            this.lblTimer.Text = "lblTimer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(477, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Question :";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(581, 35);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(47, 15);
            this.lblCount.TabIndex = 24;
            this.lblCount.Text = "label3";
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndex.Location = new System.Drawing.Point(560, 35);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(47, 15);
            this.lblIndex.TabIndex = 23;
            this.lblIndex.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.pra10;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 75);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnPrevious);
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.btnEnd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 555);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1190, 68);
            this.panel2.TabIndex = 0;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Back;
            this.btnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPrevious.Location = new System.Drawing.Point(263, 7);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(96, 53);
            this.btnPrevious.TabIndex = 16;
            this.btnPrevious.Text = "&Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Forward;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnNext.Location = new System.Drawing.Point(832, 7);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(96, 53);
            this.btnNext.TabIndex = 17;
            this.btnNext.Tag = "Next Question";
            this.btnNext.Text = "&Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Box_Red;
            this.btnEnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnEnd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnd.Location = new System.Drawing.Point(552, 7);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(96, 53);
            this.btnEnd.TabIndex = 18;
            this.btnEnd.Text = "&End";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.panelAnschk);
            this.panel3.Controls.Add(this.panelAnsRdb);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 79);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(1190, 476);
            this.panel3.TabIndex = 0;
            // 
            // panelAnschk
            // 
            this.panelAnschk.AutoSize = true;
            this.panelAnschk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelAnschk.Controls.Add(this.panel16);
            this.panelAnschk.Controls.Add(this.panel12);
            this.panelAnschk.Controls.Add(this.panel10);
            this.panelAnschk.Controls.Add(this.panel13);
            this.panelAnschk.Controls.Add(this.panel11);
            this.panelAnschk.Controls.Add(this.panel14);
            this.panelAnschk.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAnschk.Location = new System.Drawing.Point(10, 210);
            this.panelAnschk.Name = "panelAnschk";
            this.panelAnschk.Size = new System.Drawing.Size(1166, 162);
            this.panelAnschk.TabIndex = 26;
            // 
            // panel16
            // 
            this.panel16.AutoSize = true;
            this.panel16.BackColor = System.Drawing.SystemColors.Control;
            this.panel16.Controls.Add(this.lblExplanationChk6);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel16.Location = new System.Drawing.Point(0, 130);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(1166, 32);
            this.panel16.TabIndex = 6;
            // 
            // lblExplanationChk6
            // 
            this.lblExplanationChk6.AutoSize = true;
            this.lblExplanationChk6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplanationChk6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblExplanationChk6.Location = new System.Drawing.Point(124, 16);
            this.lblExplanationChk6.Name = "lblExplanationChk6";
            this.lblExplanationChk6.Size = new System.Drawing.Size(51, 16);
            this.lblExplanationChk6.TabIndex = 0;
            this.lblExplanationChk6.Text = "label2";
            // 
            // panel12
            // 
            this.panel12.AutoSize = true;
            this.panel12.BackColor = System.Drawing.SystemColors.Control;
            this.panel12.Controls.Add(this.chk5);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 104);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1166, 26);
            this.panel12.TabIndex = 0;
            // 
            // chk5
            // 
            this.chk5.AutoSize = true;
            this.chk5.Location = new System.Drawing.Point(127, 6);
            this.chk5.Name = "chk5";
            this.chk5.Size = new System.Drawing.Size(80, 17);
            this.chk5.TabIndex = 4;
            this.chk5.Text = "checkBox5";
            this.chk5.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            this.panel10.AutoSize = true;
            this.panel10.BackColor = System.Drawing.SystemColors.Control;
            this.panel10.Controls.Add(this.chk4);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 78);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1166, 26);
            this.panel10.TabIndex = 0;
            // 
            // chk4
            // 
            this.chk4.AutoSize = true;
            this.chk4.Location = new System.Drawing.Point(127, 6);
            this.chk4.Name = "chk4";
            this.chk4.Size = new System.Drawing.Size(80, 17);
            this.chk4.TabIndex = 3;
            this.chk4.Text = "checkBox4";
            this.chk4.UseVisualStyleBackColor = true;
            // 
            // panel13
            // 
            this.panel13.AutoSize = true;
            this.panel13.BackColor = System.Drawing.SystemColors.Control;
            this.panel13.Controls.Add(this.chk3);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 52);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1166, 26);
            this.panel13.TabIndex = 0;
            // 
            // chk3
            // 
            this.chk3.AutoSize = true;
            this.chk3.Location = new System.Drawing.Point(127, 6);
            this.chk3.Name = "chk3";
            this.chk3.Size = new System.Drawing.Size(80, 17);
            this.chk3.TabIndex = 2;
            this.chk3.Text = "checkBox3";
            this.chk3.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            this.panel11.AutoSize = true;
            this.panel11.BackColor = System.Drawing.SystemColors.Control;
            this.panel11.Controls.Add(this.chk2);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 26);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1166, 26);
            this.panel11.TabIndex = 0;
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.Location = new System.Drawing.Point(127, 6);
            this.chk2.Name = "chk2";
            this.chk2.Size = new System.Drawing.Size(80, 17);
            this.chk2.TabIndex = 1;
            this.chk2.Text = "checkBox2";
            this.chk2.UseVisualStyleBackColor = true;
            // 
            // panel14
            // 
            this.panel14.AutoSize = true;
            this.panel14.BackColor = System.Drawing.SystemColors.Control;
            this.panel14.Controls.Add(this.chk1);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(1166, 26);
            this.panel14.TabIndex = 5;
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Location = new System.Drawing.Point(127, 6);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(80, 17);
            this.chk1.TabIndex = 0;
            this.chk1.Text = "checkBox1";
            this.chk1.UseVisualStyleBackColor = true;
            // 
            // panelAnsRdb
            // 
            this.panelAnsRdb.AutoSize = true;
            this.panelAnsRdb.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelAnsRdb.Controls.Add(this.panel15);
            this.panelAnsRdb.Controls.Add(this.panel5);
            this.panelAnsRdb.Controls.Add(this.panel7);
            this.panelAnsRdb.Controls.Add(this.panel6);
            this.panelAnsRdb.Controls.Add(this.panel8);
            this.panelAnsRdb.Controls.Add(this.panel9);
            this.panelAnsRdb.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAnsRdb.Location = new System.Drawing.Point(10, 49);
            this.panelAnsRdb.Name = "panelAnsRdb";
            this.panelAnsRdb.Size = new System.Drawing.Size(1166, 161);
            this.panelAnsRdb.TabIndex = 22;
            // 
            // panel15
            // 
            this.panel15.AutoSize = true;
            this.panel15.BackColor = System.Drawing.SystemColors.Control;
            this.panel15.Controls.Add(this.lblExplanationRdb6);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(0, 133);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(1166, 28);
            this.panel15.TabIndex = 15;
            // 
            // lblExplanationRdb6
            // 
            this.lblExplanationRdb6.AutoSize = true;
            this.lblExplanationRdb6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplanationRdb6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblExplanationRdb6.Location = new System.Drawing.Point(124, 12);
            this.lblExplanationRdb6.Name = "lblExplanationRdb6";
            this.lblExplanationRdb6.Size = new System.Drawing.Size(51, 16);
            this.lblExplanationRdb6.TabIndex = 0;
            this.lblExplanationRdb6.Text = "label1";
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.rdb5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 107);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1166, 26);
            this.panel5.TabIndex = 14;
            // 
            // rdb5
            // 
            this.rdb5.AutoSize = true;
            this.rdb5.Location = new System.Drawing.Point(127, 6);
            this.rdb5.Name = "rdb5";
            this.rdb5.Size = new System.Drawing.Size(90, 17);
            this.rdb5.TabIndex = 0;
            this.rdb5.Text = "RadioButton5";
            this.rdb5.UseVisualStyleBackColor = true;
            this.rdb5.CheckedChanged += new System.EventHandler(this.rdb5_CheckedChanged);
            // 
            // panel7
            // 
            this.panel7.AutoSize = true;
            this.panel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel7.BackColor = System.Drawing.SystemColors.Control;
            this.panel7.Controls.Add(this.rdb4);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 84);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1166, 23);
            this.panel7.TabIndex = 0;
            // 
            // rdb4
            // 
            this.rdb4.AutoSize = true;
            this.rdb4.Location = new System.Drawing.Point(127, 3);
            this.rdb4.Name = "rdb4";
            this.rdb4.Size = new System.Drawing.Size(90, 17);
            this.rdb4.TabIndex = 12;
            this.rdb4.Text = "RadioButton4";
            this.rdb4.UseVisualStyleBackColor = true;
            this.rdb4.CheckedChanged += new System.EventHandler(this.rdb4_CheckedChanged);
            // 
            // panel6
            // 
            this.panel6.AutoSize = true;
            this.panel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.Controls.Add(this.rdb3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 61);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1166, 23);
            this.panel6.TabIndex = 0;
            // 
            // rdb3
            // 
            this.rdb3.AutoSize = true;
            this.rdb3.Location = new System.Drawing.Point(127, 3);
            this.rdb3.Name = "rdb3";
            this.rdb3.Size = new System.Drawing.Size(90, 17);
            this.rdb3.TabIndex = 11;
            this.rdb3.Text = "RadioButton3";
            this.rdb3.UseVisualStyleBackColor = true;
            this.rdb3.CheckedChanged += new System.EventHandler(this.rdb3_CheckedChanged);
            // 
            // panel8
            // 
            this.panel8.AutoSize = true;
            this.panel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel8.BackColor = System.Drawing.SystemColors.Control;
            this.panel8.Controls.Add(this.rdb2);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 33);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1166, 28);
            this.panel8.TabIndex = 0;
            // 
            // rdb2
            // 
            this.rdb2.AutoSize = true;
            this.rdb2.Location = new System.Drawing.Point(127, 8);
            this.rdb2.Name = "rdb2";
            this.rdb2.Size = new System.Drawing.Size(90, 17);
            this.rdb2.TabIndex = 10;
            this.rdb2.Text = "RadioButton2";
            this.rdb2.UseVisualStyleBackColor = true;
            this.rdb2.CheckedChanged += new System.EventHandler(this.rdb2_CheckedChanged);
            // 
            // panel9
            // 
            this.panel9.AutoSize = true;
            this.panel9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel9.BackColor = System.Drawing.SystemColors.Control;
            this.panel9.Controls.Add(this.rdb1);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1166, 33);
            this.panel9.TabIndex = 13;
            // 
            // rdb1
            // 
            this.rdb1.AutoSize = true;
            this.rdb1.Location = new System.Drawing.Point(127, 13);
            this.rdb1.Name = "rdb1";
            this.rdb1.Size = new System.Drawing.Size(90, 17);
            this.rdb1.TabIndex = 9;
            this.rdb1.Text = "RadioButton1";
            this.rdb1.UseVisualStyleBackColor = true;
            this.rdb1.CheckedChanged += new System.EventHandler(this.rdb1_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.lblQuestion);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(10, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1166, 39);
            this.panel4.TabIndex = 21;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(53, 23);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(86, 16);
            this.lblQuestion.TabIndex = 8;
            this.lblQuestion.Text = "lblQuestion";
            // 
            // pexamTimer
            // 
            this.pexamTimer.Interval = 1000;
            this.pexamTimer.Tick += new System.EventHandler(this.pexamTimer_Tick);
            // 
            // PractiseExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 623);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PractiseExam";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PractiseExam_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelAnschk.ResumeLayout(false);
            this.panelAnschk.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panelAnsRdb.ResumeLayout(false);
            this.panelAnsRdb.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelAnschk;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label lblExplanationChk6;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.CheckBox chk5;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.CheckBox chk4;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.CheckBox chk3;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.CheckBox chk2;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.CheckBox chk1;
        private System.Windows.Forms.Panel panelAnsRdb;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label lblExplanationRdb6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton rdb5;
        private System.Windows.Forms.Panel panel7;
        internal System.Windows.Forms.RadioButton rdb4;
        private System.Windows.Forms.Panel panel6;
        internal System.Windows.Forms.RadioButton rdb3;
        private System.Windows.Forms.Panel panel8;
        internal System.Windows.Forms.RadioButton rdb2;
        private System.Windows.Forms.Panel panel9;
        internal System.Windows.Forms.RadioButton rdb1;
        private System.Windows.Forms.Panel panel4;
        internal System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblTimeRemaining;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Button btnPrevious;
        internal System.Windows.Forms.Button btnNext;
        internal System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer pexamTimer;

    }
}

