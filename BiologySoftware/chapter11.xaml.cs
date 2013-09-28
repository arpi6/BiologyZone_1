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
	/// Interaction logic for chapter11.xaml
	/// </summary>
	public partial class chapter11 : Window
	{
		public chapter11()
		{
			this.InitializeComponent();
			
			// Insert code required on object creation below this point.
		}

		private void btnglossary11_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			glossary11 gl11 = new glossary11();
			gl11.Show();
		}

		private void btnmodel_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			examples11 ez = new examples11();
			ez.Show();
		}
	}
}