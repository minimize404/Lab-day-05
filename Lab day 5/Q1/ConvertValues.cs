using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23052023___Lab_Session
{
    public class ConvertValues
    {
        public void kilometerToMeterNoReturnNoParameter()
        {
            Console.Write("Enter the kilometer value: ");
            double kmValue = double.Parse(Console.ReadLine());
            Console.WriteLine(kmValue + " km = " + (kmValue * 1000) + " m");

        }

        public void kilometerToMeterNoReturn(double kmValue)
        {
            Console.WriteLine(kmValue + " km = " + (kmValue * 1000) + " m");
        }

        public double kilometerToMeter(double kmValue)
        {
            return kmValue * 1000;
        }
    }
}
