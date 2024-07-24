namespace HebrewDate
{
    partial class DateSelect
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
            label_Title = new Label();
            label_dayInWeek = new Label();
            label_dayInMonth = new Label();
            label_month = new Label();
            label_year = new Label();
            comboBox_year = new ComboBox();
            button_CorrectDate = new Button();
            comboBox2 = new ComboBox();
            comboBoxdayInMonth = new ComboBox();
            comboBox_month = new ComboBox();
            SuspendLayout();
            // 
            // label_Title
            // 
            label_Title.AutoSize = true;
            label_Title.Location = new Point(322, 44);
            label_Title.Name = "label_Title";
            label_Title.Size = new Size(117, 25);
            label_Title.TabIndex = 0;
            label_Title.Text = "כתיבת תאריך";
            // 
            // label_dayInWeek
            // 
            label_dayInWeek.AutoSize = true;
            label_dayInWeek.Location = new Point(829, 114);
            label_dayInWeek.Name = "label_dayInWeek";
            label_dayInWeek.RightToLeft = RightToLeft.Yes;
            label_dayInWeek.Size = new Size(101, 25);
            label_dayInWeek.TabIndex = 1;
            label_dayInWeek.Text = "היום בשבוע";
            // 
            // label_dayInMonth
            // 
            label_dayInMonth.AutoSize = true;
            label_dayInMonth.Location = new Point(563, 114);
            label_dayInMonth.Name = "label_dayInMonth";
            label_dayInMonth.RightToLeft = RightToLeft.Yes;
            label_dayInMonth.Size = new Size(101, 25);
            label_dayInMonth.TabIndex = 2;
            label_dayInMonth.Text = "היום בחודש";
            // 
            // label_month
            // 
            label_month.AutoSize = true;
            label_month.Location = new Point(317, 114);
            label_month.Name = "label_month";
            label_month.RightToLeft = RightToLeft.Yes;
            label_month.Size = new Size(52, 25);
            label_month.TabIndex = 3;
            label_month.Text = "חודש";
            // 
            // label_year
            // 
            label_year.AutoSize = true;
            label_year.Location = new Point(88, 114);
            label_year.Name = "label_year";
            label_year.RightToLeft = RightToLeft.Yes;
            label_year.Size = new Size(45, 25);
            label_year.TabIndex = 4;
            label_year.Text = "שנה";
            // 
            // comboBox_year
            // 
            comboBox_year.FormattingEnabled = true;
            comboBox_year.Items.AddRange(new object[] { "תשפ\"ד", "תשפ\"ה", "תשפ\"ו", "תשפ\"ז", "תשפ\"ח", "תשפ\"ט", "תש\"צ", "תשצ\"א", "תשצ\"ב", "תשצ\"ג" });
            comboBox_year.Location = new Point(41, 162);
            comboBox_year.Name = "comboBox_year";
            comboBox_year.RightToLeft = RightToLeft.Yes;
            comboBox_year.Size = new Size(182, 33);
            comboBox_year.TabIndex = 5;
            comboBox_year.Text = "בחר שנה";
            // 
            // button_CorrectDate
            // 
            button_CorrectDate.Location = new Point(358, 620);
            button_CorrectDate.Name = "button_CorrectDate";
            button_CorrectDate.RightToLeft = RightToLeft.Yes;
            button_CorrectDate.Size = new Size(112, 34);
            button_CorrectDate.TabIndex = 6;
            button_CorrectDate.Text = "הצג נוסח תאריך";
            button_CorrectDate.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "ראשון", "שני", "שלישי", "רביעי", "חמישי", "ששי" });
            comboBox2.Location = new Point(773, 162);
            comboBox2.Name = "comboBox2";
            comboBox2.RightToLeft = RightToLeft.Yes;
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 7;
            comboBox2.Text = "בחר יום בשבוע";
            // 
            // comboBoxdayInMonth
            // 
            comboBoxdayInMonth.FormattingEnabled = true;
            comboBoxdayInMonth.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" });
            comboBoxdayInMonth.Location = new Point(521, 162);
            comboBoxdayInMonth.Name = "comboBoxdayInMonth";
            comboBoxdayInMonth.RightToLeft = RightToLeft.Yes;
            comboBoxdayInMonth.Size = new Size(182, 33);
            comboBoxdayInMonth.TabIndex = 8;
            comboBoxdayInMonth.Text = "בחר יום בחודש";
            // 
            // comboBox_month
            // 
            comboBox_month.FormattingEnabled = true;
            comboBox_month.Items.AddRange(new object[] { "תשרי", "מרחשון", "כסלו", "טבת", "שבט", "אדר", "אדר הראשון", "אדר השני", "ניסן", "אייר", "סיון", "תמוז", "אב", "אלול" });
            comboBox_month.Location = new Point(257, 162);
            comboBox_month.Name = "comboBox_month";
            comboBox_month.RightToLeft = RightToLeft.Yes;
            comboBox_month.Size = new Size(182, 33);
            comboBox_month.TabIndex = 9;
            comboBox_month.Text = "בחר חודש";
            // 
            // DateSelect
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 729);
            Controls.Add(comboBox_month);
            Controls.Add(comboBoxdayInMonth);
            Controls.Add(comboBox2);
            Controls.Add(button_CorrectDate);
            Controls.Add(comboBox_year);
            Controls.Add(label_year);
            Controls.Add(label_month);
            Controls.Add(label_dayInMonth);
            Controls.Add(label_dayInWeek);
            Controls.Add(label_Title);
            Name = "DateSelect";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Title;
        private Label label_dayInWeek;
        private Label label_dayInMonth;
        private Label label_month;
        private Label label_year;
        private ComboBox comboBox_year;
        private Button button_CorrectDate;
        private ComboBox comboBox2;
        private ComboBox comboBoxdayInMonth;
        private ComboBox comboBox_month;
    }
}
