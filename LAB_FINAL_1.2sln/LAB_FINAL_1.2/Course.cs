using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_FINAL_1._2
{
    class Course
    {
        private String courseName;
        private String courseCode;
        private int courseCredit;
        public static int studentLimit = 30;
        public int scount = 0;
        public Student[] student = new Student[studentLimit];
        public String CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }
        public String CourseCode
        {
            get { return courseCode; }
            set { courseCode = value; }
        }
        public int CourseCredit
        {
            get { return courseCredit; }
            set { courseCredit = value; }
        }

      public Course()
        {
        }
      public Course(string courseName, string courseCode, int courseCredit)
        {
            this.courseName = courseName;
            this.courseCode = courseCode;
            this.courseCredit = courseCredit;
        }
      public void Addstudent(params Student[] stu)
      {
          foreach (Student s in stu)
          {
              if (scount < studentLimit && s.count < Student.coursetLimit)
              {
                  student[scount++] = s;
                  
              }
          }
      }
      public void Removestudent(Student s)
      {
          bool su = true;
          for (int i = 0; i < scount; i++)
          {

              if (student[i] == s)
              {
                  student[i] = null;
                  scount--;
                  su = false;
              }
              if (!su)
              {
                  student[i] = student[i + 1];
              }

          }
      }

      public void ShowCourseInfo()
      {
          Console.WriteLine("Course Name = " + courseName);
          Console.WriteLine("Course Code = " + courseCode);
          Console.WriteLine("Course Credit = " + courseCredit);
      }
      public void Showinfo()
      {

          if (scount < studentLimit)
          {

              for (int i = 0; i < scount; i++)
              {
                  student[i].ShowInfo();

              }
          }
          else
          {
              Console.WriteLine("Seat available for 30 student");
          }

      }
    }
}
