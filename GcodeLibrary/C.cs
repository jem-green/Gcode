using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace GcodeLibrary
{
    public class C : Word
    {
        public C()
        {
            _word = WordType.A;
            _address = -1;

        }
        public C(double coordinate)
        {
            _word = WordType.X;
            _address = -1;
            _value = coordinate;

        }
        public double Angle
        {
            get
            {
                return ((double)_value);
            }
            set
            {
                _value = value;
            }
        }
    }
}
