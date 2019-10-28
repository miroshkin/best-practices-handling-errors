using System;
using System.Collections;
using System.Threading;
using System.Transactions;

namespace BestPracticesHandlingErrors
{
    class Program
    {
        static void Main(string[] args)
        {

            string value = "asdf";
            long currentUser = 007;
            //Decorate exception
            try
            {
                int a = Int32.Parse(value);
            }
            catch (Exception e)
            {
                //Add data about exception
                e.Data.Add("user", currentUser);
                e.Data.Add("value", value);
                foreach (DictionaryEntry o in e.Data)
                {
                    Console.WriteLine($"{o.Key} : {o.Value}");
                } 
            }

        }
    }


}
