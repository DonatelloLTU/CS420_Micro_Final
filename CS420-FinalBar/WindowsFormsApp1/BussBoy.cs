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
    public partial class BussBoy : Form
    {
        public BussBoy()
        {
            InitializeComponent();
        }

        private void textOutput1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textOutput1.Text = string.Empty;
            var client = new WebClient();
            var output = client.DownloadString("https://localhost:32771/api/Source/GetChekcPaid");
            textOutput1.Text += Environment.NewLine + output;
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

            Uri ur = new Uri("https://localhost:32771/api/Source/TableReady");

            DateTime time = DateTime.Now;
            string foo = time.ToUniversalTime()
                         .ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'");
            string count = tableNumberBox.Text;
            string customerName = seatCountBox.Text;
            

            string payload = "{\"tableNumber\":\"" + count + "\",\"seatCount\":" + customerName + ",\"timeStamp\":\"" + foo +  "\"}";

            HttpContent ci = new StringContent(payload, Encoding.UTF8, "application/json");
            var t = Task.Run(() => PostURI(ur, ci));
            t.Wait();

            Console.WriteLine(t.Result);
            Console.ReadLine();
            tableNumberBox.Text = string.Empty;
            seatCountBox.Text = string.Empty;
            
        }

        private void tableNumberBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void seatCountBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Hide();
            Main main = new Main();
            main.Show();
        }
    }
}
