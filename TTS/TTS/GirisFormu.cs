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
    public partial class GirisFormu : Form
    {
        public GirisFormu()
        {
            InitializeComponent();
        }

        private void kapatDugmesi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void girisDugmesi_Click(object sender, EventArgs e)
        {
            KullaniciFormu kullaniciform = new KullaniciFormu();
            kullaniciform.Show();
            YoneticiFormu yoneticiform = new YoneticiFormu();
            yoneticiform.Show();
        }
    }
}
