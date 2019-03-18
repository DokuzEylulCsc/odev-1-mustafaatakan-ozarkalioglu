using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1
{
    class Er:Asker
    {
        public void Hareket()
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(0,100);
            Sayi = sayi;
            if (sayi<10)
            {
                if(Y>0 && Y<17)
                {
                    Y--;
                }
                
            }
            else if(sayi>=10 && sayi<30)
            {
                if (Y > 0 && Y < 17)
                {
                    Y++;
                }
            }
            else if(sayi>=30 && sayi<50)
            {
                //ates et
            }
            else
            {
                //bekle
            }
        }
    }
}
