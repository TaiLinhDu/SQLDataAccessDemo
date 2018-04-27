using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Dashboard : Form
    {
        private List<Person> people = new List<Person>();
        public Dashboard()
        {
            InitializeComponent();
            //people connet to Listbox to display informations
            UpdateBinding();
        }

        private void Form1_Load (object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UpdateBinding()
        {
            peopleFoundListbox.DataSource = people;
            peopleFoundListbox.DisplayMember = "FullInfo";
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //Data Access
            DataAccess db = new DataAccess();

            people = db.GetPeople(lastNameText.Text);
            UpdateBinding();
        }

        private void insertRecordButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.InsertPerson(firstNameInsText.Text, lastNameInsText.Text, emailAddressInsText.Text,
                phoneNumberInsText.Text);

            firstNameInsText.Text = "";
            lastNameInsText.Text = "";
            emailAdressInsText.Text = "";
            phoneNumberInsText.Text = "";
        }
    }
}
