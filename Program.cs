using System;
using NUnit.Framework;

namespace TryNUnitDotNet
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(new Stomach().contents);
        }

        public static string FriendlyMainClaim()
        {
            return "I swear I'm nice!";
        }

        static string PrivateFriendlyMainClaim()
        {
            return "Psst I'm nice";
        }
    }

    public class Stomach
    {
        public int contents = 4;
        public string bloodType = "A+";

        public string BloodType
        {
            get { return bloodType; }
            set { bloodType = value; }
        }

        public string Growl()
        {
            return "grrr";
        }

        public int Digest(int count)
        {
            contents -= count;
            return contents;
        }

        string PrivateExclamation()
        {
            return "excuse me";
        }
    }
}
