namespace lab2_warehouse
{
    partial class FormResources
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResources));
            this.lBres = new System.Windows.Forms.ListBox();
            this.btnthrowaway = new System.Windows.Forms.Button();
            this.btnsale = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lBres
            // 
            this.lBres.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lBres.FormattingEnabled = true;
            this.lBres.ItemHeight = 20;
            this.lBres.Location = new System.Drawing.Point(99, 28);
            this.lBres.Name = "lBres";
            this.lBres.Size = new System.Drawing.Size(188, 184);
            this.lBres.TabIndex = 0;
            this.lBres.SelectedIndexChanged += new System.EventHandler(this.lBres_SelectedIndexChanged);
            // 
            // btnthrowaway
            // 
            this.btnthrowaway.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnthrowaway.Location = new System.Drawing.Point(64, 218);
            this.btnthrowaway.Name = "btnthrowaway";
            this.btnthrowaway.Size = new System.Drawing.Size(153, 41);
            this.btnthrowaway.TabIndex = 1;
            this.btnthrowaway.Text = "throw away";
            this.btnthrowaway.UseVisualStyleBackColor = true;
            this.btnthrowaway.Click += new System.EventHandler(this.btnthrowaway_Click);
            // 
            // btnsale
            // 
            this.btnsale.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnsale.Location = new System.Drawing.Point(223, 218);
            this.btnsale.Name = "btnsale";
            this.btnsale.Size = new System.Drawing.Size(75, 41);
            this.btnsale.TabIndex = 2;
            this.btnsale.Text = "Sale";
            this.btnsale.UseVisualStyleBackColor = true;
            this.btnsale.Click += new System.EventHandler(this.btnsale_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBuy.Location = new System.Drawing.Point(300, 28);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(75, 41);
            this.btnBuy.TabIndex = 3;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // FormResources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lab2_warehouse.Properties.Resources.buy1;
            this.ClientSize = new System.Drawing.Size(387, 262);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnsale);
            this.Controls.Add(this.btnthrowaway);
            this.Controls.Add(this.lBres);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormResources";
            this.Text = "Resources";
            this.Load += new System.EventHandler(this.FormResources_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lBres;
        private System.Windows.Forms.Button btnthrowaway;
        private System.Windows.Forms.Button btnsale;
        private System.Windows.Forms.Button btnBuy;
    }
}