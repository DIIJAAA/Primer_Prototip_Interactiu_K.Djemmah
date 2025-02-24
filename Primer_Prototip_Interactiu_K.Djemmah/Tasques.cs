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
    public partial class Tasques : Form
    {
        public Tasques()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Perfil perfilForm = new Perfil();
            perfilForm.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Horari horariForm = new Horari();
            horariForm.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Progres progresForm = new Progres();
            progresForm.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Recursos recursosForm = new Recursos();
            recursosForm.Show();
        }

        private void cONTACTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contacte contacteForm = new Contacte();
            contacteForm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has creat una nova tasca correctament. Rebràs una notificació quan estigui propera la data límit.", "Tasca Creada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
