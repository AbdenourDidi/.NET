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
    internal class Person : ISerializable
    {

        private static readonly long _serialVersionUID = 1L;

        private readonly String _name;
        private readonly String _firstname;
        private readonly DateTime _birthDate;

        public String Name
        {
            get { return _name; }
        }

        public String Firstname
        {
            get { return _firstname; }
        }

        public String BirthDate
        {
            get { return _birthDate.ToString(); }
        }


        public Person(String _name, String _firstname, DateTime _birthDate)
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

