using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ИМ_Лаб7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            price = (double)el_1.Value;
            sales_rate = (double)el_2.Value;
            chart1.Series[0].Points.AddXY(0, price);
            chart1.Series[1].Points.AddXY(0, sales_rate);
            chart1.Series[2].Points.AddXY(0, bablo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                bt_Start.Text = "Старт";
            }
            else
            {
                timer1.Start();
                bt_Start.Text = "Стоп";
            }
        }

        Random rnd = new Random();
        double price = 0;
        double sales_rate = 0;
        const double car_mileage = 0.09;
        const double car_warranty = 0.02;
        const double equipment = 0.6;
        const double advertisement = 0.8;
        double bablo = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            price = price * (1 + advertisement * (rnd.NextDouble() - 0.5) * car_mileage * equipment);
            sales_rate = sales_rate * (1 + car_warranty * (rnd.NextDouble() - 0.5) * car_mileage * price * advertisement);
            bablo = price * sales_rate;

            chart1.Series[0].Points.AddXY(0, price);
            chart1.Series[1].Points.AddXY(0, sales_rate);
            chart1.Series[2].Points.AddXY(0, bablo);
        }
    }
}
