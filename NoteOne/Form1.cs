using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NoteOne
{
    public partial class NoteOne : Form
    {
        private Style style;
        float fontSize;
        public NoteOne()
        {
            fontSize = 8.0F;
            style = new Style(false, false, false, false, false);
            InitializeComponent();
        }

        private void boldBtn_Click(object sender, EventArgs e)
        {
            if (style.GetBoldOn() == false)
            {
                style.SetBoldOn(true);
                boldBtn.BackColor = Color.Gray;
                CheckStyles();
            }
            else
            {
                style.SetBoldOn(false);
                boldBtn.BackColor = Color.LightGray;
                CheckStyles();
            }
        }

        private void italicBtn_Click(object sender, EventArgs e)
        {
            if (style.GetItalicOn() == false)
            {
                style.SetItalicOn(true);
                italicBtn.BackColor = Color.Gray;
                CheckStyles();
            }
            else
            {
                style.SetItalicOn(false);
                italicBtn.BackColor = Color.LightGray;
                CheckStyles();
            }
        }
        private void Underline_Click(object sender, EventArgs e)
        {
            if (style.GetUnderlineOn() == false)
            {
                style.SetUnderlineOn(true);
                undrln_btn.BackColor = Color.Gray;
                CheckStyles();
            }
            else
            {
                style.SetUnderlineOn(false);
                undrln_btn.BackColor = Color.LightGray;
                CheckStyles();
            }
        }

        private void fontSizeSlct_SelectedIndexChanged(object sender, EventArgs e)
        {
            fontSize = float.Parse(Convert.ToString(fontSizeSlct.SelectedItem));
            CheckStyles();
        }

        private void fontSizeSlct_TextChanged(object sender, EventArgs e)
        {
            try
            {
                fontSize = float.Parse(fontSizeSlct.Text);
                if (style.GetBoldOn() == true)
                {
                    if (style.GetItalicOn() == true)
                    {
                        submissionBox.SelectionFont = new Font(FontFamily.GenericSansSerif, fontSize, FontStyle.Bold | FontStyle.Italic);
                    }
                    else
                    {
                        submissionBox.SelectionFont = new Font(FontFamily.GenericSansSerif, fontSize, FontStyle.Bold);
                    }
                }
                else
                {
                    if (style.GetItalicOn() == true)
                    {
                        submissionBox.SelectionFont = new Font(FontFamily.GenericSansSerif, fontSize, FontStyle.Italic);
                    }
                    else
                    {
                        submissionBox.SelectionFont = new Font(FontFamily.GenericSansSerif, fontSize, FontStyle.Bold);
                    }
                    fontSizeSlct.Text = Convert.ToString(fontSize);
                }
            }
            catch(Exception)
            { 

            }
        }
        private void CheckStyles()
        {
            int maxIndex = -1;
            int[] indexes = new int[3];
            FontStyle[] fontStyles = new FontStyle[3];
            if(style.GetBoldOn() == true)
            {
                fontStyles[0] = FontStyle.Bold;
                maxIndex++;
                indexes[maxIndex] = 0;
            }
            if(style.GetItalicOn() == true)
            {
                fontStyles[1] = FontStyle.Italic;
                maxIndex++;
                indexes[maxIndex] = 1;
            }
            if(style.GetUnderlineOn() == true)
            {
                fontStyles[2] = FontStyle.Underline;
                maxIndex++;
                indexes[maxIndex] = 2;
            }
            switch(maxIndex)
            {
                case 0:
                    submissionBox.SelectionFont = new Font(FontFamily.GenericSansSerif, fontSize, fontStyles[indexes[0]]);
                    break;
                case 1:
                    submissionBox.SelectionFont = new Font(FontFamily.GenericSansSerif, fontSize, fontStyles[indexes[0]] | fontStyles[indexes[1]]);
                    break;
                case 2:
                    submissionBox.SelectionFont = new Font(FontFamily.GenericSansSerif, fontSize, fontStyles[indexes[0]] | fontStyles[indexes[1]] | fontStyles[indexes[2]]);
                    break;
                default:
                    submissionBox.SelectionFont = new Font(FontFamily.GenericSansSerif, fontSize);
                    break;
            }
        }

        private void submissionBox_TextChanged(object sender, EventArgs e)
        {
            string[] bin = submissionBox.Text.Split(' ', '\n', '.', '!', '?') ;
            wrd_cnt.Text = bin.Length - 1 + " words";
            ln_cnt.Text = Convert.ToString(submissionBox.Lines.Length - 1) + " paragraphs";
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if(save_drctry_txt.Visible == false)
            {
                save_drctry_txt.Visible = true;
                MessageBox.Show("Enter the save directory with file name and .txt extension into the box next to save, then click save again");
            }
            else
            {
                try
                {
                    submissionBox.SaveFile(save_drctry_txt.Text);
                    MessageBox.Show("Saved");
                    save_drctry_txt.Text = "";
                }
                catch(Exception)
                {
                    MessageBox.Show("Failed!");
                }
                save_drctry_txt.Visible = false;
            }
        }

        private void open_btn_Click(object sender, EventArgs e)
        {
            if(save_drctry_txt.Visible == false)
            {
                save_drctry_txt.Visible = true;
                MessageBox.Show("Enter the directory of the file you want to open with the .txt extension, then click open again");
            }
            else
            {
                try
                {
                    submissionBox.LoadFile(save_drctry_txt.Text);
                    save_drctry_txt.Text = "";
                }
                catch
                {
                    MessageBox.Show("Failed");
                }
                save_drctry_txt.Visible = false;
            }
        }

        private void cntr_btn_Click(object sender, EventArgs e)
        {
            if(style.GetTextCentredOn() == false)
            {
                style.SetTextCentredOn(true);
                cntr_btn.BackColor = Color.Gray;
                submissionBox.SelectionAlignment = HorizontalAlignment.Center;
            }
            else
            {
                style.SetTextCentredOn(false);
                cntr_btn.BackColor = Color.LightGray;
                submissionBox.SelectionAlignment = HorizontalAlignment.Left;
            }
        }

        private void stng_btn_Click(object sender, EventArgs e)
        {
            if(style.GetSettingOn() == false)
            {
                style.SetSettingOn(true);
                stng_btn.BackColor = Color.Gray;
                submissionBox.Visible = false;
                wndw_clr_lbl.Visible = true;
                wndw_clr_slctr.Visible = true;
            }
            else
            {
                style.SetSettingOn(false);
                stng_btn.BackColor = Color.LightGray;
                submissionBox.Visible = true;
                wndw_clr_lbl.Visible = false;
                wndw_clr_slctr.Visible = false;
            }
        }

        private void wndw_clr_slctr_SelectedIndexChanged(object sender, EventArgs e)
        {
            string colour = wndw_clr_slctr.Text;
            colour = colour.Replace(" ", "");
            NoteOne.ActiveForm.BackColor = Color.FromName(colour);
        }
    }
}
