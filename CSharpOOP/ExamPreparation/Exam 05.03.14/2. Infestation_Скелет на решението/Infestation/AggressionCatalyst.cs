namespace Infestation
{
    public class AggressionCatalyst : Catalyst
    {
        public override int AggressionEffect
        {
            get
            {
                return Catalyst.BoostedEffectStrength;
            }
        }
    }
}