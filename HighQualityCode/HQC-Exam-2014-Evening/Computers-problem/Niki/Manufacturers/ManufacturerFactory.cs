namespace ComputersSystem.Manufacturers
{
    using System;

    public class ManufacturerFactory : IManufacturerFactory
    {
        public IManufacturer GetManufacturer(string name)
        {
            switch (name)
            {
                case "HP": return new HPComputers();
                case "Dell": return new DellComputers();
                case "Lenovo": return new LenovoComputers();
                default:
                    throw new ArgumentException("Invalid manufacturer!");
            }
        }
    }
}
