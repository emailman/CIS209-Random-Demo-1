namespace CIS209_Random_Demo_1
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
            this.btnRandInt = new System.Windows.Forms.Button();
            this.lblRandInt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRandInt
            // 
            this.btnRandInt.Location = new System.Drawing.Point(13, 13);
            this.btnRandInt.Name = "btnRandInt";
            this.btnRandInt.Size = new System.Drawing.Size(75, 23);
            this.btnRandInt.TabIndex = 0;
            this.btnRandInt.Text = "Random Int";
            this.btnRandInt.UseVisualStyleBackColor = true;
            // 
            // lblRandInt
            // 
            this.lblRandInt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRandInt.Location = new System.Drawing.Point(115, 13);
            this.lblRandInt.Name = "lblRandInt";
            this.lblRandInt.Size = new System.Drawing.Size(55, 23);
            this.lblRandInt.TabIndex = 1;
            this.lblRandInt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.lblRandInt);
            this.Controls.Add(this.btnRandInt);
            this.Name = "Form1";
            this.Text = "Random Things";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRandInt;
        private System.Windows.Forms.Label lblRandInt;
    }
}

