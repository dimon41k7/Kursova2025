namespace Kursova
{
    partial class FormShowObj
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
            listBoxShowObject = new ListBox();
            labelShow = new Label();
            SuspendLayout();
            // 
            // ButtonBack
            // 
            ButtonBack.Location = new Point(12, 12);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(94, 29);
            ButtonBack.TabIndex = 42;
            ButtonBack.Text = "Назад";
            ButtonBack.UseVisualStyleBackColor = true;
            ButtonBack.Click += ButtonBack_Click;
            // 
            // listBoxShowObject
            // 
            listBoxShowObject.FormattingEnabled = true;
            listBoxShowObject.Location = new Point(103, 66);
            listBoxShowObject.MinimumSize = new Size(600, 350);
            listBoxShowObject.Name = "listBoxShowObject";
            listBoxShowObject.Size = new Size(600, 344);
            listBoxShowObject.TabIndex = 43;
            // 
            // labelShow
            // 
            labelShow.AutoSize = true;
            labelShow.Location = new Point(129, 21);
            labelShow.Name = "labelShow";
            labelShow.Size = new Size(0, 20);
            labelShow.TabIndex = 44;
            // 
            // FormShowObj
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(labelShow);
            Controls.Add(listBoxShowObject);
            Controls.Add(ButtonBack);
            MinimumSize = new Size(800, 500);
            Name = "FormShowObj";
            Text = "FormShowObj";
            Load += FormShowObj_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonBack;
        private ListBox listBoxShowObject;
        private Label labelShow;
    }
}