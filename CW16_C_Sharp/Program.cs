using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

namespace CW16_C_Sharp
{
    internal class Program
    {
        //public static async void GetData()
        //{
        //    double sum = GiveMoney();
        //    string url = @"https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?json";
        //    HttpClient client = new HttpClient();
        //    var response = await client.GetAsync(new Uri(url));
        //    if (response.IsSuccessStatusCode)
        //    {

        //        string jsonContent = await response.Content.ReadAsStringAsync();
        //        List<Currency> data = JsonConvert.DeserializeObject<List<Currency>>(jsonContent);
        //        foreach (Currency currency in data)
        //        {
        //            if (currency.r030 == 840.ToString())
        //            {
        //                Console.WriteLine(sum / currency.rate);
        //            }
        //            //Console.WriteLine($"{currency.r030} {currency.cc} {currency.rate}");
        //        }
        //    }
        //}

        //public static double GiveMoney()
        //{
        //    Console.WriteLine("Сума у гривнях: ");
        //    return Convert.ToDouble(Console.ReadLine());
        //}
        static void Main(string[] args)
        {
            //GetData();
            //Console.ReadLine();

            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };

            // Pair numbers
            var pairNum = arr.Where(num => num % 2 == 0);
            foreach(var nums in pairNum)
            {
                Console.Write(nums + " ");
            }
            Console.Write("\n");

            // Unpair numbers:
            var unpairNum = arr.Where(num => num % 2 == 1);
            foreach (var nums in unpairNum)
            {
                Console.Write(nums + " ");
            }
            Console.Write("\n");

            // Numbers more than:
            var moreThan = arr.Where(num => num > 5);
            foreach (var nums in moreThan)
            {
                Console.Write(nums + " ");
            }
            Console.Write("\n");

            // Range numbers:
            var rangeNums = arr.Where(num => num > 0 && num < 4);
            foreach (var nums in rangeNums)
            {
                Console.Write(nums + " ");
            }
            Console.Write("\n");

            // Multi + sorted:
            var multSeven = arr.Where(num => num % 7 == 0).OrderBy(num => num);
            foreach (var nums in multSeven)
            {
                Console.Write(nums + " ");
            }
            Console.Write("\n");

            var multiEight = arr.Where(num => num % 8 == 0).OrderByDescending(num => num);
            foreach (var nums in multiEight)
            {
                Console.Write(nums + " ");
            }
            Console.Write("\n");

            Console.ReadLine();

        }
    }
}
