using System;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;
using System.Collections.Generic;

namespace GradeCalculator{
    class MainWindow : Window{

        protected readonly GradeManager gradeManager; //holds the parent grade manager

        [UI] private Entry NewCategoryEntry = null;
        [UI] private Entry NewPointsEarnedEntry = null;
        [UI] private Entry NewPointsPossibleEntry = null;
        [UI] private Entry NewPercentEntry = null;
        [UI] private Entry NewPercentOfTotalEntry = null;
        [UI] private Entry NewContribToTotal = null;

        [UI] private Box CategoryBox = null;
        [UI] private Grid ValueGrid = null;

        

        public struct PointsUI{
            public Dictionary<int, string> IndexToCatGuid;
            public Entry[] CategoryEntries;
            public Entry[] PointsEarnedEntries;
            public Entry[] PointsPossibleEntries;
            public Entry[] PercentEntries;
            public Entry[] PercentOfTotalEntries;
            public Entry[] ContribToTotalEntries;
            public string Grade;
            public string Percent;

        }

        public void DisplayPointsUI(PointsUI pointsUI){

            for(int x = 1; x < CategoryBox.Children.Length; x++){
                CategoryBox.Remove(CategoryBox.Children[x]);
            }
            foreach(Entry entry in pointsUI.CategoryEntries){
                CategoryBox.Add(entry);
            }

            for(int x = 1; x < CategoryBox.Children.Length; x++){
                CategoryBox.Remove(CategoryBox.Children[x]);
            }
            foreach(Entry entry in pointsUI.CategoryEntries){
                CategoryBox.Add(entry);
            }
        }

        public MainWindow(GradeManager gradeManager) : this(new Builder("MainWindow.glade"), gradeManager) { }

        private MainWindow(Builder builder, GradeManager gradeManager) : base(builder.GetRawOwnedObject("MainWindow")){
            builder.Autoconnect(this);
            this.gradeManager = gradeManager;
            DeleteEvent += Window_DeleteEvent;

        }

        private void Window_DeleteEvent(object sender, DeleteEventArgs a){
            Application.Quit();
        }
    }
}
