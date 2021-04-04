using GcodeLibrary;
using System;
using System.Collections.Generic;

namespace GcodeCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Word> codes = new List<Word>();
            codes.Add(new Dwell(150));
            Word lm = new Word();
            lm.X = 0;
            lm.Y = 0;
            codes.Add(new LinearMove(0, 0));
        }
    }
}
