using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace GcodeLibrary
{
    public class Dwell : Word
    {
        #region Varaibles
        #endregion
        #region Constructors

        public Dwell()  // G4
        {
            _word = WordType.G;
            _address = 4;
            _parameters = new Dictionary<WordType, Word>();
            _parameters.Add(WordType.P, new P());  // miliseconds
            _parameters.Add(WordType.S, new S());  // seconds

            // S take presidence
        }
        public Dwell(int parameter)  // G4
        {
            _word = Word.WordType.G;
            _address = 4;
            _parameters = new Dictionary<WordType, Word>();
            _parameters.Add(WordType.P, new P(parameter));  // miliseconds
            _parameters.Add(WordType.S, new S());           // seconds

            // S take presidence
        }
        public Dwell(int parameter, int Speed)  // G4
        {
            _word = Word.WordType.G;
            _address = 4;
            _parameters = new Dictionary<WordType, Word>();
            _parameters.Add(WordType.P, new P(parameter));  // miliseconds
            _parameters.Add(WordType.S, new S(Speed));      // seconds

            // S take presidence
        }

        #endregion
        #region Properties
        public int Parameter
        {
            get
            {
                return ((int)_parameters[WordType.P].Value);
            }
            set
            {
                _parameters[WordType.P].Value = value;
            }
        }
        public int Speed
        {
            get
            {
                return ((int)_parameters[WordType.S].Value);
            }
            set
            {
                _parameters[WordType.S].Value = value;
            }
        }

        #endregion
    }
}
