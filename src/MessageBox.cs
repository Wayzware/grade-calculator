using System;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;

namespace GradeCalculator
{
    class MessageBox : Dialog
    {

        [UI] private Label MessageLabel = null;

        public MessageBox(string message, string header = "Grade Calculator") : this(new Builder("MessageBox.glade"), message, header) { }

        private MessageBox(Builder builder, string message, string header) : base(builder.GetRawOwnedObject("MessageBox"))
        {
            builder.Autoconnect(this);
            DefaultResponse = ResponseType.Cancel;
            
            MessageLabel.Text = message;
            this.Title = header;
            Response += Dialog_Response;
        }

        private void Dialog_Response(object o, ResponseArgs args)
        {
            Hide();
        }
    }
}
