﻿namespace OOAnalysOODesign
{
    partial class Huvudmeny
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Huvudmeny));
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
            this.lblStartPris = new System.Windows.Forms.Label();
            this.lblSlutPris = new System.Windows.Forms.Label();
            this.lblZonPrisStart = new System.Windows.Forms.Label();
            this.lblZonPrisSlut = new System.Windows.Forms.Label();
            this.lblBiljettpris = new System.Windows.Forms.Label();
            this.lblTotalPris = new System.Windows.Forms.Label();
            this.btnKöp = new System.Windows.Forms.Button();
            this.lblStartValuta = new System.Windows.Forms.Label();
            this.lblSlutValuta = new System.Windows.Forms.Label();
            this.lblTotalValuta = new System.Windows.Forms.Label();
            this.uppdateraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.regitreraKontoToolStripMenuItem,
            this.uppdateraToolStripMenuItem});
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
            this.lblSlutZon.Location = new System.Drawing.Point(388, 246);
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
            this.lblSlutZonfast.Location = new System.Drawing.Point(306, 246);
            this.lblSlutZonfast.Name = "lblSlutZonfast";
            this.lblSlutZonfast.Size = new System.Drawing.Size(76, 31);
            this.lblSlutZonfast.TabIndex = 5;
            this.lblSlutZonfast.Text = "Zon: ";
            this.lblSlutZonfast.Visible = false;
            // 
            // lblStartPris
            // 
            this.lblStartPris.AutoSize = true;
            this.lblStartPris.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartPris.Location = new System.Drawing.Point(42, 305);
            this.lblStartPris.Name = "lblStartPris";
            this.lblStartPris.Size = new System.Drawing.Size(69, 31);
            this.lblStartPris.TabIndex = 5;
            this.lblStartPris.Text = "Pris:";
            this.lblStartPris.Visible = false;
            // 
            // lblSlutPris
            // 
            this.lblSlutPris.AutoSize = true;
            this.lblSlutPris.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlutPris.Location = new System.Drawing.Point(306, 305);
            this.lblSlutPris.Name = "lblSlutPris";
            this.lblSlutPris.Size = new System.Drawing.Size(69, 31);
            this.lblSlutPris.TabIndex = 5;
            this.lblSlutPris.Text = "Pris:";
            this.lblSlutPris.Visible = false;
            // 
            // lblZonPrisStart
            // 
            this.lblZonPrisStart.AutoSize = true;
            this.lblZonPrisStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZonPrisStart.Location = new System.Drawing.Point(124, 305);
            this.lblZonPrisStart.Name = "lblZonPrisStart";
            this.lblZonPrisStart.Size = new System.Drawing.Size(78, 31);
            this.lblZonPrisStart.TabIndex = 5;
            this.lblZonPrisStart.Text = "PRIS";
            this.lblZonPrisStart.Visible = false;
            // 
            // lblZonPrisSlut
            // 
            this.lblZonPrisSlut.AutoSize = true;
            this.lblZonPrisSlut.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZonPrisSlut.Location = new System.Drawing.Point(388, 305);
            this.lblZonPrisSlut.Name = "lblZonPrisSlut";
            this.lblZonPrisSlut.Size = new System.Drawing.Size(78, 31);
            this.lblZonPrisSlut.TabIndex = 7;
            this.lblZonPrisSlut.Text = "PRIS";
            this.lblZonPrisSlut.Visible = false;
            // 
            // lblBiljettpris
            // 
            this.lblBiljettpris.AutoSize = true;
            this.lblBiljettpris.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiljettpris.Location = new System.Drawing.Point(42, 358);
            this.lblBiljettpris.Name = "lblBiljettpris";
            this.lblBiljettpris.Size = new System.Drawing.Size(247, 31);
            this.lblBiljettpris.TabIndex = 5;
            this.lblBiljettpris.Text = "Biljettpris för resan:";
            this.lblBiljettpris.Visible = false;
            // 
            // lblTotalPris
            // 
            this.lblTotalPris.AutoSize = true;
            this.lblTotalPris.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPris.Location = new System.Drawing.Point(306, 358);
            this.lblTotalPris.Name = "lblTotalPris";
            this.lblTotalPris.Size = new System.Drawing.Size(78, 31);
            this.lblTotalPris.TabIndex = 7;
            this.lblTotalPris.Text = "PRIS";
            this.lblTotalPris.Visible = false;
            // 
            // btnKöp
            // 
            this.btnKöp.Location = new System.Drawing.Point(513, 347);
            this.btnKöp.Name = "btnKöp";
            this.btnKöp.Size = new System.Drawing.Size(123, 42);
            this.btnKöp.TabIndex = 8;
            this.btnKöp.Text = "Bekräfta köp";
            this.btnKöp.UseVisualStyleBackColor = true;
            this.btnKöp.Visible = false;
            this.btnKöp.Click += new System.EventHandler(this.btnKöp_Click);
            // 
            // lblStartValuta
            // 
            this.lblStartValuta.AutoSize = true;
            this.lblStartValuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartValuta.Location = new System.Drawing.Point(208, 305);
            this.lblStartValuta.Name = "lblStartValuta";
            this.lblStartValuta.Size = new System.Drawing.Size(41, 31);
            this.lblStartValuta.TabIndex = 5;
            this.lblStartValuta.Text = "Kr";
            this.lblStartValuta.Visible = false;
            // 
            // lblSlutValuta
            // 
            this.lblSlutValuta.AutoSize = true;
            this.lblSlutValuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlutValuta.Location = new System.Drawing.Point(472, 305);
            this.lblSlutValuta.Name = "lblSlutValuta";
            this.lblSlutValuta.Size = new System.Drawing.Size(41, 31);
            this.lblSlutValuta.TabIndex = 5;
            this.lblSlutValuta.Text = "Kr";
            this.lblSlutValuta.Visible = false;
            // 
            // lblTotalValuta
            // 
            this.lblTotalValuta.AutoSize = true;
            this.lblTotalValuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValuta.Location = new System.Drawing.Point(396, 358);
            this.lblTotalValuta.Name = "lblTotalValuta";
            this.lblTotalValuta.Size = new System.Drawing.Size(41, 31);
            this.lblTotalValuta.TabIndex = 5;
            this.lblTotalValuta.Text = "Kr";
            this.lblTotalValuta.Visible = false;
            // 
            // uppdateraToolStripMenuItem
            // 
            this.uppdateraToolStripMenuItem.Name = "uppdateraToolStripMenuItem";
            this.uppdateraToolStripMenuItem.Size = new System.Drawing.Size(115, 19);
            this.uppdateraToolStripMenuItem.Text = "Uppdatera";
            this.uppdateraToolStripMenuItem.Click += new System.EventHandler(this.uppdateraToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKöp);
            this.Controls.Add(this.lblZonPrisSlut);
            this.Controls.Add(this.lblSlutZon);
            this.Controls.Add(this.lblTotalPris);
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
            this.Controls.Add(this.lblSlutPris);
            this.Controls.Add(this.lblSlutZonfast);
            this.Controls.Add(this.lblTotalValuta);
            this.Controls.Add(this.lblSlutValuta);
            this.Controls.Add(this.lblStartValuta);
            this.Controls.Add(this.lblZonPrisStart);
            this.Controls.Add(this.lblStartPris);
            this.Controls.Add(this.lblStartZonfast);
            this.Controls.Add(this.lblBiljettpris);
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
        private System.Windows.Forms.Label lblStartPris;
        private System.Windows.Forms.Label lblSlutPris;
        private System.Windows.Forms.Label lblZonPrisStart;
        private System.Windows.Forms.Label lblZonPrisSlut;
        private System.Windows.Forms.Label lblBiljettpris;
        private System.Windows.Forms.Label lblTotalPris;
        private System.Windows.Forms.Button btnKöp;
        private System.Windows.Forms.Label lblStartValuta;
        private System.Windows.Forms.Label lblSlutValuta;
        private System.Windows.Forms.Label lblTotalValuta;
        private System.Windows.Forms.ToolStripMenuItem uppdateraToolStripMenuItem;
    }
}

