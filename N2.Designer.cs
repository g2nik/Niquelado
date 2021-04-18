
namespace Niquelado
{
    partial class N2
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
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAsign = new System.Windows.Forms.Button();
            this.txtTabCod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTabSearch = new System.Windows.Forms.TextBox();
            this.txtCodes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDelete
            // 
            this.txtDelete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelete.Location = new System.Drawing.Point(12, 33);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(149, 38);
            this.txtDelete.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(181, 33);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 38);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Borrar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cantidad de espacios a borrar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tabulaciones hasta codigo";
            // 
            // btnAsign
            // 
            this.btnAsign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsign.Location = new System.Drawing.Point(12, 188);
            this.btnAsign.Name = "btnAsign";
            this.btnAsign.Size = new System.Drawing.Size(301, 38);
            this.btnAsign.TabIndex = 4;
            this.btnAsign.Text = "Asignar";
            this.btnAsign.UseVisualStyleBackColor = true;
            this.btnAsign.Click += new System.EventHandler(this.btnAsign_Click);
            // 
            // txtTabCod
            // 
            this.txtTabCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTabCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTabCod.Location = new System.Drawing.Point(12, 138);
            this.txtTabCod.Name = "txtTabCod";
            this.txtTabCod.Size = new System.Drawing.Size(136, 38);
            this.txtTabCod.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tabulaciones hasta buscar";
            // 
            // txtTabSearch
            // 
            this.txtTabSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTabSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTabSearch.Location = new System.Drawing.Point(177, 138);
            this.txtTabSearch.Name = "txtTabSearch";
            this.txtTabSearch.Size = new System.Drawing.Size(136, 38);
            this.txtTabSearch.TabIndex = 6;
            // 
            // txtCodes
            // 
            this.txtCodes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodes.Location = new System.Drawing.Point(389, 40);
            this.txtCodes.Multiline = true;
            this.txtCodes.Name = "txtCodes";
            this.txtCodes.Size = new System.Drawing.Size(383, 509);
            this.txtCodes.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(386, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Codigos tecnicos";
            // 
            // btnStop
            // 
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.ForeColor = System.Drawing.Color.Red;
            this.btnStop.Location = new System.Drawing.Point(12, 298);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(301, 38);
            this.btnStop.TabIndex = 10;
            this.btnStop.Text = "Parar";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // N2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCodes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTabSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAsign);
            this.Controls.Add(this.txtTabCod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtDelete);
            this.Name = "N2";
            this.Text = "N2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAsign;
        private System.Windows.Forms.TextBox txtTabCod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTabSearch;
        private System.Windows.Forms.TextBox txtCodes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStop;
    }
}