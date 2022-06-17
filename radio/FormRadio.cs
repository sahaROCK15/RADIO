using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace radio
{
    public partial class FormRadio : Form
    {
        List<Radio> radioes = new List<Radio>();
        Point LastPoint;
        public FormRadio()
        {
            InitializeComponent();
        }
        private void FormRadio_Load(object sender, EventArgs e)
        {
            using (StreamReader file = File.OpenText("radioes.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                radioes = (List<Radio>)serializer.Deserialize(file, typeof(List<Radio>));
            }
            for (int i = 0; i < radioes.Count; i++)
            {
                MakeButton(flowLayoutPanelRadio, i);
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.URL = radioes[(int)((sender as Button).Tag)].Url;
        }
        public void MakeButton(FlowLayoutPanel panel, int ind)
        {
            Button btn = new Button();
            btn.Height = 70;
            btn.Width = 85;
            btn.BackgroundImageLayout = ImageLayout.Zoom;
            btn.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\..\..\images\" + $"{ind}.jpg");
            btn.Click += new System.EventHandler(button_Click);
            btn.Tag = ind;
            panel.Controls.Add(btn);
        }


        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRollUp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }
    }
}
