
namespace Rezerwacja
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Title = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Date_calender = new System.Windows.Forms.MonthCalendar();
            this.Data = new System.Windows.Forms.Panel();
            this.Show_date = new System.Windows.Forms.Label();
            this.Choose = new System.Windows.Forms.Button();
            this.Confirm = new System.Windows.Forms.Button();
            this.Comments_text = new System.Windows.Forms.RichTextBox();
            this.User_comments = new System.Windows.Forms.Label();
            this.User_number_of_people = new System.Windows.Forms.Label();
            this.User_date = new System.Windows.Forms.Label();
            this.User_hour = new System.Windows.Forms.Label();
            this.User_email = new System.Windows.Forms.Label();
            this.User_phone = new System.Windows.Forms.Label();
            this.User_surname = new System.Windows.Forms.Label();
            this.User_name = new System.Windows.Forms.Label();
            this.Email_text = new System.Windows.Forms.TextBox();
            this.Phone_text = new System.Windows.Forms.TextBox();
            this.Surname_text = new System.Windows.Forms.TextBox();
            this.Name_text = new System.Windows.Forms.TextBox();
            this.Number_of_people_text = new System.Windows.Forms.ComboBox();
            this.Hour_text = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Bernard MT Condensed", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Title.ForeColor = System.Drawing.SystemColors.Window;
            this.Title.Location = new System.Drawing.Point(40, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(481, 114);
            this.Title.TabIndex = 1;
            this.Title.Text = "Rezerwacja";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(355, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 23);
            this.textBox1.TabIndex = 1;
            // 
            // Date_calender
            // 
            this.Date_calender.Location = new System.Drawing.Point(340, 61);
            this.Date_calender.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.Date_calender.MinDate = new System.DateTime(2020, 6, 1, 0, 0, 0, 0);
            this.Date_calender.Name = "Date_calender";
            this.Date_calender.TabIndex = 3;
            this.Date_calender.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Date_calender_DateChanged);
            // 
            // Data
            // 
            this.Data.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Data.BackColor = System.Drawing.Color.Transparent;
            this.Data.Controls.Add(this.Show_date);
            this.Data.Controls.Add(this.Choose);
            this.Data.Controls.Add(this.Confirm);
            this.Data.Controls.Add(this.Comments_text);
            this.Data.Controls.Add(this.User_comments);
            this.Data.Controls.Add(this.User_number_of_people);
            this.Data.Controls.Add(this.User_date);
            this.Data.Controls.Add(this.User_hour);
            this.Data.Controls.Add(this.User_email);
            this.Data.Controls.Add(this.User_phone);
            this.Data.Controls.Add(this.User_surname);
            this.Data.Controls.Add(this.User_name);
            this.Data.Controls.Add(this.Email_text);
            this.Data.Controls.Add(this.Phone_text);
            this.Data.Controls.Add(this.Surname_text);
            this.Data.Controls.Add(this.Name_text);
            this.Data.Controls.Add(this.Number_of_people_text);
            this.Data.Controls.Add(this.Hour_text);
            this.Data.Controls.Add(this.Date_calender);
            this.Data.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Data.Location = new System.Drawing.Point(40, 137);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(618, 455);
            this.Data.TabIndex = 1;
            // 
            // Show_date
            // 
            this.Show_date.AutoSize = true;
            this.Show_date.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Show_date.ForeColor = System.Drawing.SystemColors.Window;
            this.Show_date.Location = new System.Drawing.Point(340, 232);
            this.Show_date.Name = "Show_date";
            this.Show_date.Size = new System.Drawing.Size(123, 25);
            this.Show_date.TabIndex = 23;
            this.Show_date.Text = "Wybierz datę";
            // 
            // Choose
            // 
            this.Choose.BackColor = System.Drawing.Color.Goldenrod;
            this.Choose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Choose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Choose.Location = new System.Drawing.Point(507, 229);
            this.Choose.Name = "Choose";
            this.Choose.Size = new System.Drawing.Size(102, 32);
            this.Choose.TabIndex = 22;
            this.Choose.Text = "Wybierz";
            this.Choose.UseVisualStyleBackColor = false;
            this.Choose.Click += new System.EventHandler(this.Choose_Click);
            // 
            // Confirm
            // 
            this.Confirm.BackColor = System.Drawing.Color.Goldenrod;
            this.Confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Confirm.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Confirm.Location = new System.Drawing.Point(30, 406);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(579, 46);
            this.Confirm.TabIndex = 21;
            this.Confirm.Text = "Zarezerwuj stolik";
            this.Confirm.UseVisualStyleBackColor = false;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // Comments_text
            // 
            this.Comments_text.Location = new System.Drawing.Point(340, 297);
            this.Comments_text.Name = "Comments_text";
            this.Comments_text.Size = new System.Drawing.Size(269, 82);
            this.Comments_text.TabIndex = 20;
            this.Comments_text.Text = "";
            // 
            // User_comments
            // 
            this.User_comments.AutoSize = true;
            this.User_comments.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.User_comments.ForeColor = System.Drawing.SystemColors.Window;
            this.User_comments.Location = new System.Drawing.Point(340, 264);
            this.User_comments.Name = "User_comments";
            this.User_comments.Size = new System.Drawing.Size(70, 30);
            this.User_comments.TabIndex = 18;
            this.User_comments.Text = "Uwagi";
            // 
            // User_number_of_people
            // 
            this.User_number_of_people.AutoSize = true;
            this.User_number_of_people.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.User_number_of_people.ForeColor = System.Drawing.SystemColors.Window;
            this.User_number_of_people.Location = new System.Drawing.Point(30, 323);
            this.User_number_of_people.Name = "User_number_of_people";
            this.User_number_of_people.Size = new System.Drawing.Size(131, 30);
            this.User_number_of_people.TabIndex = 17;
            this.User_number_of_people.Text = "Liczba osób*";
            // 
            // User_date
            // 
            this.User_date.AutoSize = true;
            this.User_date.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.User_date.ForeColor = System.Drawing.SystemColors.Window;
            this.User_date.Location = new System.Drawing.Point(340, 28);
            this.User_date.Name = "User_date";
            this.User_date.Size = new System.Drawing.Size(66, 30);
            this.User_date.TabIndex = 16;
            this.User_date.Text = "Data*";
            // 
            // User_hour
            // 
            this.User_hour.AutoSize = true;
            this.User_hour.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.User_hour.ForeColor = System.Drawing.SystemColors.Window;
            this.User_hour.Location = new System.Drawing.Point(30, 264);
            this.User_hour.Name = "User_hour";
            this.User_hour.Size = new System.Drawing.Size(98, 30);
            this.User_hour.TabIndex = 15;
            this.User_hour.Text = "Godzina*";
            // 
            // User_email
            // 
            this.User_email.AutoSize = true;
            this.User_email.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.User_email.ForeColor = System.Drawing.SystemColors.Window;
            this.User_email.Location = new System.Drawing.Point(30, 205);
            this.User_email.Name = "User_email";
            this.User_email.Size = new System.Drawing.Size(80, 30);
            this.User_email.TabIndex = 14;
            this.User_email.Text = "E-mail*";
            // 
            // User_phone
            // 
            this.User_phone.AutoSize = true;
            this.User_phone.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.User_phone.ForeColor = System.Drawing.SystemColors.Window;
            this.User_phone.Location = new System.Drawing.Point(30, 146);
            this.User_phone.Name = "User_phone";
            this.User_phone.Size = new System.Drawing.Size(89, 30);
            this.User_phone.TabIndex = 13;
            this.User_phone.Text = "Telefon*";
            // 
            // User_surname
            // 
            this.User_surname.AutoSize = true;
            this.User_surname.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.User_surname.ForeColor = System.Drawing.SystemColors.Window;
            this.User_surname.Location = new System.Drawing.Point(30, 87);
            this.User_surname.Name = "User_surname";
            this.User_surname.Size = new System.Drawing.Size(110, 30);
            this.User_surname.TabIndex = 12;
            this.User_surname.Text = "Nazwisko*";
            // 
            // User_name
            // 
            this.User_name.AutoSize = true;
            this.User_name.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.User_name.ForeColor = System.Drawing.SystemColors.Window;
            this.User_name.Location = new System.Drawing.Point(30, 28);
            this.User_name.Name = "User_name";
            this.User_name.Size = new System.Drawing.Size(62, 30);
            this.User_name.TabIndex = 11;
            this.User_name.Text = "Imię*";
            // 
            // Email_text
            // 
            this.Email_text.Location = new System.Drawing.Point(30, 238);
            this.Email_text.Name = "Email_text";
            this.Email_text.Size = new System.Drawing.Size(201, 23);
            this.Email_text.TabIndex = 10;
            this.Email_text.TextChanged += new System.EventHandler(this.Email_text_TextChanged);
            // 
            // Phone_text
            // 
            this.Phone_text.Location = new System.Drawing.Point(30, 179);
            this.Phone_text.Name = "Phone_text";
            this.Phone_text.Size = new System.Drawing.Size(201, 23);
            this.Phone_text.TabIndex = 9;
            this.Phone_text.TextChanged += new System.EventHandler(this.Phone_text_TextChanged);
            // 
            // Surname_text
            // 
            this.Surname_text.Location = new System.Drawing.Point(30, 120);
            this.Surname_text.Name = "Surname_text";
            this.Surname_text.Size = new System.Drawing.Size(201, 23);
            this.Surname_text.TabIndex = 8;
            this.Surname_text.TextChanged += new System.EventHandler(this.Surname_text_TextChanged);
            // 
            // Name_text
            // 
            this.Name_text.BackColor = System.Drawing.Color.White;
            this.Name_text.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name_text.Location = new System.Drawing.Point(30, 61);
            this.Name_text.Name = "Name_text";
            this.Name_text.Size = new System.Drawing.Size(201, 23);
            this.Name_text.TabIndex = 7;
            this.Name_text.TextChanged += new System.EventHandler(this.Name_text_TextChanged);
            // 
            // Number_of_people_text
            // 
            this.Number_of_people_text.BackColor = System.Drawing.Color.White;
            this.Number_of_people_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Number_of_people_text.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Number_of_people_text.FormattingEnabled = true;
            this.Number_of_people_text.Location = new System.Drawing.Point(30, 356);
            this.Number_of_people_text.Name = "Number_of_people_text";
            this.Number_of_people_text.Size = new System.Drawing.Size(201, 23);
            this.Number_of_people_text.TabIndex = 6;
            this.Number_of_people_text.SelectedIndexChanged += new System.EventHandler(this.Number_of_people_text_SelectedIndexChanged);
            // 
            // Hour_text
            // 
            this.Hour_text.BackColor = System.Drawing.Color.White;
            this.Hour_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Hour_text.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Hour_text.ForeColor = System.Drawing.Color.Black;
            this.Hour_text.FormattingEnabled = true;
            this.Hour_text.Location = new System.Drawing.Point(30, 297);
            this.Hour_text.Name = "Hour_text";
            this.Hour_text.Size = new System.Drawing.Size(201, 23);
            this.Hour_text.TabIndex = 2;
            this.Hour_text.SelectedIndexChanged += new System.EventHandler(this.Hour_text_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(513, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1225, 615);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.Title);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Data.ResumeLayout(false);
            this.Data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MonthCalendar Date_calender;
        private System.Windows.Forms.Panel Data;
        private System.Windows.Forms.RichTextBox Comments_text;
        private System.Windows.Forms.Label User_comments;
        private System.Windows.Forms.Label User_number_of_people;
        private System.Windows.Forms.Label User_date;
        private System.Windows.Forms.Label User_hour;
        private System.Windows.Forms.Label User_email;
        private System.Windows.Forms.Label User_phone;
        private System.Windows.Forms.Label User_surname;
        private System.Windows.Forms.Label User_name;
        private System.Windows.Forms.TextBox Email_text;
        private System.Windows.Forms.TextBox Phone_text;
        private System.Windows.Forms.TextBox Surname_text;
        private System.Windows.Forms.TextBox Name_text;
        private System.Windows.Forms.ComboBox Number_of_people_text;
        private System.Windows.Forms.ComboBox Hour_text;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Label Show_date;
        private System.Windows.Forms.Button Choose;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

