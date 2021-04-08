using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery.Model
{
    class OperaArta
    {
        protected string titlu;
        protected string numeArtist;
        protected int anRealizare;
       
        public OperaArta() { }

        public OperaArta(OperaArta operaArta)
        {
            this.titlu = operaArta.titlu;
            this.numeArtist = operaArta.numeArtist;
            this.anRealizare = operaArta.anRealizare;
        }

        public OperaArta(string titlu, string numeArtist, int anRealizare)
        {
            this.titlu = titlu;
            this.numeArtist = numeArtist;
            this.anRealizare = anRealizare;
        }

        public string GetTitlu()
        {
            return titlu;
        }

        public string GetNumeArtist()
        {
            return numeArtist;
        }

        public int GetAnRealizare()
        {
            return anRealizare;
        }
        
        public void setTitlu(string titlu)
        {
            this.titlu = titlu;
        }

        public void setNumeArtist(string numeArtist)
        {
            this.numeArtist = numeArtist;
        }

        public void setAnRealizare(int anRealizare)
        {
            this.anRealizare = anRealizare;
        }
    }
}
