using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace libRegEntity
{
    public class PhysicalPerson : IPerson
    {
        private Int32 id;
        public Int32 Id
        {
            get { return id; }
            set { id = value; }
        }
        
        private String name;
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        
        private String email;
        public String Email
        {
            get { return email; }
            set { email = value; }
        }
        private decimal salary;

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        
        private DateTime dateBirth;
        public DateTime DateBirth
        {
            get { return dateBirth; }
            set { dateBirth = value; }
        }
        
        private char genre;
        public char Genre
        {
            get { return genre; }
            set { genre = value; }
        }
        
        public override string ToString()
        {
            return String.Format("{0} --- {1} --- {2} --- {3} --- {4} --- {5}", this.Id, this.Name, this.Email, this.Salary, this.DateBirth, this.Genre);
        }
    }
}
