using System;

namespace GcodeLibrary
{
    public class HPGL2
    {
        #region Fields

        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        string _filename = "";
        string _path = "";

        #endregion

        #region Constructor

        HPGL2(string filename, string path)
        {
            _filename = filename;
            _path = path;
        }

        #endregion




    }
}
