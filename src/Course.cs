using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeCalculator{
    
    public class Course : Entity{

        protected string Instructor {get; set;} = "";
        protected GradeScale GradingScale;

        public Dictionary<string, Category> Categories {get; protected set;}

        public Course(){
            Guid = System.Guid.NewGuid().ToString();
            Categories = new Dictionary<string, Category>();
            GradingScale = new GradeScale();
        }

        public double GetGradePercent() => Categories.Values.Aggregate(0.0, (total, next) => total += next.isActive ? next.GetGradePercent() : 0.0);
        public string GetGradeLetter() => GradingScale.GetGrade(GetGradePercent());
        

    }
}