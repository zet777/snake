﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine:Figura
    {
       

        public HorizontalLine(int xLeft, int xRiht, int y, char sym)
        {
            pList = new List<Point>();
           for(int x= xLeft; x<=xRiht; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }

        }
       
    }
}
