using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace GcodeLibrary
{
    public class O : Word
    {
        public O()  // dwell time in canned cycles
        {
            _word = WordType.O;
            _address = -1;

        }

        public O(int dwell)  // dwell time in canned cycles
        {
            _word = WordType.O;
            _address = -1;
            _value = dwell;

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
