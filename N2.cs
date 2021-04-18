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
    public partial class N2 : Form
    {
        string[] codes;
        bool stop = false;
        bool first = true;
        bool last = false;

        public N2(Color background, Color elements, Color font)
        {
            InitializeComponent();
            ChangeTheme(background, elements, font);

            txtDelete.Text = "60";
            txtTabCod.Text = "10";
            txtTabSearch.Text = "43";
            txtCodes.Text = "0654" + Environment.NewLine +
                "5084" + Environment.NewLine +
                "6977" + Environment.NewLine +
                "g736";

        }

        private void ChangeTheme(Color background, Color elements, Color font)
        {
            BackColor = background;

            btnAsign.BackColor = elements;
            btnAsign.BackColor = elements;
            txtCodes.BackColor = elements;
            txtDelete.BackColor = elements;
            txtTabCod.BackColor = elements;
            txtTabSearch.BackColor = elements;

            btnAsign.ForeColor = font;
            btnDelete.ForeColor = font;
            txtCodes.ForeColor = font;
            txtDelete.ForeColor = font;
            txtTabCod.ForeColor = font;
            txtTabSearch.ForeColor = font;

            label1.ForeColor = font;
            label2.ForeColor = font;
            label3.ForeColor = font;
            label4.ForeColor = font;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int spaces = 60;
            int.TryParse(txtDelete.Text, out spaces);
            SendKeys.Send("%{Tab}");
            for (int i = 0; i < spaces + 1; i++)
            {
                //SendKeys.Send(" ");
                if (!stop)
                {
                    SendKeys.SendWait(" ");
                }
                
            }
            
        }

        private void btnAsign_Click(object sender, EventArgs e)
        {
            codes = txtCodes.Text.Split('\n');
            //for (int i = 0; i < codes.Length; i++)
            //{
            //    if (codes[i].Length == 4)
            //    {
            //        codes[i] = "0" + codes[i];
            //    }
            //}


            SendKeys.SendWait("%{Tab}");


            for (int i = 0; i < codes.Length; i++)
            {
               
                last = i == codes.Length - 1;

                if (!stop)
                {
                    round(codes[i]);
                    if (!last) {
                        SendKeys.SendWait("{Enter}");
                        System.Threading.Thread.Sleep(500);
                    }
                }
            }
        }

        private void round(string insert)
        {
            int tabsToCode = 0;
            int.TryParse(txtTabCod.Text, out tabsToCode);

            if (!first)
            {
                tabsToCode--;
            }
            
            for (int i = 0; i < tabsToCode; i++)
            {
                if (!stop)
                {
                    SendKeys.SendWait("{TAB}");
                    //System.Threading.Thread.Sleep(150);
                    System.Threading.Thread.Sleep(100);
                }
                
            }

            SendKeys.SendWait(insert);


            int tabsToSearch = 0;
            int.TryParse(txtTabSearch.Text, out tabsToSearch);

            if (last)
            {
                tabsToSearch++;
            }

            for (int i = 0; i < tabsToSearch; i++)
            {
                if (!stop)
                {
                    SendKeys.SendWait("{TAB}");
                    System.Threading.Thread.Sleep(25);
                }
                
            }
            SendKeys.SendWait(" ");
            //TODO BIEN
            System.Threading.Thread.Sleep(500);
            SendKeys.SendWait("{TAB}");
            System.Threading.Thread.Sleep(500);
            SendKeys.SendWait("{Enter}");
            System.Threading.Thread.Sleep(500);
            first = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stop = !stop;
        }
    }
}
