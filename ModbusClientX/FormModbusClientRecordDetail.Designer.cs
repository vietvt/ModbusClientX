namespace ModbusClientX
{
    partial class FormModbusClientRecordDetail
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
            this.propertyGridModbusDetail = new System.Windows.Forms.PropertyGrid();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // propertyGridModbusDetail
            // 
            this.propertyGridModbusDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGridModbusDetail.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertyGridModbusDetail.Location = new System.Drawing.Point(12, 12);
            this.propertyGridModbusDetail.Name = "propertyGridModbusDetail";
            this.propertyGridModbusDetail.PropertySort = System.Windows.Forms.PropertySort.Categorized;
            this.propertyGridModbusDetail.Size = new System.Drawing.Size(409, 334);
            this.propertyGridModbusDetail.TabIndex = 74;
            this.propertyGridModbusDetail.ToolbarVisible = false;
            this.propertyGridModbusDetail.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGridModbusDetail_PropertyValueChanged);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(120, 352);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 34);
            this.btnClose.TabIndex = 75;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnWrite.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnWrite.Enabled = false;
            this.btnWrite.Location = new System.Drawing.Point(12, 352);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(102, 34);
            this.btnWrite.TabIndex = 76;
            this.btnWrite.Text = "Write to Device";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // FormModbusClientRecordDetail
            // 
            this.AcceptButton = this.btnWrite;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(433, 398);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.propertyGridModbusDetail);
            this.Name = "FormModbusClientRecordDetail";
            this.Text = "Modbus Client Record Detail";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormModbusClientRecordDetail_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PropertyGrid propertyGridModbusDetail;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnWrite;
    }
}