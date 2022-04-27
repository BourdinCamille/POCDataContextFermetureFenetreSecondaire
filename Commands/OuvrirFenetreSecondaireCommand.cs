using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using POCDataContextFermetureFenetreSecondaire.ViewModels;

namespace POCDataContextFermetureFenetreSecondaire.Commands
{
    class OuvrirFenetreSecondaireCommand : ICommand
    {
        private FenetrePrincipaleDC _FenetrePrincipaleDc;
        public OuvrirFenetreSecondaireCommand(FenetrePrincipaleDC fenetrePrincipaleDc)
        {
            _FenetrePrincipaleDc = fenetrePrincipaleDc;
        }

        public event System.EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object? parameter)
        {
            return _FenetrePrincipaleDc.CanOuvrir();
        }

        public void Execute(object? parameter)
        {
            _FenetrePrincipaleDc.Ouvrir();
        }
    }
}
