namespace WinFormsApp7
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }

        

        int soru = 0, dogru = 0, yanlis = 0;
        private void sonraki_Click(object sender, EventArgs e)
        {
            abtn.Enabled = true;
            bbtn.Enabled = true;
            cbtn.Enabled = true;
            dbtn.Enabled = true;
            sonraki.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            soru++;
            sorulbl.Text = soru.ToString();

            if (soru == 1)
            {
                richTextBox1.Text = "UEFA Kupasını alan ilk Türk takımı hangisidir?";
                abtn.Text = "Fenerbahçe";
                bbtn.Text = "Trabzonspor";
                cbtn.Text = "Beşiktaş";
                dbtn.Text = "Galatasaray";
                label4.Text = "Galatasaray";
            }
            if (soru == 2)
            {
                richTextBox1.Text = "Kayseri hangi bölgededir?";
                abtn.Text = "İç Anadolu";
                bbtn.Text = "Güneydoğu";
                cbtn.Text = "Karadeniz";
                dbtn.Text = "Batı";
                label4.Text = "İç Anadolu";

            }
            if (soru == 3)
            {
                richTextBox1.Text = "Pisagor teoremi hangi bilim dalıyla ilgilidir ?";
                abtn.Text = "Coğrafya";
                bbtn.Text = "Tarih";
                cbtn.Text = "Matematik";
                dbtn.Text = "Edebiyat";
                label4.Text = "Matematik";

            }
            if (soru == 4)
            {
                sonraki.Text = "Sonuçlar";
                abtn.Enabled = false;
                bbtn.Enabled = false;
                cbtn.Enabled = false;
                dbtn.Enabled = false;
                sonraki.Enabled = true;
                MessageBox.Show("doğrular: "+ dogru +"\n" + "yanlışlar: "+ yanlis);
                sonraki.Enabled = false;

            }
        }

        private void abtn_Click(object sender, EventArgs e)
        {
            abtn.Enabled = false;
            bbtn.Enabled = false;
            cbtn.Enabled = false;
            dbtn.Enabled = false;
            sonraki.Enabled = true;


            label5.Text = abtn.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                dogrulbl.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                yanlislbl.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void bbtn_Click(object sender, EventArgs e)
        {
            abtn.Enabled = false; bbtn.Enabled = false; cbtn.Enabled = false; dbtn.Enabled = false;
            sonraki.Enabled = true;

            label5.Text = bbtn.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                dogrulbl.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                yanlislbl.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void cbtn_Click(object sender, EventArgs e)
        {
            abtn.Enabled = false;
            bbtn.Enabled = false;
            cbtn.Enabled = false;
            dbtn.Enabled = false;
            sonraki.Enabled = true;

            label5.Text = cbtn.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                dogrulbl.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                yanlislbl.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void dbtn_Click(object sender, EventArgs e)
        {
            abtn.Enabled = false;
            bbtn.Enabled = false;
            cbtn.Enabled = false;
            dbtn.Enabled = false;
            sonraki.Enabled = true;

            label5.Text = dbtn.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                dogrulbl.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                yanlislbl.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }
    }
}
