using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Candidate
    {

        private int id;

        // we use the set and get functions for make the code more secure
        public int Id
        {
            // get the value of the private id to use in program class
            get { return id; }
            // set the value to the private id 
            set { id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // the number of votes that a candiodate have
        private int votes;

        public int Votes
        {
            get { return votes; }
            set { votes = value; }
        }

        // the percent of votes that  a candidtae
        private double percent;

        public double Percent
        {
            get { return percent; }
            set { percent = value; }
        }
        

        // initial the value of the private properties that we have
        public Candidate()
        {
            this.id = 0;
            this.name = "";
            this.votes = 0;
            this.percent = 0.0;
        }


        // make anthor contrcator for passing the values through the class paramters
        public Candidate(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        // this method add vote to the total votes of current candidate
        public void AddVote()
        {
            votes++;
        }

        // this method calculte the percent of a candidate
        // and take the total of all votes as paramater 
        public void ClacPercent(double total)
        {
            percent = votes / total;
        }
        
    }
}
