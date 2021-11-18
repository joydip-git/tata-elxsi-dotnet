using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        //private System.Windows.Forms.Button btnLogin;

        public Form1()
        {
            InitializeComponent();

            //this.btnLogin = new System.Windows.Forms.Button();
            //this.btnLogin.Name = "btnLogin";
            //this.btnLogin.Text = "Login";
            //this.btnLogin.Size = new System.Drawing.Size(200, 50);
            //this.btnLogin.Location = new System.Drawing.Point(100, 200);
            //this.Controls.Add(this.btnLogin);

            //System.EventHandler ev1 = new System.EventHandler(this.OnLoginClicked);
            //System.EventHandler ev2 = new System.EventHandler(this.OnLoginClicked2);
            //System.EventHandler ev = ev1;
            //ev += ev2;
            //this.btnLogin.Click += ev;
            //this.btnLogin.Click += ev1;
            //this.btnLogin.Click += ev2;
            //Clicked--> ev.Invoke(this.btnLogin,new EventArgs());--> OnLoginClicked(this.btnLogin,new EventArgs())
        }

        private void OnLoginClicked(object sender, EventArgs e)
        {
            MessageBox.Show("Logeed In");
        }

        //private void OnLoginClicked(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Logeed In");
        //}
        //private void OnLoginClicked2(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Logeed In 2");
        //}
    }
}
