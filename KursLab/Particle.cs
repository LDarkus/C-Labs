using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursLab
{

    public class Particle
    {

        public int Radius;//Радиус
        public float X;
        public float Y;

        public float SpeedX;// направление движения
        public float SpeedY; // скорость перемещения

        public float Life;// Здоровье частицы
        public static Random rand = new Random();

        public Particle()
        {
            var direction = (double)rand.Next(360);
            var speed = 1 + rand.Next(10);
            SpeedX = (float)(Math.Cos(Radian(direction)) * speed);
            SpeedY = (float)(Math.Sin(Radian(direction)) * speed);
            Radius = 2 + rand.Next(10);
            Life = 20 + rand.Next(100);
        }

        public virtual void Draw(Graphics g)
        {
            // рассчитываем коэффициент прозрачности по шкале от 0 до 1.0
            float k = Math.Min(1f, Life / 100);
            // рассчитываем значение альфа канала в шкале от 0 до 255
            // по аналогии с RGB, он используется для задания прозрачности
            int alpha = (int)(k * 255);

            // создаем цвет из уже существующего, но привязываем к нему еще и значение альфа канала
            var color = Color.FromArgb(alpha, Color.Black);
            var b = new SolidBrush(color);

            // остальное все так же
            g.FillEllipse(b, X - Radius, Y - Radius, Radius * 2, Radius * 2);

            b.Dispose();
        }

        public static float Radian(double direction)
        {
            return (float)(direction / 180 * Math.PI);
        }
       
    }

    
}
