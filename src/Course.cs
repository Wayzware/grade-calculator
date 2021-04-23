using System;

namespace GradeCalculator{
    
    public class Course : Entity{

        protected string Instructor {get; set;} = "";

        private Category[] Categories;

        Course(){
            Guid = System.Guid.NewGuid().ToString();
            Categories = new Category[]{};
        }
        Course(string json){

        }

    }
}