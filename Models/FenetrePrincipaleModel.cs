using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCDataContextFermetureFenetreSecondaire.Models
{
    public class FenetrePrincipaleModel
    {
        public FenetrePrincipaleModel()
        {}

        public FenetrePrincipaleModel(string description)
        {
            Description = description;
        }

        public string Description { get; set; }

    }
}
