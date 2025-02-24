using System;
using System.Windows.Forms;

namespace Primer_Prototip_Interactiu_K.Djemmah
{
    public partial class IniciUsuari : Form
    {
        public IniciUsuari()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "Dijaa" && textBox4.Text == "Password")
            {
                MessageBox.Show("Benvingut/da!");
                this.Hide();
                MenuPrincipal menuPrincipal = new MenuPrincipal();
                menuPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Contrasenya o Usuari Incorrectes!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Clear();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Obre el formulari de Registre
            RegistreUsuari formulariRegistre = new RegistreUsuari();
            formulariRegistre.Show();

            // Amaga el formulari actual
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Obté el nom d'usuari del TextBox existent (textBox3)
            string Usuari = textBox3.Text.Trim();

            // Comprova si el nom d'usuari està buit
            if (string.IsNullOrEmpty(Usuari))
            {
                MessageBox.Show("Si us plau, introdueix el teu nom d'usuari.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Mostra el missatge que s'ha enviat un correu electrònic
                MessageBox.Show("S'ha enviat un correu electrònic per restablir la teva contrasenya.", "Correu Enviat", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

    }
}
