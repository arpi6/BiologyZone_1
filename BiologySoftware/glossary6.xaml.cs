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
	/// Interaction logic for glossary6.xaml
	/// </summary>
	public partial class glossary6 : Window
	{
		public glossary6()
		{
			this.InitializeComponent();
			
			// Insert code required on object creation below this point.
		}

		private void btnsearch_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if (txtsearch.Text == "renewable resources")
			{
				txtdefinition.Text = ("Can be regenerated , can be repaired Ex: water, wind , energy , trees");
			}
			
			if (txtsearch.Text == "nonrenewable resources")
			{
				txtdefinition.Text = ("Can not be replenished , it can run out Ex: oil, gassoline , fossil, fuel..");
			}
			
			if (txtsearch.Text == "sustainable development")
			{
				txtdefinition.Text = ("A way of using resources without destroying them , or hearting environment. Cutting trees but grow them at the same time.");
			}
			
			if (txtsearch.Text == "global warning")
			{
				txtdefinition.Text = ("Increase in the average tempurature of the biosphere is global warning.");
			}
			
			if (txtsearch.Text == "biological magnification")
			{
				txtdefinition.Text = (" Concentrations of harmful substance increase in organisms at higher trophic levels in a food chain. it effects the entire food web.");
			}
			
			if (txtsearch.Text == "ozon depletion")
			{
				txtdefinition.Text = ("CFC chemical causes the depletion of the ozone layer and it is found in A/C freezer , aerosol cans.");
			}
			
			if (txtsearch.Text == "biodiversity")
			{
				txtdefinition.Text = ("The variety of all organisms in the biosphere. Important because it is one of the Earth's greatest natural resources.");
			}
		}
	}
}