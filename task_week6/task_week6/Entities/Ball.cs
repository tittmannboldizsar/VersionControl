using System.Drawing;
using task_week6.Abstractions;

namespace task_week6.Entities
{
    public class Ball : Toy
    {

        //Kikommentelt részek megvannak írva a Toy osztályban és mivel abból van származtatva ezért nincs rájuk szükség

        //public Ball()
        //{
        //    Width = 50;
        //    Height = Width;
        //    AutoSize = false;
        //    Paint += Ball_Paint;
        //}

        //private void Ball_Paint(object sender, PaintEventArgs e)
        //{
        //    DrawImage(e.Graphics);
        //}

        protected override void DrawImage(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.Blue), 0, 0, Width, Height);
        }

        //    public void MoveBall()
        //    {
        //        Left += 1;
        //    }
    }
}
