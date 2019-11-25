namespace CapoSupremoIP
{
    partial class ExistingOrders
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
            this.lblPendingOrders = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPendingOrders
            // 
            this.lblPendingOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingOrders.Location = new System.Drawing.Point(224, 19);
            this.lblPendingOrders.Name = "lblPendingOrders";
            this.lblPendingOrders.Size = new System.Drawing.Size(390, 66);
            this.lblPendingOrders.TabIndex = 1;
            this.lblPendingOrders.Text = " Pending Orders";
            // 
            // ExistingOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapoSupremoIP.Properties.Resources._75588239_574488233367148_6902869144618663936_n;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPendingOrders);
            this.Name = "ExistingOrders";
            this.Text = "Existing Orders";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExistingOrders_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPendingOrders;
    }
}