using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace J27C76
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void ShowDonations_Click(object sender, EventArgs e)
        {
            string fileName = "J27C76_Test_Data.txt";

            if (File.Exists(fileName) == true)
            {
                Form DonationDisplay = new DonationDisplay();
                DonationDisplay.Show();
                    
            }
            else
            {
                MessageBox.Show("No such file" + fileName);
            }

        }
        private void HighestDonationPrint_Click(object sender, EventArgs e)
        {
            string fileName = "J27C76_Test_Data.txt";
            StreamReader donations = new StreamReader(fileName);
            int lineCount = File.ReadLines(fileName).Count();
            string[] names = new string[lineCount];
            int[] amount = new int[lineCount];
            using (donations)
            {
               for (int line = 0; line< lineCount;line++)
                {
                    string content = donations.ReadLine();
                    if (content != null)
                    {
                        char[] dChar = {' ', '\t'};
                        string[] temp = content.Split(dChar);
                        amount[line] = Convert.ToInt32(temp[temp.Length - 1]);
                        if (temp.Length>2)
                        {
                            string tempName ="";
                            for(int field = 0; field <= temp.Length - 2; field++)
                            {
                                tempName += temp[field] + " ";
                            }
                            names[line] = tempName;
                        }
                        else
                        {
                            names[line] = temp[0];
                        }
                    }
                }
                int maxPos = Array.IndexOf(amount, amount.Max());

                string outputFile = "J27C76_Highest_Donation.txt";
                using (StreamWriter output = File.CreateText(outputFile))
                {
                    output.WriteLine("Top donator is: " + names[maxPos] + " with " + amount[maxPos]);
                }
                MessageBox.Show("Top donator is: " + names[maxPos] + " with " + amount[maxPos] + "\n The information has been saved to " + outputFile);

            }

        }

        private void Exit_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
