using System;

namespace Laba2.BookFile
{
    public class PublishingHouse
    {
        public PublishingHouse(string name, string country, string city, DateTime yearOfFoundation, OwnershipType ownershipType)
        {
            Name = name;
            Country = country;
            City = city;
            YearOfFoundation = yearOfFoundation;
            OwnershipType = ownershipType;
        }

        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public DateTime YearOfFoundation { get; set; }
        public OwnershipType OwnershipType { get; set; }

        public override string ToString()
        {
            return string.Format("Name - {0} , Country - {1} , City - {2} , Year of Foundation - {3} , Ownership type - {4} ", Name,
                Country, City, YearOfFoundation.Year, OwnershipType);
        }
    }
}