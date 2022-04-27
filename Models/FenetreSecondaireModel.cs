using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCDataContextFermetureFenetreSecondaire.Models
{
    public class FenetreSecondaireModel
    {
        public FenetreSecondaireModel()
        {}

        public FenetreSecondaireModel(string description, string details, DateTime dateDuJour, string meteoDuJour)
        {
            Description = description;
            Details = details;
            DateDuJour = dateDuJour;
            MeteoDuJour = meteoDuJour;
        }

        public string Description { get; set; }

        public string Details { get; set; }

        public DateTime DateDuJour { get; set; }

        public string MeteoDuJour { get; set; }

    }
}
