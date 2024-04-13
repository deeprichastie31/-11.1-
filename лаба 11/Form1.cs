using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using лаба_11.Properties;

namespace лаба_11
{
    public partial class Form1 : Form
    {
        int n;
        bool iscollapsed = true;
        public Form1()
        {
            InitializeComponent();
        }

        private double formula(int n)
        {
            return Math.Pow(-1, n) * (n + 1);
        }
        private double whhile(int n)
        {
            double rez = 0;
            while (n >= 0)
            {
                rez += Math.Pow(-1, n) * (2 * n + 1);
                n--;
            }
            return rez;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e) 
        { 
            if (iscollapsed) // пока не выполнится некое условие, таймер будет работать
            {
                panel3.Height += 5; // высота панели, в которой находится две три кнопки, причем две функцональные, за каждую итерацию увеличивается на 5 пикселей.
                // для этого необходимо задать в свойствах панели минимальное и максимальное значение
                if (panel3.Size == panel3.MaximumSize) // если панель достигает своих максимальных размеров, то таймер останавливается и метка присваивает значение false, чтобы при повторном нажатии выполнилось другое условие и панель закрылась
                {
                    timer1.Stop();
                    iscollapsed = false;
                }
            }
            else 
            {
                panel3.Height -= 5;
                if (panel3.Size == panel3.MinimumSize)
                {
                    timer1.Stop();
                    iscollapsed = true;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start(); // Запускает таймер по нажатию кнопки, ну то есть метод таймер, в котором вся необходимая логика уже расписана.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                n = Convert.ToInt32(textBox2.Text);
                if (n > int.MaxValue || n < int.MinValue)
                {
                    throw new OverflowException("Число должно входить в диапозон значений Int 32");
                }
                textBox1.Text = Convert.ToString(formula(n));
            }
            catch (OverflowException)
            {
                textBox1.Text = "Число должно входить в диапозон значений Int 32, Нажмите С";
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                n = Convert.ToInt32(textBox2.Text);
                if (n > int.MaxValue || n < int.MinValue)
                {
                    throw new OverflowException("Число должно входить в диапозон значений Int 32");
                }
                textBox1.Text = Convert.ToString(whhile(n));
            }
            catch (OverflowException)
            {
                textBox1.Text = "Число должно входить в диапозон значений Int 32, Нажмите С";
                textBox2 = null;
                n = 0;
            }
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = null;
            n = 0;
        }





        //private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        //{
        //    if (scroll == hScrollBar1.Value)
        //    {
        //        textBox2.Location = new Point(textBox2.Location.X + 2); // изменяем позицию внутри панели с вводом
        //        label1.Location = new Point(label1.Location.X + 2);
        //        panel1.Location = new Point(panel1.Location.X + 2);
        //    }
        //    else if (scroll < hScrollBar1.Value)
        //    {
        //        textBox2.Location = new Point(textBox2.Location.X - 2);
        //        label1.Location = new Point(label1.Location.X - 2);
        //        panel1.Location = new Point(panel1.Location.X - 2);
        //    }
        //    else if (scroll > hScrollBar1.Value)
        //    {
        //        textBox2.Location = new Point(textBox2.Location.X + 2);
        //        label1.Location = new Point(label1.Location.X + 2);
        //        panel1.Location = new Point(panel1.Location.X + 2);
        //    }
        //    scroll = hScrollBar1.Value;
        //}
    }
}

//**************************
//*** Randomize the list ***
//**************************
