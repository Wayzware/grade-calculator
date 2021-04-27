
using System.Collections.Generic;

namespace GradeCalculator{

    public class GradeScale{

        public List<Item> Scale = new List<Item>(20);
        public struct Item {
            public double lowerBound;
            public string grade;
        }

        public void AddItem(string grade, double lowerBound){Scale.Add(new Item{lowerBound = lowerBound, grade = grade});}
        public void RemoveItem(string grade, double lowerBound){
            List<Item> newScale = new List<Item>(20);
            foreach(var item in Scale){
                if(item.grade != grade && item.lowerBound != lowerBound) newScale.Add(item);
            }
            Scale = newScale;
        }

        public string GetGrade(double percent){
            string grade = "None";
            double diff = -999;
            foreach(var item in Scale){
                double curDiff = percent - item.lowerBound;
                if(curDiff >= 0 && curDiff < diff) grade = item.grade;
            }
            return grade;
        }
    }
}