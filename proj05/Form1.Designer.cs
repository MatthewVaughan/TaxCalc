namespace proj05
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNumUnits = new System.Windows.Forms.Label();
            this.lblNumPrice = new System.Windows.Forms.Label();
            this.txtNumItems = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(448, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblNumUnits
            // 
            this.lblNumUnits.AutoSize = true;
            this.lblNumUnits.Location = new System.Drawing.Point(77, 97);
            this.lblNumUnits.Name = "lblNumUnits";
            this.lblNumUnits.Size = new System.Drawing.Size(114, 17);
            this.lblNumUnits.TabIndex = 1;
            this.lblNumUnits.Text = "Number of Units:";
            // 
            // lblNumPrice
            // 
            this.lblNumPrice.AutoSize = true;
            this.lblNumPrice.Location = new System.Drawing.Point(77, 127);
            this.lblNumPrice.Name = "lblNumPrice";
            this.lblNumPrice.Size = new System.Drawing.Size(73, 17);
            this.lblNumPrice.TabIndex = 2;
            this.lblNumPrice.Text = "Unit Price:";
            // 
            // txtNumItems
            // 
            this.txtNumItems.Location = new System.Drawing.Point(223, 91);
            this.txtNumItems.Name = "txtNumItems";
            this.txtNumItems.Size = new System.Drawing.Size(100, 22);
            this.txtNumItems.TabIndex = 3;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(223, 127);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(100, 22);
            this.txtUnitPrice.TabIndex = 4;
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(80, 183);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(95, 42);
            this.BtnClear.TabIndex = 5;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(223, 183);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(105, 42);
            this.BtnCalculate.TabIndex = 6;
            this.BtnCalculate.Text = "Buy";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 386);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtNumItems);
            this.Controls.Add(this.lblNumPrice);
            this.Controls.Add(this.lblNumUnits);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Sale Calculater";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblNumUnits;
        private System.Windows.Forms.Label lblNumPrice;
        private System.Windows.Forms.TextBox txtNumItems;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnCalculate;
    }
}

