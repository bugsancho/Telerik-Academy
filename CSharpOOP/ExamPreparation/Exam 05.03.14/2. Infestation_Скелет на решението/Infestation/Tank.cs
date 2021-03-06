﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    class Tank : Unit
    {
        public const int TankPower = 25;
        public const int TankAggression = 25;
        public const int TankHealth = 20;
        public const UnitClassification TankType = UnitClassification.Mechanical;
        public Tank(string id)
            : base(id, Tank.TankType, Tank.TankHealth, Tank.TankPower, Tank.TankAggression)
        {
        }
    }
}
