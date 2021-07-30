namespace To_Do_List_CIT265_A5
{
    partial class homepage
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
            this.eventBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.sortbydate = new System.Windows.Forms.Button();
            this.Sort = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eventBox
            // 
            this.eventBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventBox.FormattingEnabled = true;
            this.eventBox.Location = new System.Drawing.Point(350, 53);
            this.eventBox.Name = "eventBox";
            this.eventBox.Size = new System.Drawing.Size(384, 264);
            this.eventBox.TabIndex = 7;
            this.eventBox.TabStop = false;
            this.eventBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "&Create an Event";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(58, 271);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(79, 23);
            this.quit.TabIndex = 5;
            this.quit.Text = "&Quit";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(58, 111);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(122, 23);
            this.delete.TabIndex = 1;
            this.delete.Text = "&Remove Event";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.button2_Click);
            // 
            // sortbydate
            // 
            this.sortbydate.Location = new System.Drawing.Point(58, 162);
            this.sortbydate.Name = "sortbydate";
            this.sortbydate.Size = new System.Drawing.Size(122, 23);
            this.sortbydate.TabIndex = 2;
            this.sortbydate.Text = "Sort By &Date";
            this.sortbydate.UseVisualStyleBackColor = true;
            this.sortbydate.Click += new System.EventHandler(this.sortbydate_Click);
            // 
            // Sort
            // 
            this.Sort.Location = new System.Drawing.Point(58, 219);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(122, 23);
            this.Sort.TabIndex = 3;
            this.Sort.Text = "Sort By &Name";
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(350, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "Save as .txt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.sortbydate);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.eventBox);
            this.Name = "homepage";
            this.Text = "To-Do-List";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox eventBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button sortbydate;
        private System.Windows.Forms.Button Sort;
        private System.Windows.Forms.Button button2;
    }
}

