using System;
using System.IO;
using System.Windows.Forms;

namespace Xpense
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            EmptyAllBoxes();
           
        }


        private void SubmitButton_Click(object sender, EventArgs e)
        {
            // submit
            int day = dateTimePicker1.Value.Day;
            int month = dateTimePicker1.Value.Month;
            int year = dateTimePicker1.Value.Year;
            decimal house = Convert.ToDecimal(HouseTextBox.Text);
            decimal  school = Convert.ToDecimal(SchoolTextBox.Text);
            decimal car = Convert.ToDecimal(CarTextBox.Text);
            decimal pets = Convert.ToDecimal(PetsTextBox.Text);
            decimal others = Convert.ToDecimal(OthersTextBox.Text);
            decimal unpredicted = Convert.ToDecimal(UnpredictedTextBox.Text);
            EmptyAllBoxes();
            TotalLabel.Text = $"The total for the the day is : {house + school + car + pets + others + unpredicted}";

            Directory.CreateDirectory(FilePaths.AppFolder + $@"\Values\{UserData.Username}\");

            StreamWriter writeHouse = new StreamWriter(FilePaths.AppFolder + $@"\Values\{UserData.Username}\house.txt");
            StreamReader readHouse = new StreamReader(FilePaths.AppFolder + $@"\Values\{UserData.Username}\house.txt");

            StreamWriter writeSchool = new StreamWriter(FilePaths.AppFolder + $@"\Values\{UserData.Username}\school.txt");
            StreamReader readSchool = new StreamReader(FilePaths.AppFolder + $@"\Values\{UserData.Username}\school.txt");

            StreamWriter writeCar = new StreamWriter(FilePaths.AppFolder + $@"\Values\{UserData.Username}\car.txt");
            StreamReader readCar = new StreamReader(FilePaths.AppFolder + $@"\Values\{UserData.Username}\car.txt");

            StreamWriter writePets = new StreamWriter(FilePaths.AppFolder + $@"\Values\{UserData.Username}\pets.txt");
            StreamReader readPets = new StreamReader(FilePaths.AppFolder + $@"\Values\{UserData.Username}\pets.txt");

            StreamWriter writeOthers = new StreamWriter(FilePaths.AppFolder + $@"\Values\{UserData.Username}\others.txt");
            StreamReader readOthers = new StreamReader(FilePaths.AppFolder + $@"\Values\{UserData.Username}\others.txt");

            StreamWriter writeUnpredicted = new StreamWriter(FilePaths.AppFolder + $@"\Values\{UserData.Username}\unpredicted.txt");
            StreamReader readUnpredicted = new StreamReader(FilePaths.AppFolder + $@"\Values\{UserData.Username}\unpredicted.txt");
            

            writeHouse.WriteLine(readHouse.ReadLine() + house);
            writeSchool.WriteLine(readSchool.ReadLine() + school);
            writeCar.WriteLine(readCar.ReadLine() + car);
            writePets.WriteLine(readPets.ReadLine() + pets);
            writeOthers.WriteLine(readOthers.ReadLine() + others);
            writeUnpredicted.WriteLine(readUnpredicted.ReadLine() + unpredicted);

            readCar.Close();
            writeCar.Close();
            readHouse.Close();
            writeHouse.Close();
            readOthers.Close();
            writeOthers.Close();
            readPets.Close();
            writePets.Close();
            readSchool.Close();
            writeSchool.Close();
            readUnpredicted.Close();
            writeUnpredicted.Close();
        }














        void EmptyAllBoxes()
        {
            HouseTextBox.Text = "0";
            SchoolTextBox.Text = "0";
            CarTextBox.Text = "0";
            PetsTextBox.Text = "0";
            OthersTextBox.Text = "0";
            UnpredictedTextBox.Text = "0";
        }

        #region empty / fill boxes on focus
        private void HouseTextBox_Enter(object sender, EventArgs e)
        {
            if(HouseTextBox.Text == "0") HouseTextBox.Text = "";
        }

        private void HouseTextBox_Leave(object sender, EventArgs e)
        {
            if(HouseTextBox.Text == "") HouseTextBox.Text = "0";
        }

        private void CarTextBox_Enter(object sender, EventArgs e)
        {
            if(CarTextBox.Text == "0") CarTextBox.Text = "";
        }

        private void CarTextBox_Leave(object sender, EventArgs e)
        {
            if (CarTextBox.Text == "") CarTextBox.Text = "0";
        }

        private void SchoolTextBox_Enter(object sender, EventArgs e)
        {
           if(SchoolTextBox.Text == "0") SchoolTextBox.Text = "";
        }

        private void SchoolTextBox_Leave(object sender, EventArgs e)
        {
            if (SchoolTextBox.Text == "") SchoolTextBox.Text = "0";
        }

        private void PetsTextBox_Enter(object sender, EventArgs e)
        {
            if (PetsTextBox.Text == "0") PetsTextBox.Text = "";
        }

        private void PetsTextBox_Leave(object sender, EventArgs e)
        {
            if (PetsTextBox.Text == "")  PetsTextBox.Text = "0";
        }

        private void OthersTextBox_Enter(object sender, EventArgs e)
        {
            if (OthersTextBox.Text == "0") OthersTextBox.Text = "";
        }

        private void OthersTextBox_Leave(object sender, EventArgs e)
        {
            if(OthersTextBox.Text == "") OthersTextBox.Text = "0";
        }

        private void UnpredictedTextBox_Enter(object sender, EventArgs e)
        {
            if (UnpredictedTextBox.Text == "0") UnpredictedTextBox.Text = "";
        }

        private void UnpredictedTextBox_Leave(object sender, EventArgs e)
        {
            if (UnpredictedTextBox.Text == "") UnpredictedTextBox.Text = "0";
        }

        #endregion

        #region focus on enter and start focus on date time picker
        private void HouseTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                CarTextBox.Focus();
            }
        }

        private void CarTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SchoolTextBox.Focus();
            }
        }

        private void SchoolTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
               PetsTextBox.Focus();
            }
        }

        private void PetsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
               OthersTextBox.Focus();
            }
        }

        private void OthersTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                UnpredictedTextBox.Focus();
            }
        }

        private void UnpredictedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
               SubmitButton.Focus();
            }
        }

        private void SubmitButton_Enter(object sender, EventArgs e)
        {
            if (HouseTextBox.Text == "0" || CarTextBox.Text == "0" || SchoolTextBox.Text == "0" || PetsTextBox.Text == "0" || OthersTextBox.Text == "0" || UnpredictedTextBox.Text == "0") dateTimePicker1.Focus();
        }

        private void dateTimePicker1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                HouseTextBox.Focus();
            }
        }
        #endregion
    }
}
