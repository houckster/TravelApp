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
        public List<Resources.oEnviroment> Enviroment = new List<Resources.oEnviroment>();
        public List<Resources.oSupply> Supplies = new List<Resources.oSupply>();

        public frmMain()
        {
            InitializeComponent();
        }

        /***********************************************************************************
        *
        *   Team project created to be able to allow users help with packing.  The users can either start with the items they
        *   are first packing, then select from the combobox drop down the enviroment that they are traveling to.  The background
        *   of the application will change depending on the selected backgroud.  Users will also be able to indicate which activities
        *   they will be doing.  From here teh users will finalize their list by clicking on the Show List which is a Summary of 
        *   their trip items.  The application will give some "suggetions" which the user may opt out of if they wish.  Once
        *   Past the summary, they can either print the information or completely exit...or start over.
        *
        *   **Input Validation & Exception handling needed
        *   **Array & Collection needed
        *   **Date Processing and calculations needed
        *   **Output format needed
        *
        *************************************************************************************/     

        private void frmMain_Load(object sender, EventArgs e)
        {
            //on form load start the following methods.  The whole idea is to generate the list to know 
            PopulateListRecco();
            SuppliesListing();
            grbActivities.Visible = false;
            
        }

        private void ClearActivities()
        {
            //creating a foreach loop which will run through the checkboxes in a panel control and
            //clear out any check boxes of the set field.  Wasn't sure how to string this all together.
            
            foreach (Control c in pnlCoastalActivities.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox chk = (CheckBox)c;
                    if (chk.Checked)
                    {
                        chk.Checked = false;
                    }
                }
            }
            foreach (Control c2 in pnlMountainActivities.Controls)
            {
                if (c2 is CheckBox)
                {
                    CheckBox chk = (CheckBox)c2;
                    if (chk.Checked)
                    {
                        chk.Checked = false;
                    }
                }
            }
            foreach (Control c3 in pnlUrbanActivities.Controls)
            {
                if (c3 is CheckBox)
                {
                    CheckBox chk = (CheckBox)c3;
                    if (chk.Checked)
                    {
                        chk.Checked = false;
                    }
                }
            }
        }

        private void SuppliesListing()
        {
            //short-hand way of doing the information located in the PopulateListRecco() information below.  This passes the information
            //into the list right off the bat without the extra lines of code.
            Supplies.Add(new Resources.oSupply("Art Materials"));

            //now create the above line for each supply list.
            Supplies.Add(new Resources.oSupply("Boots"));
            Supplies.Add(new Resources.oSupply("Bug Spray"));
            Supplies.Add(new Resources.oSupply("Cap/Hat"));
            Supplies.Add(new Resources.oSupply("Compass"));
            Supplies.Add(new Resources.oSupply("Concert Tickets"));
            Supplies.Add(new Resources.oSupply("Convention Pass Docs"));
            Supplies.Add(new Resources.oSupply("Dance Shoes"));
            Supplies.Add(new Resources.oSupply("Dress Suit/Clothes"));
            Supplies.Add(new Resources.oSupply("Gloves"));
            Supplies.Add(new Resources.oSupply("Hair Gel"));
            Supplies.Add(new Resources.oSupply("Hairbrush"));
            Supplies.Add(new Resources.oSupply("Jacket"));
            Supplies.Add(new Resources.oSupply("Laptop"));
            Supplies.Add(new Resources.oSupply("Pants"));
            Supplies.Add(new Resources.oSupply("Power Cables"));
            Supplies.Add(new Resources.oSupply("Shirts"));
            Supplies.Add(new Resources.oSupply("Shorts"));
            Supplies.Add(new Resources.oSupply("Socks"));
            Supplies.Add(new Resources.oSupply("Spare Book(s)"));
            Supplies.Add(new Resources.oSupply("Spare Change"));
            Supplies.Add(new Resources.oSupply("Spare Contacts"));
            Supplies.Add(new Resources.oSupply("Spare Glasses"));
            Supplies.Add(new Resources.oSupply("Sports Jersey"));
            Supplies.Add(new Resources.oSupply("Sun Screen"));
            Supplies.Add(new Resources.oSupply("Sweater"));
            Supplies.Add(new Resources.oSupply("Swimming Trunks"));
            Supplies.Add(new Resources.oSupply("Toothpaste & Toothbrush"));
            Supplies.Add(new Resources.oSupply("Underwear/Boxers"));
            Supplies.Add(new Resources.oSupply("Water Bottle"));
            Supplies.Add(new Resources.oSupply("Wind Breaker"));
        }

        private void ReadSelectedSupplies()
        {
         //this is inteded to reach the selected supplies that the user is selecting.
            foreach (string l in lsbSelectionList.SelectedItems)
            {
                return;
            }
        }

        private Resources.oSupply GetSupplyByName(string name)
        {
            //this will run through the list to get a specific item in the supply list.
            foreach (Resources.oSupply s in Supplies)
            {
                if (s.name == name)
                    {
                    return s;
                    }
            }
            return null;
        }

        private void PopulateListRecco()
        {
            //Now we call and populate the information into our arrays.  This format is needed so that we can set what items are
            //recommended for later use.  It's long but it's better than repeat if statments...right?
            Resources.oEnviroment e0 = new Resources.oEnviroment();
            e0.name = "Urban";

            // add the information to the activities dropdown
            Resources.oActivity a0 = new Resources.oActivity();
            //not passing in information for checkYN as checkboxes always default to false anyway.
            a0.name = "Hit The Bar";
            a0.recommended = "Dance Shoes, Spare Change, Hair Gel";

            //set the activity array inside the enviroment.
            e0.Activities[0] = a0;
            //Add the information to the envrioment
            

            //duplicate the above for the rest of the data.
            Resources.oActivity a1 = new Resources.oActivity();
            a1.name = "Convention";
            a1.recommended = "Art Materials, Laptop, Power Cables, Convention Pass Docs";
            e0.Activities[1] = a1;
            

            Resources.oActivity a2 = new Resources.oActivity();
            a2.name = "Go To The Zoo";
            a2.recommended = "Water Bottle, Sun Screen, Bug Spray";
            e0.Activities[2] = a2;
            

            Resources.oActivity a3 = new Resources.oActivity();
            a3.name = "Dine Out - Fancy";
            a3.recommended = "Spare Change, Dress Suit/Clothes, Wind Breaker";
            e0.Activities[3] = a3;
            

            Resources.oActivity a4 = new Resources.oActivity();
            a4.name = "Visit A Museum";
            a4.recommended = "Art Materials, Compass, Spare Glasses";
            e0.Activities[4] = a4;
            

            Resources.oActivity a5 = new Resources.oActivity();
            a5.name = "Sports Event";
            a5.recommended = "Sports Jersey, Spare Glasses, Wind Breaker";
            e0.Activities[5] = a5;
            Enviroment.Add(e0);

            //Now one for Mountains. a0m stands for (a)activity (item 1)0 (m)mountains.
            Resources.oEnviroment e1 = new Resources.oEnviroment();
            e1.name = "Mountains";
            Resources.oActivity a0m = new Resources.oActivity();
            a0m.name = "Hiking";
            a0m.recommended = "Jacket, Compass, Boots";
            e1.Activities[0] = a0m;
            

            Resources.oActivity a1m = new Resources.oActivity();
            a1m.name = "Horse Riding";
            a1m.recommended = "Boots, Sun Screen, Compass";
            e1.Activities[1] = a1m;
            

            Resources.oActivity a2m = new Resources.oActivity();
            a2m.name = "Camping";
            a2m.recommended = "Water Bottle, Swimming Trunks, Spare Book(s)";
            e1.Activities[2] = a2m;
            

            Resources.oActivity a3m = new Resources.oActivity();
            a3m.name = "Treasure Hunting";
            a3m.recommended = "Gloves, Compass, Cap/Hat";
            e1.Activities[3] = a3m;
            

            Resources.oActivity a4m = new Resources.oActivity();
            a4m.name = "Lake Cabin Trip";
            a4m.recommended = "Art Materials, Sun Screen, Swimming Trunks";
            e1.Activities[4] = a4m;
            

            Resources.oActivity a5m = new Resources.oActivity();
            a5m.name = "Mountain Climbing";
            a5m.recommended = "Boots, Cap/Hat, Water Bottle";
            e1.Activities[5] = a5m;
            Enviroment.Add(e1);

            //Now one for Coastal. a0c stands for (a)activity (item 1)0 (m)mountains.
            Resources.oEnviroment e2 = new Resources.oEnviroment();
            e2.name = "Coastal";
            Resources.oActivity a0c = new Resources.oActivity();
            a0c.name = "Resort Stay";
            a0c.recommended = "Toothpaste & Toothbrush, Swimming Trunks, Socks";
            e2.Activities[0] = a0c;
            

            Resources.oActivity a1c = new Resources.oActivity();
            a1c.name = "Amusement Park";
            a1c.recommended = "Cap/Hat, Shorts, Spare Glasses";
            e2.Activities[1] = a1c;
            

            Resources.oActivity a2c = new Resources.oActivity();
            a2c.name = "Surfing";
            a2c.recommended = "Swimming Trunks, Bug Spray, Sun Screen";
            e2.Activities[2] = a2c;
            

            Resources.oActivity a3c = new Resources.oActivity();
            a3c.name = "Visit Wildlife Sanctuary";
            a3c.recommended = "Cap/Hat, Underwear/Boxers, Wind Breaker";
            e2.Activities[3] = a3c;
            

            Resources.oActivity a4c = new Resources.oActivity();
            a4c.name = "Beach Bumming";
            a4c.recommended = "Swimming Trunks, Spare Glasses, Sun Screen";
            e2.Activities[4] = a4c;
            

            Resources.oActivity a5c = new Resources.oActivity();
            a5c.name = "Sailing";
            a5c.recommended = "Sun Screen, Wind Breaker, Shorts";
            e2.Activities[5] = a5c;
            Enviroment.Add(e2);
        }

        private void CallRecommendationList()
        {
            //This will handle the need of updating the summary listbox.
            string currEnviorment = cmbEnviroment.Text;
            Resources.oEnviroment CurrentEnivromentObjt;
            CurrentEnivromentObjt = GetEnviromentByName(currEnviorment);

            ClearRecommendedSupplyList();

            if (currEnviorment == "Urban")
            {
                foreach (Control c3 in pnlUrbanActivities.Controls)
                {
                    if (c3 is CheckBox)
                    {
                        CheckBox chk = (CheckBox)c3;
                        if (chk.Checked)
                        {
                            string recommendations;
                            Resources.oActivity curAct = GetActivityByName(chk.Text, CurrentEnivromentObjt);

                            recommendations = curAct.recommended;

                            foreach (string rec in recommendations.Split(','))
                            {
                                Resources.oSupply mySupply = GetSupplyByName(rec.Trim());
                                mySupply.recommendList = true;
                            }
                        }
                    }
                }
            }

            if (currEnviorment == "Mountains")
            {
                foreach (Control c3 in pnlMountainActivities.Controls)
                {
                    if (c3 is CheckBox)
                    {
                        CheckBox chk = (CheckBox)c3;
                        if (chk.Checked)
                        {
                            string recommendations;
                            Resources.oActivity curAct = GetActivityByName(chk.Text, CurrentEnivromentObjt);

                            recommendations = curAct.recommended;

                            foreach (string rec in recommendations.Split(','))
                            {
                                Resources.oSupply mySupply = GetSupplyByName(rec.Trim());
                                mySupply.recommendList = true;
                            }
                        }
                    }
                }
            }

            if (currEnviorment == "Coastal")
            {
                foreach (Control c3 in pnlCoastalActivities.Controls)
                {
                    if (c3 is CheckBox)
                    {
                        CheckBox chk = (CheckBox)c3;
                        if (chk.Checked)
                        {
                            string recommendations;
                            Resources.oActivity curAct = GetActivityByName(chk.Text, CurrentEnivromentObjt);

                            recommendations = curAct.recommended;

                            foreach (string rec in recommendations.Split(','))
                            {
                                Resources.oSupply mySupply = GetSupplyByName(rec.Trim());
                                mySupply.recommendList = true;
                            }
                        }
                    }
                }
            }

            lsbRecommendation.Clear();
            foreach (Resources.oSupply x in Supplies)
            {
                if (x.recommendList == true)
                {
                    lsbRecommendation.Items.Add(x.name);
                }
            }
            
        }

        private void ClearRecommendedSupplyList()
        {
            foreach (Resources.oSupply s in Supplies)
            {
                s.recommendList = false;
            }
        }

        private Resources.oEnviroment GetEnviromentByName(string name)
        {
            foreach (Resources.oEnviroment z in Enviroment)
            {
                if (z.name == name)
                {
                    return z;
                }
            }
            return null;
        }

        private Resources.oActivity GetActivityByName(string name, Resources.oEnviroment env)
        {
            foreach (Resources.oActivity act in env.Activities)
            {
                if (act.name == name)
                {
                    return act;
                }
            }
            return null;
        }

        private void cmbEnviroment_SelectedValueChanged(object sender, EventArgs e)
        {
            grbActivities.Visible = true;
        }

        private string DateTimeCalculator()
        {
            //figure out the days on the trip -  Will need excpetion handling around thi **************
            DateTime dateArrive = dtpDepature.Value;
            DateTime dateReturn = dtpReturn.Value;
            double dateCount = (dateArrive - dateReturn).TotalDays;
            return "The total time on the trip is " + dateCount.ToString();
        }

        #region Buttons

        // To Do - Exception Handling & Validation: Add controls insuring that users select something else things blow up. ****

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //combo box which handles what will be shown based on the selection.
            object selectedItem = cmbEnviroment.SelectedItem;
            string comboBoxText = selectedItem.ToString();

            //switch that sets depending on if one of the items for the combobox is selected to show a select amount of info.
            switch (comboBoxText)
            {
                //show the coastal info
                case "Coastal":
                    pictureBox1.BackgroundImage = Travel_Group_Project.Properties.Resources.Coastal;
                    pnlCoastalActivities.Enabled = true;
                    pnlMountainActivities.Enabled = false;
                    pnlUrbanActivities.Enabled = false;
                    pnlCoastalActivities.BringToFront();
                    ClearActivities();

                    break;
                //show the Mountains info
                case "Mountains":
                    pictureBox1.BackgroundImage = Travel_Group_Project.Properties.Resources.mountains;
                    pnlCoastalActivities.Enabled = false;
                    pnlMountainActivities.Enabled = true;
                    pnlUrbanActivities.Enabled = false;
                    pnlMountainActivities.BringToFront();
                    ClearActivities();
                    break;

                //show the Mountains info
                case "Urban":
                    pictureBox1.BackgroundImage = Travel_Group_Project.Properties.Resources.urban;
                    pnlCoastalActivities.Enabled = false;
                    pnlMountainActivities.Enabled = false;
                    pnlUrbanActivities.Enabled = true;
                    pnlUrbanActivities.BringToFront();
                    ClearActivities();
                    break;

                default:
                    pictureBox1.BackgroundImage = null;
                    break;
            }
        }

        private void btnAddOne_Click(object sender, EventArgs e)
        {
            //when this button is clicked it will move the selected item or items to the collections box.
            object moveSingleItem = lsbSelectionList.SelectedItem;

            lsbChosenItems.Items.Add(moveSingleItem);
            lsbSelectionList.Items.Remove(lsbSelectionList.SelectedItem);
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            lsbChosenItems.Items.AddRange(lsbSelectionList.Items);
            lsbSelectionList.Items.Clear();
        }

        private void btnRemoveOne_Click(object sender, EventArgs e)
        {
            lsbSelectionList.Items.Add(lsbChosenItems.SelectedItem);
            lsbChosenItems.Items.Remove(lsbChosenItems.SelectedItem);
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            lsbSelectionList.Items.AddRange(lsbChosenItems.Items);
            lsbChosenItems.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the application.
            Close();
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            lsbSelectionList.Items.AddRange(lsbChosenItems.Items);
            lsbChosenItems.Items.Clear();
            ClearActivities();
        }

        private void btnFinalizePack_Click(object sender, EventArgs e)
        {
            //load information into the finalized form.
            frmFinal finalForm = new frmFinal();
            finalForm.listViewDisplay.Add("Don't forget to bring" + DateTimeCalculator());
            finalForm.Show();
        }


        private void checkBoxMtn54_CheckedChanged(object sender, EventArgs e)
        {
            //call the refresh list to start the population of the summary list.
            CallRecommendationList();
        }

        private void checkBoxMtn44_CheckedChanged(object sender, EventArgs e)
        {
            CallRecommendationList();
        }

        private void checkBoxMtn52_CheckedChanged(object sender, EventArgs e)
        {
            CallRecommendationList();
        }

        private void checkBoxMtn41_CheckedChanged(object sender, EventArgs e)
        {
            CallRecommendationList();
        }

        private void checkBoxMtn49_CheckedChanged(object sender, EventArgs e)
        {
            CallRecommendationList();
        }

        private void checkBoxMtn43_CheckedChanged(object sender, EventArgs e)
        {
            CallRecommendationList();
        }

        private void checkBoxCst36_CheckedChanged(object sender, EventArgs e)
        {
            CallRecommendationList();
        }

        private void checkBoxCst35_CheckedChanged(object sender, EventArgs e)
        {
            CallRecommendationList();
        }

        private void checkBoxCst34_CheckedChanged(object sender, EventArgs e)
        {
            CallRecommendationList();
        }

        private void checkBoxCst29_CheckedChanged(object sender, EventArgs e)
        {
            CallRecommendationList();
        }

        private void checkBoxCst19_CheckedChanged(object sender, EventArgs e)
        {
            CallRecommendationList();
        }

        private void checkBoxCst33_CheckedChanged(object sender, EventArgs e)
        {
            CallRecommendationList();
        }

        private void checkBoxUrb1_CheckedChanged(object sender, EventArgs e)
        {
            CallRecommendationList();
        }

        private void checkBoxUrb13_CheckedChanged(object sender, EventArgs e)
        {
            CallRecommendationList();
        }

        private void checkBoxUrb3_CheckedChanged(object sender, EventArgs e)
        {
            CallRecommendationList();
        }

        private void checkBoxUrb17_CheckedChanged(object sender, EventArgs e)
        {
            CallRecommendationList();
        }

        private void checkBoxUrb5_CheckedChanged(object sender, EventArgs e)
        {
            CallRecommendationList();
        }

        private void checkBoxUrb11_CheckedChanged(object sender, EventArgs e)
        {
            CallRecommendationList();
        }

        #endregion

    }
}
