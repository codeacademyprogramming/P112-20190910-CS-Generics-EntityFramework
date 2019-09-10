using CourseProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class Form1 : Form
    {

        private readonly P112CourseEntities _context;
        public Form1()
        {
            InitializeComponent();
            _context = new P112CourseEntities();

            //Demo();
        }

        public void Demo()
        {
            //List<Classroom> otaqlar = _context.Classrooms.ToList();


            //foreach (Classroom otaq in otaqlar)
            //{
            //    List<Group> groups = otaq.Groups.ToList();

            //    foreach (Group item in groups)
            //    {
            //        MessageBox.Show($"Otaq: {otaq.Name} - {item.Name}");
            //    }
            //}

            //Student student = _context.Students.Find(11);
            //MessageBox.Show(student.Firstname);

            //Student student = _context.Students.FirstOrDefault(s => s.Lastname.Contains("ova"));
            //MessageBox.Show($"{student.Firstname} {student.Lastname} {student.Birthdate?.ToString("dd.MM.yyyy")}");

            //List<Student> students = _context.Students.Where(s => s.Lastname.Contains("ev")).ToList();

            //foreach (Student item in students)
            //{
            //    MessageBox.Show(item.Firstname);
            //}


            //Classroom classroom = new Classroom
            //{
            //    Name = "Saturn",
            //    Capacity = 20
            //};

            //_context.Classrooms.Add(classroom);
            //_context.SaveChanges();

            //Student student = _context.Students.FirstOrDefault(s => s.Firstname == "Gunel" && s.Lastname == "Huseynova");
            //student.Email = "gunelho@code.edu.az";
            //_context.SaveChanges();

            //Classroom classroom = _context.Classrooms.FirstOrDefault(c => c.Name == "Test23");
            //if (classroom != null)
            //{
            //    _context.Classrooms.Remove(classroom);
            //    _context.SaveChanges();
            //}

            //List<Classroom> classrooms = _context.Classrooms.Where(c => c.Name == "Test2").ToList();
            //_context.Classrooms.RemoveRange(classrooms);
            //_context.SaveChanges();

            //List<Classroom> classrooms = _context.Classrooms.Where(c => !c.Name.EndsWith("n")).ToList();
            //_context.Classrooms.RemoveRange(classrooms);
            //_context.SaveChanges();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            Classroom classroom = new Classroom();
            classroom.Name = txtName.Text;
            classroom.Capacity = Convert.ToInt32(txtCapacity.Text);


            _context.Classrooms.Add(classroom);
            _context.SaveChanges();

            txtName.Text = "";
            txtCapacity.Text = "";

            Employee employee = new Employee();
            employee.Phones.Add("0505555000");








        }
    }
}
