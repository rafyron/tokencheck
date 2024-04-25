using System;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;
using System.Security.Cryptography;

namespace TOKENCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxCertInfo.ScrollBars = ScrollBars.Vertical;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cria uma janela de seleção de certificado
            X509Store store = new X509Store(StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadOnly);
            X509Certificate2Collection certs = X509Certificate2UI.SelectFromCollection(
                store.Certificates, "Escolha um Certificado", "Selecione o certificado que deseja usar",
                X509SelectionFlag.SingleSelection);

            // Se um certificado foi selecionado, exiba suas informações
            if (certs.Count > 0)
            {
                X509Certificate2 cert = certs[0];
                string certType = GetCertificateType(cert);
                textBoxCertInfo.Text = $"Nome no Certificado:\r\n{cert.Subject}\r\n\r\n" +
                                       $"A/C:\r\n{cert.Issuer}\r\n\r\n" +
                                       $"Válido de:\r\n{cert.NotBefore.ToShortDateString()}\r\n\r\n" +
                                       $"Até:\r\n{cert.NotAfter.ToShortDateString()}\r\n\r\n" +
                                       $"Chave de Validação:\r\n{cert.Thumbprint}\r\n\r\n" +
                                       $"Tipo de Certificado:\r\n{certType}";
            }
            else
            {
                textBoxCertInfo.Text = "Nenhum certificado selecionado.";
            }

            store.Close();
        }

        private string GetCertificateType(X509Certificate2 cert)
        {
            if (cert.Extensions["2.5.29.37"] != null)
            {
                X509EnhancedKeyUsageExtension ekuExtension = (X509EnhancedKeyUsageExtension)cert.Extensions["2.5.29.37"];
                OidCollection oids = ekuExtension.EnhancedKeyUsages;
                foreach (Oid oid in oids)
                {
                    if (oid.Value == "1.3.6.1.5.5.7.3.2") // OID para Client Authentication
                    {
                        return "Certificado de Cliente";
                    }
                }
            }
            return "Outro tipo de Certificado";
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string url = "https://linktr.ee/grupoconceitotecnologia"; // URL que você deseja abrir

            Process.Start(new ProcessStartInfo
            {
                FileName = @"C:\Program Files\Google\Chrome\Application\chrome.exe", // Caminho completo para o executável do Chrome
                Arguments = url
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja fechar o programa?" , "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }

    }
    }
}
