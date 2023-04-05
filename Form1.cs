using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IzradaWebPreglednika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser1.Navigate("https://www.google.com");
            this.KeyDown += new KeyEventHandler(txtBoxSearch_KeyDown_1);
        }
        private void bntHome_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com");
        }

        private void bntSearch_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtBoxSearch.Text);
        }

        private void bntBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void bntForward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void bntRefresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void bntTabs_Click(object sender, EventArgs e)
        {
            TabPage tabpage = new TabPage();
            tabpage.Text = "New Tab";
            tabControl1.Controls.Add(tabpage);
            WebBrowser webBrowser = new WebBrowser();
            webBrowser.Parent = tabpage;
            webBrowser.Dock = DockStyle.Fill;
            webBrowser.Navigate("www.google.com");
        }

        private void addBookmarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbBookmark.Items.Add(webBrowser1.Url.ToString());
            cbBookmark.SelectedItem = webBrowser1.Url.ToString();
            cbBookmark.Focus();
        }

        private void removeBookmarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbBookmark.Items.Remove(cbBookmark.SelectedItem);
        }

        private void clearBookmarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbBookmark.Items.Clear();
        }

        private void cbBookmark_Click(object sender, EventArgs e)
        {
            try {
                if (cbBookmark.SelectedItem == null) {
                    MessageBox.Show("Bookmark ne postoji!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    webBrowser1.Navigate(cbBookmark.SelectedItem.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - Bookmark ne postoji!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtBoxSearch_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(txtBoxSearch.Text);
            }
        }

        private void bntNewTabOpen_Click(object sender, EventArgs e)
        {
            TabPage tabpage = new TabPage();
            tabpage.Text = "New Tab";
            tabControl1.Controls.Add(tabpage);
            WebBrowser webBrowser = new WebBrowser();
            webBrowser.Parent = tabpage;
            webBrowser.Dock = DockStyle.Fill;
            webBrowser.Navigate(txtBoxSearch.Text);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("");
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "HTML file (*.html)|*.html|HTML file (*.htm)|*.htm";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string htmlCodeTxtOutput = webBrowser1.DocumentText;
                    File.AppendAllText(saveFileDialog1.FileName, htmlCodeTxtOutput);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Pogrešan u spremanje datoteka!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "HTML file (*.html)|*.html|HTML file (*.htm)|*.htm";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        webBrowser1.DocumentText = reader.ReadToEnd();
                    }
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
