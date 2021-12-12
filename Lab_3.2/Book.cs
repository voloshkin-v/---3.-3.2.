using System;

namespace Lab_2
{
    public class Book
    {
        public long SerialNumber { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public int SamplesCount { get; set; }

        public Book() { }
        
        public Book(long serialNumber, string name, int year, double price, int samplesCount)
        {
            SerialNumber = serialNumber;
            Name = name;
            Year = year;
            Price = price;
            SamplesCount = samplesCount;
        }

        public void IncreasePrice(double percentage)
        {
            Price = Price + Price / 100 * percentage;
        }

        public double EditionPrice => Price * SamplesCount;

        public override string ToString() => $"{SerialNumber} {Name} {Price}";
    }
}