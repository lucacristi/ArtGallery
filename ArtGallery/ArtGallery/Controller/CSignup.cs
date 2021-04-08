using ArtGallery.Model.Persistenta;
using ArtGallery.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery.Controller
{
    class CSignup
    {
        private VSignup vSignup;
        private PersistentaUtilizatori utilizatorP;
    }

    public CSignup()
    {
        this.vPersoane = new VPersoane();
        this.persoanaP = new PersoanaPersistenta();
        this.gestionareEvenimente();
    }
}
