namespace lab2_warehouse
{
    partial class FormBuy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuy));
            this.btnAddshipment = new System.Windows.Forms.Button();
            this.lblshname = new System.Windows.Forms.Label();
            this.tBproduct = new System.Windows.Forms.TextBox();
            this.lblChorg = new System.Windows.Forms.Label();
            this.cBpartner = new System.Windows.Forms.ComboBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.nUDamount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nUDamount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddshipment
            // 
            this.btnAddshipment.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddshipment.Location = new System.Drawing.Point(309, 228);
            this.btnAddshipment.Name = "btnAddshipment";
            this.btnAddshipment.Size = new System.Drawing.Size(75, 34);
            this.btnAddshipment.TabIndex = 0;
            this.btnAddshipment.Text = "BUY";
            this.btnAddshipment.UseVisualStyleBackColor = true;
            this.btnAddshipment.Click += new System.EventHandler(this.btnAddshipment_Click);
            // 
            // lblshname
            // 
            this.lblshname.AutoSize = true;
            this.lblshname.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblshname.Location = new System.Drawing.Point(0, 9);
            this.lblshname.Name = "lblshname";
            this.lblshname.Size = new System.Drawing.Size(160, 20);
            this.lblshname.TabIndex = 1;
            this.lblshname.Text = "Name of product";
            // 
            // tBproduct
            // 
            this.tBproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBproduct.Location = new System.Drawing.Point(4, 32);
            this.tBproduct.Name = "tBproduct";
            this.tBproduct.Size = new System.Drawing.Size(100, 26);
            this.tBproduct.TabIndex = 2;
            // 
            // lblChorg
            // 
            this.lblChorg.AutoSize = true;
            this.lblChorg.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChorg.Location = new System.Drawing.Point(190, 9);
            this.lblChorg.Name = "lblChorg";
            this.lblChorg.Size = new System.Drawing.Size(155, 20);
            this.lblChorg.TabIndex = 3;
            this.lblChorg.Text = "Chose a partner";
            // 
            // cBpartner
            // 
            this.cBpartner.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBpartner.FormattingEnabled = true;
            this.cBpartner.Location = new System.Drawing.Point(208, 32);
            this.cBpartner.Name = "cBpartner";
            this.cBpartner.Size = new System.Drawing.Size(121, 28);
            this.cBpartner.TabIndex = 4;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAmount.Location = new System.Drawing.Point(0, 84);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(78, 20);
            this.lblAmount.TabIndex = 5;
            this.lblAmount.Text = "Amount";
            // 
            // nUDamount
            // 
            this.nUDamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nUDamount.Location = new System.Drawing.Point(4, 121);
            this.nUDamount.Name = "nUDamount";
            this.nUDamount.Size = new System.Drawing.Size(120, 26);
            this.nUDamount.TabIndex = 7;
            // 
            // FormBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lab2_warehouse.Properties.Resources.buy;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.nUDamount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.cBpartner);
            this.Controls.Add(this.lblChorg);
            this.Controls.Add(this.tBproduct);
            this.Controls.Add(this.lblshname);
            this.Controls.Add(this.btnAddshipment);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBuy";
            this.Text = "Buy";
            this.Load += new System.EventHandler(this.FormBuy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUDamount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddshipment;
        private System.Windows.Forms.Label lblshname;
        private System.Windows.Forms.TextBox tBproduct;
        private System.Windows.Forms.Label lblChorg;
        private System.Windows.Forms.ComboBox cBpartner;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.NumericUpDown nUDamount;
    }
}