namespace Chat
{
    partial class Form_chat
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_zapisz = new System.Windows.Forms.Button();
            this.lbl_ip = new System.Windows.Forms.Label();
            this.lbl_port = new System.Windows.Forms.Label();
            this.lbl_port2 = new System.Windows.Forms.Label();
            this.lbl_ip2 = new System.Windows.Forms.Label();
            this.txt_ip1 = new System.Windows.Forms.TextBox();
            this.txt_port1 = new System.Windows.Forms.TextBox();
            this.txt_ip2 = new System.Windows.Forms.TextBox();
            this.txt_port2 = new System.Windows.Forms.TextBox();
            this.lst_wiad = new System.Windows.Forms.ListBox();
            this.txt_wiad = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_port1);
            this.groupBox1.Controls.Add(this.txt_ip1);
            this.groupBox1.Controls.Add(this.lbl_port);
            this.groupBox1.Controls.Add(this.lbl_ip);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ja";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_port2);
            this.groupBox2.Controls.Add(this.txt_ip2);
            this.groupBox2.Controls.Add(this.lbl_port2);
            this.groupBox2.Controls.Add(this.lbl_ip2);
            this.groupBox2.Location = new System.Drawing.Point(254, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 125);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kolega";
            this.groupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // btn_zapisz
            // 
            this.btn_zapisz.Location = new System.Drawing.Point(412, 143);
            this.btn_zapisz.Name = "btn_zapisz";
            this.btn_zapisz.Size = new System.Drawing.Size(75, 23);
            this.btn_zapisz.TabIndex = 2;
            this.btn_zapisz.Text = "Połącz";
            this.btn_zapisz.UseVisualStyleBackColor = true;
            this.btn_zapisz.Click += new System.EventHandler(this.Btn_zapisz_Click);
            // 
            // lbl_ip
            // 
            this.lbl_ip.AutoSize = true;
            this.lbl_ip.Location = new System.Drawing.Point(7, 20);
            this.lbl_ip.Name = "lbl_ip";
            this.lbl_ip.Size = new System.Drawing.Size(15, 14);
            this.lbl_ip.TabIndex = 0;
            this.lbl_ip.Text = "IP";
            this.lbl_ip.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lbl_port
            // 
            this.lbl_port.AutoSize = true;
            this.lbl_port.Location = new System.Drawing.Point(6, 53);
            this.lbl_port.Name = "lbl_port";
            this.lbl_port.Size = new System.Drawing.Size(26, 14);
            this.lbl_port.TabIndex = 1;
            this.lbl_port.Text = "Port";
            // 
            // lbl_port2
            // 
            this.lbl_port2.AutoSize = true;
            this.lbl_port2.Location = new System.Drawing.Point(6, 53);
            this.lbl_port2.Name = "lbl_port2";
            this.lbl_port2.Size = new System.Drawing.Size(26, 14);
            this.lbl_port2.TabIndex = 3;
            this.lbl_port2.Text = "Port";
            // 
            // lbl_ip2
            // 
            this.lbl_ip2.AutoSize = true;
            this.lbl_ip2.Location = new System.Drawing.Point(7, 20);
            this.lbl_ip2.Name = "lbl_ip2";
            this.lbl_ip2.Size = new System.Drawing.Size(15, 14);
            this.lbl_ip2.TabIndex = 2;
            this.lbl_ip2.Text = "IP";
            // 
            // txt_ip1
            // 
            this.txt_ip1.Location = new System.Drawing.Point(56, 20);
            this.txt_ip1.Name = "txt_ip1";
            this.txt_ip1.Size = new System.Drawing.Size(100, 20);
            this.txt_ip1.TabIndex = 2;
            // 
            // txt_port1
            // 
            this.txt_port1.Location = new System.Drawing.Point(56, 53);
            this.txt_port1.Name = "txt_port1";
            this.txt_port1.Size = new System.Drawing.Size(100, 20);
            this.txt_port1.TabIndex = 3;
            // 
            // txt_ip2
            // 
            this.txt_ip2.Location = new System.Drawing.Point(54, 20);
            this.txt_ip2.Name = "txt_ip2";
            this.txt_ip2.Size = new System.Drawing.Size(100, 20);
            this.txt_ip2.TabIndex = 4;
            // 
            // txt_port2
            // 
            this.txt_port2.Location = new System.Drawing.Point(54, 50);
            this.txt_port2.Name = "txt_port2";
            this.txt_port2.Size = new System.Drawing.Size(100, 20);
            this.txt_port2.TabIndex = 5;
            // 
            // lst_wiad
            // 
            this.lst_wiad.FormattingEnabled = true;
            this.lst_wiad.ItemHeight = 14;
            this.lst_wiad.Location = new System.Drawing.Point(12, 175);
            this.lst_wiad.Name = "lst_wiad";
            this.lst_wiad.Size = new System.Drawing.Size(475, 270);
            this.lst_wiad.TabIndex = 3;
            this.lst_wiad.SelectedIndexChanged += new System.EventHandler(this.Lst_wiad_SelectedIndexChanged);
            // 
            // txt_wiad
            // 
            this.txt_wiad.Location = new System.Drawing.Point(12, 452);
            this.txt_wiad.Name = "txt_wiad";
            this.txt_wiad.Size = new System.Drawing.Size(396, 20);
            this.txt_wiad.TabIndex = 4;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(412, 451);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 5;
            this.btn_send.Text = "Wyślij";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.Btn_send_Click);
            // 
            // Form_chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(494, 484);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txt_wiad);
            this.Controls.Add(this.lst_wiad);
            this.Controls.Add(this.btn_zapisz);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "Form_chat";
            this.Text = "ChatApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_ip;
        private System.Windows.Forms.Button btn_zapisz;
        private System.Windows.Forms.TextBox txt_port1;
        private System.Windows.Forms.TextBox txt_ip1;
        private System.Windows.Forms.Label lbl_port;
        private System.Windows.Forms.TextBox txt_port2;
        private System.Windows.Forms.TextBox txt_ip2;
        private System.Windows.Forms.Label lbl_port2;
        private System.Windows.Forms.Label lbl_ip2;
        private System.Windows.Forms.ListBox lst_wiad;
        private System.Windows.Forms.TextBox txt_wiad;
        private System.Windows.Forms.Button btn_send;
    }
}

