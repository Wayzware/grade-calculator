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

        /// <summary>
        /// Loads data from the given json into the class's Courses dictionary. 
        /// </summary>
        public bool LoadData(string jsonFilePath){
            JsonDataHolder data;
            try{
                data = JsonSerializer.Deserialize<JsonDataHolder>(jsonFilePath);
            }
            catch{
                (new MessageBox("Could not save the data file to " + jsonFilePath, "Error")).Show();
                return false;
            }
            Course[] courses = data.Courses;
            Courses = new Dictionary<string, Course>();
            foreach(Course course in courses){
                if(!Courses.ContainsKey(course.Guid)) Courses.Add(course.Guid, course);
            }
            return true;
        }

        public bool SaveData(string jsonFilePath){
            List<Course> courses = new List<Course>(Courses.Count);

            foreach(Course course in Courses.Values) courses.Add(course);

            JsonDataHolder data = new JsonDataHolder{
                releaseVersion = 1,
                Courses = courses.ToArray()
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