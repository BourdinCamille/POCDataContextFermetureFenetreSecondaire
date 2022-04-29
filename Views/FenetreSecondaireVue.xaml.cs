using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace POCDataContextFermetureFenetreSecondaire.Views
{
    /// <summary>
    /// Logique d'interaction pour FenetreSecondaire.xaml
    /// </summary>
    public partial class FenetreSecondaireVue : Window
    {
        public FenetreSecondaireVue()
        {
            InitializeComponent();
        }

        private void FermetureFenetre(object sender, EventArgs e)
        {
            BindingOperations.ClearAllBindings(testUnbind);
            //BindingOperations.ClearBinding(testUnbind, TextBlock.TextProperty);
            this.Close();
            this.DataContext = null;
        }
    }
}
