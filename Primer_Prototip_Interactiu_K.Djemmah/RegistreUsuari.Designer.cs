namespace Primer_Prototip_Interactiu_K.Djemmah
{
    partial class RegistreUsuari
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistreUsuari));
            panel1 = new Panel();
            splitContainer1 = new SplitContainer();
            pictureBox1 = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel9 = new Panel();
            panel10 = new Panel();
            panel11 = new Panel();
            textBox2 = new TextBox();
            panel12 = new Panel();
            panel13 = new Panel();
            textBox3 = new TextBox();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox4 = new TextBox();
            panel2 = new Panel();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Linen;
            panel1.Controls.Add(splitContainer1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 542);
            panel1.TabIndex = 14;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
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
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel2);
            splitContainer1.Size = new Size(800, 542);
            splitContainer1.SplitterDistance = 175;
            splitContainer1.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 175);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.BackColor = Color.RosyBrown;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel2, 0, 5);
            tableLayoutPanel2.Controls.Add(button1, 0, 6);
            tableLayoutPanel2.Controls.Add(panel9, 0, 4);
            tableLayoutPanel2.Controls.Add(panel10, 0, 3);
            tableLayoutPanel2.Controls.Add(panel11, 0, 1);
            tableLayoutPanel2.Controls.Add(panel12, 0, 2);
            tableLayoutPanel2.Controls.Add(panel13, 0, 0);
            tableLayoutPanel2.Location = new Point(179, 20);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 7;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(426, 321);
            tableLayoutPanel2.TabIndex = 17;
            // 
            // panel9
            // 
            panel9.Controls.Add(comboBox1);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(3, 194);
            panel9.Name = "panel9";
            panel9.Size = new Size(420, 42);
            panel9.TabIndex = 15;
            // 
            // panel10
            // 
            panel10.Controls.Add(textBox4);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(3, 154);
            panel10.Name = "panel10";
            panel10.Size = new Size(420, 34);
            panel10.TabIndex = 15;
            // 
            // panel11
            // 
            panel11.Controls.Add(textBox2);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(3, 61);
            panel11.Name = "panel11";
            panel11.Size = new Size(420, 42);
            panel11.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBox2.Font = new Font("Sylfaen", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(121, 3);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Contrasenya";
            textBox2.Size = new Size(200, 35);
            textBox2.TabIndex = 3;
            // 
            // panel12
            // 
            panel12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel12.Controls.Add(textBox1);
            panel12.Location = new Point(3, 109);
            panel12.Name = "panel12";
            panel12.Size = new Size(420, 39);
            panel12.TabIndex = 15;
            // 
            // panel13
            // 
            panel13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel13.Controls.Add(textBox3);
            panel13.Location = new Point(3, 3);
            panel13.Name = "panel13";
            panel13.Size = new Size(420, 52);
            panel13.TabIndex = 15;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBox3.Font = new Font("Sylfaen", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(121, 14);
            textBox3.Margin = new Padding(10, 3, 3, 10);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Usuari";
            textBox3.Size = new Size(200, 35);
            textBox3.TabIndex = 2;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button1.AutoSize = true;
            button1.BackColor = Color.LightSeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(152, 281);
            button1.Name = "button1";
            button1.Size = new Size(122, 37);
            button1.TabIndex = 0;
            button1.Text = "Registra't";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBox1.Font = new Font("Sylfaen", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(121, 0);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Contrasenya";
            textBox1.Size = new Size(200, 35);
            textBox1.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBox4.Font = new Font("Sylfaen", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(121, -1);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Contrasenya";
            textBox4.Size = new Size(200, 35);
            textBox4.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(comboBox2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 242);
            panel2.Name = "panel2";
            panel2.Size = new Size(420, 33);
            panel2.TabIndex = 18;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(121, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 23);
            comboBox1.TabIndex = 19;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(121, 0);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(200, 23);
            comboBox2.TabIndex = 20;
            // 
            // RegistreUsuari
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 542);
            Controls.Add(panel1);
            Name = "RegistreUsuari";
            Text = "a";
            panel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel9;
        private Button button1;
        private Panel panel10;
        private TextBox textBox4;
        private Panel panel11;
        private TextBox textBox2;
        private Panel panel12;
        private TextBox textBox1;
        private Panel panel13;
        private TextBox textBox3;
        private Panel panel2;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
    }
}