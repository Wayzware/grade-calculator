using System;

namespace GradeCalculator{

    /// <summary>
    /// This class forms the base of every category object
    /// </summary>
    public class Category : Entity{
        public Assignment[] Assignments {get; private set;}
        public double worth;

        
    }

}