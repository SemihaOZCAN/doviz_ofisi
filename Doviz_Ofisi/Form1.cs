using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace Doviz_Ofisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldosya = new XmlDocument();

            try
            {
                xmldosya.Load(bugun);

                // Dolar alış
                string dolaralis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
                lblDAlis.Text = dolaralis;

                // Dolar satış
                string dolarsatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
                lblDSatis.Text = dolarsatis;

                // Euro alış
                string euroalis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
                lblEAlis.Text = euroalis;

                // Euro satış (düzeltilmiş)
                string eurosatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
                lblESatis.Text = eurosatis;

                // Güncelleme tarihi
                string tarih = xmldosya.SelectSingleNode("Tarih_Date").Attributes["Tarih"].Value;
                lblTarih.Text = "Kurların Güncellenme Tarihi: " + tarih;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri çekme hatası: " + ex.Message);
            }

        }

        private void buttonDalis_Click(object sender, EventArgs e)
        {
            textBoxKur.Text = lblDAlis.Text;
        }

        private void buttonDsatis_Click(object sender, EventArgs e)
        {
            textBoxKur.Text = lblDSatis.Text;

        }

        private void buttonEalis_Click(object sender, EventArgs e)
        {
            textBoxKur.Text = lblEAlis.Text;
        }

        private void buttonEsatis_Click(object sender, EventArgs e)
        {
            textBoxKur.Text = lblESatis.Text;
        }

        private void buttonIslem1_Click(object sender, EventArgs e)
        {
            try
            {
                double kur = Convert.ToDouble(textBoxKur.Text);
                double miktar = Convert.ToDouble(textBoxMiktar.Text);
                double tutar = kur * miktar;
                textBoxTutar.Text = tutar.ToString();
                MessageBox.Show("İşlem başarıyla gerçekleştirildi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hesaplama hatası: " + ex.Message);
            }

        }

        private void textBoxKur_TextChanged(object sender, EventArgs e)
        {
            textBoxKur.Text = textBoxKur.Text.Replace(".", ",");
        }

        private void buttonIslem2_Click(object sender, EventArgs e)
        {
            try
            {
                double kur = Convert.ToDouble(textBoxKur.Text);
                int miktar = Convert.ToInt32(textBoxMiktar.Text);
                int tutar = Convert.ToInt32(miktar / kur);

                textBoxTutar.Text = tutar.ToString();

                int kalan = miktar % Convert.ToInt32(kur);
                textBoxKalan.Text = kalan.ToString();
                MessageBox.Show("Bozdurma işlemi başarıyla gerçekleştirildi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hesaplama hatası: " + ex.Message);
            }

            
        }

        private void textBoxMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece rakam ve geri silme (Backspace) tuşuna izin ver
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Lütfen sadece sayısal değerler girin.");
            }
        }
    }
}
