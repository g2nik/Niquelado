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
    public partial class SMS : Form
    {
        string n = Environment.NewLine;

        string final = "";
        string header = "";
        string output = "";

        string[] delete;
        string[] deleteFrom;

        public SMS(Color background, Color elements, Color font, string[] delete, string[] deleteFrom)
        {
            InitializeComponent();
            ChageTheme(background, elements, font);
            this.delete = delete;
            this.deleteFrom = deleteFrom;
        }

        private void ChageTheme(Color background, Color elements, Color font)
        {
            this.BackColor = background;

            this.btnNickel.BackColor = elements;
            this.btnPriorize.BackColor = elements;
            this.btnUnpriorize.BackColor = elements;
            this.btnHigh.BackColor = elements;
            this.btnMid.BackColor = elements;
            this.btnLow.BackColor = elements;
            this.txtFinal.BackColor = elements;

            this.btnNickel.ForeColor = font;
            this.btnPriorize.ForeColor = font;
            this.btnUnpriorize.ForeColor = font;
            this.btnHigh.ForeColor = font;
            this.btnMid.ForeColor = font;
            this.btnLow.ForeColor = font;
            this.txtFinal.ForeColor = font;
        }

        private void Process()
        {
            try
            {
                final = Clipboard.GetText();

                final = DeleteSpace(final);
                final = DeleteStart(final);

                foreach (string s in delete) final = XDelete(final, s);
                foreach (string s in deleteFrom) final = DeleteEnd(final, s);

                final = final.Trim();

                Join();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error niquelando, asegurate que hayas copiado bien el SMS");
            }
        }

        private void Join()
        {
            try
            {
                output = header == "" ? header + final : header + n + final;

                txtFinal.Text = output;

                Clipboard.SetText(txtFinal.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error niquelando, asegurate que hayas copiado bien el SMS");
            }
        }

        private void Nickel(object sender, EventArgs e)
        {
            Process();
        }

        private void Priorize(object sender, EventArgs e)
        {
            header = "** PRIORIZAR **";
            Join();
        }

        private void Unpriorize(object sender, EventArgs e)
        {
            header = "";
            Join();
        }

        private void Low(object sender, EventArgs e)
        {
            header = "** PRIORIDAD BAJA **";
            Join();
        }

        private void Mid(object sender, EventArgs e)
        {
            header = "** PRIORIDAD MEDIA **";
            Join();
        }

        private void High(object sender, EventArgs e)
        {
            header = "** PRIORIDAD ALTA **";
            Join();
        }

        ///////////////////////////////////////////////////////////////////////////////

        public static string DeleteSpace(string text)
        {
            for (int i = 0; i < text.Length - 1; i++)
            {
                string check = text.Substring(i, 1);
                string check2 = text.Substring(i + 1, 1);

                if (check == " " && check2 == " ")
                {
                    text = text.Substring(0, i) + text.Substring(i + 1);
                    i = 0;
                }
            }
            return text;
        }

        public static bool TextCoincides(string text, string toCompare, int index)
        {
            int coincidences = 0;
            for (int i = 0; i < toCompare.Length; i++)
            {
                if (text.Substring(index + i, 1) == toCompare.Substring(i, 1)) coincidences++;
            }
            return coincidences == toCompare.Length;
        }

        public static string XDelete(string text, string toDelete)
        {
            bool found = false;
            string result = "";

            for (int i = 0; i < text.Length - toDelete.Length && !found; i++)
            {
                string check = text.Substring(i, toDelete.Length);
                if (check == toDelete)
                {
                    found = true;
                    result = text.Substring(0, i) + text.Substring(i + toDelete.Length);
                }
            }

            return !found ? text : result;
        }

        public static string DeleteText(string text, string toDelete)
        {
            bool exit = false;
            bool coincidence = false;
            int index = 0;

            for (int i = 0; i < text.Length - 1 && !exit; i++)
            {
                if (i == text.Length - toDelete.Length) exit = true;

                if (TextCoincides(text, toDelete, i))
                {
                    index = i;
                    exit = true;
                    coincidence = true;
                }
            }
            if (coincidence) { return text.Substring(0, index) + text.Substring(index + toDelete.Length); }
            else { return text; }
        }

        public static string DeleteStart(string text)
        {
            for (int i = 0; i < text.Length - 4; i++)
            {
                string check = text.Substring(i, 4);
                if (check == "BANK") text = text.Substring(i + 5);
            }
            return text;
        }

        public static string DeleteEnd(string text, string checkPoint)
        {
            for (int i = 0; i < text.Length - checkPoint.Length; i++)
            {
                string check = text.Substring(i, checkPoint.Length);
                if (check == checkPoint) text = text.Substring(0, i);
            }
            return text;
        }

        public static string Divide(string text)
        {
            string n = Environment.NewLine;
            int length = 11;
            int index = 0;
            for (int i = 0; i < text.Length - 5; i++)
            {
                string check = text.Substring(i, 5).ToUpper();
                if (check == "PASS ") index = i;
                if (check == "PASS:") { index = i; length = 12; }
            }
            return text.Substring(0, index) + n + text.Substring(index, length) + n + text.Substring(index + length);
        }

        public static bool WordInText(string text, string word)
        {
            bool exit = false;
            bool coincidence = false;
            int index = 0;

            for (int i = 0; i < text.Length - 1 && !exit; i++)
            {
                if (i == text.Length - word.Length) exit = true;

                if (TextCoincides(text, word, i))
                {
                    index = i;
                    exit = true;
                    coincidence = true;
                }
            }
            return coincidence;
        }
    }
}
