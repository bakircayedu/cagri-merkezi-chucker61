using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veri_Yapıları_Ödev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayTypedStack cagriStack = new ArrayTypedStack(100);
        ArrayTypedStack musteriStack = new ArrayTypedStack(100);
        ArrayTypedStack temsilciStack = new ArrayTypedStack(100);

        Cagri cagri = new Cagri();
        private void btnAramaYap_Click(object sender, EventArgs e)
        {
            if (cbMusteriTuru.Text == "Bireysel")
            {
                cagri.musteri.Tur = "Bireysel";
            }
            if (cbMusteriTuru.Text == "Ticari")
            {
                cagri.musteri.Tur = "Ticari";
            }

            int temp = Convert.ToInt32(txtMusteriTanimlayici.Text);
            cagri.musteri.Tanimlayici = temp;
            temp++;
            txtMusteriTanimlayici.Text = temp.ToString();

            txtAramaZamani.Text = DateTime.Now.ToString();
            cagri.musteri.CagriBaslangic = Convert.ToDateTime(txtAramaZamani.Text);

            musteriStack.Push(cagri);  //musteri stackine çağrının musteri hakkında olan kısmını pushladım sonradan temsilci stackıyla birleşip çağrı stackine eklenecek
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnCagriAta_Click(object sender, EventArgs e)
        {
            object musteri = musteriStack.Pop(); //Hocam pop ettiğimde nesnenin elemanlarına nasıl ulaşacağımı bulamadım maks buraya kadar gelebiliyorum
            
            int temp = Convert.ToInt32(txtCagriTanimlayici.Text);
            cagri.temsilci.CagriTanimlayicisi = temp;
            temp++;
            txtCagriTanimlayici.Text = temp.ToString();

            cagri.temsilci.Tanimlayici = cbTemsilciTuru.Text;

            cagri.temsilci.CagriBitis = DateTime.Now;

            cagri.temsilci.CagriZamani = Convert.ToInt32(cagri.temsilci.CagriBitis.Second) - Convert.ToInt32(cagri.musteri.CagriBaslangic.Second);
            
            cagri.temsilci.GorusmeNotlari = rtxtNotDefteri.Text;

            temsilciStack.Push(cagri); //temsilci stackine temsilciyle alakalı olan kısmı ekledim

            txtSıra.Text = cagriStack.items.Length.ToString();
        }

    }
}
