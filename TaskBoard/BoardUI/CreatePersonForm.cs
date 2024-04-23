using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoardLibrary;

namespace BoardUI
{
    public partial class CreatePersonForm : Form
    {
        public CreatePersonForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CreatePersonForm_Load(object sender, EventArgs e)
        {

        }

        private void CreatePersonButton_Click(object sender, EventArgs e)
        {
            using (var context = new BoardContext())
            {
                var newPerson = new PersonModel
                {
                    FirstName = "Cezary",
                    LastName = "Storczyk",
                    email = "moj_email@wp.pl"
                };
                context.Persons.Add(newPerson);
                context.SaveChanges();
            }

            //PersonModel model = new PersonModel(
            //        CreateFirstNameValue.Text,
            //        CreateLastNameValue.Text,
            //        CreateEmailValue.Text
            //        );

            


        }
    }
}
