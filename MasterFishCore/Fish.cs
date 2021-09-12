using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterFishCore
{
    public class Fish
    {
        public string Name { get; }
        public int MaxTemp { get; }
        public int MinTemp { get; }
        public int MaxTime { get; }
        public int MinTime { get; }
        private string[] TempArr { get; }

        int maxCounter = 0;
        int minCounter = 0;
        bool isFull;
        string Log = "";


        public Fish(string name, int maxTemp, int minTemp, int maxTime, int minTime, string tempArr)
        {
            Name = name;
            MaxTemp = maxTemp;
            MinTemp = minTemp;
            MaxTime = maxTime;
            MinTime = minTime;
            isFull = true;
            TempArr = tempArr.Split();
        }

        public Fish(string name, int maxTemp, int maxTime, string tempArr)
        {
            Name = name;
            MaxTemp = maxTemp;
            MaxTime = maxTime;
            TempArr = tempArr.Split();
            isFull = false;
        }
        
        public void Calc()
        {
            for (int i = 0; i < TempArr.Length; i++)
            {
                if (Convert.ToInt32(TempArr[i]) > MaxTemp)
                {
                    maxCounter++;
                }

                else if ((Convert.ToInt32(TempArr[i]) < MaxTemp) && (isFull == false))
                {
                    maxCounter++;
                }

                else if (Convert.ToInt32(TempArr[i]) < MinTemp)
                {
                    minCounter++;
                }
            }

            if (maxCounter * 10 > MaxTime)
            {
                Log += $"Превышение порога максимальной температуры на {maxCounter * 10} Минут; {Environment.NewLine}";
            }

            if (isFull == true)
            {
                if (minCounter * 10 > MinTime)
                {
                    Log += $"Превышение порога минимальной температуры на {minCounter * 10} Минут; {Environment.NewLine}";
                }
            }
        }
    }
}
