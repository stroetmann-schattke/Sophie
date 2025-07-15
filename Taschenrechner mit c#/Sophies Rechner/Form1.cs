using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sophies_Rechner
{
    public partial class Form1 : Form
    {
        double ersterWert = 0;
        string operation = "";
        bool operationGedrückt = false;

        public Form1()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text  += "1";
            textBox1.Focus();
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            textBox1.Focus();
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            textBox1.Focus();
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            textBox1.Focus();
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
            textBox1.Focus();
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
            textBox1.Focus();
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            textBox1.Focus();
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
            textBox1.Focus();
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
            textBox1.Focus();
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
            textBox1.Focus();
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
            textBox1.Focus();
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
            textBox1.Focus();
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
            textBox1.Focus();
            textBox1.SelectionStart=textBox1.Text.Length;
            textBox1.SelectionLength = 0;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            string Eingabe = textBox1.Text.ToString();
            try
            {
                var Ergebnis = new DataTable().Compute(Eingabe, null);
                textBox1.Text = Ergebnis.ToString();
            }
           catch {
                label1.Text = "Fehler";
                
            }
          
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text +=  ",";
            selecttextbox();
        }

        private void selecttextbox()
        {
            textBox1.Focus();
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
            textBox1.Focus();
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += "√";
            textBox1.Focus();
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;
        }

        //private void Operator_Click(object sender, EventArgs e) {
        //    System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
        //    ersterWert = Convert.ToDouble(textBox1.Text);
        //    operation = btn.Text;
        //    operationGedrückt = true;
        //}

        //private void buttonGleich_Click(object sender, EventArgs e) {
        //     double zweiterWert = Convert.ToDouble(textBox1.Text);
        //     double ergebnis = 0; 

        //     switch (operation) {
        //         case "+":
        //             ergebnis = ersterWert + zweiterWert;
        //             break;
        //         case "-":
        //             ergebnis = ersterWert - zweiterWert;
        //             break;
        //         case "*": 
        //             ergebnis = ersterWert * zweiterWert;
        //             break;
        //         case "/":
        //             ergebnis = ersterWert / zweiterWert;
        //             break;
        //     }

        // }
    }
}
