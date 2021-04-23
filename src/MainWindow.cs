using System;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;

namespace GradeCalculator{
    class MainWindow : Window{

        private readonly GradeManager gradeManager;

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
