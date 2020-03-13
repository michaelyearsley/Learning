using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    class School
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNum { get; set; }
        private string _TwitterAdress;
        public string TwitterAdress
        {
            get { return _TwitterAdress; }
            set
            {
                if (value.StartsWith("@"))
                    _TwitterAdress = value;
                else
                    throw new Exception("The twitter address must begin with @");
            }
        }
        public School()
        {
            Name = "Hogwarts School";
            PhoneNum = "555-1234";
        }
        public School(string SchoolName, string SchoolPhoneNum)
        {
            Name = SchoolName;
            PhoneNum = SchoolPhoneNum;

        }
        public static float AvegThreeScores(float A, float B, float C) => (A + B + C) / 3;
        public static int AvegThreeScores(int A, int B, int C) => (A + B + C) / 3;
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(Adress);
            sb.Append(City);
            sb.Append(", ");
            sb.Append(State);
            sb.Append("  ");
            sb.Append(Zip);

            return sb.ToString();
        }
    }
}
