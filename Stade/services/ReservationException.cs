using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stade.services
{
    class ReservationException:Exception
    {
        public ReservationException(String msg)
        {
            new Exception(msg);
        }
    }
}
