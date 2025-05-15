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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Додати);
            Controls.Add(listBoxGeoObjects);
            Name = "MainForm";
            Text = "MainForm";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxGeoObjects;
        private Button Додати;
    }
}
