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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var factory = new ConnectionFactory() { HostName = "host.docker.internal" };
            //using (var connection = factory.CreateConnection())
            //using (var channel = connection.CreateModel())
            //{
            //    channel.QueueDeclare(queue: "newReservation",
            //                         durable: true,
            //                         exclusive: false,
            //                         autoDelete: false,
            //                         arguments: null);

            //    var consumer = new EventingBasicConsumer(channel);
            //    consumer.Received += (model, ea) =>
            //    {
            //        var body = ea.Body.ToArray();
            //        var message = Encoding.UTF8.GetString(body);
            //        textBoxOutput.Text += Environment.NewLine + message;
            //    };
            //    channel.BasicConsume(queue: "newReservation",
            //                         autoAck: true,
            //                         consumer: consumer);

            textBoxOutput.Text = string.Empty;
            var client = new WebClient();
            var output = client.DownloadString("https://localhost:32772/api/Source/GetReservation");
            textBoxOutput.Text += Environment.NewLine + output;
        }

        private void textBoxOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

            Uri ur = new Uri("https://localhost:32772/api/Source/NewReservation");

            DateTime time = DateTime.Now;
            string foo = time.ToUniversalTime()
                         .ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'");
            string count = countBox.Text;
            string customerName = nameBox.Text;
            string phone = phoneBox.Text;

            string payload = "{\"timeStamp\":\"" + foo + "\",\"guestCount\":" + count + ",\"name\":\"" + customerName + "\",\"phoneNumber\":\"" + phone + "\"}";

            HttpContent ci = new StringContent(payload, Encoding.UTF8, "application/json");
            var t = Task.Run(() => PostURI(ur, ci));
            t.Wait();

            Console.WriteLine(t.Result);
            Console.ReadLine();
            countBox.Text = string.Empty;
            nameBox.Text = string.Empty;
            phoneBox.Text = string.Empty;
        }

        private void tableSeated_Click(object sender, EventArgs e)
        {
            static async Task<string> PostURI(Uri uru, HttpContent cii)
            {
                var response = string.Empty;
                using (var client = new HttpClient())
                {
                    HttpResponseMessage result = await client.PostAsync(uru, cii);
                    if (result.IsSuccessStatusCode)
                    {
                        response = result.StatusCode.ToString();
                    }
                }
                return response;
            }

            Uri ur = new Uri("https://localhost:32772/api/Source/TableSeated");

            DateTime time = DateTime.Now;

            string foo = time.ToUniversalTime()
                         .ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'");

            string table = tableNumber.Text;
            string guest = guestNumber.Text;


            string posting = "{\"tableNumber\":\"" + table + "\",\"guests\":" + table + ",\"timeStamp\":\"" + foo + "\"}";

            HttpContent ci = new StringContent(posting, Encoding.UTF8, "application/json");
            var t = Task.Run(() => PostURI(ur, ci));
            t.Wait();

            Console.WriteLine(t.Result);
            Console.ReadLine();
            tableNumber.Text = string.Empty;
            guestNumber.Text = string.Empty;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void phoneBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void countBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void guestCountBox_Click(object sender, EventArgs e)
        {

        }

        private void textBoxOutput1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void guestNumber_TextChanged(object sender, EventArgs e)
        {

        }



        private void getTable_Click(object sender, EventArgs e)
        {
            textBoxOutput1.Text = string.Empty;
            var client = new WebClient();
            var output = client.DownloadString("https://localhost:32772/api/Source/TableReady");
            textBoxOutput1.Text += Environment.NewLine + output;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Hide();
            Main main = new Main();
            main.Show();

        }
    }
}
