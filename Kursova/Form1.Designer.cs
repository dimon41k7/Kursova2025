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
            buttonShowObject = new Button();
            buttonDelete = new Button();
            comboBoxArea = new ComboBox();
            buttonFilter = new Button();
            buttonEdit = new Button();
            label2 = new Label();
            buttonGetFact = new Button();
            labelGetFact = new Label();
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
            listBoxGeoObjectsAll.MouseClick += listBoxGeoObjectsAll_MouseClick;
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
            buttonFavorites.Location = new Point(738, 81);
            buttonFavorites.Name = "buttonFavorites";
            buttonFavorites.Size = new Size(151, 29);
            buttonFavorites.TabIndex = 4;
            buttonFavorites.Text = "Додати в обране";
            buttonFavorites.UseVisualStyleBackColor = true;
            buttonFavorites.Click += buttonFavorites_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(1156, 12);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(151, 29);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "Зберегти";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(1156, 54);
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
            listBoxFavorites.MouseClick += listBoxFavorites_MouseClick;
            // 
            // buttonShowObject
            // 
            buttonShowObject.Location = new Point(614, 174);
            buttonShowObject.Name = "buttonShowObject";
            buttonShowObject.Size = new Size(151, 29);
            buttonShowObject.TabIndex = 8;
            buttonShowObject.Text = "Показати на мапі";
            buttonShowObject.UseVisualStyleBackColor = true;
            buttonShowObject.Click += buttonShowObject_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(562, 81);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(151, 29);
            buttonDelete.TabIndex = 9;
            buttonDelete.Text = "Видалити";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // comboBoxArea
            // 
            comboBoxArea.FormattingEnabled = true;
            comboBoxArea.Location = new Point(1156, 107);
            comboBoxArea.Name = "comboBoxArea";
            comboBoxArea.Size = new Size(151, 28);
            comboBoxArea.TabIndex = 10;
            comboBoxArea.SelectedIndexChanged += comboBoxArea_SelectedIndexChanged;
            // 
            // buttonFilter
            // 
            buttonFilter.Location = new Point(914, 81);
            buttonFilter.Name = "buttonFilter";
            buttonFilter.Size = new Size(151, 28);
            buttonFilter.TabIndex = 11;
            buttonFilter.Text = "Фільтри";
            buttonFilter.UseVisualStyleBackColor = true;
            buttonFilter.Click += buttonFilter_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(381, 83);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(151, 28);
            buttonEdit.TabIndex = 12;
            buttonEdit.Text = "Редагувати";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(988, 138);
            label2.Name = "label2";
            label2.Size = new Size(197, 20);
            label2.TabIndex = 13;
            label2.Text = "Список обраних елементів";
            // 
            // buttonGetFact
            // 
            buttonGetFact.Location = new Point(62, 391);
            buttonGetFact.Name = "buttonGetFact";
            buttonGetFact.Size = new Size(214, 29);
            buttonGetFact.TabIndex = 14;
            buttonGetFact.Text = "Отримати цікавий факт";
            buttonGetFact.UseVisualStyleBackColor = true;
            buttonGetFact.Click += buttonGetFact_Click;
            // 
            // labelGetFact
            // 
            labelGetFact.AutoSize = true;
            labelGetFact.Location = new Point(292, 395);
            labelGetFact.Name = "labelGetFact";
            labelGetFact.Size = new Size(0, 20);
            labelGetFact.TabIndex = 15;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 453);
            Controls.Add(labelGetFact);
            Controls.Add(buttonGetFact);
            Controls.Add(label2);
            Controls.Add(buttonEdit);
            Controls.Add(buttonFilter);
            Controls.Add(comboBoxArea);
            Controls.Add(buttonDelete);
            Controls.Add(buttonShowObject);
            Controls.Add(listBoxFavorites);
            Controls.Add(buttonLoad);
            Controls.Add(buttonSave);
            Controls.Add(buttonFavorites);
            Controls.Add(label1);
            Controls.Add(listBoxGeoObjectsAll);
            Controls.Add(Додати);
            Controls.Add(listBoxGeoObjects);
            MinimumSize = new Size(1350, 500);
            Name = "MainForm";
            Text = "MainForm";
            FormClosing += MainForm_FormClosing;
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
        private Button buttonShowObject;
        private Button buttonDelete;
        private ComboBox comboBoxArea;
        private Button buttonFilter;
        private Button buttonEdit;
        private Label label2;
        private Button buttonGetFact;
        private Label labelGetFact;
    }
}
