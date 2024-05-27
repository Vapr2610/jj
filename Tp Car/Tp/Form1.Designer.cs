namespace Tp
{
    partial class Form1
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
            pictureBox1 = new PictureBox();
            pbcar = new PictureBox();
            pb1 = new PictureBox();
            pb2 = new PictureBox();
            tm1 = new System.Windows.Forms.Timer(components);
            pnborder = new Panel();
            menuStrip1 = new MenuStrip();
            startToolStripMenuItem = new ToolStripMenuItem();
            pauseToolStripMenuItem = new ToolStripMenuItem();
            newGameToolStripMenuItem = new ToolStripMenuItem();
            difficultToolStripMenuItem = new ToolStripMenuItem();
            easyToolStripMenuItem = new ToolStripMenuItem();
            mediumToolStripMenuItem = new ToolStripMenuItem();
            hardToolStripMenuItem = new ToolStripMenuItem();
            tmleft = new System.Windows.Forms.Timer(components);
            tmright = new System.Windows.Forms.Timer(components);
            lb1 = new Label();
            coin1 = new PictureBox();
            coin3 = new PictureBox();
            coin4 = new PictureBox();
            coin2 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbcar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb2).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)coin1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Location = new Point(170, -13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(10, 80);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pbcar
            // 
            pbcar.Enabled = false;
            pbcar.Image = Properties.Resources.машина;
            pbcar.Location = new Point(186, 353);
            pbcar.Name = "pbcar";
            pbcar.Size = new Size(47, 109);
            pbcar.SizeMode = PictureBoxSizeMode.Zoom;
            pbcar.TabIndex = 1;
            pbcar.TabStop = false;
            // 
            // pb1
            // 
            pb1.Image = Properties.Resources.машина1;
            pb1.Location = new Point(296, 298);
            pb1.Name = "pb1";
            pb1.Size = new Size(47, 109);
            pb1.SizeMode = PictureBoxSizeMode.Zoom;
            pb1.TabIndex = 2;
            pb1.TabStop = false;
            // 
            // pb2
            // 
            pb2.Image = Properties.Resources.машина1;
            pb2.Location = new Point(211, 36);
            pb2.Name = "pb2";
            pb2.Size = new Size(47, 109);
            pb2.SizeMode = PictureBoxSizeMode.Zoom;
            pb2.TabIndex = 4;
            pb2.TabStop = false;
            // 
            // tm1
            // 
            tm1.Interval = 40;
            tm1.Tick += tm1_Tick;
            // 
            // pnborder
            // 
            pnborder.BackColor = SystemColors.ActiveBorder;
            pnborder.Location = new Point(382, 0);
            pnborder.Name = "pnborder";
            pnborder.Size = new Size(15, 565);
            pnborder.TabIndex = 6;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { startToolStripMenuItem, pauseToolStripMenuItem, newGameToolStripMenuItem, difficultToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(534, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // startToolStripMenuItem
            // 
            startToolStripMenuItem.Name = "startToolStripMenuItem";
            startToolStripMenuItem.Size = new Size(43, 20);
            startToolStripMenuItem.Text = "Start";
            startToolStripMenuItem.Click += startToolStripMenuItem_Click;
            // 
            // pauseToolStripMenuItem
            // 
            pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            pauseToolStripMenuItem.Size = new Size(50, 20);
            pauseToolStripMenuItem.Text = "Pause";
            pauseToolStripMenuItem.Click += pauseToolStripMenuItem_Click;
            // 
            // newGameToolStripMenuItem
            // 
            newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            newGameToolStripMenuItem.Size = new Size(77, 20);
            newGameToolStripMenuItem.Text = "New Game";
            newGameToolStripMenuItem.Click += newGameToolStripMenuItem_Click;
            // 
            // difficultToolStripMenuItem
            // 
            difficultToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { easyToolStripMenuItem, mediumToolStripMenuItem, hardToolStripMenuItem });
            difficultToolStripMenuItem.Name = "difficultToolStripMenuItem";
            difficultToolStripMenuItem.Size = new Size(70, 20);
            difficultToolStripMenuItem.Text = "Difficulty ";
            // 
            // easyToolStripMenuItem
            // 
            easyToolStripMenuItem.Name = "easyToolStripMenuItem";
            easyToolStripMenuItem.Size = new Size(119, 22);
            easyToolStripMenuItem.Text = "Easy";
            easyToolStripMenuItem.Click += easyToolStripMenuItem_Click;
            // 
            // mediumToolStripMenuItem
            // 
            mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            mediumToolStripMenuItem.Size = new Size(119, 22);
            mediumToolStripMenuItem.Text = "Medium";
            mediumToolStripMenuItem.Click += mediumToolStripMenuItem_Click;
            // 
            // hardToolStripMenuItem
            // 
            hardToolStripMenuItem.Name = "hardToolStripMenuItem";
            hardToolStripMenuItem.Size = new Size(119, 22);
            hardToolStripMenuItem.Text = "Hard";
            hardToolStripMenuItem.Click += hardToolStripMenuItem_Click;
            // 
            // tmleft
            // 
            tmleft.Interval = 1;
            tmleft.Tick += tmleft_Tick;
            // 
            // tmright
            // 
            tmright.Interval = 1;
            tmright.Tick += tmright_Tick;
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Font = new Font("Bernard MT Condensed", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lb1.ForeColor = Color.Black;
            lb1.Location = new Point(403, 36);
            lb1.Name = "lb1";
            lb1.Size = new Size(0, 31);
            lb1.TabIndex = 8;
            // 
            // coin1
            // 
            coin1.Image = Properties.Resources.монета;
            coin1.Location = new Point(90, 156);
            coin1.Name = "coin1";
            coin1.Size = new Size(30, 38);
            coin1.SizeMode = PictureBoxSizeMode.Zoom;
            coin1.TabIndex = 11;
            coin1.TabStop = false;
            // 
            // coin3
            // 
            coin3.Image = Properties.Resources.монета;
            coin3.Location = new Point(252, 261);
            coin3.Name = "coin3";
            coin3.Size = new Size(30, 38);
            coin3.SizeMode = PictureBoxSizeMode.Zoom;
            coin3.TabIndex = 12;
            coin3.TabStop = false;
            // 
            // coin4
            // 
            coin4.Image = Properties.Resources.монета;
            coin4.Location = new Point(313, 189);
            coin4.Name = "coin4";
            coin4.Size = new Size(30, 38);
            coin4.SizeMode = PictureBoxSizeMode.Zoom;
            coin4.TabIndex = 13;
            coin4.TabStop = false;
            // 
            // coin2
            // 
            coin2.Image = Properties.Resources.монета;
            coin2.Location = new Point(122, 261);
            coin2.Name = "coin2";
            coin2.Size = new Size(30, 38);
            coin2.SizeMode = PictureBoxSizeMode.Zoom;
            coin2.TabIndex = 14;
            coin2.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ButtonHighlight;
            pictureBox2.Location = new Point(170, 156);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(10, 80);
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ButtonHighlight;
            pictureBox3.Location = new Point(170, 327);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(10, 80);
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.ButtonHighlight;
            pictureBox4.Location = new Point(170, 485);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(10, 80);
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(534, 561);
            Controls.Add(menuStrip1);
            Controls.Add(coin2);
            Controls.Add(coin4);
            Controls.Add(coin3);
            Controls.Add(coin1);
            Controls.Add(lb1);
            Controls.Add(pnborder);
            Controls.Add(pb2);
            Controls.Add(pb1);
            Controls.Add(pbcar);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox1);
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(550, 600);
            MinimumSize = new Size(550, 600);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbcar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb2).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)coin1).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin3).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin4).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pbcar;
        private PictureBox pb1;
        private PictureBox pb2;
        private System.Windows.Forms.Timer tm1;
        private Panel pnborder;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem startToolStripMenuItem;
        private ToolStripMenuItem pauseToolStripMenuItem;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem difficultToolStripMenuItem;
        private ToolStripMenuItem easyToolStripMenuItem;
        private ToolStripMenuItem mediumToolStripMenuItem;
        private ToolStripMenuItem hardToolStripMenuItem;
        private System.Windows.Forms.Timer tmleft;
        private System.Windows.Forms.Timer tmright;
        private Label lb1;
        private PictureBox coin1;
        private PictureBox coin3;
        private PictureBox coin4;
        private PictureBox coin2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}
