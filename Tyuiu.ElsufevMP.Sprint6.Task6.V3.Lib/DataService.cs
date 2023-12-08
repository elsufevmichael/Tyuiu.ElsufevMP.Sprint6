using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ElsufevMP.Sprint6.Task6.V3.Lib
{
    public class DataService : ISprint6Task6V3
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    //Обработка условия:
                    //var array = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToArray();
                    string[] words = line.Split(' ', ',', '.');
                    for (int i = 0; i < words.Length; i++)
                    {
                        if (words[i].Contains('r'))
                        {
                            resStr = resStr + " " + words[i];
                        }
                    }
                }
            }
            return resStr;
        }
    }
}
