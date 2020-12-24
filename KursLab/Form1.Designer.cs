namespace KursLab
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.TbTimeSpeed = new System.Windows.Forms.TrackBar();
            this.lbSpreading = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Step = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbTimeSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 200;
            this.timer.Tick += new System.EventHandler(this.timerTick);
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(0, 0);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(977, 443);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            this.picDisplay.Click += new System.EventHandler(this.picDisplay_Click);
            this.picDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseMove);
            // 
            // TbTimeSpeed
            // 
            this.TbTimeSpeed.LargeChange = 30;
            this.TbTimeSpeed.Location = new System.Drawing.Point(351, 469);
            this.TbTimeSpeed.Maximum = 350;
            this.TbTimeSpeed.Minimum = 150;
            this.TbTimeSpeed.Name = "TbTimeSpeed";
            this.TbTimeSpeed.Size = new System.Drawing.Size(210, 56);
            this.TbTimeSpeed.SmallChange = 30;
            this.TbTimeSpeed.TabIndex = 20;
            this.TbTimeSpeed.Value = 150;
            this.TbTimeSpeed.Scroll += new System.EventHandler(this.TbSpreading_Scroll);
            // 
            // lbSpreading
            // 
            this.lbSpreading.AutoSize = true;
            this.lbSpreading.Location = new System.Drawing.Point(579, 469);
            this.lbSpreading.Name = "lbSpreading";
            this.lbSpreading.Size = new System.Drawing.Size(22, 17);
            this.lbSpreading.TabIndex = 4;
            this.lbSpreading.Text = "0°";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(12, 469);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(152, 34);
            this.Start.TabIndex = 21;
            this.Start.Text = "Старт/стоп";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Step
            // 
            this.Step.Location = new System.Drawing.Point(179, 469);
            this.Step.Name = "Step";
            this.Step.Size = new System.Drawing.Size(152, 34);
            this.Step.TabIndex = 22;
            this.Step.Text = "Шаг";
            this.Step.UseVisualStyleBackColor = true;
            this.Step.Click += new System.EventHandler(this.Step_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 576);
            this.Controls.Add(this.Step);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.lbSpreading);
            this.Controls.Add(this.TbTimeSpeed);
            this.Controls.Add(this.picDisplay);
            this.Name = "Form1";
            this.Text = "Частицы";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbTimeSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.TrackBar TbTimeSpeed;
        private System.Windows.Forms.Label lbSpreading;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Step;
    }
}

