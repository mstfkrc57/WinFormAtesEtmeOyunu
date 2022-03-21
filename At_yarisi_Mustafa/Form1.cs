using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace At_yarisi_Mustafa
{
    public partial class atyarisi_form : Form
    {
        public atyarisi_form()
        {
            InitializeComponent();
        }
        int birinci_atuzaklik, ikinci_atuzaklik, ucuncu_atuzaklık; //atların yol uzaklıkları
        Random rnd = new Random();

        private void btn_yarisi_baslat_Click(object sender, EventArgs e)
        {
            timer_start.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void timer_start_Tick(object sender, EventArgs e)
        {
            int birinci_atin_uzakligi = birinci_at.Width;
            int ikinci_atin_uzakligi = ikinci_at.Width;
            int ucuncu_atin_uzakligi = ucuncu_at.Width;
            int bitis_uzakligi = lbl_bitis.Left;

            birinci_at.Left = birinci_at.Left + rnd.Next(5, 15);
            ikinci_at.Left = ikinci_at.Left + rnd.Next(5, 15);
            ucuncu_at.Left = ucuncu_at.Left + rnd.Next(5, 15);

            if (birinci_at.Left>ikinci_at.Left +5 && birinci_at.Left>ucuncu_at.Left +5)
            {
                lbl_canli.Text = "Tamer'in Oğlu yarışı birinci götürüyor";
            }
            if (ikinci_at.Left > birinci_at.Left + 5 && ikinci_at.Left > ucuncu_at.Left + 5)
            {
                lbl_canli.Text = "Johny Guitar liderliği ele geçirdi!!";
            }
            if (ucuncu_at.Left > birinci_at.Left + 5 && ucuncu_at.Left > ikinci_at.Left + 5)
            {
                lbl_canli.Text = "Şahbatur arka kulvardan geçiyorrr";
            }
            if ( birinci_atin_uzakligi+birinci_at.Left>=bitis_uzakligi  )
            {
                timer_start.Enabled = false;
                lbl_yaris_sonu.Text=("VEEE Tamer'in oğlu yarışı lider bitiriyor.");
            }
            if (ikinci_atin_uzakligi+ikinci_at.Left>=bitis_uzakligi)
            {
                timer_start.Enabled = false;
                lbl_yaris_sonu.Text=("VEEE Johny Guitar yarışı lider bitiriyor.");

            }
            if (ucuncu_atin_uzakligi+ucuncu_at.Left>=bitis_uzakligi)
            {
                timer_start.Enabled = false;
                lbl_yaris_sonu.Text=("VEEE Şahbatur yarışı lider bitiriyor.");
            }

        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            birinci_atuzaklik = birinci_at.Left;
            ikinci_atuzaklik = ikinci_at.Left;
            ucuncu_atuzaklık = ucuncu_at.Left;
            

       
        }

        
    }
}
