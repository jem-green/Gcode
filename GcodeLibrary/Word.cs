using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GcodeLibrary
{
    public class Word
    {
        #region Fields
        public enum WordType
        {
            A = 0,      // A rotational axis around x axis
            B = 1,      // B rotational axis around y axis
            C = 2,      // C rotational axis around z axis
            D = 3,      // D tool radius compensation
            E = 4,      // E Precision feedrate
            F = 5,      // F Feed rate
            G = 6,      // G Preparitory
            H = 7,      // H Tool length offset
            I = 8,      // I Arc center in x axis 
            J = 9,      // J Arc center in y axis
            K = 10,     // K arc center in z axis
            L = 11,     // L repetitions in canned cycles
            M = 12,     // M Miscelanious
            N = 13,     // N Line Number
            O = 14,     // O dwell time in canned cycles
            P = 15,     // P Parameter
            Q = 16,     // Q Peck increment in canned cycles
            R = 17,     // R Arc radius
            S = 18,     // S Speed
            T = 19,     // T Tool selection
            U = 20,     // U Incremental axis corresponding to x axis
            V = 21,     // V Incremental axis corresponding to y axis
            W = 22,     // W Incremental axis corresponding to z axis
            X = 23,     // X cordinate
            Y = 24,     // Y cordinate
            Z = 25,     // Z cordinate
        }

        protected WordType _word = WordType.G;
        protected int _address = 0;
        protected Dictionary<WordType, Word> _parameters;
        protected double _value;

        #endregion
        #region Constructor

        public Word(WordType word, int address)
        {
            _word = word;
            _address = address;
        }

        public Word(WordType word)
        {
            _word = word;
            _address = 0;
        }

        public Word()
        {
            _word = WordType.M;
            _address = 0;
        }

        #endregion
        #region Properties

        public WordType Variable
        {
            get
            {
                return (_word);
            }
            set
            {
                _word = value;
            }
        }

        /// <summary>
        /// Specification indicates this is a duble
        /// </summary>
        public double Value
        {
            get
            {
                return (_value);
            }
            set
            {
                _value = value;
            }
        }

        #endregion
        #region Methods

        public override string ToString()
        {
            StringBuilder word = new StringBuilder(_word.ToString());
            word.Append(_value);
            return (word.ToString());
        }

        #endregion
    }
}
