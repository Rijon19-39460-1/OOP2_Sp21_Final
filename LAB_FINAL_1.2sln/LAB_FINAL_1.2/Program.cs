using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_FINAL_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("ABC", "145", 3.5f);
            Student s2 = new Student("BCD", "146", 3.6f);
            Student s3 = new Student("EFG", "147", 2.5f);


            Course c2 = new Course("RB", "011", 3);
            Course c3 = new Course("GB", "015", 6);
            Course c4 = new Course("YB", "016", 3);
            Course c5 = new Course("FB", "017", 2);
            Course c6 = new Course("BB", "018", 3);
            Course c7 = new Course("MB", "019", 2);
            s1.Addcourse(c2, c3, c4, c5,c6);
            Console.WriteLine("After Adding course for ID 145");
            s1.ShowcourseInfo();
            s1.Dropcourse(c3);
            Console.WriteLine("After drop  course-GB (015) for ID 145");
            s1.ShowcourseInfo();
            c2.Addstudent(s2, s3);
            Console.WriteLine("Students for course-RB (011) ");
            c2.Showinfo();

        }
    }
}
