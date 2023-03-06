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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.lblStartHållplats = new System.Windows.Forms.Label();
            this.lblSlutHållplats = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblZonAPris = new System.Windows.Forms.Label();
            this.lblZonBPris = new System.Windows.Forms.Label();
            this.lblZonCPris = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblStartZon = new System.Windows.Forms.Label();
            this.lblSlutZon = new System.Windows.Forms.Label();
            this.lblStartZonfast = new System.Windows.Forms.Label();
            this.lblSlutZonfast = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(704, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(96, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tidtabelToolStripMenuItem,
            this.biljettprisToolStripMenuItem,
            this.loggaInToolStripMenuItem,
            this.regitreraKontoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(96, 450);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tidtabelToolStripMenuItem
            // 
            this.tidtabelToolStripMenuItem.Name = "tidtabelToolStripMenuItem";
            this.tidtabelToolStripMenuItem.Size = new System.Drawing.Size(95, 19);
            this.tidtabelToolStripMenuItem.Text = "Tidtabel";
            this.tidtabelToolStripMenuItem.Click += new System.EventHandler(this.tidtabelToolStripMenuItem_Click);
            // 
            // biljettprisToolStripMenuItem
            // 
            this.biljettprisToolStripMenuItem.Name = "biljettprisToolStripMenuItem";
            this.biljettprisToolStripMenuItem.Size = new System.Drawing.Size(95, 19);
            this.biljettprisToolStripMenuItem.Text = "Biljettpris";
            this.biljettprisToolStripMenuItem.Click += new System.EventHandler(this.biljettprisToolStripMenuItem_Click);
            // 
            // loggaInToolStripMenuItem
            // 
            this.loggaInToolStripMenuItem.Name = "loggaInToolStripMenuItem";
            this.loggaInToolStripMenuItem.Size = new System.Drawing.Size(95, 19);
            this.loggaInToolStripMenuItem.Text = "Logga in";
            this.loggaInToolStripMenuItem.Click += new System.EventHandler(this.loggaInToolStripMenuItem_Click);
            // 
            // regitreraKontoToolStripMenuItem
            // 
            this.regitreraKontoToolStripMenuItem.Name = "regitreraKontoToolStripMenuItem";
            this.regitreraKontoToolStripMenuItem.Size = new System.Drawing.Size(95, 19);
            this.regitreraKontoToolStripMenuItem.Text = "Regitrera konto";
            this.regitreraKontoToolStripMenuItem.Click += new System.EventHandler(this.regitreraKontoToolStripMenuItem_Click);
            // 
            // cbHållplats1
            // 
            this.cbHållplats1.FormattingEnabled = true;
            this.cbHållplats1.Location = new System.Drawing.Point(48, 158);
            this.cbHållplats1.Margin = new System.Windows.Forms.Padding(2);
            this.cbHållplats1.Name = "cbHållplats1";
            this.cbHållplats1.Size = new System.Drawing.Size(125, 21);
            this.cbHållplats1.TabIndex = 1;
            this.cbHållplats1.SelectedIndexChanged += new System.EventHandler(this.cbHållplats1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Res från:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Res till:";
            // 
            // cbHållplats2
            // 
            this.cbHållplats2.FormattingEnabled = true;
            this.cbHållplats2.Location = new System.Drawing.Point(310, 158);
            this.cbHållplats2.Margin = new System.Windows.Forms.Padding(2);
            this.cbHållplats2.Name = "cbHållplats2";
            this.cbHållplats2.Size = new System.Drawing.Size(127, 21);
            this.cbHållplats2.TabIndex = 4;
            this.cbHållplats2.SelectedIndexChanged += new System.EventHandler(this.cbHållplats2_SelectedIndexChanged);
            // 
            // lblStartHållplats
            // 
            this.lblStartHållplats.AutoSize = true;
            this.lblStartHållplats.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartHållplats.Location = new System.Drawing.Point(42, 196);
            this.lblStartHållplats.Name = "lblStartHållplats";
            this.lblStartHållplats.Size = new System.Drawing.Size(334, 31);
            this.lblStartHållplats.TabIndex = 5;
            this.lblStartHållplats.Text = "Den valda start hållplatsen";
            this.lblStartHållplats.Visible = false;
            // 
            // lblSlutHållplats
            // 
            this.lblSlutHållplats.AutoSize = true;
            this.lblSlutHållplats.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlutHållplats.Location = new System.Drawing.Point(304, 196);
            this.lblSlutHållplats.Name = "lblSlutHållplats";
            this.lblSlutHållplats.Size = new System.Drawing.Size(323, 31);
            this.lblSlutHållplats.TabIndex = 5;
            this.lblSlutHållplats.Text = "Den valda slut hållplatsen";
            this.lblSlutHållplats.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(507, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Zonpriser";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(507, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "Zon A: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(507, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 31);
            this.label5.TabIndex = 1;
            this.label5.Text = "Zon B: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(507, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 31);
            this.label6.TabIndex = 1;
            this.label6.Text = "Zon C: ";
            // 
            // lblZonAPris
            // 
            this.lblZonAPris.AutoSize = true;
            this.lblZonAPris.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZonAPris.Location = new System.Drawing.Point(607, 49);
            this.lblZonAPris.Name = "lblZonAPris";
            this.lblZonAPris.Size = new System.Drawing.Size(29, 31);
            this.lblZonAPris.TabIndex = 1;
            this.lblZonAPris.Text = "0";
            // 
            // lblZonBPris
            // 
            this.lblZonBPris.AutoSize = true;
            this.lblZonBPris.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZonBPris.Location = new System.Drawing.Point(607, 85);
            this.lblZonBPris.Name = "lblZonBPris";
            this.lblZonBPris.Size = new System.Drawing.Size(29, 31);
            this.lblZonBPris.TabIndex = 1;
            this.lblZonBPris.Text = "0";
            // 
            // lblZonCPris
            // 
            this.lblZonCPris.AutoSize = true;
            this.lblZonCPris.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZonCPris.Location = new System.Drawing.Point(607, 123);
            this.lblZonCPris.Name = "lblZonCPris";
            this.lblZonCPris.Size = new System.Drawing.Size(29, 31);
            this.lblZonCPris.TabIndex = 1;
            this.lblZonCPris.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(90, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 55);
            this.label7.TabIndex = 6;
            this.label7.Text = "BUSSAB";
            // 
            // lblStartZon
            // 
            this.lblStartZon.AutoSize = true;
            this.lblStartZon.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartZon.Location = new System.Drawing.Point(124, 246);
            this.lblStartZon.Name = "lblStartZon";
            this.lblStartZon.Size = new System.Drawing.Size(72, 31);
            this.lblStartZon.TabIndex = 7;
            this.lblStartZon.Text = "ZON";
            this.lblStartZon.Visible = false;
            // 
            // lblSlutZon
            // 
            this.lblSlutZon.AutoSize = true;
            this.lblSlutZon.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlutZon.Location = new System.Drawing.Point(388, 249);
            this.lblSlutZon.Name = "lblSlutZon";
            this.lblSlutZon.Size = new System.Drawing.Size(72, 31);
            this.lblSlutZon.TabIndex = 7;
            this.lblSlutZon.Text = "ZON";
            this.lblSlutZon.Visible = false;
            // 
            // lblStartZonfast
            // 
            this.lblStartZonfast.AutoSize = true;
            this.lblStartZonfast.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartZonfast.Location = new System.Drawing.Point(42, 246);
            this.lblStartZonfast.Name = "lblStartZonfast";
            this.lblStartZonfast.Size = new System.Drawing.Size(76, 31);
            this.lblStartZonfast.TabIndex = 5;
            this.lblStartZonfast.Text = "Zon: ";
            this.lblStartZonfast.Visible = false;
            // 
            // lblSlutZonfast
            // 
            this.lblSlutZonfast.AutoSize = true;
            this.lblSlutZonfast.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlutZonfast.Location = new System.Drawing.Point(306, 249);
            this.lblSlutZonfast.Name = "lblSlutZonfast";
            this.lblSlutZonfast.Size = new System.Drawing.Size(76, 31);
            this.lblSlutZonfast.TabIndex = 5;
            this.lblSlutZonfast.Text = "Zon: ";
            this.lblSlutZonfast.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSlutZon);
            this.Controls.Add(this.lblStartZon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblSlutHållplats);
            this.Controls.Add(this.lblZonCPris);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblZonBPris);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblZonAPris);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSlutZonfast);
            this.Controls.Add(this.lblStartZonfast);
            this.Controls.Add(this.lblStartHållplats);
            this.Controls.Add(this.cbHållplats2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbHållplats1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "BussAB";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Label lblStartHållplats;
        private System.Windows.Forms.Label lblSlutHållplats;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblZonAPris;
        private System.Windows.Forms.Label lblZonBPris;
        private System.Windows.Forms.Label lblZonCPris;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblStartZon;
        private System.Windows.Forms.Label lblSlutZon;
        private System.Windows.Forms.Label lblStartZonfast;
        private System.Windows.Forms.Label lblSlutZonfast;
    }
}

