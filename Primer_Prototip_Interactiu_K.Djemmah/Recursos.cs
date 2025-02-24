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
    public partial class Recursos : Form
    {
        public Recursos()
        {
            InitializeComponent();
        }

        // Obrir formulari MenuPrincipal
        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
        }

        // Obrir formulari Perfil
        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Perfil perfilForm = new Perfil();
            perfilForm.Show();
        }

        // Obrir formulari Horari
        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Horari horariForm = new Horari();
            horariForm.Show();
        }

        // Obrir formulari Tasques
        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tasques tasquesForm = new Tasques();
            tasquesForm.Show();
        }

        // Obrir formulari Progrés
        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            this.Hide();
            Progres progresForm = new Progres();
            progresForm.Show();
        }

        // Obrir formulari Contacte
        private void cONTACTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contacte contacteForm = new Contacte();
            contacteForm.Show();
        }

        // Botó per fer una cerca
        private void button9_Click(object sender, EventArgs e)
        {
            // Afegir elements a les ListView
            listView1.Items.Clear(); // Netejar abans d'afegir nous elements
            listView1.Items.Add("Ítem 1");

            listView2.Items.Clear();
            listView2.Items.Add("Ítem 2");

            listView3.Items.Clear();
            listView3.Items.Add("Ítem 3");

            listView4.Items.Clear();
            listView4.Items.Add("Ítem 4");

            listView5.Items.Clear();
            listView5.Items.Add("Ítem 5");

            listView6.Items.Clear();
            listView6.Items.Add("Ítem 6");

            // Mostrar missatge de confirmació
            MessageBox.Show("S'ha fet la cerca correctament.", "Cerca Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
