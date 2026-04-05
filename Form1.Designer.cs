namespace WinFormsApp7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            abtn = new Button();
            bbtn = new Button();
            cbtn = new Button();
            dbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            sorulbl = new Label();
            dogrulbl = new Label();
            yanlislbl = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            sonraki = new Button();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(4, 3);
            richTextBox1.Margin = new Padding(4, 3, 4, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(595, 257);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // abtn
            // 
            abtn.BackColor = Color.FromArgb(255, 128, 0);
            abtn.Location = new Point(4, 269);
            abtn.Margin = new Padding(4, 3, 4, 3);
            abtn.Name = "abtn";
            abtn.Size = new Size(294, 69);
            abtn.TabIndex = 1;
            abtn.Text = "A";
            abtn.UseVisualStyleBackColor = false;
            abtn.Click += abtn_Click;
            // 
            // bbtn
            // 
            bbtn.BackColor = Color.Yellow;
            bbtn.Location = new Point(306, 269);
            bbtn.Margin = new Padding(4, 3, 4, 3);
            bbtn.Name = "bbtn";
            bbtn.Size = new Size(294, 69);
            bbtn.TabIndex = 2;
            bbtn.Text = "B";
            bbtn.UseVisualStyleBackColor = false;
            bbtn.Click += bbtn_Click;
            // 
            // cbtn
            // 
            cbtn.BackColor = Color.Lime;
            cbtn.Location = new Point(4, 345);
            cbtn.Margin = new Padding(4, 3, 4, 3);
            cbtn.Name = "cbtn";
            cbtn.Size = new Size(294, 69);
            cbtn.TabIndex = 3;
            cbtn.Text = "C";
            cbtn.UseVisualStyleBackColor = false;
            cbtn.Click += cbtn_Click;
            // 
            // dbtn
            // 
            dbtn.BackColor = Color.FromArgb(255, 192, 255);
            dbtn.Location = new Point(306, 345);
            dbtn.Margin = new Padding(4, 3, 4, 3);
            dbtn.Name = "dbtn";
            dbtn.Size = new Size(294, 69);
            dbtn.TabIndex = 4;
            dbtn.Text = "D";
            dbtn.UseVisualStyleBackColor = false;
            dbtn.Click += dbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(678, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 24);
            label1.TabIndex = 5;
            label1.Text = "Soru:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(665, 85);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 24);
            label2.TabIndex = 6;
            label2.Text = "Doğru:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(667, 139);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 24);
            label3.TabIndex = 7;
            label3.Text = "Yanlış:";
            // 
            // sorulbl
            // 
            sorulbl.AutoSize = true;
            sorulbl.Location = new Point(780, 35);
            sorulbl.Margin = new Padding(4, 0, 4, 0);
            sorulbl.Name = "sorulbl";
            sorulbl.Size = new Size(20, 24);
            sorulbl.TabIndex = 8;
            sorulbl.Text = "0";
            // 
            // dogrulbl
            // 
            dogrulbl.AutoSize = true;
            dogrulbl.Location = new Point(780, 85);
            dogrulbl.Margin = new Padding(4, 0, 4, 0);
            dogrulbl.Name = "dogrulbl";
            dogrulbl.Size = new Size(20, 24);
            dogrulbl.TabIndex = 9;
            dogrulbl.Text = "0";
            // 
            // yanlislbl
            // 
            yanlislbl.AutoSize = true;
            yanlislbl.Location = new Point(780, 139);
            yanlislbl.Margin = new Padding(4, 0, 4, 0);
            yanlislbl.Name = "yanlislbl";
            yanlislbl.Size = new Size(20, 24);
            yanlislbl.TabIndex = 10;
            yanlislbl.Text = "0";
            // 
            // pictureBox1
            // 
            pictureBox1.Enabled = false;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(634, 286);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Enabled = false;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(766, 286);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(109, 111);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // sonraki
            // 
            sonraki.BackColor = SystemColors.InactiveCaption;
            sonraki.Location = new Point(634, 207);
            sonraki.Margin = new Padding(4, 3, 4, 3);
            sonraki.Name = "sonraki";
            sonraki.Size = new Size(241, 43);
            sonraki.TabIndex = 13;
            sonraki.Text = "Sonraki";
            sonraki.UseVisualStyleBackColor = false;
            sonraki.Click += sonraki_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Enabled = false;
            label4.Location = new Point(549, 475);
            label4.Name = "label4";
            label4.Size = new Size(61, 24);
            label4.TabIndex = 15;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Enabled = false;
            label5.Location = new Point(634, 475);
            label5.Name = "label5";
            label5.Size = new Size(61, 24);
            label5.TabIndex = 16;
            label5.Text = "label5";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 434);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(sonraki);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(yanlislbl);
            Controls.Add(dogrulbl);
            Controls.Add(sorulbl);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dbtn);
            Controls.Add(cbtn);
            Controls.Add(bbtn);
            Controls.Add(abtn);
            Controls.Add(richTextBox1);
            Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button abtn;
        private Button bbtn;
        private Button cbtn;
        private Button dbtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label sorulbl;
        private Label dogrulbl;
        private Label yanlislbl;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button sonraki;
        private Label label4;
        private Label label5;
    }
}
