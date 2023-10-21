namespace _07_10_23__Calcolatore_Subnet_
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_NumHost = new System.Windows.Forms.Label();
            this.txtb_NumHost = new System.Windows.Forms.TextBox();
            this.lbl_NumSottoreti = new System.Windows.Forms.Label();
            this.txtb_NumSottoreti = new System.Windows.Forms.TextBox();
            this.btn_Calcolare = new System.Windows.Forms.Button();
            this.lbl_Class = new System.Windows.Forms.Label();
            this.lbl_IndirizzoBase = new System.Windows.Forms.Label();
            this.lbl_Subnet = new System.Windows.Forms.Label();
            this.lbl_CIDR = new System.Windows.Forms.Label();
            this.txtb_Class = new System.Windows.Forms.TextBox();
            this.txtb_IndirizzoBase = new System.Windows.Forms.TextBox();
            this.txtb_Subnet = new System.Windows.Forms.TextBox();
            this.lb_Broadcast = new System.Windows.Forms.ListBox();
            this.lbl_UltimoHost = new System.Windows.Forms.Label();
            this.lb_UltimoHost = new System.Windows.Forms.ListBox();
            this.lbl_PrimoHost = new System.Windows.Forms.Label();
            this.lb_DG = new System.Windows.Forms.ListBox();
            this.lb_PrimoHost = new System.Windows.Forms.ListBox();
            this.txtb_CIDR = new System.Windows.Forms.TextBox();
            this.lbl_DG = new System.Windows.Forms.Label();
            this.lbl_Broadcast = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_NumHost
            // 
            this.lbl_NumHost.AutoSize = true;
            this.lbl_NumHost.Location = new System.Drawing.Point(9, 9);
            this.lbl_NumHost.Name = "lbl_NumHost";
            this.lbl_NumHost.Size = new System.Drawing.Size(109, 13);
            this.lbl_NumHost.TabIndex = 0;
            this.lbl_NumHost.Text = "Numero host possibili:";
            // 
            // txtb_NumHost
            // 
            this.txtb_NumHost.Location = new System.Drawing.Point(12, 25);
            this.txtb_NumHost.Name = "txtb_NumHost";
            this.txtb_NumHost.Size = new System.Drawing.Size(123, 20);
            this.txtb_NumHost.TabIndex = 1;
            this.txtb_NumHost.TextChanged += new System.EventHandler(this.txtb_NumHost_TextChanged);
            // 
            // lbl_NumSottoreti
            // 
            this.lbl_NumSottoreti.AutoSize = true;
            this.lbl_NumSottoreti.Location = new System.Drawing.Point(9, 48);
            this.lbl_NumSottoreti.Name = "lbl_NumSottoreti";
            this.lbl_NumSottoreti.Size = new System.Drawing.Size(126, 13);
            this.lbl_NumSottoreti.TabIndex = 2;
            this.lbl_NumSottoreti.Text = "Numero sottoreti possibili:";
            // 
            // txtb_NumSottoreti
            // 
            this.txtb_NumSottoreti.Location = new System.Drawing.Point(12, 64);
            this.txtb_NumSottoreti.Name = "txtb_NumSottoreti";
            this.txtb_NumSottoreti.Size = new System.Drawing.Size(123, 20);
            this.txtb_NumSottoreti.TabIndex = 3;
            // 
            // btn_Calcolare
            // 
            this.btn_Calcolare.Location = new System.Drawing.Point(141, 9);
            this.btn_Calcolare.Name = "btn_Calcolare";
            this.btn_Calcolare.Size = new System.Drawing.Size(75, 75);
            this.btn_Calcolare.TabIndex = 4;
            this.btn_Calcolare.Text = "Clicca per calcolare";
            this.btn_Calcolare.UseVisualStyleBackColor = true;
            this.btn_Calcolare.Click += new System.EventHandler(this.btn_Calcolare_Click);
            // 
            // lbl_Class
            // 
            this.lbl_Class.AutoSize = true;
            this.lbl_Class.Location = new System.Drawing.Point(222, 32);
            this.lbl_Class.Name = "lbl_Class";
            this.lbl_Class.Size = new System.Drawing.Size(87, 13);
            this.lbl_Class.TabIndex = 5;
            this.lbl_Class.Text = "Classe della rete:";
            // 
            // lbl_IndirizzoBase
            // 
            this.lbl_IndirizzoBase.AutoSize = true;
            this.lbl_IndirizzoBase.Location = new System.Drawing.Point(315, 32);
            this.lbl_IndirizzoBase.Name = "lbl_IndirizzoBase";
            this.lbl_IndirizzoBase.Size = new System.Drawing.Size(83, 13);
            this.lbl_IndirizzoBase.TabIndex = 6;
            this.lbl_IndirizzoBase.Text = "Indirizzo privato:";
            this.lbl_IndirizzoBase.Click += new System.EventHandler(this.lbl_IndirizzoBase_Click);
            // 
            // lbl_Subnet
            // 
            this.lbl_Subnet.AutoSize = true;
            this.lbl_Subnet.Location = new System.Drawing.Point(405, 32);
            this.lbl_Subnet.Name = "lbl_Subnet";
            this.lbl_Subnet.Size = new System.Drawing.Size(44, 13);
            this.lbl_Subnet.TabIndex = 11;
            this.lbl_Subnet.Text = "Subnet:";
            // 
            // lbl_CIDR
            // 
            this.lbl_CIDR.AutoSize = true;
            this.lbl_CIDR.Location = new System.Drawing.Point(495, 32);
            this.lbl_CIDR.Name = "lbl_CIDR";
            this.lbl_CIDR.Size = new System.Drawing.Size(36, 13);
            this.lbl_CIDR.TabIndex = 12;
            this.lbl_CIDR.Text = "CIDR:";
            // 
            // txtb_Class
            // 
            this.txtb_Class.Location = new System.Drawing.Point(225, 48);
            this.txtb_Class.Name = "txtb_Class";
            this.txtb_Class.Size = new System.Drawing.Size(84, 20);
            this.txtb_Class.TabIndex = 29;
            // 
            // txtb_IndirizzoBase
            // 
            this.txtb_IndirizzoBase.Location = new System.Drawing.Point(318, 48);
            this.txtb_IndirizzoBase.Name = "txtb_IndirizzoBase";
            this.txtb_IndirizzoBase.Size = new System.Drawing.Size(84, 20);
            this.txtb_IndirizzoBase.TabIndex = 30;
            // 
            // txtb_Subnet
            // 
            this.txtb_Subnet.Location = new System.Drawing.Point(408, 48);
            this.txtb_Subnet.Name = "txtb_Subnet";
            this.txtb_Subnet.Size = new System.Drawing.Size(84, 20);
            this.txtb_Subnet.TabIndex = 31;
            // 
            // lb_Broadcast
            // 
            this.lb_Broadcast.FormattingEnabled = true;
            this.lb_Broadcast.Location = new System.Drawing.Point(867, 25);
            this.lb_Broadcast.Name = "lb_Broadcast";
            this.lb_Broadcast.Size = new System.Drawing.Size(87, 56);
            this.lb_Broadcast.TabIndex = 28;
            // 
            // lbl_UltimoHost
            // 
            this.lbl_UltimoHost.AutoSize = true;
            this.lbl_UltimoHost.Location = new System.Drawing.Point(678, 9);
            this.lbl_UltimoHost.Name = "lbl_UltimoHost";
            this.lbl_UltimoHost.Size = new System.Drawing.Size(62, 13);
            this.lbl_UltimoHost.TabIndex = 10;
            this.lbl_UltimoHost.Text = "Ultimo host:";
            // 
            // lb_UltimoHost
            // 
            this.lb_UltimoHost.FormattingEnabled = true;
            this.lb_UltimoHost.Location = new System.Drawing.Point(681, 25);
            this.lb_UltimoHost.Name = "lb_UltimoHost";
            this.lb_UltimoHost.Size = new System.Drawing.Size(87, 56);
            this.lb_UltimoHost.TabIndex = 26;
            // 
            // lbl_PrimoHost
            // 
            this.lbl_PrimoHost.AutoSize = true;
            this.lbl_PrimoHost.Location = new System.Drawing.Point(586, 9);
            this.lbl_PrimoHost.Name = "lbl_PrimoHost";
            this.lbl_PrimoHost.Size = new System.Drawing.Size(59, 13);
            this.lbl_PrimoHost.TabIndex = 9;
            this.lbl_PrimoHost.Text = "Primo host:";
            this.lbl_PrimoHost.Click += new System.EventHandler(this.label7_Click);
            // 
            // lb_DG
            // 
            this.lb_DG.FormattingEnabled = true;
            this.lb_DG.Location = new System.Drawing.Point(774, 25);
            this.lb_DG.Name = "lb_DG";
            this.lb_DG.Size = new System.Drawing.Size(87, 56);
            this.lb_DG.TabIndex = 25;
            // 
            // lb_PrimoHost
            // 
            this.lb_PrimoHost.FormattingEnabled = true;
            this.lb_PrimoHost.Location = new System.Drawing.Point(588, 25);
            this.lb_PrimoHost.Name = "lb_PrimoHost";
            this.lb_PrimoHost.Size = new System.Drawing.Size(87, 56);
            this.lb_PrimoHost.TabIndex = 27;
            // 
            // txtb_CIDR
            // 
            this.txtb_CIDR.Location = new System.Drawing.Point(498, 48);
            this.txtb_CIDR.Name = "txtb_CIDR";
            this.txtb_CIDR.Size = new System.Drawing.Size(84, 20);
            this.txtb_CIDR.TabIndex = 32;
            // 
            // lbl_DG
            // 
            this.lbl_DG.AutoSize = true;
            this.lbl_DG.Location = new System.Drawing.Point(771, 9);
            this.lbl_DG.Name = "lbl_DG";
            this.lbl_DG.Size = new System.Drawing.Size(26, 13);
            this.lbl_DG.TabIndex = 33;
            this.lbl_DG.Text = "DG:";
            // 
            // lbl_Broadcast
            // 
            this.lbl_Broadcast.AutoSize = true;
            this.lbl_Broadcast.Location = new System.Drawing.Point(864, 9);
            this.lbl_Broadcast.Name = "lbl_Broadcast";
            this.lbl_Broadcast.Size = new System.Drawing.Size(58, 13);
            this.lbl_Broadcast.TabIndex = 34;
            this.lbl_Broadcast.Text = "Broadcast:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 450);
            this.Controls.Add(this.lbl_Broadcast);
            this.Controls.Add(this.lbl_DG);
            this.Controls.Add(this.txtb_CIDR);
            this.Controls.Add(this.txtb_Subnet);
            this.Controls.Add(this.txtb_IndirizzoBase);
            this.Controls.Add(this.txtb_Class);
            this.Controls.Add(this.lb_Broadcast);
            this.Controls.Add(this.lb_PrimoHost);
            this.Controls.Add(this.lb_UltimoHost);
            this.Controls.Add(this.lb_DG);
            this.Controls.Add(this.lbl_CIDR);
            this.Controls.Add(this.lbl_Subnet);
            this.Controls.Add(this.lbl_UltimoHost);
            this.Controls.Add(this.lbl_PrimoHost);
            this.Controls.Add(this.lbl_IndirizzoBase);
            this.Controls.Add(this.lbl_Class);
            this.Controls.Add(this.btn_Calcolare);
            this.Controls.Add(this.txtb_NumSottoreti);
            this.Controls.Add(this.lbl_NumSottoreti);
            this.Controls.Add(this.txtb_NumHost);
            this.Controls.Add(this.lbl_NumHost);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_NumHost;
        private System.Windows.Forms.TextBox txtb_NumHost;
        private System.Windows.Forms.Label lbl_NumSottoreti;
        private System.Windows.Forms.TextBox txtb_NumSottoreti;
        private System.Windows.Forms.Button btn_Calcolare;
        private System.Windows.Forms.Label lbl_Class;
        private System.Windows.Forms.Label lbl_IndirizzoBase;
        private System.Windows.Forms.Label lbl_Subnet;
        private System.Windows.Forms.Label lbl_CIDR;
        private System.Windows.Forms.TextBox txtb_Class;
        private System.Windows.Forms.TextBox txtb_IndirizzoBase;
        private System.Windows.Forms.TextBox txtb_Subnet;
        private System.Windows.Forms.ListBox lb_Broadcast;
        private System.Windows.Forms.Label lbl_UltimoHost;
        private System.Windows.Forms.ListBox lb_UltimoHost;
        private System.Windows.Forms.Label lbl_PrimoHost;
        private System.Windows.Forms.ListBox lb_DG;
        private System.Windows.Forms.ListBox lb_PrimoHost;
        private System.Windows.Forms.TextBox txtb_CIDR;
        private System.Windows.Forms.Label lbl_DG;
        private System.Windows.Forms.Label lbl_Broadcast;
    }
}

