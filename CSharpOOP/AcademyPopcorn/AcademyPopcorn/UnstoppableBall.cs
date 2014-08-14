using System;

namespace AcademyPopcorn
{
    //A ball that only bouces off unpassable block and racket objects
    class UnstoppableBall : Ball
    {
        public new const string CollisionGroupString = "unstoppableBall";

        public UnstoppableBall(MatrixCoords topLeft, MatrixCoords speed)
            : base(topLeft, speed)
        {
        }
        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "unpassableBlock"
                || base.CanCollideWith(otherCollisionGroupString);
        }
        public override string GetCollisionGroupString()
        {
            return UnstoppableBall.CollisionGroupString;
        }
        public override void RespondToCollision(CollisionData collisionData)
        {
            if (collisionData.hitObjectsCollisionGroupStrings.Contains("unpassableBlock") || collisionData.hitObjectsCollisionGroupStrings.Contains("racket"))
            {
                base.RespondToCollision(collisionData);
            }
        }
    }
}
