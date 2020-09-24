using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Niquelado
{
    public partial class Config : Form
    {
        private Color background;
        private Color elements;
        private Color font;

        public string[] delete;
        public string[] deleteFrom;

        public Config(Color background, Color elements, Color font, string[] delete, string[] deleteFrom)
        {
            InitializeComponent();
            ChangeTheme(background, elements, font);
            this.background = background;

            this.delete = delete;
            this.deleteFrom = deleteFrom;

            foreach (string s in delete) txtDelete.Text += s + Environment.NewLine;
            foreach (string s in deleteFrom) txtDeleteFrom.Text += s + Environment.NewLine;
        }

        private void ChangeTheme(Color background, Color elements, Color font)
        {
            BackColor = background;

            btnTheme.BackColor = elements;
            btnUpdate.BackColor = elements;
            txtDelete.BackColor = elements;
            txtDeleteFrom.BackColor = elements;

            btnTheme.ForeColor = font;
            btnUpdate.ForeColor = font;
            txtDelete.ForeColor = font;
            txtDeleteFrom.ForeColor = font;
            lbDelete.ForeColor = font;
            lbDeleteFrom.ForeColor = font;
        }

        private void UpdateTheme(object sender, EventArgs e)
        {
            if (background == Color.White)
            {
                background = Color.FromArgb(30, 40, 50);
                elements = Color.FromArgb(40, 50, 60);
                font = Color.FromArgb(24, 237, 163);
            }
            else
            {
                background = Color.White;
                elements = Color.FromArgb(240, 240, 240);
                font = Color.Black;
            }

            ChangeTheme(background, elements, font);

            Form1.background = background;
            Form1.elements = elements;
            Form1.font = font;

            Program.Form.ChangeTheme(background, elements, font);
        }

        private void UpdateExpressions(object sender, EventArgs e)
        {
            Program.Form.delete = txtDelete.Text.Split('\n');
            Program.Form.deleteFrom = txtDeleteFrom.Text.Split('\n');
            Program.Form.Update();
        }
    }
}
