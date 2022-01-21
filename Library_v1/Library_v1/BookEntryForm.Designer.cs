namespace Library_v1
{
    partial class BookEntryForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.nmrLength = new System.Windows.Forms.NumericUpDown();
            this.lblGenre = new System.Windows.Forms.Label();
            this.comGenre = new System.Windows.Forms.ComboBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.chkStarted = new System.Windows.Forms.CheckBox();
            this.chkCompleted = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrLength)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(287, 20);
            this.txtName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(12, 94);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(38, 13);
            this.lblAuthor.TabIndex = 3;
            this.lblAuthor.Text = "Author";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(12, 110);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(287, 20);
            this.txtAuthor.TabIndex = 2;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(12, 133);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(40, 13);
            this.lblLength.TabIndex = 5;
            this.lblLength.Text = "Length";
            // 
            // nmrLength
            // 
            this.nmrLength.Location = new System.Drawing.Point(12, 149);
            this.nmrLength.Name = "nmrLength";
            this.nmrLength.Size = new System.Drawing.Size(120, 20);
            this.nmrLength.TabIndex = 6;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(12, 172);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(36, 13);
            this.lblGenre.TabIndex = 8;
            this.lblGenre.Text = "Genre";
            // 
            // comGenre
            // 
            this.comGenre.FormattingEnabled = true;
            this.comGenre.Location = new System.Drawing.Point(12, 188);
            this.comGenre.Name = "comGenre";
            this.comGenre.Size = new System.Drawing.Size(287, 21);
            this.comGenre.TabIndex = 9;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(12, 55);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(32, 13);
            this.lblISBN.TabIndex = 11;
            this.lblISBN.Text = "ISBN";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(12, 71);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(287, 20);
            this.txtISBN.TabIndex = 10;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 212);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(12, 229);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(287, 120);
            this.txtDescription.TabIndex = 13;
            // 
            // chkStarted
            // 
            this.chkStarted.AutoSize = true;
            this.chkStarted.Location = new System.Drawing.Point(12, 356);
            this.chkStarted.Name = "chkStarted";
            this.chkStarted.Size = new System.Drawing.Size(86, 17);
            this.chkStarted.TabIndex = 14;
            this.chkStarted.Text = "Book started";
            this.chkStarted.UseVisualStyleBackColor = true;
            // 
            // chkCompleted
            // 
            this.chkCompleted.AutoSize = true;
            this.chkCompleted.Location = new System.Drawing.Point(12, 380);
            this.chkCompleted.Name = "chkCompleted";
            this.chkCompleted.Size = new System.Drawing.Size(103, 17);
            this.chkCompleted.TabIndex = 15;
            this.chkCompleted.Text = "Book completed";
            this.chkCompleted.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(12, 415);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(287, 23);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // BookEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.chkCompleted);
            this.Controls.Add(this.chkStarted);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.comGenre);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.nmrLength);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Name = "BookEntryForm";
            this.Text = "Add/Edit Book";
            ((System.ComponentModel.ISupportInitialize)(this.nmrLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.NumericUpDown nmrLength;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.ComboBox comGenre;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.CheckBox chkStarted;
        private System.Windows.Forms.CheckBox chkCompleted;
        private System.Windows.Forms.Button btnSubmit;
    }
}