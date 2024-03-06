namespace GeneticAlgorithm
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
            this.generation = new System.Windows.Forms.Button();
            this.X1box = new System.Windows.Forms.TextBox();
            this.X2box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Y2box = new System.Windows.Forms.TextBox();
            this.Y1box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chromosoms = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.iterationCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maxIteration = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // generation
            // 
            this.generation.Location = new System.Drawing.Point(38, 604);
            this.generation.Name = "generation";
            this.generation.Size = new System.Drawing.Size(93, 23);
            this.generation.TabIndex = 1;
            this.generation.Text = "Генерировать";
            this.generation.UseVisualStyleBackColor = true;
            this.generation.Click += new System.EventHandler(this.generation_Click);
            // 
            // X1box
            // 
            this.X1box.Location = new System.Drawing.Point(194, 607);
            this.X1box.Name = "X1box";
            this.X1box.Size = new System.Drawing.Size(100, 20);
            this.X1box.TabIndex = 2;
            this.X1box.Text = "-10";
            // 
            // X2box
            // 
            this.X2box.Location = new System.Drawing.Point(194, 633);
            this.X2box.Name = "X2box";
            this.X2box.Size = new System.Drawing.Size(100, 20);
            this.X2box.TabIndex = 3;
            this.X2box.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 591);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 609);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 633);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 593);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Y";
            // 
            // Y2box
            // 
            this.Y2box.Location = new System.Drawing.Point(300, 635);
            this.Y2box.Name = "Y2box";
            this.Y2box.Size = new System.Drawing.Size(100, 20);
            this.Y2box.TabIndex = 8;
            this.Y2box.Text = "10";
            // 
            // Y1box
            // 
            this.Y1box.Location = new System.Drawing.Point(300, 609);
            this.Y1box.Name = "Y1box";
            this.Y1box.Size = new System.Drawing.Size(100, 20);
            this.Y1box.TabIndex = 7;
            this.Y1box.Text = "-10";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(492, 609);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Магия";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chromosoms
            // 
            this.chromosoms.Location = new System.Drawing.Point(638, 612);
            this.chromosoms.Name = "chromosoms";
            this.chromosoms.Size = new System.Drawing.Size(100, 20);
            this.chromosoms.TabIndex = 11;
            this.chromosoms.Text = "4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(635, 596);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Хромосом";
            // 
            // iterationCount
            // 
            this.iterationCount.AutoSize = true;
            this.iterationCount.Location = new System.Drawing.Point(492, 639);
            this.iterationCount.Name = "iterationCount";
            this.iterationCount.Size = new System.Drawing.Size(35, 13);
            this.iterationCount.TabIndex = 13;
            this.iterationCount.Text = "label6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(635, 640);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ограничение итераций";
            // 
            // maxIteration
            // 
            this.maxIteration.Location = new System.Drawing.Point(638, 656);
            this.maxIteration.Name = "maxIteration";
            this.maxIteration.Size = new System.Drawing.Size(100, 20);
            this.maxIteration.TabIndex = 14;
            this.maxIteration.Text = "10000";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(1166, 560);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 720);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maxIteration);
            this.Controls.Add(this.iterationCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chromosoms);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Y2box);
            this.Controls.Add(this.Y1box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.X2box);
            this.Controls.Add(this.X1box);
            this.Controls.Add(this.generation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button generation;
        private System.Windows.Forms.TextBox X1box;
        private System.Windows.Forms.TextBox X2box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Y2box;
        private System.Windows.Forms.TextBox Y1box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox chromosoms;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label iterationCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox maxIteration;
        private System.Windows.Forms.TextBox textBox1;
    }
}

