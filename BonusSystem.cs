/** 
 * Author1:  Philip Rönnmark 990513-4392 (phrinn-1@student.ltu.se) 
 * Course:   L0002B
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales
{
    class BonusSystem
    {
        private Person[] people = new Person[300];



        //Arrays for storing people in different bonus levels
        private Person[] peopleLevel1 = new Person[300];
        private Person[] peopleLevel2 = new Person[300];
        private Person[] peopleLevel3 = new Person[300];
        private Person[] peopleLevel4 = new Person[300];

        //Counters for populating bonus level arrays
        private int lvl1 = 0;
        private int lvl2 = 0;
        private int lvl3 = 0;
        private int lvl4 = 0;


        //Counts amount people added
        private int numOfPeople = 0;

        /// <summary>
        /// Adds person to list and sorts the list and puts the person in the correct bonus level
        /// </summary>
        /// <param name="p"></param>
        public void AddPerson(Person p)
        {
            people[numOfPeople] = p;
            bubbleSort();
            sortLevels(p);
        }

        /// <summary>
        /// Bubble sort algorithm for sorting people based on their sales
        /// </summary>
        private void bubbleSort()
        {
            bool sorted = false;
            Person temp;
            while (!sorted)
            {
                sorted = true;
                for (int i = 0; i < numOfPeople - 1; i++)
                {
                    if (people[i].Sales > people[i + 1].Sales)
                    {
                        temp = people[i];
                        people[i] = people[i + 1];
                        people[i + 1] = temp;
                        sorted = false;
                    }
                }
            }
        }

        /// <summary>
        /// Displays people in the correct Bonus level and aggregate value for how many in that bonus level
        /// </summary>
        /// <returns></returns>
        public string display()
        {

            string display = "Namn".PadRight(15) + "Personnummer".PadRight(15) +  "Distrikt".PadRight(15) + "Antals sålda artiklar";
            if (lvl1 > 0) { 
            for(int i = 0; i < lvl1; i++)
            {
                display += "\n" + peopleLevel1[i].ToString();
            }
            }
            display += "\n" + lvl1 + " Har uppnåt nivå 1: Under 50 artiklar" + "\n";
            if (lvl2 > 0)
            {
                for (int i = 0; i < lvl2; i++)
                {
                    display += "\n" + peopleLevel2[i].ToString();
                }
            }

            display += "\n" + lvl2 + " Har uppnåt nivå 2: 50-99 artiklar" + "\n";

            if (lvl3 > 0)
            {
                for (int i = 0; i < lvl3; i++)
                {
                    display += "\n" + peopleLevel3[i].ToString();
                }
            }

            display += "\n" + lvl3 + " Har uppnåt nivå 3: 100-199" + "\n";

            if (lvl4 > 0)
            {
                for (int i = 0; i < lvl4; i++)
                {
                    display += "\n" + peopleLevel4[i].ToString();
                }
            }

            display += "\n" + lvl4 + " Har uppnåt nivå 4: Över 199" + "\n";

            return display;




        }


        /// <summary>
        /// The level arrays are not being overwritten, needs to be cleared before.
        /// </summary>
        private void sortLevels(Person p)
        {

            int sales = p.Sales;

                
                if(sales < 50 )
                {
                    peopleLevel1[lvl1] = people[numOfPeople];
                    lvl1++;
                } 

                else if (sales < 99)
                {
                    peopleLevel2[lvl2] = people[numOfPeople];
                    lvl2++;
                } 

                else if (sales < 199 )
                {
                    peopleLevel3[lvl3] = people[numOfPeople];
                    lvl3++;
                } 

                else if(sales > 199 )
                {
                    peopleLevel4[lvl4] = people[numOfPeople];
                    lvl4++;
                }
                    

        }



    }
}
