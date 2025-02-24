﻿using System;
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
    public partial class Perfil : Form
    {
        public Perfil()
        {
            InitializeComponent();
        }

        // Botó per pujar una imatge de perfil
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Els canvis del perfil s'han guardat correctament.", "Editar Perfil", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Botó per guardar els canvis del perfil
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("S'ha generat l'informe correctament.", "Informe generat", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Obrir formulari MenuPrincipal
        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
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

        // Mostrar missatge al fer clic a la imatge de perfil
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has canviat la teva imatge de perfil!", "Informació", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
