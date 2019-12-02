using System;
using System.Collections.Generic;
using System.Text;

namespace lab11
{
    public class Visitor
    {
        public bool RideRollerCoster { get; set; }
        public bool ShootDash { get; set; }
        public bool GoRoomFear { get; set; }
        public bool GoRoomCurvedMirrors { get; set; }
        public bool EatPopcorn { get; set; }
        public bool RideDamnWheel { get; set; }

        public void Show(Visitor visitor)
        {
            Console.WriteLine("Ride roller coster - {0}",RideRollerCoster.ToString());
            Console.WriteLine("Shoot dash - {0}",ShootDash.ToString());
            Console.WriteLine("Room of fear - {0}",GoRoomFear.ToString());
            Console.WriteLine("Room with curver mirrors - {0}",GoRoomCurvedMirrors.ToString());
            Console.WriteLine("Eat popcorn - {0}",EatPopcorn.ToString());
            Console.WriteLine("Ride Damn wheel - {0}",RideDamnWheel.ToString());
        }
    }
}
