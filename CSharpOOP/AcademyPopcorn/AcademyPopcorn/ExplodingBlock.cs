using System;
using System.Collections.Generic;

namespace AcademyPopcorn
{
    //A block that upon destruction produces several BlockDestroyer objects, in every surrounding 'tile'.
    class ExplodingBlock : Block
    {
        bool isFirstExplosion = true;
        public ExplodingBlock(MatrixCoords topLeft)
            : base(topLeft)
        {
        }
        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<BlockDestroyer> bombs = new List<BlockDestroyer>();
            if (this.IsDestroyed && this.isFirstExplosion)
            {
                bombs.Add(new BlockDestroyer(new MatrixCoords(this.TopLeft.Row + 1, this.TopLeft.Col - 1)));
                bombs.Add(new BlockDestroyer(new MatrixCoords(this.TopLeft.Row + 1, this.TopLeft.Col)));
                bombs.Add(new BlockDestroyer(new MatrixCoords(this.TopLeft.Row + 1, this.TopLeft.Col + 1)));
                bombs.Add(new BlockDestroyer(new MatrixCoords(this.TopLeft.Row - 1, this.TopLeft.Col - 1)));
                bombs.Add(new BlockDestroyer(new MatrixCoords(this.TopLeft.Row - 1, this.TopLeft.Col)));
                bombs.Add(new BlockDestroyer(new MatrixCoords(this.TopLeft.Row - 1, this.TopLeft.Col + 1)));
                bombs.Add(new BlockDestroyer(new MatrixCoords(this.TopLeft.Row, this.TopLeft.Col - 1)));
                bombs.Add(new BlockDestroyer(new MatrixCoords(this.TopLeft.Row, this.TopLeft.Col + 1)));
                this.isFirstExplosion = false;
            }
            return bombs;
        }
    }

}
