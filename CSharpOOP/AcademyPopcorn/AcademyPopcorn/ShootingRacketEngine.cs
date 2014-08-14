using System;

namespace AcademyPopcorn
{
    //An engine that implements the ShootRacket method that in certain conditions fires a shot from the racket.
    class ShootingRacketEngine : Engine
    {
        public ShootingRacketEngine(IRenderer renderer, IUserInterface userInterface, int sleepTime) : base(renderer, userInterface, sleepTime)
        {
        }
        //task 4
        public void ShootRacket()
        {
            if (this.playerRacket is ShootingRacket)
            {
                ShootingRacket shootingRacket = this.playerRacket as ShootingRacket;
                if (shootingRacket.IsShotLoaded)
                {
                    shootingRacket.Shoot();
                }
            }
        }
    }
}
