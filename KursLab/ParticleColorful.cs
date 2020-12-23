using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursLab
{
    class ParticleColorful:Particle
    {
        
        

            public Color FromColor;//начальный цвет
            public Color ToColor;//новый цвет

            public static Color MixColor(Color color1, Color color2, float k)
            {
                return Color.FromArgb(
                (int)(color2.A * k + color1.A * (1 - k)),
                (int)(color2.R * k + color1.R * (1 - k)),
                (int)(color2.G * k + color1.G * (1 - k)),
                (int)(color2.B * k + color1.B * (1 - k))
            );
            }
            public override void Draw(Graphics g)
            {
                // рассчитываем коэффициент прозрачности по шкале от 0 до 1.0
                float k = Math.Min(1f, Life / 100);
                // рассчитываем значение альфа канала в шкале от 0 до 255
                // по аналогии с RGB, он используется для задания прозрачности


                // создаем цвет из уже существующего, но привязываем к нему еще и значение альфа канала
                var color = MixColor(ToColor, FromColor, k);
                var b = new SolidBrush(color);

                // остальное все так же
                g.FillEllipse(b, X - Radius, Y - Radius, Radius * 2, Radius * 2);

                b.Dispose();
            

            }
    }
}
