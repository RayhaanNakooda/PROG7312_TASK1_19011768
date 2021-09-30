//19011768

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem19011768
{
    public partial class frmReplaceBooks : Form
    {

        //creating an instance of the random class
        private static Random random = new Random();

        //creating an instance of the random class
        Worker worker = new Worker();

        //<-----------------Code Attribution------------------
        //Code obtained from : https://www.youtube.com/watch?v=lp9cJJUDUsk&ab_channel=SaeThunder

        //variables that will be used to start the timer of the application 
        int timeCs, timeSec, timeMin;
        bool isActive;
        string finalTime;

        //<-------------End of Code Attribution------------->


        public frmReplaceBooks()
        {
            InitializeComponent();


            //disables the button functionality at the opening of the form
            btnUp.Enabled = false;
            btnDown.Enabled = false;
            btnCheckOrder.Enabled = false;


            //<-----------------Code Attribution------------------
            //Code obtained from : https://stackoverflow.com/questions/4321300/c-easiest-way-to-populate-a-listbox-from-a-list


            //for loop that adds the randomly generated call numbers to the list that resides in the worker class
            for (int i = 1; i <= 10; i++)
            {
                worker.callNumberlist.Add(RandomCallNumber());//adding the call numbers to the list
            }

            //for loop that adds the randomly generated call numbers to the listbox of the form
            for (int i = 0; i < worker.callNumberlist.Count; i++)
            {
                lbCallNumbers.Items.Add(worker.callNumberlist.ElementAt(i));//adding the call numbers to the listbox
            }

            //<-------------End of Code Attribution------------->

        }


        private void frmLoad(object sender, EventArgs e)
        {

        }


        public static string RandomCallNumber()
        {

            //<-----------------Code Attribution------------------
            //Code obtained from : https://www.codegrepper.com/code-examples/csharp/random+alphanumeric+generator+dewey+decimal+call+number+c%23
            

            //string of all the alphabets and numbers going from 0-9
            const string alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string numbers = "0123456789";


            //the below three lines joins the strings after they have been randomly created to create a call number 
            return new string(Enumerable.Repeat(numbers, 3).Select(s => s[random.Next(s.Length)]).ToArray()) + "." +
                   new string(Enumerable.Repeat(numbers, 2).Select(s => s[random.Next(s.Length)]).ToArray()) + " " +
                   new string(Enumerable.Repeat(alphabets, 3).Select(s => s[random.Next(s.Length)]).ToArray());


            //<-------------End of Code Attribution------------->

        }


        private void btnCheckOrder_Click(object sender, EventArgs e)
        {

            //boolean value to that disables the timer of the form
            isActive = false;


            //takes the text from the 3 textboxes and adds it to a variable called finalTime which is used to display the final time of the task taken by the user
            finalTime = lblMinutes.Text + "m " + lblSeconds.Text + "s " + lblMilli.Text;

           

            //calls the CheckOrder method from the worker class which has 4 parameters
            worker.CheckOrder(lbCallNumbers, lblSeconds, lblMinutes, finalTime);


            //disables the button functionality once the button btnCheckOrder has been clicked
            btnDown.Enabled = false;
            btnUp.Enabled = false;

            //enables the button functionality once the button btnCheckOrder has been clicked
            btnStart.Enabled = true;
           
        }


        private void btnUp_Click(object sender, EventArgs e)
        {

            //if no item is selected in the listbox an error will be given to the user to select an item
            if (lbCallNumbers.SelectedIndex == -1)
            {
                MessageBox.Show("Select an item to move", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                //gets the index of the selected item in the listbox 
                int newIndex = lbCallNumbers.SelectedIndex - 1;

                if (newIndex < 0)
                {
                    return;
                }

                object selectedItem = lbCallNumbers.SelectedItem;

                lbCallNumbers.Items.Remove(selectedItem); //removes the selected item at the index

                lbCallNumbers.Items.Insert(newIndex,selectedItem); //add the selected item that was removed and places it in the next index

                lbCallNumbers.SetSelected(newIndex, true); //sets the new index of the item

            }

        }


        private void btnDown_Click(object sender, EventArgs e)
        {

            //if no item is selected in the listbox an error will be given to the user to select an item
            if (lbCallNumbers.SelectedIndex == -1)
            {
                MessageBox.Show("Select an item to move", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                //gets the index of the selected item in the listbox 
                int newIndex = lbCallNumbers.SelectedIndex + 1;

                if (newIndex >= lbCallNumbers.Items.Count)
                {
                    return;
                }

                object selectedItem = lbCallNumbers.SelectedItem;

                lbCallNumbers.Items.Remove(selectedItem); //removes the selected item at the index

                lbCallNumbers.Items.Insert(newIndex, selectedItem); //add the selected item that was removed and places it in the next index

                lbCallNumbers.SetSelected(newIndex, true); //sets the new index of the item

            }
        }


        private void btnStart_Click(object sender, EventArgs e)
        {

            //boolean value to that activates the timer of the form
            isActive = true;

            //enables and disables the buttons functionality once the button btnStart has been clicked
            btnUp.Enabled = true;
            btnDown.Enabled = true;
            btnStart.Enabled = false;
            btnCheckOrder.Enabled = true;


        }

        private void frmReplaceBooks_Load(object sender, EventArgs e)
        {
            //sets value of the variables to 0
            timeCs = 0;
            timeSec = 0;
            timeMin = 0;

            //boolean value to that disables the timer of the form
            isActive = false;

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {

            //restarts the form / closes the current instance of the form and opens a new one
            frmReplaceBooks frmRB = new frmReplaceBooks();
            this.Hide();
            frmRB.ShowDialog();
            this.Close();
        }

      

        private void timer1_Tick(object sender, EventArgs e)
        {

            //<-----------------Code Attribution------------------
            //Code obtained from : https://www.youtube.com/watch?v=lp9cJJUDUsk&ab_channel=SaeThunder

            if (isActive)
            {
                timeCs++;

                if (timeCs >= 65)
                {
                    timeSec++;
                    timeCs = 0;

                    if (timeSec >= 60)
                    {
                        timeMin++;
                        timeSec = 0;
                    }
                }
            }

            DrawTime();

            //<-------------End of Code Attribution------------->

        }

        private void DrawTime()
        {
            lblMilli.Text = String.Format("{0:00}", timeCs);
            lblSeconds.Text = String.Format("{0:00}", timeSec);
            lblMinutes.Text = String.Format("{0:00}", timeMin);
        }


        private void pbExit_Click(object sender, EventArgs e)
        {
            //closes the current instance of the form
            frmMainMenu frmRB = new frmMainMenu();
            this.Hide();
            frmRB.ShowDialog();
            this.Close();
        }


    }




}
