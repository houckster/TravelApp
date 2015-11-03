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
    public partial class frmFinal : Form
    {
        //passing information in from the original list to the finalized listing.
        public List<string> listViewDisplay = new List<string>();

        public frmFinal()
        {
            InitializeComponent();
        }

        private void frmFinal_Load(object sender, EventArgs e)
        {
            foreach (string x in listViewDisplay)
            {
               
                    lsbFinalReport.Items.Add(x);
                
            }
        }
        
    }
}
