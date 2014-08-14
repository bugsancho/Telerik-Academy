namespace ComputersSystem.Manufacturers
{
    using System;

    public interface IManufacturerFactory
    {
        IManufacturer GetManufacturer(string name);
    }
}