using System;
using System.Drawing;
using System.Windows.Forms;
using WMPLib;
using System.IO;
namespace HOME_WORK_CONTROL
{
    /// <summary>
    /// the main form
    /// </summary>
    public partial class Form1 : Form
    {
        bool on = true;
        bool toggleLight = true;
        Timer t = new Timer();
        WindowsMediaPlayer Player = new WindowsMediaPlayer();
        public Form1()
        {
            InitializeComponent();
            //it's radio button make it on
            // Turn_off_on_music.Checked = true;
            //turn on the music when program open
            Player.URL = @"Resources/dota_2_01.DOTA2.mp3";
            // Player.controls.play();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Music_On_Of.Text = "MUSIC ON";
            t.Interval = 1000;
            t.Tick += new EventHandler(t_Tick);
            t.Start();
        }
        //this will preform a flashlight effect
        private void t_Tick(object sender, EventArgs e)
        {
            if (toggleLight)
            {
                Music_On_Of.BackColor = Color.LimeGreen;
                toggleLight = false;
            }
            else
            {
                Music_On_Of.BackColor = Color.Transparent;
                toggleLight = true;
            }
        }

        //Exit button
        private void Exit_button_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to exit this program?", "Exit from the program",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                this.Close();
        }
        //choose hero button
        private void New_round_button_Click(object sender, EventArgs e)
        {
            // this.Hide();
            //open another window for showing the data
            try
            {
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            catch (Exception) { }

        }
        //switch the button on_off
        private void Music_On_Of_Click(object sender, EventArgs e)
        {
            if (on)
            {
                Music_On_Of.Text = "MUSIC OFF";
                Player.controls.pause();
                Music_On_Of.BackColor = Color.Transparent;
                t.Stop();
                on = false;

            }
            else
            {
                Music_On_Of.Text = "MUSIC ON";
                Player.controls.play();
                t.Start();
                on = true;
            }
        }

        private void Resumption_button_Click(object sender, EventArgs e)
        {
            //check if xml file exists to download the last saved match.
            if (File.Exists("../../Resources/xmlfile.xml"))
            {
                Form3 form3 = new Form3();
                form3.ShowDialog();
            }
            else
            {
                MessageBox.Show("THERE IS NO SAVED DATA","EMPTY MEMORY",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            }
   
        }

        private void New_round_button_MouseEnter(object sender, EventArgs e)
        {

            New_round_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            New_round_button.ForeColor = System.Drawing.Color.Black;
        }

        private void New_round_button_MouseLeave(object sender, EventArgs e)
        {
            New_round_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            New_round_button.ForeColor = System.Drawing.Color.White;
        }

        private void Resumption_button_MouseEnter(object sender, EventArgs e)
        {
            Resumption_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            Resumption_button.ForeColor = System.Drawing.Color.Black;
        }

        private void Resumption_button_MouseLeave(object sender, EventArgs e)
        {
            Resumption_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            Resumption_button.ForeColor = System.Drawing.Color.White;
        }

        private void Exit_button_MouseEnter(object sender, EventArgs e)
        {
            Exit_button.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            Exit_button.ForeColor = System.Drawing.Color.Red;
        }

        private void Exit_button_MouseLeave(object sender, EventArgs e)
        {
            Exit_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            Exit_button.ForeColor = System.Drawing.Color.White;
        }
    }
}
