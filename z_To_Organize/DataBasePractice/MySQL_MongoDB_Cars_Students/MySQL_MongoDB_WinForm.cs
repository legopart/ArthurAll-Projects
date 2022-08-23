using DataBaseOOP;
using MySQL_MongoDB_Cars_StudentsNet4_7.Classes;
using System;
using System.Windows.Forms;
namespace MySQL_MongoDB_Cars_StudentsNet4_7
{
    public partial class MySQL_MongoDB_WinForm : Form
    {
        
        public static Students selectedRowStudent;
        public static Car selectedRowCar;
        public MongoDb mongoDb = new MongoDb();
        public MySQL mySQL = new MySQL("localhost", "root", "admin", "autosrade");
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
            Students.SetList_DataTable(mongoDb);
            dgrdMongoDB.DataSource = Students.MongoDBResultTable;
        }
        public void GetCorrentRow_MongoDB()          //DataGridView dgrdStudents
        {
            try
            {
                DataGridViewRow studentCurrentRow = dgrdMongoDB.CurrentRow;
                if (studentCurrentRow != null)
                {
                    object id = studentCurrentRow.Cells[0].Value;
                    string firstName = studentCurrentRow.Cells[1].Value.ToString();
                    string lastName = studentCurrentRow.Cells[2].Value.ToString();
                    object course = studentCurrentRow.Cells[3].Value.ToString();
                    selectedRowStudent = new Students(id, firstName, lastName, course);
                    lblId_MongoDB.Text = selectedRowStudent.Id?.ToString();
                    txtName_MongoDB.Text = selectedRowStudent.FirstName;
                    txtLastName_MongoDB.Text = selectedRowStudent.LastName;
                    txtCourse_MongoDB.Text = selectedRowStudent.Course.ToString();
                }
            }
            catch (Exception) {}
        }
        private void btnDelete_MongoDB_Click(object sender, EventArgs e)
            { try { selectedRowStudent?.DeleteOne(mongoDb); LoadTable_MongoDB(); } catch (Exception) { } }
        private void btnInsert_MongoDB_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = txtFirstNameInsert_MongoDB.Text;
                string lastName = txtLastNameInsert_MongoDB.Text;
                object course = txtCoursesInsert_MongoDB.Text;
                Students newStudent = new Students(firstName, lastName, course);
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
                Students updatedStudent = new Students(firstName, lastName, course);
                selectedRowStudent?.UpdateOne(mongoDb, updatedStudent);
                LoadTable_MongoDB();
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        private void btnReload_MongoDB_Click(object sender, EventArgs e) => LoadTable_MongoDB();
#endregion








#region MySQL Region
        private void dgrdMySQL_CellClick(object sender, DataGridViewCellEventArgs e) => GetCorrentRow_MySQL();
        private void dgrdMySQL_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e) => GetCorrentRow_MySQL();
        public void LoadTable_MySQL()
        {
            Car.SetDataTable(mySQL);
            dgrdMySQL.DataSource = Car.MySQLResultTable;
        }
        public void GetCorrentRow_MySQL()          //DataGridView dgrdStudents
        {
            try
            {
                DataGridViewRow carCurrentRow = dgrdMySQL.CurrentRow;
                object id = carCurrentRow.Cells[0].Value;
                string type = carCurrentRow.Cells[1].Value.ToString();
                string description = carCurrentRow.Cells[2].Value.ToString();
                string subDescription = carCurrentRow.Cells[3].Value.ToString();
                string model = carCurrentRow.Cells[4].Value.ToString();
                string priceString = carCurrentRow.Cells[5].Value.ToString();
                int? price = null;
                if(priceString != null &&priceString != "") price = Int32.Parse(priceString);
                selectedRowCar = new Car(id, type, description, subDescription, model, price);
                lblId_MySQL.Text = selectedRowCar.Id?.ToString();
                txtType_MySQL.Text = selectedRowCar.Type;
                txtDescription_MySQL.Text = selectedRowCar.Description;
                txtSubDescription_MySQL.Text= selectedRowCar.SubDescription;
                txtModel_MySQL.Text = selectedRowCar.Model;
                txtPrice_MySQL.Text = selectedRowCar.Price.ToString();
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        private void btnDelete_MySQL_Click(object sender, EventArgs e)
            { try { selectedRowCar?.Delete(mySQL); LoadTable_MySQL(); } catch (Exception) {} }
        private void btnUpdate_MySQL_Click(object sender, EventArgs e)
        {
            try
            {
                string type = txtType_MySQL.Text;
                string descriptionn = txtDescription_MySQL.Text;
                string subDescription = txtSubDescription_MySQL.Text;
                string model = txtModel_MySQL.Text;
                string priceString = txtPrice_MySQL.Text;
                int? price = null;
                if (priceString != "") price = Int32.Parse(priceString);
                Car updatedCar = new Car(type, descriptionn, subDescription, model, price);
                selectedRowCar?.Update(mySQL, updatedCar);
                LoadTable_MySQL();
            } catch (Exception) {}
        }
        private void btnInsert_MySQL_Click(object sender, EventArgs e)
        {
            try
            {
                string type = txtTypeInsert_MySQL.Text;
                string descriptionn = txtDescriptionInsert_MySQL.Text;
                string subDescription = txtSubDescriptionInsert_MySQL.Text;
                string model = txtModelInsert_MySQL.Text;
                string priceString = txtPriceInsert_MySQL.Text;
                int? price = null;
                if (priceString != "") price = Int32.Parse(priceString);
                Car newCar = new Car(type, descriptionn, subDescription, model, price);
                newCar.Insert(mySQL);
                LoadTable_MySQL();
                txtTypeInsert_MySQL.Text = "";
                txtPriceInsert_MySQL.Text = "";
            }
            catch (Exception) {}
        }
        private void btnReload_MySQL_Click(object sender, EventArgs e) => LoadTable_MySQL();






        #endregion


    }
}