using ArtGallery.Model.Persistenta;
using ArtGallery.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtGallery.Controller
{
    class CWelcome
    {
        private VWelcome vWelcome;
        private PersistentaUtilizatori persistUtilizatori;


        public CWelcome()
        {
            this.vWelcome = new VWelcome();
            this.persistUtilizatori = new PersistentaUtilizatori();
            this.gestionareEvenimente();
        }

        public VWelcome GetVWelcome()
        {
            return this.vWelcome;
        }

        private void gestionareEvenimente()
        {
            this.vWelcome.GetButtonLogin().Click += new EventHandler(login);
        }

        private void login(object sender, EventArgs e)
        {
            string username = this.vWelcome.GetTextBoxUsername().Text;
            string password = this.vWelcome.GetTextBoxPassword().Text;

            if (username.Length > 0 && password.Length > 0)
            {
                if (this.persistUtilizatori.CautaUtilizator(username) != null)
                {
                    this.vWelcome.Hide();
                    VAngajat vAngajat = new VAngajat();
                    vAngajat.Show();
                }
                else
                {
                    MessageBox.Show("Nu exista utilizatorul \"" + username +"\"!");
                }
            }
            else
                MessageBox.Show("Nu s-a introdus numele sau parola");
        }
    }   
}
