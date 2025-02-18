using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primer_Prototip_Interactiu_K.Djemmah
{
    public partial class RegistreUsuari : Form
    {
        public RegistreUsuari()
        {
            InitializeComponent();
            // Afegir opcions als ComboBox
            comboBox1.Items.AddRange(new string[] {
                "Educació Primària",
                "Educació Secundària Obligatòria (ESO)",
                "Batxillerat",
                "Formació Professional (FP)",
                "Ensenyaments universitaris"
            });

            comboBox2.Items.AddRange(new string[] {
                "Ciències socials (Economia, Història, Lingüística, etc.)",
                "Ciències naturals (Biologia, Física, Química, etc.)",
                "Ciències Pures (Matemàtiques, Geometria, etc.)",
                "Ciències aplicades i tecnologies (Arquitectura, Informàtica, Farmàcia, etc.)"
            });

            // Afegir esdeveniments als controls
            button1.Click += Button1_Click;
            linkLabel1.LinkClicked += LinkLabel1_LinkClicked;
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Obrir el formulari d'IniciUsuari i amagar aquest formulari
            IniciUsuari iniciUsuari = new IniciUsuari();
            iniciUsuari.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Obrir el formulari del menú principal i mostrar el missatge
            MessageBox.Show("Benvingut/da! S'ha enviat un correu per a verificar l'usuari.", "Registre complet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }
    }
}
