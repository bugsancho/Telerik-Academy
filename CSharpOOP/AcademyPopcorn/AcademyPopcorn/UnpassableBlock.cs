using System;

namespace AcademyPopcorn
{
    //A block that doesn't respond to collision(is indestructible).
    class UnpassableBlock : Block
    {
        public new const string CollisionGroupString = "unpassableBlock";

        public UnpassableBlock(MatrixCoords topLeft) : base(topLeft)
        {
            base.body = new char[,] { {'-' } };
        }
        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "unstoppableBall" || base.CanCollideWith(otherCollisionGroupString);
        }
        public override string GetCollisionGroupString()
        {
            return UnpassableBlock.CollisionGroupString;
        }
        public override void RespondToCollision(CollisionData collisionData)
        {
        }
    }
}
