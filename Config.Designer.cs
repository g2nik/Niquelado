namespace Niquelado
{
    partial class Config
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
            this.btnTheme = new System.Windows.Forms.Button();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.lbDelete = new System.Windows.Forms.Label();
            this.lbDeleteFrom = new System.Windows.Forms.Label();
            this.txtDeleteFrom = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTheme
            // 
            this.btnTheme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnTheme.FlatAppearance.BorderSize = 0;
            this.btnTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTheme.Location = new System.Drawing.Point(11, 478);
            this.btnTheme.Name = "btnTheme";
            this.btnTheme.Size = new System.Drawing.Size(760, 71);
            this.btnTheme.TabIndex = 2;
            this.btnTheme.Text = "CAMBIAR TEMA";
            this.btnTheme.UseVisualStyleBackColor = false;
            this.btnTheme.Click += new System.EventHandler(this.UpdateTheme);
            // 
            // txtDelete
            // 
            this.txtDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtDelete.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelete.Location = new System.Drawing.Point(13, 43);
            this.txtDelete.Multiline = true;
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(759, 130);
            this.txtDelete.TabIndex = 3;
            // 
            // lbDelete
            // 
            this.lbDelete.AutoSize = true;
            this.lbDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDelete.Location = new System.Drawing.Point(12, 9);
            this.lbDelete.Name = "lbDelete";
            this.lbDelete.Size = new System.Drawing.Size(414, 31);
            this.lbDelete.TabIndex = 4;
            this.lbDelete.Text = "Borrar las siguientes expresiones";
            // 
            // lbDeleteFrom
            // 
            this.lbDeleteFrom.AutoSize = true;
            this.lbDeleteFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDeleteFrom.Location = new System.Drawing.Point(11, 196);
            this.lbDeleteFrom.Name = "lbDeleteFrom";
            this.lbDeleteFrom.Size = new System.Drawing.Size(542, 31);
            this.lbDeleteFrom.TabIndex = 5;
            this.lbDeleteFrom.Text = "Borrar a partir de las siguientes expresiones";
            // 
            // txtDeleteFrom
            // 
            this.txtDeleteFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeleteFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtDeleteFrom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDeleteFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeleteFrom.Location = new System.Drawing.Point(11, 230);
            this.txtDeleteFrom.Multiline = true;
            this.txtDeleteFrom.Name = "txtDeleteFrom";
            this.txtDeleteFrom.Size = new System.Drawing.Size(759, 130);
            this.txtDeleteFrom.TabIndex = 6;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(11, 391);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(760, 71);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "ACTUALIZAR CONFIGURACIÓN";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.UpdateExpressions);
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtDeleteFrom);
            this.Controls.Add(this.lbDeleteFrom);
            this.Controls.Add(this.lbDelete);
            this.Controls.Add(this.txtDelete);
            this.Controls.Add(this.btnTheme);
            this.Name = "Config";
            this.Text = "Config";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTheme;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.Label lbDelete;
        private System.Windows.Forms.Label lbDeleteFrom;
        private System.Windows.Forms.TextBox txtDeleteFrom;
        private System.Windows.Forms.Button btnUpdate;
    }
}