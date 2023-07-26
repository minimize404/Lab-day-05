using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23052023___Lab_Session
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConvertValues convertValuesObj = new ConvertValues();
            convertValuesObj.kilometerToMeterNoReturnNoParameter();

            Console.Write("Enter the kilometer value: ");
            double kmValue = double.Parse(Console.ReadLine());
            convertValuesObj.kilometerToMeterNoReturn(kmValue);

            // Test
        }
    }
}
