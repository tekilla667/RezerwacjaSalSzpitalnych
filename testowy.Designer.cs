namespace RezerwacjaSal
{
    partial class testowy
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
            this.buttonTESTOWY1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTESTOWY1
            // 
            this.buttonTESTOWY1.Location = new System.Drawing.Point(251, 136);
            this.buttonTESTOWY1.Name = "buttonTESTOWY1";
            this.buttonTESTOWY1.Size = new System.Drawing.Size(200, 72);
            this.buttonTESTOWY1.TabIndex = 0;
            this.buttonTESTOWY1.Text = "button1";
            this.buttonTESTOWY1.UseVisualStyleBackColor = true;
            this.buttonTESTOWY1.Click += new System.EventHandler(this.button1_Click);
            // 
            // testowy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonTESTOWY1);
            this.Name = "testowy";
            this.Text = "testowy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTESTOWY1;
    }
}