namespace PuanFikstürü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int sayi1, sayi2, sayi3, sayi4, sayi5, sayi6, sayi7, sayi8, sayi9, sayi10, sayi11, sayi12;
        int gs = 0; int fb = 0; int bjk = 0; int ts = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            sayi1 = rastgele.Next(1, 5);
            label2.Text = sayi1.ToString();
            sayi2 = rastgele.Next(1, 5);
            label4.Text = sayi2.ToString();
            sayi3 = rastgele.Next(1, 5);
            label20.Text = sayi3.ToString();
            sayi4 = rastgele.Next(1, 5);
            label19.Text = sayi4.ToString();
            sayi5 = rastgele.Next(1, 5);
            gslabel1.Text = sayi5.ToString();
            sayi6 = rastgele.Next(1, 5);
            bjklabel.Text = sayi6.ToString();

            if (Convert.ToInt32(label2.Text) > (Convert.ToInt32(label4.Text)))
            {
                gs = gs + 3;
                label10.Text = gs.ToString();
            }
            if (Convert.ToInt32(label4.Text) > (Convert.ToInt32(label2.Text)))
            {
                fb = fb + 3;
                label11.Text = fb.ToString();
            }
            if (Convert.ToInt32(label2.Text) == (Convert.ToInt32(label4.Text)))
            {
                fb = fb + 1;
                gs = gs + 1;
                label10.Text = gs.ToString();
                label11.Text = fb.ToString();
            }

                if (Convert.ToInt32(label20.Text) > (Convert.ToInt32(label19.Text)))
                {
                    ts = ts + 3;
                    label12.Text = ts.ToString();
                }
                if (Convert.ToInt32(label19.Text) > (Convert.ToInt32(label20.Text)))
                {
                    gs = gs + 3;
                    label10.Text = gs.ToString();
                }
            if (Convert.ToInt32(label19.Text) == (Convert.ToInt32(label20.Text)))
            {
                gs = gs + 1;
                ts = ts + 1;
                label10.Text = gs.ToString();
                label12.Text = ts.ToString();
            }
                    if (Convert.ToInt32(gslabel1.Text) > (Convert.ToInt32(bjklabel.Text)))
                    {
                        gs = gs + 3;
                        label10.Text = gs.ToString();
                    }
                    if (Convert.ToInt32(bjklabel.Text) > (Convert.ToInt32(gslabel1.Text)))
                    {
                        bjk = bjk + 3;
                        label13.Text = bjk.ToString();
                    }
            if (Convert.ToInt32(gslabel1.Text) == (Convert.ToInt32(bjklabel.Text)))
            {
                gs = gs + 1;
                bjk = bjk + 1;
                label10.Text = gs.ToString();
                label13.Text = bjk.ToString();
                    }

                }
            }
        }