using System;
using System.Collections.Generic;
using System.Text;
using ShapeLibrary;

namespace GcodeLibrary
{
    public class Code : Word
    {
        
        public override string ToString()
        {
            StringBuilder code = new StringBuilder(_word.ToString());
            code.Append(_address);
            foreach (KeyValuePair<WordType, Word> parameter in _parameters)
            {
                Word word = parameter.Value;
                code.Append(word.ToString());
            }
            return (code.ToString());
        }
    }
}
