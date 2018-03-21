using System.Collections.Generic;

namespace ConnCore_ESP12E_Service.Providers.Models
{
    public class EspBoard
    {
        public List<Pin> Pins { get; set; }

        public EspBoard ()
        {
            Pins = new List<Pin>();
            Pins.AddRange(
                new List<Pin>
                {
                    new Pin(){PinNum = 0, State = true},
                    new Pin(){PinNum = 1, State = true},
                    new Pin(){PinNum = 2, State = true},
                    new Pin(){PinNum = 3, State = true},
                    new Pin(){PinNum = 4, State = true},
                    new Pin(){PinNum = 5, State = true},
                    new Pin(){PinNum = 6, State = true},
                    new Pin(){PinNum = 7, State = true},
                    new Pin(){PinNum = 8, State = true},
                    new Pin(){PinNum = 9, State = true}
                });
        }
        public class Pin
        {
            public int PinNum { get; set; }
            public bool State { get; set; } = false;
        }
    }

   
}
