using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LabCSharp0._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // When pressing the Start button, the program will change the color of the Stop button to green,
        // indicating that it can be pressed to stop something.
        private void start_Click(object sender, EventArgs e)
        {
            stop.BackColor = Color.Green;
            start.BackColor = Color.Red;
        }

        // When the Stop button is pressed, the color state of the buttons will go back to default.
        private void stop_Click(object sender, EventArgs e)
        {
            start.BackColor = Color.Green;
            stop.BackColor = Color.Red;
        }
    }
}
