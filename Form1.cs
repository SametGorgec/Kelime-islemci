using System.Windows.Forms;

namespace Kelime_işlemci
{
    public partial class samet_grgc : Form
    {
        public samet_grgc()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void samet_grgc_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
                comboBox1.Items.Add(font.Name);
            comboBox1.SelectedIndex = 165;

            float[] fontSize = new float[]
            {
                2,3,4,5,6,7,8,9,10,
                11,12,14,16,18,20,
                22,24,26,28,36,48,72
            };

            foreach (float size in fontSize)
                cbBoyut.Items.Add(size);
            cbBoyut.SelectedIndex = 12;
                    

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Bold);
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ApplyFont();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFont();
        }

        private void ApplyFont()
        {
            if(comboBox1.SelectedItem != null && cbBoyut.SelectedItem != null)
            {
                string secilenFont = comboBox1.SelectedItem.ToString();
                float secilenboyut = float.Parse(cbBoyut.SelectedItem.ToString());

                richTextBox1.SelectionFont = new Font(secilenFont, secilenboyut);
            }
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Italic);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Underline);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Regular);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Font eski = richTextBox1.Font;
            richTextBox1.Font = new Font(eski.FontFamily, eski.Size + 1, eski.Style);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Font eski = richTextBox1.Font;
            richTextBox1.Font = new Font(eski.FontFamily, eski.Size - 2, eski.Style);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Blue;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Green;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Yellow;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Purple;
        }


        private void cbBoyut_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                float yeniBoyut = float.Parse(cbBoyut.SelectedItem.ToString());
                Font eski = richTextBox1.Font;
                richTextBox1.Font = new Font(eski.FontFamily, yeniBoyut, eski.Style);
            }
            catch
            {
                MessageBox.Show("Geçerli bir yazı boyutu seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
