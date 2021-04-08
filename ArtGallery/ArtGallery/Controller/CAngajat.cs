using ArtGallery.Model.Persistenta;
using ArtGallery.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery.Controller
{
    class CAngajat
    {
        private string username;
        private VAngajat vAngajat;
        private PersistentaOperaArta persistentaOperaArta;

        public CAngajat()
        {
            this.vAngajat = new VAngajat();
            this.persistentaOperaArta = new PersistentaOperaArta();
            this.gestionareEvenimente();
        }

        public CAngajat(string username)
        {
            this.username = username;
            this.vAngajat = new VAngajat();
            this.persistentaOperaArta = new PersistentaOperaArta();
            this.gestionareEvenimente();
        }

        public VAngajat GetVAngajat()
        {
            return this.vAngajat;
        }

        private void gestionareEvenimente()
        {
            vAngajat.GetUsernameLabel().Text = "username: " + username;
           // this.vAngajat.GetButtonSignup().Click += new EventHandler(signup);
        }
    }
}
