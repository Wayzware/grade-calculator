using System;
using System.Collections.Generic;

namespace GradeCalculator{

    /// <summary>
    /// This class forms the base of every category object
    /// </summary>
    public class Category : Entity{
        public Dictionary<string, Assignment> Assignments {get; protected set;}
        public double worth;
        
    }

}