namespace NewNoteBlock {
    partial class GoToForm {
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
            this.butGo = new System.Windows.Forms.Button();
            this.labGo = new System.Windows.Forms.Label();
            this.butCancel = new System.Windows.Forms.Button();
            this.tbLineNum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.tbLineNum)).BeginInit();
            this.SuspendLayout();
            // 
            // butGo
            // 
            this.butGo.Location = new System.Drawing.Point(12, 53);
            this.butGo.Name = "butGo";
            this.butGo.Size = new System.Drawing.Size(74, 23);
            this.butGo.TabIndex = 0;
            this.butGo.Text = "Перейти";
            this.butGo.UseVisualStyleBackColor = true;
            this.butGo.Click += new System.EventHandler(this.butGo_Click);
            // 
            // labGo
            // 
            this.labGo.AutoSize = true;
            this.labGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labGo.Location = new System.Drawing.Point(12, 9);
            this.labGo.Name = "labGo";
            this.labGo.Size = new System.Drawing.Size(143, 15);
            this.labGo.TabIndex = 1;
            this.labGo.Text = "Введите номер строки:";
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(92, 53);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 3;
            this.butCancel.Text = "Отмена";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // tbLineNum
            // 
            this.tbLineNum.Location = new System.Drawing.Point(12, 27);
            this.tbLineNum.Name = "tbLineNum";
            this.tbLineNum.Size = new System.Drawing.Size(155, 20);
            this.tbLineNum.TabIndex = 4;
            // 
            // GoToForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 86);
            this.Controls.Add(this.tbLineNum);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.labGo);
            this.Controls.Add(this.butGo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GoToForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Перейти";
            ((System.ComponentModel.ISupportInitialize)(this.tbLineNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butGo;
        private System.Windows.Forms.Label labGo;
        private System.Windows.Forms.Button butCancel;
        public System.Windows.Forms.NumericUpDown tbLineNum;
    }
}