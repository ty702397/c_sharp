using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Person wang = new Person() { 
                Name = "哈哈哈哈",
                Age = 14,
                //Height = 180
            };
            Person.Id = "123456789";
            Person.ShowId();
           /* wang.Name = "哈哈";
            wang.Age = 22;
            wang.Height = 155;*/
            wang.Eat();
            wang.Run();


        }
    }
}
