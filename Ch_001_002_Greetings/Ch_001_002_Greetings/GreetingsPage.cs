using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Ch_001_002_Greetings
{
	public class GreetingsPage : ContentPage
	{
		public GreetingsPage ()
		{
            //// Drei Arten von Initialisierung der Contentproperty
            //// Explizit Content setzen. Keine Objektinitialisierungssyntax:
            ////Label label = new Label();
            //label.Text = "Greetings, Xamarin.Forms!";
            //this.Content = label;

      //      // Explizit Content Property setzen. Mit Objektinitialisierungssyntax:
		    //Label label = new Label { Text = "Greetings, Xamarin.Forms!" };
		    //this.Content = label;

            // Direktes Setzen der Content Property ohne explizit ein Objekt zu benennen. Mit Objektinitialisierungssntax
		    this.Content = new Label() { Text = "Greetings, Xamarin.Forms" };
		}
	}
}