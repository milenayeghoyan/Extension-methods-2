using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_methods_2
{
    // task 1
    public static class StringExtension
    {
        public static string Foo(this string s)
        {

            string[] c = s.Split(' ');
            for (int i = 0; i < c.Length; i++)
            {
                char c2 = char.ToUpper(c[i][0]);
                string anotherstring = c[i].Substring(1).ToLower();
                c[i] = c2 + anotherstring;
            }
            string str = string.Join(" ", c);
            return str;
        }
    }
    // task 2 without extension methods 
    class Person : IComparable
    {
        public string name { get; set; }
        public int age { get; set; }

        public int CompareTo(object obj)
        {
            if (!(obj is Person otherPersonn))
            {
                throw new NotImplementedException();
            }
            return age.CompareTo(otherPersonn.age);
        }

    }
    // task 15 
    public class CallRecord
    {
        public int Duration { get; set; }

    }
    public class DataUsage
    {
        public int Usageamount { get; set; }
    }
    public class Price // gnayin plan 
    {
        public int CallRate { get; set; } = 5;
        public int DataRate { get; set; } = 10;
    }

    public static class IEnumerableExtension
    {
        public static int CalculateCallsTotalPrice(this IEnumerable<CallRecord> callRecords, Price price)
        {
            int cost = 0;
            foreach (var item in callRecords)
            {
                cost += item.Duration * price.CallRate;
            }
            return cost;
        }
        public static int CalculateCost(this IEnumerable<DataUsage> dataUsages, Price price )
        {
            int totalCost = 0;
            foreach (var item in dataUsages)
            {
                totalCost += item.Usageamount * price.DataRate;
            }
            return totalCost;

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            /* // task 1 
           string newstring = "hello word";
           Console.WriteLine(newstring.Foo());*/


            /* //task 2 
             List<Person> person = new List<Person>()
             {
                 new Person{name="Albert",age=25},
                 new Person{name="Armen", age=43},
                 new Person{name="Vera",age=10}
             };
             person.Sort();
             foreach (var item in person) 
             {
                 Console.WriteLine($"{item.name}-{item.age}");
             }*/


            /* //task 15 
             IEnumerable<CallRecord> callRecords = new List<CallRecord>()
             {
                 new CallRecord(){ Duration =10},
                 new CallRecord(){ Duration =20},
                 new CallRecord(){ Duration =30},
             };
             IEnumerable<DataUsage> dataUsage = new List<DataUsage>()
             {
                 new DataUsage(){ Usageamount =5},
                 new DataUsage(){ Usageamount =10},
             };

             Price price = new Price();
             var bill=callRecords.CalculateCallsTotalPrice(price)+dataUsage.CalculateCost(price);
             Console.WriteLine(bill);


             */


        }
    }
}
