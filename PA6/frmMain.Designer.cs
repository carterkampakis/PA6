namespace PA6
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.titletxt = new System.Windows.Forms.Label();
            this.titlebox = new System.Windows.Forms.TextBox();
            this.genretxt = new System.Windows.Forms.TextBox();
            this.genrelbl = new System.Windows.Forms.Label();
            this.authortxt = new System.Windows.Forms.TextBox();
            this.authorlbl = new System.Windows.Forms.Label();
            this.copiestxt = new System.Windows.Forms.TextBox();
            this.copieslbl = new System.Windows.Forms.Label();
            this.isbntxt = new System.Windows.Forms.TextBox();
            this.isbnlbl = new System.Windows.Forms.Label();
            this.lengthtxt = new System.Windows.Forms.TextBox();
            this.lengthlbl = new System.Windows.Forms.Label();
            this.booklist = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Rentbtn = new System.Windows.Forms.Button();
            this.Returnbtn = new System.Windows.Forms.Button();
            this.Newbtn = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Closebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 44);
            this.label1.TabIndex = 1;
            // 
            // titletxt
            // 
            this.titletxt.AutoSize = true;
            this.titletxt.Location = new System.Drawing.Point(384, 11);
            this.titletxt.Name = "titletxt";
            this.titletxt.Size = new System.Drawing.Size(93, 44);
            this.titletxt.TabIndex = 0;
            this.titletxt.Text = "Title";
            // 
            // titlebox
            // 
            this.titlebox.Location = new System.Drawing.Point(390, 47);
            this.titlebox.Name = "titlebox";
            this.titlebox.Size = new System.Drawing.Size(175, 50);
            this.titlebox.TabIndex = 2;
            // 
            // genretxt
            // 
            this.genretxt.Location = new System.Drawing.Point(390, 206);
            this.genretxt.Name = "genretxt";
            this.genretxt.Size = new System.Drawing.Size(175, 50);
            this.genretxt.TabIndex = 4;
            // 
            // genrelbl
            // 
            this.genrelbl.AutoSize = true;
            this.genrelbl.Location = new System.Drawing.Point(384, 170);
            this.genrelbl.Name = "genrelbl";
            this.genrelbl.Size = new System.Drawing.Size(126, 44);
            this.genrelbl.TabIndex = 3;
            this.genrelbl.Text = "Genre";
            // 
            // authortxt
            // 
            this.authortxt.Location = new System.Drawing.Point(390, 128);
            this.authortxt.Name = "authortxt";
            this.authortxt.Size = new System.Drawing.Size(175, 50);
            this.authortxt.TabIndex = 6;
            // 
            // authorlbl
            // 
            this.authorlbl.AutoSize = true;
            this.authorlbl.Location = new System.Drawing.Point(384, 92);
            this.authorlbl.Name = "authorlbl";
            this.authorlbl.Size = new System.Drawing.Size(132, 44);
            this.authorlbl.TabIndex = 5;
            this.authorlbl.Text = "Author";
            this.authorlbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // copiestxt
            // 
            this.copiestxt.Location = new System.Drawing.Point(390, 284);
            this.copiestxt.Name = "copiestxt";
            this.copiestxt.Size = new System.Drawing.Size(175, 50);
            this.copiestxt.TabIndex = 8;
            this.copiestxt.TextChanged += new System.EventHandler(this.copiestxt_TextChanged);
            // 
            // copieslbl
            // 
            this.copieslbl.AutoSize = true;
            this.copieslbl.Location = new System.Drawing.Point(384, 248);
            this.copieslbl.Name = "copieslbl";
            this.copieslbl.Size = new System.Drawing.Size(212, 44);
            this.copieslbl.TabIndex = 7;
            this.copieslbl.Text = "Copies Avl.";
            // 
            // isbntxt
            // 
            this.isbntxt.Location = new System.Drawing.Point(390, 362);
            this.isbntxt.Name = "isbntxt";
            this.isbntxt.Size = new System.Drawing.Size(175, 50);
            this.isbntxt.TabIndex = 10;
            // 
            // isbnlbl
            // 
            this.isbnlbl.AutoSize = true;
            this.isbnlbl.Location = new System.Drawing.Point(384, 326);
            this.isbnlbl.Name = "isbnlbl";
            this.isbnlbl.Size = new System.Drawing.Size(107, 44);
            this.isbnlbl.TabIndex = 9;
            this.isbnlbl.Text = "ISBN";
            // 
            // lengthtxt
            // 
            this.lengthtxt.Location = new System.Drawing.Point(390, 440);
            this.lengthtxt.Name = "lengthtxt";
            this.lengthtxt.Size = new System.Drawing.Size(175, 50);
            this.lengthtxt.TabIndex = 12;
            // 
            // lengthlbl
            // 
            this.lengthlbl.AutoSize = true;
            this.lengthlbl.Location = new System.Drawing.Point(384, 404);
            this.lengthlbl.Name = "lengthlbl";
            this.lengthlbl.Size = new System.Drawing.Size(136, 44);
            this.lengthlbl.TabIndex = 11;
            this.lengthlbl.Text = "Length";
            this.lengthlbl.Click += new System.EventHandler(this.lengthlbl_Click);
            // 
            // booklist
            // 
            this.booklist.FormattingEnabled = true;
            this.booklist.ItemHeight = 44;
            this.booklist.Location = new System.Drawing.Point(12, 14);
            this.booklist.Name = "booklist";
            this.booklist.Size = new System.Drawing.Size(362, 444);
            this.booklist.TabIndex = 13;
            this.booklist.SelectedIndexChanged += new System.EventHandler(this.booklist_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(624, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(331, 300);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Rentbtn
            // 
            this.Rentbtn.Location = new System.Drawing.Point(635, 334);
            this.Rentbtn.Name = "Rentbtn";
            this.Rentbtn.Size = new System.Drawing.Size(133, 65);
            this.Rentbtn.TabIndex = 15;
            this.Rentbtn.Text = "Rent";
            this.Rentbtn.UseVisualStyleBackColor = true;
            this.Rentbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Returnbtn
            // 
            this.Returnbtn.Location = new System.Drawing.Point(807, 334);
            this.Returnbtn.Name = "Returnbtn";
            this.Returnbtn.Size = new System.Drawing.Size(133, 65);
            this.Returnbtn.TabIndex = 16;
            this.Returnbtn.Text = "Return";
            this.Returnbtn.UseVisualStyleBackColor = true;
            // 
            // Newbtn
            // 
            this.Newbtn.Location = new System.Drawing.Point(571, 440);
            this.Newbtn.Name = "Newbtn";
            this.Newbtn.Size = new System.Drawing.Size(103, 43);
            this.Newbtn.TabIndex = 17;
            this.Newbtn.Text = "New";
            this.Newbtn.UseVisualStyleBackColor = true;
            this.Newbtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(680, 440);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(88, 43);
            this.Addbtn.TabIndex = 18;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.Location = new System.Drawing.Point(774, 440);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(108, 43);
            this.Deletebtn.TabIndex = 19;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Closebtn
            // 
            this.Closebtn.Location = new System.Drawing.Point(888, 440);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(102, 43);
            this.Closebtn.TabIndex = 20;
            this.Closebtn.Text = "Close";
            this.Closebtn.UseVisualStyleBackColor = true;
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 44F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 537);
            this.Controls.Add(this.Closebtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.Newbtn);
            this.Controls.Add(this.Returnbtn);
            this.Controls.Add(this.Rentbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.booklist);
            this.Controls.Add(this.lengthtxt);
            this.Controls.Add(this.lengthlbl);
            this.Controls.Add(this.isbntxt);
            this.Controls.Add(this.isbnlbl);
            this.Controls.Add(this.copiestxt);
            this.Controls.Add(this.copieslbl);
            this.Controls.Add(this.authortxt);
            this.Controls.Add(this.authorlbl);
            this.Controls.Add(this.genretxt);
            this.Controls.Add(this.genrelbl);
            this.Controls.Add(this.titlebox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titletxt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label titletxt;
        private System.Windows.Forms.TextBox titlebox;
        private System.Windows.Forms.TextBox genretxt;
        private System.Windows.Forms.Label genrelbl;
        private System.Windows.Forms.TextBox authortxt;
        private System.Windows.Forms.Label authorlbl;
        private System.Windows.Forms.TextBox copiestxt;
        private System.Windows.Forms.Label copieslbl;
        private System.Windows.Forms.TextBox isbntxt;
        private System.Windows.Forms.Label isbnlbl;
        private System.Windows.Forms.TextBox lengthtxt;
        private System.Windows.Forms.Label lengthlbl;
        private System.Windows.Forms.ListBox booklist;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Rentbtn;
        private System.Windows.Forms.Button Returnbtn;
        private System.Windows.Forms.Button Newbtn;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Closebtn;
    }
}