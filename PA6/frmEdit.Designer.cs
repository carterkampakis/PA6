namespace PA6
{
    partial class frmEdit
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
            this.lengthtxt = new System.Windows.Forms.TextBox();
            this.lengthlbl = new System.Windows.Forms.Label();
            this.isbntxt = new System.Windows.Forms.TextBox();
            this.isbnlbl = new System.Windows.Forms.Label();
            this.copiestxt = new System.Windows.Forms.TextBox();
            this.copieslbl = new System.Windows.Forms.Label();
            this.authortxt = new System.Windows.Forms.TextBox();
            this.authorlbl = new System.Windows.Forms.Label();
            this.genretxt = new System.Windows.Forms.TextBox();
            this.genrelbl = new System.Windows.Forms.Label();
            this.titlebox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.titletxt = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtCoverDate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lengthtxt
            // 
            this.lengthtxt.Location = new System.Drawing.Point(101, 643);
            this.lengthtxt.Name = "lengthtxt";
            this.lengthtxt.Size = new System.Drawing.Size(175, 28);
            this.lengthtxt.TabIndex = 26;
            this.lengthtxt.TextChanged += new System.EventHandler(this.lengthtxt_TextChanged);
            // 
            // lengthlbl
            // 
            this.lengthlbl.AutoSize = true;
            this.lengthlbl.Location = new System.Drawing.Point(97, 616);
            this.lengthlbl.Name = "lengthlbl";
            this.lengthlbl.Size = new System.Drawing.Size(68, 24);
            this.lengthlbl.TabIndex = 25;
            this.lengthlbl.Text = "Length";
            this.lengthlbl.Click += new System.EventHandler(this.lengthlbl_Click);
            // 
            // isbntxt
            // 
            this.isbntxt.Location = new System.Drawing.Point(101, 546);
            this.isbntxt.Name = "isbntxt";
            this.isbntxt.Size = new System.Drawing.Size(175, 28);
            this.isbntxt.TabIndex = 24;
            this.isbntxt.TextChanged += new System.EventHandler(this.isbntxt_TextChanged);
            // 
            // isbnlbl
            // 
            this.isbnlbl.AutoSize = true;
            this.isbnlbl.Location = new System.Drawing.Point(97, 519);
            this.isbnlbl.Name = "isbnlbl";
            this.isbnlbl.Size = new System.Drawing.Size(52, 24);
            this.isbnlbl.TabIndex = 23;
            this.isbnlbl.Text = "ISBN";
            this.isbnlbl.Click += new System.EventHandler(this.isbnlbl_Click);
            // 
            // copiestxt
            // 
            this.copiestxt.Location = new System.Drawing.Point(101, 449);
            this.copiestxt.Name = "copiestxt";
            this.copiestxt.Size = new System.Drawing.Size(175, 28);
            this.copiestxt.TabIndex = 22;
            this.copiestxt.TextChanged += new System.EventHandler(this.copiestxt_TextChanged);
            // 
            // copieslbl
            // 
            this.copieslbl.AutoSize = true;
            this.copieslbl.Location = new System.Drawing.Point(97, 422);
            this.copieslbl.Name = "copieslbl";
            this.copieslbl.Size = new System.Drawing.Size(105, 24);
            this.copieslbl.TabIndex = 21;
            this.copieslbl.Text = "Copies Avl.";
            this.copieslbl.Click += new System.EventHandler(this.copieslbl_Click);
            // 
            // authortxt
            // 
            this.authortxt.Location = new System.Drawing.Point(100, 283);
            this.authortxt.Name = "authortxt";
            this.authortxt.Size = new System.Drawing.Size(175, 28);
            this.authortxt.TabIndex = 20;
            this.authortxt.TextChanged += new System.EventHandler(this.authortxt_TextChanged);
            // 
            // authorlbl
            // 
            this.authorlbl.AutoSize = true;
            this.authorlbl.Location = new System.Drawing.Point(97, 256);
            this.authorlbl.Name = "authorlbl";
            this.authorlbl.Size = new System.Drawing.Size(66, 24);
            this.authorlbl.TabIndex = 19;
            this.authorlbl.Text = "Author";
            this.authorlbl.Click += new System.EventHandler(this.authorlbl_Click);
            // 
            // genretxt
            // 
            this.genretxt.Location = new System.Drawing.Point(100, 365);
            this.genretxt.Name = "genretxt";
            this.genretxt.Size = new System.Drawing.Size(175, 28);
            this.genretxt.TabIndex = 18;
            this.genretxt.TextChanged += new System.EventHandler(this.genretxt_TextChanged);
            // 
            // genrelbl
            // 
            this.genrelbl.AutoSize = true;
            this.genrelbl.Location = new System.Drawing.Point(96, 338);
            this.genrelbl.Name = "genrelbl";
            this.genrelbl.Size = new System.Drawing.Size(63, 24);
            this.genrelbl.TabIndex = 17;
            this.genrelbl.Text = "Genre";
            this.genrelbl.Click += new System.EventHandler(this.genrelbl_Click);
            // 
            // titlebox
            // 
            this.titlebox.Location = new System.Drawing.Point(100, 190);
            this.titlebox.Name = "titlebox";
            this.titlebox.Size = new System.Drawing.Size(175, 28);
            this.titlebox.TabIndex = 16;
            this.titlebox.TextChanged += new System.EventHandler(this.titlebox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 15;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // titletxt
            // 
            this.titletxt.AutoSize = true;
            this.titletxt.Location = new System.Drawing.Point(97, 163);
            this.titletxt.Name = "titletxt";
            this.titletxt.Size = new System.Drawing.Size(45, 24);
            this.titletxt.TabIndex = 14;
            this.titletxt.Text = "Title";
            this.titletxt.Click += new System.EventHandler(this.titletxt_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 741);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 28);
            this.textBox1.TabIndex = 28;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCoverDate
            // 
            this.txtCoverDate.AutoSize = true;
            this.txtCoverDate.Location = new System.Drawing.Point(97, 714);
            this.txtCoverDate.Name = "txtCoverDate";
            this.txtCoverDate.Size = new System.Drawing.Size(101, 24);
            this.txtCoverDate.TabIndex = 27;
            this.txtCoverDate.Text = "Cover URL";
            this.txtCoverDate.Click += new System.EventHandler(this.txtCoverDate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(440, 190);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(331, 300);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(440, 501);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 108);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(595, 501);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(176, 108);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 1078);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtCoverDate);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmEdit";
            this.Text = "frmEdit";
            this.Load += new System.EventHandler(this.frmEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox lengthtxt;
        private System.Windows.Forms.Label lengthlbl;
        private System.Windows.Forms.TextBox isbntxt;
        private System.Windows.Forms.Label isbnlbl;
        private System.Windows.Forms.TextBox copiestxt;
        private System.Windows.Forms.Label copieslbl;
        private System.Windows.Forms.TextBox authortxt;
        private System.Windows.Forms.Label authorlbl;
        private System.Windows.Forms.TextBox genretxt;
        private System.Windows.Forms.Label genrelbl;
        private System.Windows.Forms.TextBox titlebox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label titletxt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtCoverDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}