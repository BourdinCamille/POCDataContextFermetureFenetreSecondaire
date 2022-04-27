using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using POCDataContextFermetureFenetreSecondaire.Commands;
using POCDataContextFermetureFenetreSecondaire.Models;
using POCDataContextFermetureFenetreSecondaire.Views;

namespace POCDataContextFermetureFenetreSecondaire.ViewModels
{
    public class FenetrePrincipaleDC : ViewModelBase
    {
        private FenetrePrincipaleModel _FenetrePrincipaleModel;
        private FenetreSecondaireDC _FenetreSecondaireDc;

        public FenetrePrincipaleDC()
        {
            _FenetrePrincipaleModel = new FenetrePrincipaleModel("Ceci est la fenêtre principale.");
            OuvrirFenetreSecondaireCommand = new OuvrirFenetreSecondaireCommand(this);
        }

        public string Description
        {
            get => _FenetrePrincipaleModel.Description;
            set
            {
                _FenetrePrincipaleModel.Description = value;
                OnPropertyChanged(nameof(Description));
            }
        }

        public ICommand OuvrirFenetreSecondaireCommand { get; private set; }

        public void Ouvrir()
        {
            _FenetreSecondaireDc = new FenetreSecondaireDC();
            FenetreSecondaireVue fenetreSecondaire = new FenetreSecondaireVue();
            fenetreSecondaire.DataContext = _FenetreSecondaireDc;
            fenetreSecondaire.Show();
        }
        public bool CanOuvrir()
        {
            return true;
        }
    }
}
