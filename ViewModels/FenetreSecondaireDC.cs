using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using POCDataContextFermetureFenetreSecondaire.Commands;
using POCDataContextFermetureFenetreSecondaire.Models;

namespace POCDataContextFermetureFenetreSecondaire.ViewModels
{
    public class FenetreSecondaireDC : ViewModelBase
    {
        private FenetreSecondaireModel _FenetreSecondaireModel;
        private UserControlVM _UserControlVM;
        private bool _IsFromFenetreSecondaireDC = true;

        public FenetreSecondaireDC()
        {
            _FenetreSecondaireModel = new FenetreSecondaireModel("Ceci est la fenêtre secondaire", 
                                                                    "POC pour l'optimisation des DC lors de la fermeture d'une fenêtre secondaire",
                                                                    DateTime.Today, 
                                                                    "Ensoleillé");
            _UserControlVM = new UserControlVM("Je suis un User Control", true);
            _UserControlVM.Parent = this;
            AfficherInfosCommand = new AfficherInfosCommand(this);
        }

        public UserControlVM UserControlVm
        {
            get => _UserControlVM;
            set
            {
                _UserControlVM = value;
                OnPropertyChanged(nameof(UserControlVm));
            }
        }

        public bool IsFromFenetreSecondaireDC
        {
            get => _IsFromFenetreSecondaireDC;
            set
            {
                _IsFromFenetreSecondaireDC = value;
                OnPropertyChanged(nameof(IsFromFenetreSecondaireDC));
            }
        }

        public string Description
        {
            get => _FenetreSecondaireModel.Description;
            set
            {
                _FenetreSecondaireModel.Description = value;
                OnPropertyChanged(nameof(Description));
            }
        }

        public string Details
        {
            get => _FenetreSecondaireModel.Details;
            set
            {
                _FenetreSecondaireModel.Details = value;
                OnPropertyChanged(nameof(Details));
            }
        }

        public DateTime DateDuJour
        {
            get => _FenetreSecondaireModel.DateDuJour;
            set
            {
                _FenetreSecondaireModel.DateDuJour = value;
                OnPropertyChanged(nameof(DateDuJour));
            }
        }

        public string MeteoDuJour
        {
            get => _FenetreSecondaireModel.MeteoDuJour;
            set
            {
                _FenetreSecondaireModel.MeteoDuJour = value;
                OnPropertyChanged(nameof(MeteoDuJour));
            }
        }

        public string TestConverter { get; set; } = "Cette propriété de FenêtreSecondaireDC est appelée depuis le User Control";

        public ICommand AfficherInfosCommand { get; private set; }

        public void AfficherInfos()
        {
            MessageBox.Show("La fenêtre a été fermée mais il reste une ou des VM fantôme(s)");
        }

        public bool CanAfficherInfos()
        {
            if (!String.IsNullOrEmpty(Description) && !String.IsNullOrEmpty(MeteoDuJour))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
