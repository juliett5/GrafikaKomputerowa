using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezerwacja
{
   
    public partial class Form1 : Form
    {
        private bool name_text_changed = false;
        private bool surname_text_changed = false;
        private bool phone_text_changed = false;
        private bool email_text_changed = false;
        private bool hour_text_changed = false;
        private bool number_of_people_text_changed = false;
        private bool date_calender_text_changed = false;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Hour_text.Items.Add("10");
            Hour_text.Items.Add("11");
            Hour_text.Items.Add("12");

            Number_of_people_text.Items.Add("1");
            Number_of_people_text.Items.Add("2");
            Number_of_people_text.Items.Add("3");

        }

        private void Choose_Click(object sender, EventArgs e)
        {
            DateTime date = Date_calender.TodayDate;

            if (Date_calender.SelectionRange.Start >= Date_calender.TodayDate)
            {
                Show_date.Text = Date_calender.SelectionRange.Start.ToShortDateString();
            }
        }

        private void Name_text_TextChanged(object sender, EventArgs e)
        {

            if (Name_text.Text.Length == 0)
            {
                name_text_changed = false;
            }
            else name_text_changed = true;
        }

        private void Surname_text_TextChanged(object sender, EventArgs e)
        {
            surname_text_changed = true;
        }

        private void Phone_text_TextChanged(object sender, EventArgs e)
        {
            phone_text_changed = true;
        }

        private void Email_text_TextChanged(object sender, EventArgs e)
        {
            email_text_changed = true;
        }

        private void Hour_text_SelectedIndexChanged(object sender, EventArgs e)
        {
            hour_text_changed = true;
        }

        private void Number_of_people_text_SelectedIndexChanged(object sender, EventArgs e)
        {
            number_of_people_text_changed = true;
        }

        private void Date_calender_DateChanged(object sender, DateRangeEventArgs e)
        {
            date_calender_text_changed = true;
        }
        private void Confirm_Click(object sender, EventArgs e)
        {
            if (name_text_changed == false || surname_text_changed == false || phone_text_changed == false ||
                email_text_changed == false || hour_text_changed == false ||
                number_of_people_text_changed == false || date_calender_text_changed == false)
            {
                Confirm.Text = "Wymagane pola nie zostały wypełnione";
            }
            else
            {
                Confirm.Text = "Zatwierdź rezerwację";
                Form2 x = new Form2();
                x.ShowDialog();
            }

            

        }

      
    }
}
