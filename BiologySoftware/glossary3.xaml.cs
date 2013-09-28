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
	/// Interaction logic for glossary3.xaml
	/// </summary>
	public partial class glossary3 : Window
	{
		public glossary3()
		{
			this.InitializeComponent();
			
			// Insert code required on object creation below this point.
		}

		private void btnsearch3_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if (txtsearch3.Text == "ecology")
			{
				txtdefinition3.Text = ("Study of how organisms interact with each other and with their environment.");
			}
			
			if (txtsearch3.Text == "autotroph")
			{
				txtdefinition3.Text = ("Autotrophs use energy from the environment for make food. Also called producers. \r\n Ex: Plants, some algae, some bacteria.");
			}
			
			if (txtsearch3.Text == "producer")
			{
				txtdefinition3.Text = ("Other name for Autotrophs.");
			}
			
			if (txtsearch3.Text == "photosynthesis")
			{
				txtdefinition3.Text = ("Process in which autotrophs use light energy to convert carbon dioxide and water in oxygen and food. Done by plants and algae");
			}
			
			if (txtsearch3.Text == "chemosynthesis")
			{
				txtdefinition3.Text = ("Process in which autotrophs use chemicals to make food , done by bacteria.");
			}
			
			if (txtsearch3.Text == "heterotrophs")
			{
				txtdefinition3.Text = ("Organisms that rely on the other organisms for their energy and food supply. Also called consumers. \r\n Ex: Animals, fungi, some algae, some bacteria.");
			}
			
			if (txtsearch3.Text == "consumer")
			{
				txtdefinition3.Text = ("Other name for Heterotrophs");
			}
			
			if (txtsearch3.Text == "herbivore")
			{
				txtdefinition3.Text = ("Type of Heterotrophs , which eat plants. \r\n Ex: Caws, Horses....");
			}
			
			if (txtsearch3.Text == "carnivore")
			{
				txtdefinition3.Text = ("Type of Heterotrophs which eat animals \r\n Ex: Lions, Sharks,........");
			}
			
			if (txtsearch3.Text == "omnivore")
			{
				txtdefinition3.Text = ("Type of Heterotrophs which eat both plants and animals \r\n Ex: Birds, Humans...");
			}
			
			if (txtsearch3.Text == "trophic level")
			{
				txtdefinition3.Text = ("Each step on food chain . Usually no more than 3 or 4.");
			}
			
			if (txtsearch3.Text == "food chain")
			{
				txtdefinition3.Text = ("A series of steps in which organisms transfer energy by eating and being eaten.");
			}
			
			if (txtsearch3.Text == "food web")
			{
				txtdefinition3.Text = ("Shows how food chains are interconnected. More realistic in nature because animals eat more than 1 type of food.");
			}
			
			if (txtsearch3.Text == "ecological pyramid")
			{
				txtdefinition3.Text = ("A diagram that shows the relative amount of energy or matter contained within each trophic level in a food chain or food web.");
			}
			
			if (txtsearch3.Text == "10 % law")
			{
				txtdefinition3.Text = ("Only about 10% of energy available within each trophic level is transfered to organisms at the next trophic level.");
			}
			
			if (txtsearch3.Text == "detritivore")
			{
				txtdefinition3.Text = ("Feed on plant and animal remains and other dead matter. (leftover) \r\n Ex: vultures, ants...");
			}
			
			if (txtsearch3.Text == "decomposer")
			{
				txtdefinition3.Text = ("Break down and recycle organic matter. \r\n Ex: Bacteria, and fungi.");
			}
			
			
			
		}
	}
}