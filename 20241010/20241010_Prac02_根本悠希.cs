using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241010
{
    internal class _20241010_Prac02_根本悠希
    {
        public struct Record
        {
            private int amount;//収入
            private DateTime day;//日付
            public string memo;//メモ

            public int Amount
            {  
                get { return amount; }set { amount = value; } 
            }
            public DateTime Day
            {
                get { return day; }
                set { day = value; }
            }

        };


        static void Main(string[] args)
        { 
            Record record = new Record();
            List<Record> revenue = new List<Record>();//収入の記録
            List<Record> payment = new List<Record>();//支出の記録
            while (true) 
            { 

            }
          
        }
    }
}
