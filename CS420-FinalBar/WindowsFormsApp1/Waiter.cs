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
    public partial class Waiter : Form
    {
        public Waiter()
        {
            InitializeComponent();
        }

        private void textBoxOutput3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxOutput3.Text = string.Empty;
            var client = new WebClient();
            var output = client.DownloadString("https://localhost:32774/api/Source/DrinkReady");
            textBoxOutput3.Text += Environment.NewLine + output;
        }

        private void textBoxOutput5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxOutput5.Text = string.Empty;
            var client = new WebClient();
            var output = client.DownloadString("https://localhost:32774/api/Source/FoodReady");
            textBoxOutput5.Text += Environment.NewLine + output;
        }

        private void textOutputBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textOutputBox6.Text = string.Empty;
            var client = new WebClient();
            var output = client.DownloadString("https://localhost:32774/api/Source/ReadyToPay");
            textOutputBox6.Text += Environment.NewLine + output;
        }

        private void textOutput9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textOutput9.Text = string.Empty;
            var client = new WebClient();
            var output = client.DownloadString("https://localhost:32774/api/Source/TableSeated");
            textOutput9.Text += Environment.NewLine + output;
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
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

            Uri ur = new Uri("https://localhost:32774/api/Source/OrderDrinks");

            DateTime time = DateTime.Now;
            string foo = time.ToUniversalTime()
                         .ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'");
            string count = nameBox.Text;
            string customerName = textBox1.Text;
            string phone = textBox2.Text;

            string payload = "{\"orderNumber\":\"" + count + "\",\"name\":" + customerName + ",\"tableNumber\":\"" + phone + "\",\"tableNumber\":\"" + phone + "\",\"timeStamp\":\"" + foo + "\"}";

            HttpContent ci = new StringContent(payload, Encoding.UTF8, "application/json");
            var t = Task.Run(() => PostURI(ur, ci));
            t.Wait();

            Console.WriteLine(t.Result);
            Console.ReadLine();
            nameBox.Text = string.Empty;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
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

            Uri ur = new Uri("https://localhost:32774/api/Source/OrderFood");

            DateTime time = DateTime.Now;
            string foo = time.ToUniversalTime()
                         .ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'");
            string count = textBox3.Text;
            string customerName = textBox4.Text;
            string phone = textBox5.Text;

            string payload = "{\"orderNumber\":\"" + count + "\",\"name\":" + customerName + ",\"tableNumber\":\"" + phone + "\",\"tableNumber\":\"" + phone + "\",\"timeStamp\":\"" + foo + "\"}";

            HttpContent ci = new StringContent(payload, Encoding.UTF8, "application/json");
            var t = Task.Run(() => PostURI(ur, ci));
            t.Wait();

            Console.WriteLine(t.Result);
            Console.ReadLine();
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
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

            Uri ur = new Uri("https://localhost:32774/api/Source/CheckPaid");

            DateTime time = DateTime.Now;
            string foo = time.ToUniversalTime()
                         .ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'");
            string count = textBox6.Text;


            string payload = "{\"tableNumber\":\"" + count + "\",\"paid\":true," + "\",\"timeStamp\":\"" + foo + "\"}";

            HttpContent ci = new StringContent(payload, Encoding.UTF8, "application/json");
            var t = Task.Run(() => PostURI(ur, ci));
            t.Wait();

            Console.WriteLine(t.Result);
            Console.ReadLine();
            textBox6.Text = string.Empty;

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Hide();
            Main main = new Main();
            main.Show();
        }
    }
}
