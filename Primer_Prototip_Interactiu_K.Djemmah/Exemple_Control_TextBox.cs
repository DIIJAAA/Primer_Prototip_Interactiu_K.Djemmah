using System;
using System.Windows.Forms;

namespace Primer_Prototip_Interactiu_K.Djemmah
{
    public partial class Exemple_Control_TextBox : Form
    {
        // Declarem els TextBoxs
        private TextBox textBoxNormal;
        private TextBox textBoxMaxLength;
        private TextBox textBoxPassword;
        private TextBox textBoxTextChanged;

        public Exemple_Control_TextBox()
        {
            InitializeComponent();

            // Configuració bàsica del formulari
            this.Text = "Exemple de TextBox";
            this.Size = new Size(400, 300);

            // TextBox normal
            textBoxNormal = new TextBox();
            textBoxNormal.Location = new Point(50, 50);
            textBoxNormal.Size = new Size(200, 30);
            textBoxNormal.Text = "TextBox normal";

            // TextBox amb MaxLength
            textBoxMaxLength = new TextBox();
            textBoxMaxLength.Location = new Point(50, 100);
            textBoxMaxLength.Size = new Size(200, 30);
            textBoxMaxLength.MaxLength = 10; // Limita a 10 caràcters
            textBoxMaxLength.Text = "Màx 10 caràcters";

            // TextBox amb PasswordChar
            textBoxPassword = new TextBox();
            textBoxPassword.Location = new Point(50, 150);
            textBoxPassword.Size = new Size(200, 30);
            textBoxPassword.PasswordChar = '*'; // Amaga el text amb asteriscs
            textBoxPassword.Text = "contrasenya";

            // TextBox amb l'event TextChanged
            textBoxTextChanged = new TextBox();
            textBoxTextChanged.Location = new Point(50, 200);
            textBoxTextChanged.Size = new Size(200, 30);
            textBoxTextChanged.TextChanged += TextBoxTextChanged_TextChanged; // Assignem l'event

            // Afegim els TextBoxs al formulari
            this.Controls.Add(textBoxNormal);
            this.Controls.Add(textBoxMaxLength);
            this.Controls.Add(textBoxPassword);
            this.Controls.Add(textBoxTextChanged);
        }

        // Event que es dispara quan el text del TextBoxTextChanged canvia
        private void TextBoxTextChanged_TextChanged(object sender, EventArgs e)
        {
            // Mostrem el text actual en el títol del formulari
            this.Text = "Text canviat: " + textBoxTextChanged.Text;
        }
    }
}