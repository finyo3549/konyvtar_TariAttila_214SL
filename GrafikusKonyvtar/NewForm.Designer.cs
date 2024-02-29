namespace GrafikusKonyvtar
{
    partial class NewForm
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
            numericUpDown_PageCount = new NumericUpDown();
            label6 = new Label();
            numericUpDown_PublishYear = new NumericUpDown();
            label5 = new Label();
            label3 = new Label();
            textBox_Author = new TextBox();
            label2 = new Label();
            textBox_Title = new TextBox();
            button_Submit = new Button();
            button_Back = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_PageCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_PublishYear).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown_PageCount
            // 
            numericUpDown_PageCount.Location = new Point(266, 278);
            numericUpDown_PageCount.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown_PageCount.Name = "numericUpDown_PageCount";
            numericUpDown_PageCount.Size = new Size(120, 23);
            numericUpDown_PageCount.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(184, 280);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 22;
            label6.Text = "Oldalszám";
            // 
            // numericUpDown_PublishYear
            // 
            numericUpDown_PublishYear.Location = new Point(266, 234);
            numericUpDown_PublishYear.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown_PublishYear.Name = "numericUpDown_PublishYear";
            numericUpDown_PublishYear.Size = new Size(120, 23);
            numericUpDown_PublishYear.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(184, 236);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 20;
            label5.Text = "Kiadás éve";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(184, 194);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 19;
            label3.Text = "Szerző";
            // 
            // textBox_Author
            // 
            textBox_Author.Location = new Point(266, 191);
            textBox_Author.Name = "textBox_Author";
            textBox_Author.Size = new Size(351, 23);
            textBox_Author.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(184, 152);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 17;
            label2.Text = "Cím";
            // 
            // textBox_Title
            // 
            textBox_Title.Location = new Point(266, 149);
            textBox_Title.Name = "textBox_Title";
            textBox_Title.Size = new Size(351, 23);
            textBox_Title.TabIndex = 16;
            // 
            // button_Submit
            // 
            button_Submit.Location = new Point(311, 345);
            button_Submit.Name = "button_Submit";
            button_Submit.Size = new Size(75, 23);
            button_Submit.TabIndex = 24;
            button_Submit.Text = "Rögzít";
            button_Submit.UseVisualStyleBackColor = true;
            button_Submit.Click += button_Submit_Click;
            // 
            // button_Back
            // 
            button_Back.Location = new Point(454, 345);
            button_Back.Name = "button_Back";
            button_Back.Size = new Size(75, 23);
            button_Back.TabIndex = 25;
            button_Back.Text = "Vissza";
            button_Back.UseVisualStyleBackColor = true;
            button_Back.Click += button_Back_Click;
            // 
            // NewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Back);
            Controls.Add(button_Submit);
            Controls.Add(numericUpDown_PageCount);
            Controls.Add(label6);
            Controls.Add(numericUpDown_PublishYear);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(textBox_Author);
            Controls.Add(label2);
            Controls.Add(textBox_Title);
            Name = "NewForm";
            Text = "NewForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_PageCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_PublishYear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown_PageCount;
        private Label label6;
        private NumericUpDown numericUpDown_PublishYear;
        private Label label5;
        private Label label3;
        private TextBox textBox_Author;
        private Label label2;
        private TextBox textBox_Title;
        private Button button_Submit;
        private Button button_Back;
    }
}