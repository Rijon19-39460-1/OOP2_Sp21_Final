using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace final_lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string cname = tbName.Text;
            string ccode = tbCode.Text;

            string connString = @"Server=LAPTOP-D3473TU4;Database=COURSE;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string query = string.Format("insert into course values ('{0}','{1}')",cname,ccode);
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();
                if (r > 0)
                {
                    MessageBox.Show("Course Inserted");
                }
                else
                {
                    MessageBox.Show("Failed to insert course");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loadData_Click(object sender, EventArgs e)
        {
            string cname = tbName.Text;
            string ccode = tbCode.Text;

            string connString = @"Server=LAPTOP-D3473TU4;Database=COURSE;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);
            List<Course> course = new List<Course>();
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string query = "select * from course";
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Course c = new Course();
                    c.id = reader.GetInt32(reader.GetOrdinal("id"));
                    c.CourseName = reader.GetString(reader.GetOrdinal("CourseName"));
                    c.CourseCode = reader.GetString(reader.GetOrdinal("CourseCode"));
                    course.Add(c);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            dtView.DataSource = course;
            dtView.Visible = true;
        }
    }
}
