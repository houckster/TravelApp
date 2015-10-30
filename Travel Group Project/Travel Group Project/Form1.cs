using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Travel_Group_Project
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selectedItem = comboBox1.SelectedItem;
            string comboBoxText = selectedItem.ToString();
            switch (comboBoxText)
            {
                case "Coastal":
                    pictureBox1.BackgroundImage = Travel_Group_Project.Properties.Resources.Coastal;
                        break;
                case "Mountains":
                    pictureBox1.BackgroundImage = Travel_Group_Project.Properties.Resources.mountains;
                        break;
                case "Urban":
                    pictureBox1.BackgroundImage = Travel_Group_Project.Properties.Resources.urban;
                    break;
                default:
                    pictureBox1.BackgroundImage = null;
                    break;
            }

        }
    }
}
