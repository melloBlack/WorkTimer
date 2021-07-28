namespace WorkTimer
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Start = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Minimalize = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sayac = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.workTimerDataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workTimerDataDataSet = new WorkTimer.WorkTimerDataDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.workTimerDataDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workTimerDataDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listView1.AllowColumnReorder = true;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(33)))), ((int)(((byte)(82)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-2, 399);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeftLayout = true;
            this.listView1.ShowGroups = false;
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(503, 130);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Day";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "WorkTime";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Project";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 198;
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Transparent;
            this.Start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Start.BackgroundImage")));
            this.Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.Start.FlatAppearance.BorderSize = 0;
            this.Start.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PeachPuff;
            this.Start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Start.ForeColor = System.Drawing.Color.White;
            this.Start.Location = new System.Drawing.Point(367, -14);
            this.Start.Margin = new System.Windows.Forms.Padding(0);
            this.Start.Name = "Start";
            this.Start.Padding = new System.Windows.Forms.Padding(0, 18, 0, 0);
            this.Start.Size = new System.Drawing.Size(134, 91);
            this.Start.TabIndex = 0;
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Pause
            // 
            this.Pause.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Pause.BackColor = System.Drawing.Color.Transparent;
            this.Pause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pause.BackgroundImage")));
            this.Pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pause.CausesValidation = false;
            this.Pause.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Pause.Enabled = false;
            this.Pause.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.Pause.FlatAppearance.BorderSize = 0;
            this.Pause.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Pause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Pause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pause.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(28)))), ((int)(((byte)(70)))));
            this.Pause.Location = new System.Drawing.Point(345, 113);
            this.Pause.Name = "Pause";
            this.Pause.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.Pause.Size = new System.Drawing.Size(156, 111);
            this.Pause.TabIndex = 2;
            this.Pause.TabStop = false;
            this.Pause.UseVisualStyleBackColor = true;
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.Transparent;
            this.Stop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Stop.BackgroundImage")));
            this.Stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Stop.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.Stop.FlatAppearance.BorderSize = 0;
            this.Stop.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Stop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PeachPuff;
            this.Stop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stop.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Stop.ForeColor = System.Drawing.Color.White;
            this.Stop.Location = new System.Drawing.Point(2, -14);
            this.Stop.Name = "Stop";
            this.Stop.Padding = new System.Windows.Forms.Padding(0, 18, 0, 0);
            this.Stop.Size = new System.Drawing.Size(97, 88);
            this.Stop.TabIndex = 3;
            this.Stop.Text = "Exit";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Minimalize
            // 
            this.Minimalize.BackColor = System.Drawing.Color.Transparent;
            this.Minimalize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Minimalize.BackgroundImage")));
            this.Minimalize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Minimalize.Cursor = System.Windows.Forms.Cursors.PanSE;
            this.Minimalize.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Minimalize.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.Minimalize.FlatAppearance.BorderSize = 0;
            this.Minimalize.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Minimalize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Minimalize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Minimalize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimalize.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Minimalize.ForeColor = System.Drawing.Color.DarkRed;
            this.Minimalize.Location = new System.Drawing.Point(426, 341);
            this.Minimalize.Name = "Minimalize";
            this.Minimalize.Size = new System.Drawing.Size(75, 55);
            this.Minimalize.TabIndex = 11;
            this.Minimalize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Minimalize.UseVisualStyleBackColor = false;
            this.Minimalize.Click += new System.EventHandler(this.Minimalize_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // sayac
            // 
            this.sayac.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sayac.AutoEllipsis = true;
            this.sayac.BackColor = System.Drawing.Color.Transparent;
            this.sayac.Font = new System.Drawing.Font("Segoe Script", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sayac.ForeColor = System.Drawing.Color.Beige;
            this.sayac.Location = new System.Drawing.Point(3, 144);
            this.sayac.Name = "sayac";
            this.sayac.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sayac.Size = new System.Drawing.Size(129, 252);
            this.sayac.TabIndex = 9;
            this.sayac.Text = "0";
            this.sayac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sayac.Click += new System.EventHandler(this.sayac_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipTitle = "KaraStudios";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "What are you looking for here? Get back to work!";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // workTimerDataDataSetBindingSource
            // 
            this.workTimerDataDataSetBindingSource.DataSource = this.workTimerDataDataSet;
            this.workTimerDataDataSetBindingSource.Position = 0;
            // 
            // workTimerDataDataSet
            // 
            this.workTimerDataDataSet.DataSetName = "WorkTimerDataDataSet";
            this.workTimerDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AcceptButton = this.Pause;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.Minimalize;
            this.ClientSize = new System.Drawing.Size(501, 526);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.sayac);
            this.Controls.Add(this.Minimalize);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Start);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Work Timer";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workTimerDataDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workTimerDataDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Button Minimalize;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label sayac;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.BindingSource workTimerDataDataSetBindingSource;
        private WorkTimerDataDataSet workTimerDataDataSet;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.ColumnHeader columnHeader2;
        public System.Windows.Forms.ColumnHeader columnHeader3;
        public System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView listView1;
       
    }
}

