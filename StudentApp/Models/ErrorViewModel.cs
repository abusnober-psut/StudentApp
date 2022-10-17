namespace StudentApp.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Branch { get; set; }
        public string Section { get; set; }
        public decimal GPA { get; set; }

    }

    public class StudentBusinessLayer
    {
        public Student getByID(int stID)
        {
            Student myStudent = new Student();
            myStudent.ID = stID;
            myStudent.Name = "Mohammad";
            myStudent.GPA = 88.9m;

            return myStudent;

        }

    }

}