using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA6
{
    public partial class frmEdit : Form
    {
        private Book myBook;
        private string cwid;
        private string mode;
        public frmEdit(Object tempBook, string tempMode, string tempcwid)
        {
            myBook = (Book)tempBook;
            cwid = tempcwid;
            mode = tempMode;
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void booklist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lengthtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void lengthlbl_Click(object sender, EventArgs e)
        {

        }

        private void isbntxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void isbnlbl_Click(object sender, EventArgs e)
        {

        }

        private void copiestxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void copieslbl_Click(object sender, EventArgs e)
        {

        }

        private void authortxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void authorlbl_Click(object sender, EventArgs e)
        {

        }

        private void genretxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void genrelbl_Click(object sender, EventArgs e)
        {

        }

        private void titlebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void titletxt_Click(object sender, EventArgs e)
        {

        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            if(mode=="edit")
            {
                titlebox.Text = myBook.title;
                authortxt.Text = myBook.author;
                genretxt.Text = myBook.genre;
                copiestxt.Text = myBook.copies.ToString();
                isbntxt.Text = myBook.isbn;
                textBox1.Text = myBook.cover;
                lengthtxt.Text = myBook.length.ToString();

                pictureBox1.Load(myBook.cover);

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
