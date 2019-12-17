namespace API_Volt
{
    partial class frmconfigeth
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
            this.label1 = new System.Windows.Forms.Label();
            this.txthost = new System.Windows.Forms.TextBox();
            this.txtmac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmask = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtgtw = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdns1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtdns2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host:";
            // 
            // txthost
            // 
            this.txthost.Location = new System.Drawing.Point(13, 32);
            this.txthost.Name = "txthost";
            this.txthost.Size = new System.Drawing.Size(263, 20);
            this.txthost.TabIndex = 1;
            // 
            // txtmac
            // 
            this.txtmac.Location = new System.Drawing.Point(13, 77);
            this.txtmac.Name = "txtmac";
            this.txtmac.ReadOnly = true;
            this.txtmac.Size = new System.Drawing.Size(263, 20);
            this.txtmac.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "MAC Address:";
            // 
            // txtip
            // 
            this.txtip.Location = new System.Drawing.Point(13, 122);
            this.txtip.Name = "txtip";
            this.txtip.Size = new System.Drawing.Size(263, 20);
            this.txtip.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "IP:";
            // 
            // txtmask
            // 
            this.txtmask.Location = new System.Drawing.Point(13, 167);
            this.txtmask.Name = "txtmask";
            this.txtmask.Size = new System.Drawing.Size(263, 20);
            this.txtmask.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Máscara de Subrede:";
            // 
            // txtgtw
            // 
            this.txtgtw.Location = new System.Drawing.Point(13, 212);
            this.txtgtw.Name = "txtgtw";
            this.txtgtw.Size = new System.Drawing.Size(263, 20);
            this.txtgtw.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gateway:";
            // 
            // txtdns1
            // 
            this.txtdns1.Location = new System.Drawing.Point(13, 257);
            this.txtdns1.Name = "txtdns1";
            this.txtdns1.Size = new System.Drawing.Size(263, 20);
            this.txtdns1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "DNS Primário:";
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(103, 350);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(79, 36);
            this.btnsalvar.TabIndex = 12;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(200, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 36);
            this.button2.TabIndex = 13;
            this.button2.Text = "Fechar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtdns2
            // 
            this.txtdns2.Location = new System.Drawing.Point(13, 302);
            this.txtdns2.Name = "txtdns2";
            this.txtdns2.Size = new System.Drawing.Size(263, 20);
            this.txtdns2.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "DNS Secundário:";
            // 
            // frmconfigeth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 398);
            this.Controls.Add(this.txtdns2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.txtdns1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtgtw);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmask);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txthost);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmconfigeth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuração da Interface Ethernet";
            this.Load += new System.EventHandler(this.frmconfigeth_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txthost;
        private System.Windows.Forms.TextBox txtmac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmask;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtgtw;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdns1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtdns2;
        private System.Windows.Forms.Label label7;
    }
}