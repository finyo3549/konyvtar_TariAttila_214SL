using KonyvtarAsztaliKonzolos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrafikusKonyvtar
{
    public partial class NewForm : Form
    {
        public NewForm()
        {
            InitializeComponent();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            if(textBox_Author.Text != "" && textBox_Title.Text != "" && numericUpDown_PageCount.Value != 0 && numericUpDown_PublishYear.Value != 0)
            {
                book.Author = textBox_Author.Text;
                book.Title = textBox_Title.Text;
                book.Page_count = (int)numericUpDown_PageCount.Value;
                book.Publish_year = (int)numericUpDown_PublishYear.Value;
                Program.db.Insert(book);

                this.Close();
            }
            else
            {
                MessageBox.Show("Nem adtál meg minden adatot!");
            }
            

        }
    }
}
