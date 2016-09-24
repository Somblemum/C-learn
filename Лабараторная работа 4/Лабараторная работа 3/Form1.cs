using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабараторная_работа_3
{
    public partial class Form1 : Form
    {  
        public Form1()
        {
            InitializeComponent( );
        }
                 
                private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void label11_Click(object sender, EventArgs e)
        {
          
        }

        private void label8_Click(object sender, EventArgs e)
        {
             
            
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
             
  
             double R, h, S, V, P;
           
            R = Convert.ToDouble(label7.Text);
            h = Convert.ToDouble(label9.Text);
            S = Math.PI * R * R; V = S * h; P = 2 * Math.PI * R * h + 2 * S;
             
            label8.Text = string.Format("{0,10:#.##}", S); label11.Text = string.Format("{0,10:#.##}", P); label10.Text = string.Format("{0,10:#.##}", V);
            MessageBox.Show(string.Format( "Объём цилиндра = {0} \n Поверхность = {1}",label10.Text, label11.Text));
        }

        private void label10_Click(object sender, EventArgs e)
        {

           
            
          
        }
    }
}
