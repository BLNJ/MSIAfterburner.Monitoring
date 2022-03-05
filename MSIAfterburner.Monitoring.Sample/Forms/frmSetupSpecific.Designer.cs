namespace MSIAfterburner.Monitoring.Sample.Forms
{
    partial class frmSetupSpecific
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
            this.btnValuesSet = new System.Windows.Forms.Button();
            this.numSensorValue = new System.Windows.Forms.NumericUpDown();
            this.txtSensorName = new System.Windows.Forms.TextBox();
            this.lblSensorValue = new System.Windows.Forms.Label();
            this.lblSensorName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numSensorValue)).BeginInit();
            this.SuspendLayout();
            // 
            // btnValuesSet
            // 
            this.btnValuesSet.Location = new System.Drawing.Point(100, 87);
            this.btnValuesSet.Name = "btnValuesSet";
            this.btnValuesSet.Size = new System.Drawing.Size(75, 23);
            this.btnValuesSet.TabIndex = 18;
            this.btnValuesSet.Text = "Set";
            this.btnValuesSet.UseVisualStyleBackColor = true;
            this.btnValuesSet.Click += new System.EventHandler(this.btnValuesSet_Click);
            // 
            // numSensorValue
            // 
            this.numSensorValue.Location = new System.Drawing.Point(100, 43);
            this.numSensorValue.Name = "numSensorValue";
            this.numSensorValue.Size = new System.Drawing.Size(127, 20);
            this.numSensorValue.TabIndex = 17;
            // 
            // txtSensorName
            // 
            this.txtSensorName.Location = new System.Drawing.Point(100, 6);
            this.txtSensorName.MaxLength = 260;
            this.txtSensorName.Name = "txtSensorName";
            this.txtSensorName.Size = new System.Drawing.Size(127, 20);
            this.txtSensorName.TabIndex = 16;
            // 
            // lblSensorValue
            // 
            this.lblSensorValue.AutoSize = true;
            this.lblSensorValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSensorValue.Location = new System.Drawing.Point(12, 45);
            this.lblSensorValue.Name = "lblSensorValue";
            this.lblSensorValue.Size = new System.Drawing.Size(82, 13);
            this.lblSensorValue.TabIndex = 15;
            this.lblSensorValue.Text = "SensorValue:";
            // 
            // lblSensorName
            // 
            this.lblSensorName.AutoSize = true;
            this.lblSensorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSensorName.Location = new System.Drawing.Point(12, 9);
            this.lblSensorName.Name = "lblSensorName";
            this.lblSensorName.Size = new System.Drawing.Size(82, 13);
            this.lblSensorName.TabIndex = 14;
            this.lblSensorName.Text = "SensorName:";
            // 
            // frmSetupSpecific
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 125);
            this.Controls.Add(this.btnValuesSet);
            this.Controls.Add(this.numSensorValue);
            this.Controls.Add(this.txtSensorName);
            this.Controls.Add(this.lblSensorValue);
            this.Controls.Add(this.lblSensorName);
            this.Name = "frmSetupSpecific";
            this.Text = "frmSetupSpecific";
            ((System.ComponentModel.ISupportInitialize)(this.numSensorValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValuesSet;
        private System.Windows.Forms.NumericUpDown numSensorValue;
        private System.Windows.Forms.TextBox txtSensorName;
        private System.Windows.Forms.Label lblSensorValue;
        private System.Windows.Forms.Label lblSensorName;
    }
}