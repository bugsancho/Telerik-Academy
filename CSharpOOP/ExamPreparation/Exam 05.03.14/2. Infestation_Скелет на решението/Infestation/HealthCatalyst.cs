namespace Infestation
{
    public class HealthCatalyst : Catalyst
    {
        public override int HealthEffect
        {
            get
            {
                return Catalyst.BoostedEffectStrength;
            }
        }
    }
}