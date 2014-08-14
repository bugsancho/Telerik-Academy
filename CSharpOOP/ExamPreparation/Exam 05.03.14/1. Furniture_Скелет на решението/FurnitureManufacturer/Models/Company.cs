namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using FurnitureManufacturer.Interfaces;
    using System.Linq;
    using System.Text;

    public class Company : ICompany
    {
        private ICollection<IFurniture> furnitures;
        private string registrationNumber;
        private string name;

        public Company(string name, string registrationNumber)
        {
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
            this.Furnitures = new List<IFurniture>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name of a company cannot be null or empty");
                }
                if (value.Length < 5)
                {
                    throw new ArgumentException("The name of a company cannot be less than 5 characters long");
                }
                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get { return this.registrationNumber; }
            private set
            {
                if (value.Length != 10)
                {
                    throw new ArgumentException("Registration number must be exactly 10 digits long");
                }
                long number;
                bool isNumeric = long.TryParse(value, out number);
                if (!isNumeric)
                {
                    throw new ArgumentException("Registration number must contain only digits.");
                }
                this.registrationNumber = value;
            }
        }

        public ICollection<IFurniture> Furnitures
        {
            get { return new List<IFurniture>(furnitures); }
            private set { furnitures = value; }
        }




        public void Add(IFurniture furniture)
        {
            //if (furniture != null)
            //{
            //    throw new ArgumentNullException("Cannot add a furniture that has null reference");
            //}
            this.furnitures.Add(furniture);
        }

        public void Remove(IFurniture furniture)
        {
            //if (furniture != null)
            //{
            //    throw new ArgumentNullException("Cannot remove a furniture that has null reference");
            //}
            this.furnitures.Remove(furniture);
        }

        public IFurniture Find(string model)
        {
            return this.Furnitures.FirstOrDefault(x => x.Model.ToLower() == model.ToLower());
        }

        public string Catalog()
        {
            var info = new StringBuilder();
            info.AppendFormat("{0} - {1} - {2} {3}",
                  this.Name,
                  this.RegistrationNumber,
                  this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
                  this.Furnitures.Count != 1 ? "furnitures" : "furniture");

            var orderedFurniture = this.Furnitures.OrderBy(x => x.Price).ThenBy(x => x.Model);
            
            foreach (var item in orderedFurniture)
            {
                info.AppendLine();
                info.Append(item.ToString());
            }

            return info.ToString();
        }
    }
}