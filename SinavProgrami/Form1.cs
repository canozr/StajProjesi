using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace SinavProgrami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[] classRoomLimitNumber = new int[] { 54, 36, 40, 34, 48, 60, 78, 78, 56 };
        private string[] times1 = new string[] { "08:30 - 10:00", "10:00 - 12:00", "13:00 - 15:00", "15:00 - 17:00", "17:00 - 19:00" };
        private string[] times2 = new string[] { "09:00 - 11:00", "11:00 - 13:00", "13:00 - 15:00", "15:00 - 17:00", "17:00 - 19:00" };
        private int timesCount = 5;
        private Color btn_color;
        private string btn_color_index;

        private List<string> btnList = new List<string>();
        private List<string> btnListChecked = new List<string>();

        private DateTime dateTime = DateTime.Now;
        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTime;

            this.Size = new Size(1060, 300);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            panel1.Enabled = false;

            timeComBox.Text = timeComBox.Items[0].ToString();
            classComBox.Text = classComBox.Items[0].ToString();
            classRoomComBox.Text = classRoomComBox.Items[0].ToString();
            classRoomLimit.Text = "DERSLİK KAPASİTESİ: " + classRoomLimitNumber[0].ToString();


            TablePanel.HorizontalScroll.Enabled = false;
            TablePanel.VerticalScroll.Enabled = true;
            TablePanel.HorizontalScroll.Visible = false;
            TablePanel.HorizontalScroll.Maximum = 0;
            TablePanel.AutoScroll = true;

        }
        private void classRoomComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected_classRoom = classRoomComBox.SelectedIndex;
            classRoomLimit.Text = "DERSLİK KAPASİTESİ: " + classRoomLimitNumber[selected_classRoom].ToString();
            numberOfStudents.Value = 1;
        }
        private void CreateTable()
        {
            TablePanel.Controls.Clear();
            SaveTableBtn.Enabled = true;
            panel1.Enabled = true;

            btnList.Clear();
            btnListChecked.Clear();

            // Gün Sayısı Ayarla
            int numberOfDays;

            if (timeComBox.SelectedIndex == 0)
            {
                numberOfDays = 5;
                TablePanel.Size = new Size(1017, 350);
                this.Size = new Size(1060, 650);
            }
            else
            {
                numberOfDays = 10;
                TablePanel.Size = new Size(1017, 487);
                this.Size = new Size(1060, 800);
            }

            // Zamanları Ayarla
            string[] times = new string[timesCount];
            times = times1;
            if (timeComBox.SelectedIndex == 1) times = times2;

            // daysLabels Oluştur
            Label[] daysLabels = new Label[numberOfDays];
            Size daysLabelsSize = new Size(170, 30);
            int daysLabelsX = 5;
            int daysLabelsY = 52;

            for (int i = 0; i < daysLabels.Length; i++)
            {
                // Gün Kontrolü
                if (dateTime.DayOfWeek.ToString() == "Saturday")
                    dateTime = dateTime.AddDays(2);
                else if (dateTime.DayOfWeek.ToString() == "Sunday")
                    dateTime = dateTime.AddDays(1);

                // daysLabels ayarları
                daysLabels[i] = new Label();
                daysLabels[i].Font = new Font("Tahoma", 10, FontStyle.Bold);
                daysLabels[i].AutoSize = false;
                daysLabels[i].Size = daysLabelsSize;
                daysLabels[i].Left = daysLabelsX;
                daysLabels[i].Top = daysLabelsY;
                daysLabels[i].Text = dateTime.ToString("dd/MM/yyyy") + " " + CultureInfo.GetCultureInfo("tr-TR").DateTimeFormat.DayNames[(int)dateTime.DayOfWeek];

                // Pozisyon Ayarla
                daysLabelsY += 62;

                // Gün Ayarla
                dateTime = dateTime.AddDays(1);

                // TablePanel e Ekle
                TablePanel.Controls.Add(daysLabels[i]);
            }

            // timeLabels Oluştur
            Label[] timeLabels = new Label[timesCount];
            Size timeLabelsSize = new Size(120, 30);
            int timeLabelsX = 215;
            int timeLabelsY = 5;

            for (int i = 0; i < timeLabels.Length; i++)
            {
                // timeLabels ayarları
                timeLabels[i] = new Label();
                timeLabels[i].Font = new Font("Tahoma", 10, FontStyle.Bold);
                timeLabels[i].AutoSize = false;
                timeLabels[i].Size = timeLabelsSize;
                timeLabels[i].Left = timeLabelsX;
                timeLabels[i].Top = timeLabelsY;
                timeLabels[i].Text = times[i];

                // Pozisyon Ayarla
                timeLabelsX += 155;

                // TablePanel e Ekle
                TablePanel.Controls.Add(timeLabels[i]);
            }

            // examBtns Oluştur
            Button[] examBtns = new Button[timesCount * numberOfDays];
            Size examBtnsSize = new Size(150, 50);
            int examBtnsX = 190;
            int examBtnsY = 35;
            int timeCount = 0;

            for (int i = 0; i < examBtns.Length; i++)
            {
                // Pozisyon Kontrolü
                if (i != 0 && i % 5 == 0)
                {
                    examBtnsX = 190;
                    examBtnsY += 62;
                    timeCount++;
                }

                // examBtns ayarları
                examBtns[i] = new Button();
                examBtns[i].Name = "b" + i;
                examBtns[i].Click += new EventHandler(AddExam);
                examBtns[i].Font = new Font("Tahoma", 10);
                examBtns[i].BackColor = Color.White;
                examBtns[i].TabIndex = 10 + i;
                examBtns[i].TabStop = false;
                examBtns[i].FlatStyle = FlatStyle.Flat;
                examBtns[i].FlatAppearance.BorderSize = 0;
                examBtns[i].AutoSize = false;
                examBtns[i].Size = examBtnsSize;
                examBtns[i].Left = examBtnsX;
                examBtns[i].Top = examBtnsY;
                examBtns[i].Text = "";
                examBtns[i].AccessibleDescription = timeCount.ToString();

                // Pozisyon Ayarla
                examBtnsX += 155;

                // TablePanel e Ekle
                TablePanel.Controls.Add(examBtns[i]);
            }
        }
        private void CreateTableBtn_Click(object sender, EventArgs e)
        {
            // dateTime ayarla
            dateTime = dateTimePicker1.Value;

            // Gün Kontrolü
            if (dateTime.DayOfWeek.ToString() == "Saturday" || dateTime.DayOfWeek.ToString() == "Sunday")
                MessageBox.Show("Hafta İçi Bir Gün Seçin", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                CreateTable();
        }
        private void AddExam(object sender, EventArgs e)
        {
            LessonNameInput.Focus();

            Button button = sender as Button;
            bool isAdd = false;

            if (button.BackColor != Color.White)
            {
                button.Text = "";
                button.BackColor = Color.White;

                // Liste Kontrolü

                if (btnList.Contains(button.AccessibleDescription) && btnListChecked.Contains(button.AccessibleDescription))
                    btnListChecked.Remove(button.AccessibleDescription);

                if (btnList.Contains(button.AccessibleDescription) && !btnListChecked.Contains(button.AccessibleDescription))
                    btnList.Remove(button.AccessibleDescription);

                button.AccessibleDescription = button.AccessibleDescription[0].ToString();
            }
            else if (LessonNameInput.Text != "" && TeacherNameText.Text != "")
            {
                if (button.AccessibleDescription.Length <= 3) button.AccessibleDescription += btn_color_index;
                if (btnList.Contains(button.AccessibleDescription))
                {
                    if (timeComBox.SelectedIndex == 0)
                    {
                        if (btnListChecked.Contains(button.AccessibleDescription))
                        {
                            isAdd = false;
                            MessageBox.Show("1 haftalık program için aynı güne 2' den fazla aynı sınıf eklenemez.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            isAdd = true;
                            btnListChecked.Add(button.AccessibleDescription);
                        }
                    }
                    else
                    {
                        isAdd = false;
                        MessageBox.Show("2 haftalık program için aynı güne 1' den fazla aynı sınıf eklenemez.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else isAdd = true;
                if (isAdd)
                {
                    // Button Ayarları
                    float font_size = 10;

                    if ((LessonNameInput.Text.Length + TeacherNameText.Text.Length) + 5 > 32) font_size = 8;
                    button.Font = new Font("Tahoma", font_size);
                    if (LessonMarkCheckBox.Checked) button.Text = "* ";
                    else button.Text = "";
                    button.Text += LessonNameInput.Text;
                    button.Text += "\n" + TeacherNameText.Text;
                    button.Text += " - " + numberOfStudents.Value.ToString();
                    button.BackColor = btn_color;

                    btnList.Add(button.AccessibleDescription);
                }
                else button.AccessibleDescription = button.AccessibleDescription.Replace(btn_color_index, "");
            }
            else MessageBox.Show("DERS ve ÖĞRETMEN Bilgilerini Girin!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void numberOfStudents_ValueChanged(object sender, EventArgs e)
        {
            if (numberOfStudents.Value > classRoomLimitNumber[classRoomComBox.SelectedIndex])
            {
                MessageBox.Show("Öğrenci Sayısı Derslik Kapasitesini Aşıyor !", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numberOfStudents.Value = classRoomLimitNumber[classRoomComBox.SelectedIndex];
            }
        }
        private void SaveTableImage(string folderName)
        {
            // Ekran görüntüsü modu
            panel1.Visible = false;
            panel2.Visible = false;
            TablePanel.AutoSize = true;
            TablePanel.Height += 50;

            Label[] labels = new Label[2];

            // Renk Yazısı
            labels[0] = new Label();
            labels[0].Font = new Font("Tahoma", 8, FontStyle.Bold);
            labels[0].Text = "Sınıf 1: Yeşil / Sınıf 2: Mavi / Sınıf 3: Pembe / Sınıf 4: Mor";
            labels[0].AutoSize = true;
            labels[0].Left = (TablePanel.Width / 2) - labels[0].Size.Width;
            labels[0].Top = TablePanel.Height - 45;

            // İşaret Metni
            labels[1] = new Label();
            labels[1].Font = new Font("Tahoma", 8, FontStyle.Bold);
            labels[1].Text = "* işaretli sınavlar Fakülte Dersliklerinde, diğer bütün sınavlar Bilgisayar Mühendisliği dersliklerinde yapılacaktır.";
            labels[1].AutoSize = true;
            labels[1].Left = (TablePanel.Width / 2) - (labels[1].Size.Width * 2);
            labels[1].Top = TablePanel.Height - 25;

            TablePanel.Controls.Add(labels[0]);
            TablePanel.Controls.Add(labels[1]);

            // Ekran görüntüsü al
            Bitmap bmp = new Bitmap(TablePanel.Width, TablePanel.Height);
            TablePanel.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            bmp.Save(folderName);

            // Düzenleme modu
            panel1.Visible = true;
            panel2.Visible = true;
            TablePanel.AutoSize = false;
            TablePanel.Size = new Size(1017, 487);
        }
        private void SaveTableBtn_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog1 = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                string folderName = folderBrowserDialog1.SelectedPath;
                SaveTableImage(folderName + @"\Tablo" + DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".png");
            }
        }
        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            var dateTimePicker = sender as DateTimePicker;
            if (dateTimePicker.Value.DayOfWeek.ToString() == "Saturday" || dateTimePicker.Value.DayOfWeek.ToString() == "Sunday")
            {
                if (dateTimePicker.Value.DayOfWeek.ToString() == "Saturday")
                    dateTimePicker.Value = dateTimePicker.Value.AddDays(2);
                else
                    dateTimePicker.Value = dateTimePicker.Value.AddDays(1);

                MessageBox.Show("Hafta İçi Bir Gün Seçin!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else dateTime = dateTimePicker.Value;
        }
        private void classComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Button renk
            switch (classComBox.SelectedIndex)
            {
                // Yeşil
                case 0:
                    btn_color = Color.FromArgb(100, 0, 255, 76);
                    btn_color_index = "green";
                    break;
                // Mavi
                case 1:
                    btn_color = Color.FromArgb(100, 0, 164, 255);
                    btn_color_index = "blue";

                    break;
                // Pembe
                case 2:
                    btn_color = Color.FromArgb(100, 255, 0, 181);
                    btn_color_index = "pink";
                    break;
                // Mor
                case 3:
                    btn_color = Color.FromArgb(100, 171, 0, 255);
                    btn_color_index = "purple";
                    break;
            }
        }
    }
}
