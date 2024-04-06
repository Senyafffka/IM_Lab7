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
            chart2.Series[0].Points.Clear();
            chart3.Series[0].Points.Clear();
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
        const double car_mileage = 0.1, car_warranty = 0.09, equipment = 0.1;
        double advertisement = 0.2;
        int priceK = 1, sales_rateK = 1;
        double profit_general = 0;
        double yminChart1 = 999999999999, ymaxChart1 = 0;
        double yminChart2 = 999999999999, ymaxChart2 = 0;
        double yminChart3 = 999999999999, ymaxChart3 = 0;

        public void check()
        {
            if (yminChart1 > sales_rate)
                yminChart1 = sales_rate - 2;

            if (ymaxChart1 < sales_rate)
                ymaxChart1 = sales_rate + 2;

            if (yminChart2 > profit)
                yminChart2 = profit;

            if (ymaxChart2 < profit)
                ymaxChart2 = profit;

            if (yminChart3 > price)
                yminChart3 = price;

            if (ymaxChart3 < price)
                ymaxChart3 = price;

            if (sales_rate <= 1 || profit <= 100000)
            {
                MessageBox.Show(
                "Вы банкрот",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
                timer1.Stop();
            }

            chart1.ChartAreas[0].AxisY.ScaleView.Position = yminChart1;
            chart1.ChartAreas[0].AxisY.ScaleView.Size = ymaxChart1 - yminChart1;
            chart2.ChartAreas[0].AxisY.ScaleView.Position = yminChart2;
            chart2.ChartAreas[0].AxisY.ScaleView.Size = ymaxChart2 - yminChart2;
            chart3.ChartAreas[0].AxisY.ScaleView.Position = yminChart3;
            chart3.ChartAreas[0].AxisY.ScaleView.Size = ymaxChart3 - yminChart3;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            profit = price * sales_rate;
            profit_general += profit;
            sales_rateK = 1;
            int sales_rate_sup = (int)sales_rate * 10;
            do
            {
                sales_rateK *= 10;
                sales_rate_sup /= 10;
            } while (sales_rate_sup % 10 != 0);

            if (profit > prevProfit)
            {
                advertisement += 1   / sales_rateK;
                price += price * (1 / (sales_rate * sales_rateK) + car_mileage * equipment * advertisement * (rnd.NextDouble() - 0.5));
            }
            else if (profit < prevProfit)
            {
                advertisement -= 1 / sales_rateK;
                price -= price * (1 / (sales_rate * sales_rateK) + car_mileage * equipment * advertisement * (rnd.NextDouble() - 0.5));
            }

            priceK = 1;
            int price_sup = (int)price / 10;
            do
            {
                priceK *= 10;
                price_sup /= 10;
            } while (price_sup % 10 != 0);

            if (price > prevPrice)
                sales_rate -= sales_rate * (priceK * 1.2 / price + car_mileage * car_warranty * advertisement * (rnd.NextDouble() - 0.5));
            else if (price < prevPrice)
                sales_rate += sales_rate * (priceK * 1.2 / price + car_mileage * car_warranty * advertisement * (rnd.NextDouble() - 0.5));

            prevPrice = price;
            prevProfit = profit;

            el_1.Value = (decimal)price;
            el_2.Value = (long)sales_rate;

            check();

            l_profitM.Text = ((long)profit).ToString();
            l_profitG.Text = ((long)profit_general).ToString();

            chart1.Series[0].Points.AddXY(month, (int)sales_rate);
            chart2.Series[0].Points.AddXY(month, profit);
            chart3.Series[0].Points.AddXY(month, price);

            month++;
        }
    }
}
