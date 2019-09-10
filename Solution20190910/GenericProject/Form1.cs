using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Test();
        }


        public void Test()
        {
            //List<string> names = new List<string>();

            //Demo<string> demo1 = new Demo<string>();
            //string a1 = demo1.ReturnType("Salam");

            //Demo<int> demo2 = new Demo<int>();
            //int a2 = demo2.ReturnType(55);

            //Student student = new Student
            //{
            //    Name = "Anar",
            //    Age = 27
            //};
            //Demo<Student> demo3 = new Demo<Student>();
            //demo3.ReturnType(student);


            //Dictionary<string, Student> pairs = new Dictionary<string, Student>();
            //pairs.Add("telebe1", new Student { Name = "Esger", Age = 38 });
            //pairs.Add("telebe2", new Student { Name = "Ismayil", Age = 24 });
            //pairs.Add("telebe3", new Student { Name = "Huseyn", Age = 25 });

            //foreach (var item in pairs)
            //{
            //    MessageBox.Show($"{item.Key} - {item.Value.Name}");
            //}

            //ArrayList arrayList = new ArrayList();
            //arrayList.Add("Cavid");
            //arrayList.Add(99);
            //arrayList.Add(true);
            //arrayList.Add(new Student { Name = "Gunel", Age = 20 });

            //foreach (var item in arrayList)
            //{
            //    if (item.GetType().Name == "Student")
            //    {
            //        Student s = item as Student;
            //        MessageBox.Show(s.Name);
            //    }
            //}

            //Hashtable hashtable = new Hashtable();
            //hashtable.Add("Kamil", "Hesenov");
            //hashtable.Add(1, true);
            //hashtable.Add(false, 55);
            //hashtable.Add("Kamil", 777);

            //foreach (var item in hashtable)
            //{
            //    MessageBox.Show(item.ToString());
            //}

          

            Stack myStack = new Stack();
            myStack.Push("Hello!!");
            myStack.Push(0);
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(null);
            myStack.Push(4);
            myStack.Push(5);

            try
            {
                foreach (var itm in myStack)
                {
                    MessageBox.Show(itm.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }
    }
}
