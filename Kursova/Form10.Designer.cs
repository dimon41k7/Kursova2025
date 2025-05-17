namespace Kursova
{
    partial class FormContinentEdit
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
            label4 = new Label();
            label5 = new Label();
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
            ButtonBack.TabIndex = 66;
            ButtonBack.Text = "Назад";
            ButtonBack.UseVisualStyleBackColor = true;
            ButtonBack.Click += ButtonBack_Click;
            // 
            // textBoxPopulation
            // 
            textBoxPopulation.Location = new Point(480, 128);
            textBoxPopulation.Name = "textBoxPopulation";
            textBoxPopulation.Size = new Size(110, 27);
            textBoxPopulation.TabIndex = 65;
            // 
            // textBoxArea
            // 
            textBoxArea.Location = new Point(480, 78);
            textBoxArea.Name = "textBoxArea";
            textBoxArea.Size = new Size(110, 27);
            textBoxArea.TabIndex = 64;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(359, 135);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 63;
            label4.Text = "Населення";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(359, 81);
            label5.Name = "label5";
            label5.Size = new Size(95, 20);
            label5.TabIndex = 62;
            label5.Text = "Площа (км²)";
            // 
            // Редагувати
            // 
            Редагувати.Location = new Point(480, 186);
            Редагувати.Name = "Редагувати";
            Редагувати.Size = new Size(94, 29);
            Редагувати.TabIndex = 61;
            Редагувати.Text = "Редагувати";
            Редагувати.UseVisualStyleBackColor = true;
            Редагувати.Click += Редагувати_Click;
            // 
            // textBoxLongitude
            // 
            textBoxLongitude.Location = new Point(224, 183);
            textBoxLongitude.Name = "textBoxLongitude";
            textBoxLongitude.Size = new Size(110, 27);
            textBoxLongitude.TabIndex = 60;
            // 
            // textBoxLatitude
            // 
            textBoxLatitude.Location = new Point(224, 132);
            textBoxLatitude.Name = "textBoxLatitude";
            textBoxLatitude.Size = new Size(110, 27);
            textBoxLatitude.TabIndex = 59;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(224, 82);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(110, 27);
            textBoxName.TabIndex = 58;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 190);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 57;
            label3.Text = "Довгота";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 135);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 56;
            label2.Text = "Широта";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 85);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 55;
            label1.Text = "Назва континенту";
            // 
            // FormContinentEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 453);
            Controls.Add(ButtonBack);
            Controls.Add(textBoxPopulation);
            Controls.Add(textBoxArea);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(Редагувати);
            Controls.Add(textBoxLongitude);
            Controls.Add(textBoxLatitude);
            Controls.Add(textBoxName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MinimumSize = new Size(1350, 500);
            Name = "FormContinentEdit";
            Text = "FormContinentEdit";
            Load += FormContinentEdit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonBack;
        private TextBox textBoxPopulation;
        private TextBox textBoxArea;
        private Label label4;
        private Label label5;
        private Button Редагувати;
        private TextBox textBoxLongitude;
        private TextBox textBoxLatitude;
        private TextBox textBoxName;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}