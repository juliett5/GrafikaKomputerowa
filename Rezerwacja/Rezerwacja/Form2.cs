using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dapper;

namespace Rezerwacja
{
    public partial class Form2 : Form
    {
     
        public Form2()
        {
            InitializeComponent();
        }

        private void No_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Yes_button_Click(object sender, EventArgs e)
        {
         
        }
    }
}
