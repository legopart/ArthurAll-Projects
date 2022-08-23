namespace MySQL_MongoDB_Cars_StudentsNet4_7
{
    partial class MySQL_MongoDB_WinForm
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
            this.dgrdMongoDB = new System.Windows.Forms.DataGridView();
            this.clmId_MongoDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgrdMySQL = new System.Windows.Forms.DataGridView();
            this.clmId_MySQL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMongoDB = new System.Windows.Forms.Label();
            this.lblMySql = new System.Windows.Forms.Label();
            this.txtType_MySQL = new System.Windows.Forms.TextBox();
            this.txtPrice_MySQL = new System.Windows.Forms.TextBox();
            this.txtLastName_MongoDB = new System.Windows.Forms.TextBox();
            this.txtTypeInsert_MySQL = new System.Windows.Forms.TextBox();
            this.txtPriceInsert_MySQL = new System.Windows.Forms.TextBox();
            this.txtFirstNameInsert_MongoDB = new System.Windows.Forms.TextBox();
            this.txtLastNameInsert_MongoDB = new System.Windows.Forms.TextBox();
            this.btnDelete_MySQL = new System.Windows.Forms.Button();
            this.btnUpdate_MySQL = new System.Windows.Forms.Button();
            this.btnDelete_MongoDB = new System.Windows.Forms.Button();
            this.btnUpdate_MongoDB = new System.Windows.Forms.Button();
            this.btnInsert_MySQL = new System.Windows.Forms.Button();
            this.btnInsert_MongoDB = new System.Windows.Forms.Button();
            this.lblType_MySQL = new System.Windows.Forms.Label();
            this.lblPrice_MySQL = new System.Windows.Forms.Label();
            this.lblFirstName_MongoDB = new System.Windows.Forms.Label();
            this.lblLastName_MongoDB = new System.Windows.Forms.Label();
            this.lblTypeInsert_MySQL = new System.Windows.Forms.Label();
            this.lblPriceInsert_MySQL = new System.Windows.Forms.Label();
            this.lblFirstNameInsert_MongoDB = new System.Windows.Forms.Label();
            this.lblLastNameInsert_MongoDB = new System.Windows.Forms.Label();
            this.lblTitle_MongoDB = new System.Windows.Forms.Label();
            this.lblTitle_MySql = new System.Windows.Forms.Label();
            this.lblId_MongoDB = new System.Windows.Forms.Label();
            this.txtName_MongoDB = new System.Windows.Forms.TextBox();
            this.lblId_MySQL = new System.Windows.Forms.Label();
            this.btnReload_MongoDB = new System.Windows.Forms.Button();
            this.btnReload_MySQL = new System.Windows.Forms.Button();
            this.txtCourse_MongoDB = new System.Windows.Forms.TextBox();
            this.txtModel_MySQL = new System.Windows.Forms.TextBox();
            this.txtDescription_MySQL = new System.Windows.Forms.TextBox();
            this.txtSubDescription_MySQL = new System.Windows.Forms.RichTextBox();
            this.lblCourses_MongoDB = new System.Windows.Forms.Label();
            this.lblSubDescription_MySQL = new System.Windows.Forms.Label();
            this.lblDescription_MySQL = new System.Windows.Forms.Label();
            this.lblModel_MySQL = new System.Windows.Forms.Label();
            this.txtCoursesInsert_MongoDB = new System.Windows.Forms.TextBox();
            this.txtModelInsert_MySQL = new System.Windows.Forms.TextBox();
            this.txtSubDescriptionInsert_MySQL = new System.Windows.Forms.RichTextBox();
            this.txtDescriptionInsert_MySQL = new System.Windows.Forms.TextBox();
            this.lblCoursesInsert_MongoDB = new System.Windows.Forms.Label();
            this.lblSubDescriptionInsert_MySQL = new System.Windows.Forms.Label();
            this.lblDescriptionInsert_MySQL = new System.Windows.Forms.Label();
            this.lblModelInsert_MySQL = new System.Windows.Forms.Label();
            this.lbltTypeNote_MySQL = new System.Windows.Forms.Label();
            this.lbltCourseNote_MongoDB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdMongoDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdMySQL)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrdMongoDB
            // 
            this.dgrdMongoDB.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgrdMongoDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdMongoDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId_MongoDB});
            this.dgrdMongoDB.Location = new System.Drawing.Point(413, 53);
            this.dgrdMongoDB.Name = "dgrdMongoDB";
            this.dgrdMongoDB.RowHeadersWidth = 51;
            this.dgrdMongoDB.RowTemplate.Height = 29;
            this.dgrdMongoDB.Size = new System.Drawing.Size(376, 255);
            this.dgrdMongoDB.TabIndex = 0;
            this.dgrdMongoDB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrdMongoDB_CellClick);
            this.dgrdMongoDB.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dgrdMongoDB_CellStateChanged);
            // 
            // clmId_MongoDB
            // 
            this.clmId_MongoDB.DataPropertyName = "clmId_MongoDB";
            this.clmId_MongoDB.HeaderText = "Id";
            this.clmId_MongoDB.MinimumWidth = 6;
            this.clmId_MongoDB.Name = "clmId_MongoDB";
            this.clmId_MongoDB.Visible = false;
            this.clmId_MongoDB.Width = 125;
            // 
            // dgrdMySQL
            // 
            this.dgrdMySQL.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgrdMySQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdMySQL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId_MySQL});
            this.dgrdMySQL.Location = new System.Drawing.Point(12, 53);
            this.dgrdMySQL.Name = "dgrdMySQL";
            this.dgrdMySQL.RowHeadersWidth = 51;
            this.dgrdMySQL.RowTemplate.Height = 29;
            this.dgrdMySQL.Size = new System.Drawing.Size(376, 255);
            this.dgrdMySQL.TabIndex = 1;
            this.dgrdMySQL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrdMySQL_CellClick);
            this.dgrdMySQL.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dgrdMySQL_CellStateChanged);
            // 
            // clmId_MySQL
            // 
            this.clmId_MySQL.DataPropertyName = "clmId_MySQL";
            this.clmId_MySQL.HeaderText = "Id";
            this.clmId_MySQL.MinimumWidth = 6;
            this.clmId_MySQL.Name = "clmId_MySQL";
            this.clmId_MySQL.Visible = false;
            this.clmId_MySQL.Width = 125;
            // 
            // lblMongoDB
            // 
            this.lblMongoDB.AutoSize = true;
            this.lblMongoDB.Location = new System.Drawing.Point(557, 23);
            this.lblMongoDB.Name = "lblMongoDB";
            this.lblMongoDB.Size = new System.Drawing.Size(77, 20);
            this.lblMongoDB.TabIndex = 2;
            this.lblMongoDB.Text = "MongoDB";
            // 
            // lblMySql
            // 
            this.lblMySql.AutoSize = true;
            this.lblMySql.Location = new System.Drawing.Point(157, 23);
            this.lblMySql.Name = "lblMySql";
            this.lblMySql.Size = new System.Drawing.Size(50, 20);
            this.lblMySql.TabIndex = 3;
            this.lblMySql.Text = "MySql";
            // 
            // txtType_MySQL
            // 
            this.txtType_MySQL.Location = new System.Drawing.Point(71, 340);
            this.txtType_MySQL.Name = "txtType_MySQL";
            this.txtType_MySQL.Size = new System.Drawing.Size(125, 27);
            this.txtType_MySQL.TabIndex = 4;
            // 
            // txtPrice_MySQL
            // 
            this.txtPrice_MySQL.Location = new System.Drawing.Point(186, 399);
            this.txtPrice_MySQL.Name = "txtPrice_MySQL";
            this.txtPrice_MySQL.Size = new System.Drawing.Size(125, 27);
            this.txtPrice_MySQL.TabIndex = 5;
            // 
            // txtLastName_MongoDB
            // 
            this.txtLastName_MongoDB.Location = new System.Drawing.Point(598, 340);
            this.txtLastName_MongoDB.Name = "txtLastName_MongoDB";
            this.txtLastName_MongoDB.Size = new System.Drawing.Size(125, 27);
            this.txtLastName_MongoDB.TabIndex = 7;
            // 
            // txtTypeInsert_MySQL
            // 
            this.txtTypeInsert_MySQL.Location = new System.Drawing.Point(33, 525);
            this.txtTypeInsert_MySQL.Name = "txtTypeInsert_MySQL";
            this.txtTypeInsert_MySQL.Size = new System.Drawing.Size(125, 27);
            this.txtTypeInsert_MySQL.TabIndex = 8;
            // 
            // txtPriceInsert_MySQL
            // 
            this.txtPriceInsert_MySQL.Location = new System.Drawing.Point(186, 591);
            this.txtPriceInsert_MySQL.Name = "txtPriceInsert_MySQL";
            this.txtPriceInsert_MySQL.Size = new System.Drawing.Size(125, 27);
            this.txtPriceInsert_MySQL.TabIndex = 9;
            // 
            // txtFirstNameInsert_MongoDB
            // 
            this.txtFirstNameInsert_MongoDB.Location = new System.Drawing.Point(448, 482);
            this.txtFirstNameInsert_MongoDB.Name = "txtFirstNameInsert_MongoDB";
            this.txtFirstNameInsert_MongoDB.Size = new System.Drawing.Size(125, 27);
            this.txtFirstNameInsert_MongoDB.TabIndex = 10;
            // 
            // txtLastNameInsert_MongoDB
            // 
            this.txtLastNameInsert_MongoDB.Location = new System.Drawing.Point(588, 482);
            this.txtLastNameInsert_MongoDB.Name = "txtLastNameInsert_MongoDB";
            this.txtLastNameInsert_MongoDB.Size = new System.Drawing.Size(125, 27);
            this.txtLastNameInsert_MongoDB.TabIndex = 11;
            // 
            // btnDelete_MySQL
            // 
            this.btnDelete_MySQL.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDelete_MySQL.Location = new System.Drawing.Point(316, 308);
            this.btnDelete_MySQL.Name = "btnDelete_MySQL";
            this.btnDelete_MySQL.Size = new System.Drawing.Size(72, 29);
            this.btnDelete_MySQL.TabIndex = 12;
            this.btnDelete_MySQL.Text = "Delete";
            this.btnDelete_MySQL.UseVisualStyleBackColor = false;
            this.btnDelete_MySQL.Click += new System.EventHandler(this.btnDelete_MySQL_Click);
            // 
            // btnUpdate_MySQL
            // 
            this.btnUpdate_MySQL.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUpdate_MySQL.Location = new System.Drawing.Point(338, 365);
            this.btnUpdate_MySQL.Name = "btnUpdate_MySQL";
            this.btnUpdate_MySQL.Size = new System.Drawing.Size(75, 29);
            this.btnUpdate_MySQL.TabIndex = 13;
            this.btnUpdate_MySQL.Text = "Update";
            this.btnUpdate_MySQL.UseVisualStyleBackColor = false;
            this.btnUpdate_MySQL.Click += new System.EventHandler(this.btnUpdate_MySQL_Click);
            // 
            // btnDelete_MongoDB
            // 
            this.btnDelete_MongoDB.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDelete_MongoDB.Location = new System.Drawing.Point(412, 308);
            this.btnDelete_MongoDB.Name = "btnDelete_MongoDB";
            this.btnDelete_MongoDB.Size = new System.Drawing.Size(70, 29);
            this.btnDelete_MongoDB.TabIndex = 14;
            this.btnDelete_MongoDB.Text = "Delete";
            this.btnDelete_MongoDB.UseVisualStyleBackColor = false;
            this.btnDelete_MongoDB.Click += new System.EventHandler(this.btnDelete_MongoDB_Click);
            // 
            // btnUpdate_MongoDB
            // 
            this.btnUpdate_MongoDB.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUpdate_MongoDB.Location = new System.Drawing.Point(729, 356);
            this.btnUpdate_MongoDB.Name = "btnUpdate_MongoDB";
            this.btnUpdate_MongoDB.Size = new System.Drawing.Size(70, 29);
            this.btnUpdate_MongoDB.TabIndex = 15;
            this.btnUpdate_MongoDB.Text = "Update";
            this.btnUpdate_MongoDB.UseVisualStyleBackColor = false;
            this.btnUpdate_MongoDB.Click += new System.EventHandler(this.btnUpdate_MongoDB_Click);
            // 
            // btnInsert_MySQL
            // 
            this.btnInsert_MySQL.BackColor = System.Drawing.Color.Gainsboro;
            this.btnInsert_MySQL.Location = new System.Drawing.Point(324, 544);
            this.btnInsert_MySQL.Name = "btnInsert_MySQL";
            this.btnInsert_MySQL.Size = new System.Drawing.Size(75, 29);
            this.btnInsert_MySQL.TabIndex = 16;
            this.btnInsert_MySQL.Text = "Insert";
            this.btnInsert_MySQL.UseVisualStyleBackColor = false;
            this.btnInsert_MySQL.Click += new System.EventHandler(this.btnInsert_MySQL_Click);
            // 
            // btnInsert_MongoDB
            // 
            this.btnInsert_MongoDB.BackColor = System.Drawing.Color.Gainsboro;
            this.btnInsert_MongoDB.Location = new System.Drawing.Point(719, 491);
            this.btnInsert_MongoDB.Name = "btnInsert_MongoDB";
            this.btnInsert_MongoDB.Size = new System.Drawing.Size(69, 29);
            this.btnInsert_MongoDB.TabIndex = 17;
            this.btnInsert_MongoDB.Text = "Insert";
            this.btnInsert_MongoDB.UseVisualStyleBackColor = false;
            this.btnInsert_MongoDB.Click += new System.EventHandler(this.btnInsert_MongoDB_Click);
            // 
            // lblType_MySQL
            // 
            this.lblType_MySQL.AutoSize = true;
            this.lblType_MySQL.Location = new System.Drawing.Point(107, 312);
            this.lblType_MySQL.Name = "lblType_MySQL";
            this.lblType_MySQL.Size = new System.Drawing.Size(46, 20);
            this.lblType_MySQL.TabIndex = 18;
            this.lblType_MySQL.Text = "Type*";
            // 
            // lblPrice_MySQL
            // 
            this.lblPrice_MySQL.AutoSize = true;
            this.lblPrice_MySQL.Location = new System.Drawing.Point(186, 376);
            this.lblPrice_MySQL.Name = "lblPrice_MySQL";
            this.lblPrice_MySQL.Size = new System.Drawing.Size(41, 20);
            this.lblPrice_MySQL.TabIndex = 19;
            this.lblPrice_MySQL.Text = "Price";
            // 
            // lblFirstName_MongoDB
            // 
            this.lblFirstName_MongoDB.AutoSize = true;
            this.lblFirstName_MongoDB.Location = new System.Drawing.Point(488, 312);
            this.lblFirstName_MongoDB.Name = "lblFirstName_MongoDB";
            this.lblFirstName_MongoDB.Size = new System.Drawing.Size(76, 20);
            this.lblFirstName_MongoDB.TabIndex = 20;
            this.lblFirstName_MongoDB.Text = "FirstName";
            // 
            // lblLastName_MongoDB
            // 
            this.lblLastName_MongoDB.AutoSize = true;
            this.lblLastName_MongoDB.Location = new System.Drawing.Point(609, 312);
            this.lblLastName_MongoDB.Name = "lblLastName_MongoDB";
            this.lblLastName_MongoDB.Size = new System.Drawing.Size(79, 20);
            this.lblLastName_MongoDB.TabIndex = 21;
            this.lblLastName_MongoDB.Text = "Last Name";
            // 
            // lblTypeInsert_MySQL
            // 
            this.lblTypeInsert_MySQL.AutoSize = true;
            this.lblTypeInsert_MySQL.Location = new System.Drawing.Point(71, 494);
            this.lblTypeInsert_MySQL.Name = "lblTypeInsert_MySQL";
            this.lblTypeInsert_MySQL.Size = new System.Drawing.Size(46, 20);
            this.lblTypeInsert_MySQL.TabIndex = 22;
            this.lblTypeInsert_MySQL.Text = "Type*";
            // 
            // lblPriceInsert_MySQL
            // 
            this.lblPriceInsert_MySQL.AutoSize = true;
            this.lblPriceInsert_MySQL.Location = new System.Drawing.Point(215, 560);
            this.lblPriceInsert_MySQL.Name = "lblPriceInsert_MySQL";
            this.lblPriceInsert_MySQL.Size = new System.Drawing.Size(41, 20);
            this.lblPriceInsert_MySQL.TabIndex = 23;
            this.lblPriceInsert_MySQL.Text = "Price";
            // 
            // lblFirstNameInsert_MongoDB
            // 
            this.lblFirstNameInsert_MongoDB.AutoSize = true;
            this.lblFirstNameInsert_MongoDB.Location = new System.Drawing.Point(479, 459);
            this.lblFirstNameInsert_MongoDB.Name = "lblFirstNameInsert_MongoDB";
            this.lblFirstNameInsert_MongoDB.Size = new System.Drawing.Size(80, 20);
            this.lblFirstNameInsert_MongoDB.TabIndex = 24;
            this.lblFirstNameInsert_MongoDB.Text = "First Name";
            // 
            // lblLastNameInsert_MongoDB
            // 
            this.lblLastNameInsert_MongoDB.AutoSize = true;
            this.lblLastNameInsert_MongoDB.Location = new System.Drawing.Point(614, 459);
            this.lblLastNameInsert_MongoDB.Name = "lblLastNameInsert_MongoDB";
            this.lblLastNameInsert_MongoDB.Size = new System.Drawing.Size(75, 20);
            this.lblLastNameInsert_MongoDB.TabIndex = 25;
            this.lblLastNameInsert_MongoDB.Text = "LastName";
            // 
            // lblTitle_MongoDB
            // 
            this.lblTitle_MongoDB.AutoSize = true;
            this.lblTitle_MongoDB.Location = new System.Drawing.Point(708, 25);
            this.lblTitle_MongoDB.Name = "lblTitle_MongoDB";
            this.lblTitle_MongoDB.Size = new System.Drawing.Size(66, 20);
            this.lblTitle_MongoDB.TabIndex = 26;
            this.lblTitle_MongoDB.Text = "Students";
            // 
            // lblTitle_MySql
            // 
            this.lblTitle_MySql.AutoSize = true;
            this.lblTitle_MySql.Location = new System.Drawing.Point(313, 25);
            this.lblTitle_MySql.Name = "lblTitle_MySql";
            this.lblTitle_MySql.Size = new System.Drawing.Size(37, 20);
            this.lblTitle_MySql.TabIndex = 27;
            this.lblTitle_MySql.Text = "Cars";
            // 
            // lblId_MongoDB
            // 
            this.lblId_MongoDB.AutoSize = true;
            this.lblId_MongoDB.Location = new System.Drawing.Point(467, 431);
            this.lblId_MongoDB.Name = "lblId_MongoDB";
            this.lblId_MongoDB.Size = new System.Drawing.Size(22, 20);
            this.lblId_MongoDB.TabIndex = 28;
            this.lblId_MongoDB.Text = "id";
            // 
            // txtName_MongoDB
            // 
            this.txtName_MongoDB.Location = new System.Drawing.Point(454, 340);
            this.txtName_MongoDB.Name = "txtName_MongoDB";
            this.txtName_MongoDB.Size = new System.Drawing.Size(125, 27);
            this.txtName_MongoDB.TabIndex = 6;
            // 
            // lblId_MySQL
            // 
            this.lblId_MySQL.AutoSize = true;
            this.lblId_MySQL.Location = new System.Drawing.Point(20, 345);
            this.lblId_MySQL.Name = "lblId_MySQL";
            this.lblId_MySQL.Size = new System.Drawing.Size(22, 20);
            this.lblId_MySQL.TabIndex = 29;
            this.lblId_MySQL.Text = "id";
            // 
            // btnReload_MongoDB
            // 
            this.btnReload_MongoDB.BackColor = System.Drawing.Color.Gainsboro;
            this.btnReload_MongoDB.Location = new System.Drawing.Point(718, 310);
            this.btnReload_MongoDB.Name = "btnReload_MongoDB";
            this.btnReload_MongoDB.Size = new System.Drawing.Size(70, 29);
            this.btnReload_MongoDB.TabIndex = 30;
            this.btnReload_MongoDB.Text = "Reload";
            this.btnReload_MongoDB.UseVisualStyleBackColor = false;
            this.btnReload_MongoDB.Click += new System.EventHandler(this.btnReload_MongoDB_Click);
            // 
            // btnReload_MySQL
            // 
            this.btnReload_MySQL.BackColor = System.Drawing.Color.Gainsboro;
            this.btnReload_MySQL.Location = new System.Drawing.Point(12, 308);
            this.btnReload_MySQL.Name = "btnReload_MySQL";
            this.btnReload_MySQL.Size = new System.Drawing.Size(76, 29);
            this.btnReload_MySQL.TabIndex = 31;
            this.btnReload_MySQL.Text = "Reload";
            this.btnReload_MySQL.UseVisualStyleBackColor = false;
            this.btnReload_MySQL.Click += new System.EventHandler(this.btnReload_MySQL_Click);
            // 
            // txtCourse_MongoDB
            // 
            this.txtCourse_MongoDB.Location = new System.Drawing.Point(454, 397);
            this.txtCourse_MongoDB.Name = "txtCourse_MongoDB";
            this.txtCourse_MongoDB.Size = new System.Drawing.Size(259, 27);
            this.txtCourse_MongoDB.TabIndex = 32;
            // 
            // txtModel_MySQL
            // 
            this.txtModel_MySQL.Location = new System.Drawing.Point(186, 451);
            this.txtModel_MySQL.Name = "txtModel_MySQL";
            this.txtModel_MySQL.Size = new System.Drawing.Size(125, 27);
            this.txtModel_MySQL.TabIndex = 33;
            // 
            // txtDescription_MySQL
            // 
            this.txtDescription_MySQL.Location = new System.Drawing.Point(207, 341);
            this.txtDescription_MySQL.Name = "txtDescription_MySQL";
            this.txtDescription_MySQL.Size = new System.Drawing.Size(125, 27);
            this.txtDescription_MySQL.TabIndex = 34;
            // 
            // txtSubDescription_MySQL
            // 
            this.txtSubDescription_MySQL.Location = new System.Drawing.Point(12, 401);
            this.txtSubDescription_MySQL.Name = "txtSubDescription_MySQL";
            this.txtSubDescription_MySQL.Size = new System.Drawing.Size(153, 84);
            this.txtSubDescription_MySQL.TabIndex = 35;
            this.txtSubDescription_MySQL.Text = "";
            // 
            // lblCourses_MongoDB
            // 
            this.lblCourses_MongoDB.AutoSize = true;
            this.lblCourses_MongoDB.Location = new System.Drawing.Point(454, 374);
            this.lblCourses_MongoDB.Name = "lblCourses_MongoDB";
            this.lblCourses_MongoDB.Size = new System.Drawing.Size(60, 20);
            this.lblCourses_MongoDB.TabIndex = 36;
            this.lblCourses_MongoDB.Text = "Courses";
            // 
            // lblSubDescription_MySQL
            // 
            this.lblSubDescription_MySQL.AutoSize = true;
            this.lblSubDescription_MySQL.Location = new System.Drawing.Point(15, 374);
            this.lblSubDescription_MySQL.Name = "lblSubDescription_MySQL";
            this.lblSubDescription_MySQL.Size = new System.Drawing.Size(114, 20);
            this.lblSubDescription_MySQL.TabIndex = 37;
            this.lblSubDescription_MySQL.Text = "Sub Description";
            // 
            // lblDescription_MySQL
            // 
            this.lblDescription_MySQL.AutoSize = true;
            this.lblDescription_MySQL.Location = new System.Drawing.Point(228, 313);
            this.lblDescription_MySQL.Name = "lblDescription_MySQL";
            this.lblDescription_MySQL.Size = new System.Drawing.Size(85, 20);
            this.lblDescription_MySQL.TabIndex = 38;
            this.lblDescription_MySQL.Text = "Description";
            // 
            // lblModel_MySQL
            // 
            this.lblModel_MySQL.AutoSize = true;
            this.lblModel_MySQL.Location = new System.Drawing.Point(192, 431);
            this.lblModel_MySQL.Name = "lblModel_MySQL";
            this.lblModel_MySQL.Size = new System.Drawing.Size(52, 20);
            this.lblModel_MySQL.TabIndex = 39;
            this.lblModel_MySQL.Text = "Model";
            // 
            // txtCoursesInsert_MongoDB
            // 
            this.txtCoursesInsert_MongoDB.Location = new System.Drawing.Point(454, 539);
            this.txtCoursesInsert_MongoDB.Name = "txtCoursesInsert_MongoDB";
            this.txtCoursesInsert_MongoDB.Size = new System.Drawing.Size(259, 27);
            this.txtCoursesInsert_MongoDB.TabIndex = 40;
            // 
            // txtModelInsert_MySQL
            // 
            this.txtModelInsert_MySQL.Location = new System.Drawing.Point(186, 649);
            this.txtModelInsert_MySQL.Name = "txtModelInsert_MySQL";
            this.txtModelInsert_MySQL.Size = new System.Drawing.Size(125, 27);
            this.txtModelInsert_MySQL.TabIndex = 41;
            // 
            // txtSubDescriptionInsert_MySQL
            // 
            this.txtSubDescriptionInsert_MySQL.Location = new System.Drawing.Point(15, 591);
            this.txtSubDescriptionInsert_MySQL.Name = "txtSubDescriptionInsert_MySQL";
            this.txtSubDescriptionInsert_MySQL.Size = new System.Drawing.Size(153, 94);
            this.txtSubDescriptionInsert_MySQL.TabIndex = 42;
            this.txtSubDescriptionInsert_MySQL.Text = "";
            // 
            // txtDescriptionInsert_MySQL
            // 
            this.txtDescriptionInsert_MySQL.Location = new System.Drawing.Point(188, 526);
            this.txtDescriptionInsert_MySQL.Name = "txtDescriptionInsert_MySQL";
            this.txtDescriptionInsert_MySQL.Size = new System.Drawing.Size(125, 27);
            this.txtDescriptionInsert_MySQL.TabIndex = 43;
            // 
            // lblCoursesInsert_MongoDB
            // 
            this.lblCoursesInsert_MongoDB.AutoSize = true;
            this.lblCoursesInsert_MongoDB.Location = new System.Drawing.Point(478, 516);
            this.lblCoursesInsert_MongoDB.Name = "lblCoursesInsert_MongoDB";
            this.lblCoursesInsert_MongoDB.Size = new System.Drawing.Size(60, 20);
            this.lblCoursesInsert_MongoDB.TabIndex = 44;
            this.lblCoursesInsert_MongoDB.Text = "Courses";
            // 
            // lblSubDescriptionInsert_MySQL
            // 
            this.lblSubDescriptionInsert_MySQL.AutoSize = true;
            this.lblSubDescriptionInsert_MySQL.Location = new System.Drawing.Point(37, 560);
            this.lblSubDescriptionInsert_MySQL.Name = "lblSubDescriptionInsert_MySQL";
            this.lblSubDescriptionInsert_MySQL.Size = new System.Drawing.Size(114, 20);
            this.lblSubDescriptionInsert_MySQL.TabIndex = 45;
            this.lblSubDescriptionInsert_MySQL.Text = "Sub Description";
            // 
            // lblDescriptionInsert_MySQL
            // 
            this.lblDescriptionInsert_MySQL.AutoSize = true;
            this.lblDescriptionInsert_MySQL.Location = new System.Drawing.Point(210, 495);
            this.lblDescriptionInsert_MySQL.Name = "lblDescriptionInsert_MySQL";
            this.lblDescriptionInsert_MySQL.Size = new System.Drawing.Size(85, 20);
            this.lblDescriptionInsert_MySQL.TabIndex = 46;
            this.lblDescriptionInsert_MySQL.Text = "Description";
            // 
            // lblModelInsert_MySQL
            // 
            this.lblModelInsert_MySQL.AutoSize = true;
            this.lblModelInsert_MySQL.Location = new System.Drawing.Point(215, 626);
            this.lblModelInsert_MySQL.Name = "lblModelInsert_MySQL";
            this.lblModelInsert_MySQL.Size = new System.Drawing.Size(52, 20);
            this.lblModelInsert_MySQL.TabIndex = 47;
            this.lblModelInsert_MySQL.Text = "Model";
            // 
            // lbltTypeNote_MySQL
            // 
            this.lbltTypeNote_MySQL.AutoSize = true;
            this.lbltTypeNote_MySQL.Location = new System.Drawing.Point(58, 695);
            this.lbltTypeNote_MySQL.Name = "lbltTypeNote_MySQL";
            this.lbltTypeNote_MySQL.Size = new System.Drawing.Size(198, 20);
            this.lbltTypeNote_MySQL.TabIndex = 48;
            this.lbltTypeNote_MySQL.Text = "*only known types accepted!";
            // 
            // lbltCourseNote_MongoDB
            // 
            this.lbltCourseNote_MongoDB.AutoSize = true;
            this.lbltCourseNote_MongoDB.Location = new System.Drawing.Point(448, 695);
            this.lbltCourseNote_MongoDB.Name = "lbltCourseNote_MongoDB";
            this.lbltCourseNote_MongoDB.Size = new System.Drawing.Size(164, 20);
            this.lbltCourseNote_MongoDB.TabIndex = 49;
            this.lbltCourseNote_MongoDB.Text = "*seperate courses with ,";
            // 
            // MySQL_MongoDB_WinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(826, 726);
            this.Controls.Add(this.lbltCourseNote_MongoDB);
            this.Controls.Add(this.lbltTypeNote_MySQL);
            this.Controls.Add(this.lblModelInsert_MySQL);
            this.Controls.Add(this.lblDescriptionInsert_MySQL);
            this.Controls.Add(this.lblSubDescriptionInsert_MySQL);
            this.Controls.Add(this.lblCoursesInsert_MongoDB);
            this.Controls.Add(this.txtDescriptionInsert_MySQL);
            this.Controls.Add(this.txtSubDescriptionInsert_MySQL);
            this.Controls.Add(this.txtModelInsert_MySQL);
            this.Controls.Add(this.txtCoursesInsert_MongoDB);
            this.Controls.Add(this.lblModel_MySQL);
            this.Controls.Add(this.lblDescription_MySQL);
            this.Controls.Add(this.lblSubDescription_MySQL);
            this.Controls.Add(this.lblCourses_MongoDB);
            this.Controls.Add(this.txtSubDescription_MySQL);
            this.Controls.Add(this.txtDescription_MySQL);
            this.Controls.Add(this.txtModel_MySQL);
            this.Controls.Add(this.txtCourse_MongoDB);
            this.Controls.Add(this.btnReload_MySQL);
            this.Controls.Add(this.btnReload_MongoDB);
            this.Controls.Add(this.lblId_MySQL);
            this.Controls.Add(this.lblId_MongoDB);
            this.Controls.Add(this.lblTitle_MySql);
            this.Controls.Add(this.lblTitle_MongoDB);
            this.Controls.Add(this.lblLastNameInsert_MongoDB);
            this.Controls.Add(this.lblFirstNameInsert_MongoDB);
            this.Controls.Add(this.lblPriceInsert_MySQL);
            this.Controls.Add(this.lblTypeInsert_MySQL);
            this.Controls.Add(this.lblLastName_MongoDB);
            this.Controls.Add(this.lblFirstName_MongoDB);
            this.Controls.Add(this.lblPrice_MySQL);
            this.Controls.Add(this.lblType_MySQL);
            this.Controls.Add(this.btnInsert_MongoDB);
            this.Controls.Add(this.btnInsert_MySQL);
            this.Controls.Add(this.btnUpdate_MongoDB);
            this.Controls.Add(this.btnDelete_MongoDB);
            this.Controls.Add(this.btnUpdate_MySQL);
            this.Controls.Add(this.btnDelete_MySQL);
            this.Controls.Add(this.txtLastNameInsert_MongoDB);
            this.Controls.Add(this.txtFirstNameInsert_MongoDB);
            this.Controls.Add(this.txtPriceInsert_MySQL);
            this.Controls.Add(this.txtTypeInsert_MySQL);
            this.Controls.Add(this.txtLastName_MongoDB);
            this.Controls.Add(this.txtName_MongoDB);
            this.Controls.Add(this.txtPrice_MySQL);
            this.Controls.Add(this.txtType_MySQL);
            this.Controls.Add(this.lblMySql);
            this.Controls.Add(this.lblMongoDB);
            this.Controls.Add(this.dgrdMySQL);
            this.Controls.Add(this.dgrdMongoDB);
            this.Name = "MySQL_MongoDB_WinForm";
            this.Text = "MySQL and MongoDB Windows Forms";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MySQL_MongoDB_WinForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdMongoDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdMySQL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrdMongoDB;
        private System.Windows.Forms.DataGridView dgrdMySQL;
        private System.Windows.Forms.Label lblMongoDB;
        private System.Windows.Forms.Label lblMySql;
        private System.Windows.Forms.TextBox txtType_MySQL;
        private System.Windows.Forms.TextBox txtPrice_MySQL;
        private System.Windows.Forms.TextBox txtLastName_MongoDB;
        private System.Windows.Forms.TextBox txtTypeInsert_MySQL;
        private System.Windows.Forms.TextBox txtPriceInsert_MySQL;
        private System.Windows.Forms.TextBox txtFirstNameInsert_MongoDB;
        private System.Windows.Forms.TextBox txtLastNameInsert_MongoDB;
        private System.Windows.Forms.Button btnDelete_MySQL;
        private System.Windows.Forms.Button btnUpdate_MySQL;
        private System.Windows.Forms.Button btnDelete_MongoDB;
        private System.Windows.Forms.Button btnUpdate_MongoDB;
        private System.Windows.Forms.Button btnInsert_MySQL;
        private System.Windows.Forms.Button btnInsert_MongoDB;
        private System.Windows.Forms.Label lblType_MySQL;
        private System.Windows.Forms.Label lblPrice_MySQL;
        private System.Windows.Forms.Label lblFirstName_MongoDB;
        private System.Windows.Forms.Label lblLastName_MongoDB;
        private System.Windows.Forms.Label lblTypeInsert_MySQL;
        private System.Windows.Forms.Label lblPriceInsert_MySQL;
        private System.Windows.Forms.Label lblFirstNameInsert_MongoDB;
        private System.Windows.Forms.Label lblLastNameInsert_MongoDB;
        private System.Windows.Forms.Label lblTitle_MongoDB;
        private System.Windows.Forms.Label lblTitle_MySql;
        private System.Windows.Forms.Label lblId_MongoDB;
        private System.Windows.Forms.TextBox txtName_MongoDB;
        private System.Windows.Forms.Label lblId_MySQL;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.Button btnReload_MongoDB;
        private System.Windows.Forms.Button btnReload_MySQL;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId_MongoDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId_MySQL;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtModel_MySQL;
        private System.Windows.Forms.TextBox txtDescription_MySQL;
        private System.Windows.Forms.RichTextBox txtSubDescription_MySQL;
        private System.Windows.Forms.Label lblCourses_MongoDB;
        private System.Windows.Forms.Label lblSubDescription_MySQL;
        private System.Windows.Forms.Label lblDescription_MySQL;
        private System.Windows.Forms.Label lblModel_MySQL;
        private System.Windows.Forms.TextBox txtCoursesInsert_MongoDB;
        private System.Windows.Forms.TextBox txtModelInsert_MySQL;
        private System.Windows.Forms.RichTextBox txtSubDescriptionInsert_MySQL;
        private System.Windows.Forms.TextBox txtDescriptionInsert_MySQL;
        private System.Windows.Forms.Label lblCoursesInsert_MongoDB;
        private System.Windows.Forms.Label lblSubDescriptionInsert_MySQL;
        private System.Windows.Forms.Label lblDescriptionInsert_MySQL;
        private System.Windows.Forms.Label lblModelInsert_MySQL;
        private System.Windows.Forms.TextBox txtCourse_MongoDB;
        private System.Windows.Forms.Label lbltTypeNote_MySQL;
        private System.Windows.Forms.Label lbltCourseNote_MongoDB;
    }
}
