using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Project
{


    class Program
    {
        private const int INPUT_DATA_OPTION = 1;
        private const int CROSS_JOIN_OPTION = 2;
        private const int PRINT_CALCULATIONS_OPTION = 3;
        private const int PRINT_RESULTS = 4;
        private const int CLEAR_DB_OPTION = 5;

        static void Main(string[] args)
        {

            int action = 0;
            while (action != 6)
            {
                action = Menu.StartMenu();
                switch (action)
                {
                    case INPUT_DATA_OPTION:
                        Calculator.InputData();
                        break;
                    case CROSS_JOIN_OPTION:
                        Calculator.CrossJoinData();
                        break;
                    case PRINT_CALCULATIONS_OPTION:
                        Calculator.PrintCalc();
                        break;
                    case PRINT_RESULTS:
                        Calculator.PrintResults();
                        break;
                    case CLEAR_DB_OPTION:
                        Calculator.ClearDB();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
