using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace WindowsFormsApp1
{
    public partial class Bartender : Form
    {
        public object JToken { get; private set; }

        public Bartender()
        {
            InitializeComponent();
        }

        private void tableNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void getDrink_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = string.Empty;
            var client = new WebClient();
            var output = client.DownloadString("https://localhost:32770/api/Source/GetDrinkOrder");
            textBoxOutput.Text += Environment.NewLine + output;
        }

        private void orderNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void drinkName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            static async Task<string> PostURI(Uri ur, HttpContent ci)
            {
                var response = string.Empty;
                using (var client = new HttpClient())
                {
                    HttpResponseMessage result = await client.PostAsync(ur, ci);
                    if (result.IsSuccessStatusCode)
                    {
                        response = result.StatusCode.ToString();
                    }
                }
                return response;
            }

            Uri ur = new Uri("https://localhost:32770/api/Source/DrinkReady");

            DateTime time = DateTime.Now;
            //string time = "2020-12-03T03:18:08.070Z";

            string foo = time.ToUniversalTime()
                         .ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'");

            string tableN = tableNumber.Text;
            string orderN = orderNum.Text;
            string drinkN = drinkName.Text;



            string payload = "{\"timeStamp\":\"" + foo + "\",\"orderNumber\":" + orderN + ",\"tableNumber\":\"" + tableN + "\",\"drink\":{\"" + drinkN + "\":0}}";

            HttpContent ci = new StringContent(payload, Encoding.UTF8, "application/json");
            var t = Task.Run(() => PostURI(ur, ci));
            t.Wait();

            Console.WriteLine(t.Result);
            Console.ReadLine();
            tableNumber.Text = string.Empty;
            orderNum.Text = string.Empty;
            drinkName.Text = string.Empty;
        }

        private void back_Click(object sender, EventArgs e)
        {
            Hide();
            Main main = new Main();
            main.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
