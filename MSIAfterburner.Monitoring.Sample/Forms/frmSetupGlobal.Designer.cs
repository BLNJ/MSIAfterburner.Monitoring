namespace MSIAfterburner.Monitoring.Sample.Forms
{
    partial class frmSetupGlobal
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
            this.listKeys = new System.Windows.Forms.ListView();
            this.colKeysName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colKeysValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnValuesSet = new System.Windows.Forms.Button();
            this.numSensorValue = new System.Windows.Forms.NumericUpDown();
            this.txtSensorName = new System.Windows.Forms.TextBox();
            this.lblSensorValue = new System.Windows.Forms.Label();
            this.lblSensorName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSensorValue)).BeginInit();
            this.SuspendLayout();
            // 
            // listKeys
            // 
            this.listKeys.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colKeysName,
            this.colKeysValue});
            this.listKeys.FullRowSelect = true;
            this.listKeys.GridLines = true;
            this.listKeys.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listKeys.HideSelection = false;
            this.listKeys.LabelWrap = false;
            this.listKeys.Location = new System.Drawing.Point(12, 12);
            this.listKeys.MultiSelect = false;
            this.listKeys.Name = "listKeys";
            this.listKeys.ShowGroups = false;
            this.listKeys.Size = new System.Drawing.Size(175, 278);
            this.listKeys.TabIndex = 0;
            this.listKeys.UseCompatibleStateImageBehavior = false;
            this.listKeys.View = System.Windows.Forms.View.Details;
            this.listKeys.SelectedIndexChanged += new System.EventHandler(this.listKeys_SelectedIndexChanged);
            // 
            // colKeysName
            // 
            this.colKeysName.Text = "Name";
            this.colKeysName.Width = 105;
            // 
            // colKeysValue
            // 
            this.colKeysValue.Text = "Value";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 296);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(58, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(119, 296);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(68, 23);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnValuesSet);
            this.groupBox1.Controls.Add(this.numSensorValue);
            this.groupBox1.Controls.Add(this.txtSensorName);
            this.groupBox1.Controls.Add(this.lblSensorValue);
            this.groupBox1.Controls.Add(this.lblSensorName);
            this.groupBox1.Location = new System.Drawing.Point(193, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 206);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnValuesSet
            // 
            this.btnValuesSet.Location = new System.Drawing.Point(129, 132);
            this.btnValuesSet.Name = "btnValuesSet";
            this.btnValuesSet.Size = new System.Drawing.Size(75, 23);
            this.btnValuesSet.TabIndex = 13;
            this.btnValuesSet.Text = "Set";
            this.btnValuesSet.UseVisualStyleBackColor = true;
            this.btnValuesSet.Click += new System.EventHandler(this.btnValuesSet_Click);
            // 
            // numSensorValue
            // 
            this.numSensorValue.Location = new System.Drawing.Point(129, 88);
            this.numSensorValue.Name = "numSensorValue";
            this.numSensorValue.Size = new System.Drawing.Size(127, 20);
            this.numSensorValue.TabIndex = 12;
            // 
            // txtSensorName
            // 
            this.txtSensorName.Location = new System.Drawing.Point(129, 51);
            this.txtSensorName.MaxLength = 260;
            this.txtSensorName.Name = "txtSensorName";
            this.txtSensorName.Size = new System.Drawing.Size(127, 20);
            this.txtSensorName.TabIndex = 11;
            // 
            // lblSensorValue
            // 
            this.lblSensorValue.AutoSize = true;
            this.lblSensorValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSensorValue.Location = new System.Drawing.Point(41, 90);
            this.lblSensorValue.Name = "lblSensorValue";
            this.lblSensorValue.Size = new System.Drawing.Size(82, 13);
            this.lblSensorValue.TabIndex = 10;
            this.lblSensorValue.Text = "SensorValue:";
            // 
            // lblSensorName
            // 
            this.lblSensorName.AutoSize = true;
            this.lblSensorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSensorName.Location = new System.Drawing.Point(41, 54);
            this.lblSensorName.Name = "lblSensorName";
            this.lblSensorName.Size = new System.Drawing.Size(82, 13);
            this.lblSensorName.TabIndex = 9;
            this.lblSensorName.Text = "SensorName:";
            // 
            // frmSetupGlobal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listKeys);
            this.Name = "frmSetupGlobal";
            this.Text = "frmSetupGlobal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSensorValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listKeys;
        private System.Windows.Forms.ColumnHeader colKeysName;
        private System.Windows.Forms.ColumnHeader colKeysValue;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnValuesSet;
        private System.Windows.Forms.NumericUpDown numSensorValue;
        private System.Windows.Forms.TextBox txtSensorName;
        private System.Windows.Forms.Label lblSensorValue;
        private System.Windows.Forms.Label lblSensorName;
    }
}