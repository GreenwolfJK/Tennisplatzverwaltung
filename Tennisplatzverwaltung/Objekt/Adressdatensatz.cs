using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennisplatzverwaltung
{
    public class Adressdatensatz
    {
        private String id;
        private String vorname;
        private String nachname;
        private String strasse;
        private String plz;
        private String ort;

        // Setzt den String für die Listbox zusammen
        public String lsb_String()
        {
            return (id + " | " + vorname + " " + nachname + " | " + strasse + ", " + plz + " " + ort);
        }

        public String Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Vorname
        {
            get { return vorname; }
            set { vorname = value; }
        }

        public String Nachname
        {
            get { return nachname; }
            set { nachname = value; }
        }

        public String Strasse
        {
            get { return strasse; }
            set { strasse = value; }
        }

        public String Plz
        {
            get { return plz; }
            set { plz = value; }
        }

        public String Ort
        {
            get { return ort; }
            set { ort = value; }
        }
    }
}
