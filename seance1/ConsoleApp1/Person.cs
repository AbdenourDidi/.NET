using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Data;

namespace ConsoleApp1
{
    [Serializable]
    internal class Person 
    {


        private readonly string _name;
        private readonly string _firstname;
        private readonly DateTime _birthDate;

        public virtual string Name
        {
            get { return _name; }
        }

        public string Firstname
        {
            get { return _firstname; }
        }

        public string BirthDate
        {
            get { return _birthDate.ToString(); }
        }


        public Person(string _name, string _firstname, DateTime _birthDate)
        {
            this._name = _name;
            this._firstname = _firstname;
            this._birthDate = _birthDate;
        }

        
        public override string ToString()
        {
            return "Person [name = " + _name + ", firstname = " + _firstname + ", birthDate =  " + BirthDate + "]";
        }


    }

}

