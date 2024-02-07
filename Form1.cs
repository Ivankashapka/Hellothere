﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Random rand;

        public Form1()
        {
            InitializeComponent();
            rand = new Random();
        }

        private byte[] GetRandomBytes(int n)
        {
            // Fill an array of bytes of length "n" with random numbers.
            var randomBytes = new byte[n];
            rand.NextBytes(randomBytes);
            return randomBytes;
        }

        private void SayHelloButton_Click(object sender, EventArgs e)
        {
           
             // Declare an array of bytes and fill it with random numbers
             byte[] rgb = GetRandomBytes(3);
             textBox1.ForeColor = Color.FromArgb(255, rgb[0], rgb[1], rgb[2]);
           
        }
        private void SayGoodbay_click(object sender, EventArgs e)
        {

            // Declare an array of bytes and fill it with random numbers
            byte[] rgb = GetRandomBytes(3);
            textBox2.ForeColor = Color.FromArgb(255, rgb[0], rgb[1], rgb[2]);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
