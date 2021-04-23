using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace GradeCalculator{

    /// <summary>
    /// This class is the main manager for this program
    /// It holds all data 
    /// </summary>
    public class GradeManager{

        public Dictionary<string, Course> Courses {get; protected set;}

        public GradeManager(){
            Courses = new Dictionary<string, Course>();
        }

        public bool LoadData(string jsonFilePath){
            JsonDataHolder data;
            try{
                data = JsonSerializer.Serialize<JsonDataHolder>(jsonFilePath);
            }
            catch{
                (new MessageBox("Could not save the data file to " + jsonFilePath, "Error")).Show();
                return false;
            }
            List<Course> courses = data.Courses;

        }

        public bool SaveData(string jsonFilePath){
            List<Course> courses = new List<Course>(Courses.Count);
            List<Assignment> assignments = new List<Assignment>();
            List<Category> categories = new List<Category>();

            foreach(Course course in Courses.Values){
                courses.Add(course);
                foreach(Category category in course.Categories.Values){
                    categories.Add(category);
                    foreach(Assignment assignment in category.Assignments.Values){
                        assignments.Add(assignment);
                    }
                }
            }

            JsonDataHolder data = new JsonDataHolder{
                Courses = courses.ToArray(),
                Categories = categories.ToArray(),
                Assignments = assignments.ToArray()
            };

            JsonSerializerOptions jOptions = new JsonSerializerOptions{
                WriteIndented = true
            };

            string jsonData = JsonSerializer.Serialize<JsonDataHolder>(data, jOptions);
            try {File.WriteAllText(jsonFilePath, jsonData);}
            catch {
                (new MessageBox("Could not save the data file to " + jsonFilePath, "Error")).Show();
                return false;
            }
            return true;

        }
    }
}