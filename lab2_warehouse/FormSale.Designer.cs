namespace lab2_warehouse
{
    partial class FormSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSale));
            this.lblPartner = new System.Windows.Forms.Label();
            this.cbBpartner = new System.Windows.Forms.ComboBox();
            this.nUDamountp = new System.Windows.Forms.NumericUpDown();
            this.btnSale = new System.Windows.Forms.Button();
            this.lblChosesh = new System.Windows.Forms.Label();
            this.lblamount = new System.Windows.Forms.Label();
            this.tBthisSh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nUDamountp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPartner
            // 
            this.lblPartner.AutoSize = true;
            this.lblPartner.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPartner.Location = new System.Drawing.Point(232, 9);
            this.lblPartner.Name = "lblPartner";
            this.lblPartner.Size = new System.Drawing.Size(140, 20);
            this.lblPartner.TabIndex = 0;
            this.lblPartner.Text = "Chose a partner";
            // 
            // cbBpartner
            // 
            this.cbBpartner.FormattingEnabled = true;
            this.cbBpartner.Location = new System.Drawing.Point(236, 44);
            this.cbBpartner.Name = "cbBpartner";
            this.cbBpartner.Size = new System.Drawing.Size(121, 21);
            this.cbBpartner.TabIndex = 1;
            // 
            // nUDamountp
            // 
            this.nUDamountp.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nUDamountp.Location = new System.Drawing.Point(-2, 154);
            this.nUDamountp.Name = "nUDamountp";
            this.nUDamountp.Size = new System.Drawing.Size(120, 27);
            this.nUDamountp.TabIndex = 2;
            // 
            // btnSale
            // 
            this.btnSale.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSale.Location = new System.Drawing.Point(282, 154);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(75, 30);
            this.btnSale.TabIndex = 3;
            this.btnSale.Text = "Sale";
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // lblChosesh
            // 
            this.lblChosesh.AutoSize = true;
            this.lblChosesh.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChosesh.Location = new System.Drawing.Point(12, 9);
            this.lblChosesh.Name = "lblChosesh";
            this.lblChosesh.Size = new System.Drawing.Size(86, 20);
            this.lblChosesh.TabIndex = 5;
            this.lblChosesh.Text = "Shipment";
            // 
            // lblamount
            // 
            this.lblamount.AutoSize = true;
            this.lblamount.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblamount.Location = new System.Drawing.Point(12, 114);
            this.lblamount.Name = "lblamount";
            this.lblamount.Size = new System.Drawing.Size(71, 20);
            this.lblamount.TabIndex = 6;
            this.lblamount.Text = "amount";
            // 
            // tBthisSh
            // 
            this.tBthisSh.Location = new System.Drawing.Point(-2, 32);
            this.tBthisSh.Name = "tBthisSh";
            this.tBthisSh.Size = new System.Drawing.Size(100, 20);
            this.tBthisSh.TabIndex = 7;
            // 
            // FormSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lab2_warehouse.Properties.Resources.saletrue;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.tBthisSh);
            this.Controls.Add(this.lblamount);
            this.Controls.Add(this.lblChosesh);
            this.Controls.Add(this.btnSale);
            this.Controls.Add(this.nUDamountp);
            this.Controls.Add(this.cbBpartner);
            this.Controls.Add(this.lblPartner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSale";
            this.Text = "Sale";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSale_FormClosing);
            this.Load += new System.EventHandler(this.FormSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUDamountp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPartner;
        private System.Windows.Forms.ComboBox cbBpartner;
        private System.Windows.Forms.NumericUpDown nUDamountp;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Label lblChosesh;
        private System.Windows.Forms.Label lblamount;
        private System.Windows.Forms.TextBox tBthisSh;
    }
}