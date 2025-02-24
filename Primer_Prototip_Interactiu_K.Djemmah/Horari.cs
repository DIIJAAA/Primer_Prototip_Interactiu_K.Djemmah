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
    public partial class Horari : Form
    {
        public Horari()
        {
            InitializeComponent();
        }

        // Obrir formulari MenuPrincipal
        private void iNICIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
        }

        // Obrir formulari Perfil
        private void pERFILToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Perfil perfilForm = new Perfil();
            perfilForm.Show();
        }

        // Obrir formulari Tasques
        private void tASQUESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tasques tasquesForm = new Tasques();
            tasquesForm.Show();
        }

        // Obrir formulari Progrés
        private void pROGRÈSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Progres progresForm = new Progres();
            progresForm.Show();
        }

        // Obrir formulari Recursos
        private void rECURSOSToolStripMenuItem_Click(object sender, EventArgs e)
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

        // Botó per crear un event
        private void button9_Click(object sender, EventArgs e)
        {
            // Mostra un missatge confirmant que l'event s'ha creat correctament
            MessageBox.Show("Un cop afegida la data i hora, has creat l'event correctament. Es mostrarà una notificació quan quedi poc per a l'event.", "Event Creat", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void richTextBox16_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
