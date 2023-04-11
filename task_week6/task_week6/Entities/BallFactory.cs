using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_week6.Abstractions;

namespace task_week6.Entities
{
    public class BallFactory : IToyFactory
    {

        public Toy CreateNew()
        {
            return new Ball();
        }

    }
}
