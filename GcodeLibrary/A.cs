using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace GcodeLibrary
{
    public class A : Word
    {
        public A()
        {
            _word = WordType.A;
            _address = -1;

        }
        public A(double angle)
        {
            _word = WordType.A;
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
