using System;
using System.Collections.Generic;

namespace GradeCalculator{

    /// <summary>
    /// This class forms the base of every category object
    /// </summary>
    public class Category : Entity{
        public Dictionary<string, Assignment> Assignments {get; protected set;}
        public double worth;
        
        public double GetValue(){
            double pointsEarned = GetPointsEarned();
            double pointsPossible = GetPointsPossible();
            return pointsPossible == 0 ? 0 : worth * pointsEarned / pointsPossible;
        }

        public double GetPercent(){
            double pointsEarned = GetPointsEarned();
            double pointsPossible = GetPointsPossible();
            return pointsPossible == 0 ? 0 : pointsEarned / pointsPossible;
        }

        public double GetPointsEarned(){
            double pointsEarned = 0;
            foreach(Assignment assgn in Assignments.Values){
                if(assgn.isActive) pointsEarned += assgn.pointsEarned;
            }
            return pointsEarned;
        }

        public double GetPointsPossible(){
            double pointsPossible = 0;
            foreach(Assignment assgn in Assignments.Values){
                if(assgn.isActive) pointsPossible += assgn.pointsPossible;
            }
            return pointsPossible;
        }
    }

}