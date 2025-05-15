namespace Kursova
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxGeoObjects = new ListBox();
            Додати = new Button();
            listBoxGeoObjectsAll = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // listBoxGeoObjects
            // 
            listBoxGeoObjects.FormattingEnabled = true;
            listBoxGeoObjects.Location = new Point(62, 54);
            listBoxGeoObjects.Name = "listBoxGeoObjects";
            listBoxGeoObjects.Size = new Size(150, 84);
            listBoxGeoObjects.TabIndex = 0;
            // 
            // Додати
            // 
            Додати.Location = new Point(218, 82);
            Додати.Name = "Додати";
            Додати.Size = new Size(134, 29);
            Додати.TabIndex = 1;
            Додати.Text = "Додати";
            Додати.UseVisualStyleBackColor = true;
            Додати.Click += Додати_Click;
            // 
            // listBoxGeoObjectsAll
            // 
            listBoxGeoObjectsAll.FormattingEnabled = true;
            listBoxGeoObjectsAll.Location = new Point(62, 174);
            listBoxGeoObjectsAll.Name = "listBoxGeoObjectsAll";
            listBoxGeoObjectsAll.Size = new Size(533, 184);
            listBoxGeoObjectsAll.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(282, 138);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 3;
            label1.Text = "Загальний список";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 450);
            Controls.Add(label1);
            Controls.Add(listBoxGeoObjectsAll);
            Controls.Add(Додати);
            Controls.Add(listBoxGeoObjects);
            Name = "MainForm";
            Text = "MainForm";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxGeoObjects;
        private Button Додати;
        private ListBox listBoxGeoObjectsAll;
        private Label label1;
    }
}
