using Microsoft.Win32;

namespace Primer_Prototip_Interactiu_K.Djemmah
{
    public partial class IniciUsuari : Form
    {
        public IniciUsuari()
        {
            InitializeComponent();
            button1.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Benvingut/da!", "Missatge de Benvinguda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Obre el formulari de Registre
            RegistreUsuari formulariRegistre = new RegistreUsuari();
            formulariRegistre.Show();

            // Tanca o amaga el formulari actual
            this.Hide(); 
                        
        }
    }
}
