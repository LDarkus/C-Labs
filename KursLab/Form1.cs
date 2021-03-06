﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static KursLab.Emitter;

namespace KursLab
{
    public partial class Form1 : Form
    {
        List<Emitter> emitters = new List<Emitter>();
        Emitter emitter; // добавим поле для эмиттера
        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);
            
            this.emitter = new Emitter // создаю эмиттер и привязываю его к полю emitter
            {
                Direction = 270,
                Spreading = 50,
                SpeedMin = 3,
                SpeedMax = 5,
                ColorFrom = Color.Gold,
                ColorTo = Color.FromArgb(0, Color.DarkViolet),
                ParticlesPerTick = 1,
                X = picDisplay.Width ,
                Y = picDisplay.Height ,
            };

            emitters.Add(this.emitter); // все равно добавляю в список emitters, чтобы он рендерился и обновлялся
        }

        

        
        private void picDisplay_Click(object sender, EventArgs e)
        {

        }
        int counter = 0;
        private void timerTick(object sender, EventArgs e)
        {
            emitter.UpdateState();
            counter++;
            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black);
                // рисую на изображении сколько насчитал
                emitter.Render(g);
            }
            picDisplay.Invalidate();
        }

        

        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            // в обработчике заносим положение мыши в переменные для хранения положения мыши
            emitter.MousePositionX = e.X;
            emitter.MousePositionY = e.Y;
        }

        private void TbSpreading_Scroll(object sender, EventArgs e)
        {
            if (TbTimeSpeed.Value == 0)
            { timer.Enabled = false; }
            else
            {
                timer.Enabled = true;
                if (TbTimeSpeed.Maximum - TbTimeSpeed.Value <= 0)
                {
                    timer.Interval = TbTimeSpeed.Maximum - TbTimeSpeed.Value+1;
                    lbSpreading.Text = $"{timer.Interval}°";
                }

            
                else
                { timer.Interval = TbTimeSpeed.Maximum-TbTimeSpeed.Value;
                lbSpreading.Text = $"{timer.Interval}°";}
                

            }
            
        }

        bool flag = false;
        private void Start_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                timer.Enabled = true;
                TbTimeSpeed.Enabled = true;
            }
            else
            {
                timer.Enabled = false;
                TbTimeSpeed.Enabled = false;
            }
            flag = !flag;
        }

        private void Step_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            flag = true;
            timerTick(sender,e);
        }
    }
}
