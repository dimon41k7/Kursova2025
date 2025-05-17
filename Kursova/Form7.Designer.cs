namespace Kursova
{
    partial class FormCityEdit
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
            Редагувати = new Button();
            textBoxPopulation = new TextBox();
            textBoxLongitude = new TextBox();
            textBoxLatitude = new TextBox();
            textBoxName = new TextBox();
            label4 = new Label();
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
            ButtonBack.TabIndex = 19;
            ButtonBack.Text = "Назад";
            ButtonBack.UseVisualStyleBackColor = true;
            ButtonBack.Click += ButtonBack_Click;
            // 
            // Редагувати
            // 
            Редагувати.Location = new Point(385, 163);
            Редагувати.Name = "Редагувати";
            Редагувати.Size = new Size(94, 29);
            Редагувати.TabIndex = 18;
            Редагувати.Text = "Редагувати";
            Редагувати.UseVisualStyleBackColor = true;
            Редагувати.Click += Редагувати_Click;
            // 
            // textBoxPopulation
            // 
            textBoxPopulation.Location = new Point(226, 236);
            textBoxPopulation.Name = "textBoxPopulation";
            textBoxPopulation.Size = new Size(110, 27);
            textBoxPopulation.TabIndex = 17;
            // 
            // textBoxLongitude
            // 
            textBoxLongitude.Location = new Point(226, 186);
            textBoxLongitude.Name = "textBoxLongitude";
            textBoxLongitude.Size = new Size(110, 27);
            textBoxLongitude.TabIndex = 16;
            // 
            // textBoxLatitude
            // 
            textBoxLatitude.Location = new Point(226, 135);
            textBoxLatitude.Name = "textBoxLatitude";
            textBoxLatitude.Size = new Size(110, 27);
            textBoxLatitude.TabIndex = 15;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(226, 85);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(110, 27);
            textBoxName.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(106, 239);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 13;
            label4.Text = "Населення";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 193);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 12;
            label3.Text = "Довгота";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 138);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 11;
            label2.Text = "Широта";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 88);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 10;
            label1.Text = "Назва міста";
            // 
            // FormCityEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 453);
            Controls.Add(ButtonBack);
            Controls.Add(Редагувати);
            Controls.Add(textBoxPopulation);
            Controls.Add(textBoxLongitude);
            Controls.Add(textBoxLatitude);
            Controls.Add(textBoxName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MinimumSize = new Size(1350, 500);
            Name = "FormCityEdit";
            Text = "FormCityEdit";
            Load += FormCityEdit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonBack;
        private Button Редагувати;
        private TextBox textBoxPopulation;
        private TextBox textBoxLongitude;
        private TextBox textBoxLatitude;
        private TextBox textBoxName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}