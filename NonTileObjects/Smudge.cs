﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MapEditor.NonTileObjects
{
    public class Smudge
    {
        public string Name;
        public int RelativeX;
        public int X;
        public int RelativeY;
        public int Y;
        public int unknown;

        public void Initialize(string iniValue)
        {
            string[] values = iniValue.Split(',');
            if (values.Count() == 4)
            {
                Name = values[0];
                RelativeX = int.Parse(values[1]) - Constants.StartingXY;
                RelativeY = int.Parse(values[2]) - Constants.StartingXY;
                unknown = int.Parse(values[3]);
            }
        }
        public Smudge Clone()
        {
            return (Smudge)this.MemberwiseClone();
        }
        public string CreateINIValue()
        {
            return Name + "," + X + "," + Y + "," + unknown;
        }
    }
}