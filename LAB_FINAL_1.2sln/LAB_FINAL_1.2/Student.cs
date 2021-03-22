using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_FINAL_1._2
{
    class Student
    {
        public static int coursetLimit =5;
        public Course[] course = new Course[coursetLimit];
        public int count =0;
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private float cgpa;

        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }

        public Student()
        {
        }
        public Student(string name, string id, float cgpa)
        {
            this.name = name;
            this.id = id;
            this.cgpa = cgpa;
        }
        public void Addcourse (params Course[] cor)
        {
            foreach (Course c in cor)
            {
                if (count < coursetLimit && c.scount < Course.studentLimit)
                {
                    course[count++] = c;
                    c.Addstudent(this);

                }
            }
            
        }
        public void Dropcourse(Course c)
        {
            bool cr = true;
            for (int i = 0; i < count; i++)
            {

                if (course[i] == c)
                {
                    course[i] = null;
                    count--;
                    cr = false;
                }
                if (!cr)
                {
                    course[i] = course[i + 1];
                }

            }
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Cgpa: " + cgpa);
        }
        public void ShowcourseInfo()
        {

            if (count < coursetLimit)
            {
                for (int i = 0; i < count; i++)
                {
                    course[i].ShowCourseInfo();

                }
            }
            else
            {
                Console.WriteLine("take only 5 course");
            }
           
        }
    }
}
