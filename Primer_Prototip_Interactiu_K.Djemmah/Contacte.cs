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
    public partial class Contacte : Form
    {
        public Contacte()
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

        // Obrir formulari Horari
        private void hORARIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Horari horariForm = new Horari();
            horariForm.Show();
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

        // Botó per enviar el missatge de contacte
        private void button2_Click(object sender, EventArgs e)
        {
            // Verifica que tots els camps estiguin omplerts
            if (string.IsNullOrEmpty(textBox7.Text) || string.IsNullOrEmpty(textBox3.Text) ||
                string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(richTextBox1.Text))
            {
                MessageBox.Show("Si us plau, omple tots els camps abans d'enviar el missatge.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Mostra un missatge confirmant que el missatge s'ha enviat correctament
                MessageBox.Show("El teu missatge s'ha enviat correctament. Et contactarem aviat.", "Missatge Enviat", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Neteja els camps del formulari
                textBox7.Clear();
                textBox3.Clear();
                textBox4.Clear();
                richTextBox1.Clear();
            }
        }
    }
}