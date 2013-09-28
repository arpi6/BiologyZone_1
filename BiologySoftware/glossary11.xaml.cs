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
	/// Interaction logic for glossary11.xaml
	/// </summary>
	public partial class glossary11 : Window
	{
		public glossary11()
		{
			this.InitializeComponent();
			
			// Insert code required on object creation below this point.
		}

		private void btnsearch_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			// TODO: Add event handler implementation here.
			if (txtsearch.Text == "genetics")
			{
				txtdefinition.Text = (" Scientific study of heredity. which is how offspring inherits traits from parents.");
			}
			
			if (txtsearch.Text == "trait")
			{
				txtdefinition.Text = (" A Characteristic that can be passed from parent to offspring. (Ex: Eye-Color, Hair-Color, etc..)");
			}
			
			if (txtsearch.Text == "mendel's experiment")
			{
				txtdefinition.Text = (".Father of genetics, proposed principle of inheritanse. \r\n .Used pea plant to experiment because \r\n (a) The clossed-up structure of pea plant makes fertilization controlable. \r\n (b) 7 distinctive trait yield clearly observable results. \r\n (c) rapid reproductive cycle yield results quickly and experiment can be repeated quickly.");
			}
			
			if (txtsearch.Text == "self-fertilization")
			{
				txtdefinition.Text = ("If pollen of a flower fertilize eggs from the same plant's flower. \r\n - Purebred after many generations.");
			}
			
			if (txtsearch.Text == "cross-fertilization")
			{
				txtdefinition.Text = (" If pollen of a flower fertilize eggs from different plant's flower.");
			}
			
			if (txtsearch.Text == "genotype")
			{
				txtdefinition.Text = (" Genetic make-up of an organism (What is inside the organism) Ex: (TT, Tt . tt)");
			}
			
			if (txtsearch.Text == "phenotype")
			{
				txtdefinition.Text = (" The organism's outward expression of the trait (What you see outside) Ex: (Tall, Short)");
			}
			
			if (txtsearch.Text == "homozygous dominant")
			{
				txtdefinition.Text = (" TT");
			}
			
			if (txtsearch.Text == "homozygous recessive")
			{
				txtdefinition.Text = (" tt");
			}
			
			if (txtsearch.Text == "heterozygous")
			{
				txtdefinition.Text = (" Tt");
			}
			
			if (txtsearch.Text == "linked genes")
			{
				txtdefinition.Text = (" Genes that are located on the same chromosome. When genes of 2 traits are located on the same chromosome. The 2 genes travel together to the same sex cell. The are not sorted randomly or independently.");
			}
			
			if (txtsearch.Text == "pleiotropy")
			{
				txtdefinition.Text = (" When 1 gene affect , more than 1 trait. Ex: Sickle-cell disease. 1 gene causes red blood cells to be hint , causing clamping and blocking of blood. resseres: weakness , anemia , damage in brain , spleen and heart.");
			}
			
			if (txtsearch.Text == "incomplete dominance")
			{
				txtdefinition.Text = (" When 2 different alleles for the same trait combineand both alleles are partially expressed. Offspring looks 'in between' Ex: snapdragons = Red * white = pink ");
			}
			
			if (txtsearch.Text == "codominance")
			{
				txtdefinition.Text = (" When 2 different alleles for the same trait. combine and both alleles are fully expressed. offspring has both  characteristics. Ex: Human blood type . A * B = AB");
			}
			
			if (txtsearch.Text == "polygenic trait")
			{
				txtdefinition.Text = (" Traits that are effected by more than one gene Ex. Human eye color \r\n -1 gene for pigment tone \r\n -1 gene for pigment amount \r\n -1 gene for pigment position.");
			}
			
			if (txtsearch.Text == "enviranmental effects")
			{
				txtdefinition.Text = (" When an oragnism internal or external enviranment affect gene expressive. Ex: \r\n Temparature: rabersil or color \r\n Soil acidity: hydrogea flower color \r\n Exercise: human height");
			}
			
			if (txtsearch.Text == "recombination")
			{
				txtdefinition.Text = (" When there are new combinations or alleles in the offspring.");
			}
			
			if (txtsearch.Text == "crossing over")
			{
				txtdefinition.Text = (" When neigboring segments of chromosome from a homologous pair break of and exchange place. Crossing over takes place in Meosis during prophase and metaphase");
			}
			
			if (txtsearch.Text == "multiple alleles")
			{
				txtdefinition.Text = (" Most traits have genes with 3 or more alleles, even though each individual only has 2 of them at a time.");
			}
			
			if (txtsearch.Text == "dominant allele")
			{
				txtdefinition.Text = (" The stronger form of gene.");
			}
			
			if (txtsearch.Text == "recessive allele")
			{
				txtdefinition.Text = (" The weaker for of gene.");
			}
			
			if (txtsearch.Text == "chromosome theory of inheritance")
			{
				txtdefinition.Text = (" Material of inheritance is found in genes. which are carried on chromosomes.");
			}
			
			if (txtsearch.Text == "law of segregation")
			{
				txtdefinition.Text = (" There are 2 genes for every trait, and the pair of genes segrigates during meosis , when sex cells are formed. ");
			}
			
			if (txtsearch.Text == "law of independent assortment")
			{
				txtdefinition.Text = (" There are many traits in organisms . therefore there are many many pairs of genes. Different pair of genes segrigate into sex cells randomly and independently of each other.");
			}
			
			if (txtsearch.Text == "law of dominance")
			{
				txtdefinition.Text = (" There are 2 genes for every trait , and the dominant allele (The stronger form) will cover the recessive allele (The weaker form)");
			}
			
			if (txtsearch.Text == "monohybrid cross")
			{
				txtdefinition.Text = (" punnet squares for 1 trait");
			}
			
			if (txtsearch.Text == "dihybrid cross")
			{
				txtdefinition.Text = (" punnet squares for 2 traits");
			}
			
		}
	}
}