using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTS
{
    public partial class KullaniciFormu : Form
    {
        public KullaniciFormu()
        {
            InitializeComponent();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HakkindaKutusu hakkindakutu = new HakkindaKutusu();
            hakkindakutu.Show();
        }

        private void şifreDeğiştirmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Degistirme degistir = new Degistirme();
            degistir.Show();
        }

        private void blokTanımlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BlokTanimlama bloktanimla = new BlokTanimlama();
            bloktanimla.Show();
        }

        private void koğuşTanımlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KogusTanimlama kogustanimla = new KogusTanimlama();
            kogustanimla.Show();
        }

        private void ilaçTanımlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IlacTanimlama ilactanimla = new IlacTanimlama();
            ilactanimla.Show();
        }

        private void hükümlüTutukluTanımlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HukumluTutukluTanimlama hukumlututuklutanimla = new HukumluTutukluTanimlama();
            hukumlututuklutanimla.Show();
        }

        private void hükümlüTutukluÇıkışİşlemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HukumluTutukluCikisIslemi hukumlututuklucikis = new HukumluTutukluCikisIslemi();
            hukumlututuklucikis.Show();
        }

        private void muayeneBilgileriSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MuayeneBilgileriSorgulama muayenebilgilerisorgula = new MuayeneBilgileriSorgulama();
            muayenebilgilerisorgula.Show();
        }

        private void ilaçKullanımBilgileriSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IlacKullanimBilgileriSorgulama ilackullanimbilgilerisorgula = new IlacKullanimBilgileriSorgulama();
            ilackullanimbilgilerisorgula.Show();
        }

        private void muayeneyeÇıkarmaRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MuayeneyeCikarmaRaporu muayeneyecikacakrapor = new MuayeneyeCikarmaRaporu();
            muayeneyecikacakrapor.Show();
        }

        private void ilaçDağıtımRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IlacDagitimRaporu ilacdagitimrapor = new IlacDagitimRaporu();
            ilacdagitimrapor.Show();
        }

        private void hükümlüTutukluSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HukumluTutukluSorgulama hukumlututuklusorgula = new HukumluTutukluSorgulama();
            hukumlututuklusorgula.Show();
        }

        private void teknikDestekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeknikDestek teknikdestekform = new TeknikDestek();
            teknikdestekform.Show();
        }

        private void muayeneTalepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MuayeneTalep muayenetalebi = new MuayeneTalep();
            muayenetalebi.Show();
        }

        private void muayeneBilgiGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MuayeneBilgiGirisi muayenebilgigiris = new MuayeneBilgiGirisi();
            muayenebilgigiris.Show();
        }

        private void ilaçBilgiGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IlacBilgiGirisi ilacbilgigiris = new IlacBilgiGirisi();
            ilacbilgigiris.Show();
        }

        private void ilaçKullanımSonlandırmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IlacKullanimSonlandirma ilackullanimsonlandir = new IlacKullanimSonlandirma();
            ilackullanimsonlandir.Show();
        }
    }
}
