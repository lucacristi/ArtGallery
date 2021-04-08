using ArtGallery.Model.Persistenta;
using ArtGallery.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery.Controller
{
    class CAdministrator
    {
        private VAdministrator vAdministrator;
        private PersistentaOperaArta persistentaOperaArta;
        private PersistentaUtilizatori persistentaUtilizatori;

        public CAdministrator()
        {
            this.vAdministrator = new VAdministrator();
            this.persistentaOperaArta = new PersistentaOperaArta();
            this.persistentaUtilizatori = new PersistentaUtilizatori();
        }

        public VAdministrator GetVAdministrator()
        {
            return this.vAdministrator;
        }
    }


}
