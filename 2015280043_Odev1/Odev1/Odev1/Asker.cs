using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1
{
    class Asker
    {
        private bool hayatta;
        private int can;
        private int x, y;
        private int takim;
        public int Sayi;   
        public bool Hayatta
        {
            get
            {
                return hayatta;
            }

            set
            {
                hayatta = value;
            }
        }
        public int Can
        {
            get
            {
                return can;
            }

            set
            {
                can = value;
            }
        }
        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }
        public int Takim
        {
            get
            {
                return takim;
            }

            set
            {
                takim = value;
            }
        }
        public void Canli()
        {
            can = 100;
            Hayatta = true;
        }

        public bool Canlimi
        {
            get
            {
                return Hayatta;
            }


        }

        public void Hasar(int hasar)
        {
            Can = Can - hasar;
            if (Can <= 0)
                Ol();
        }
        protected virtual void Ol()
        {
            Can = 0;
            Hayatta = false;
        }

    }
}
