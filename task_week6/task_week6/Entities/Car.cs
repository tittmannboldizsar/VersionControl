using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_week6.Abstractions;

namespace task_week6.Entities
{
    class Car : Toy
    {
        protected override void DrawImage(Graphics g)
        {
            Image img =  Image.FromFile("Images/car.png");
            g.DrawImage(img, new Rectangle(0, 0, Width, Height));
        }
    }
}
