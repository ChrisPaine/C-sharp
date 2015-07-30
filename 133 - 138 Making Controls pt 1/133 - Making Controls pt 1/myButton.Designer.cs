namespace _133___Making_Controls_pt_1
{
    partial class myButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // myButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "myButton";
            this.Size = new System.Drawing.Size(156, 95);
            this.Leave += new System.EventHandler(this.myButton_Leave);
            this.MouseEnter += new System.EventHandler(this.myButton_MouseEnter);
            this.MouseHover += new System.EventHandler(this.myButton_MouseHover);
            this.ResumeLayout(false);

        }

        #endregion

    }
}
