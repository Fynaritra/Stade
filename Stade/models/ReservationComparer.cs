using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stade.models
{
    class ReservationComparer : IEqualityComparer<ClassReservation>
    {
        public bool Equals(ClassReservation x, ClassReservation y)
        {
            if (Object.ReferenceEquals(x, y)) return true;
            return x.datereservation.CompareTo(y.datereservation) == 0;
        }

        public int GetHashCode(ClassReservation obj)
        {
            return obj.GetHashCode();
        }
    }
}
