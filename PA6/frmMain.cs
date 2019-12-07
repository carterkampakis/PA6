﻿using System;
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
    public partial class frmMain : Form
    {
        string cwid;
        List<Book> myBooks;

        public frmMain(string tempCwid)
        {
            this.cwid = tempCwid;
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void LoadList()
        {
            myBooks = BookFile.GetAllBooks(cwid);
            booklist.DataSource = myBooks;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void copiestxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void lengthlbl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void booklist_SelectedIndexChanged(object sender, EventArgs e)
        {
            Book myBook = (Book)booklist.SelectedItem;
            titletxt.Text = myBook.title;
            authortxt.Text = myBook.author;
            genretxt.Text = myBook.genre;
            isbntxt.Text = myBook.isbn;
            copiestxt.Text = myBook.copies.ToString();
            lengthtxt.Text = myBook.length.ToString();

            try
            {
                pictureBox1.Load(myBook.cover);
            }
            catch
            {

            }
        }
    }
}
