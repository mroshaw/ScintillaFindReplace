namespace ScintillaFindReplace
{
    partial class Demo
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
            this.scintilla1 = new ScintillaNET.Scintilla();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonReplace = new System.Windows.Forms.Button();
            this.scintilla2 = new ScintillaNET.Scintilla();
            this.radioButtonScintilla1 = new System.Windows.Forms.RadioButton();
            this.radioButtonScintilla2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // scintilla1
            // 
            this.scintilla1.Location = new System.Drawing.Point(12, 12);
            this.scintilla1.Name = "scintilla1";
            this.scintilla1.Size = new System.Drawing.Size(462, 174);
            this.scintilla1.TabIndex = 2;
            this.scintilla1.UseTabs = false;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(480, 12);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 23);
            this.buttonFind.TabIndex = 0;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // buttonReplace
            // 
            this.buttonReplace.Location = new System.Drawing.Point(480, 42);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(75, 23);
            this.buttonReplace.TabIndex = 1;
            this.buttonReplace.Text = "Replace";
            this.buttonReplace.UseVisualStyleBackColor = true;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
            // 
            // scintilla2
            // 
            this.scintilla2.Location = new System.Drawing.Point(12, 216);
            this.scintilla2.Name = "scintilla2";
            this.scintilla2.Size = new System.Drawing.Size(462, 174);
            this.scintilla2.TabIndex = 3;
            this.scintilla2.UseTabs = false;
            // 
            // radioButtonScintilla1
            // 
            this.radioButtonScintilla1.AutoSize = true;
            this.radioButtonScintilla1.Checked = true;
            this.radioButtonScintilla1.Location = new System.Drawing.Point(13, 193);
            this.radioButtonScintilla1.Name = "radioButtonScintilla1";
            this.radioButtonScintilla1.Size = new System.Drawing.Size(70, 17);
            this.radioButtonScintilla1.TabIndex = 4;
            this.radioButtonScintilla1.TabStop = true;
            this.radioButtonScintilla1.Text = "Scintilla 1";
            this.radioButtonScintilla1.UseVisualStyleBackColor = true;
            this.radioButtonScintilla1.CheckedChanged += new System.EventHandler(this.radioButtonScintilla1_CheckedChanged);
            // 
            // radioButtonScintilla2
            // 
            this.radioButtonScintilla2.AutoSize = true;
            this.radioButtonScintilla2.Location = new System.Drawing.Point(13, 397);
            this.radioButtonScintilla2.Name = "radioButtonScintilla2";
            this.radioButtonScintilla2.Size = new System.Drawing.Size(70, 17);
            this.radioButtonScintilla2.TabIndex = 5;
            this.radioButtonScintilla2.Text = "Scintilla 2";
            this.radioButtonScintilla2.UseVisualStyleBackColor = true;
            this.radioButtonScintilla2.CheckedChanged += new System.EventHandler(this.radioButtonScintilla2_CheckedChanged);
            // 
            // Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 431);
            this.Controls.Add(this.radioButtonScintilla2);
            this.Controls.Add(this.radioButtonScintilla1);
            this.Controls.Add(this.scintilla2);
            this.Controls.Add(this.buttonReplace);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.scintilla1);
            this.Name = "Demo";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonReplace;
        private ScintillaNET.Scintilla scintilla1;
        private ScintillaNET.Scintilla scintilla2;
        private System.Windows.Forms.RadioButton radioButtonScintilla1;
        private System.Windows.Forms.RadioButton radioButtonScintilla2;
    }

}
