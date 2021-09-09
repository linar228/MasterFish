
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
            this.SuspendLayout();
            // 
            // postavshic
            // 
            this.postavshic.Location = new System.Drawing.Point(342, 48);
            this.postavshic.Name = "postavshic";
            this.postavshic.Size = new System.Drawing.Size(100, 20);
            this.postavshic.TabIndex = 0;
            this.postavshic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Поставщик";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 171);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(437, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 155);
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
            this.Fish.Location = new System.Drawing.Point(57, 314);
            this.Fish.Name = "Fish";
            this.Fish.Size = new System.Drawing.Size(49, 82);
            this.Fish.TabIndex = 4;
            // 
            // AddFish
            // 
            this.AddFish.Location = new System.Drawing.Point(44, 283);
            this.AddFish.Name = "AddFish";
            this.AddFish.Size = new System.Drawing.Size(75, 25);
            this.AddFish.TabIndex = 5;
            this.AddFish.Text = "Add Fish";
            this.AddFish.UseVisualStyleBackColor = true;
            this.AddFish.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(839, 472);
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
        private System.Windows.Forms.ListBox Fish;
        private System.Windows.Forms.Button AddFish;
    }
}

