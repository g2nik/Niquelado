namespace Niquelado
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelSubMenu = new System.Windows.Forms.Panel();
            this.btnN2 = new System.Windows.Forms.Button();
            this.btnMenuSMSOld = new System.Windows.Forms.Button();
            this.btnMenuConfig = new System.Windows.Forms.Button();
            this.btnMenuIPL = new System.Windows.Forms.Button();
            this.btnMenuSMS = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panelMenu.Controls.Add(this.panelSubMenu);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 561);
            this.panelMenu.TabIndex = 0;
            // 
            // panelSubMenu
            // 
            this.panelSubMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelSubMenu.Controls.Add(this.btnN2);
            this.panelSubMenu.Controls.Add(this.btnMenuSMSOld);
            this.panelSubMenu.Controls.Add(this.btnMenuConfig);
            this.panelSubMenu.Controls.Add(this.btnMenuIPL);
            this.panelSubMenu.Controls.Add(this.btnMenuSMS);
            this.panelSubMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSubMenu.Location = new System.Drawing.Point(0, 200);
            this.panelSubMenu.Name = "panelSubMenu";
            this.panelSubMenu.Size = new System.Drawing.Size(200, 361);
            this.panelSubMenu.TabIndex = 4;
            // 
            // btnN2
            // 
            this.btnN2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnN2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnN2.FlatAppearance.BorderSize = 0;
            this.btnN2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN2.Location = new System.Drawing.Point(0, 300);
            this.btnN2.Name = "btnN2";
            this.btnN2.Size = new System.Drawing.Size(200, 75);
            this.btnN2.TabIndex = 4;
            this.btnN2.Text = "N2";
            this.btnN2.UseVisualStyleBackColor = false;
            this.btnN2.Click += new System.EventHandler(this.btnN2_Click_1);
            // 
            // btnMenuSMSOld
            // 
            this.btnMenuSMSOld.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMenuSMSOld.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuSMSOld.FlatAppearance.BorderSize = 0;
            this.btnMenuSMSOld.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuSMSOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuSMSOld.Location = new System.Drawing.Point(0, 225);
            this.btnMenuSMSOld.Name = "btnMenuSMSOld";
            this.btnMenuSMSOld.Size = new System.Drawing.Size(200, 75);
            this.btnMenuSMSOld.TabIndex = 3;
            this.btnMenuSMSOld.Text = "SMS OLD";
            this.btnMenuSMSOld.UseVisualStyleBackColor = false;
            this.btnMenuSMSOld.Click += new System.EventHandler(this.OpenSMSOld);
            // 
            // btnMenuConfig
            // 
            this.btnMenuConfig.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMenuConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuConfig.FlatAppearance.BorderSize = 0;
            this.btnMenuConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuConfig.Location = new System.Drawing.Point(0, 150);
            this.btnMenuConfig.Name = "btnMenuConfig";
            this.btnMenuConfig.Size = new System.Drawing.Size(200, 75);
            this.btnMenuConfig.TabIndex = 2;
            this.btnMenuConfig.Text = "Config";
            this.btnMenuConfig.UseVisualStyleBackColor = false;
            this.btnMenuConfig.Click += new System.EventHandler(this.OpenConfig);
            // 
            // btnMenuIPL
            // 
            this.btnMenuIPL.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMenuIPL.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuIPL.FlatAppearance.BorderSize = 0;
            this.btnMenuIPL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuIPL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuIPL.Location = new System.Drawing.Point(0, 75);
            this.btnMenuIPL.Name = "btnMenuIPL";
            this.btnMenuIPL.Size = new System.Drawing.Size(200, 75);
            this.btnMenuIPL.TabIndex = 0;
            this.btnMenuIPL.Text = "IPL";
            this.btnMenuIPL.UseVisualStyleBackColor = false;
            this.btnMenuIPL.Click += new System.EventHandler(this.OpenIPL);
            // 
            // btnMenuSMS
            // 
            this.btnMenuSMS.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMenuSMS.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuSMS.FlatAppearance.BorderSize = 0;
            this.btnMenuSMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuSMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuSMS.Location = new System.Drawing.Point(0, 0);
            this.btnMenuSMS.Name = "btnMenuSMS";
            this.btnMenuSMS.Size = new System.Drawing.Size(200, 75);
            this.btnMenuSMS.TabIndex = 1;
            this.btnMenuSMS.Text = "SMS";
            this.btnMenuSMS.UseVisualStyleBackColor = false;
            this.btnMenuSMS.Click += new System.EventHandler(this.OpenSMS);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Transparent;
            this.panelLogo.Controls.Add(this.logo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 200);
            this.panelLogo.TabIndex = 3;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("logo.ErrorImage")));
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(200, 200);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(200, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(784, 561);
            this.panelForm.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Niquelado";
            this.panelMenu.ResumeLayout(false);
            this.panelSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnMenuIPL;
        private System.Windows.Forms.Button btnMenuSMS;
        private System.Windows.Forms.Button btnMenuConfig;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel panelSubMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnMenuSMSOld;
        private System.Windows.Forms.Button btnN2;
    }
}

