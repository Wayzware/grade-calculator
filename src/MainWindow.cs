using System;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;

namespace GradeCalculator{
    class MainWindow : Window{

        private int _counter;

        public MainWindow() : this(new Builder("MainWindow.glade")) { }

        private MainWindow(Builder builder) : base(builder.GetRawOwnedObject("MainWindow")){
            builder.Autoconnect(this);

            DeleteEvent += Window_DeleteEvent;  
        }

        private void Window_DeleteEvent(object sender, DeleteEventArgs a){
            Application.Quit();
        }
    }
}
