using System;
using System.Collections.Generic;

namespace AcademyPopcorn
{
    //A racket that on collision with a gift loads a shot that is fired when the Shoot method is called
    class ShootingRacket : Racket
    {
        private bool isShotLoaded = false;
        private bool isShotFired = false;
        public bool IsShotFired
        {
            get
            {
                return this.isShotFired;
            }
            set
            {
                this.isShotFired = value;
            }
        }

        public bool IsShotLoaded
        {
            get
            {
                return this.isShotLoaded;
            }
            set
            {
                this.isShotLoaded = value;
            }
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            if (collisionData.hitObjectsCollisionGroupStrings.Contains("gift"))
            {
                IsShotLoaded = true;
            }
            else
            {
                base.RespondToCollision(collisionData);
            }
        }
        public void Shoot()
        {
            this.IsShotFired = true;
        }
        public override IEnumerable<GameObject> ProduceObjects()
        {
            if (IsShotFired && IsShotLoaded)
            {
                IsShotLoaded = false;
                IsShotFired = false;
                return new List<Bullet> { new Bullet(new MatrixCoords(this.TopLeft.Row, this.TopLeft.Col + this.Width / 2)) };
            }
            else
            {
                return base.ProduceObjects();
            }
        }
        public ShootingRacket(MatrixCoords topLeft, int width)
            : base(topLeft, width)
        {
        }
    }
}
