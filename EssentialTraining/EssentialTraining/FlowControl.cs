using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialTraining
{
    public class FlowControl
    {
        public string IsYourNameNotBruce(string yourName)
        {
            if (yourName.ToLower() != "bruce")
                return "Can we call you Bruce for sake of simplicity?";
            else
                return "G'day Bruce";
        }
        public string GradeLetter(int score)
        {
            if (score > 90)
                return "A";
            else if (score > 79 && score < 90)
                return "B";
            else if (score > 69 && score < 80)
                return "C";
            else if (score > 59 && score < 70)
                return "D";
            else
                return "F";
        }
        public string PrimaryOrSecondaryCompounr(string color)
        {
            if(color.ToLower() == "red"|| color.ToLower() == "blue" || color.ToLower() == "yellow")
                return "Primary";
            else
                return "secondary";
        }
        public string SecondaryOrPrimary(string color)
        {
            switch(color.ToLower())
            {
                case "red":
                    return "Primary";
                case "blue":
                    return "Primary";
                case "yellow":
                    return "Primary";
                default:
                    return "secondary";
            }
        }
        public string PrimaryOrSecondary(string color)
        {
            var results = string.Empty;
            if (color.ToLower() == "red")
                results = "Primary";
            else if( color.ToLower() == "yellow")
                results = "Primary";
            else if (color.ToLower() == "blue")
                results = "Primary";
            else
                results = "Secondary";
            return results;
        }
        public bool IsYourFavoriteColorYellow(String color)
        {
            return(color.ToLower()== "yellow");
        }
        public bool IsYourFavoriteColorGreen(String color)
        {
            return (color.ToLower() == "green") ? true: false;
        }
        public bool IsYourFavoriteColorRed(String color)
        {
            if (color.ToLower() == "red") return true;  return false;
        }
        public bool IsYourFavoriteColorBlue(String color)
        {
            if (color.ToLower() == "blue")
                return true;
            else
                return false;
        }
    }
}
