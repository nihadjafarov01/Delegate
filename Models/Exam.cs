namespace ConsoleApp1.Models
{
    internal class Exam
    {
        public static List<Exam> exams = new List<Exam>();

        public Exam()
        {
            student = new Student();
            exams.Add(this);
        }
        public int Point { get; set; }
        public Student student { get; set; }
        public string Subject { get; set; }
        public DateTime StartDate = new DateTime(2023, 11, 01, 9, 15, 0);
        public DateTime EndDate = new DateTime(2023, 11, 01, 11, 15, 0);

        //StudentName  Subject  Point  Duration
        public override string ToString()
        {
            return $"Student name: {student.Name} \nSubject: {Subject} \nPoint: {Point} \nDuration: {EndDate - StartDate}";
        }
    }
}
