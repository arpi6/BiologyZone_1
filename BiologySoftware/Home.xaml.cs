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
	
	public partial class Home : Window
	{
		public Home()
		{
			this.InitializeComponent();
		}

		private void ch1_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			chapter1 page1 = new chapter1();
			page1.Show();
		}

		private void ch3_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			chapter3 page3 = new chapter3();
			page3.Show();
		}

		private void ch11_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			chapter11 page7 = new chapter11();
			page7.Show();
		}

		private void ch6_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			glossary6 six = new glossary6();
			six.Show();
		
		}

		


		
	}
}