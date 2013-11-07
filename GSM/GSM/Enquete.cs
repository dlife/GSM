using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GSM
{
    class Enquete
    {
        #region Class variables
        
        private int iJa = 0;
        private int iNee = 0;
        private int iOnverschillig = 0;
        private int iCount = 0;

        #endregion

        #region Property's

        public int Ja
        {
            get { return iJa; }
            set { iJa = value; }
        }

        public int Nee { get { return iNee; } set { iNee = value; } }
        public int Onverschillig { get { return iOnverschillig; } set { iOnverschillig = value;} }
        public int Count { get { return iCount; } set { iCount = value; } }

        #endregion

        #region Methods

        public void Reset()
        {
            iJa = iNee = iOnverschillig = iCount = 0;
        }

        public string GeefWeer()
        {
            string test, uitvoer;

            if (iJa == iNee)
            {
                test = "onbepaald";
            }
            else if (iJa > iNee)
            {
                test = "toegestaan";
            }
            else
            {
                test = "niet toegestaan";
            }

            uitvoer = "GSM-gebruik is "+ test + Environment.NewLine
                + "-#ja: " + iJa + Environment.NewLine
                + "-#nee: " + iNee + Environment.NewLine
                + "-#onverschillig: " + iOnverschillig;

            return uitvoer;
        }

        public bool IsBereikt()
        {
            int reken = iJa + iNee + iOnverschillig;
            if (reken == iCount)
            {
                return true;
            }
            return false;
        }

        #endregion
    }
}
