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
    public partial class Progres : Form
    {
        public Progres()
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

        // Obrir formulari Recursos
        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Recursos recursosForm = new Recursos();
            recursosForm.Show();
        }

        // Obrir formulari Contacte
        private void cONTACTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contacte contacteForm = new Contacte();
            contacteForm.Show();
        }

        // Quan es fa clic a la imatge, mostra el missatge de confirmació
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has pujat la teva imatge de perfil correctament.", "Perfil actualitzat", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Primer botó: Bono de recompensa descarregat
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desbloqueja el premi per obtenir la recompensa.", "Premi Bloquejat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Restants botons: Missatge de desbloqueig necessari
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bono de recompensa descarregat.", "Recompensa Obtinguda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desbloqueja el premi per obtenir la recompensa.", "Premi Bloquejat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desbloqueja el premi per obtenir la recompensa.", "Premi Bloquejat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desbloqueja el premi per obtenir la recompensa.", "Premi Bloquejat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}
