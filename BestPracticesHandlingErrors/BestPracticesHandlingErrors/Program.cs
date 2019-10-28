using System;
using System.Collections;
using System.Threading;
using System.Transactions;

namespace BestPracticesHandlingErrors
{
    class Program
    {

        //Source 
        //https://blog.elmah.io/csharp-exception-handling-best-practices/?utm_source=csharpdigest&utm_medium=email&utm_campaign=featured


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


            int numberOfHands = 9;
            //Catch specific exceptions
            try
            {
                if (numberOfHands%2 != 0)
                {
                    throw new ArgumentException("");

                }
            }
            catch (ArgumentException e)
            {
                e.Data.Add("numberOfHands", numberOfHands);
                Console.WriteLine($"Incorrect numberOfHands value - {e.Data["numberOfHands"]}");
            }
            catch (NullReferenceException e)
            {

            }
            catch (Exception e)
            {

            }

        }
    }


}
