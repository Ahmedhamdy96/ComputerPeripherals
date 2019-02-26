using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.IO.Ports; 


namespace SerialPortInterface
{
    public partial class Form1 : Form
    {
        SerialPort port = new SerialPort("COM3", 9600);
        public Form1()
        {
            InitializeComponent();
            port.Open(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = textBox1.Text;
            port.Write(data); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string status = port.ReadExisting();
            label3.Text = status;
        }
    }
}
