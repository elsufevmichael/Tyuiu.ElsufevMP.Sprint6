using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ElsufevMP.Sprint6.Task5.V16.Lib
{
    public class DataService : ISprint6Task5V16
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            //Получение кол-ва строк в файле
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    len++;
                }
            }

            //массив, длинна которого соответствует кол-ву строк в файле
            double[] numsArray = new double[len];

            //заносим значения в массив
            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    numsArray[index] = Convert.ToDouble(line);
                    index++;
                }
            }

            //оставляем только положительные значения
            numsArray = numsArray.Where(val => val > 0).ToArray();

            return numsArray;
        }
    }
}
