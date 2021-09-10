
namespace MasterFish
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.postavshic = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Fish = new System.Windows.Forms.ListBox();
            this.AddFish = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.Result = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // postavshic
            // 
            this.postavshic.Location = new System.Drawing.Point(263, 84);
            this.postavshic.Name = "postavshic";
            this.postavshic.Size = new System.Drawing.Size(109, 20);
            this.postavshic.TabIndex = 0;
            this.postavshic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Поставщик";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 169);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(437, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Температура";
            // 
            // Fish
            // 
            this.Fish.FormattingEnabled = true;
            this.Fish.Items.AddRange(new object[] {
            "Семга",
            "Карп"});
            this.Fish.Location = new System.Drawing.Point(38, 263);
            this.Fish.Name = "Fish";
            this.Fish.Size = new System.Drawing.Size(81, 108);
            this.Fish.TabIndex = 4;
            // 
            // AddFish
            // 
            this.AddFish.Location = new System.Drawing.Point(38, 232);
            this.AddFish.Name = "AddFish";
            this.AddFish.Size = new System.Drawing.Size(81, 25);
            this.AddFish.TabIndex = 5;
            this.AddFish.Text = "Add Fish";
            this.AddFish.UseVisualStyleBackColor = true;
            this.AddFish.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.listBox1.Location = new System.Drawing.Point(151, 263);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(44, 82);
            this.listBox1.TabIndex = 6;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "Секунды",
            "Минуты"});
            this.listBox2.Location = new System.Drawing.Point(201, 263);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(59, 30);
            this.listBox2.TabIndex = 7;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(463, 299);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(111, 26);
            this.Result.TabIndex = 8;
            this.Result.Text = "Result";
            this.Result.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(724, 398);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.AddFish);
            this.Controls.Add(this.Fish);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.postavshic);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox postavshic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddFish;
        public System.Windows.Forms.ListBox Fish;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button Result;
    }
}

