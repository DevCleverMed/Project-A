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
    public partial class GestionCons : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=YES;Initial Catalog=Contro;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public GestionCons()
        {
            InitializeComponent();
        }

        private void GestionCons_Load(object sender, EventArgs e)
        {
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandText = "   select  codecomplexe , nomcomplexe from Complexe";
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            comboBoxComp.DataSource = dt;
            comboBoxComp.DisplayMember = "nomcomplexe";
            comboBoxComp.ValueMember = "codecomplexe";
            cn.Close();
        }

        private void buttonChercher_Click(object sender, EventArgs e)
        {
            cn.Open();
            //cn.Open();
            cmd.Connection = cn;
            string s;
            if (textBoxMatr.Text == "") MessageBox.Show("Si le conseilles cherché n'existe pas ");
            else
            {
                s = textBoxMatr.Text;
                cmd.CommandText = " select *from Conseiller where matricule ='" + s + "' ";
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    textBoxNom.Text = dr.GetString(1);
                    textBoxPren.Text = dr.GetString(2);
                    comboBoxComp.SelectedValue = dr.GetString(4);
                    textBoxNb.Text = dr.GetInt32(5) + " ";
                    cn.Close();
                }
                else
                {
                    MessageBox.Show("Ce Conseiller introuvable ! ");
                }
                dr.Close();
            }
        }

        private void buttonModi_Click(object sender, EventArgs e)
        {
            string s;
             if (textBoxMatr.Text == "" || textBoxNom.Text == "" || textBoxPren.Text == "" || textBoxNb.Text == "")
             { MessageBox.Show("entre le matricule"); }
             else
             {
                cn.Open();
                 s = textBoxMatr.Text;
                 cmd.CommandText = "select *from Conseiller where Matricule ='" + s + "' ";
                 SqlDataReader dr = cmd.ExecuteReader();
                 if (dr.HasRows)
                 {
                     dr.Close();
                     cmd.CommandText = string.Format("update Conseiller set  Nom = '{0}' , Prenom = '{1}' ,  CodeSecret = '{2}' ,  NombreVisites = '{3}' where Matricule = '{4}' ", textBoxMatr.Text, textBoxPren.Text,
                       comboBoxComp.SelectedValue, Int32.Parse(textBoxNb.Text), textBoxMatr.Text);
                     cmd.ExecuteNonQuery();

                 }
                 else
                 {
                     MessageBox.Show("Ce Matricule n'existe pas");
                 }
             }
        }
    }
}
    