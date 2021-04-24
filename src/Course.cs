using System;
using System.Collections.Generic;

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
        

    }
}