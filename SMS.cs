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

        public static bool TextCoincides(string text, string toCompare, int index)
        {
            int coincidences = 0;
            for (int i = 0; i < toCompare.Length; i++)
            {
                if (text.Substring(index + i, 1) == toCompare.Substring(i, 1)) coincidences++;
            }
            return coincidences == toCompare.Length;
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
            for (int i = 0; i < text.Length - 4; i++)
            {
                string check = text.Substring(i, 4);
                if (check == checkPoint) text = text.Substring(0, i);
            }
            return text;
        }

        public static string Divide(string text)
        {
            string[] unidades = { "ingresos", "billetes", "tarjetas", "libretas", "fuera de servicio" };
            int length = 11;
            int index = 0;
            for (int i = 0; i < text.Length - 5; i++)
            {
                string check = text.Substring(i, 5).ToUpper();
                if (check == "PASS ") index = i;
                if (check == "PASS:") { index = i; length = 12; }
                if (check == "PASS:\t") { index = i; }
                if (check == "PASS\t") { index = i; }
            }
            return text.Substring(0, index) + "\n" + text.Substring(index, length + 2) + prueba(text, unidades);
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

        public static string prueba(string text, string[] unidades)
        {

            string text2 = "Hola";

            for (int i = 0; i <= unidades.Length - 1; i++)
            {

                bool unidad = text.Contains(unidades[i]);
                if (unidad)
                {
                    if (unidades[i] == "fuera de servicio")
                    {
                        text2 = " Cajero " + unidades[i];
                    }
                    else
                    {
                        text2 = " Unidad de " + unidades[i];
                    }
                }
            }
            return text2;

        }

        public static void Niquel()
        {
            String text = Clipboard.GetText();


            //string input = Console.ReadLine();
            //while (!string.IsNullOrEmpty(input)) text += input;

            //DeleteSpace borra cualquier espacio que este despues de otro espacio
            text = DeleteSpace(text);

            //DeleteText borra el texto entre comillas del mensaje, si no lo encuentra lo deja tal cual
            text = DeleteText(text, "+N+N+");

            //DeleteStart borra toda la parafernalia del principio hasta el "CAIXABANK OF."
            text = DeleteStart(text);

            //DeleteEnd borra todo lo que encuentra a partir del texto especificado entre comillas
            text = Divide(text);
            text = DeleteEnd(text, "[SIN");


            //Esta parte añade "** PRIORIZAR **" al principio del mensaje si ve que no es ingresos
            //bool ingresos = WordInText(text, "ingresos") || WordInText(text, "INGRESOS");
            //if (!ingresos) text = "** PRIORIZAR **" + "\n" + text;

            text = text.Replace("\t", " ");
            Clipboard.SetText(text);

        }

        private void btnNickel_Click(object sender, EventArgs e)
        {
            Niquel();
        }
    }
}
