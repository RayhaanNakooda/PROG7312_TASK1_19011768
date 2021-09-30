//19011768

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem19011768
{
    public class Worker
    {

        //List that are created to store the call numbers
        public List<string> callNumberlist = new List<string>();

        public List<string> sortedList = new List<string>();


        //3 Lists that are created that displays messages to the user based on their time of the task 
        List<string> goodScore = new List<string> {"Well done, you are faster than the Flash",
                                                   "You are the speed of light, keep it up :)", 
                                                   "I didn't even blink and you were done, fantastic work",
                                                   "Ferrari got nothing on you, good work",
                                                   "Wow that was exceptionally fast", 
                                                   "They should hire you for the next Usain Bolt, keep it up"};

        List<string> averageScore = new List<string> {"You may not be the fastest out there but you sure aren't the slowest",
                                                      "Just remember Rome wasn't built in a day, keep trying :)",
                                                      "I admire your effort but keep trying for that fast time",
                                                      "Breath in and out and try again for a better time"};

        List<string> slowScore = new List<string> {"You really aren't the fastest on the block, keep trying",
                                                   "Heads up, keep calm and try again :)",
                                                   "You can do much better if you believe in youself",
                                                   "Very slow but remember practice makes perfect"};


     
        public void CheckOrder(ListBox lb, Label lblSeconds, Label lblMinutes, string finalTime)
        {

            //clears the sorted list
            sortedList.Clear();


            sortedList.AddRange(lb.Items.Cast<string>());

            //LINQ query that sorts the call number list
            var sorting = callNumberlist.OrderBy(x => x).ToList<string>();

            //converts the label values to integer variables
            int scoreSeconds = Convert.ToInt32(lblSeconds.Text);
            int scoreMinutes = Convert.ToInt32(lblMinutes.Text);


            //<-----------------Code Attribution------------------
            //Code obtained from : https://stackoverflow.com/questions/1753508/how-could-i-get-a-random-string-from-a-list-and-assign-it-to-a-variable

            Random randNum = new Random();
            int aRandomPos = randNum.Next(goodScore.Count);//Returns a nonnegative random number less than the specified maximum (goodScore.Count).
            int bRandomPos = randNum.Next(averageScore.Count);//Returns a nonnegative random number less than the specified maximum (averageScore.Count).
            int cRandomPos = randNum.Next(slowScore.Count);//Returns a nonnegative random number less than the specified maximum (slowScore.Count).


            string fastTime = goodScore[aRandomPos];
            string averageTime = averageScore[bRandomPos];
            string slowTime = slowScore[cRandomPos];

            //<-------------End of Code Attribution------------->


            //<-----------------Code Attribution------------------
            //Code obtained from : https://stackoverflow.com/questions/9602579/how-to-compare-two-liststring-to-each-other


            if (sortedList.SequenceEqual(sorting))
            {
               
                MessageBox.Show("\t\tWell Done" + Environment.NewLine + "Time taken to complete the task : " + finalTime);

                if (scoreMinutes < 1 && scoreSeconds > 30)
                {
                    MessageBox.Show(averageTime);
                }

                else if (scoreMinutes < 1 && scoreSeconds < 30)
                {                 
                    MessageBox.Show(fastTime);
                }

                else if (scoreMinutes >= 1 && scoreSeconds < 60)
                {
                    MessageBox.Show(slowTime);
                }

            }
            else
            {
                MessageBox.Show("The call numbers are not in the correct order. Click Start and try again.");
            }

            //<-------------End of Code Attribution------------->

        }

    }
}
