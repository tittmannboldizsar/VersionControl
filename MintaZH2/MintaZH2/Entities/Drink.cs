using MintaZH2.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MintaZH2.Entities
{
    public class Drink : Product
    {
        //fontos az override mindkét esetben, de virtual esetében nem jelenik meg mint hiba ott generate overriides
        public override void Display()
        {
            BackColor = Color.LightBlue;
        }
    }
}
