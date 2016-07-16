namespace WinFormsTraining
{
    partial class frmHobbies
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
            this.lstHobbies = new System.Windows.Forms.ListBox();
            this.txtHobby = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstHobbies
            // 
            this.lstHobbies.FormattingEnabled = true;
            this.lstHobbies.Location = new System.Drawing.Point(22, 12);
            this.lstHobbies.Name = "lstHobbies";
            this.lstHobbies.Size = new System.Drawing.Size(209, 134);
            this.lstHobbies.TabIndex = 0;
            // 
            // txtHobby
            // 
            this.txtHobby.Location = new System.Drawing.Point(34, 178);
            this.txtHobby.Name = "txtHobby";
            this.txtHobby.Size = new System.Drawing.Size(171, 20);
            this.txtHobby.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(34, 226);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmHobbies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 261);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtHobby);
            this.Controls.Add(this.lstHobbies);
            this.Name = "frmHobbies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hobbies";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstHobbies;
        private System.Windows.Forms.TextBox txtHobby;
        private System.Windows.Forms.Button btnAdd;
    }
}