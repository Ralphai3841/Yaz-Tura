using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazıTura
{
    public partial class DoWhileExample : Form
    {
        public DoWhileExample()
        {
            InitializeComponent();
        }

        Random random = new Random();
        private void btnGuess_Click(object sender, EventArgs e)
        {
            string[] questions = { "Yes", "No" };  // yes => Yazı, no => Tura
            string question = "";
            DialogResult result;
            do
            {
                int number = random.Next(0, 2);
                question = questions[number];
                result = MessageBox.Show("Yazı mı? Tura mı?\nYazı ise Yes\n Tura ise no seçeneğini seçiniz.", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            } while (result.ToString() != question);
            MessageBox.Show("Kazandınız");
        }
    }
}
