namespace _4asikii
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4TimeNow = new System.Windows.Forms.Timer(this.components);
            this.label1TimeNow = new System.Windows.Forms.Label();
            this.labelVremya = new System.Windows.Forms.Label();
            this.buttonBudStop = new System.Windows.Forms.Button();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.buttonBudDop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(30, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(527, 488);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // timer1
            // 
            this.timer1.Interval = 1100;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 61000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 3660000;
            // 
            // timer4TimeNow
            // 
            this.timer4TimeNow.Tick += new System.EventHandler(this.timer4TimeNow_Tick);
            // 
            // label1TimeNow
            // 
            this.label1TimeNow.AutoSize = true;
            this.label1TimeNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1TimeNow.Location = new System.Drawing.Point(383, 299);
            this.label1TimeNow.Name = "label1TimeNow";
            this.label1TimeNow.Size = new System.Drawing.Size(58, 22);
            this.label1TimeNow.TabIndex = 2;
            this.label1TimeNow.Text = "label1";
            // 
            // labelVremya
            // 
            this.labelVremya.AutoSize = true;
            this.labelVremya.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVremya.Location = new System.Drawing.Point(621, 157);
            this.labelVremya.Name = "labelVremya";
            this.labelVremya.Size = new System.Drawing.Size(78, 36);
            this.labelVremya.TabIndex = 25;
            this.labelVremya.Text = "label";
            // 
            // buttonBudStop
            // 
            this.buttonBudStop.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonBudStop.Enabled = false;
            this.buttonBudStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBudStop.Location = new System.Drawing.Point(594, 258);
            this.buttonBudStop.Name = "buttonBudStop";
            this.buttonBudStop.Size = new System.Drawing.Size(136, 32);
            this.buttonBudStop.TabIndex = 24;
            this.buttonBudStop.Text = "Убрать";
            this.buttonBudStop.UseVisualStyleBackColor = false;
            this.buttonBudStop.Click += new System.EventHandler(this.buttonBudStop_Click);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox2.Location = new System.Drawing.Point(617, 154);
            this.maskedTextBox2.Mask = "00:00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(82, 41);
            this.maskedTextBox2.TabIndex = 23;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // buttonBudDop
            // 
            this.buttonBudDop.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonBudDop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBudDop.Location = new System.Drawing.Point(594, 220);
            this.buttonBudDop.Name = "buttonBudDop";
            this.buttonBudDop.Size = new System.Drawing.Size(136, 32);
            this.buttonBudDop.TabIndex = 22;
            this.buttonBudDop.Text = "Добавить";
            this.buttonBudDop.UseVisualStyleBackColor = false;
            this.buttonBudDop.Click += new System.EventHandler(this.buttonBudDop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(588, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 36);
            this.label1.TabIndex = 26;
            this.label1.Text = "Будильник";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(615, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Время (ч:м)";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(563, 44);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 512);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelVremya);
            this.Controls.Add(this.buttonBudStop);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.buttonBudDop);
            this.Controls.Add(this.label1TimeNow);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Часы";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4TimeNow;
        private System.Windows.Forms.Label label1TimeNow;
        private System.Windows.Forms.Label labelVremya;
        private System.Windows.Forms.Button buttonBudStop;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Button buttonBudDop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

