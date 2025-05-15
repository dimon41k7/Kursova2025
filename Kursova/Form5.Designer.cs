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
            SuspendLayout();
            // 
            // textBoxPopulation
            // 
            textBoxPopulation.Location = new Point(441, 130);
            textBoxPopulation.Name = "textBoxPopulation";
            textBoxPopulation.Size = new Size(110, 27);
            textBoxPopulation.TabIndex = 53;
            // 
            // textBoxArea
            // 
            textBoxArea.Location = new Point(441, 80);
            textBoxArea.Name = "textBoxArea";
            textBoxArea.Size = new Size(110, 27);
            textBoxArea.TabIndex = 52;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(320, 137);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 50;
            label4.Text = "Населення";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(320, 83);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 49;
            label5.Text = "Площа";
            // 
            // Додати
            // 
            Додати.Location = new Point(441, 188);
            Додати.Name = "Додати";
            Додати.Size = new Size(94, 29);
            Додати.TabIndex = 47;
            Додати.Text = "Додати";
            Додати.UseVisualStyleBackColor = true;
            // 
            // textBoxLongitude
            // 
            textBoxLongitude.Location = new Point(185, 185);
            textBoxLongitude.Name = "textBoxLongitude";
            textBoxLongitude.Size = new Size(110, 27);
            textBoxLongitude.TabIndex = 46;
            // 
            // textBoxLatitude
            // 
            textBoxLatitude.Location = new Point(185, 134);
            textBoxLatitude.Name = "textBoxLatitude";
            textBoxLatitude.Size = new Size(110, 27);
            textBoxLatitude.TabIndex = 45;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(185, 84);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(110, 27);
            textBoxName.TabIndex = 44;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 192);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 43;
            label3.Text = "Довгота";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 137);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 42;
            label2.Text = "Широта";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 87);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 41;
            label1.Text = "Назва регіону";
            // 
            // AddContinentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 450);
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
            Name = "AddContinentForm";
            Text = "AddContinentForm";
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
    }
}