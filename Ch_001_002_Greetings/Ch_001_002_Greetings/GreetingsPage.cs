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

            //// Explizit Content Property setzen. Mit Objektinitialisierungssyntax:
		    //Label label = new Label { Text = "Greetings, Xamarin.Forms!" };
		    //this.Content = label;

            // Direktes Setzen der Content Property ohne explizit ein Objekt zu benennen. Mit Objektinitialisierungssntax
		    this.Content = new Label() { Text = "Greetings, Xamarin.Forms" };

            //Padding = new Thickness(0, 20, 0, 0);

            // Mehrere Möglichkeiten das Padding Plattformabhängig zu setzen:

            // Setzen des Paddings nur für iOS mittels Präprozessor Direktiven:
            //#if __IOS__
            //    Padding = new Thickness(0, 20, 0, 0);
            //#endif

            // Device.OnPlatform Methode ist veraltet - siehe Meldung wenn Code ausgeführt wird:
            //Padding = Device.OnPlatform<Thickness>(new Thickness(0, 20, 0, 0), new Thickness(0), new Thickness(0));
            
            // Wie oben nur ohne eckige Klammern <T>, wenn der Compiler den Typ selbst herausfinden kann, anhand der übergebenen Argumente:
            Padding = Device.OnPlatform<Thickness>(new Thickness(0, 20, 0, 0), new Thickness(0), new Thickness(0));


            // Veraltet - siehe Meldung wenn Code ausgeführt wird:
            ////Device.OnPlatform(() =>
            //{
            //    Padding = new Thickness(0, 20, 0, 0);
            //});
        }
    }
}