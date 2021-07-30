namespace Assignment_6
{
    partial class Form1
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.FilesListBox = new System.Windows.Forms.ListBox();
            this.subdir = new System.Windows.Forms.CheckBox();
            this.folderstxt = new System.Windows.Forms.Label();
            this.filestxt = new System.Windows.Forms.Label();
            this.textbox = new System.Windows.Forms.Label();
            this.ttt = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open File Explorer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FilesListBox
            // 
            this.FilesListBox.FormattingEnabled = true;
            this.FilesListBox.Location = new System.Drawing.Point(259, 51);
            this.FilesListBox.Name = "FilesListBox";
            this.FilesListBox.Size = new System.Drawing.Size(529, 368);
            this.FilesListBox.TabIndex = 1;
            // 
            // subdir
            // 
            this.subdir.AutoSize = true;
            this.subdir.Location = new System.Drawing.Point(259, 12);
            this.subdir.Name = "subdir";
            this.subdir.Size = new System.Drawing.Size(129, 17);
            this.subdir.TabIndex = 2;
            this.subdir.Text = "Count Sub Directories";
            this.subdir.UseVisualStyleBackColor = true;
            // 
            // folderstxt
            // 
            this.folderstxt.AutoSize = true;
            this.folderstxt.Location = new System.Drawing.Point(167, 126);
            this.folderstxt.Name = "folderstxt";
            this.folderstxt.Size = new System.Drawing.Size(0, 13);
            this.folderstxt.TabIndex = 5;
            // 
            // filestxt
            // 
            this.filestxt.AutoSize = true;
            this.filestxt.Location = new System.Drawing.Point(167, 166);
            this.filestxt.Name = "filestxt";
            this.filestxt.Size = new System.Drawing.Size(0, 13);
            this.filestxt.TabIndex = 6;
            // 
            // textbox
            // 
            this.textbox.AutoSize = true;
            this.textbox.Location = new System.Drawing.Point(35, 126);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(93, 13);
            this.textbox.TabIndex = 3;
            this.textbox.Text = "Number of Folders";
            // 
            // ttt
            // 
            this.ttt.AutoSize = true;
            this.ttt.Location = new System.Drawing.Point(35, 166);
            this.ttt.Name = "ttt";
            this.ttt.Size = new System.Drawing.Size(80, 13);
            this.ttt.TabIndex = 4;
            this.ttt.Text = "Number of Files";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.filestxt);
            this.Controls.Add(this.folderstxt);
            this.Controls.Add(this.ttt);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.subdir);
            this.Controls.Add(this.FilesListBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox FilesListBox;
        private System.Windows.Forms.CheckBox subdir;
        private System.Windows.Forms.Label folderstxt;
        private System.Windows.Forms.Label filestxt;
        private System.Windows.Forms.Label textbox;
        private System.Windows.Forms.Label ttt;
        private System.Windows.Forms.Button button2;
    }
}

