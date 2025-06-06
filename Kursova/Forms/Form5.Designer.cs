namespace Kursova
{
    partial class AddContinentForm
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
            textBoxPopulation = new TextBox();
            textBoxArea = new TextBox();
            label4 = new Label();
            label5 = new Label();
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
            // textBoxPopulation
            // 
            textBoxPopulation.Location = new Point(480, 128);
            textBoxPopulation.Name = "textBoxPopulation";
            textBoxPopulation.Size = new Size(110, 27);
            textBoxPopulation.TabIndex = 53;
            // 
            // textBoxArea
            // 
            textBoxArea.Location = new Point(480, 78);
            textBoxArea.Name = "textBoxArea";
            textBoxArea.Size = new Size(110, 27);
            textBoxArea.TabIndex = 52;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(359, 135);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 50;
            label4.Text = "Населення";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(359, 81);
            label5.Name = "label5";
            label5.Size = new Size(95, 20);
            label5.TabIndex = 49;
            label5.Text = "Площа (км²)";
            // 
            // Додати
            // 
            Додати.Location = new Point(620, 130);
            Додати.Name = "Додати";
            Додати.Size = new Size(94, 29);
            Додати.TabIndex = 47;
            Додати.Text = "Додати";
            Додати.UseVisualStyleBackColor = true;
            Додати.Click += Додати_Click;
            // 
            // textBoxLongitude
            // 
            textBoxLongitude.Location = new Point(224, 183);
            textBoxLongitude.Name = "textBoxLongitude";
            textBoxLongitude.Size = new Size(110, 27);
            textBoxLongitude.TabIndex = 46;
            // 
            // textBoxLatitude
            // 
            textBoxLatitude.Location = new Point(224, 132);
            textBoxLatitude.Name = "textBoxLatitude";
            textBoxLatitude.Size = new Size(110, 27);
            textBoxLatitude.TabIndex = 45;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(224, 82);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(110, 27);
            textBoxName.TabIndex = 44;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 190);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 43;
            label3.Text = "Довгота";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 135);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 42;
            label2.Text = "Широта";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 85);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 41;
            label1.Text = "Назва континенту";
            // 
            // ButtonBack
            // 
            ButtonBack.Location = new Point(12, 12);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(94, 29);
            ButtonBack.TabIndex = 54;
            ButtonBack.Text = "Назад";
            ButtonBack.UseVisualStyleBackColor = true;
            ButtonBack.Click += ButtonBack_Click;
            // 
            // AddContinentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 453);
            Controls.Add(ButtonBack);
            Controls.Add(textBoxPopulation);
            Controls.Add(textBoxArea);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(Додати);
            Controls.Add(textBoxLongitude);
            Controls.Add(textBoxLatitude);
            Controls.Add(textBoxName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MinimumSize = new Size(1350, 500);
            Name = "AddContinentForm";
            Text = "AddContinentForm";
            FormClosing += AddContinentForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPopulation;
        private TextBox textBoxArea;
        private Label label4;
        private Label label5;
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