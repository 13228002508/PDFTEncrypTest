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
using iTextSharp.text.pdf;
namespace PDFEncyption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EncryptionBtn_Click(object sender, EventArgs e)
        {
            String scourcePath = this.textBox1.Text;
            String destinationPath = this.DesEncrypPathText.Text;
            destinationPath += "\\Encry.pdf";
            String strOpenPassword = this.OpenFilPassWText.Text;
            String strOWnerPassword = this.PerrmisionPassText.Text;
            bool bRet=EncryptPDF(scourcePath,destinationPath, strOpenPassword, strOWnerPassword);
            if (bRet)
                MessageBox.Show(destinationPath+":加密成功"+"___生成文件路径："+ destinationPath, "EncryPDF");
            else
                MessageBox.Show(destinationPath + ":加密失败", "EncryPDF");
        }

        private void SrcPathBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "文本文件|*.pdf*";//|C#文件|*.cs|所有文件|*.*
            if (DialogResult.OK == fileDialog.ShowDialog())
            {
                this.textBox1.Text = fileDialog.FileName;
            }
            
        }

        private void DesBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.DesEncrypPathText.Text = dialog.SelectedPath;
            }
        }


        private bool EncryptPDF(String strPath,String StrDesPath,String strOpenPassWord,String strOwnerPassWord)
        {
            try
            {
                //提交注释第三版
                //提交注释第二版
                //添加注释
                PdfReader itextPdfReader = new PdfReader(strPath);
                iTextSharp.text.Document document = new iTextSharp.text.Document();
                FileStream fileStream = new FileStream(StrDesPath, FileMode.Create);
                PdfWriter pdfWriter = PdfWriter.GetInstance(document, fileStream);
                String strOpenPas, strOwnerPas;
                strOpenPas = this.OpenFilPassWText.Text;
                strOwnerPas = this.PerrmisionPassText.Text;
                pdfWriter.SetEncryption(PdfWriter.STRENGTH40BITS, strOpenPas, strOwnerPas, PdfWriter.AllowCopy);
                document.Open();

                //Setting PDF file enctyption page count 
                document.SetPageSize(iTextSharp.text.PageSize.LEDGER.Rotate());
                iTextSharp.text.pdf.PdfContentByte oDirectContent = pdfWriter.DirectContent;
                int iNUmberOfPages = itextPdfReader.NumberOfPages;
                int iPage = 0;

                while (iPage < iNUmberOfPages)
                {
                    iPage += 1;
                    document.SetPageSize(itextPdfReader.GetPageSizeWithRotation(iPage));
                    document.NewPage();
                    iTextSharp.text.pdf.PdfImportedPage oPdfImportedPage = pdfWriter.GetImportedPage(itextPdfReader, iPage);
                    int iRotation = itextPdfReader.GetPageRotation(iPage);
                    if (iRotation == 90 || iRotation == 270)
                    {
                        oDirectContent.AddTemplate(oPdfImportedPage, 0, -1.0F, 1.0F, 0, 0, itextPdfReader.GetPageSizeWithRotation(iPage).Height);
                    }
                    else
                    {
                        oDirectContent.AddTemplate(oPdfImportedPage, 1.0F, 0, 0, 1.0F, 0, 0);
                    }

                }
                document.Close();
                return true;
            }catch(Exception e)
            {
                //e.ToString();
                
                return false;
            }
           
        }


    }
}
