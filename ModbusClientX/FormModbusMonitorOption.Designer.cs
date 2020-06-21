namespace ModbusClientX
{
    partial class FormModbusMonitorOption
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
            this.propertyGridOption = new System.Windows.Forms.PropertyGrid();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openOptionFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveOptionFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // propertyGridOption
            // 
            this.propertyGridOption.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGridOption.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertyGridOption.Location = new System.Drawing.Point(9, 27);
            this.propertyGridOption.Name = "propertyGridOption";
            this.propertyGridOption.Size = new System.Drawing.Size(645, 205);
            this.propertyGridOption.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(117, 248);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 34);
            this.btnCancel.TabIndex = 79;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(9, 248);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(102, 34);
            this.btnOk.TabIndex = 78;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "*.json";
            this.saveFileDialog1.FileName = "DefaultModbusOption";
            this.saveFileDialog1.Filter = "Modbus Monitor Option File|*.json";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "*.Json";
            this.openFileDialog1.FileName = "DefaultModbusOption";
            this.openFileDialog1.Filter = "Modbus Monitor Option File|*.json";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(666, 24);
            this.menuStrip1.TabIndex = 80;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openOptionFileToolStripMenuItem,
            this.saveOptionFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openOptionFileToolStripMenuItem
            // 
            this.openOptionFileToolStripMenuItem.Name = "openOptionFileToolStripMenuItem";
            this.openOptionFileToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.openOptionFileToolStripMenuItem.Text = "&Open Option File";
            this.openOptionFileToolStripMenuItem.Click += new System.EventHandler(this.openOptionFileToolStripMenuItem_Click);
            // 
            // saveOptionFileToolStripMenuItem
            // 
            this.saveOptionFileToolStripMenuItem.Name = "saveOptionFileToolStripMenuItem";
            this.saveOptionFileToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.saveOptionFileToolStripMenuItem.Text = "&Save Option File";
            this.saveOptionFileToolStripMenuItem.Click += new System.EventHandler(this.saveOptionFileToolStripMenuItem_Click);
            // 
            // FormModbusMonitorOption
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(666, 306);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.propertyGridOption);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormModbusMonitorOption";
            this.Text = "Modbus Monitor Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormModbusMonitorOption_FormClosing);
            this.Load += new System.EventHandler(this.FormModbusMonitorOption_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PropertyGrid propertyGridOption;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openOptionFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveOptionFileToolStripMenuItem;
    }
}