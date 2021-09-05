using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

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
            Hour_text.Items.Add("12:00");
            Hour_text.Items.Add("13:00");
            Hour_text.Items.Add("14:00");
            Hour_text.Items.Add("15:00");
            Hour_text.Items.Add("16:00");
            Hour_text.Items.Add("17:00");
            Hour_text.Items.Add("18:00");
            Hour_text.Items.Add("19:00");
            Hour_text.Items.Add("20:00");

            Number_of_people_text.Items.Add("1");
            Number_of_people_text.Items.Add("2");
            Number_of_people_text.Items.Add("3");
            Number_of_people_text.Items.Add("4");
            Number_of_people_text.Items.Add("5+");
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
                MessageBox.Show("Wypełnij wymagane pola.", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var result = MessageBox.Show("Czy chcesz zatwierdzić rezerwację?", "Uwaga!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SaveToDatabase();
                }
            }
        }
        private bool Date_closed()
        {
            using var db = new SqlConnection("Database=Rezerwacja_stolika;Integrated Security=true;");
            var rezerwacje = db.Query<Rezerwacja>("Select* From Rezerwacja");
            var zarezerwowane = rezerwacje.Where(x => x.Data_rezerwacji == Date_calender.TodayDate.Date).Count();
            return zarezerwowane > 5;
        }
        private void SaveToDatabase()
        {
            using (var db = new SqlConnection("Database=Rezerwacja_stolika;Integrated Security=true;"))
            {
                var time = DateTime.Parse(Hour_text.SelectedItem.ToString());
                if (Date_closed())
                {
                    MessageBox.Show("Nie można dokonać więcej rezerwacji na ten dzień.", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                db.Execute
                (
                "insert into Rezerwacja (Data_rezerwacji, Godzina_rezerwacji, Ilosc_osob, Uwagi, Imie, Nazwisko, Numer_telefonu) values(@data,@godzina,@ilosc,@uwagi,@imie,@nazwisko,@numer)",
                new
                {
                    data = Date_calender.TodayDate.Date,
                    godzina = time,
                    ilosc = Number_of_people_text.SelectedItem,
                    uwagi = Comments_text.Text,
                    imie = Name_text.Text,
                    nazwisko = Surname_text.Text,
                    numer = Phone_text.Text
                }
                );

                MessageBox.Show("Rezerwacja została dokonana. Dziekujemy!");
            }
        }
    }
}
