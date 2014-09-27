using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
namespace Testing1
{
    public partial class TestSerial : Form
    {
        SerialPort sp;
        public TestSerial()
        {
            InitializeComponent();
            sp = new SerialPort();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sp.PortName = "COM3";
                sp.BaudRate = 9600;

                sp.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TestSerial());
        }

        private void TestSerial_Load(object sender, EventArgs e)
        {

        }


    }
}