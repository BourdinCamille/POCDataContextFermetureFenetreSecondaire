using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace POCDataContextFermetureFenetreSecondaire.ViewModels
{
    public class UserControlVM : ViewModelBase
    {
        private FenetreSecondaireDC _Parent;

        private string _DescriptionUc;

        private bool _IsFromUserControl;

        public UserControlVM(string descriptionUC, bool isFromUserControl)
        {
            _DescriptionUc = descriptionUC;
            _IsFromUserControl = isFromUserControl;
        }

        public FenetreSecondaireDC Parent
        {
            get => _Parent;
            set
            {
                _Parent = value;
                OnPropertyChanged(nameof(Parent));
            }
        }

        public string DescriptionUc
        {
            get => _DescriptionUc;
            set
            {
                _DescriptionUc = value;
                OnPropertyChanged(nameof(DescriptionUc));
            }
        }

        public bool IsFromUserControl
        {
            get => _IsFromUserControl;
            set
            {
                _IsFromUserControl = value;
                OnPropertyChanged(nameof(IsFromUserControl));
            }
        }
    }
}
