using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*   SendMessage("你好，好久不见");*/

            /*  string res = SellHouse(10,1000);
              MessageBox.Show(res);*/

            PlayFootball();
        }
        /// <summary>
        /// 送信函数
        /// </summary>
        /// <param name="message">信件内容</param>
        public void SendMessage(string message)
        {
            MessageBox.Show(message);
        }

        /// <summary>
        /// 中介函数
        /// </summary>
        /// <param name="area">房屋面积</param>
        /// <param name="price">平米单价</param>
        /// <returns></returns>
        public string SellHouse(int area, int price)
        {
            return "张三愿意出价" + (area * price - 1000);
        }

        /// <summary>
        /// 踢球
        /// </summary>
        public void PlayFootball()
        {
            MessageBox.Show("梅西在踢球");
        }
    }
}
