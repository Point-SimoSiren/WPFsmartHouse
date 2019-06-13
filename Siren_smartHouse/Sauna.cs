using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siren_smartHouse
{
    public class Sauna
    {
        public Boolean Switched { get; set; }

        public Double SaunaTemperature { get; set; }

        public void AsetaSauna(int tila)

        {
            if (tila == 0)
            {
                Switched = false;
                SaunaTemperature = 20.01;
            }
            else
            {
                Switched = true;
                SaunaTemperature = 22.05;
            }
        }


    }
}
