using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor
{
    public partial class FormMain : Form
    {
        string selected;
        string language = "english";

        public FormMain()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            box_value.Text = "";
            txt_resultado.Text = "";
            label_s.Text = "";
        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            int numconvert = int.Parse(box_value.Text);
            if (selected == "binary")
                txt_resultado.Text = Convert.ToString(numconvert, 2);
            else if (selected == "hexa")
                txt_resultado.Text = Convert.ToString(numconvert, 16);
            else if (selected == "decimal")
                txt_resultado.Text = Convert.ToString(numconvert, 10);
            else if (selected == "octal")
                txt_resultado.Text = Convert.ToString(numconvert, 8);
        }

        private void binaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selected = "binary";

            if (language == "english")
                label_s.Text = "binary";
            else if (language == "portuguese")
                label_s.Text = "Binario";

        }

        private void hexaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selected = "hexa";
                label_s.Text = "hexa";
        }

        private void decimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selected = "decimal";
            label_s.Text = "decimal";
        }

        private void octalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selected = "octal";
            label_s.Text = "octal";
        }


        #region languages
        private void portuguêsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Português
            language = "portuguese";

            if (label_s.Text == "Binary")
                label_s.Text = "Binario";

            //Menu
            themeToolStripMenuItem.Text = "Temas";
            lightToolStripMenuItem.Text = "Claro";
            darkToolStripMenuItem.Text = "Escuro";

            converterToolStripMenuItem.Text = "Converter";
            binaryToolStripMenuItem.Text = "Binario";

            langugeToolStripMenuItem.Text = "Idioma";
            portuguêsToolStripMenuItem.Text = "Português";
            englishToolStripMenuItem.Text = "Inglês";



            //Itens
            label_result.Text = "Resultado";
            label_result.Location = new Point(173, 129);

            label_title.Text = "Conversor";
            label_Selected.Text = "Selecionou";
            label_s.Location = new Point(91, 88);
            label_value.Text = "Valor";
            btn_clear.Text = "Limpar";
            btn_convert.Text = "Converter";
            btn_exit.Text = "Sair";
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //English
            language = "english";

            if (label_s.Text == "Binario")
                label_s.Text = "Binary";

            //Menu
            themeToolStripMenuItem.Text = "Themes";
            lightToolStripMenuItem.Text = "Light";
            darkToolStripMenuItem.Text = "Dark";

            converterToolStripMenuItem.Text = "Converter";
            binaryToolStripMenuItem.Text = "Binary";

            langugeToolStripMenuItem.Text = "Language";
            portuguêsToolStripMenuItem.Text = "Portuguese";
            englishToolStripMenuItem.Text = "English";

            //items
            label_result.Text = "Result";
            label_result.Location = new Point(193, 129);

            label_title.Text = "Converter";
            label_Selected.Text = "Selected";
            label_s.Location = new Point(77, 88);
            label_value.Text = "Value";
            btn_clear.Text = "Clear";
            btn_convert.Text = "Convert";
            btn_exit.Text = "Exit";
        }
        #endregion


        #region Themes
        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(212, 212, 212);
            box_value.BackColor = Color.FromArgb(212, 212, 212);
            ForeColor = Color.Black;
            box_value.ForeColor = Color.Black;
            txt_resultado.ForeColor = Color.Black;
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(42, 42, 42);
            box_value.BackColor = Color.FromArgb(42, 42, 42);
            ForeColor = Color.White;
            box_value.ForeColor = Color.White;
            txt_resultado.ForeColor = Color.White;
        }
        #endregion
    }
}
