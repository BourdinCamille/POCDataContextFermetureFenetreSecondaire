using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCDataContextFermetureFenetreSecondaire.ViewModels
{
    public class UserControlVM : ViewModelBase
    {
        public UserControlVM(string descriptionUC, bool isFromUserControl)
        {
            DescriptionUc = descriptionUC;
            IsFromUserControl = isFromUserControl;
        }

        public FenetreSecondaireDC Parent { get; set; }

        public string DescriptionUc { get; set; }

        public bool IsFromUserControl { get; set; }
    }
}
