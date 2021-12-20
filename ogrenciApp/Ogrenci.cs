using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenciApp
{
   public class Ogrenci
    {


        public int s;
        public Ogrenci()
        {
           

        }
        string d;
        private string _no;
        public string no { get {
                int number;
                bool success = int.TryParse(_no, out number);

                if (success)
                {
                    _no = _bolum.Substring(0, 1).ToUpper() + _no;

                }


                return _no; } set { _no = value; } }

        private string _ad;
        public string ad { get {return _ad; } set { _ad=value; } }

        private string _soyad;
        public string soyad { get {return _soyad ; } set {_soyad = value; } }

        private string _bolum;
        public string bolum { get {return _bolum; } set {_bolum = value; } }

        private int _sinif;
        public int sinif{ get { return _sinif; } set {_sinif = value; } }


    }
}
