namespace WindowsFormsApplication1
{
    partial class StudySession
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("INTRODUCTION");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("RDBMS");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("INDEX", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("OVERVIEW");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("SELECT");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("INSERT");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("UPDATE");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("DELETE");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("DROP");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("ALTER");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("TABLE", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("DISTINCT");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("AND");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("ORDER_BY");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("TOP");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("LIKE");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("WILD_CARD");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("IN");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("BETWEEN");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("ALIAS");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("CLAUSE", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("OVERVIEWS");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("INNER_JOIN");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("LEFT_JOIN");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("RIGHT_JOIN");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("FULL_JOIN");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("JOIN", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26});
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("SQL_CONSTRAINTS");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("NOT_NULL");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("UNIQUE");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("PRIMARY_KEY");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("FOREIGN_KEY");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("CHECK");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("DEFAULT");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("CONSTRAINTS", new System.Windows.Forms.TreeNode[] {
            treeNode28,
            treeNode29,
            treeNode30,
            treeNode31,
            treeNode32,
            treeNode33,
            treeNode34});
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("SQL_VIEWS");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("VIEWS", new System.Windows.Forms.TreeNode[] {
            treeNode36});
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("CREATE_INDEX");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("INDEX", new System.Windows.Forms.TreeNode[] {
            treeNode38});
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("AVERAGE");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("COUNT");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("FIRST");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("LAST");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("MAX");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("MIN");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("SUM");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("GROUP_BY");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("HAVING");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("UPPER_CASE");
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("LOWER_CASE");
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("MID");
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("LENGTH");
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("ROUND");
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("NOW");
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("FORMAT");
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("CONCATENATE");
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("SUBSTRING");
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("TRIM");
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("REPLACE");
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("DATEADD");
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("DATEDIFF");
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("GETDATE");
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("SYSDATE");
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("FUNCTION", new System.Windows.Forms.TreeNode[] {
            treeNode40,
            treeNode41,
            treeNode42,
            treeNode43,
            treeNode44,
            treeNode45,
            treeNode46,
            treeNode47,
            treeNode48,
            treeNode49,
            treeNode50,
            treeNode51,
            treeNode52,
            treeNode53,
            treeNode54,
            treeNode55,
            treeNode56,
            treeNode57,
            treeNode58,
            treeNode59,
            treeNode60,
            treeNode61,
            treeNode62,
            treeNode63});
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel4 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 80);
            this.panel1.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Home;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(440, 7);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 53);
            this.btnHome.TabIndex = 2;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblTitle.Font = new System.Drawing.Font("Jokerman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(560, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(286, 55);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "STUDY GUIDE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.pra10;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 75);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(15, 35, 15, 15);
            this.panel2.Size = new System.Drawing.Size(924, 547);
            this.panel2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.webBrowser1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(305, 35);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(600, 493);
            this.panel5.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(596, 489);
            this.webBrowser1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.treeView1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(15, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(290, 493);
            this.panel4.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.treeView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.LineColor = System.Drawing.Color.Maroon;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node2";
            treeNode1.Text = "INTRODUCTION";
            treeNode2.Name = "Node3";
            treeNode2.Text = "RDBMS";
            treeNode3.Name = "Node0";
            treeNode3.Text = "INDEX";
            treeNode4.Name = "Node5";
            treeNode4.Text = "OVERVIEW";
            treeNode5.Name = "Node7";
            treeNode5.Text = "SELECT";
            treeNode6.Name = "Node8";
            treeNode6.Text = "INSERT";
            treeNode7.Name = "Node9";
            treeNode7.Text = "UPDATE";
            treeNode8.Name = "Node10";
            treeNode8.Text = "DELETE";
            treeNode9.Name = "Node8";
            treeNode9.Text = "DROP";
            treeNode10.Name = "Node9";
            treeNode10.Text = "ALTER";
            treeNode11.Name = "Node4";
            treeNode11.Text = "TABLE";
            treeNode12.Name = "Node12";
            treeNode12.Text = "DISTINCT";
            treeNode13.Name = "Node13";
            treeNode13.Text = "AND";
            treeNode14.Name = "Node14";
            treeNode14.Text = "ORDER_BY";
            treeNode15.Name = "Node15";
            treeNode15.Text = "TOP";
            treeNode16.Name = "Node16";
            treeNode16.Text = "LIKE";
            treeNode17.Name = "Node17";
            treeNode17.Text = "WILD_CARD";
            treeNode18.Name = "Node18";
            treeNode18.Text = "IN";
            treeNode19.Name = "Node19";
            treeNode19.Text = "BETWEEN";
            treeNode20.Name = "Node20";
            treeNode20.Text = "ALIAS";
            treeNode21.Name = "Node11";
            treeNode21.Text = "CLAUSE";
            treeNode22.Name = "Node22";
            treeNode22.Text = "OVERVIEWS";
            treeNode23.Name = "Node23";
            treeNode23.Text = "INNER_JOIN";
            treeNode24.Name = "Node24";
            treeNode24.Text = "LEFT_JOIN";
            treeNode25.Name = "Node25";
            treeNode25.Text = "RIGHT_JOIN";
            treeNode26.Name = "Node26";
            treeNode26.Text = "FULL_JOIN";
            treeNode27.Name = "Node21";
            treeNode27.Text = "JOIN";
            treeNode28.Name = "Node1";
            treeNode28.Text = "SQL_CONSTRAINTS";
            treeNode29.Name = "Node2";
            treeNode29.Text = "NOT_NULL";
            treeNode30.Name = "Node3";
            treeNode30.Text = "UNIQUE";
            treeNode31.Name = "Node4";
            treeNode31.Text = "PRIMARY_KEY";
            treeNode32.Name = "Node5";
            treeNode32.Text = "FOREIGN_KEY";
            treeNode33.Name = "Node6";
            treeNode33.Text = "CHECK";
            treeNode34.Name = "Node7";
            treeNode34.Text = "DEFAULT";
            treeNode35.Name = "Node0";
            treeNode35.Text = "CONSTRAINTS";
            treeNode36.Name = "Node13";
            treeNode36.Text = "SQL_VIEWS";
            treeNode37.Name = "Node10";
            treeNode37.Text = "VIEWS";
            treeNode38.Name = "Node11";
            treeNode38.Text = "CREATE_INDEX";
            treeNode39.Name = "Node14";
            treeNode39.Text = "INDEX";
            treeNode40.Name = "Node15";
            treeNode40.Text = "AVERAGE";
            treeNode41.Name = "Node16";
            treeNode41.Text = "COUNT";
            treeNode42.Name = "Node17";
            treeNode42.Text = "FIRST";
            treeNode43.Name = "Node18";
            treeNode43.Text = "LAST";
            treeNode44.Name = "Node19";
            treeNode44.Text = "MAX";
            treeNode45.Name = "Node20";
            treeNode45.Text = "MIN";
            treeNode46.Name = "Node21";
            treeNode46.Text = "SUM";
            treeNode47.Name = "Node22";
            treeNode47.Text = "GROUP_BY";
            treeNode48.Name = "Node23";
            treeNode48.Text = "HAVING";
            treeNode49.Name = "Node24";
            treeNode49.Text = "UPPER_CASE";
            treeNode50.Name = "Node25";
            treeNode50.Text = "LOWER_CASE";
            treeNode51.Name = "Node26";
            treeNode51.Text = "MID";
            treeNode52.Name = "Node27";
            treeNode52.Text = "LENGTH";
            treeNode53.Name = "Node28";
            treeNode53.Text = "ROUND";
            treeNode54.Name = "Node29";
            treeNode54.Text = "NOW";
            treeNode55.Name = "Node30";
            treeNode55.Text = "FORMAT";
            treeNode56.Name = "Node2";
            treeNode56.Text = "CONCATENATE";
            treeNode57.Name = "Node3";
            treeNode57.Text = "SUBSTRING";
            treeNode58.Name = "Node4";
            treeNode58.Text = "TRIM";
            treeNode59.Name = "Node5";
            treeNode59.Text = "REPLACE";
            treeNode60.Name = "Node6";
            treeNode60.Text = "DATEADD";
            treeNode61.Name = "Node7";
            treeNode61.Text = "DATEDIFF";
            treeNode62.Name = "Node8";
            treeNode62.Text = "GETDATE";
            treeNode63.Name = "Node9";
            treeNode63.Text = "SYSDATE";
            treeNode64.Name = "Node12";
            treeNode64.Text = "FUNCTION";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode11,
            treeNode21,
            treeNode27,
            treeNode35,
            treeNode37,
            treeNode39,
            treeNode64});
            this.treeView1.Size = new System.Drawing.Size(286, 489);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 627);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(924, 52);
            this.panel3.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // StudySession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 679);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "StudySession";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ImageList imageList1;
    }
}

