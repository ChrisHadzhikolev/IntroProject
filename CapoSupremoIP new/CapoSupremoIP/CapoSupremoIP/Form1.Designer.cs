namespace CapoSupremoIP
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnKitchen = new System.Windows.Forms.Button();
            this.btnCashDesk = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKitchen
            // 
            this.btnKitchen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKitchen.BackgroundImage")));
            this.btnKitchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnKitchen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKitchen.Location = new System.Drawing.Point(221, 123);
            this.btnKitchen.Name = "btnKitchen";
            this.btnKitchen.Size = new System.Drawing.Size(350, 113);
            this.btnKitchen.TabIndex = 1;
            this.btnKitchen.Text = "Kitchen";
            this.btnKitchen.UseVisualStyleBackColor = true;
            this.btnKitchen.Click += new System.EventHandler(this.btnKitchen_Click);
            // 
            // btnCashDesk
            // 
            this.btnCashDesk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCashDesk.BackgroundImage")));
            this.btnCashDesk.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnCashDesk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCashDesk.Location = new System.Drawing.Point(221, 272);
            this.btnCashDesk.Name = "btnCashDesk";
            this.btnCashDesk.Size = new System.Drawing.Size(350, 113);
            this.btnCashDesk.TabIndex = 2;
            this.btnCashDesk.Text = "Cash Desk";
            this.btnCashDesk.UseVisualStyleBackColor = true;
            this.btnCashDesk.Click += new System.EventHandler(this.btnCashDesk_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(175, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(442, 46);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Capo Supremo Pizzeria";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapoSupremoIP.Properties.Resources._75588239_574488233367148_6902869144618663936_n;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCashDesk);
            this.Controls.Add(this.btnKitchen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnKitchen;
        private System.Windows.Forms.Button btnCashDesk;
        private System.Windows.Forms.Label lblTitle;
    }
}

