namespace To_Do_List_CIT265_A5
{
    partial class EventWindow
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.eventdes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.eventName = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.eventDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Date of Event";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Description";
            // 
            // eventdes
            // 
            this.eventdes.Location = new System.Drawing.Point(114, 93);
            this.eventdes.Multiline = true;
            this.eventdes.Name = "eventdes";
            this.eventdes.Size = new System.Drawing.Size(200, 67);
            this.eventdes.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(10, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name of Event";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // eventName
            // 
            this.eventName.Location = new System.Drawing.Point(114, 46);
            this.eventName.Name = "eventName";
            this.eventName.Size = new System.Drawing.Size(200, 20);
            this.eventName.TabIndex = 0;
            this.eventName.TextChanged += new System.EventHandler(this.eventName_TextChanged);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(239, 268);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 3;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // eventDate
            // 
            this.eventDate.Location = new System.Drawing.Point(114, 200);
            this.eventDate.Name = "eventDate";
            this.eventDate.Size = new System.Drawing.Size(200, 20);
            this.eventDate.TabIndex = 2;
            // 
            // EventWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 320);
            this.Controls.Add(this.eventDate);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eventdes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eventName);
            this.Name = "EventWindow";
            this.Text = "Add Event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        //IMporant
        private System.Windows.Forms.TextBox eventdes;
        private System.Windows.Forms.TextBox eventName;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.DateTimePicker eventDate;
    }
}