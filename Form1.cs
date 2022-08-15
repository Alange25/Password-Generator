using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _PasswordGenerator_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            // Clear all the text fields.
            Password.Text = "";
           
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            // The exit button.
            this.Close();
        }

        private void Passwordbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // If the eight checkbox is checked.
                if (eight.Checked == true)
                {
                    // To make sure other check boxes are disabled.
                    ten.Checked = false;
                    sixteen.Checked = false;
                    twenty.Checked = false;

                    // Creating a new password using a random function.
                    const string str = "abcdefghijklmnopqrstuvwxyz!@#$%^&*(){}[]ABCDEFGHIJKLMNOPQRSTUVWXYZ123456789";
                    Random r = new Random();
                    string Eight = new string(str.ToCharArray().OrderBy(s => (r.Next(4) % 2) == 0).ToArray());

                    // Display new password that is eight characters in length.
                    Password.Text = Eight[15].ToString() + Eight[1].ToString() + Eight[10].ToString() + Eight[23].ToString()
                        + Eight[20].ToString() + Eight[5].ToString() + Eight[30].ToString() + Eight[40].ToString();
                }

                // If the sixteen checkbox is checked.
                if (ten.Checked == true)
                {
                    // To make sure other check boxes are disabled.
                    eight.Checked = false;
                    sixteen.Checked = false;
                    twenty.Checked = false;

                    // Creating a new password using a random function.
                    const string str = "abcdefghijklmnopqrstuvwxyz!@#$%^&*(){}[]ABCDEFGHIJKLMNOPQRSTUVWXYZ123456789";
                    Random r = new Random();
                    string Ten = new string(str.ToCharArray().OrderBy(s => (r.Next(4) % 2) == 0).ToArray());

                    // Display new password that is eight characters in length.
                    Password.Text = Ten[15].ToString() + Ten[1].ToString() + Ten[10].ToString() + Ten[23].ToString()
                        + Ten[20].ToString() + Ten[5].ToString() + Ten[30].ToString() + Ten[40].ToString()
                        + Ten[11].ToString() + Ten[13].ToString();
                }


                // If the sixteen checkbox is checked.
                if (sixteen.Checked == true)
                {
                    // To make sure other check boxes are disabled.
                    eight.Checked = false;
                    ten.Checked = false;
                    twenty.Checked = false;

                    // Creating a new password using a random function.
                    const string str = "abcdefghijklmnopqrstuvwxyz!@#$%^&*(){}[]ABCDEFGHIJKLMNOPQRSTUVWXYZ123456789";
                    Random r = new Random();
                    string Sixteen = new string(str.ToCharArray().OrderBy(s => (r.Next(4) % 2) == 0).ToArray());

                    // Display new password that is eight characters in length.
                    Password.Text = Sixteen[15].ToString() + Sixteen[1].ToString() + Sixteen[10].ToString() + Sixteen[23].ToString()
                        + Sixteen[20].ToString() + Sixteen[5].ToString() + Sixteen[30].ToString() + Sixteen[40].ToString() 
                        + Sixteen[11].ToString() + Sixteen[13].ToString() + Sixteen[32].ToString() + Sixteen[33].ToString() + Sixteen[43].ToString()
                        + Sixteen[41].ToString()+ Sixteen[36].ToString() + Sixteen[34].ToString();
                }

                // If the sixteen checkbox is checked.
                if (twenty.Checked == true)
                {
                    // To make sure other check boxes are disabled.
                    eight.Checked = false;
                    ten.Checked = false;
                    sixteen.Checked = false;

                    // Creating a new password using a random function.
                    const string str = "abcdefghijklmnopqrstuvwxyz!@#$%^&*(){}[]ABCDEFGHIJKLMNOPQRSTUVWXYZ123456789";
                    Random r = new Random();
                    string Twenty = new string(str.ToCharArray().OrderBy(s => (r.Next(4) % 2) == 0).ToArray());

                    // Display new password that is eight characters in length.
                    Password.Text = Twenty[15].ToString() + Twenty[1].ToString() + Twenty[10].ToString() + Twenty[23].ToString()
                        + Twenty[20].ToString() + Twenty[5].ToString() + Twenty[30].ToString() + Twenty[40].ToString()
                        + Twenty[11].ToString() + Twenty[13].ToString() + Twenty[32].ToString() + Twenty[33].ToString() + Twenty[43].ToString()
                        + Twenty[41].ToString() + Twenty[36].ToString() + Twenty[34].ToString() + Twenty[25].ToString() + Twenty[21].ToString()
                        + Twenty[8].ToString() + Twenty[6].ToString();
                }
            }

            // In case of error display error message.
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }






        }
    }
}
