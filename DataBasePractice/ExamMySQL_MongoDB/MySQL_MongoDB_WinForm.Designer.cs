namespace ExamMySQL_MongoDB
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
            this.txtLastName_MongoDB = new System.Windows.Forms.TextBox();
            this.txtFirstNameInsert_MySQL = new System.Windows.Forms.TextBox();
            this.txtAgeInsert_MySQL = new System.Windows.Forms.TextBox();
            this.txtFirstNameInsert_MongoDB = new System.Windows.Forms.TextBox();
            this.txtLastNameInsert_MongoDB = new System.Windows.Forms.TextBox();
            this.btnDelete_MongoDB = new System.Windows.Forms.Button();
            this.btnUpdate_MongoDB = new System.Windows.Forms.Button();
            this.btnInsert_MySQL = new System.Windows.Forms.Button();
            this.btnInsert_MongoDB = new System.Windows.Forms.Button();
            this.lblFirstName_MongoDB = new System.Windows.Forms.Label();
            this.lblLastName_MongoDB = new System.Windows.Forms.Label();
            this.lbFirstNameInsert_MySQL = new System.Windows.Forms.Label();
            this.lblAgeInsert_MySQL = new System.Windows.Forms.Label();
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
            this.lblCourses_MongoDB = new System.Windows.Forms.Label();
            this.txtCoursesInsert_MongoDB = new System.Windows.Forms.TextBox();
            this.txtLastNameInsert_MySQL = new System.Windows.Forms.TextBox();
            this.lblCoursesInsert_MongoDB = new System.Windows.Forms.Label();
            this.lblLastName_MySQL = new System.Windows.Forms.Label();
            this.lbltCourseNote_MongoDB = new System.Windows.Forms.Label();
            this.lblInsertLecturer = new System.Windows.Forms.Label();
            this.txtInsertLecturer = new System.Windows.Forms.TextBox();
            this.btnInsertLecturer_MongoDB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAssignCourse_MongoDB = new System.Windows.Forms.TextBox();
            this.btnAssign_MongoDBB = new System.Windows.Forms.Button();
            this.txtInsertCourseToCourses_MongoDB = new System.Windows.Forms.TextBox();
            this.btnInsertCourseToCourses_MongoDB = new System.Windows.Forms.Button();
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
            this.dgrdMongoDB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrdMongoDB_CellContentClick);
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
            // txtLastName_MongoDB
            // 
            this.txtLastName_MongoDB.Location = new System.Drawing.Point(598, 340);
            this.txtLastName_MongoDB.Name = "txtLastName_MongoDB";
            this.txtLastName_MongoDB.Size = new System.Drawing.Size(125, 27);
            this.txtLastName_MongoDB.TabIndex = 7;
            // 
            // txtFirstNameInsert_MySQL
            // 
            this.txtFirstNameInsert_MySQL.Location = new System.Drawing.Point(44, 397);
            this.txtFirstNameInsert_MySQL.Name = "txtFirstNameInsert_MySQL";
            this.txtFirstNameInsert_MySQL.Size = new System.Drawing.Size(125, 27);
            this.txtFirstNameInsert_MySQL.TabIndex = 8;
            // 
            // txtAgeInsert_MySQL
            // 
            this.txtAgeInsert_MySQL.Location = new System.Drawing.Point(197, 463);
            this.txtAgeInsert_MySQL.Name = "txtAgeInsert_MySQL";
            this.txtAgeInsert_MySQL.Size = new System.Drawing.Size(125, 27);
            this.txtAgeInsert_MySQL.TabIndex = 9;
            // 
            // txtFirstNameInsert_MongoDB
            // 
            this.txtFirstNameInsert_MongoDB.Location = new System.Drawing.Point(467, 576);
            this.txtFirstNameInsert_MongoDB.Name = "txtFirstNameInsert_MongoDB";
            this.txtFirstNameInsert_MongoDB.Size = new System.Drawing.Size(125, 27);
            this.txtFirstNameInsert_MongoDB.TabIndex = 10;
            // 
            // txtLastNameInsert_MongoDB
            // 
            this.txtLastNameInsert_MongoDB.Location = new System.Drawing.Point(607, 576);
            this.txtLastNameInsert_MongoDB.Name = "txtLastNameInsert_MongoDB";
            this.txtLastNameInsert_MongoDB.Size = new System.Drawing.Size(125, 27);
            this.txtLastNameInsert_MongoDB.TabIndex = 11;
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
            this.btnInsert_MySQL.Location = new System.Drawing.Point(335, 416);
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
            this.btnInsert_MongoDB.Location = new System.Drawing.Point(738, 585);
            this.btnInsert_MongoDB.Name = "btnInsert_MongoDB";
            this.btnInsert_MongoDB.Size = new System.Drawing.Size(69, 29);
            this.btnInsert_MongoDB.TabIndex = 17;
            this.btnInsert_MongoDB.Text = "Insert";
            this.btnInsert_MongoDB.UseVisualStyleBackColor = false;
            this.btnInsert_MongoDB.Click += new System.EventHandler(this.btnInsert_MongoDB_Click);
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
            // lbFirstNameInsert_MySQL
            // 
            this.lbFirstNameInsert_MySQL.AutoSize = true;
            this.lbFirstNameInsert_MySQL.Location = new System.Drawing.Point(82, 366);
            this.lbFirstNameInsert_MySQL.Name = "lbFirstNameInsert_MySQL";
            this.lbFirstNameInsert_MySQL.Size = new System.Drawing.Size(80, 20);
            this.lbFirstNameInsert_MySQL.TabIndex = 22;
            this.lbFirstNameInsert_MySQL.Text = "First Name";
            // 
            // lblAgeInsert_MySQL
            // 
            this.lblAgeInsert_MySQL.AutoSize = true;
            this.lblAgeInsert_MySQL.Location = new System.Drawing.Point(226, 432);
            this.lblAgeInsert_MySQL.Name = "lblAgeInsert_MySQL";
            this.lblAgeInsert_MySQL.Size = new System.Drawing.Size(36, 20);
            this.lblAgeInsert_MySQL.TabIndex = 23;
            this.lblAgeInsert_MySQL.Text = "Age";
            // 
            // lblFirstNameInsert_MongoDB
            // 
            this.lblFirstNameInsert_MongoDB.AutoSize = true;
            this.lblFirstNameInsert_MongoDB.Location = new System.Drawing.Point(498, 553);
            this.lblFirstNameInsert_MongoDB.Name = "lblFirstNameInsert_MongoDB";
            this.lblFirstNameInsert_MongoDB.Size = new System.Drawing.Size(80, 20);
            this.lblFirstNameInsert_MongoDB.TabIndex = 24;
            this.lblFirstNameInsert_MongoDB.Text = "First Name";
            // 
            // lblLastNameInsert_MongoDB
            // 
            this.lblLastNameInsert_MongoDB.AutoSize = true;
            this.lblLastNameInsert_MongoDB.Location = new System.Drawing.Point(633, 553);
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
            this.lblTitle_MySql.Size = new System.Drawing.Size(66, 20);
            this.lblTitle_MySql.TabIndex = 27;
            this.lblTitle_MySql.Text = "Students";
            // 
            // lblId_MongoDB
            // 
            this.lblId_MongoDB.AutoSize = true;
            this.lblId_MongoDB.Location = new System.Drawing.Point(460, 432);
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
            this.lblId_MySQL.Location = new System.Drawing.Point(194, 312);
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
            // lblCourses_MongoDB
            // 
            this.lblCourses_MongoDB.AutoSize = true;
            this.lblCourses_MongoDB.Location = new System.Drawing.Point(454, 374);
            this.lblCourses_MongoDB.Name = "lblCourses_MongoDB";
            this.lblCourses_MongoDB.Size = new System.Drawing.Size(60, 20);
            this.lblCourses_MongoDB.TabIndex = 36;
            this.lblCourses_MongoDB.Text = "Courses";
            // 
            // txtCoursesInsert_MongoDB
            // 
            this.txtCoursesInsert_MongoDB.Location = new System.Drawing.Point(473, 633);
            this.txtCoursesInsert_MongoDB.Name = "txtCoursesInsert_MongoDB";
            this.txtCoursesInsert_MongoDB.Size = new System.Drawing.Size(259, 27);
            this.txtCoursesInsert_MongoDB.TabIndex = 40;
            // 
            // txtLastNameInsert_MySQL
            // 
            this.txtLastNameInsert_MySQL.Location = new System.Drawing.Point(199, 398);
            this.txtLastNameInsert_MySQL.Name = "txtLastNameInsert_MySQL";
            this.txtLastNameInsert_MySQL.Size = new System.Drawing.Size(125, 27);
            this.txtLastNameInsert_MySQL.TabIndex = 43;
            // 
            // lblCoursesInsert_MongoDB
            // 
            this.lblCoursesInsert_MongoDB.AutoSize = true;
            this.lblCoursesInsert_MongoDB.Location = new System.Drawing.Point(497, 610);
            this.lblCoursesInsert_MongoDB.Name = "lblCoursesInsert_MongoDB";
            this.lblCoursesInsert_MongoDB.Size = new System.Drawing.Size(60, 20);
            this.lblCoursesInsert_MongoDB.TabIndex = 44;
            this.lblCoursesInsert_MongoDB.Text = "Courses";
            // 
            // lblLastName_MySQL
            // 
            this.lblLastName_MySQL.AutoSize = true;
            this.lblLastName_MySQL.Location = new System.Drawing.Point(221, 367);
            this.lblLastName_MySQL.Name = "lblLastName_MySQL";
            this.lblLastName_MySQL.Size = new System.Drawing.Size(79, 20);
            this.lblLastName_MySQL.TabIndex = 46;
            this.lblLastName_MySQL.Text = "Last Name";
            // 
            // lbltCourseNote_MongoDB
            // 
            this.lbltCourseNote_MongoDB.AutoSize = true;
            this.lbltCourseNote_MongoDB.Location = new System.Drawing.Point(473, 679);
            this.lbltCourseNote_MongoDB.Name = "lbltCourseNote_MongoDB";
            this.lbltCourseNote_MongoDB.Size = new System.Drawing.Size(164, 20);
            this.lbltCourseNote_MongoDB.TabIndex = 49;
            this.lbltCourseNote_MongoDB.Text = "*seperate courses with ,";
            // 
            // lblInsertLecturer
            // 
            this.lblInsertLecturer.AutoSize = true;
            this.lblInsertLecturer.Location = new System.Drawing.Point(481, 731);
            this.lblInsertLecturer.Name = "lblInsertLecturer";
            this.lblInsertLecturer.Size = new System.Drawing.Size(136, 20);
            this.lblInsertLecturer.TabIndex = 50;
            this.lblInsertLecturer.Text = "Insert New Lecturer";
            // 
            // txtInsertLecturer
            // 
            this.txtInsertLecturer.Location = new System.Drawing.Point(481, 754);
            this.txtInsertLecturer.Name = "txtInsertLecturer";
            this.txtInsertLecturer.Size = new System.Drawing.Size(169, 27);
            this.txtInsertLecturer.TabIndex = 51;
            // 
            // btnInsertLecturer_MongoDB
            // 
            this.btnInsertLecturer_MongoDB.Location = new System.Drawing.Point(667, 754);
            this.btnInsertLecturer_MongoDB.Name = "btnInsertLecturer_MongoDB";
            this.btnInsertLecturer_MongoDB.Size = new System.Drawing.Size(94, 29);
            this.btnInsertLecturer_MongoDB.TabIndex = 52;
            this.btnInsertLecturer_MongoDB.Text = "Insert";
            this.btnInsertLecturer_MongoDB.UseVisualStyleBackColor = true;
            this.btnInsertLecturer_MongoDB.Click += new System.EventHandler(this.btnInsertLecturer_MongoDB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(488, 470);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "Assign to Course";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 806);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 54;
            this.label2.Text = "Add Course to Courses";
            // 
            // txtAssignCourse_MongoDB
            // 
            this.txtAssignCourse_MongoDB.Location = new System.Drawing.Point(488, 502);
            this.txtAssignCourse_MongoDB.Name = "txtAssignCourse_MongoDB";
            this.txtAssignCourse_MongoDB.Size = new System.Drawing.Size(125, 27);
            this.txtAssignCourse_MongoDB.TabIndex = 55;
            // 
            // btnAssign_MongoDBB
            // 
            this.btnAssign_MongoDBB.Location = new System.Drawing.Point(622, 501);
            this.btnAssign_MongoDBB.Name = "btnAssign_MongoDBB";
            this.btnAssign_MongoDBB.Size = new System.Drawing.Size(94, 29);
            this.btnAssign_MongoDBB.TabIndex = 56;
            this.btnAssign_MongoDBB.Text = "Assign";
            this.btnAssign_MongoDBB.UseVisualStyleBackColor = true;
            this.btnAssign_MongoDBB.Click += new System.EventHandler(this.btnAssign_MongoDBB_Click);
            // 
            // txtInsertCourseToCourses_MongoDB
            // 
            this.txtInsertCourseToCourses_MongoDB.Location = new System.Drawing.Point(480, 836);
            this.txtInsertCourseToCourses_MongoDB.Name = "txtInsertCourseToCourses_MongoDB";
            this.txtInsertCourseToCourses_MongoDB.Size = new System.Drawing.Size(125, 27);
            this.txtInsertCourseToCourses_MongoDB.TabIndex = 57;
            // 
            // btnInsertCourseToCourses_MongoDB
            // 
            this.btnInsertCourseToCourses_MongoDB.Location = new System.Drawing.Point(611, 837);
            this.btnInsertCourseToCourses_MongoDB.Name = "btnInsertCourseToCourses_MongoDB";
            this.btnInsertCourseToCourses_MongoDB.Size = new System.Drawing.Size(94, 29);
            this.btnInsertCourseToCourses_MongoDB.TabIndex = 58;
            this.btnInsertCourseToCourses_MongoDB.Text = "Insert";
            this.btnInsertCourseToCourses_MongoDB.UseVisualStyleBackColor = true;
            this.btnInsertCourseToCourses_MongoDB.Click += new System.EventHandler(this.btnInsertCourseToCourses_MongoDB_Click);
            // 
            // MySQL_MongoDB_WinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(826, 1055);
            this.Controls.Add(this.btnInsertCourseToCourses_MongoDB);
            this.Controls.Add(this.txtInsertCourseToCourses_MongoDB);
            this.Controls.Add(this.btnAssign_MongoDBB);
            this.Controls.Add(this.txtAssignCourse_MongoDB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInsertLecturer_MongoDB);
            this.Controls.Add(this.txtInsertLecturer);
            this.Controls.Add(this.lblInsertLecturer);
            this.Controls.Add(this.lbltCourseNote_MongoDB);
            this.Controls.Add(this.lblLastName_MySQL);
            this.Controls.Add(this.lblCoursesInsert_MongoDB);
            this.Controls.Add(this.txtLastNameInsert_MySQL);
            this.Controls.Add(this.txtCoursesInsert_MongoDB);
            this.Controls.Add(this.lblCourses_MongoDB);
            this.Controls.Add(this.txtCourse_MongoDB);
            this.Controls.Add(this.btnReload_MySQL);
            this.Controls.Add(this.btnReload_MongoDB);
            this.Controls.Add(this.lblId_MySQL);
            this.Controls.Add(this.lblId_MongoDB);
            this.Controls.Add(this.lblTitle_MySql);
            this.Controls.Add(this.lblTitle_MongoDB);
            this.Controls.Add(this.lblLastNameInsert_MongoDB);
            this.Controls.Add(this.lblFirstNameInsert_MongoDB);
            this.Controls.Add(this.lblAgeInsert_MySQL);
            this.Controls.Add(this.lbFirstNameInsert_MySQL);
            this.Controls.Add(this.lblLastName_MongoDB);
            this.Controls.Add(this.lblFirstName_MongoDB);
            this.Controls.Add(this.btnInsert_MongoDB);
            this.Controls.Add(this.btnInsert_MySQL);
            this.Controls.Add(this.btnUpdate_MongoDB);
            this.Controls.Add(this.btnDelete_MongoDB);
            this.Controls.Add(this.txtLastNameInsert_MongoDB);
            this.Controls.Add(this.txtFirstNameInsert_MongoDB);
            this.Controls.Add(this.txtAgeInsert_MySQL);
            this.Controls.Add(this.txtFirstNameInsert_MySQL);
            this.Controls.Add(this.txtLastName_MongoDB);
            this.Controls.Add(this.txtName_MongoDB);
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
        private System.Windows.Forms.TextBox txtLastName_MongoDB;
        private System.Windows.Forms.TextBox txtFirstNameInsert_MySQL;
        private System.Windows.Forms.TextBox txtAgeInsert_MySQL;
        private System.Windows.Forms.TextBox txtFirstNameInsert_MongoDB;
        private System.Windows.Forms.TextBox txtLastNameInsert_MongoDB;
        private System.Windows.Forms.Button btnDelete_MongoDB;
        private System.Windows.Forms.Button btnUpdate_MongoDB;
        private System.Windows.Forms.Button btnInsert_MySQL;
        private System.Windows.Forms.Button btnInsert_MongoDB;
        private System.Windows.Forms.Label lblFirstName_MongoDB;
        private System.Windows.Forms.Label lblLastName_MongoDB;
        private System.Windows.Forms.Label lbFirstNameInsert_MySQL;
        private System.Windows.Forms.Label lblAgeInsert_MySQL;
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
        private System.Windows.Forms.Label lblCourses_MongoDB;
        private System.Windows.Forms.TextBox txtCoursesInsert_MongoDB;
        private System.Windows.Forms.TextBox txtLastNameInsert_MySQL;
        private System.Windows.Forms.Label lblCoursesInsert_MongoDB;
        private System.Windows.Forms.Label lblLastName_MySQL;
        private System.Windows.Forms.TextBox txtCourse_MongoDB;
        private System.Windows.Forms.Label lbltCourseNote_MongoDB;
        private System.Windows.Forms.Label lblInsertLecturer;
        private System.Windows.Forms.TextBox txtInsertLecturer;
        private System.Windows.Forms.Button btnInsertLecturer_MongoDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAssignCourse_MongoDB;
        private System.Windows.Forms.Button btnAssign_MongoDBB;
        private System.Windows.Forms.TextBox txtInsertCourseToCourses_MongoDB;
        private System.Windows.Forms.Button btnInsertCourseToCourses_MongoDB;
    }
}
