namespace geneticAlgorithm
{
    partial class main
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.crossoverBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mutationBox = new System.Windows.Forms.ComboBox();
            this.comb = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mutationChance = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.populationSize = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.maxAges = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grupBox5 = new System.Windows.Forms.GroupBox();
            this.generationPoints = new System.Windows.Forms.Button();
            this.pointsCount = new System.Windows.Forms.NumericUpDown();
            this.ClearButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.comb.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.crossoverBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 39);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Кроссовер";
            // 
            // crossoverBox
            // 
            this.crossoverBox.FormattingEnabled = true;
            this.crossoverBox.Items.AddRange(new object[] {
            "упорядоченый",
            "циклический",
            "рекомбинации",
            "измененный"});
            this.crossoverBox.Location = new System.Drawing.Point(6, 12);
            this.crossoverBox.Name = "crossoverBox";
            this.crossoverBox.Size = new System.Drawing.Size(136, 21);
            this.crossoverBox.TabIndex = 0;
            this.crossoverBox.Text = "рекомбинации";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mutationBox);
            this.groupBox2.Location = new System.Drawing.Point(13, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(148, 39);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Мутации";
            // 
            // mutationBox
            // 
            this.mutationBox.FormattingEnabled = true;
            this.mutationBox.Items.AddRange(new object[] {
            "инверсная",
            "транслокации",
            "жадная"});
            this.mutationBox.Location = new System.Drawing.Point(6, 12);
            this.mutationBox.Name = "mutationBox";
            this.mutationBox.Size = new System.Drawing.Size(136, 21);
            this.mutationBox.TabIndex = 0;
            this.mutationBox.Text = "инверсная";
            // 
            // comb
            // 
            this.comb.Controls.Add(this.label1);
            this.comb.Controls.Add(this.mutationChance);
            this.comb.Location = new System.Drawing.Point(12, 103);
            this.comb.Name = "comb";
            this.comb.Size = new System.Drawing.Size(149, 39);
            this.comb.TabIndex = 3;
            this.comb.TabStop = false;
            this.comb.Text = "Шанс мутации";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(113, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "%";
            // 
            // mutationChance
            // 
            this.mutationChance.Location = new System.Drawing.Point(7, 13);
            this.mutationChance.Name = "mutationChance";
            this.mutationChance.Size = new System.Drawing.Size(100, 20);
            this.mutationChance.TabIndex = 0;
            this.mutationChance.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox3.Controls.Add(this.populationSize);
            this.groupBox3.Location = new System.Drawing.Point(13, 148);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(148, 47);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Размер популяции";
            // 
            // populationSize
            // 
            this.populationSize.Location = new System.Drawing.Point(6, 21);
            this.populationSize.Name = "populationSize";
            this.populationSize.Size = new System.Drawing.Size(136, 20);
            this.populationSize.TabIndex = 0;
            this.populationSize.Text = "100";
            // 
            // groupBox4
            // 
            this.groupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox4.Controls.Add(this.maxAges);
            this.groupBox4.Location = new System.Drawing.Point(13, 201);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(148, 47);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Количество поколений";
            // 
            // maxAges
            // 
            this.maxAges.Location = new System.Drawing.Point(6, 21);
            this.maxAges.Name = "maxAges";
            this.maxAges.Size = new System.Drawing.Size(136, 20);
            this.maxAges.TabIndex = 0;
            this.maxAges.Text = "100";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(7, 341);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(148, 43);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "Старт";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Location = new System.Drawing.Point(167, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(529, 394);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // grupBox5
            // 
            this.grupBox5.Controls.Add(this.ClearButton);
            this.grupBox5.Controls.Add(this.generationPoints);
            this.grupBox5.Controls.Add(this.pointsCount);
            this.grupBox5.Location = new System.Drawing.Point(12, 255);
            this.grupBox5.Name = "grupBox5";
            this.grupBox5.Size = new System.Drawing.Size(143, 80);
            this.grupBox5.TabIndex = 8;
            this.grupBox5.TabStop = false;
            this.grupBox5.Text = "Рандом";
            // 
            // generationPoints
            // 
            this.generationPoints.Location = new System.Drawing.Point(71, 51);
            this.generationPoints.Name = "generationPoints";
            this.generationPoints.Size = new System.Drawing.Size(72, 23);
            this.generationPoints.TabIndex = 1;
            this.generationPoints.Text = "Генерация";
            this.generationPoints.UseVisualStyleBackColor = true;
            this.generationPoints.Click += new System.EventHandler(this.generationPoints_Click);
            // 
            // pointsCount
            // 
            this.pointsCount.Location = new System.Drawing.Point(36, 25);
            this.pointsCount.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.pointsCount.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.pointsCount.Name = "pointsCount";
            this.pointsCount.Size = new System.Drawing.Size(61, 20);
            this.pointsCount.TabIndex = 0;
            this.pointsCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(-5, 51);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(72, 23);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 396);
            this.Controls.Add(this.grupBox5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.comb);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "main";
            this.Text = "Генетический Алгоритм";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.comb.ResumeLayout(false);
            this.comb.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pointsCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox crossoverBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox mutationBox;
        private System.Windows.Forms.GroupBox comb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mutationChance;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox populationSize;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox maxAges;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grupBox5;
        private System.Windows.Forms.Button generationPoints;
        private System.Windows.Forms.NumericUpDown pointsCount;
        private System.Windows.Forms.Button ClearButton;
    }
}

