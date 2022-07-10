using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Algorithms
{
    public class ATMCashDispenser
    {
        public static Dictionary<int, int> atmBalance = new Dictionary<int, int>
        {
            {2000,1 },{500,2},{200,2},{100,3}
        };

        
        public string Withdraw(int amount)
        {
            int pendingAmount = amount;
            bool isPossible = false;
            Dictionary<int, int> printNotes = new Dictionary<int, int>();

            while(pendingAmount > 0)
            {
                (int note, int noteCount) = CheckNote(pendingAmount);

                if (note != 0)
                {
                    pendingAmount = pendingAmount - (note * noteCount);
                    printNotes.Add(note,noteCount);
                    isPossible = true;
                }
                else
                {
                    isPossible = false;
                    break;
                }
            }   

            if(isPossible)
            {
                return DebitATMBalance(printNotes);
            }
            else
            {
                return "Notes notes not available for entered amount";
            };
        }

        public string DebitATMBalance(Dictionary<int,int> printNotes)
        {
            foreach(KeyValuePair<int, int> note in printNotes)
            {
                atmBalance[note.Key] = atmBalance[note.Key] - note.Value;
            }
            return printNotes.ToString() + atmBalance.ToString();
        }

        public (int,int) CheckNote(int amount)
        {
            int res = amount / 2000;
            if (atmBalance[2000] >= res && res > 0)
            {
                return (2000, res);
            }

            int res1 = amount / 500;
            if (atmBalance[500] >= res1 && res1 > 0)
            {
                return (500, res1);
            }

            int res2 = amount / 200;
            if (atmBalance[200] >= res2 && res2 > 0)
            {
                return (200, res2);
            }

            int res4 = amount / 100;
            if (atmBalance[100] >= res4 && res4 > 0)
            {
                return (100, res4);
            }

            return (0, 0);
        }
    }
}
