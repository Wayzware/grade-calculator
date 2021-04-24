
using System.Collections.Generic;

namespace GradeCalculator{

    public class GradeScale{

        public List<GradeScaleItem> Scale = new List<GradeScaleItem>(20);
        public struct GradeScaleItem {
            public double lowerBound;
            public string grade;
        }

        public void AddItem(string grade, double lowerBound){Scale.Add(new GradeScaleItem{lowerBound = lowerBound, grade = grade});}
        public void RemoveItem(string grade, double lowerBound){
            List<GradeScaleItem> newScale = new List<GradeScaleItem>(20);
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