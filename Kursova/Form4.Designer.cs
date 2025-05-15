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
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(589, 153);
            label7.Name = "label7";
            label7.Size = new Size(150, 40);
            label7.TabIndex = 40;
            label7.Text = "Форма державного \r\nправління";
            // 
            // listBoxGovernmentType
            // 
            listBoxGovernmentType.FormattingEnabled = true;
            listBoxGovernmentType.Location = new Point(745, 99);
            listBoxGovernmentType.Name = "listBoxGovernmentType";
            listBoxGovernmentType.Size = new Size(216, 124);
            listBoxGovernmentType.TabIndex = 39;
            // 
            // textBoxPopulation
            // 
            textBoxPopulation.Location = new Point(445, 197);
            textBoxPopulation.Name = "textBoxPopulation";
            textBoxPopulation.Size = new Size(110, 27);
            textBoxPopulation.TabIndex = 38;
            // 
            // textBoxArea
            // 
            textBoxArea.Location = new Point(445, 96);
            textBoxArea.Name = "textBoxArea";
            textBoxArea.Size = new Size(110, 27);
            textBoxArea.TabIndex = 37;
            // 
            // textBoxCapital
            // 
            textBoxCapital.Location = new Point(445, 144);
            textBoxCapital.Name = "textBoxCapital";
            textBoxCapital.Size = new Size(110, 27);
            textBoxCapital.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(324, 204);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 35;
            label4.Text = "Населення";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(324, 99);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 34;
            label5.Text = "Площа";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(325, 147);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 33;
            label6.Text = "Столиця";
            // 
            // Додати
            // 
            Додати.Location = new Point(978, 147);
            Додати.Name = "Додати";
            Додати.Size = new Size(94, 29);
            Додати.TabIndex = 32;
            Додати.Text = "Додати";
            Додати.UseVisualStyleBackColor = true;
            // 
            // textBoxLongitude
            // 
            textBoxLongitude.Location = new Point(189, 201);
            textBoxLongitude.Name = "textBoxLongitude";
            textBoxLongitude.Size = new Size(110, 27);
            textBoxLongitude.TabIndex = 31;
            // 
            // textBoxLatitude
            // 
            textBoxLatitude.Location = new Point(189, 150);
            textBoxLatitude.Name = "textBoxLatitude";
            textBoxLatitude.Size = new Size(110, 27);
            textBoxLatitude.TabIndex = 30;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(189, 100);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(110, 27);
            textBoxName.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 208);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 28;
            label3.Text = "Довгота";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 153);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 27;
            label2.Text = "Широта";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 103);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 26;
            label1.Text = "Назва регіону";
            // 
            // AddCountryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 450);
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
    }
}