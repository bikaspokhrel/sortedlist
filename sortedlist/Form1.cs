using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sortedlist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private SortedList<int, string> RunnerList = new SortedList<int, string>();
        private void BtnLoadRunners_Click(object sender, EventArgs e)
        {
            // this is a Key Value pair 
            RunnerList.Add(1, "Howard");
            RunnerList.Add(2,"Jones");
            RunnerList.Add(3,"James");
            RunnerList.Add(4,"Speedy"); //run the method that loads the list into the listbox
            loadLBxRunners();
        }
        private void loadLBxRunners()
        { //clear the listbox 
            lbxRunnerList.Items.Clear();
            //reload the listbox by adding in each entry in the sortedlist 
            foreach (KeyValuePair<int, string> Runner in RunnerList)
            {
                lbxRunnerList.Items.Add(Runner.Key + " " + Runner.Value);
            }
        }

        private void BtnAddRunner_Click(object sender, EventArgs e)
        {
            //add a new member
            int value = 0; //loop through each entry, the last one is the max of the loop 
            foreach (var pair in RunnerList)
            {
                value = pair.Key; //just keep the last entry added
            }
            //loop until there is a spare number. if Runnerlist contains the value then add 1 to it and try again ==true is redundant in the code 
            //We could loop from 0 with a For loop looking for an empty value as well. 
            while (RunnerList.ContainsKey(value))
            {
                //add 1 to value
                value += 1;
            }
            //add the new entry to the list.
            RunnerList.Add(value, txtRunnerName.Text); //empty the text box and reset the focus to it. 
            txtRunnerName.Text = "";
            txtRunnerName.Focus();
            loadLBxRunners();
        }
    }
    }
