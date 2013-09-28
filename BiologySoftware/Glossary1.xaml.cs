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
	/// Interaction logic for Glossary1.xaml
	/// </summary>
	public partial class Glossary1 : Window
	{
		public Glossary1()
		{
			this.InitializeComponent();
			
			// Insert code required on object creation below this point.
		}

		private void btnsearch_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if (txtsearch.Text == "science")
			{
				txtdefinition.Text = ("1) Investigation and understand the natural world.\r\n 2)Explain events in the natural world.\r\n 3) use those explanations to make useful predictions");
			}
			
			if (txtsearch.Text == "observation")
			{
				txtdefinition.Text = (" Gathering information using 5 senses.\r\n Example: Plant A is  green and standing up. \r\n plant B is yellow and lying down. ");
			}
			
			if (txtsearch.Text == "quantitative data")
			{
				txtdefinition.Text = (" numbers");
			}
			
			if (txtsearch.Text == "qualitative data")
			{
				txtdefinition.Text = ("description in words");
			}
			
			if (txtsearch.Text == "data")
			{
				txtdefinition.Text  = (" information gathered from observations is called data");
			}
			
			if (txtsearch.Text == "inference")
			{
				txtdefinition.Text = ("A logical interpretation based on observation. (I think ...Because ...) \r\n Example: I Think plant A is healthy Because it is green and standing up. \r\n I Think plant B is dying Because it is yellow and lying down.");
			}
			
			if (txtsearch.Text == "hypothesis")
			{
				txtdefinition.Text = (".A proposed scientific explanation for a set of observations \r\n.Must be proposed in a way that can be tested \r\n.Tested by doing experiment or gathering more data \r\n.May be confirmed or ruled out");
			}
			
			if (txtsearch.Text == "controlled experiment")
			{
				txtdefinition.Text = ("A controlled experiment needs two groups for comparison.\r\n Group A: Control group = Group in which all conditions (variables) are kept same (controlled). \r\n Group 2: Experimental group = The test group in which all conditions(variables) are the same except the one being tested");
			}
			
			if (txtsearch.Text == "spontaneous generation")
			{
				txtdefinition.Text = ("Life could come from non-living matter (Traditional idea) \r\n Example: Maggots spontaneously appeared on meat.");
			}
			
			if (txtsearch.Text == "biogenesis")
			{
				txtdefinition.Text = ("Life come from only life (by Redi) \r\n Example: Maggots come from eggs that flies laid on meat.");
			}
			
			if (txtsearch.Text == "manipulated variable")
			{
				txtdefinition.Text = ("The variable that is changed on purpose. (Independent) \r\n Example in Redi's experiment : +/- cover.");
			}
			
			if (txtsearch.Text == "responding variable")
			{
				txtdefinition.Text = (" The variable that is observed and that changes in response to the manipulated variable (dependent variable) \r\n Example in Redi's Experiment: +/- maggots");
			}
			
			if (txtsearch.Text == "theory")
			{
				txtdefinition.Text = (" A well tested hypothesis that unifies a board range of observations. \r\n Not considered obsolete truth ,may changes as new evidence in uncovered.");
			}
			
			if (txtsearch.Text == "unicellular")
			{
				txtdefinition.Text = (" Made of one cell.");
			}
			
			if (txtsearch.Text == "multicellular")
			{
				txtdefinition.Text = (" Made of many cells.");
			}
			
			if (txtsearch.Text == "sexual reproduction")
			{
				txtdefinition.Text = (" 2 parents, offspring with genetic variation.");
			}
			
			if (txtsearch.Text == "asexual reproduction")
			{
				txtdefinition.Text = (" 1 parent, offspring without genetic variation.");
			}
			
			if (txtsearch.Text == "growth")
			{
				txtdefinition.Text = (" Increase in size.");
			}
			
			if (txtsearch.Text == "development")
			{
				txtdefinition.Text = (" Change in shape, form, or maturity.");
			}
			
			if (txtsearch.Text == "metabolism")
			{
				txtdefinition.Text = (" Combination of chemical reactions through which an organism builds up or breaks down materials.");
			}
			
			if (txtsearch.Text == "stimulus")
			{
				txtdefinition.Text = (" A signal to which an organism responds.");
			}
			
			if (txtsearch.Text == "response")
			{
				txtdefinition.Text = (" a reaction to a stimulus.");
			}
			
			if (txtsearch.Text == "homeostasis")
			{
				txtdefinition.Text = (" Process of keeping conditions inside the body as constant as possible.");
			}
			
			if (txtsearch.Text == "evolution")
			{
				txtdefinition.Text = (" Change over time.");
			}
			
		}
	}
}