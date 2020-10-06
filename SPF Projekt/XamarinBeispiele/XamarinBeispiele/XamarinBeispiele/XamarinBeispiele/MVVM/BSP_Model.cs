using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinBeispiele
{
    class BSP_Model
    {
        public String Bezeichnung { get; protected set; }
        public int LagerMenge { get; set; }

        public BSP_Model(String bezeichnung, int LagerMenge)
        {
            this.Bezeichnung = bezeichnung;
            this.LagerMenge = LagerMenge;
        }

        public override string ToString()
        {
            return Bezeichnung;
        }
    }
}
