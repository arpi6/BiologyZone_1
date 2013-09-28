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
	/// Interaction logic for testyourself1.xaml
	/// </summary>
	public partial class testyourself1 : Window
	{
		public testyourself1()
		{
			this.InitializeComponent();
			
			// Insert code required on object creation below this point.
		}

		private void optiona_Checked(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			answer1.Text = ("Correct");
		}

		private void optionb_Checked(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			answer1.Text = ("Your answer is wrong The Correct answer is A");
		}

		private void optionc_Checked(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			answer1.Text = ("Your answer is wrong The Correct answer is A");
		}

		private void optiond_Checked(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			answer1.Text = ("Your answer is wrong The Correct answer is A");
		}

		private void optiona1_Checked(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			answer2.Text = ("your answer is wrong the correct answer is D");
		}

		private void optionb1_Checked(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			answer2.Text = ("your answer is wrong the correct answer is D");
		}

		private void optionc1_Checked(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			answer2.Text = ("your answer is wrong the correct answer is D");
		}

		private void optiond1_Checked(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			answer2.Text = ("Correct");
		}

		private void optiona2_Checked(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			answer3.Text = ("Your answer is wrong the correct answer is B");
		}

		private void optionb2_Checked(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			answer3.Text = ("Correct");
		}

		
		private void question4_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if (question4.Text == "experimental")
			{
				answer4.Text = ("Correct");
			}
			else
			{
				answer4.Text = ("Your answer is wrong the correct answer is experimental");
			}
		}

		private void optiona3_Checked(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			answer5.Text = ("Your Answer is Wrong the correct answer is C");
		}

		private void optionb3_Checked(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			answer5.Text = ("Your Answer is Wrong the correct answer is C");
		}

		private void optionc3_Checked(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			answer5.Text =("correct");
		}

		private void optiond3_Checked(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			answer5.Text = ("Your Answer is Wrong the correct answer is C");
		}

	}
}