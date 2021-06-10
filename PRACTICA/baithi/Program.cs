using System;
using Ex2.ex2;

namespace baithi
{
    public delegate void ShowNumber(int a, int b );
    internal class Program
    {
        public static ShowNumber ss = new ShowNumber(PrimeNumberFinder.PriceNumber);
        public static void Main(string[] args)
        {
            //ex1
            Mobilephone mbPhone = new Mobilephone();
            mbPhone.PhoneName = "Tran Quan";
            mbPhone.PhoneType = "098889999";
            mbPhone.PhonePrice = 200;
            mbPhone.Display();
            //ex2
            PrimeNumberFinder pn = new PrimeNumberFinder();


        }
    }

  
}