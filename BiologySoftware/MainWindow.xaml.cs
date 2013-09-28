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
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			this.InitializeComponent();
			 PasswordBox password = new PasswordBox();
            password.Password = "icodezone";
            

			// Insert code required on object creation below this point.
		}

		private void btnClose_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			this.Close();
		}

		private void btnlogin_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if (password.Password == "icodezone" && id.Text == "icodezone")
			{
				Home home = new Home();
				home.Show();
			}
			
			else
			{
				MessageBox.Show("You entered invalid UserId or Password. Please try again to login to ICodeZone's DataBase.");
			}
		}
	}
}