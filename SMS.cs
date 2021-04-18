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

        public SMS(Color background, Color elements, Color font, string[] delete, string[] deleteFrom)
        {
            InitializeComponent();
            ChageTheme(background, elements, font);
        }

        private void ChageTheme(Color background, Color elements, Color font)
        {
            this.BackColor = background;

            this.btnNickel.BackColor = elements;

            this.btnNickel.ForeColor = font;
        }

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

        public static void Niquel()
        {

            try
            {
                string text = Clipboard.GetText();
                string output = "";
                string office = "";
                string atm = "";
                string address = "";
                string pass = "";
                string motive = "";

                string[] motives = { "Unidad de ingresos", "Unidad de billetes", "Unidad de tarjetas", "Unidad de libretas", "Cajero fuera de servicio" };
                string[] toDelete = { "+N+N+", "+N+N+S", "**externalizada**", "**PRIORIZAR**", "***TRASPASADA***", "+N+S+", "+N+S", "" };

                string n = Environment.NewLine;

                string copied = text;
                output = copied.Replace("  ", ""); //Borra espacios dobles
                output = output.Replace("\t", ""); //Borra tabulaciones
                output = output.Replace("Definir en texto completamente CAUSA-SINTOMA-ACCION , fotografías y/o VIDEOS.", ""); //Borra tabulaciones
                output = output.Substring(output.IndexOf("[")); //Borra la parafernalia del principio hasta el primer [
                for (int i = 0; i <= motives.Length - 1; i++) if (output.Contains(motives[i])) motive = motives[i]; //Obtiene el motivo de porque el cajero esta caido
                atm = output.Substring(1, 5); //Obtiene el cajero
                office = output.Substring(8, 4); //Obtiene la oficina
                output = output.Substring(output.IndexOf("CAIXABANK")); //Borra hasta CAIXABANK
                address = output.Substring(output.IndexOf(office) + 5, output.IndexOf("+") - output.IndexOf(office) - 5); //Obtiene la direccióon
                output = output.Substring(output.IndexOf("+"), output.IndexOf("[") - output.IndexOf("+")); //Borra la dirección y todo despues de la pass
                for (int i = 0; i < toDelete.Length - 1; i++) output = output.Replace(toDelete[i], ""); //Borra todos los elementos que se hallen en toDelete
                pass = output.Replace("\n", ""); //Obtiene la pass

                string final = address + n +
                    "Of: " + office + n +
                    "Cajero: " + atm + n +
                    pass + n +
                    motive;

                Clipboard.SetText(final);
                SendKeys.SendWait("%{Tab}");
                System.Threading.Thread.Sleep(50);
                SendKeys.Send("^{v}");
                System.Threading.Thread.Sleep(50);
                SendKeys.SendWait("{Tab}");
                SendKeys.SendWait("{Tab}");
                SendKeys.SendWait("{Tab}");
                SendKeys.SendWait("{Tab}");
                SendKeys.SendWait("{Tab}");
                SendKeys.SendWait("{Tab}");
                SendKeys.SendWait("{Tab}");
                SendKeys.Send("{Enter}");
                SendKeys.Send("{Enter}");
                System.Threading.Thread.Sleep(1000);
                SendKeys.SendWait("^{F4}");
            }
            catch
            {
            }
        }

        private void btnNickel_Click(object sender, EventArgs e)
        {
            Niquel();
        }
    }
}
