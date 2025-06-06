namespace Kursova
{
    partial class FormFilter
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
            ButtonBack = new Button();
            buttonFilter = new Button();
            label1 = new Label();
            textBoxNameFilter = new TextBox();
            label2 = new Label();
            textBoxLatitudeMin = new TextBox();
            label3 = new Label();
            textBoxLatitudeMax = new TextBox();
            textBoxLongitudeMax = new TextBox();
            label4 = new Label();
            textBoxLongitudeMin = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // ButtonBack
            // 
            ButtonBack.Location = new Point(12, 12);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(94, 29);
            ButtonBack.TabIndex = 10;
            ButtonBack.Text = "Назад";
            ButtonBack.UseVisualStyleBackColor = true;
            ButtonBack.Click += ButtonBack_Click;
            // 
            // buttonFilter
            // 
            buttonFilter.Location = new Point(280, 231);
            buttonFilter.Name = "buttonFilter";
            buttonFilter.Size = new Size(139, 29);
            buttonFilter.TabIndex = 11;
            buttonFilter.Text = " Відфільтрувати";
            buttonFilter.UseVisualStyleBackColor = true;
            buttonFilter.Click += buttonFilter_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 83);
            label1.Name = "label1";
            label1.Size = new Size(189, 20);
            label1.TabIndex = 12;
            label1.Text = "Відфільтрувати за назвою";
            // 
            // textBoxNameFilter
            // 
            textBoxNameFilter.Location = new Point(280, 80);
            textBoxNameFilter.Name = "textBoxNameFilter";
            textBoxNameFilter.Size = new Size(139, 27);
            textBoxNameFilter.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 138);
            label2.Name = "label2";
            label2.Size = new Size(226, 20);
            label2.TabIndex = 14;
            label2.Text = "Відфільтрувати за широтою від";
            // 
            // textBoxLatitudeMin
            // 
            textBoxLatitudeMin.Location = new Point(280, 135);
            textBoxLatitudeMin.Name = "textBoxLatitudeMin";
            textBoxLatitudeMin.Size = new Size(139, 27);
            textBoxLatitudeMin.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(442, 138);
            label3.Name = "label3";
            label3.Size = new Size(26, 20);
            label3.TabIndex = 16;
            label3.Text = "до";
            // 
            // textBoxLatitudeMax
            // 
            textBoxLatitudeMax.Location = new Point(474, 135);
            textBoxLatitudeMax.Name = "textBoxLatitudeMax";
            textBoxLatitudeMax.Size = new Size(139, 27);
            textBoxLatitudeMax.TabIndex = 17;
            // 
            // textBoxLongitudeMax
            // 
            textBoxLongitudeMax.Location = new Point(474, 186);
            textBoxLongitudeMax.Name = "textBoxLongitudeMax";
            textBoxLongitudeMax.Size = new Size(139, 27);
            textBoxLongitudeMax.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(442, 189);
            label4.Name = "label4";
            label4.Size = new Size(26, 20);
            label4.TabIndex = 20;
            label4.Text = "до";
            // 
            // textBoxLongitudeMin
            // 
            textBoxLongitudeMin.Location = new Point(280, 186);
            textBoxLongitudeMin.Name = "textBoxLongitudeMin";
            textBoxLongitudeMin.Size = new Size(139, 27);
            textBoxLongitudeMin.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 189);
            label5.Name = "label5";
            label5.Size = new Size(227, 20);
            label5.TabIndex = 18;
            label5.Text = "Відфільтрувати за довготою від";
            // 
            // FormFilter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 453);
            Controls.Add(textBoxLongitudeMax);
            Controls.Add(label4);
            Controls.Add(textBoxLongitudeMin);
            Controls.Add(label5);
            Controls.Add(textBoxLatitudeMax);
            Controls.Add(label3);
            Controls.Add(textBoxLatitudeMin);
            Controls.Add(label2);
            Controls.Add(textBoxNameFilter);
            Controls.Add(label1);
            Controls.Add(buttonFilter);
            Controls.Add(ButtonBack);
            MinimumSize = new Size(1350, 500);
            Name = "FormFilter";
            Text = "Form6";
            FormClosing += FormFilter_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonBack;
        private Button buttonFilter;
        private Label label1;
        private TextBox textBoxNameFilter;
        private Label label2;
        private TextBox textBoxLatitudeMin;
        private Label label3;
        private TextBox textBoxLatitudeMax;
        private TextBox textBoxLongitudeMax;
        private Label label4;
        private TextBox textBoxLongitudeMin;
        private Label label5;
    }
}