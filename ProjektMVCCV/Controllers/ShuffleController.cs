using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjektMVCCV;
using ProjektMVCCV.Models;

namespace ProjektMVCCV.Controllers
{
    public class ShuffleController : Controller
    {
        // GET: Shuffle
        public ActionResult Index()
        {
            try
            {
                List<char> strShuffled = new List<char>();
                var Strings = new ShuffleModels();
                Random rnd = new Random();
                string  RandomCha = "";
                char[] charAlpha = "abcdefghijklmnopqrstuvxyzåäö".ToCharArray();
                int random;

                #region hur jag löste det

                //Random
                for (int i = 1; i <= 20; i++)
                {
                    random = rnd.Next(1, charAlpha.Count());
                    foreach (char x in charAlpha)
                    {
                        RandomCha = charAlpha[random].ToString();
                    }
                    Strings.Default = Strings.Default + RandomCha;
                }

                //Shuffled
                foreach (var y in Shuffle(Strings.Default.ToList()))
                {
                    Strings.Shuffled = Strings.Shuffled + y.ToString();
                }

                //Sorted
                strShuffled = Strings.Shuffled.ToList();
                strShuffled.Sort();
                foreach (var z in strShuffled)
                {
                    Strings.Sorted = Strings.Sorted + z.ToString();
                }

                //nummer
                int num;
                foreach (var a in strShuffled)
                {
                    if (strShuffled.IndexOf(a) != -1)
                    {
                        num = strShuffled.IndexOf(a) + 1;
                        char upper = char.ToUpper(a);
                        Strings.Number = Strings.Number + " " + a + ": index " + num.ToString() + " alfabetiskt nummer: " + (upper - 'A' + 1) + "  |  ";
                    }
                }
                #endregion

                #region Jag hittade dock detta senare, jag hade användt koden nedan men du skall ju få någonting orginal ifrån mig därav den övre regionen
                    //Random rnd = new Random();
                    //string RndString = string.Empty;
                    //for (int i = 0; i < 20; i++)
                    //{
                    //    RndString += ((char)rnd.Next(97, 122)).ToString();
                    //}
                    //return RndString;
                #endregion

                return View(Strings);
            }

            catch
            {
                return View("Något gick fel...");
            }
        }

        
        public string Shuffle(List<char> List)
        {
            try
            {
                int n = 20;
                string str ="";
                Random rnd = new Random();
                while (n > 1)                               //rotera index medan listan har fler possitioner än 1 
                {
                    int k = (rnd.Next(0, n));               //random ifrån 0 till antalet possitioner i listan
                    n--;

                    //rotera listan med random istället för "<" likt bubble-sort
                    char value = List[k];
                    List[k] = List[n];
                    List[n] = value;
                }
                foreach (var a in List)
                {
                    str = str + a.ToString() ;
                }
                return str.ToString();
            }
            catch
            {
                return ("Något gick fel");
            }
        }
        public ActionResult GetString(List<char> charalp)
        {
            try
            {
                int i = 1;
                int q = 1;

                foreach (char item in charalp)
                {
                    Console.Write(i + "->" + item + " | ");
                    i++;
                }

                charalp.Sort();
                foreach (char item in charalp)
                {
                    Console.Write(q + "->" + item + " | ");
                    q++;
                }

                Shuffle(charalp);
                return View(charalp);
            }
            catch
            {
                return View();
            }
        }
    }
}
