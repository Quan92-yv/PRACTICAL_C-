using System;

namespace Ex1
{
    public class Phone
    {
        public string PhoneName { get; set; }
        public string PhoneType { get; set; }
        public float PhonePrice { get; set; }

        public void display()
        {
            Console.WriteLine($"Phone {PhoneName}, type {PhoneType}, price {PhonePrice}");
        }
    }
}