namespace OOAnalysOODesign
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSkapaAnvändarnamn = new System.Windows.Forms.TextBox();
            this.txtSkapaLösenord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegistreraHär = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrera konto";
            // 
            // txtSkapaAnvändarnamn
            // 
            this.txtSkapaAnvändarnamn.Location = new System.Drawing.Point(77, 110);
            this.txtSkapaAnvändarnamn.Margin = new System.Windows.Forms.Padding(2);
            this.txtSkapaAnvändarnamn.Name = "txtSkapaAnvändarnamn";
            this.txtSkapaAnvändarnamn.Size = new System.Drawing.Size(132, 20);
            this.txtSkapaAnvändarnamn.TabIndex = 1;
            // 
            // txtSkapaLösenord
            // 
            this.txtSkapaLösenord.Location = new System.Drawing.Point(77, 190);
            this.txtSkapaLösenord.Margin = new System.Windows.Forms.Padding(2);
            this.txtSkapaLösenord.Name = "txtSkapaLösenord";
            this.txtSkapaLösenord.PasswordChar = '*';
            this.txtSkapaLösenord.Size = new System.Drawing.Size(106, 20);
            this.txtSkapaLösenord.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Skapa ett användarnamn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Skapa ett lösenord";
            // 
            // btnRegistreraHär
            // 
            this.btnRegistreraHär.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistreraHär.Location = new System.Drawing.Point(459, 282);
            this.btnRegistreraHär.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistreraHär.Name = "btnRegistreraHär";
            this.btnRegistreraHär.Size = new System.Drawing.Size(96, 52);
            this.btnRegistreraHär.TabIndex = 5;
            this.btnRegistreraHär.Text = "Registrera här";
            this.btnRegistreraHär.UseVisualStyleBackColor = true;
            this.btnRegistreraHär.Click += new System.EventHandler(this.btnRegistreraHär_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnRegistreraHär);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSkapaLösenord);
            this.Controls.Add(this.txtSkapaAnvändarnamn);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form5";
            this.Text = "Registrera konto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSkapaAnvändarnamn;
        private System.Windows.Forms.TextBox txtSkapaLösenord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegistreraHär;
    }
}