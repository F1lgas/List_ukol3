namespace List_ukol3
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_a = new System.Windows.Forms.Button();
            this.button_e = new System.Windows.Forms.Button();
            this.button_i = new System.Windows.Forms.Button();
            this.button_o = new System.Windows.Forms.Button();
            this.button_u = new System.Windows.Forms.Button();
            this.button_y = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.vstup = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_a
            // 
            this.button_a.Enabled = false;
            this.button_a.Location = new System.Drawing.Point(67, 38);
            this.button_a.Name = "button_a";
            this.button_a.Size = new System.Drawing.Size(24, 23);
            this.button_a.TabIndex = 0;
            this.button_a.Text = "a";
            this.button_a.UseVisualStyleBackColor = true;
            this.button_a.Click += new System.EventHandler(this.button_a_Click);
            // 
            // button_e
            // 
            this.button_e.Enabled = false;
            this.button_e.Location = new System.Drawing.Point(97, 38);
            this.button_e.Name = "button_e";
            this.button_e.Size = new System.Drawing.Size(24, 23);
            this.button_e.TabIndex = 1;
            this.button_e.Text = "e";
            this.button_e.UseVisualStyleBackColor = true;
            this.button_e.Click += new System.EventHandler(this.button_a_Click);
            // 
            // button_i
            // 
            this.button_i.Enabled = false;
            this.button_i.Location = new System.Drawing.Point(127, 38);
            this.button_i.Name = "button_i";
            this.button_i.Size = new System.Drawing.Size(24, 23);
            this.button_i.TabIndex = 2;
            this.button_i.Text = "i";
            this.button_i.UseVisualStyleBackColor = true;
            this.button_i.Click += new System.EventHandler(this.button_a_Click);
            // 
            // button_o
            // 
            this.button_o.Enabled = false;
            this.button_o.Location = new System.Drawing.Point(157, 38);
            this.button_o.Name = "button_o";
            this.button_o.Size = new System.Drawing.Size(24, 23);
            this.button_o.TabIndex = 3;
            this.button_o.Text = "o";
            this.button_o.UseVisualStyleBackColor = true;
            this.button_o.Click += new System.EventHandler(this.button_a_Click);
            // 
            // button_u
            // 
            this.button_u.Enabled = false;
            this.button_u.Location = new System.Drawing.Point(187, 38);
            this.button_u.Name = "button_u";
            this.button_u.Size = new System.Drawing.Size(24, 23);
            this.button_u.TabIndex = 4;
            this.button_u.Text = "u";
            this.button_u.UseVisualStyleBackColor = true;
            this.button_u.Click += new System.EventHandler(this.button_a_Click);
            // 
            // button_y
            // 
            this.button_y.Enabled = false;
            this.button_y.Location = new System.Drawing.Point(217, 38);
            this.button_y.Name = "button_y";
            this.button_y.Size = new System.Drawing.Size(24, 23);
            this.button_y.TabIndex = 5;
            this.button_y.Text = "y";
            this.button_y.UseVisualStyleBackColor = true;
            this.button_y.Click += new System.EventHandler(this.button_a_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Uložit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vstup
            // 
            this.vstup.Location = new System.Drawing.Point(12, 12);
            this.vstup.Name = "vstup";
            this.vstup.Size = new System.Drawing.Size(229, 20);
            this.vstup.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Odstranit:";
            // 
            // reset
            // 
            this.reset.Enabled = false;
            this.reset.Location = new System.Drawing.Point(246, 38);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 9;
            this.reset.Text = "Resetovat";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 70);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vstup);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_y);
            this.Controls.Add(this.button_u);
            this.Controls.Add(this.button_o);
            this.Controls.Add(this.button_i);
            this.Controls.Add(this.button_e);
            this.Controls.Add(this.button_a);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "List_ukol3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_a;
        private System.Windows.Forms.Button button_e;
        private System.Windows.Forms.Button button_i;
        private System.Windows.Forms.Button button_o;
        private System.Windows.Forms.Button button_u;
        private System.Windows.Forms.Button button_y;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox vstup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reset;
    }
}

