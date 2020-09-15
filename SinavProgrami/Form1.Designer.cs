namespace SinavProgrami
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.classComBox = new System.Windows.Forms.ComboBox();
            this.timeComBox = new System.Windows.Forms.ComboBox();
            this.classRoomComBox = new System.Windows.Forms.ComboBox();
            this.classRoomLimit = new System.Windows.Forms.Label();
            this.numberOfStudents = new System.Windows.Forms.NumericUpDown();
            this.CreateTableBtn = new System.Windows.Forms.Button();
            this.LessonNameInput = new System.Windows.Forms.TextBox();
            this.TablePanel = new System.Windows.Forms.Panel();
            this.SaveTableBtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LessonMarkCheckBox = new System.Windows.Forms.CheckBox();
            this.TeacherNameText = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfStudents)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 1;
            this.label1.Tag = "";
            this.label1.Text = "DERS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(11, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 2;
            this.label2.Tag = "";
            this.label2.Text = "ÖĞRETMEN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(11, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 24);
            this.label4.TabIndex = 4;
            this.label4.Tag = "";
            this.label4.Text = "DERSLİK";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(11, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 24);
            this.label5.TabIndex = 5;
            this.label5.Tag = "";
            this.label5.Text = "ÖĞRENCİ SAYISI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(11, 98);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 24);
            this.label6.TabIndex = 6;
            this.label6.Tag = "";
            this.label6.Text = "KAÇINCI SINIF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(183, 6);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 24);
            this.label7.TabIndex = 7;
            this.label7.Tag = "";
            this.label7.Text = "TARİH";
            // 
            // classComBox
            // 
            this.classComBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classComBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.classComBox.FormattingEnabled = true;
            this.classComBox.ItemHeight = 21;
            this.classComBox.Items.AddRange(new object[] {
            "SINIF 1 (YEŞİL)",
            "SINIF 2 (MAVİ)",
            "SINIF 3 (PEMBE)",
            "SINIF 4 (MOR)"});
            this.classComBox.Location = new System.Drawing.Point(160, 93);
            this.classComBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.classComBox.Name = "classComBox";
            this.classComBox.Size = new System.Drawing.Size(222, 29);
            this.classComBox.TabIndex = 2;
            this.classComBox.TabStop = false;
            this.classComBox.Tag = "";
            this.classComBox.SelectedIndexChanged += new System.EventHandler(this.classComBox_SelectedIndexChanged);
            // 
            // timeComBox
            // 
            this.timeComBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeComBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.timeComBox.FormattingEnabled = true;
            this.timeComBox.ItemHeight = 21;
            this.timeComBox.Items.AddRange(new object[] {
            "1 HAFTALIK",
            "2 HAFTALIK"});
            this.timeComBox.Location = new System.Drawing.Point(67, 42);
            this.timeComBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.timeComBox.Name = "timeComBox";
            this.timeComBox.Size = new System.Drawing.Size(306, 29);
            this.timeComBox.TabIndex = 0;
            this.timeComBox.TabStop = false;
            this.timeComBox.Tag = "";
            // 
            // classRoomComBox
            // 
            this.classRoomComBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classRoomComBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.classRoomComBox.FormattingEnabled = true;
            this.classRoomComBox.ItemHeight = 21;
            this.classRoomComBox.Items.AddRange(new object[] {
            "Bil1",
            "Bil2",
            "Bil3",
            "Bil4",
            "FD1",
            "FD2",
            "FD3",
            "FD4",
            "Nano1"});
            this.classRoomComBox.Location = new System.Drawing.Point(160, 132);
            this.classRoomComBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.classRoomComBox.Name = "classRoomComBox";
            this.classRoomComBox.Size = new System.Drawing.Size(222, 29);
            this.classRoomComBox.TabIndex = 3;
            this.classRoomComBox.TabStop = false;
            this.classRoomComBox.Tag = "";
            this.classRoomComBox.SelectedIndexChanged += new System.EventHandler(this.classRoomComBox_SelectedIndexChanged);
            // 
            // classRoomLimit
            // 
            this.classRoomLimit.AutoSize = true;
            this.classRoomLimit.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.classRoomLimit.Location = new System.Drawing.Point(239, 165);
            this.classRoomLimit.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.classRoomLimit.Name = "classRoomLimit";
            this.classRoomLimit.Size = new System.Drawing.Size(143, 17);
            this.classRoomLimit.TabIndex = 15;
            this.classRoomLimit.Tag = "";
            this.classRoomLimit.Text = "DERSLİK KAPASİTESİ:";
            this.classRoomLimit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numberOfStudents
            // 
            this.numberOfStudents.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numberOfStudents.Location = new System.Drawing.Point(192, 192);
            this.numberOfStudents.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfStudents.Name = "numberOfStudents";
            this.numberOfStudents.Size = new System.Drawing.Size(190, 28);
            this.numberOfStudents.TabIndex = 4;
            this.numberOfStudents.TabStop = false;
            this.numberOfStudents.Tag = "";
            this.numberOfStudents.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfStudents.ValueChanged += new System.EventHandler(this.numberOfStudents_ValueChanged);
            // 
            // CreateTableBtn
            // 
            this.CreateTableBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CreateTableBtn.Location = new System.Drawing.Point(63, 122);
            this.CreateTableBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CreateTableBtn.Name = "CreateTableBtn";
            this.CreateTableBtn.Size = new System.Drawing.Size(310, 46);
            this.CreateTableBtn.TabIndex = 2;
            this.CreateTableBtn.TabStop = false;
            this.CreateTableBtn.Tag = "";
            this.CreateTableBtn.Text = "Tabloyu Oluştur";
            this.CreateTableBtn.UseVisualStyleBackColor = true;
            this.CreateTableBtn.Click += new System.EventHandler(this.CreateTableBtn_Click);
            // 
            // LessonNameInput
            // 
            this.LessonNameInput.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LessonNameInput.Location = new System.Drawing.Point(160, 14);
            this.LessonNameInput.MaxLength = 30;
            this.LessonNameInput.Name = "LessonNameInput";
            this.LessonNameInput.Size = new System.Drawing.Size(222, 28);
            this.LessonNameInput.TabIndex = 0;
            this.LessonNameInput.TabStop = false;
            this.LessonNameInput.Tag = "";
            // 
            // TablePanel
            // 
            this.TablePanel.Location = new System.Drawing.Point(12, 254);
            this.TablePanel.Name = "TablePanel";
            this.TablePanel.Size = new System.Drawing.Size(1017, 487);
            this.TablePanel.TabIndex = 22;
            // 
            // SaveTableBtn
            // 
            this.SaveTableBtn.Enabled = false;
            this.SaveTableBtn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SaveTableBtn.Location = new System.Drawing.Point(63, 171);
            this.SaveTableBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.SaveTableBtn.Name = "SaveTableBtn";
            this.SaveTableBtn.Size = new System.Drawing.Size(310, 46);
            this.SaveTableBtn.TabIndex = 3;
            this.SaveTableBtn.TabStop = false;
            this.SaveTableBtn.Tag = "";
            this.SaveTableBtn.Text = "Tabloyu Kaydet";
            this.SaveTableBtn.UseVisualStyleBackColor = true;
            this.SaveTableBtn.Click += new System.EventHandler(this.SaveTableBtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CausesValidation = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(67, 78);
            this.dateTimePicker1.MinDate = new System.DateTime(2020, 7, 18, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(306, 28);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.TabStop = false;
            this.dateTimePicker1.Tag = "";
            this.dateTimePicker1.Value = new System.DateTime(2020, 7, 20, 0, 0, 0, 0);
            this.dateTimePicker1.CloseUp += new System.EventHandler(this.dateTimePicker1_CloseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LessonMarkCheckBox);
            this.panel1.Controls.Add(this.TeacherNameText);
            this.panel1.Controls.Add(this.LessonNameInput);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.classRoomLimit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.classRoomComBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.numberOfStudents);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.classComBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 236);
            this.panel1.TabIndex = 1;
            // 
            // LessonMarkCheckBox
            // 
            this.LessonMarkCheckBox.AutoSize = true;
            this.LessonMarkCheckBox.Location = new System.Drawing.Point(388, 14);
            this.LessonMarkCheckBox.Name = "LessonMarkCheckBox";
            this.LessonMarkCheckBox.Size = new System.Drawing.Size(100, 28);
            this.LessonMarkCheckBox.TabIndex = 5;
            this.LessonMarkCheckBox.TabStop = false;
            this.LessonMarkCheckBox.Text = "İşaretle";
            this.LessonMarkCheckBox.UseVisualStyleBackColor = true;
            // 
            // TeacherNameText
            // 
            this.TeacherNameText.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TeacherNameText.Location = new System.Drawing.Point(160, 52);
            this.TeacherNameText.MaxLength = 30;
            this.TeacherNameText.Name = "TeacherNameText";
            this.TeacherNameText.Size = new System.Drawing.Size(222, 28);
            this.TeacherNameText.TabIndex = 1;
            this.TeacherNameText.TabStop = false;
            this.TeacherNameText.Tag = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SaveTableBtn);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.timeComBox);
            this.panel2.Controls.Add(this.CreateTableBtn);
            this.panel2.Location = new System.Drawing.Point(605, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(425, 236);
            this.panel2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 753);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TablePanel);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1060, 800);
            this.MinimumSize = new System.Drawing.Size(1060, 300);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sınav Programı Hazırlama";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numberOfStudents)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox classComBox;
        private System.Windows.Forms.ComboBox classRoomComBox;
        private System.Windows.Forms.Label classRoomLimit;
        private System.Windows.Forms.NumericUpDown numberOfStudents;
        public System.Windows.Forms.ComboBox timeComBox;
        private System.Windows.Forms.Button CreateTableBtn;
        private System.Windows.Forms.TextBox LessonNameInput;
        private System.Windows.Forms.Panel TablePanel;
        private System.Windows.Forms.Button SaveTableBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TeacherNameText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox LessonMarkCheckBox;
    }
}

