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
            Label label = new Label();
            label.Text = "Greetings, Xamarin.Forms!";
            this.Content = label;
        }
	}
}