namespace WindowsFormDBConnect
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
            this.addNoteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.notesInfo = new System.Windows.Forms.RichTextBox();
            this.note = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // addNoteButton
            // 
            this.addNoteButton.Location = new System.Drawing.Point(201, 382);
            this.addNoteButton.Name = "addNoteButton";
            this.addNoteButton.Size = new System.Drawing.Size(121, 23);
            this.addNoteButton.TabIndex = 0;
            this.addNoteButton.Text = "Добави бележка";
            this.addNoteButton.UseVisualStyleBackColor = true;
            this.addNoteButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Бележка";
            // 
            // notesInfo
            // 
            this.notesInfo.ImeMode = System.Windows.Forms.ImeMode.On;
            this.notesInfo.Location = new System.Drawing.Point(328, 12);
            this.notesInfo.Name = "notesInfo";
            this.notesInfo.Size = new System.Drawing.Size(423, 353);
            this.notesInfo.TabIndex = 5;
            this.notesInfo.Text = "";
            // 
            // note
            // 
            this.note.ImeMode = System.Windows.Forms.ImeMode.On;
            this.note.Location = new System.Drawing.Point(72, 12);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(250, 353);
            this.note.TabIndex = 20;
            this.note.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.note);
            this.Controls.Add(this.notesInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addNoteButton);
            this.Name = "Form1";
            this.Text = "Бележки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button addNoteButton;
        private Label label1;
        private RichTextBox notesInfo;
        private RichTextBox note;
    }
}