using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class Starter
    { 
        public void Run ()
        {
            Action first = new Action();
            Action second = new Action();
            Action third = new Action();

            for (int i = 0; i < 100; i++)
            {
                Random rand = new Random();
                int r = rand.Next(1, 4);
                switch (r)
                {
                    case 1:
                        first.First();
                        break;
                    case 2:
                        second.Second();
                        break;
                    case 3:
                        third.Third();
                        break;
                }
            }
        }
    }
}
