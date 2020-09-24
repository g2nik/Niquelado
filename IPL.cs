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
    public partial class IPL : Form
    {
        string final = "";
        string output = "";

        public IPL(Color background, Color elements, Color font)
        {
            InitializeComponent();
            ChageTheme(background, elements, font);
        }

        private void ChageTheme(Color background, Color elements, Color font)
        {
            this.BackColor = background;

            this.btnNickel.BackColor = elements;
            this.txtFinal.BackColor = elements;

            this.btnNickel.ForeColor = font;
            this.txtFinal.ForeColor = font;
        }

        private void Nickel(object sender, EventArgs e)
        {
            try
            {
                final = Clipboard.GetText();
                output = final.Replace("\t", ",");
                txtFinal.Text = output;
                Clipboard.SetText(txtFinal.Text);
            }
            catch (Exception f)
            {
                MessageBox.Show("Error niquelando, asegurate que hayas copiado bien los números de los cajeros");
            }
        }        
    }
}
