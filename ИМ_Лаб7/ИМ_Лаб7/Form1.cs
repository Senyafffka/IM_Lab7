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

            chart2.Series[0].Points.Clear();
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();

            chart2.Series[0].Points.AddXY(0, sales_rate);
            chart1.Series[0].Points.AddXY(0, price);
            chart1.Series[1].Points.AddXY(0, profit);
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
                price = (double)el_1.Value;
                sales_rate = (double)el_2.Value;

                timer1.Start();
                bt_Start.Text = "Стоп";
            }
        }

        Random rnd = new Random();
        int month = 0;
        double price = 0, profit = 0, sales_rate = 0;
        double prevProfit = 0, prevPrice = 0;
        double car_mileage = 0.1, car_warranty = 0.09, equipment = 0.1, advertisement = 0.2;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (profit > prevProfit)
                price -= car_mileage * equipment * advertisement * sales_rate / price;
            else
                price += car_mileage * equipment * advertisement * sales_rate / price;
            sales_rate = car_mileage * car_warranty * advertisement * sales_rate / price;

            el_1.Value = (decimal)price;
            el_2.Value = (int)sales_rate;

            chart2.Series[0].Points.AddXY(month, (int)sales_rate);
            chart1.Series[0].Points.AddXY(month, price);
            chart1.Series[1].Points.AddXY(month, profit);

            month++;
        }
    }
}
