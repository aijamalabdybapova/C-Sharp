﻿using Microsoft.VisualBasic;
using System.Collections.Generic;

namespace Zametka
{
    public class Zametka
    {
        public int Day;
        public int Month = 10;
        public string opisanie;
        public string name;
        public int Number;
        public DateTime CreationTime;
        public static List<Zametka> zametki = new List<Zametka>();
    }
}