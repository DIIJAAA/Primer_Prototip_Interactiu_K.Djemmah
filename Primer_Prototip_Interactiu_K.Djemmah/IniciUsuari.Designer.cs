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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel6 = new Panel();
            linkLabel2 = new LinkLabel();
            panel5 = new Panel();
            button1 = new Button();
            panel4 = new Panel();
            textBox2 = new TextBox();
            panel3 = new Panel();
            textBox1 = new TextBox();
            panel2 = new Panel();
            linkLabel1 = new LinkLabel();
            INICI.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
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
            panel1.Size = new Size(800, 542);
            panel1.TabIndex = 2;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Enabled = false;
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
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Size = new Size(800, 542);
            splitContainer1.SplitterDistance = 165;
            splitContainer1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 165);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.BackColor = Color.RosyBrown;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel6, 0, 4);
            tableLayoutPanel1.Controls.Add(panel5, 0, 3);
            tableLayoutPanel1.Controls.Add(panel4, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 0, 2);
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Location = new Point(202, 23);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 97F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(426, 311);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // panel6
            // 
            panel6.Controls.Add(linkLabel2);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 237);
            panel6.Name = "panel6";
            panel6.Size = new Size(420, 71);
            panel6.TabIndex = 15;
            // 
            // linkLabel2
            // 
            linkLabel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.WhiteSmoke;
            linkLabel2.Location = new Point(122, 0);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(172, 15);
            linkLabel2.TabIndex = 8;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "No tens cap compte? Registra't!";
            linkLabel2.TextAlign = ContentAlignment.BottomCenter;
            linkLabel2.VisitedLinkColor = Color.FromArgb(64, 0, 0);
            // 
            // panel5
            // 
            panel5.Controls.Add(button1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 194);
            panel5.Name = "panel5";
            panel5.Size = new Size(420, 37);
            panel5.TabIndex = 15;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button1.AutoSize = true;
            button1.BackColor = Color.LightSeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(145, 3);
            button1.Name = "button1";
            button1.Size = new Size(122, 32);
            button1.TabIndex = 0;
            button1.Text = "Inicia sessió";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(textBox2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 100);
            panel4.Name = "panel4";
            panel4.Size = new Size(420, 53);
            panel4.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBox2.Font = new Font("Sylfaen", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(110, 7);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Contrasenya";
            textBox2.Size = new Size(200, 35);
            textBox2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(textBox1);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(420, 91);
            panel3.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBox1.Font = new Font("Sylfaen", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(110, 46);
            textBox1.Margin = new Padding(10, 3, 3, 10);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Usuari";
            textBox1.Size = new Size(200, 35);
            textBox1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(linkLabel1);
            panel2.Location = new Point(3, 159);
            panel2.Name = "panel2";
            panel2.Size = new Size(420, 29);
            panel2.TabIndex = 15;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.WhiteSmoke;
            linkLabel1.Location = new Point(122, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(178, 15);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Has olvidat la teva contrasenya?";
            linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel1.VisitedLinkColor = Color.FromArgb(64, 0, 0);
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // IniciUsuari
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Linen;
            ClientSize = new Size(800, 542);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            Name = "IniciUsuari";
            Text = "Form1";
            INICI.ResumeLayout(false);
            panel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private LinkLabel linkLabel2;
        private Panel panel4;
        private Panel panel3;
        private Panel panel5;
        private Panel panel6;
    }
}
