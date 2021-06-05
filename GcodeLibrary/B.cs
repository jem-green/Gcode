using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace GcodeLibrary
{
    public class B : Word
    {
        public B()
        {
            _word = WordType.B;
            _address = -1;

        }
        public B(double angle)
        {
            _word = WordType.X;
            _address = -1;
            _value = angle;

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
