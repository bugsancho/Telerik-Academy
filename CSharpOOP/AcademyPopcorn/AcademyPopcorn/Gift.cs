using System;
using System.Collections.Generic;

namespace AcademyPopcorn
{
    //An object that falls down and is destroyed upon colliding with a racket.
    class Gift : MovingObject
    {
        public new const string CollisionGroupString = "gift";

        public Gift(MatrixCoords topLeft) : base(topLeft, new char[,]{{'+'}}, new MatrixCoords(1,0))
        {

        }
        
        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "racket";
        }
        public override void RespondToCollision(CollisionData collisionData)
        {
            if (collisionData.hitObjectsCollisionGroupStrings.Contains("racket"))
            {
                this.IsDestroyed = true;
            }
        }
        public override string GetCollisionGroupString()
        {
            return Gift.CollisionGroupString;
        }
    }
}
