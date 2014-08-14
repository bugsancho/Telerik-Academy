using System;
using System.Collections.Generic;

namespace AcademyPopcorn
{
    //A block that upon destruction leaves behind a gift object
    class GiftBlock : Block
    {
        private bool isFirstHit = true;
        public GiftBlock(MatrixCoords topLeft) : base(topLeft)
        {
        }
        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<Gift> gifts = new List<Gift>();
            if (this.IsDestroyed && this.isFirstHit)
            {
                gifts.Add(new Gift(new MatrixCoords(this.TopLeft.Row,this.TopLeft.Col)));
                this.isFirstHit = false;
            }
            return gifts;
        }
    }
}
