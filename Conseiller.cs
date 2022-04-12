using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohammedHamdani
{
    class Conseiller
    {

        private string _matricule;
        private string _nom;
        private string _prenom;
        private string _codeComplexe;
        private string _codeSecret;
        private int _nombreVisite;

        public string matricule
        {
            get { return _matricule; }
            set { _matricule = value; }
        }
        public string nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public Conseiller() { }

        public Conseiller(string matricule, string nom, string prenom, string codeSecret, string codecomplexe, int nombrevisite)
        {
            if (codeSecret.Length < 3)
                throw new Exception("codeSecret doit etre contient au moin 3 caracter");
            _matricule = matricule;
            _nom = nom;
            _prenom = prenom;
            _codeSecret = codeSecret;
            _codeComplexe = codecomplexe;
            _nombreVisite = nombrevisite;
        }

        public override string ToString()
        {
            return string.Format("matricule : " + _matricule + "- nom : " + _nom + "- prenom : " + _prenom + "- codeSecret : " + _codeSecret + " - codecomplexe : " + _codeComplexe + " - nombreVisite : " + _nombreVisite);
        }

    }
}

