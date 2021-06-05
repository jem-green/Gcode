using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace GcodeLibrary
{
    public class P : Word
    {
        public P()  // Parameter
        {
            _word = WordType.P;
            _address = -1;
        }

        public P(int parameter)  // Parameter
        {
            _word = WordType.P;
            _address = -1;
            _value = parameter;
        }

        public int Value
        {
            get
            {
                return ((int)_value);
            }
            set
            {
                _value = value;
            }
        }
    }
}
