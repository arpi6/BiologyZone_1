using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BiologySoftware
{
	/// <summary>
	/// Interaction logic for chapter1.xaml
	/// </summary>
	public partial class chapter1 : Window
	{
		public chapter1()
		{
			this.InitializeComponent();
			
			// Insert code required on object creation below this point.
		}

		private void btnnote_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			note1 note = new note1();
			note.Show();
		}

		private void btnglossary_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			Glossary1 glossary = new Glossary1();
			glossary.Show();
		}

		private void btntest_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			testyourself1 test = new testyourself1();
			test.Show();
		}

		

		
	}
}