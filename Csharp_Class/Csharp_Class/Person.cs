using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_Class {
    class Person {
        // public 修饰符 所有项目可以引用
        public string Name { get; set; }
        // internal 修饰符 只能在本项目中引用
        internal int Age { get; set; }
        // private 修饰符 私有的，只能在本类中引用
        private int Height { get; set; }

        public void Eat () {
            MessageBox.Show (Name + "吃饭");
        }
        public void Run () {
            MessageBox.Show (Name + "跑步");
        }

        // 静态属性和方法用static 修饰
        public static string Id { get; set; }
        public static void ShowId () {
            MessageBox.Show (Id);
        }
    }

}