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
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.TbSpreading = new System.Windows.Forms.TrackBar();
            this.lbSpreading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbSpreading)).BeginInit();
            this.SuspendLayout();
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
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 40;
            this.timer.Tick += new System.EventHandler(this.timerTick);
            // 
            // TbSpreading
            // 
            this.TbSpreading.Location = new System.Drawing.Point(265, 449);
            this.TbSpreading.Maximum = 359;
            this.TbSpreading.Name = "TbSpreading";
            this.TbSpreading.Size = new System.Drawing.Size(210, 56);
            this.TbSpreading.TabIndex = 3;
            this.TbSpreading.Scroll += new System.EventHandler(this.TbSpreading_Scroll);
            // 
            // lbSpreading
            // 
            this.lbSpreading.AutoSize = true;
            this.lbSpreading.Location = new System.Drawing.Point(481, 449);
            this.lbSpreading.Name = "lbSpreading";
            this.lbSpreading.Size = new System.Drawing.Size(22, 17);
            this.lbSpreading.TabIndex = 4;
            this.lbSpreading.Text = "0°";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 576);
            this.Controls.Add(this.lbSpreading);
            this.Controls.Add(this.TbSpreading);
            this.Controls.Add(this.picDisplay);
            this.Name = "Form1";
            this.Text = "Частицы";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TbSpreading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TrackBar TbSpreading;
        private System.Windows.Forms.Label lbSpreading;
    }
}

