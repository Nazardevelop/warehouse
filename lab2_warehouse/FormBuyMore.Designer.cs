namespace lab2_warehouse
{
    partial class FormBuyMore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuyMore));
            this.tBShname = new System.Windows.Forms.TextBox();
            this.cBpartner = new System.Windows.Forms.ComboBox();
            this.nUDamount = new System.Windows.Forms.NumericUpDown();
            this.lbloldShip = new System.Windows.Forms.Label();
            this.lblNUm = new System.Windows.Forms.Label();
            this.lblPartner = new System.Windows.Forms.Label();
            this.btnBuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUDamount)).BeginInit();
            this.SuspendLayout();
            // 
            // tBShname
            // 
            this.tBShname.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBShname.Location = new System.Drawing.Point(12, 70);
            this.tBShname.Name = "tBShname";
            this.tBShname.Size = new System.Drawing.Size(100, 33);
            this.tBShname.TabIndex = 0;
            // 
            // cBpartner
            // 
            this.cBpartner.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBpartner.FormattingEnabled = true;
            this.cBpartner.Location = new System.Drawing.Point(214, 69);
            this.cBpartner.Name = "cBpartner";
            this.cBpartner.Size = new System.Drawing.Size(121, 34);
            this.cBpartner.TabIndex = 1;
            // 
            // nUDamount
            // 
            this.nUDamount.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nUDamount.Location = new System.Drawing.Point(12, 167);
            this.nUDamount.Name = "nUDamount";
            this.nUDamount.Size = new System.Drawing.Size(120, 33);
            this.nUDamount.TabIndex = 2;
            // 
            // lbloldShip
            // 
            this.lbloldShip.AutoSize = true;
            this.lbloldShip.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbloldShip.Location = new System.Drawing.Point(7, 27);
            this.lbloldShip.Name = "lbloldShip";
            this.lbloldShip.Size = new System.Drawing.Size(120, 26);
            this.lbloldShip.TabIndex = 3;
            this.lbloldShip.Text = "Shipment";
            // 
            // lblNUm
            // 
            this.lblNUm.AutoSize = true;
            this.lblNUm.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNUm.Location = new System.Drawing.Point(28, 128);
            this.lblNUm.Name = "lblNUm";
            this.lblNUm.Size = new System.Drawing.Size(99, 26);
            this.lblNUm.TabIndex = 4;
            this.lblNUm.Text = "Amount";
            // 
            // lblPartner
            // 
            this.lblPartner.AutoSize = true;
            this.lblPartner.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPartner.Location = new System.Drawing.Point(181, 27);
            this.lblPartner.Name = "lblPartner";
            this.lblPartner.Size = new System.Drawing.Size(189, 26);
            this.lblPartner.TabIndex = 5;
            this.lblPartner.Text = "Choose Partner";
            // 
            // btnBuy
            // 
            this.btnBuy.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBuy.Location = new System.Drawing.Point(273, 167);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(75, 33);
            this.btnBuy.TabIndex = 6;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // FormBuyMore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lab2_warehouse.Properties.Resources.saletrue;
            this.ClientSize = new System.Drawing.Size(382, 262);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.lblPartner);
            this.Controls.Add(this.lblNUm);
            this.Controls.Add(this.lbloldShip);
            this.Controls.Add(this.nUDamount);
            this.Controls.Add(this.cBpartner);
            this.Controls.Add(this.tBShname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBuyMore";
            this.Text = "Buy More";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBuyMore_FormClosing);
            this.Load += new System.EventHandler(this.FormBuyMore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUDamount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBShname;
        private System.Windows.Forms.ComboBox cBpartner;
        private System.Windows.Forms.NumericUpDown nUDamount;
        private System.Windows.Forms.Label lbloldShip;
        private System.Windows.Forms.Label lblNUm;
        private System.Windows.Forms.Label lblPartner;
        private System.Windows.Forms.Button btnBuy;
    }
}