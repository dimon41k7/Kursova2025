namespace Kursova
{
    partial class AddCityForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxName = new TextBox();
            textBoxLatitude = new TextBox();
            textBoxLongitude = new TextBox();
            textBoxPopulation = new TextBox();
            Додати = new Button();
            ButtonBack = new Button();
            textBoxRegion = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 88);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "Назва міста";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 138);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Широта";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 193);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 2;
            label3.Text = "Довгота";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(106, 239);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 3;
            label4.Text = "Населення";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(226, 85);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(110, 27);
            textBoxName.TabIndex = 4;
            // 
            // textBoxLatitude
            // 
            textBoxLatitude.Location = new Point(226, 135);
            textBoxLatitude.Name = "textBoxLatitude";
            textBoxLatitude.Size = new Size(110, 27);
            textBoxLatitude.TabIndex = 5;
            // 
            // textBoxLongitude
            // 
            textBoxLongitude.Location = new Point(226, 186);
            textBoxLongitude.Name = "textBoxLongitude";
            textBoxLongitude.Size = new Size(110, 27);
            textBoxLongitude.TabIndex = 6;
            // 
            // textBoxPopulation
            // 
            textBoxPopulation.Location = new Point(226, 236);
            textBoxPopulation.Name = "textBoxPopulation";
            textBoxPopulation.Size = new Size(110, 27);
            textBoxPopulation.TabIndex = 7;
            // 
            // Додати
            // 
            Додати.Location = new Point(380, 186);
            Додати.Name = "Додати";
            Додати.Size = new Size(94, 29);
            Додати.TabIndex = 8;
            Додати.Text = "Додати";
            Додати.UseVisualStyleBackColor = true;
            Додати.Click += Додати_Click;
            // 
            // ButtonBack
            // 
            ButtonBack.Location = new Point(12, 12);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(94, 29);
            ButtonBack.TabIndex = 9;
            ButtonBack.Text = "Назад";
            ButtonBack.UseVisualStyleBackColor = true;
            ButtonBack.Click += ButtonBack_Click;
            // 
            // textBoxRegion
            // 
            textBoxRegion.Location = new Point(226, 289);
            textBoxRegion.Name = "textBoxRegion";
            textBoxRegion.Size = new Size(110, 27);
            textBoxRegion.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(86, 292);
            label5.Name = "label5";
            label5.Size = new Size(134, 20);
            label5.TabIndex = 10;
            label5.Text = "Належить регіону";
            // 
            // AddCityForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 453);
            Controls.Add(textBoxRegion);
            Controls.Add(label5);
            Controls.Add(ButtonBack);
            Controls.Add(Додати);
            Controls.Add(textBoxPopulation);
            Controls.Add(textBoxLongitude);
            Controls.Add(textBoxLatitude);
            Controls.Add(textBoxName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MinimumSize = new Size(1350, 500);
            Name = "AddCityForm";
            Text = "AddCityForm";
            Load += AddCityForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxName;
        private TextBox textBoxLatitude;
        private TextBox textBoxLongitude;
        private TextBox textBoxPopulation;
        private Button Додати;
        private Button ButtonBack;
        private TextBox textBoxRegion;
        private Label label5;
    }
}