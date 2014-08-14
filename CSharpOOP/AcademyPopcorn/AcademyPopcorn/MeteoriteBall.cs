using System;
using System.Collections.Generic;

namespace AcademyPopcorn
{
    //a ball that leaves behind a trail of objects
    class MeteoriteBall : Ball
    {
        private const int trailLifeTime = 3;
        public MeteoriteBall(MatrixCoords topLeft, MatrixCoords speed)
            : base(topLeft, speed)
        {
        }

        public override System.Collections.Generic.IEnumerable<GameObject> ProduceObjects()
        {
            TrailObject trail = new TrailObject(this.TopLeft, new char[,] { { '.' } }, MeteoriteBall.trailLifeTime);
            List<TrailObject> trailList = new List<TrailObject>() {trail };
            return trailList;
        }
    }
}
