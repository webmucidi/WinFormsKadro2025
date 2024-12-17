namespace WinFormsAppSadeceDongu
{
    partial class Form1
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
            listBoxNetflix = new ListBox();
            buttonFilmOner = new Button();
            SuspendLayout();
            // 
            // listBoxNetflix
            // 
            listBoxNetflix.FormattingEnabled = true;
            listBoxNetflix.Location = new Point(346, 150);
            listBoxNetflix.Name = "listBoxNetflix";
            listBoxNetflix.Size = new Size(150, 104);
            listBoxNetflix.TabIndex = 0;
            // 
            // buttonFilmOner
            // 
            buttonFilmOner.Location = new Point(356, 284);
            buttonFilmOner.Name = "buttonFilmOner";
            buttonFilmOner.Size = new Size(125, 29);
            buttonFilmOner.TabIndex = 1;
            buttonFilmOner.Text = "Film/Dizi Öner";
            buttonFilmOner.UseVisualStyleBackColor = true;
            buttonFilmOner.Click += buttonFilmOner_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonFilmOner);
            Controls.Add(listBoxNetflix);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxNetflix;
        private Button buttonFilmOner;
    }
}
