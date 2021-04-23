using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
namespace GradeCalculator{

    /// <summary>
    /// This class assists with serializing and deserializing json data files
    /// </summary>
    public static class JsonHelper{

        public static List<Entity> LoadData(string jsonFilePath, bool alerts = true){
            if(!File.Exists(jsonFilePath)) {
                if(alerts) (new MessageBox("Could not access data file " + jsonFilePath + ".", "Error")).Show();
                return new List<Entity>(0);
            }
            return null;
        }

        public static bool SaveData(IEnumerable<Entity> data, string jsonFilePath, bool alerts = true){
            return true;
        }
    }

}