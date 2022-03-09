
namespace AS2122_4E_INF_UbalducciMattia_Pizzeria
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblScelta = new System.Windows.Forms.Label();
            this.lblQuantità = new System.Windows.Forms.Label();
            this.lblTotaleVerdura = new System.Windows.Forms.Label();
            this.lblPizzeMargherita = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRiepilogo = new System.Windows.Forms.Label();
            this.lblTotaleStagioni = new System.Windows.Forms.Label();
            this.cmbScelta = new System.Windows.Forms.ComboBox();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.lstVisualizza = new System.Windows.Forms.ListBox();
            this.txtQuantità = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblScelta
            // 
            this.lblScelta.AutoSize = true;
            this.lblScelta.Location = new System.Drawing.Point(62, 92);
            this.lblScelta.Name = "lblScelta";
            this.lblScelta.Size = new System.Drawing.Size(106, 15);
            this.lblScelta.TabIndex = 0;
            this.lblScelta.Text = "Che pizza desideri?";
            // 
            // lblQuantità
            // 
            this.lblQuantità.AutoSize = true;
            this.lblQuantità.Location = new System.Drawing.Point(62, 148);
            this.lblQuantità.Name = "lblQuantità";
            this.lblQuantità.Size = new System.Drawing.Size(56, 15);
            this.lblQuantità.TabIndex = 1;
            this.lblQuantità.Text = "Quantità:";
            this.lblQuantità.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTotaleVerdura
            // 
            this.lblTotaleVerdura.AutoSize = true;
            this.lblTotaleVerdura.Location = new System.Drawing.Point(535, 299);
            this.lblTotaleVerdura.Name = "lblTotaleVerdura";
            this.lblTotaleVerdura.Size = new System.Drawing.Size(136, 15);
            this.lblTotaleVerdura.TabIndex = 3;
            this.lblTotaleVerdura.Text = "Totale pizze con verdura:";
            this.lblTotaleVerdura.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblPizzeMargherita
            // 
            this.lblPizzeMargherita.AutoSize = true;
            this.lblPizzeMargherita.Location = new System.Drawing.Point(535, 252);
            this.lblPizzeMargherita.Name = "lblPizzeMargherita";
            this.lblPizzeMargherita.Size = new System.Drawing.Size(131, 15);
            this.lblPizzeMargherita.TabIndex = 2;
            this.lblPizzeMargherita.Text = "Totale pizze margherite:";
            this.lblPizzeMargherita.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 0;
            // 
            // lblRiepilogo
            // 
            this.lblRiepilogo.AutoSize = true;
            this.lblRiepilogo.Location = new System.Drawing.Point(536, 50);
            this.lblRiepilogo.Name = "lblRiepilogo";
            this.lblRiepilogo.Size = new System.Drawing.Size(60, 15);
            this.lblRiepilogo.TabIndex = 4;
            this.lblRiepilogo.Text = "Riepilogo:";
            // 
            // lblTotaleStagioni
            // 
            this.lblTotaleStagioni.AutoSize = true;
            this.lblTotaleStagioni.Location = new System.Drawing.Point(535, 346);
            this.lblTotaleStagioni.Name = "lblTotaleStagioni";
            this.lblTotaleStagioni.Size = new System.Drawing.Size(124, 15);
            this.lblTotaleStagioni.TabIndex = 5;
            this.lblTotaleStagioni.Text = "Totale pizze 4 stagioni:";
            // 
            // cmbScelta
            // 
            this.cmbScelta.FormattingEnabled = true;
            this.cmbScelta.Items.AddRange(new object[] {
            "margherita",
            "vedure",
            "4 stagioni"});
            this.cmbScelta.Location = new System.Drawing.Point(196, 92);
            this.cmbScelta.Name = "cmbScelta";
            this.cmbScelta.Size = new System.Drawing.Size(121, 23);
            this.cmbScelta.TabIndex = 6;
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(337, 80);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(116, 39);
            this.btnAggiungi.TabIndex = 7;
            this.btnAggiungi.Text = "AGGIUNGI";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            // 
            // lstVisualizza
            // 
            this.lstVisualizza.FormattingEnabled = true;
            this.lstVisualizza.ItemHeight = 15;
            this.lstVisualizza.Location = new System.Drawing.Point(535, 80);
            this.lstVisualizza.Name = "lstVisualizza";
            this.lstVisualizza.Size = new System.Drawing.Size(120, 94);
            this.lstVisualizza.TabIndex = 8;
            // 
            // txtQuantità
            // 
            this.txtQuantità.Location = new System.Drawing.Point(196, 145);
            this.txtQuantità.Name = "txtQuantità";
            this.txtQuantità.Size = new System.Drawing.Size(73, 23);
            this.txtQuantità.TabIndex = 9;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtQuantità);
            this.Controls.Add(this.lstVisualizza);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.cmbScelta);
            this.Controls.Add(this.lblTotaleStagioni);
            this.Controls.Add(this.lblRiepilogo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTotaleVerdura);
            this.Controls.Add(this.lblPizzeMargherita);
            this.Controls.Add(this.lblQuantità);
            this.Controls.Add(this.lblScelta);
            this.Name = "frmMain";
            this.Text = "Ubalducci Mattia;lab2.2;4E;Gestione pizzeria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScelta;
        private System.Windows.Forms.Label lblQuantità;
        private System.Windows.Forms.Label lblTotaleVerdura;
        private System.Windows.Forms.Label lblPizzeMargherita;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRiepilogo;
        private System.Windows.Forms.Label lblTotaleStagioni;
        private System.Windows.Forms.ComboBox cmbScelta;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.ListBox lstVisualizza;
        private System.Windows.Forms.TextBox txtQuantità;
    }
}

