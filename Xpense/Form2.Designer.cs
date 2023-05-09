namespace Xpense
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
            this.SubmitButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.CarTextBox = new System.Windows.Forms.TextBox();
            this.SchoolTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OthersTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.HouseTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UnpredictedTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PetsTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(347, 168);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(85, 39);
            this.SubmitButton.TabIndex = 0;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            this.SubmitButton.Enter += new System.EventHandler(this.SubmitButton_Enter);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(276, 26);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTimePicker1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Car";
            // 
            // CarTextBox
            // 
            this.CarTextBox.Location = new System.Drawing.Point(136, 120);
            this.CarTextBox.Name = "CarTextBox";
            this.CarTextBox.Size = new System.Drawing.Size(100, 26);
            this.CarTextBox.TabIndex = 5;
            this.CarTextBox.Enter += new System.EventHandler(this.CarTextBox_Enter);
            this.CarTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CarTextBox_KeyPress);
            this.CarTextBox.Leave += new System.EventHandler(this.CarTextBox_Leave);
            // 
            // SchoolTextBox
            // 
            this.SchoolTextBox.Location = new System.Drawing.Point(136, 152);
            this.SchoolTextBox.Name = "SchoolTextBox";
            this.SchoolTextBox.Size = new System.Drawing.Size(100, 26);
            this.SchoolTextBox.TabIndex = 7;
            this.SchoolTextBox.Enter += new System.EventHandler(this.SchoolTextBox_Enter);
            this.SchoolTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SchoolTextBox_KeyPress);
            this.SchoolTextBox.Leave += new System.EventHandler(this.SchoolTextBox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "School";
            // 
            // OthersTextBox
            // 
            this.OthersTextBox.Location = new System.Drawing.Point(136, 216);
            this.OthersTextBox.Name = "OthersTextBox";
            this.OthersTextBox.Size = new System.Drawing.Size(100, 26);
            this.OthersTextBox.TabIndex = 11;
            this.OthersTextBox.Enter += new System.EventHandler(this.OthersTextBox_Enter);
            this.OthersTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OthersTextBox_KeyPress);
            this.OthersTextBox.Leave += new System.EventHandler(this.OthersTextBox_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Others";
            // 
            // HouseTextBox
            // 
            this.HouseTextBox.Location = new System.Drawing.Point(136, 88);
            this.HouseTextBox.Name = "HouseTextBox";
            this.HouseTextBox.Size = new System.Drawing.Size(100, 26);
            this.HouseTextBox.TabIndex = 9;
            this.HouseTextBox.Enter += new System.EventHandler(this.HouseTextBox_Enter);
            this.HouseTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HouseTextBox_KeyPress);
            this.HouseTextBox.Leave += new System.EventHandler(this.HouseTextBox_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "House";
            // 
            // UnpredictedTextBox
            // 
            this.UnpredictedTextBox.Location = new System.Drawing.Point(136, 248);
            this.UnpredictedTextBox.Name = "UnpredictedTextBox";
            this.UnpredictedTextBox.Size = new System.Drawing.Size(100, 26);
            this.UnpredictedTextBox.TabIndex = 13;
            this.UnpredictedTextBox.Enter += new System.EventHandler(this.UnpredictedTextBox_Enter);
            this.UnpredictedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UnpredictedTextBox_KeyPress);
            this.UnpredictedTextBox.Leave += new System.EventHandler(this.UnpredictedTextBox_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Unpredicted";
            // 
            // PetsTextBox
            // 
            this.PetsTextBox.Location = new System.Drawing.Point(136, 184);
            this.PetsTextBox.Name = "PetsTextBox";
            this.PetsTextBox.Size = new System.Drawing.Size(100, 26);
            this.PetsTextBox.TabIndex = 15;
            this.PetsTextBox.Enter += new System.EventHandler(this.PetsTextBox_Enter);
            this.PetsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PetsTextBox_KeyPress);
            this.PetsTextBox.Leave += new System.EventHandler(this.PetsTextBox_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Pets";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(360, 94);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(31, 20);
            this.TotalLabel.TabIndex = 16;
            this.TotalLabel.Text = "n/a";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 306);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.PetsTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.UnpredictedTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OthersTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HouseTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SchoolTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CarTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.SubmitButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CarTextBox;
        private System.Windows.Forms.TextBox SchoolTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OthersTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox HouseTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UnpredictedTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PetsTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label TotalLabel;
    }
}