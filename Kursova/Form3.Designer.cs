namespace Kursova
{
    partial class AddRegionForm
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
            Додати = new Button();
            textBoxLongitude = new TextBox();
            textBoxLatitude = new TextBox();
            textBoxName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxPopulation = new TextBox();
            textBoxCountry = new TextBox();
            textBoxCapital = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            listBoxType = new ListBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // Додати
            // 
            Додати.Location = new Point(912, 127);
            Додати.Name = "Додати";
            Додати.Size = new Size(94, 29);
            Додати.TabIndex = 17;
            Додати.Text = "Додати";
            Додати.UseVisualStyleBackColor = true;
            Додати.Click += Додати_Click;
            // 
            // textBoxLongitude
            // 
            textBoxLongitude.Location = new Point(219, 184);
            textBoxLongitude.Name = "textBoxLongitude";
            textBoxLongitude.Size = new Size(110, 27);
            textBoxLongitude.TabIndex = 15;
            // 
            // textBoxLatitude
            // 
            textBoxLatitude.Location = new Point(219, 133);
            textBoxLatitude.Name = "textBoxLatitude";
            textBoxLatitude.Size = new Size(110, 27);
            textBoxLatitude.TabIndex = 14;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(219, 83);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(110, 27);
            textBoxName.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 191);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 11;
            label3.Text = "Довгота";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 136);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 10;
            label2.Text = "Широта";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 86);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 9;
            label1.Text = "Назва регіону";
            // 
            // textBoxPopulation
            // 
            textBoxPopulation.Location = new Point(475, 180);
            textBoxPopulation.Name = "textBoxPopulation";
            textBoxPopulation.Size = new Size(110, 27);
            textBoxPopulation.TabIndex = 23;
            // 
            // textBoxCountry
            // 
            textBoxCountry.Location = new Point(475, 129);
            textBoxCountry.Name = "textBoxCountry";
            textBoxCountry.Size = new Size(110, 27);
            textBoxCountry.TabIndex = 22;
            // 
            // textBoxCapital
            // 
            textBoxCapital.Location = new Point(475, 79);
            textBoxCapital.Name = "textBoxCapital";
            textBoxCapital.Size = new Size(110, 27);
            textBoxCapital.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(354, 187);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 20;
            label4.Text = "Населення";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(354, 132);
            label5.Name = "label5";
            label5.Size = new Size(123, 20);
            label5.TabIndex = 19;
            label5.Text = "Належить країні";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(355, 82);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 18;
            label6.Text = "Столиця";
            // 
            // listBoxType
            // 
            listBoxType.FormattingEnabled = true;
            listBoxType.Location = new Point(679, 79);
            listBoxType.Name = "listBoxType";
            listBoxType.Size = new Size(216, 124);
            listBoxType.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(619, 136);
            label7.Name = "label7";
            label7.Size = new Size(35, 20);
            label7.TabIndex = 25;
            label7.Text = "Вид";
            // 
            // AddRegionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 450);
            Controls.Add(label7);
            Controls.Add(listBoxType);
            Controls.Add(textBoxPopulation);
            Controls.Add(textBoxCountry);
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
            Name = "AddRegionForm";
            Text = "AddRegionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Додати;
        private TextBox textBoxLongitude;
        private TextBox textBoxLatitude;
        private TextBox textBoxName;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxPopulation;
        private TextBox textBoxCountry;
        private TextBox textBoxCapital;
        private Label label4;
        private Label label5;
        private Label label6;
        private ListBox listBoxType;
        private Label label7;
    }
}