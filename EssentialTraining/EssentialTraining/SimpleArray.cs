using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialTraining
{
    public class SimpleArray
    {
        public string[] GrceryList;
        public SimpleArray()
        {
            GrceryList = new string[4] { "Bread", "Milk", "Eggs", "Cheese" };
        }
        public override string ToString()
        {
            return "There are " + GrceryList.Length + " and they are:  " + GrceryList.ToString();
        }
    }
}
