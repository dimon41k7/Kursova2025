namespace Kursova
{
    partial class FormCountryEdit
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
            textBoxPopulation = new TextBox();
            textBoxArea = new TextBox();
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
            textBoxContinent = new TextBox();
            label8 = new Label();
            label7 = new Label();
            listBoxGovernmentType = new ListBox();
            SuspendLayout();
            // 
            // ButtonBack
            // 
            ButtonBack.Location = new Point(12, 12);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(94, 29);
            ButtonBack.TabIndex = 57;
            ButtonBack.Text = "Назад";
            ButtonBack.UseVisualStyleBackColor = true;
            ButtonBack.Click += ButtonBack_Click;
            // 
            // textBoxPopulation
            // 
            textBoxPopulation.Location = new Point(483, 177);
            textBoxPopulation.Name = "textBoxPopulation";
            textBoxPopulation.Size = new Size(110, 27);
            textBoxPopulation.TabIndex = 54;
            // 
            // textBoxArea
            // 
            textBoxArea.Location = new Point(483, 76);
            textBoxArea.Name = "textBoxArea";
            textBoxArea.Size = new Size(110, 27);
            textBoxArea.TabIndex = 53;
            // 
            // textBoxCapital
            // 
            textBoxCapital.Location = new Point(483, 124);
            textBoxCapital.Name = "textBoxCapital";
            textBoxCapital.Size = new Size(110, 27);
            textBoxCapital.TabIndex = 52;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(362, 184);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 51;
            label4.Text = "Населення";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(362, 79);
            label5.Name = "label5";
            label5.Size = new Size(95, 20);
            label5.TabIndex = 50;
            label5.Text = "Площа (км²)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(363, 127);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 49;
            label6.Text = "Столиця";
            // 
            // Редагувати
            // 
            Редагувати.Location = new Point(1016, 127);
            Редагувати.Name = "Редагувати";
            Редагувати.Size = new Size(94, 29);
            Редагувати.TabIndex = 48;
            Редагувати.Text = "Редагувати";
            Редагувати.UseVisualStyleBackColor = true;
            Редагувати.Click += Редагувати_Click;
            // 
            // textBoxLongitude
            // 
            textBoxLongitude.Location = new Point(227, 181);
            textBoxLongitude.Name = "textBoxLongitude";
            textBoxLongitude.Size = new Size(110, 27);
            textBoxLongitude.TabIndex = 47;
            // 
            // textBoxLatitude
            // 
            textBoxLatitude.Location = new Point(227, 130);
            textBoxLatitude.Name = "textBoxLatitude";
            textBoxLatitude.Size = new Size(110, 27);
            textBoxLatitude.TabIndex = 46;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(227, 80);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(110, 27);
            textBoxName.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 188);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 44;
            label3.Text = "Довгота";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 133);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 43;
            label2.Text = "Широта";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 83);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 42;
            label1.Text = "Назва країни";
            // 
            // textBoxContinent
            // 
            textBoxContinent.Location = new Point(780, 177);
            textBoxContinent.Name = "textBoxContinent";
            textBoxContinent.Size = new Size(110, 27);
            textBoxContinent.TabIndex = 61;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(613, 184);
            label8.Name = "label8";
            label8.Size = new Size(152, 20);
            label8.TabIndex = 60;
            label8.Text = "Належить континету";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(613, 98);
            label7.Name = "label7";
            label7.Size = new Size(150, 40);
            label7.TabIndex = 59;
            label7.Text = "Форма державного \r\nправління";
            // 
            // listBoxGovernmentType
            // 
            listBoxGovernmentType.FormattingEnabled = true;
            listBoxGovernmentType.Location = new Point(780, 59);
            listBoxGovernmentType.Name = "listBoxGovernmentType";
            listBoxGovernmentType.Size = new Size(216, 104);
            listBoxGovernmentType.TabIndex = 58;
            // 
            // FormCountryEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 453);
            Controls.Add(textBoxContinent);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(listBoxGovernmentType);
            Controls.Add(ButtonBack);
            Controls.Add(textBoxPopulation);
            Controls.Add(textBoxArea);
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
            Name = "FormCountryEdit";
            Text = "FormCountryEdit";
            Load += FormCountryEdit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonBack;
        private TextBox textBoxPopulation;
        private TextBox textBoxArea;
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
        private TextBox textBoxContinent;
        private Label label8;
        private Label label7;
        private ListBox listBoxGovernmentType;
    }
}