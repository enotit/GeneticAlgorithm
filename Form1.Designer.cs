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
            this.button1 = new System.Windows.Forms.Button();
            this.chromosoms = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.iterationCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maxIteration = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.minfuction = new System.Windows.Forms.Label();
            this.resultMinFunction = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            this.iterationCount.Location = new System.Drawing.Point(489, 640);
            this.iterationCount.Name = "iterationCount";
            this.iterationCount.Size = new System.Drawing.Size(112, 13);
            this.iterationCount.TabIndex = 13;
            this.iterationCount.Text = "Тут будет подсказка";
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
            this.maxIteration.Text = "100";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(746, 581);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // minfuction
            // 
            this.minfuction.AutoSize = true;
            this.minfuction.Location = new System.Drawing.Point(34, 618);
            this.minfuction.Name = "minfuction";
            this.minfuction.Size = new System.Drawing.Size(124, 13);
            this.minfuction.TabIndex = 17;
            this.minfuction.Text = "Тут будет мин.функция";
            // 
            // resultMinFunction
            // 
            this.resultMinFunction.Location = new System.Drawing.Point(764, 12);
            this.resultMinFunction.Multiline = true;
            this.resultMinFunction.Name = "resultMinFunction";
            this.resultMinFunction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultMinFunction.Size = new System.Drawing.Size(414, 581);
            this.resultMinFunction.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 720);
            this.Controls.Add(this.resultMinFunction);
            this.Controls.Add(this.minfuction);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maxIteration);
            this.Controls.Add(this.iterationCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chromosoms);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox chromosoms;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label iterationCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox maxIteration;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label minfuction;
        private System.Windows.Forms.TextBox resultMinFunction;
    }
}

