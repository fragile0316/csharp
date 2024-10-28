using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFRegisterStudent
{
    class Course
    {
        private string name = "";
        private bool isRegisteredAlready = false;
        private int credits = 3;

        public Course(string name)
        {
            this.name = name;
        }

        public Course(string name, int credits)
        {
            this.name = name;
            this.credits = credits;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }

        public bool IsRegisteredAlready()
        {
            return this.isRegisteredAlready;
        }

        public void SetToRegistered()
        {
            this.isRegisteredAlready = true;
        }

        public override string ToString()
        {
            return getName();
        }

        public int getCredits()
        {
            return this.credits;
        }
    }
}
