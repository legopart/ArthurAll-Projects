using DataBaseOOP;
using ExamMySQL_MongoDB.Classes;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Windows.Forms;
namespace ExamMySQL_MongoDB
{
    public partial class MySQL_MongoDB_WinForm : Form
    {
        
        public static StudentMongo? selectedRowStudent_MongoDB;
        public static StudentMySQL? selectedRowStudent_MySQL;
        public MongoDb mongoDb = new MongoDb();
        public MySQL mySQL = new MySQL();
        public MySQL_MongoDB_WinForm()
        {
            InitializeComponent();
            LoadTable_MongoDB();
            LoadTable_MySQL();
        }
        private void MySQL_MongoDB_WinForm_Load(object sender, EventArgs e){}
#region MongoDB Region
        private void dgrdMongoDB_CellClick(object sender, DataGridViewCellEventArgs e) => GetCorrentRow_MongoDB();
        private void dgrdMongoDB_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e) => GetCorrentRow_MongoDB();
        public void LoadTable_MongoDB()
        {
            StudentMongo.SetList_DataTable(mongoDb);
            dgrdMongoDB.DataSource = StudentMongo.MongoDBResultTable;
        }
        public void GetCorrentRow_MongoDB()          //DataGridView dgrdStudents
        {
            try
            {
                DataGridViewRow studentCurrentRow = dgrdMongoDB.CurrentRow;
                if (studentCurrentRow != null)
                {
                    object id = studentCurrentRow.Cells[0].Value;
                    string? firstName = studentCurrentRow.Cells[1].Value.ToString();
                    string? lastName = studentCurrentRow.Cells[2].Value.ToString();
                    object? course = studentCurrentRow.Cells[3].Value.ToString();
                    selectedRowStudent_MongoDB = new StudentMongo(id, firstName, lastName, course);
                    lblId_MongoDB.Text = selectedRowStudent_MongoDB.Id?.ToString();
                    txtName_MongoDB.Text = selectedRowStudent_MongoDB.FirstName;
                    txtLastName_MongoDB.Text = selectedRowStudent_MongoDB.LastName;
                    txtCourse_MongoDB.Text = selectedRowStudent_MongoDB.Course.ToString();
                }
            }
            catch (Exception) {}
        }
        private void btnDelete_MongoDB_Click(object sender, EventArgs e)
            { try { selectedRowStudent_MongoDB?.DeleteOne(mongoDb); LoadTable_MongoDB(); } catch (Exception) { } }
        private void btnInsert_MongoDB_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = txtFirstNameInsert_MongoDB.Text;
                string lastName = txtLastNameInsert_MongoDB.Text;
                object course = txtCoursesInsert_MongoDB.Text;
                StudentMongo newStudent = new StudentMongo(firstName, lastName, course);
                newStudent.InsertOne(mongoDb);
                LoadTable_MongoDB();
                txtFirstNameInsert_MongoDB.Text = "";
                txtLastNameInsert_MongoDB.Text = "";
                txtCoursesInsert_MongoDB.Text = "";
            }
            catch (Exception) {}
        }
        private void btnUpdate_MongoDB_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = txtName_MongoDB.Text;
                string lastName = txtLastName_MongoDB.Text;
                object course = txtCourse_MongoDB.Text;
                StudentMongo updatedStudent = new StudentMongo(firstName, lastName, course);
                selectedRowStudent_MongoDB?.UpdateOne(mongoDb, updatedStudent);
                LoadTable_MongoDB();
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        private void btnReload_MongoDB_Click(object sender, EventArgs e) => LoadTable_MongoDB();


        private void btnInsertLecturer_MongoDB_Click(object sender, EventArgs e)
        {
            mongoDb.DBCollectionString = "Lecturer";
            string lecturerName = txtInsertLecturer.Text;
            BsonDocument document = new BsonDocument { { "Name", lecturerName } };
            mongoDb.InsertOne(document);
            txtInsertLecturer.Text = "";


        }
        private void btnAssign_MongoDBB_Click(object sender, EventArgs e)
        {
            mongoDb.DBCollectionString = "Students";
            string assingCourse = txtAssignCourse_MongoDB.Text;
            object id = selectedRowStudent_MongoDB?.Id;

            FilterDefinitionBuilder<BsonDocument> builder = Builders<BsonDocument>.Filter;
            FilterDefinition<BsonDocument> filter = builder.Eq("_id", ObjectId.Parse(id?.ToString()));
            UpdateDefinition<BsonDocument> update = Builders<BsonDocument>.Update.Push("Course", new BsonDocument("CourseName", assingCourse));
            mongoDb.UpdateOne(filter, update);
            txtAssignCourse_MongoDB.Text = "";
            LoadTable_MongoDB(); ;
        }
        private void btnInsertCourseToCourses_MongoDB_Click(object sender, EventArgs e)
        {
            mongoDb.DBCollectionString = "Courses";
            string courseName = txtInsertCourseToCourses_MongoDB.Text;
            BsonDocument document = new BsonDocument { { "Name", courseName } };
            mongoDb.InsertOne(document);
            txtInsertCourseToCourses_MongoDB.Text = "";
        }

        #endregion



#region MySQL Region
        public void LoadTable_MySQL()
        {
            StudentMySQL.SetDataTable(mySQL);
            dgrdMySQL.DataSource = StudentMySQL.MySQLResultTable;
        }
        private void btnInsert_MySQL_Click(object sender, EventArgs e)
        {
            try
            {
                string firstname = txtFirstNameInsert_MySQL.Text;
                string lastname = txtLastNameInsert_MySQL.Text;
                string ageString = txtAgeInsert_MySQL.Text;
                int? age = null;
                if (ageString != "") age = Int32.Parse(ageString);
                StudentMySQL newCar = new StudentMySQL(firstname, lastname, age);
                newCar.Insert(mySQL);
                LoadTable_MySQL();
                txtFirstNameInsert_MySQL.Text = "";
                txtLastNameInsert_MySQL.Text = "";
                txtAgeInsert_MySQL.Text = "";
            }
            catch (Exception) {}
        }
        private void btnReload_MySQL_Click(object sender, EventArgs e) => LoadTable_MySQL();

        #endregion


    }
}