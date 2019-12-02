using System;
using System.Collections.Generic;
using System.Text;

namespace lab11
{
   public delegate bool Park(Visitor visitor);
    class AmusementPark
    {
        public Park Park;
        public Park OnlyGo;
        public Park ShootEatRide;
        public AmusementPark()
        {
            Park = RideDamnwheel;
            Park += RideRollercoster;
            Park += Shootdash;
            Park += GoRoomfear;
            Park += GoRoomCurvedmirrors;
            Park += Eatpopcorn;

            OnlyGo = GoRoomfear;
            OnlyGo += GoRoomCurvedmirrors;

            ShootEatRide = Shootdash;
            ShootEatRide += Eatpopcorn;
            ShootEatRide += RideDamnwheel;
            ShootEatRide += RideRollercoster;
        }



        public static bool RideRollercoster(Visitor visitor)
        {
            return visitor.RideRollerCoster = true;
        }

        public static bool Shootdash(Visitor visitor)
        {
            return visitor.ShootDash = true;
        }

        public static bool GoRoomfear(Visitor visitor)
        {
            return visitor.GoRoomFear = true;
        }

        public static bool GoRoomCurvedmirrors(Visitor visitor)
        {
            return visitor.GoRoomCurvedMirrors = true;
        }

        public static bool Eatpopcorn(Visitor visitor)
        {
            return visitor.EatPopcorn = true;
        }

        public static bool RideDamnwheel(Visitor visitor)
        {
            return visitor.RideDamnWheel = true;
        }

        

    } 

    

}
