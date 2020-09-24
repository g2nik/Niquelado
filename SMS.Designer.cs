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
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.btnNickel = new System.Windows.Forms.Button();
            this.btnPriorize = new System.Windows.Forms.Button();
            this.btnUnpriorize = new System.Windows.Forms.Button();
            this.btnLow = new System.Windows.Forms.Button();
            this.btnMid = new System.Windows.Forms.Button();
            this.btnHigh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFinal
            // 
            this.txtFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtFinal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFinal.Location = new System.Drawing.Point(13, 13);
            this.txtFinal.Multiline = true;
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(759, 130);
            this.txtFinal.TabIndex = 0;
            // 
            // btnNickel
            // 
            this.btnNickel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNickel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnNickel.FlatAppearance.BorderSize = 0;
            this.btnNickel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNickel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNickel.Location = new System.Drawing.Point(12, 167);
            this.btnNickel.Name = "btnNickel";
            this.btnNickel.Size = new System.Drawing.Size(760, 158);
            this.btnNickel.TabIndex = 1;
            this.btnNickel.Text = "NIQUELAR";
            this.btnNickel.UseVisualStyleBackColor = false;
            this.btnNickel.Click += new System.EventHandler(this.Nickel);
            // 
            // btnPriorize
            // 
            this.btnPriorize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPriorize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnPriorize.FlatAppearance.BorderSize = 0;
            this.btnPriorize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPriorize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPriorize.Location = new System.Drawing.Point(12, 331);
            this.btnPriorize.Name = "btnPriorize";
            this.btnPriorize.Size = new System.Drawing.Size(375, 50);
            this.btnPriorize.TabIndex = 2;
            this.btnPriorize.Text = "PRIORIZAR";
            this.btnPriorize.UseVisualStyleBackColor = false;
            this.btnPriorize.Click += new System.EventHandler(this.Priorize);
            // 
            // btnUnpriorize
            // 
            this.btnUnpriorize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnpriorize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnUnpriorize.FlatAppearance.BorderSize = 0;
            this.btnUnpriorize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnpriorize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnpriorize.Location = new System.Drawing.Point(398, 331);
            this.btnUnpriorize.Name = "btnUnpriorize";
            this.btnUnpriorize.Size = new System.Drawing.Size(375, 50);
            this.btnUnpriorize.TabIndex = 3;
            this.btnUnpriorize.Text = "NO PRIORIZAR";
            this.btnUnpriorize.UseVisualStyleBackColor = false;
            this.btnUnpriorize.Click += new System.EventHandler(this.Unpriorize);
            // 
            // btnLow
            // 
            this.btnLow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnLow.FlatAppearance.BorderSize = 0;
            this.btnLow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLow.Location = new System.Drawing.Point(13, 499);
            this.btnLow.Name = "btnLow";
            this.btnLow.Size = new System.Drawing.Size(759, 50);
            this.btnLow.TabIndex = 4;
            this.btnLow.Text = "BAJA";
            this.btnLow.UseVisualStyleBackColor = false;
            this.btnLow.Click += new System.EventHandler(this.Low);
            // 
            // btnMid
            // 
            this.btnMid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnMid.FlatAppearance.BorderSize = 0;
            this.btnMid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMid.Location = new System.Drawing.Point(13, 443);
            this.btnMid.Name = "btnMid";
            this.btnMid.Size = new System.Drawing.Size(759, 50);
            this.btnMid.TabIndex = 5;
            this.btnMid.Text = "MEDIA";
            this.btnMid.UseVisualStyleBackColor = false;
            this.btnMid.Click += new System.EventHandler(this.Mid);
            // 
            // btnHigh
            // 
            this.btnHigh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHigh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnHigh.FlatAppearance.BorderSize = 0;
            this.btnHigh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHigh.Location = new System.Drawing.Point(13, 387);
            this.btnHigh.Name = "btnHigh";
            this.btnHigh.Size = new System.Drawing.Size(760, 50);
            this.btnHigh.TabIndex = 6;
            this.btnHigh.Text = "ALTA";
            this.btnHigh.UseVisualStyleBackColor = false;
            this.btnHigh.Click += new System.EventHandler(this.High);
            // 
            // SMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnHigh);
            this.Controls.Add(this.btnMid);
            this.Controls.Add(this.btnLow);
            this.Controls.Add(this.btnUnpriorize);
            this.Controls.Add(this.btnPriorize);
            this.Controls.Add(this.btnNickel);
            this.Controls.Add(this.txtFinal);
            this.Name = "SMS";
            this.Text = "SMS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Button btnNickel;
        private System.Windows.Forms.Button btnPriorize;
        private System.Windows.Forms.Button btnUnpriorize;
        private System.Windows.Forms.Button btnLow;
        private System.Windows.Forms.Button btnMid;
        private System.Windows.Forms.Button btnHigh;
    }
}