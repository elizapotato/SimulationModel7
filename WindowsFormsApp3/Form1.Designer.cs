namespace WindowsFormsApp3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edNaim = new System.Windows.Forms.NumericUpDown();
            this.edZC = new System.Windows.Forms.NumericUpDown();
            this.butStart = new System.Windows.Forms.Button();
            this.labPers = new System.Windows.Forms.Label();
            this.labPrib = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edPost = new System.Windows.Forms.NumericUpDown();
            this.labTime = new System.Windows.Forms.Label();
            this.labStore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.edNaim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edZC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPost)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Найм";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Закупочная цена";
            // 
            // edNaim
            // 
            this.edNaim.Location = new System.Drawing.Point(218, 45);
            this.edNaim.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.edNaim.Name = "edNaim";
            this.edNaim.Size = new System.Drawing.Size(120, 22);
            this.edNaim.TabIndex = 2;
            this.edNaim.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // edZC
            // 
            this.edZC.Location = new System.Drawing.Point(218, 81);
            this.edZC.Name = "edZC";
            this.edZC.Size = new System.Drawing.Size(120, 22);
            this.edZC.TabIndex = 3;
            this.edZC.Value = new decimal(new int[] {
            55,
            0,
            0,
            0});
            // 
            // butStart
            // 
            this.butStart.Location = new System.Drawing.Point(307, 214);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(75, 23);
            this.butStart.TabIndex = 4;
            this.butStart.Text = "Next";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // labPers
            // 
            this.labPers.AutoSize = true;
            this.labPers.Location = new System.Drawing.Point(504, 81);
            this.labPers.Name = "labPers";
            this.labPers.Size = new System.Drawing.Size(89, 17);
            this.labPers.TabIndex = 5;
            this.labPers.Text = "Персонал: 1";
            this.labPers.Click += new System.EventHandler(this.labPers_Click);
            // 
            // labPrib
            // 
            this.labPrib.AutoSize = true;
            this.labPrib.Location = new System.Drawing.Point(504, 118);
            this.labPrib.Name = "labPrib";
            this.labPrib.Size = new System.Drawing.Size(123, 17);
            this.labPrib.TabIndex = 6;
            this.labPrib.Text = "Прибыль: 100000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Поставка";
            // 
            // edPost
            // 
            this.edPost.Location = new System.Drawing.Point(218, 113);
            this.edPost.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.edPost.Name = "edPost";
            this.edPost.Size = new System.Drawing.Size(120, 22);
            this.edPost.TabIndex = 8;
            this.edPost.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.Location = new System.Drawing.Point(441, 217);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(66, 17);
            this.labTime.TabIndex = 9;
            this.labTime.Text = "Месяц: 0";
            // 
            // labStore
            // 
            this.labStore.AutoSize = true;
            this.labStore.Location = new System.Drawing.Point(504, 45);
            this.labStore.Name = "labStore";
            this.labStore.Size = new System.Drawing.Size(98, 17);
            this.labStore.TabIndex = 10;
            this.labStore.Text = "Запасы: 3000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 287);
            this.Controls.Add(this.labStore);
            this.Controls.Add(this.labTime);
            this.Controls.Add(this.edPost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labPrib);
            this.Controls.Add(this.labPers);
            this.Controls.Add(this.butStart);
            this.Controls.Add(this.edZC);
            this.Controls.Add(this.edNaim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.edNaim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edZC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edPost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown edNaim;
        private System.Windows.Forms.NumericUpDown edZC;
        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.Label labPers;
        private System.Windows.Forms.Label labPrib;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown edPost;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.Label labStore;
    }
}

