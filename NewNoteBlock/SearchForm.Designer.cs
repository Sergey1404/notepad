namespace NewNoteBlock {
    partial class SearchForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            this.butFind = new System.Windows.Forms.Button();
            this.butReplace = new System.Windows.Forms.Button();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.tbReplace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butReplaceAll = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.cbReg = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // butFind
            // 
            this.butFind.Location = new System.Drawing.Point(12, 92);
            this.butFind.Name = "butFind";
            this.butFind.Size = new System.Drawing.Size(89, 23);
            this.butFind.TabIndex = 0;
            this.butFind.Text = "Найти";
            this.butFind.UseVisualStyleBackColor = true;
            this.butFind.Click += new System.EventHandler(this.butFind_Click);
            // 
            // butReplace
            // 
            this.butReplace.Location = new System.Drawing.Point(107, 92);
            this.butReplace.Name = "butReplace";
            this.butReplace.Size = new System.Drawing.Size(89, 23);
            this.butReplace.TabIndex = 1;
            this.butReplace.Text = "Заменить";
            this.butReplace.UseVisualStyleBackColor = true;
            this.butReplace.Click += new System.EventHandler(this.butReplace_Click);
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(93, 14);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(292, 20);
            this.tbFind.TabIndex = 2;
            this.tbFind.TextChanged += new System.EventHandler(this.tbFind_TextChanged);
            // 
            // tbReplace
            // 
            this.tbReplace.Location = new System.Drawing.Point(93, 43);
            this.tbReplace.Name = "tbReplace";
            this.tbReplace.Size = new System.Drawing.Size(292, 20);
            this.tbReplace.TabIndex = 3;
            this.tbReplace.TextChanged += new System.EventHandler(this.tbReplace_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Найти:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Заменить на:";
            // 
            // butReplaceAll
            // 
            this.butReplaceAll.Location = new System.Drawing.Point(202, 92);
            this.butReplaceAll.Name = "butReplaceAll";
            this.butReplaceAll.Size = new System.Drawing.Size(89, 23);
            this.butReplaceAll.TabIndex = 6;
            this.butReplaceAll.Text = "Заменить всё";
            this.butReplaceAll.UseVisualStyleBackColor = true;
            this.butReplaceAll.Click += new System.EventHandler(this.butReplaceAll_Click);
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(297, 92);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(89, 23);
            this.butCancel.TabIndex = 7;
            this.butCancel.Text = "Отмена";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // cbReg
            // 
            this.cbReg.AutoSize = true;
            this.cbReg.Location = new System.Drawing.Point(93, 69);
            this.cbReg.Name = "cbReg";
            this.cbReg.Size = new System.Drawing.Size(124, 17);
            this.cbReg.TabIndex = 8;
            this.cbReg.Text = "Учитывать регистр";
            this.cbReg.UseVisualStyleBackColor = true;
            this.cbReg.CheckStateChanged += new System.EventHandler(this.cbReg_CheckStateChanged);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 123);
            this.Controls.Add(this.cbReg);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butReplaceAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbReplace);
            this.Controls.Add(this.tbFind);
            this.Controls.Add(this.butReplace);
            this.Controls.Add(this.butFind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Поиск и замена текста";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchForm_FormClosing);
            this.Shown += new System.EventHandler(this.SearchForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butFind;
        private System.Windows.Forms.Button butReplace;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.TextBox tbReplace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butReplaceAll;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.CheckBox cbReg;
    }
}