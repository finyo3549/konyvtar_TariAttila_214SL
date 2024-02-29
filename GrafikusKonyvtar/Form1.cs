namespace GrafikusKonyvtar
{
    using KonyvtarAsztaliKonzolos;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox_Books.SelectedIndexChanged += listBox_Books_SelectedIndexChanged;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            foreach (Book book in Program.books)
            {
                listBox_Books.Items.Add(book.Title);
            }
        }
        private void listBox_Books_SelectedIndexChanged(object sender, EventArgs e)
        {
            Book book = Program.books[listBox_Books.SelectedIndex];
            textBox_Author.Text = book.Author;
            textBox_Title.Text = book.Title;
            numericUpDown_PageCount.Value = (int)book.Page_count;
            numericUpDown_PublishYear.Value = (int)book.Publish_year;
        }

        private void button_Modify_Click(object sender, EventArgs e)
        {
            if (listBox_Books.SelectedIndex != -1)
            {
                Book book = Program.books[listBox_Books.SelectedIndex];
                book.Author = textBox_Author.Text;
                book.Title = textBox_Title.Text;
                book.Page_count = (int)numericUpDown_PageCount.Value;
                book.Publish_year = (int)numericUpDown_PublishYear.Value;
                Program.db.Patch(book);
            }
            else MessageBox.Show("Nincs kiválasztott könyv!");
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (listBox_Books.SelectedIndex != -1)
            {
                Book book = Program.books[listBox_Books.SelectedIndex];
                book.Author = textBox_Author.Text;
                book.Title = textBox_Title.Text;
                book.Page_count = (int)numericUpDown_PageCount.Value;
                book.Publish_year = (int)numericUpDown_PublishYear.Value;
                Program.db.Delete(book);
            }
            else MessageBox.Show("Nincs kiválasztott könyv!");
        }

        private void button_New_Click(object sender, EventArgs e)
        {
            NewForm newForm = new NewForm();
            newForm.Show();
            
        }
        

    }
}
