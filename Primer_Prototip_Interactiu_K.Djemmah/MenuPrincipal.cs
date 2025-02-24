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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        // Obrir formulari Horari
        private void button9_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Horari horariForm = new Horari();
            horariForm.Show();
        }

        // Obrir formulari Tasques
        private void button10_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Tasques tasquesForm = new Tasques();
            tasquesForm.Show();
        }

        // Obrir formulari Progrés
        private void button11_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Progres progresForm = new Progres();
            progresForm.Show();
        }

        // Obrir formulari Recursos
        private void button12_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Recursos recursosForm = new Recursos();
            recursosForm.Show();
        }

        // Obrir formulari Perfil
        private void pERFILToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Perfil perfilForm = new Perfil();
            perfilForm.Show();
        }

        // Mostrar missatge per pujar una imatge
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Puja una imatge per al teu usuari.", "Pujar Imatge", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cONTACTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contacte contacteForm = new Contacte();
            contacteForm.Show();
        }
    }
}
