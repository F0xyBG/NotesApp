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
            this.label4 = new System.Windows.Forms.Label();
            this.deleteNoteButton = new System.Windows.Forms.Button();
            this.idForDelete = new System.Windows.Forms.TextBox();
            this.updateBoxID = new System.Windows.Forms.TextBox();
            this.updateBoxText = new System.Windows.Forms.RichTextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchStringBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.updateNoteButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.note = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // addNoteButton
            // 
            this.addNoteButton.Location = new System.Drawing.Point(201, 110);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(460, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Изтрий по ID:";
            // 
            // deleteNoteButton
            // 
            this.deleteNoteButton.Location = new System.Drawing.Point(653, 383);
            this.deleteNoteButton.Name = "deleteNoteButton";
            this.deleteNoteButton.Size = new System.Drawing.Size(110, 23);
            this.deleteNoteButton.TabIndex = 8;
            this.deleteNoteButton.Text = "Изтрий бележка";
            this.deleteNoteButton.UseVisualStyleBackColor = true;
            this.deleteNoteButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // idForDelete
            // 
            this.idForDelete.Location = new System.Drawing.Point(547, 384);
            this.idForDelete.Name = "idForDelete";
            this.idForDelete.Size = new System.Drawing.Size(100, 23);
            this.idForDelete.TabIndex = 9;
            // 
            // updateBoxID
            // 
            this.updateBoxID.Location = new System.Drawing.Point(41, 231);
            this.updateBoxID.Name = "updateBoxID";
            this.updateBoxID.Size = new System.Drawing.Size(121, 23);
            this.updateBoxID.TabIndex = 10;
            // 
            // updateBoxText
            // 
            this.updateBoxText.Location = new System.Drawing.Point(26, 281);
            this.updateBoxText.Name = "updateBoxText";
            this.updateBoxText.Size = new System.Drawing.Size(296, 100);
            this.updateBoxText.TabIndex = 11;
            this.updateBoxText.Text = "";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(247, 164);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 12;
            this.searchButton.Text = "Търси";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // searchStringBox
            // 
            this.searchStringBox.Location = new System.Drawing.Point(86, 164);
            this.searchStringBox.Name = "searchStringBox";
            this.searchStringBox.Size = new System.Drawing.Size(155, 23);
            this.searchStringBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Текст:";
            // 
            // updateNoteButton
            // 
            this.updateNoteButton.Location = new System.Drawing.Point(208, 387);
            this.updateNoteButton.Name = "updateNoteButton";
            this.updateNoteButton.Size = new System.Drawing.Size(114, 23);
            this.updateNoteButton.TabIndex = 16;
            this.updateNoteButton.Text = "Обнови бележка";
            this.updateNoteButton.UseVisualStyleBackColor = true;
            this.updateNoteButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(4, 203);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(318, 12);
            this.progressBar1.TabIndex = 17;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(4, 139);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(318, 12);
            this.progressBar2.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Съдържа:";
            // 
            // note
            // 
            this.note.ImeMode = System.Windows.Forms.ImeMode.On;
            this.note.Location = new System.Drawing.Point(72, 12);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(250, 92);
            this.note.TabIndex = 20;
            this.note.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.note);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.updateNoteButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchStringBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.updateBoxText);
            this.Controls.Add(this.updateBoxID);
            this.Controls.Add(this.idForDelete);
            this.Controls.Add(this.deleteNoteButton);
            this.Controls.Add(this.label4);
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
        private Label label4;
        private Button deleteNoteButton;
        private TextBox idForDelete;
        private TextBox updateBoxID;
        private RichTextBox updateBoxText;
        private Button searchButton;
        private TextBox searchStringBox;
        private Label label3;
        private Label label5;
        private Button updateNoteButton;
        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
        private Label label2;
        private RichTextBox note;
    }
}