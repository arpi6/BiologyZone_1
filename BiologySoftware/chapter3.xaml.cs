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
	/// Interaction logic for chapter3.xaml
	/// </summary>
	public partial class chapter3 : Window
	{
		public chapter3()
		{
			this.InitializeComponent();
			
			// Insert code required on object creation below this point.
		}

		private void btnglossary3_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			glossary3 page4 = new glossary3();
			page4.Show();
		}

		private void btnmodel_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			model3 model = new model3();
			model.Show();
		}

		
	}
}