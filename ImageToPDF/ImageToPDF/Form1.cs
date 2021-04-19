using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageToPDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            var imagePath = textBoxImagens.Text;
            var pdfOutput = textBoxPDF.Text;

            try
            {
                ImagensParaPDF(imagePath, pdfOutput);

                MessageBox.Show("PDF criado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ImagensParaPDF(string ImagemCaminhoOrigem, string caminhoSaidaPDF)
        {
            string[] caminhoImagens = GetImageFiles(ImagemCaminhoOrigem);

            if (caminhoImagens.Length > 0)
            {
                
                string pdfpath = caminhoSaidaPDF + ImagemCaminhoOrigem.Substring(ImagemCaminhoOrigem.LastIndexOf("\\")) + ".pdf";

                if (File.Exists(pdfpath))
                {
                    pdfpath = SetNewName(caminhoSaidaPDF, ImagemCaminhoOrigem.Substring(ImagemCaminhoOrigem.LastIndexOf("\\") + 1));
                }

                using (var doc = new iTextSharp.text.Document())
                {
                    iTextSharp.text.pdf.PdfWriter.GetInstance(doc, new FileStream(pdfpath, FileMode.Create));
                    doc.Open();

                    foreach (var item in caminhoImagens)
                    {
                        iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(item);
                        
                        //image.SetAbsolutePosition(30f, 30f);
                        if (checkBoxScalebyImageSize.Checked)
                        {
                            image.ScaleToFit(doc.PageSize.Width - 60, doc.PageSize.Height - 60);
                        }
                        else
                        {
                            image.ScaleAbsoluteHeight(doc.PageSize.Height - 60);
                            image.ScaleAbsoluteWidth(doc.PageSize.Width - 60);
                        }
                        doc.Add(image);
                        
                    }
                }
            }
            else
            {
                MessageBox.Show("Imagem não encontrada.", "Pare!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public string SetNewName(string Dir, string OldFileName)
        {
            System.Collections.ArrayList fileList = new System.Collections.ArrayList();
            string NewFileName = string.Empty;
            string[] files = Directory.GetFiles(Dir);
            for (int i = 0; i < files.Length; i++)
            {
                if (files[i].Contains(OldFileName))
                {
                    fileList.Add(files[i]);
                }
            }
            NewFileName = Dir + "\\" + OldFileName + " _ " + fileList.Count + ".pdf";

            return NewFileName;
        }

        public string[] GetImageFiles(string ImageSource)
        {
            System.Collections.ArrayList Files = new System.Collections.ArrayList();
            string[] FilesArray = Directory.GetFiles(ImageSource);
            foreach (string file in FilesArray)
            {
                string extension = file.Substring(file.LastIndexOf(".")).ToUpper();
                if (extension.CompareTo(".JPG") == 0 || extension.CompareTo(".JPEG") == 0 || extension.CompareTo(".GIF") == 0)
                {
                    Files.Add(file);
                }
            }

            string[] returnFiles = new string[Files.Count];
            for (int i = 0; i < Files.Count; i++)
            {
                returnFiles[i] = Files[i].ToString();
            }

            return returnFiles;
        }

        private void btnProcurar1_Click(object sender, EventArgs e)
        {
            DialogResult Result = folderBrowserDialog1.ShowDialog();
            if (Result == System.Windows.Forms.DialogResult.OK)
            {
                this.textBoxImagens.Text = folderBrowserDialog1.SelectedPath.ToString();
            }
            else
            {
                MessageBox.Show("Você não escolhou uma pasta.", "Parar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBoxImagens.Text = string.Empty;
            }
        }

        private void btnProcurar2_Click(object sender, EventArgs e)
        {
            DialogResult Result = folderBrowserDialog1.ShowDialog();
            if (Result == System.Windows.Forms.DialogResult.OK)
            {
                this.textBoxPDF.Text = folderBrowserDialog1.SelectedPath.ToString();
            }
            else
            {
                MessageBox.Show("Você não escolhou uma pasta.", "Parar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBoxPDF.Text = string.Empty;
            }
        }

        private void btnVerPDF_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", textBoxPDF.Text);
        }
    }
}
