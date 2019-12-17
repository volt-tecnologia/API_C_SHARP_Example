namespace API_Volt
{
    partial class frmapi
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
            this.btnconfigeth = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblstatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lvwethinfo = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnconfigtomada = new System.Windows.Forms.Button();
            this.btndesaball = new System.Windows.Forms.Button();
            this.btnhaball = new System.Windows.Forms.Button();
            this.chkreboot = new System.Windows.Forms.CheckBox();
            this.btnt10 = new System.Windows.Forms.Button();
            this.btnt9 = new System.Windows.Forms.Button();
            this.btnt8 = new System.Windows.Forms.Button();
            this.btnt4 = new System.Windows.Forms.Button();
            this.btnt7 = new System.Windows.Forms.Button();
            this.btnt6 = new System.Windows.Forms.Button();
            this.btnt5 = new System.Windows.Forms.Button();
            this.btnt3 = new System.Windows.Forms.Button();
            this.btnt2 = new System.Windows.Forms.Button();
            this.btnt1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblcalendario = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblclock = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbluptime = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbltemp = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tmrupdate = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnconfigeth
            // 
            this.btnconfigeth.Location = new System.Drawing.Point(218, 210);
            this.btnconfigeth.Name = "btnconfigeth";
            this.btnconfigeth.Size = new System.Drawing.Size(130, 47);
            this.btnconfigeth.TabIndex = 0;
            this.btnconfigeth.Text = "Configurar Interface";
            this.btnconfigeth.UseVisualStyleBackColor = true;
            this.btnconfigeth.Click += new System.EventHandler(this.btnconfigeth_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblstatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 570);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(969, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblstatus
            // 
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(0, 17);
            // 
            // lvwethinfo
            // 
            this.lvwethinfo.HideSelection = false;
            this.lvwethinfo.Location = new System.Drawing.Point(18, 19);
            this.lvwethinfo.Name = "lvwethinfo";
            this.lvwethinfo.Size = new System.Drawing.Size(330, 181);
            this.lvwethinfo.TabIndex = 2;
            this.lvwethinfo.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwethinfo);
            this.groupBox1.Controls.Add(this.btnconfigeth);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 267);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Interface Ethernet";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnconfigtomada);
            this.groupBox2.Controls.Add(this.btndesaball);
            this.groupBox2.Controls.Add(this.btnhaball);
            this.groupBox2.Controls.Add(this.chkreboot);
            this.groupBox2.Controls.Add(this.btnt10);
            this.groupBox2.Controls.Add(this.btnt9);
            this.groupBox2.Controls.Add(this.btnt8);
            this.groupBox2.Controls.Add(this.btnt4);
            this.groupBox2.Controls.Add(this.btnt7);
            this.groupBox2.Controls.Add(this.btnt6);
            this.groupBox2.Controls.Add(this.btnt5);
            this.groupBox2.Controls.Add(this.btnt3);
            this.groupBox2.Controls.Add(this.btnt2);
            this.groupBox2.Controls.Add(this.btnt1);
            this.groupBox2.Location = new System.Drawing.Point(388, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(569, 267);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status das Tomadas";
            // 
            // btnconfigtomada
            // 
            this.btnconfigtomada.Location = new System.Drawing.Point(415, 206);
            this.btnconfigtomada.Name = "btnconfigtomada";
            this.btnconfigtomada.Size = new System.Drawing.Size(130, 47);
            this.btnconfigtomada.TabIndex = 13;
            this.btnconfigtomada.Text = "Configurar Tomada";
            this.btnconfigtomada.UseVisualStyleBackColor = true;
            this.btnconfigtomada.Click += new System.EventHandler(this.btnconfigtomada_Click);
            // 
            // btndesaball
            // 
            this.btndesaball.Location = new System.Drawing.Point(121, 206);
            this.btndesaball.Name = "btndesaball";
            this.btndesaball.Size = new System.Drawing.Size(108, 47);
            this.btndesaball.TabIndex = 12;
            this.btndesaball.Text = "Desabilitar Todas";
            this.btndesaball.UseVisualStyleBackColor = true;
            this.btndesaball.Click += new System.EventHandler(this.btndesaball_Click);
            // 
            // btnhaball
            // 
            this.btnhaball.Location = new System.Drawing.Point(7, 206);
            this.btnhaball.Name = "btnhaball";
            this.btnhaball.Size = new System.Drawing.Size(108, 47);
            this.btnhaball.TabIndex = 11;
            this.btnhaball.Text = "Habilitar Todas";
            this.btnhaball.UseVisualStyleBackColor = true;
            this.btnhaball.Click += new System.EventHandler(this.btnhaball_Click);
            // 
            // chkreboot
            // 
            this.chkreboot.AutoSize = true;
            this.chkreboot.Location = new System.Drawing.Point(201, 150);
            this.chkreboot.Name = "chkreboot";
            this.chkreboot.Size = new System.Drawing.Size(144, 17);
            this.chkreboot.TabIndex = 10;
            this.chkreboot.Text = "Religar Automaticamente";
            this.chkreboot.UseVisualStyleBackColor = true;
            this.chkreboot.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnt10
            // 
            this.btnt10.Image = global::API_Volt.Properties.Resources.plug32_green;
            this.btnt10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnt10.Location = new System.Drawing.Point(415, 134);
            this.btnt10.Name = "btnt10";
            this.btnt10.Size = new System.Drawing.Size(130, 47);
            this.btnt10.TabIndex = 9;
            this.btnt10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnt10.UseVisualStyleBackColor = true;
            this.btnt10.Click += new System.EventHandler(this.btnt10_Click);
            // 
            // btnt9
            // 
            this.btnt9.Image = global::API_Volt.Properties.Resources.plug32_green;
            this.btnt9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnt9.Location = new System.Drawing.Point(7, 134);
            this.btnt9.Name = "btnt9";
            this.btnt9.Size = new System.Drawing.Size(130, 47);
            this.btnt9.TabIndex = 8;
            this.btnt9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnt9.UseVisualStyleBackColor = true;
            this.btnt9.Click += new System.EventHandler(this.btnt9_Click);
            // 
            // btnt8
            // 
            this.btnt8.Image = global::API_Volt.Properties.Resources.plug32_green;
            this.btnt8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnt8.Location = new System.Drawing.Point(415, 81);
            this.btnt8.Name = "btnt8";
            this.btnt8.Size = new System.Drawing.Size(130, 47);
            this.btnt8.TabIndex = 7;
            this.btnt8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnt8.UseVisualStyleBackColor = true;
            this.btnt8.Click += new System.EventHandler(this.btnt8_Click);
            // 
            // btnt4
            // 
            this.btnt4.Image = global::API_Volt.Properties.Resources.plug32_green;
            this.btnt4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnt4.Location = new System.Drawing.Point(415, 28);
            this.btnt4.Name = "btnt4";
            this.btnt4.Size = new System.Drawing.Size(130, 47);
            this.btnt4.TabIndex = 6;
            this.btnt4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnt4.UseVisualStyleBackColor = true;
            this.btnt4.Click += new System.EventHandler(this.btnt4_Click);
            // 
            // btnt7
            // 
            this.btnt7.Image = global::API_Volt.Properties.Resources.plug32_green;
            this.btnt7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnt7.Location = new System.Drawing.Point(279, 81);
            this.btnt7.Name = "btnt7";
            this.btnt7.Size = new System.Drawing.Size(130, 47);
            this.btnt7.TabIndex = 5;
            this.btnt7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnt7.UseVisualStyleBackColor = true;
            this.btnt7.Click += new System.EventHandler(this.btnt7_Click);
            // 
            // btnt6
            // 
            this.btnt6.Image = global::API_Volt.Properties.Resources.plug32_green;
            this.btnt6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnt6.Location = new System.Drawing.Point(143, 81);
            this.btnt6.Name = "btnt6";
            this.btnt6.Size = new System.Drawing.Size(130, 47);
            this.btnt6.TabIndex = 4;
            this.btnt6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnt6.UseVisualStyleBackColor = true;
            this.btnt6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnt5
            // 
            this.btnt5.Image = global::API_Volt.Properties.Resources.plug32_green;
            this.btnt5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnt5.Location = new System.Drawing.Point(7, 81);
            this.btnt5.Name = "btnt5";
            this.btnt5.Size = new System.Drawing.Size(130, 47);
            this.btnt5.TabIndex = 3;
            this.btnt5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnt5.UseVisualStyleBackColor = true;
            this.btnt5.Click += new System.EventHandler(this.btnt5_Click);
            // 
            // btnt3
            // 
            this.btnt3.Image = global::API_Volt.Properties.Resources.plug32_green;
            this.btnt3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnt3.Location = new System.Drawing.Point(279, 28);
            this.btnt3.Name = "btnt3";
            this.btnt3.Size = new System.Drawing.Size(130, 47);
            this.btnt3.TabIndex = 2;
            this.btnt3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnt3.UseVisualStyleBackColor = true;
            this.btnt3.Click += new System.EventHandler(this.btnt3_Click);
            // 
            // btnt2
            // 
            this.btnt2.Image = global::API_Volt.Properties.Resources.plug32_green;
            this.btnt2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnt2.Location = new System.Drawing.Point(143, 28);
            this.btnt2.Name = "btnt2";
            this.btnt2.Size = new System.Drawing.Size(130, 47);
            this.btnt2.TabIndex = 1;
            this.btnt2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnt2.UseVisualStyleBackColor = true;
            this.btnt2.Click += new System.EventHandler(this.btnt2_Click);
            // 
            // btnt1
            // 
            this.btnt1.Image = global::API_Volt.Properties.Resources.plug32_green;
            this.btnt1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnt1.Location = new System.Drawing.Point(7, 28);
            this.btnt1.Name = "btnt1";
            this.btnt1.Size = new System.Drawing.Size(130, 47);
            this.btnt1.TabIndex = 0;
            this.btnt1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnt1.UseVisualStyleBackColor = true;
            this.btnt1.Click += new System.EventHandler(this.btnt1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(12, 313);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(945, 153);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Status dos Sensores";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lblcalendario);
            this.groupBox7.Controls.Add(this.pictureBox4);
            this.groupBox7.Location = new System.Drawing.Point(710, 31);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(211, 100);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Calendário";
            // 
            // lblcalendario
            // 
            this.lblcalendario.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcalendario.Location = new System.Drawing.Point(77, 26);
            this.lblcalendario.Name = "lblcalendario";
            this.lblcalendario.Size = new System.Drawing.Size(128, 56);
            this.lblcalendario.TabIndex = 1;
            this.lblcalendario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::API_Volt.Properties.Resources.calendar;
            this.pictureBox4.Location = new System.Drawing.Point(7, 22);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 64);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblclock);
            this.groupBox6.Controls.Add(this.pictureBox3);
            this.groupBox6.Location = new System.Drawing.Point(464, 31);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(211, 100);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Relógio";
            // 
            // lblclock
            // 
            this.lblclock.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclock.Location = new System.Drawing.Point(77, 26);
            this.lblclock.Name = "lblclock";
            this.lblclock.Size = new System.Drawing.Size(128, 56);
            this.lblclock.TabIndex = 1;
            this.lblclock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::API_Volt.Properties.Resources.clock;
            this.pictureBox3.Location = new System.Drawing.Point(7, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbluptime);
            this.groupBox5.Controls.Add(this.pictureBox2);
            this.groupBox5.Location = new System.Drawing.Point(227, 31);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(211, 100);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Uptime";
            // 
            // lbluptime
            // 
            this.lbluptime.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluptime.Location = new System.Drawing.Point(77, 26);
            this.lbluptime.Name = "lbluptime";
            this.lbluptime.Size = new System.Drawing.Size(128, 56);
            this.lbluptime.TabIndex = 1;
            this.lbluptime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::API_Volt.Properties.Resources.uptime;
            this.pictureBox2.Location = new System.Drawing.Point(7, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbltemp);
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Location = new System.Drawing.Point(10, 31);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(188, 100);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Temperatura";
            // 
            // lbltemp
            // 
            this.lbltemp.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltemp.Location = new System.Drawing.Point(77, 26);
            this.lbltemp.Name = "lbltemp";
            this.lbltemp.Size = new System.Drawing.Size(100, 56);
            this.lbltemp.TabIndex = 1;
            this.lbltemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::API_Volt.Properties.Resources.temp;
            this.pictureBox1.Location = new System.Drawing.Point(7, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tmrupdate
            // 
            this.tmrupdate.Enabled = true;
            this.tmrupdate.Interval = 1000;
            this.tmrupdate.Tick += new System.EventHandler(this.tmrupdate_Tick);
            // 
            // frmapi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 592);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmapi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "API Volt - C# Example";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnconfigeth;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblstatus;
        private System.Windows.Forms.ListView lvwethinfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lbluptime;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbltemp;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lblcalendario;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblclock;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer tmrupdate;
        private System.Windows.Forms.Button btnt10;
        private System.Windows.Forms.Button btnt9;
        private System.Windows.Forms.Button btnt8;
        private System.Windows.Forms.Button btnt4;
        private System.Windows.Forms.Button btnt7;
        private System.Windows.Forms.Button btnt6;
        private System.Windows.Forms.Button btnt5;
        private System.Windows.Forms.Button btnt3;
        private System.Windows.Forms.Button btnt2;
        private System.Windows.Forms.Button btnt1;
        private System.Windows.Forms.CheckBox chkreboot;
        private System.Windows.Forms.Button btndesaball;
        private System.Windows.Forms.Button btnhaball;
        private System.Windows.Forms.Button btnconfigtomada;
    }
}

