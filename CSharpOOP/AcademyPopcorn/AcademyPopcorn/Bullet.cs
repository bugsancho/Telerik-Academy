using System;

namespace AcademyPopcorn
{
    //A moving object that moves upwards and is destroyed upon collision.
    class Bullet : MovingObject
    {
        public Bullet(MatrixCoords topLeft)
            : base(topLeft, new char[,] { { '|' } }, new MatrixCoords(-1, 0))
        {
        }
        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }
        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return true;
        }
    }
}
