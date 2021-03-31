using System;

namespace Equivalence
{
    class Person
    {
        public int PassportID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }

        public override bool Equals(object obj)
        {
            if (obj != null)
            {
                if (obj is Person)
                {
                    var person = (Person)obj;
                    return person.PassportID == PassportID
                        && person.FirstName == FirstName
                        && person.LastName == LastName
                        && person.BirthDate == BirthDate
                        && person.BirthPlace == BirthPlace;
                }
                else return false;

            }
            else return false;
        }
        public override int GetHashCode()
        {
            return (PassportID.GetHashCode() + FirstName.GetHashCode()) % (LastName.GetHashCode() + BirthDate.GetHashCode()+ BirthPlace.GetHashCode());
        }

        //Для того, чтобы при сравнении через оператор == вызвался переопределённый метод Equals
        //необходимо перегрузить операторы отношения == и !=
        public static bool operator ==(Person p1, Person p2)
        {            
            return p1.Equals(p2);
        }

        public static bool operator !=(Person p1, Person p2)
        {
            return !p1.Equals(p2);
        }
    }
}
