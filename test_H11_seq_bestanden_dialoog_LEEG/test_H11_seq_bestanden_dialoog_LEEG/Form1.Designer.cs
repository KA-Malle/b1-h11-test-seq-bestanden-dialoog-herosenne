namespace test_H11_seq_bestanden_dialoog_LEEG
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
            this.btnSluiten = new System.Windows.Forms.Button();
            this.btnVerwerken = new System.Windows.Forms.Button();
            this.txtResultaat = new System.Windows.Forms.TextBox();
            this.btnGenereer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSluiten
            // 
            this.btnSluiten.Location = new System.Drawing.Point(445, 351);
            this.btnSluiten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSluiten.Name = "btnSluiten";
            this.btnSluiten.Size = new System.Drawing.Size(85, 28);
            this.btnSluiten.TabIndex = 6;
            this.btnSluiten.Text = "&Sluiten";
            this.btnSluiten.UseVisualStyleBackColor = true;
            this.btnSluiten.Click += new System.EventHandler(this.btnSluiten_Click);
            // 
            // btnVerwerken
            // 
            this.btnVerwerken.Location = new System.Drawing.Point(332, 351);
            this.btnVerwerken.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVerwerken.Name = "btnVerwerken";
            this.btnVerwerken.Size = new System.Drawing.Size(108, 28);
            this.btnVerwerken.TabIndex = 5;
            this.btnVerwerken.Text = "&Verwerken";
            this.btnVerwerken.UseVisualStyleBackColor = true;
            this.btnVerwerken.Click += new System.EventHandler(this.btnVerwerken_Click);
            // 
            // txtResultaat
            // 
            this.txtResultaat.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultaat.Location = new System.Drawing.Point(12, 11);
            this.txtResultaat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtResultaat.Multiline = true;
            this.txtResultaat.Name = "txtResultaat";
            this.txtResultaat.Size = new System.Drawing.Size(517, 322);
            this.txtResultaat.TabIndex = 4;
            // 
            // btnGenereer
            // 
            this.btnGenereer.Location = new System.Drawing.Point(12, 351);
            this.btnGenereer.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenereer.Name = "btnGenereer";
            this.btnGenereer.Size = new System.Drawing.Size(100, 28);
            this.btnGenereer.TabIndex = 7;
            this.btnGenereer.Text = "Genereer";
            this.btnGenereer.UseVisualStyleBackColor = true;
            this.btnGenereer.Click += new System.EventHandler(this.btnGenereer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 392);
            this.Controls.Add(this.btnSluiten);
            this.Controls.Add(this.btnVerwerken);
            this.Controls.Add(this.txtResultaat);
            this.Controls.Add(this.btnGenereer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnSluiten;
        internal System.Windows.Forms.Button btnVerwerken;
        internal System.Windows.Forms.TextBox txtResultaat;
        internal System.Windows.Forms.Button btnGenereer;
    }
}

