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
using System.Windows.Shapes;
using POCDataContextFermetureFenetreSecondaire.ViewModels;

namespace POCDataContextFermetureFenetreSecondaire.Views
{
    /// <summary>
    /// Logique d'interaction pour FenetrePrincipale.xaml
    /// </summary>
    public partial class FenetrePrincipaleVue : Window
    {
        public FenetrePrincipaleVue()
        {
            InitializeComponent();
            DataContext = new FenetrePrincipaleDC();
        }
    }
}
