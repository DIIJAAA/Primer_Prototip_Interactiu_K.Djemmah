namespace Primer_Prototip_Interactiu_K.Djemmah
{
    partial class PaginaInici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaInici));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            statusStrip1 = new StatusStrip();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            iNICIToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(249, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(450, 174);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.AutoSize = true;
            button1.BackColor = Color.LightSeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Alef", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(296, 259);
            button1.Name = "button1";
            button1.Size = new Size(177, 49);
            button1.TabIndex = 8;
            button1.Text = "Inicia sessió";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.AutoSize = true;
            button2.BackColor = Color.LightSeaGreen;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Alef", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(511, 259);
            button2.Name = "button2";
            button2.Size = new Size(150, 49);
            button2.TabIndex = 9;
            button2.Text = "Registra't";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(66, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(948, 391);
            panel1.TabIndex = 10;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 507);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1069, 22);
            statusStrip1.TabIndex = 11;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.RosyBrown;
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, iNICIToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1069, 55);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "INICI";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Font = new Font("Alef", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripMenuItem1.ForeColor = SystemColors.MenuBar;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(62, 51);
            toolStripMenuItem1.Text = "...";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // iNICIToolStripMenuItem
            // 
            iNICIToolStripMenuItem.Font = new Font("Alef", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iNICIToolStripMenuItem.ForeColor = Color.White;
            iNICIToolStripMenuItem.Name = "iNICIToolStripMenuItem";
            iNICIToolStripMenuItem.Size = new Size(96, 51);
            iNICIToolStripMenuItem.Text = "INICI";
            // 
            // PaginaInici
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1069, 529);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(panel1);
            ForeColor = Color.Linen;
            MainMenuStrip = menuStrip1;
            Name = "PaginaInici";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private StatusStrip statusStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem iNICIToolStripMenuItem;
    }
}