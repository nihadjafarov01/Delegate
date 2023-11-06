using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        public delegate string myDelegate(List<Exam> x);

        static void Main(string[] args)
        {

            Exam exam2 = new Exam();
            //List<Exam> exams = new List<Exam>();
            exam2.student.Name = "Nicat";
            exam2.Subject = "Math";
            exam2.Point = 75;
            //exam1.StartDate = 14;
            //exam1.EndDate = 17;
            //myDelegate d = new myDelegate(listhefte);
            //Console.WriteLine(d(Exam.exams));

            static string list50(List<Exam> x)
            {
                for (int i = 0; i < x.Count; i++)
                {
                    if (x[i].Point > 50)
                    {
                        Console.WriteLine(x[i]);
                    }
                }
                return null;
            }
            static string listhefte(List<Exam> x)
            {
                DateTime UpToDate = new DateTime(2023, 10, 01, 11, 15, 0);
                for (int i = 0; i < x.Count; i++)
                {
                    if (x[i].StartDate > UpToDate)
                    {
                        Console.WriteLine(x[i]);
                    }
                }
                return null;
            }
            //static string listsaat(List<Exam> x)
            //{

            //    DateTime saat = new DateTime(00, 00, 00, 01, 00, 00);
            //    for (int i = 0; i < x.Count; i++)
            //    {
            //        if ((x[i].StartDate - x[i].EndDate.Hour) > saat)
            //        {
            //            Console.WriteLine(x[i]);
            //        }
            //    }
            //    return null;
            //}
            char option = '0';
            do
            {
                Console.WriteLine("1. Exam yaratmaq\n2.  pointi 50-den cox olan  examlarin siyahisini gosterirsiniz\n3. son 1 hefte erzinde olan  examlarin siyahisini gosterirsiniz\n4. 1-saatdan uzun ceken imtahanlarin siyahisi");
                option = Convert.ToChar(Console.ReadLine());
                switch (option)
                {
                    case '1':
                        Console.WriteLine("Student name: ");
                        string name = Console.ReadLine();
                        Exam exam1 = new Exam();
                        exam1.student.Name = name;
                        Console.WriteLine("Subject: ");
                        string subject = Console.ReadLine();
                        exam1.Subject = subject;
                        Console.WriteLine("Point: ");
                        int point = Convert.ToInt32(Console.ReadLine());
                        exam1.Point = point;
                        Console.WriteLine("Start time: ");
                        DateTime StartDate = new DateTime();
                        StartDate = Convert.ToDateTime(Console.ReadLine());
                        exam1.StartDate = StartDate;
                        Console.WriteLine("End time: ");
                        DateTime EndDate = new DateTime();
                        EndDate = Convert.ToDateTime(Console.ReadLine());
                        exam1.EndDate = EndDate;
                        break;
                    case '2':
                        myDelegate d = new myDelegate(list50);
                        break;
                    case '3':
                        myDelegate d2 = new myDelegate(listhefte);
                        break;
                    case '4':
                        //myDelegate d3 = new myDelegate(listsaat);
                        break;
                }
            }
            while (option != 'q');
        }
    }
}