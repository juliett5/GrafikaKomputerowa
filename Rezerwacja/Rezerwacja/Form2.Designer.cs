
namespace Rezerwacja
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Confirm_ask = new System.Windows.Forms.Label();
            this.No_button = new System.Windows.Forms.Button();
            this.Yes_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Confirm_ask
            // 
            this.Confirm_ask.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Confirm_ask.AutoSize = true;
            this.Confirm_ask.Font = new System.Drawing.Font("Segoe UI", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Confirm_ask.Location = new System.Drawing.Point(27, 35);
            this.Confirm_ask.Name = "Confirm_ask";
            this.Confirm_ask.Size = new System.Drawing.Size(660, 52);
            this.Confirm_ask.TabIndex = 0;
            this.Confirm_ask.Text = "Czy chcesz zapisać swoją rezerwację?";
            this.Confirm_ask.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // No_button
            // 
            this.No_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.No_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.No_button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.No_button.Location = new System.Drawing.Point(381, 133);
            this.No_button.Name = "No_button";
            this.No_button.Size = new System.Drawing.Size(120, 53);
            this.No_button.TabIndex = 2;
            this.No_button.Text = "Nie";
            this.No_button.UseVisualStyleBackColor = false;
            this.No_button.Click += new System.EventHandler(this.No_button_Click);
            // 
            // Yes_button
            // 
            this.Yes_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Yes_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Yes_button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Yes_button.Location = new System.Drawing.Point(215, 133);
            this.Yes_button.Name = "Yes_button";
            this.Yes_button.Size = new System.Drawing.Size(120, 53);
            this.Yes_button.TabIndex = 3;
            this.Yes_button.Text = "Tak";
            this.Yes_button.UseVisualStyleBackColor = false;
            this.Yes_button.Click += new System.EventHandler(this.Yes_button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 282);
            this.Controls.Add(this.Yes_button);
            this.Controls.Add(this.No_button);
            this.Controls.Add(this.Confirm_ask);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Confirm_ask;
        private System.Windows.Forms.Button No_button;
        private System.Windows.Forms.Button Yes_button;
    }
}