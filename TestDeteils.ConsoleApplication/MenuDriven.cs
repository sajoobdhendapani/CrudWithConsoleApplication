using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DapperDataAccessLayer;

namespace TestDeteils.ConsoleApplication
{
    class MenuDriven
    {
        ITestDetailsRepostory objTestDetails;
        public MenuDriven()
        {
            objTestDetails = new TestDetailsRepostory();
        }
        public void Menu()
        {
            int a = 5;
            do
            {
                Console.WriteLine("1 Insert");
                Console.WriteLine("2 Read");
                Console.WriteLine("3 Delete");
                Console.WriteLine("4 Update");
                Console.WriteLine("5 Read By number");
                Console.WriteLine("Enter the number");
                Console.WriteLine("6 Exit ");
                Console.WriteLine("Enter The Number");
                a = Convert.ToInt32(Console.ReadLine());

                switch (a)
                {
                    case 1:
                        Console.WriteLine("No of product count needer");
                        int count = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < count; i++)
                        {
                            TestDetails test = new TestDetails();

                            Console.WriteLine("Enter the Name");
                            test.Name = Console.ReadLine();
                            Console.WriteLine("Enter the Number");
                            test.Number = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the Duration");
                            test.Duration = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter the Score");
                            test.Score = Convert.ToInt64(Console.ReadLine());

                            test.StartDate = DateTime.Today;

                            objTestDetails.InsertSP(test);
                        }break;

                    case 2:

                        var read = objTestDetails.ReadSP();
                        Console.WriteLine($"Id     Name    Number     Duration     Scope      StartDate");
                        foreach(var R in read)
                        {
                            Console.WriteLine($"{R.Id}\t{R.Name}\t{R.Number}\t{R.Duration}\t{R.Score}\t{R.StartDate}");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter your Record Delete");
                        long delt = Convert.ToInt64(Console.ReadLine());
                        var dl = objTestDetails.DeleteSP(delt);
                        break;

                }
            } while (a != 6);
        }
    }
}
