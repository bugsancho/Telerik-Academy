using System;

namespace AcademyPopcorn
{
    //a GameObject that 'self-destroys' after a predicated number of turns(updates).
    class TrailObject : GameObject
    {
        private int lifeTime;
        private int counter;
        public TrailObject(MatrixCoords topLeft, char[,] body, int lifeTime) : base(topLeft, body)
        {
            this.lifeTime = lifeTime;
        }

        public override void Update()
        {
            if (this.counter >= this.lifeTime)
            {
                this.IsDestroyed = true;
            }
            else
            {
                this.counter++;
            }
        }
    }
}
