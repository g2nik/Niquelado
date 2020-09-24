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
    public partial class Form1 : Form
    {
        private Form activeForm = null;

        public static Color background = Color.White;
        public static Color elements = Color.FromArgb(240, 240, 240);
        public static Color font = Color.Black;

        public string[] delete = { "+N+N+", "[Garantia Fabrica: enviar piezas a Fabrica]" };
        public string[] deleteFrom = { "[FIL", "[|20" };

        public Form1()
        {
            InitializeComponent();
            OpenForm(new SMS(background, elements, font, delete, deleteFrom));
            ChangeTheme(background, elements, font);
        }

        public void Update()
        {
            delete = delete.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            deleteFrom = deleteFrom.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            for (int i = 0; i < delete.Length; i++) delete[i] = delete[i].Replace("\n", "").Replace("\r", "");
            for (int i = 0; i < deleteFrom.Length; i++) deleteFrom[i] = deleteFrom[i].Replace("\n", "").Replace("\r", "");
        }

        public void ChangeTheme(Color background, Color elements, Color font)
        {
            this.BackColor = background;

            this.panelMenu.BackColor = elements;
            this.btnMenuIPL.BackColor = elements;
            this.btnMenuSMS.BackColor = elements;
            this.btnMenuConfig.BackColor = elements;

            this.btnMenuIPL.ForeColor = font;
            this.btnMenuSMS.ForeColor = font;
            this.btnMenuConfig.ForeColor = font;
        }

        private string[] Clean(string[] array)
        {
            List<string> list = new List<string>(array);
            list.Remove("");
            return list.ToArray();
        }

        private void OpenSMS(object sender, EventArgs e)
        {
            OpenForm(new SMS(background, elements, font, delete, deleteFrom));
        }

        private void OpenIPL(object sender, EventArgs e)
        {
            OpenForm(new IPL(background, elements, font));
        }

        private void OpenConfig(object sender, EventArgs e)
        {
            OpenForm(new Config(background, elements, font, delete, deleteFrom));
        }

        private void OpenForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelForm.Controls.Add(childForm);
            panelForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
