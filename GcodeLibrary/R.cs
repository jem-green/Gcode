using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace GcodeLibrary
{
    public class R : Word
    {
        public R()
        {
            // Radius
            _word = WordType.R;
            _address = -1;

        }
        public R(double radius)
        {
            _word = WordType.R;
            _address = -1;
            _value = radius;

        }
        public double Radius
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
