using System.Windows.Forms;

namespace Primer_Prototip_Interactiu_K.Djemmah
{
    partial class IniciUsuari
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
           
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IniciUsuari));
            INICI = new ContextMenuStrip(components);
            hORARIToolStripMenuItem = new ToolStripMenuItem();
            tASQUESToolStripMenuItem = new ToolStripMenuItem();
            pROGRÈSToolStripMenuItem = new ToolStripMenuItem();
            rECURSOSToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            splitContainer1 = new SplitContainer();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            button1 = new Button();
            INICI.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // INICI
            // 
            INICI.Items.AddRange(new ToolStripItem[] { hORARIToolStripMenuItem, tASQUESToolStripMenuItem, pROGRÈSToolStripMenuItem, rECURSOSToolStripMenuItem });
            INICI.Name = "contextMenuStrip1";
            INICI.Size = new Size(132, 92);
            // 
            // hORARIToolStripMenuItem
            // 
            hORARIToolStripMenuItem.Name = "hORARIToolStripMenuItem";
            hORARIToolStripMenuItem.Size = new Size(131, 22);
            hORARIToolStripMenuItem.Text = "HORARI";
            // 
            // tASQUESToolStripMenuItem
            // 
            tASQUESToolStripMenuItem.Name = "tASQUESToolStripMenuItem";
            tASQUESToolStripMenuItem.Size = new Size(131, 22);
            tASQUESToolStripMenuItem.Text = "TASQUES";
            // 
            // pROGRÈSToolStripMenuItem
            // 
            pROGRÈSToolStripMenuItem.Name = "pROGRÈSToolStripMenuItem";
            pROGRÈSToolStripMenuItem.Size = new Size(131, 22);
            pROGRÈSToolStripMenuItem.Text = "PROGRÈS";
            // 
            // rECURSOSToolStripMenuItem
            // 
            rECURSOSToolStripMenuItem.Name = "rECURSOSToolStripMenuItem";
            rECURSOSToolStripMenuItem.Size = new Size(131, 22);
            rECURSOSToolStripMenuItem.Text = "RECURSOS";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(splitContainer1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1068, 752);
            panel1.TabIndex = 2;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.BackColor = Color.White;
            splitContainer1.Enabled = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Size = new Size(1068, 752);
            splitContainer1.SplitterDistance = 227;
            splitContainer1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1068, 227);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1068, 521);
            panel2.TabIndex = 17;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel3.BackColor = Color.RosyBrown;
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(linkLabel1);
            panel3.Controls.Add(linkLabel2);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(279, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(509, 459);
            panel3.TabIndex = 17;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBox3.Cursor = Cursors.IBeam;
            textBox3.Font = new Font("Alef", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(146, 88);
            textBox3.Margin = new Padding(10, 3, 3, 10);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Usuari";
            textBox3.Size = new Size(235, 36);
            textBox3.TabIndex = 18;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBox4.Cursor = Cursors.IBeam;
            textBox4.Font = new Font("Alef", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(146, 156);
            textBox4.Name = "textBox4";
            textBox4.PasswordChar = '*';
            textBox4.PlaceholderText = "Contrasenya";
            textBox4.Size = new Size(235, 36);
            textBox4.TabIndex = 19;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Maroon;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel1.ForeColor = Color.White;
            linkLabel1.LinkColor = Color.WhiteSmoke;
            linkLabel1.Location = new Point(146, 209);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(235, 21);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Has olvidat la teva contrasenya?";
            linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel1.VisitedLinkColor = Color.FromArgb(64, 0, 0);
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.Maroon;
            linkLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel2.ForeColor = Color.White;
            linkLabel2.LinkColor = Color.WhiteSmoke;
            linkLabel2.Location = new Point(146, 345);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(229, 21);
            linkLabel2.TabIndex = 8;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "No tens cap compte? Registra't!";
            linkLabel2.TextAlign = ContentAlignment.BottomCenter;
            linkLabel2.VisitedLinkColor = Color.FromArgb(64, 0, 0);
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button1.AutoSize = true;
            button1.BackColor = Color.LightSeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Alef", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(168, 269);
            button1.Name = "button1";
            button1.Size = new Size(181, 39);
            button1.TabIndex = 0;
            button1.Text = "Inicia sessió";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // IniciUsuari
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Linen;
            ClientSize = new Size(1068, 752);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            Name = "IniciUsuari";
            Text = "Form1";
            INICI.ResumeLayout(false);
            panel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem pÀGINADINICIToolStripMenuItem;
        private ContextMenuStrip INICI;
        private ToolStripMenuItem hORARIToolStripMenuItem;
        private ToolStripMenuItem tASQUESToolStripMenuItem;
        private ToolStripMenuItem pROGRÈSToolStripMenuItem;
        private ToolStripMenuItem rECURSOSToolStripMenuItem;
        private Panel panel1;
        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
        private Button button1;
        private LinkLabel linkLabel2;
        private Panel panel2;
        private Panel panel3;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}
