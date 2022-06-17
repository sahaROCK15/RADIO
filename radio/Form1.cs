using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://radiorecord.hostingradio.ru/phonk96.aacp";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://icecast.vgtrk.cdnvideo.ru/kulturafm_mp3_192kbps";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://pub0201.101.ru/stream/air/aac/64/200?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJrZXkiOiIxNDEzMzNjYmFiNjE3Y2VjZjY4ODM0ZDZlZTE2Nzk2MSIsIklQIjoiOTQuMjMzLjIzNy4zIiwiVUEiOiJNb3ppbGxhXC81LjAgKFdpbmRvd3MgTlQgMTAuMDsgV2luNjQ7IHg2NCkgQXBwbGVXZWJLaXRcLzUzNy4zNiAoS0hUTUwsIGxpa2UgR2Vja28pIENocm9tZVwvOTYuMC40NjY0LjE3NCBZYUJyb3dzZXJcLzIyLjEuNS44MTAgWW93c2VyXC8yLjUgU2FmYXJpXC81MzcuMzYiLCJ1aWRfY2hhbm5lbCI6IjIwMCIsInR5cGVfY2hhbm5lbCI6ImNoYW5uZWwiLCJ0eXBlRGV2aWNlIjoiUEMiLCJCcm93c2VyIjoiQ2hyb21lIiwiQnJvd3NlclZlcnNpb24iOiI5Ni4wLjQ2NjQuMTc0IiwiU3lzdGVtIjoiV2luZG93cyAxMCIsImV4cCI6MTY0ODM0MTQ1N30.cKUw8awiYKlGYqz5lhwmase3K_tYpf-eBzLSmCpC1TE";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://pub0201.101.ru/stream/air/aac/64/100?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJrZXkiOiIxMDEwZjUxZjJhNzA3MzhhNTg5YWJlOThkZmMzOWNiNSIsIklQIjoiOTQuMjMzLjIzNy4zIiwiVUEiOiJNb3ppbGxhXC81LjAgKFdpbmRvd3MgTlQgMTAuMDsgV2luNjQ7IHg2NCkgQXBwbGVXZWJLaXRcLzUzNy4zNiAoS0hUTUwsIGxpa2UgR2Vja28pIENocm9tZVwvOTYuMC40NjY0LjE3NCBZYUJyb3dzZXJcLzIyLjEuNS44MTAgWW93c2VyXC8yLjUgU2FmYXJpXC81MzcuMzYiLCJ1aWRfY2hhbm5lbCI6IjEwMCIsInR5cGVfY2hhbm5lbCI6ImNoYW5uZWwiLCJ0eXBlRGV2aWNlIjoiUEMiLCJCcm93c2VyIjoiQ2hyb21lIiwiQnJvd3NlclZlcnNpb24iOiI5Ni4wLjQ2NjQuMTc0IiwiU3lzdGVtIjoiV2luZG93cyAxMCIsImV4cCI6MTY0ODM0MTMxOX0.C-6awBr6s3dNdrCicjzf0obw--kZwYzxnHxf8liJ6AE";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://str5.pcradio.ru/record_rock-med";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://pub0302.101.ru:8443/stream/personal/aacp/64/881733?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJrZXkiOiIwNGVmZGY2MDdmMzhiODAxMjAzYzY3NDZhMzQ1OTRiYSIsIklQIjoiOTQuMjMzLjIzNy4zIiwiVUEiOiJNb3ppbGxhXC81LjAgKFdpbmRvd3MgTlQgMTAuMDsgV2luNjQ7IHg2NCkgQXBwbGVXZWJLaXRcLzUzNy4zNiAoS0hUTUwsIGxpa2UgR2Vja28pIENocm9tZVwvOTYuMC40NjY0LjE3NCBZYUJyb3dzZXJcLzIyLjEuNS44MTAgWW93c2VyXC8yLjUgU2FmYXJpXC81MzcuMzYiLCJ1aWRfY2hhbm5lbCI6Ijg4MTczMyIsInR5cGVfY2hhbm5lbCI6InBlcnNvbmFsIiwidHlwZURldmljZSI6IlBDIiwiQnJvd3NlciI6IkNocm9tZSIsIkJyb3dzZXJWZXJzaW9uIjoiOTYuMC40NjY0LjE3NCIsIlN5c3RlbSI6IldpbmRvd3MgMTAiLCJleHAiOjE2NDgzNDI1NjF9.9wAX86oh6ckv6qXrlsqHL4doh8pMRTgH6LWPZQpKpmc";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://str5.pcradio.ru/radio_ultra-med";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://online-3.gkvr.ru:8001/muztvradio_original_128.mp3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://pub0101.101.ru:8000/stream/air/aac/64/99";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://pub0101.101.ru:8000/stream/air/aac/64/102";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://node-18.zeno.fm/f174214qvzzuv?zs=F-ZU7gh-T5GdeU7iroGKEw&rj-tok=AAABf8gc6nEA0zS4URJ0isim1w&rj-ttl=5";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://pool.anison.fm/AniSonFM(320)?nocache=0.28788618294615387";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://zaycevfm.cdnvideo.ru/ZaycevFM_kpop_256.mp3";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://cc210ce280e9.sn.mynetname.net:3304/radio_mount";
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
               
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        Point LastPoint;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }
    }
}
