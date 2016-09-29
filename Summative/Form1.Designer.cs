namespace Summative
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
            this.lake = new System.Windows.Forms.Label();
            this.sahil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lake
            // 
            this.lake.AutoSize = true;
            this.lake.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lake.Location = new System.Drawing.Point(22, 18);
            this.lake.Name = "lake";
            this.lake.Size = new System.Drawing.Size(691, 56);
            this.lake.TabIndex = 0;
            this.lake.Text = "Constellation: The Big Dipper   ";
            this.lake.Click += new System.EventHandler(this.lake_Click);
            // 
            // sahil
            // 
            this.sahil.AutoSize = true;
            this.sahil.Font = new System.Drawing.Font("Tekton Pro Ext", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sahil.Location = new System.Drawing.Point(12, 523);
            this.sahil.Name = "sahil";
            this.sahil.Size = new System.Drawing.Size(283, 39);
            this.sahil.TabIndex = 1;
            this.sahil.Text = "By: Sahil Patel   ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 584);
            this.Controls.Add(this.sahil);
            this.Controls.Add(this.lake);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Constellation: The Big Dipper ";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lake;
        private System.Windows.Forms.Label sahil;
    }
}

