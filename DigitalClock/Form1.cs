using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Digital Clock Project
//8/08/2023 5:51 A.M
namespace DigitalClock
{
    public partial class DigitalClock : Form
    {
        public DigitalClock()
        {
           //Takes the border from the button
            InitializeComponent();
            RedButton.FlatStyle = FlatStyle.Flat;
            OrangeButton.FlatStyle = FlatStyle.Flat;
            YellowButton.FlatStyle = FlatStyle.Flat;
            GreenButton.FlatStyle = FlatStyle.Flat;
            BlueButton.FlatStyle = FlatStyle.Flat;
        }

        private void LoadingLabel_Click(object sender, EventArgs e)
        {

        }

        private void DigitalClock_Load(object sender, EventArgs e)
        {
            //Timer starts when program is launched
            ClockTimer.Start();
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            //Displays the info of the current Time 
            LoadingLabel.Text = DateTime.Now.ToString("hh:mm:ss");
            LoadingLabel.Text = DateTime.Now.ToString("T");
        }

        private void BlueButton_Click(object sender, EventArgs e)
        {
            //This changes the Font Color to Blue
            LoadingLabel.ForeColor = Color.Blue;
        }

        private void GreenButton_Click(object sender, EventArgs e)
        {
            //This changes the Font Color to Green
            LoadingLabel.ForeColor = Color.Green;
        }

        private void YellowButton_Click(object sender, EventArgs e)
        {
            //This changes the Font Color to Yellow
            LoadingLabel.ForeColor = Color.Yellow;
        }

        private void OrangeButton_Click(object sender, EventArgs e)
        {
            //This changes the Font Color to Orange
            LoadingLabel.ForeColor = Color.Orange;
        }

        private void RedButton_Click(object sender, EventArgs e)
        {
           //This changes the Font Color to Red
            LoadingLabel.ForeColor = Color.Red;
        }

        private void StyleButton1_Click(object sender, EventArgs e)
        {

            //This changes the Font to Impact
            LoadingLabel.Font = new Font("Impact",90, FontStyle.Regular );
        }

        private void StyleButton2_Click(object sender, EventArgs e)
        {
            //This changes the Font to Consolas
            LoadingLabel.Font = new Font("Consolas", 90, FontStyle.Regular);
        }

        private void StyleButton3_Click(object sender, EventArgs e)
        {
           //This changes the Font to Sitka Display
            LoadingLabel.Font = new Font("Sitka Display", 90, FontStyle.Regular);
        }
    }
}
