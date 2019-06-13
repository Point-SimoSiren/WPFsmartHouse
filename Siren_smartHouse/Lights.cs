using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siren_smartHouse
{
    public class Lights
    {
        public Boolean Switched { get; set; }
        public string Dimmer { get; set; }


        public void Dim100()
        {
            Switched = true;
            Dimmer = "KIRKAS";
        }
        public void Dim66()
        {
            Switched = true;
            Dimmer = "PUOLIVALO";
        }
        public void Dim33()
        {
            Switched = true;
            Dimmer = "HÄMÄRÄ";
        }
        public void Dim00()
        {
            Switched = false;
            Dimmer = "SAMMUTETTU";
        }
    }

}

