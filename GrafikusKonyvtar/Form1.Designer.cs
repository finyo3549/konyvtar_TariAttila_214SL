namespace GrafikusKonyvtar
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
            listBox_Books = new ListBox();
            label1 = new Label();
            button_New = new Button();
            button_Modify = new Button();
            button_Delete = new Button();
            textBox_Title = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox_Author = new TextBox();
            label5 = new Label();
            numericUpDown_PublishYear = new NumericUpDown();
            numericUpDown_PageCount = new NumericUpDown();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_PublishYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_PageCount).BeginInit();
            SuspendLayout();
            // 
            // listBox_Books
            // 
            listBox_Books.FormattingEnabled = true;
            listBox_Books.ItemHeight = 15;
            listBox_Books.Location = new Point(30, 50);
            listBox_Books.Name = "listBox_Books";
            listBox_Books.Size = new Size(233, 364);
            listBox_Books.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 22);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 1;
            label1.Text = "Könyvek ";
            // 
            // button_New
            // 
            button_New.Location = new Point(338, 389);
            button_New.Name = "button_New";
            button_New.Size = new Size(75, 23);
            button_New.TabIndex = 2;
            button_New.Text = "Új";
            button_New.UseVisualStyleBackColor = true;
            button_New.Click += button_New_Click;
            // 
            // button_Modify
            // 
            button_Modify.Location = new Point(461, 389);
            button_Modify.Name = "button_Modify";
            button_Modify.Size = new Size(75, 23);
            button_Modify.TabIndex = 3;
            button_Modify.Text = "Módosít";
            button_Modify.UseVisualStyleBackColor = true;
            button_Modify.Click += button_Modify_Click;
            // 
            // button_Delete
            // 
            button_Delete.Location = new Point(580, 389);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(75, 23);
            button_Delete.TabIndex = 4;
            button_Delete.Text = "Töröl";
            button_Delete.UseVisualStyleBackColor = true;
            button_Delete.Click += button_Delete_Click;
            // 
            // textBox_Title
            // 
            textBox_Title.Location = new Point(389, 49);
            textBox_Title.Name = "textBox_Title";
            textBox_Title.Size = new Size(351, 23);
            textBox_Title.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(307, 52);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 6;
            label2.Text = "Cím";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(307, 94);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 8;
            label3.Text = "Szerző";
            // 
            // textBox_Author
            // 
            textBox_Author.Location = new Point(389, 91);
            textBox_Author.Name = "textBox_Author";
            textBox_Author.Size = new Size(351, 23);
            textBox_Author.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(307, 136);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 12;
            label5.Text = "Kiadás éve";
            // 
            // numericUpDown_PublishYear
            // 
            numericUpDown_PublishYear.Location = new Point(389, 134);
            numericUpDown_PublishYear.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown_PublishYear.Name = "numericUpDown_PublishYear";
            numericUpDown_PublishYear.Size = new Size(120, 23);
            numericUpDown_PublishYear.TabIndex = 13;
            // 
            // numericUpDown_PageCount
            // 
            numericUpDown_PageCount.Location = new Point(389, 178);
            numericUpDown_PageCount.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown_PageCount.Name = "numericUpDown_PageCount";
            numericUpDown_PageCount.Size = new Size(120, 23);
            numericUpDown_PageCount.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(307, 180);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 14;
            label6.Text = "Oldalszám";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDown_PageCount);
            Controls.Add(label6);
            Controls.Add(numericUpDown_PublishYear);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(textBox_Author);
            Controls.Add(label2);
            Controls.Add(textBox_Title);
            Controls.Add(button_Delete);
            Controls.Add(button_Modify);
            Controls.Add(button_New);
            Controls.Add(label1);
            Controls.Add(listBox_Books);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown_PublishYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_PageCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox_Books;
        private Label label1;
        private Button button_New;
        private Button button_Modify;
        private Button button_Delete;
        private TextBox textBox_Title;
        private Label label2;
        private Label label3;
        private TextBox textBox_Author;
        private Label label5;
        private NumericUpDown numericUpDown_PublishYear;
        private NumericUpDown numericUpDown_PageCount;
        private Label label6;
    }
}
