using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Act3bis_Chalet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string logement;
        string reservation;

        public MainWindow()
        {
            InitializeComponent();
        }

        //vérifier si un nombre est entier
        private bool EstEntier(string textEnter)
        {
            return int.TryParse(textEnter, out int number);
        }

        //Type de logement
        //récuperer la case cocher
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if(MyRadioButton.IsChecked == true){
                logement = "chalet";
            }else if(MyRadioButton2.IsChecked == true){
                logement = "tente";
            }
            else
            {
                Console.WriteLine("vous n'avez pas cocher un logement valable");
            }
        }

        //caractéristique du logement
        //nbr personne entre 1 et 6 + récp le chiffre rentré 
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!EstEntier(e.Text) && int.Parse(e.Text) !< 1 & int.Parse(e.Text) !> 6){
                e.Handled = true;
            }
            else{
                e.Handled = false;
            }
        }

        private void TextBox_TextInput_2(object sender, TextCompositionEventArgs e)
        {
            
        }

        //date d'arrivée
        //récp la date d'arriver rentré 
        private void TextBox_TextInput_1(object sender, TextCompositionEventArgs e)
        {

        }


        //date de sortie
        //récp la date de fin rentré 
        private void TextBox_TextInput(object sender, TextCompositionEventArgs e)
        {

        }

        //réservation
        //cocher ou non (true or false)
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (checkbox.IsChecked == true)
            {
                reservation = "reserve";
            }
        }

        //boutton "INIT"
        //click = clear toutes les réponses, résultat et case cochés 
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        
        private void Button_Initialized(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        //boutton "CALCULER" 
        //click = affichage du prix + nombre de semaine dans le cadre "RESULTAT" 
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        //boutton "DUREE DE SORTIE" 
        //click = affichage du temps de séjour en semaine 
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        //text "durée en semaine"
        //modifier en mettant la durée exacte entre le debut et la fin du séjour
        private void TextBlock_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }
    }
}
