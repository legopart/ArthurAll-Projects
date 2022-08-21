namespace winform_flights
{
    partial class frmFlightPassangers
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgrdPassengers = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.txtNameUpdate = new System.Windows.Forms.TextBox();
            this.txtAgeUpdate = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.chkUseMySQL = new System.Windows.Forms.CheckBox();
            this.chkUseMongoDB = new System.Windows.Forms.CheckBox();
            this.rbtnMysql = new System.Windows.Forms.RadioButton();
            this.rbtnMongoDB = new System.Windows.Forms.RadioButton();
            this.lblUpdateName = new System.Windows.Forms.Label();
            this.lblUpdateAge = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdPassengers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(51, 203);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "name";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(51, 227);
            this.txt_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(162, 27);
            this.txt_name.TabIndex = 1;
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(51, 282);
            this.txt_age.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(71, 27);
            this.txt_age.TabIndex = 2;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(51, 258);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(34, 20);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "age";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(143, 278);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 31);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgrdPassengers
            // 
            this.dgrdPassengers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdPassengers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.age});
            this.dgrdPassengers.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgrdPassengers.Location = new System.Drawing.Point(387, 78);
            this.dgrdPassengers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgrdPassengers.Name = "dgrdPassengers";
            this.dgrdPassengers.RowHeadersWidth = 51;
            this.dgrdPassengers.RowTemplate.Height = 25;
            this.dgrdPassengers.Size = new System.Drawing.Size(357, 289);
            this.dgrdPassengers.TabIndex = 5;
            this.dgrdPassengers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_passengers_CellClick);
            this.dgrdPassengers.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dataGrid_passengers_CellStateChanged);
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // age
            // 
            this.age.DataPropertyName = "age";
            this.age.HeaderText = "age";
            this.age.MinimumWidth = 6;
            this.age.Name = "age";
            this.age.Width = 125;
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.Location = new System.Drawing.Point(416, 401);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(142, 29);
            this.btnDeleteSelected.TabIndex = 7;
            this.btnDeleteSelected.Text = "Delete Selected";
            this.btnDeleteSelected.UseVisualStyleBackColor = true;
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // txtNameUpdate
            // 
            this.txtNameUpdate.Location = new System.Drawing.Point(44, 74);
            this.txtNameUpdate.Name = "txtNameUpdate";
            this.txtNameUpdate.Size = new System.Drawing.Size(169, 27);
            this.txtNameUpdate.TabIndex = 8;
            // 
            // txtAgeUpdate
            // 
            this.txtAgeUpdate.Location = new System.Drawing.Point(44, 126);
            this.txtAgeUpdate.Name = "txtAgeUpdate";
            this.txtAgeUpdate.Size = new System.Drawing.Size(78, 27);
            this.txtAgeUpdate.TabIndex = 9;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(135, 124);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // chkUseMySQL
            // 
            this.chkUseMySQL.AutoCheck = false;
            this.chkUseMySQL.AutoSize = true;
            this.chkUseMySQL.Enabled = false;
            this.chkUseMySQL.Location = new System.Drawing.Point(27, 373);
            this.chkUseMySQL.Name = "chkUseMySQL";
            this.chkUseMySQL.Size = new System.Drawing.Size(149, 24);
            this.chkUseMySQL.TabIndex = 11;
            this.chkUseMySQL.Text = "השתמש ב MySQL";
            this.chkUseMySQL.UseVisualStyleBackColor = true;
            // 
            // chkUseMongoDB
            // 
            this.chkUseMongoDB.AutoCheck = false;
            this.chkUseMongoDB.AutoSize = true;
            this.chkUseMongoDB.Checked = true;
            this.chkUseMongoDB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseMongoDB.Location = new System.Drawing.Point(182, 373);
            this.chkUseMongoDB.Name = "chkUseMongoDB";
            this.chkUseMongoDB.Size = new System.Drawing.Size(171, 24);
            this.chkUseMongoDB.TabIndex = 12;
            this.chkUseMongoDB.Text = "השתמש ב MongoDB";
            this.chkUseMongoDB.UseVisualStyleBackColor = true;
            // 
            // rbtnMysql
            // 
            this.rbtnMysql.AutoSize = true;
            this.rbtnMysql.Enabled = false;
            this.rbtnMysql.Location = new System.Drawing.Point(626, 386);
            this.rbtnMysql.Name = "rbtnMysql";
            this.rbtnMysql.Size = new System.Drawing.Size(118, 24);
            this.rbtnMysql.TabIndex = 13;
            this.rbtnMysql.TabStop = true;
            this.rbtnMysql.Text = "טבלת MySQL";
            this.rbtnMysql.UseVisualStyleBackColor = true;
            // 
            // rbtnMongoDB
            // 
            this.rbtnMongoDB.AutoSize = true;
            this.rbtnMongoDB.Checked = true;
            this.rbtnMongoDB.Location = new System.Drawing.Point(626, 416);
            this.rbtnMongoDB.Name = "rbtnMongoDB";
            this.rbtnMongoDB.Size = new System.Drawing.Size(140, 24);
            this.rbtnMongoDB.TabIndex = 14;
            this.rbtnMongoDB.TabStop = true;
            this.rbtnMongoDB.Text = "טבלת MongoDB";
            this.rbtnMongoDB.UseVisualStyleBackColor = true;
            // 
            // lblUpdateName
            // 
            this.lblUpdateName.AutoSize = true;
            this.lblUpdateName.Location = new System.Drawing.Point(44, 51);
            this.lblUpdateName.Name = "lblUpdateName";
            this.lblUpdateName.Size = new System.Drawing.Size(97, 20);
            this.lblUpdateName.TabIndex = 15;
            this.lblUpdateName.Text = "update name";
            // 
            // lblUpdateAge
            // 
            this.lblUpdateAge.AutoSize = true;
            this.lblUpdateAge.Location = new System.Drawing.Point(44, 103);
            this.lblUpdateAge.Name = "lblUpdateAge";
            this.lblUpdateAge.Size = new System.Drawing.Size(85, 20);
            this.lblUpdateAge.TabIndex = 16;
            this.lblUpdateAge.Text = "update age";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(750, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 62);
            this.button1.TabIndex = 17;
            this.button1.Text = "התקן ל Mysql";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(750, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 62);
            this.button2.TabIndex = 18;
            this.button2.Text = "התקן ל MongoDB";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmFlightPassangers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblUpdateAge);
            this.Controls.Add(this.lblUpdateName);
            this.Controls.Add(this.rbtnMongoDB);
            this.Controls.Add(this.rbtnMysql);
            this.Controls.Add(this.chkUseMongoDB);
            this.Controls.Add(this.chkUseMySQL);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtAgeUpdate);
            this.Controls.Add(this.txtNameUpdate);
            this.Controls.Add(this.btnDeleteSelected);
            this.Controls.Add(this.dgrdPassengers);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmFlightPassangers";
            this.Text = "Flight Passangers";
            ((System.ComponentModel.ISupportInitialize)(this.dgrdPassengers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgrdPassengers;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.TextBox txtNameUpdate;
        private System.Windows.Forms.TextBox txtAgeUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.CheckBox chkUseMySQL;
        private System.Windows.Forms.CheckBox chkUseMongoDB;
        private System.Windows.Forms.RadioButton rbtnMysql;
        private System.Windows.Forms.RadioButton rbtnMongoDB;
        private System.Windows.Forms.Label lblUpdateName;
        private System.Windows.Forms.Label lblUpdateAge;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
