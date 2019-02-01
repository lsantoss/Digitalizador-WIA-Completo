using iTextSharp.text;
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIA;

namespace Digitalizador_WIA_Completo___WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListarScanners();
            txtLocalDestino.Text = "D:\\";
            cbFormato.SelectedIndex = 0;
        }

        private void BtnScanner_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
            Task.Factory.StartNew(StartScanning);
        }

        private void BtnLocalDestino_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;

            DialogResult result = folderDlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtLocalDestino.Text = folderDlg.SelectedPath;
            }
        }

        private void btnGerarPDF_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
            Scanner scanner = null;

            this.Invoke(new MethodInvoker(delegate ()
            {
                scanner = lstScanners.SelectedItem as Scanner;
            }));

            if (scanner == null)
            {
                MessageBox.Show("Você precisa selecionar uma scanner na lista!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (String.IsNullOrEmpty(txtNomeArquivo.Text))
            {
                MessageBox.Show("Digite um nome para o arquivo!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ImageFile imagem = scanner.ScanPNG();
            string imagemExtensao = ".png";
            string pathImagem = Path.Combine(txtLocalDestino.Text, txtNomeArquivo.Text + imagemExtensao);
            string pathArquivoPDF = "D:\\" + txtNomeArquivo.Text + ".pdf";

            if (File.Exists(pathImagem) || File.Exists(pathArquivoPDF))
            {
                try
                {
                    if (File.Exists(pathImagem))
                    {
                        File.Delete(pathImagem);
                    }

                    if (File.Exists(pathArquivoPDF))
                    {
                        File.Delete(pathArquivoPDF);
                    }
                }
                catch
                {
                    MessageBox.Show("Não foi possível sobrepor o documento já existente com o mesmo nome, pois ele pode estar aberto nessa ou em outra aplicação!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            try
            {
                using (var document = new Document(PageSize.LETTER, 5f, 5f, 5f, 5f))
                {
                    iTextSharp.text.pdf.PdfWriter.GetInstance(document, new System.IO.FileStream(pathArquivoPDF, System.IO.FileMode.Create));
                    document.Open();
                    imagem.SaveFile(pathImagem);
                    iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(pathImagem);
                    image.ScaleToFit(650f, 780f);
                    image.Alignment = Element.ALIGN_CENTER;
                    document.Add(image);
                    File.Delete(pathImagem);
                    MessageBox.Show("Documento PDF criado com sucesso!", "Sucesso!");
                }
            }
            catch
            {
                MessageBox.Show("Não foi possível criar arquivo PDF!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarScanners()
        {
            lstScanners.Items.Clear();
            var deviceManager = new DeviceManager();

            // Loop percorre a lista de dispositivos
            for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++)
            {
                // Descarta dispositivos que não são Scanners
                if (deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType)
                {
                    continue;
                }

                // Adiciona somente dispositivos de Scanner no ListBox
                lstScanners.Items.Add(new Scanner(deviceManager.DeviceInfos[i]));
            }
        }

        public void StartScanning()
        {
            Scanner scanner = null;

            this.Invoke(new MethodInvoker(delegate ()
            {
                scanner = lstScanners.SelectedItem as Scanner;
            }));

            if (scanner == null)
            {
                MessageBox.Show("Você precisa selecionar uma scanner na lista!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (String.IsNullOrEmpty(txtNomeArquivo.Text))
            {
                MessageBox.Show("Digite um nome para o arquivo!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ImageFile imagem = new ImageFile();
            string imagemExtensao = "";

            this.Invoke(new MethodInvoker(delegate ()
            {
                switch (cbFormato.SelectedIndex)
                {
                    case 0:
                        imagem = scanner.ScanPNG();
                        imagemExtensao = ".png";
                        break;

                    case 1:
                        imagem = scanner.ScanJPEG();
                        imagemExtensao = ".jpeg";
                        break;

                    case 2:
                        imagem = scanner.ScanTIFF();
                        imagemExtensao = ".tiff";
                        break;

                    case 3:
                        imagem = scanner.ScanBMP();
                        imagemExtensao = ".bmp";
                        break;

                    case 4:
                        imagem = scanner.ScanGIF();
                        imagemExtensao = ".gif";
                        break;
                }
            }));

            // Concatena Desino + Nome do arquivo + Extensao
            string path = Path.Combine(txtLocalDestino.Text, txtNomeArquivo.Text + imagemExtensao);

            if (File.Exists(path))
            {
                try
                {
                    File.Delete(path);
                    imagem.SaveFile(path);
                    pictureBox.Image = new Bitmap(path);
                    MessageBox.Show("Documento digitalizado com sucesso!", "Sucesso!");
                }
                catch
                {
                    MessageBox.Show("Não foi possível sobrepor o documento já existente com o mesmo nome, pois ele pode estar aberto nessa ou em outra aplicação!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    imagem.SaveFile(path);
                    pictureBox.Image = new Bitmap(path);
                    MessageBox.Show("Documento digitalizado com sucesso!", "Sucesso!");
                }
                catch
                {
                    MessageBox.Show("Documento não foi digitalizado!", "Erro!", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
    }
}
