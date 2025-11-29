using System;
using System.Globalization;

class Student
{ 

    public string Name{ get; set; }
    private int average;

    public Student(string studentName, int studentAverage)
    {
        Name = studentName;
        this.average = studentAverage;
    }

    public int Average
    {
        get { return average; }
        set 
        { 
            if (average >= 0 && average <= 100)
            {
                average = value;
            }

        }
    }
    public string LetterGarde
    {
         get
            {
            string letterGarde = "F";

            if (average >= 90)
            {
                letterGarde = "A";
            }
            else if (average >= 80)
            {
                letterGarde = "B";
            }
            else if (average >= 70)
            {
                letterGarde = "C";
            }
            else if (average >= 60)
            {
                letterGarde = "D";
            }


            return letterGarde;
            }
    }

}
