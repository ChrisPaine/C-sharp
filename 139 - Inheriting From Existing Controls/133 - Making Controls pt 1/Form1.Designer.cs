namespace _133___Making_Controls_pt_1
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
            this.Adam = new _133___Making_Controls_pt_1.myButton();
            this.SuspendLayout();
            // 
            // Adam
            // 
            this.Adam.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Adam.buttonText = "Chris Button";
            this.Adam.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Adam.Location = new System.Drawing.Point(81, 36);
            this.Adam.Name = "Adam";
            this.Adam.Size = new System.Drawing.Size(214, 94);
            this.Adam.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(484, 226);
            this.Controls.Add(this.Adam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private myButton Adam;
    }
}

