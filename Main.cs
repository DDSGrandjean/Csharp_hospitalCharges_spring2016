using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalCharges
{
    class Main
    {
        static void Main(string[] args)
        {
            int numberDays;
            double totalCharge,
                   surgical,
                   medication,
                   lab,
                   physicalRehab; 

            Heading();
            DisplayInstructions();

            numberDays = GetNumDays();
            medication = GetRxCharge();
            surgical = GetSurgCharge();
            lab = GetLabFee();
            physicalRehab = GetPhysicalCharge();

            totalCharge = GetTotalCharge(numberDays, medication, surgical, lab, physicalRehab);

            Console.WriteLine("\nYour total hospitalization charge is: {0:c}", totalCharge);
            Console.Read();
        }

        private static void Heading()
        {
            Console.WriteLine("**************************************************\n" +
                              "\tHospital Charge\n" + "\tCalculate Hospital Charge\n" +
                              "\tDylan Grandjean\n\t" + DateTime.Today.ToShortDateString() +
                              "\n**************************************************");
        } 

        private static void DisplayInstructions()
        {
            Console.WriteLine("This program will determine hospital charges.\n");
            Console.WriteLine("You will be asked to enter the number of days you\nhave stayed at the hospital for, " +
                              "the amount of\nmedications you have been taking, surgical charges,\nand physical rehabilitation charges." +
                              "\n\n**************************************************");
        }

        private static int GetNumDays()
        {
            int inputValue;

            Console.Write("How any days have you been at the hospital for?: ");
            inputValue = int.Parse(Console.ReadLine());
            return inputValue;
        }

        private static double GetRxCharge()
        {
            double inputValue;

            Console.Write("What is the total of your medication charge? ");
            inputValue = double.Parse(Console.ReadLine());
            return inputValue;
        }

        private static double GetSurgCharge()
        {
            double inputValue;

            Console.Write("What is the total of your surgical charge? ");
            inputValue = double.Parse(Console.ReadLine());
            return inputValue;
        }

        private static double GetLabFee()
        {
            double inputValue;

            Console.Write("What is the total of your lab fees? ");
            inputValue = double.Parse(Console.ReadLine());
            return inputValue;
        }

        private static double GetPhysicalCharge()
        {
            double inputValue;

            Console.Write("What is the total of your physical rehabilitation charge? ");
            inputValue = double.Parse(Console.ReadLine());
            return inputValue;
        }

        private static double GetTotalCharge(int days, double medication, double surgical, double lab, double rehab)
        {
            const double ROOM_FEE = 300;
            double totalCharge,
                   roomCharge;

            roomCharge = days * ROOM_FEE;
            totalCharge = roomCharge + medication + surgical + lab + rehab;

            return totalCharge;
        }
    }
}
