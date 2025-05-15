namespace Kursova
{
    partial class AddCountryForm
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
            label7 = new Label();
            listBoxGovernmentType = new ListBox();
            textBoxPopulation = new TextBox();
            textBoxArea = new TextBox();
            textBoxCapital = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Додати = new Button();
            textBoxLongitude = new TextBox();
            textBoxLatitude = new TextBox();
            textBoxName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ButtonBack = new Button();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(627, 133);
            label7.Name = "label7";
            label7.Size = new Size(150, 40);
            label7.TabIndex = 40;
            label7.Text = "Форма державного \r\nправління";
            // 
            // listBoxGovernmentType
            // 
            listBoxGovernmentType.FormattingEnabled = true;
            listBoxGovernmentType.Location = new Point(783, 79);
            listBoxGovernmentType.Name = "listBoxGovernmentType";
            listBoxGovernmentType.Size = new Size(216, 124);
            listBoxGovernmentType.TabIndex = 39;
            // 
            // textBoxPopulation
            // 
            textBoxPopulation.Location = new Point(483, 177);
            textBoxPopulation.Name = "textBoxPopulation";
            textBoxPopulation.Size = new Size(110, 27);
            textBoxPopulation.TabIndex = 38;
            // 
            // textBoxArea
            // 
            textBoxArea.Location = new Point(483, 76);
            textBoxArea.Name = "textBoxArea";
            textBoxArea.Size = new Size(110, 27);
            textBoxArea.TabIndex = 37;
            // 
            // textBoxCapital
            // 
            textBoxCapital.Location = new Point(483, 124);
            textBoxCapital.Name = "textBoxCapital";
            textBoxCapital.Size = new Size(110, 27);
            textBoxCapital.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(362, 184);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 35;
            label4.Text = "Населення";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(362, 79);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 34;
            label5.Text = "Площа";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(363, 127);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 33;
            label6.Text = "Столиця";
            // 
            // Додати
            // 
            Додати.Location = new Point(1016, 127);
            Додати.Name = "Додати";
            Додати.Size = new Size(94, 29);
            Додати.TabIndex = 32;
            Додати.Text = "Додати";
            Додати.UseVisualStyleBackColor = true;
            Додати.Click += Додати_Click;
            // 
            // textBoxLongitude
            // 
            textBoxLongitude.Location = new Point(227, 181);
            textBoxLongitude.Name = "textBoxLongitude";
            textBoxLongitude.Size = new Size(110, 27);
            textBoxLongitude.TabIndex = 31;
            // 
            // textBoxLatitude
            // 
            textBoxLatitude.Location = new Point(227, 130);
            textBoxLatitude.Name = "textBoxLatitude";
            textBoxLatitude.Size = new Size(110, 27);
            textBoxLatitude.TabIndex = 30;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(227, 80);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(110, 27);
            textBoxName.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 188);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 28;
            label3.Text = "Довгота";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 133);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 27;
            label2.Text = "Широта";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 83);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 26;
            label1.Text = "Назва країни";
            // 
            // ButtonBack
            // 
            ButtonBack.Location = new Point(12, 12);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(94, 29);
            ButtonBack.TabIndex = 41;
            ButtonBack.Text = "Назад";
            ButtonBack.UseVisualStyleBackColor = true;
            ButtonBack.Click += ButtonBack_Click;
            // 
            // AddCountryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 450);
            Controls.Add(ButtonBack);
            Controls.Add(label7);
            Controls.Add(listBoxGovernmentType);
            Controls.Add(textBoxPopulation);
            Controls.Add(textBoxArea);
            Controls.Add(textBoxCapital);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(Додати);
            Controls.Add(textBoxLongitude);
            Controls.Add(textBoxLatitude);
            Controls.Add(textBoxName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddCountryForm";
            Text = "AddCountryForm";
            Load += AddCountryForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private ListBox listBoxGovernmentType;
        private TextBox textBoxPopulation;
        private TextBox textBoxArea;
        private TextBox textBoxCapital;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button Додати;
        private TextBox textBoxLongitude;
        private TextBox textBoxLatitude;
        private TextBox textBoxName;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button ButtonBack;
    }
}