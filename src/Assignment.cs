using System;

namespace GradeCalculator{

    /// <summary>
    /// This class forms the base of every assignment object
    /// </summary>
    public class Assignment : Entity{
        public double pointsEarned {get; set;}
        public double pointsPossible {get; set;}
        
    }

}