using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MohammedHamdani
{
    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=YES;Initial Catalog=Contro;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Conseiller rechercher(string matricule, string codeSecret)
        {
            cmd.Connection = cn;
            cn.Open();

            cmd.CommandText = "  select*from Conseiller where Matricule = '" + matricule + "' and CodeSecret = '" + codeSecret + "' ";
            SqlDataReader dr = cmd.ExecuteReader();
            if (!dr.Read()) return null;
            return new Conseiller(dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetInt32(5));
            cn.Close();

        }

        private void bttnAnnuler_Click(object sender, EventArgs e)
        {
            textBoxMat.Text = "";
            textBoxCodeSE.Text = "";
        }

        private void bttnConexion_Click(object sender, EventArgs e)
        {
            Conseiller conseiller = rechercher(textBoxMat.Text, textBoxCodeSE.Text);
            if (conseiller == null)
            {
                MessageBox.Show("Erreur");
                return;
            }
            Accueil accueil = new Accueil();
            accueil.Show();
            GestionCons f = new GestionCons();
            f.Show();
        }
    }
}
