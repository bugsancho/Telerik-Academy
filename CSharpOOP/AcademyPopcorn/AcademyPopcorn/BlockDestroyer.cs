using System;

namespace AcademyPopcorn
{
    //An object that 'explodes' in one turn, 'killing' a block if such is available at the same location.
    class BlockDestroyer : MovingObject
    {

        public BlockDestroyer(MatrixCoords topLeft)
            : base(topLeft, new char[,] { { ' ' } }, new MatrixCoords(0, 0))
        {
            this.IsDestroyed = true;
        }
        public override void Update()
        {

        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "block";
        }
    }
}
