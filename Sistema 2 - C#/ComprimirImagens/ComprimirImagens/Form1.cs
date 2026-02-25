using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComprimirImagens
{
    public partial class Form1 : Form
    {
        string pastaOrigem = "";
        string pastaDestino = "";
        public Form1()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            lblQualidade.Text = "...";
            CentralizarLabel(lblQualidade);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            trackQualidade.Minimum = 10;
            trackQualidade.Maximum = 100;
            trackQualidade.Value = 75;
            lblQualidade.Text = "Qualidade: 75%";
        }
        private void CentralizarLabel(Label lbl)
        {
            lbl.AutoSize = false;

            lbl.Width = this.ClientSize.Width;
            lbl.Left = 0;

            lbl.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void btnSelecionarPastaOrigem_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    pastaOrigem = dialog.SelectedPath;
                    MessageBox.Show("Pasta selecionada com sucesso!");
                }
            }
        }

        private void btnSelecionarDestino_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    pastaDestino = dialog.SelectedPath;
                }
            }
        }

        private async void btnComprimir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pastaOrigem) || string.IsNullOrEmpty(pastaDestino))
            {
                MessageBox.Show("Selecione pasta de origem e destino.");
                return;
            }

            btnComprimir.Enabled = false;

            int qualidade = trackQualidade.Value;

            await Task.Run(() => ProcessarImagens(qualidade));

            btnComprimir.Enabled = true;
            MessageBox.Show("Compressão finalizada!");
        }

        private void ProcessarImagens(int qualidade)
        {
            var arquivos = Directory.GetFiles(
                pastaOrigem,
                "*.*"
            )
            .Where(f => f.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase)
                     || f.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase)
                     || f.EndsWith(".tif", StringComparison.OrdinalIgnoreCase)
                     || f.EndsWith(".tiff", StringComparison.OrdinalIgnoreCase)
                     || f.EndsWith(".png", StringComparison.OrdinalIgnoreCase))
            .ToList();

            Invoke(new Action(() =>
            {
                progressBar.Maximum = arquivos.Count;
                progressBar.Value = 0;
            }));

            foreach (var arquivo in arquivos)
            {
                ComprimirImagem(arquivo, qualidade);

                Invoke(new Action(() =>
                {
                    progressBar.Value++;
                }));
            }
        }

        private void ComprimirImagem(string caminhoOriginal, int qualidade)
        {
            using (Image imagem = Image.FromFile(caminhoOriginal))
            {
                string nomeArquivo = Path.GetFileNameWithoutExtension(caminhoOriginal);

                string novoCaminho = Path.Combine(
                    pastaDestino,
                    nomeArquivo + ".jpg"
                );

                ComprimirJpeg(imagem, novoCaminho, qualidade);
            }
        }

        // JPEG
        private void ComprimirJpeg(Image imagem, string caminhoDestino, long qualidade)
        {
            ImageCodecInfo jpgEncoder = ImageCodecInfo.GetImageEncoders()
                .First(c => c.FormatID == ImageFormat.Jpeg.Guid);

            EncoderParameters encoderParams = new EncoderParameters(1);
            encoderParams.Param[0] =
                new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, qualidade);

            imagem.Save(caminhoDestino, jpgEncoder, encoderParams);
        }

        // TIFF
        private void ComprimirTiff(Image imagem, string caminhoDestino)
        {
            ImageCodecInfo tiffEncoder = ImageCodecInfo.GetImageEncoders()
                .First(c => c.FormatID == ImageFormat.Tiff.Guid);

            EncoderParameters encoderParams = new EncoderParameters(1);
            encoderParams.Param[0] =
                new EncoderParameter(System.Drawing.Imaging.Encoder.Compression,
                (long)EncoderValue.CompressionLZW);

            imagem.Save(caminhoDestino, tiffEncoder, encoderParams);
        }

        // PNG
        private void ComprimirPng(Image imagem, string caminhoDestino)
        {
            imagem.Save(caminhoDestino, ImageFormat.Png);
        }

        private void trackQualidade_Scroll(object sender, EventArgs e)
        {
            lblQualidade.Text = $"Qualidade: {trackQualidade.Value}%";
        }
    }
}
