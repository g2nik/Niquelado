namespace Niquelado
{
    partial class SMS
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
            this.btnNickel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNickel
            // 
            this.btnNickel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNickel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnNickel.FlatAppearance.BorderSize = 0;
            this.btnNickel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNickel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNickel.Location = new System.Drawing.Point(12, 24);
            this.btnNickel.Margin = new System.Windows.Forms.Padding(15);
            this.btnNickel.Name = "btnNickel";
            this.btnNickel.Size = new System.Drawing.Size(760, 513);
            this.btnNickel.TabIndex = 8;
            this.btnNickel.Text = "NIQUELAR";
            this.btnNickel.UseVisualStyleBackColor = false;
            this.btnNickel.Click += new System.EventHandler(this.btnNickel_Click);
            // 
            // SMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnNickel);
            this.Name = "SMS";
            this.Text = "SMS";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNickel;
    }
}