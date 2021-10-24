using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {
        public Form1() {
            Random rnd = new Random();
            InitializeComponent();
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width+50, Screen.PrimaryScreen.Bounds.Height+100);
            this.Location = new Point(0, 0);
            pictureBox1.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Image = Image.FromFile($"Images\\{rnd.Next(1, 7)}.jpg");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(NewWindow));
            t.Start();
        }

        public static void NewWindow() {   
            Application.Run(new Form1());
        }

    }
}
