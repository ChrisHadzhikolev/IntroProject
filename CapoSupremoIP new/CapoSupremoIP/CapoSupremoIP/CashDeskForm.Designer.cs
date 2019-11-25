namespace CapoSupremoIP
{
    partial class CashDeskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashDeskForm));
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.btnExistingOrders = new System.Windows.Forms.Button();
            this.lblTitleCashDesk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewOrder.BackgroundImage")));
            this.btnNewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnNewOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNewOrder.Location = new System.Drawing.Point(225, 116);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(350, 113);
            this.btnNewOrder.TabIndex = 2;
            this.btnNewOrder.Text = "New Order";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // btnExistingOrders
            // 
            this.btnExistingOrders.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExistingOrders.BackgroundImage")));
            this.btnExistingOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnExistingOrders.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExistingOrders.Location = new System.Drawing.Point(225, 275);
            this.btnExistingOrders.Name = "btnExistingOrders";
            this.btnExistingOrders.Size = new System.Drawing.Size(350, 113);
            this.btnExistingOrders.TabIndex = 3;
            this.btnExistingOrders.Text = "Existing Orders";
            this.btnExistingOrders.UseVisualStyleBackColor = true;
            this.btnExistingOrders.Click += new System.EventHandler(this.btnExistingOrders_Click);
            // 
            // lblTitleCashDesk
            // 
            this.lblTitleCashDesk.AutoSize = true;
            this.lblTitleCashDesk.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleCashDesk.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblTitleCashDesk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitleCashDesk.Location = new System.Drawing.Point(177, 41);
            this.lblTitleCashDesk.Name = "lblTitleCashDesk";
            this.lblTitleCashDesk.Size = new System.Drawing.Size(442, 46);
            this.lblTitleCashDesk.TabIndex = 4;
            this.lblTitleCashDesk.Text = "Capo Supremo Pizzeria";
            // 
            // CashDeskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapoSupremoIP.Properties.Resources._75588239_574488233367148_6902869144618663936_n;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitleCashDesk);
            this.Controls.Add(this.btnExistingOrders);
            this.Controls.Add(this.btnNewOrder);
            this.Name = "CashDeskForm";
            this.Text = "CashDeskForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CashDeskForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Button btnExistingOrders;
        private System.Windows.Forms.Label lblTitleCashDesk;
    }
}