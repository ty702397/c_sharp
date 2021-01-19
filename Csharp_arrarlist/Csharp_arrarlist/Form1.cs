using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Csharp_arrarlist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             * 优势：
             * 内存读取快速
             * 劣势：
             * 数组的两个数据间，插入数据麻烦
             * 数组长度固定。过长，浪费内存。过短，内存溢出。
             */

            //定义数组
            string[] aa = new string[5];
            int[] bb = new int[] { 1, 2, 3, 4, 5 };

            /*
             * 优势：
             * 集合的大小是动态扩展或缩减。
             * 声明时，不用指定长度。
             * 可以方便的添加、删除、插入。
             * 劣势：
             * 使用的object类型进行存储。（object是所有类的父类。父类是可以接收子类的数据。）
             * 不安全，使用时可能会出现类型不匹配。
             * 存储存在装箱和拆箱的操作，导致性能低下。
             */
            //定义集合
            ArrayList arraylist = new ArrayList();
           //在集合尾部添加数据
            arraylist.Add(123);
            arraylist.Add("abc");
            //在集合指定位置添加数据
            arraylist.Insert(1, 321 + "cba");
            //删除集合中对应下标的数据
            arraylist.RemoveAt(0);
            //删除集合中指定的数据
            arraylist.Remove("abc");

            // 定义List泛型集合 
            List<int> intlist = new List<int>() { 
            1,2,3,4,5
            };
            // 同样可以使用add、insert、remove、removeat、clear()清空所有数据
            intlist.Add(1);
            intlist[1] = 10;
            intlist.Insert(3, 14);
            intlist.Remove(3);
            intlist.RemoveAt(0);
            intlist.Clear();
            //intlist.Add("abc"); 定义了int类型的泛型限制，List集合不能存储其他类型

        }
    }
}
