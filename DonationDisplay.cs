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
    public partial class DonationDisplay : Form
    {
        public DonationDisplay()
        {
            InitializeComponent();
            string fileName = "J27C76_Test_Data.txt";
            StreamReader donations = new StreamReader(fileName);
            TextBox.Text = donations.ReadToEnd();
        }
        

    }
    
}
