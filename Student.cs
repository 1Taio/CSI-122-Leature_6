using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSI_122_Leature_6
{
    public class Student
    {
        //fields
        public string _firstName;
        private string _lastName;
        double _csiGrade;
        double _genEdGrade;




        //Constructors
        public Student(string firstName, string lastName, double csiGrade, double genEdGrade)
        {
            _firstName = firstName;
            _lastName = lastName;
            _csiGrade = csiGrade;
            _genEdGrade = genEdGrade;
        }


        //Properties
        //They are realted to our fields
        public string FirstName
        {
            //get: allows the user to read the vaule
            //set: allows the user to change the vaule

            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        public string LastName { get => _lastName; set => _lastName = value; }
        public double CsiGrade { get => _csiGrade; set => _csiGrade = value; }
        public double GenEdGrade { get => _genEdGrade; set => _genEdGrade = value; }


        //what is a class method
        // a class method directly interacts with the members of the class
        
        public override string ToString()
        {
            return $"{this._firstName}{this._lastName} - Gen Ed Gradel: {this._csiGrade} -Csi Grade :{this._genEdGrade}";
        }//ToString
    
    
        public double StudentAverage()
        {
            return (_csiGrade + _genEdGrade) / 2;
        }
    
    }




}
