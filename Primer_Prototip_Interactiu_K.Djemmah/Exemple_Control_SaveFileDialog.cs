using System;
using System.Windows.Forms;

namespace Primer_Prototip_Interactiu_K.Djemmah
{
    public partial class Exemple_Control_SaveFileDialog : Form
    {
        // Declarem els controls
        private Button buttonObrirDialog;
        private TextBox textBoxRutaFitxer;
        private SaveFileDialog saveFileDialog;

        public Exemple_Control_SaveFileDialog()
        {
            InitializeComponent();

            // Configuració bàsica del formulari
            this.Text = "Exemple de SaveFileDialog";
            this.Size = new Size(400, 200);

            // Creem i configurem el Button
            buttonObrirDialog = new Button();
            buttonObrirDialog.Location = new Point(50, 50);
            buttonObrirDialog.Size = new Size(200, 30);
            buttonObrirDialog.Text = "Obrir SaveFileDialog";
            buttonObrirDialog.Click += ButtonObrirDialog_Click; // Assignem l'event

            // Creem i configurem el TextBox
            textBoxRutaFitxer = new TextBox();
            textBoxRutaFitxer.Location = new Point(50, 100);
            textBoxRutaFitxer.Size = new Size(200, 30);
            textBoxRutaFitxer.ReadOnly = true; // El TextBox és de només lectura

            // Creem i configurem el SaveFileDialog
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Fitxers de text (*.txt)|*.txt|Tots els fitxers (*.*)|*.*"; // Filtres per als tipus de fitxers
            saveFileDialog.Title = "Desar fitxer"; // Títol del diàleg

            // Afegim els controls al formulari
            this.Controls.Add(buttonObrirDialog);
            this.Controls.Add(textBoxRutaFitxer);
        }

        // Event que es dispara quan es fa clic al Button
        private void ButtonObrirDialog_Click(object sender, EventArgs e)
        {
            // Obrim el SaveFileDialog
            DialogResult resultat = saveFileDialog.ShowDialog();

            // Si l'usuari fa clic a "Desar"
            if (resultat == DialogResult.OK)
            {
                // Mostrem la ruta del fitxer seleccionat al TextBox
                textBoxRutaFitxer.Text = saveFileDialog.FileName;
            }
        }
    }
}