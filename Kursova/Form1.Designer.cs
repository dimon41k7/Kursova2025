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
            buttonFavorites = new Button();
            buttonSave = new Button();
            buttonLoad = new Button();
            listBoxFavorites = new ListBox();
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
            // buttonFavorites
            // 
            buttonFavorites.Location = new Point(613, 174);
            buttonFavorites.Name = "buttonFavorites";
            buttonFavorites.Size = new Size(151, 29);
            buttonFavorites.TabIndex = 4;
            buttonFavorites.Text = "Додати в обране";
            buttonFavorites.UseVisualStyleBackColor = true;
            buttonFavorites.Click += buttonFavorites_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(613, 248);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(151, 29);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "Зберегти";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(613, 329);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(151, 29);
            buttonLoad.TabIndex = 6;
            buttonLoad.Text = "Завантажити";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // listBoxFavorites
            // 
            listBoxFavorites.FormattingEnabled = true;
            listBoxFavorites.Location = new Point(785, 174);
            listBoxFavorites.Name = "listBoxFavorites";
            listBoxFavorites.Size = new Size(533, 184);
            listBoxFavorites.TabIndex = 7;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 450);
            Controls.Add(listBoxFavorites);
            Controls.Add(buttonLoad);
            Controls.Add(buttonSave);
            Controls.Add(buttonFavorites);
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
        private Button buttonFavorites;
        private Button buttonSave;
        private Button buttonLoad;
        private ListBox listBoxFavorites;
    }
}
