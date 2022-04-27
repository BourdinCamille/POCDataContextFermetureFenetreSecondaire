using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using POCDataContextFermetureFenetreSecondaire.ViewModels;

namespace POCDataContextFermetureFenetreSecondaire.Commands
{
    public class AfficherInfosCommand : ICommand
    {
        private FenetreSecondaireDC _FenetreSecondaireDc;
        public AfficherInfosCommand(FenetreSecondaireDC fenetreSecondaireDc)
        {
            _FenetreSecondaireDc = fenetreSecondaireDc;
        }

        public event System.EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object? parameter)
        {
            return _FenetreSecondaireDc.CanAfficherInfos();
        }

        public void Execute(object? parameter)
        {
            _FenetreSecondaireDc.AfficherInfos();
        }
    }
}
