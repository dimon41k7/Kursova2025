namespace Kursova
{
    partial class FormRegionEdit
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
            label7 = new Label();
            listBoxType = new ListBox();
            textBoxPopulation = new TextBox();
            textBoxCountry = new TextBox();
            textBoxCapital = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Редагувати = new Button();
            textBoxLongitude = new TextBox();
            textBoxLatitude = new TextBox();
            textBoxName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // ButtonBack
            // 
            ButtonBack.Location = new Point(12, 12);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(94, 29);
            ButtonBack.TabIndex = 42;
            ButtonBack.Text = "Назад";
            ButtonBack.UseVisualStyleBackColor = true;
            ButtonBack.Click += ButtonBack_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(627, 141);
            label7.Name = "label7";
            label7.Size = new Size(35, 20);
            label7.TabIndex = 41;
            label7.Text = "Вид";
            // 
            // listBoxType
            // 
            listBoxType.FormattingEnabled = true;
            listBoxType.Location = new Point(687, 84);
            listBoxType.Name = "listBoxType";
            listBoxType.Size = new Size(216, 124);
            listBoxType.TabIndex = 40;
            // 
            // textBoxPopulation
            // 
            textBoxPopulation.Location = new Point(483, 185);
            textBoxPopulation.Name = "textBoxPopulation";
            textBoxPopulation.Size = new Size(110, 27);
            textBoxPopulation.TabIndex = 39;
            // 
            // textBoxCountry
            // 
            textBoxCountry.Location = new Point(483, 134);
            textBoxCountry.Name = "textBoxCountry";
            textBoxCountry.Size = new Size(110, 27);
            textBoxCountry.TabIndex = 38;
            // 
            // textBoxCapital
            // 
            textBoxCapital.Location = new Point(483, 84);
            textBoxCapital.Name = "textBoxCapital";
            textBoxCapital.Size = new Size(110, 27);
            textBoxCapital.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(362, 192);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 36;
            label4.Text = "Населення";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(362, 137);
            label5.Name = "label5";
            label5.Size = new Size(123, 20);
            label5.TabIndex = 35;
            label5.Text = "Належить країні";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(363, 87);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 34;
            label6.Text = "Столиця";
            // 
            // Редагувати
            // 
            Редагувати.Location = new Point(920, 132);
            Редагувати.Name = "Редагувати";
            Редагувати.Size = new Size(94, 29);
            Редагувати.TabIndex = 33;
            Редагувати.Text = "Редагувати";
            Редагувати.UseVisualStyleBackColor = true;
            Редагувати.Click += Редагувати_Click;
            // 
            // textBoxLongitude
            // 
            textBoxLongitude.Location = new Point(227, 189);
            textBoxLongitude.Name = "textBoxLongitude";
            textBoxLongitude.Size = new Size(110, 27);
            textBoxLongitude.TabIndex = 32;
            // 
            // textBoxLatitude
            // 
            textBoxLatitude.Location = new Point(227, 138);
            textBoxLatitude.Name = "textBoxLatitude";
            textBoxLatitude.Size = new Size(110, 27);
            textBoxLatitude.TabIndex = 31;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(227, 88);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(110, 27);
            textBoxName.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 196);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 29;
            label3.Text = "Довгота";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 141);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 28;
            label2.Text = "Широта";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 91);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 27;
            label1.Text = "Назва регіону";
            // 
            // FormRegionEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 453);
            Controls.Add(ButtonBack);
            Controls.Add(label7);
            Controls.Add(listBoxType);
            Controls.Add(textBoxPopulation);
            Controls.Add(textBoxCountry);
            Controls.Add(textBoxCapital);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(Редагувати);
            Controls.Add(textBoxLongitude);
            Controls.Add(textBoxLatitude);
            Controls.Add(textBoxName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MinimumSize = new Size(1350, 500);
            Name = "FormRegionEdit";
            Text = "FormRegionEdit";
            FormClosing += FormRegionEdit_FormClosing;
            Load += FormRegionEdit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonBack;
        private Label label7;
        private ListBox listBoxType;
        private TextBox textBoxPopulation;
        private TextBox textBoxCountry;
        private TextBox textBoxCapital;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button Редагувати;
        private TextBox textBoxLongitude;
        private TextBox textBoxLatitude;
        private TextBox textBoxName;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}