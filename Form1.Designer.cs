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
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tidtabelToolStripMenuItem,
            this.biljettprisToolStripMenuItem,
            this.loggaInToolStripMenuItem,
            this.regitreraKontoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(174, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(106, 225);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tidtabelToolStripMenuItem
            // 
            this.tidtabelToolStripMenuItem.Name = "tidtabelToolStripMenuItem";
            this.tidtabelToolStripMenuItem.Size = new System.Drawing.Size(93, 19);
            this.tidtabelToolStripMenuItem.Text = "Tidtabel";
            // 
            // biljettprisToolStripMenuItem
            // 
            this.biljettprisToolStripMenuItem.Name = "biljettprisToolStripMenuItem";
            this.biljettprisToolStripMenuItem.Size = new System.Drawing.Size(93, 19);
            this.biljettprisToolStripMenuItem.Text = "Biljettpris";
            // 
            // loggaInToolStripMenuItem
            // 
            this.loggaInToolStripMenuItem.Name = "loggaInToolStripMenuItem";
            this.loggaInToolStripMenuItem.Size = new System.Drawing.Size(93, 19);
            this.loggaInToolStripMenuItem.Text = "Logga in";
            // 
            // regitreraKontoToolStripMenuItem
            // 
            this.regitreraKontoToolStripMenuItem.Name = "regitreraKontoToolStripMenuItem";
            this.regitreraKontoToolStripMenuItem.Size = new System.Drawing.Size(93, 19);
            this.regitreraKontoToolStripMenuItem.Text = "Regitrera konto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tidtabelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biljettprisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loggaInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regitreraKontoToolStripMenuItem;
    }
}

