using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            name = name.ToLower();

            Console.WriteLine("When is your birthday? (ex. 12/24)");
            string birthdayInput = Console.ReadLine();
            Console.WriteLine(Environment.NewLine);
            string[] birthdayArray = birthdayInput.Split(new char[] { '/' });

            for (int i = 0; i < name.Length; i++)
            {
                char[] aArray = new char[] { 'b', 'c', 'd', 'g', 'j', 'k', 'p', 'q', 't', 'u', 'v', 'w', 'y', 'z' };
                // char[] anArray = new char[] { 'a', 'e', 'f', 'h', 'i', 'l', 'm', 'n', 'o', 'r', 's', 'x' };
                bool needAn = false;
                if (name.IndexOfAny(aArray) == -1)
                {
                    needAn = true;
                }
                if (needAn)
                {
                    Console.Write(string.Format("Give me an {0}{1}", name[i], Environment.NewLine));
                }
                else
                {
                    Console.Write(string.Format("Give me a {0}{1}", name[i], Environment.NewLine));
                }
            }
            Console.WriteLine("{0} is.. GRAND!{1}", name.ToUpper(), Environment.NewLine);

            DateTime today = DateTime.Today;
            Parse parse = new Parse();
            DateTime birthday = parse.ParseBirthday(today, birthdayArray);
            TimeSpan birthdayDiff = birthday - today;
            int tilBirthday = birthdayDiff.Days;

            Console.WriteLine(String.Format("Your birthday is {0} days away!{1}", tilBirthday, Environment.NewLine));
            if (tilBirthday == 0)
            {
                Console.WriteLine("Happy Birthday!!");
            }
            Console.ReadKey();
        }

    }

    public class Parse
    {
        public DateTime ParseBirthday(DateTime today, string[] birthdayArray)
        {
            int birthdayMonth;
            int birthdayDate;
            DateTime birthday;
            if (int.TryParse(birthdayArray[0], out birthdayMonth) && int.TryParse(birthdayArray[1], out birthdayDate))
            {
                birthday = new DateTime(today.Year, birthdayMonth, birthdayDate);
                if (today.CompareTo(birthday) > 0)
                {
                    birthday = birthday.AddYears(1);
                    return birthday;
                }
                return birthday;
            }
            else
            {
                throw new Exception();
            }
        }
    }
}