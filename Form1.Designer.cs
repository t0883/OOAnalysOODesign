namespace OOAnalysOODesign
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tidtabelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biljettprisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loggaInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regitreraKontoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbHållplats1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbHållplats2 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(520, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(280, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tidtabelToolStripMenuItem,
            this.biljettprisToolStripMenuItem,
            this.loggaInToolStripMenuItem,
            this.regitreraKontoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(156, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(124, 225);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tidtabelToolStripMenuItem
            // 
            this.tidtabelToolStripMenuItem.Name = "tidtabelToolStripMenuItem";
            this.tidtabelToolStripMenuItem.Size = new System.Drawing.Size(115, 19);
            this.tidtabelToolStripMenuItem.Text = "Tidtabel";
            this.tidtabelToolStripMenuItem.Click += new System.EventHandler(this.tidtabelToolStripMenuItem_Click);
            // 
            // biljettprisToolStripMenuItem
            // 
            this.biljettprisToolStripMenuItem.Name = "biljettprisToolStripMenuItem";
            this.biljettprisToolStripMenuItem.Size = new System.Drawing.Size(115, 19);
            this.biljettprisToolStripMenuItem.Text = "Biljettpris";
            this.biljettprisToolStripMenuItem.Click += new System.EventHandler(this.biljettprisToolStripMenuItem_Click);
            // 
            // loggaInToolStripMenuItem
            // 
            this.loggaInToolStripMenuItem.Name = "loggaInToolStripMenuItem";
            this.loggaInToolStripMenuItem.Size = new System.Drawing.Size(115, 19);
            this.loggaInToolStripMenuItem.Text = "Logga in";
            this.loggaInToolStripMenuItem.Click += new System.EventHandler(this.loggaInToolStripMenuItem_Click);
            // 
            // regitreraKontoToolStripMenuItem
            // 
            this.regitreraKontoToolStripMenuItem.Name = "regitreraKontoToolStripMenuItem";
            this.regitreraKontoToolStripMenuItem.Size = new System.Drawing.Size(115, 19);
            this.regitreraKontoToolStripMenuItem.Text = "Regitrera konto";
            this.regitreraKontoToolStripMenuItem.Click += new System.EventHandler(this.regitreraKontoToolStripMenuItem_Click);
            // 
            // cbHållplats1
            // 
            this.cbHållplats1.FormattingEnabled = true;
            this.cbHållplats1.Items.AddRange(new object[] {
            "Göteborgs Central",
            "Kungsbacka",
            "Kungälv"});
            this.cbHållplats1.Location = new System.Drawing.Point(98, 158);
            this.cbHållplats1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbHållplats1.Name = "cbHållplats1";
            this.cbHållplats1.Size = new System.Drawing.Size(92, 21);
            this.cbHållplats1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Res från:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(308, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Res till:";
            // 
            // cbHållplats2
            // 
            this.cbHållplats2.FormattingEnabled = true;
            this.cbHållplats2.Items.AddRange(new object[] {
            "Göteborgs Central",
            "Kungsbacka",
            "Kungälv"});
            this.cbHållplats2.Location = new System.Drawing.Point(310, 158);
            this.cbHållplats2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbHållplats2.Name = "cbHållplats2";
            this.cbHållplats2.Size = new System.Drawing.Size(92, 21);
            this.cbHållplats2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbHållplats2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbHållplats1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tidtabelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biljettprisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loggaInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regitreraKontoToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbHållplats1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbHållplats2;
    }
}

