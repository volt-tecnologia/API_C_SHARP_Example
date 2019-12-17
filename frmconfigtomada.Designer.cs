namespace API_Volt
{
    partial class frmconfigtomada
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
            this.cbotomada = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.chken = new System.Windows.Forms.CheckBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnfechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbotomada
            // 
            this.cbotomada.FormattingEnabled = true;
            this.cbotomada.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbotomada.Location = new System.Drawing.Point(81, 10);
            this.cbotomada.Name = "cbotomada";
            this.cbotomada.Size = new System.Drawing.Size(58, 21);
            this.cbotomada.TabIndex = 0;
            this.cbotomada.SelectedIndexChanged += new System.EventHandler(this.cbotomada_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tomada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição:";
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(81, 46);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(156, 20);
            this.txtdescricao.TabIndex = 3;
            // 
            // chken
            // 
            this.chken.AutoSize = true;
            this.chken.Location = new System.Drawing.Point(19, 85);
            this.chken.Name = "chken";
            this.chken.Size = new System.Drawing.Size(106, 17);
            this.chken.TabIndex = 4;
            this.chken.Text = "Habilitar Tomada";
            this.chken.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(81, 139);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(85, 30);
            this.btnsave.TabIndex = 5;
            this.btnsave.Text = "Salvar";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnfechar
            // 
            this.btnfechar.Location = new System.Drawing.Point(172, 139);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(85, 30);
            this.btnfechar.TabIndex = 6;
            this.btnfechar.Text = "Fechar";
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // frmconfigtomada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 192);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.chken);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbotomada);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmconfigtomada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurar Tomadas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbotomada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.CheckBox chken;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnfechar;
    }
}