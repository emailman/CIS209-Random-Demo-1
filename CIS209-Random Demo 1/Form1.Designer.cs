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
            this.pbxTails = new System.Windows.Forms.PictureBox();
            this.pbxHead = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHead)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRandInt
            // 
            this.btnRandInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandInt.Location = new System.Drawing.Point(13, 13);
            this.btnRandInt.Name = "btnRandInt";
            this.btnRandInt.Size = new System.Drawing.Size(75, 23);
            this.btnRandInt.TabIndex = 0;
            this.btnRandInt.Text = "Flip";
            this.btnRandInt.UseVisualStyleBackColor = true;
            this.btnRandInt.Click += new System.EventHandler(this.btnRandInt_Click);
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
            // pbxTails
            // 
            this.pbxTails.Image = global::CIS209_Random_Demo_1.Properties.Resources.Tails1;
            this.pbxTails.Location = new System.Drawing.Point(13, 74);
            this.pbxTails.Name = "pbxTails";
            this.pbxTails.Size = new System.Drawing.Size(170, 170);
            this.pbxTails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxTails.TabIndex = 3;
            this.pbxTails.TabStop = false;
            this.pbxTails.Visible = false;
            // 
            // pbxHead
            // 
            this.pbxHead.Image = global::CIS209_Random_Demo_1.Properties.Resources.Heads1;
            this.pbxHead.Location = new System.Drawing.Point(13, 74);
            this.pbxHead.Name = "pbxHead";
            this.pbxHead.Size = new System.Drawing.Size(170, 170);
            this.pbxHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxHead.TabIndex = 2;
            this.pbxHead.TabStop = false;
            this.pbxHead.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(199, 260);
            this.Controls.Add(this.pbxTails);
            this.Controls.Add(this.pbxHead);
            this.Controls.Add(this.lblRandInt);
            this.Controls.Add(this.btnRandInt);
            this.Name = "Form1";
            this.Text = "Coin Flip";
            ((System.ComponentModel.ISupportInitialize)(this.pbxTails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHead)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRandInt;
        private System.Windows.Forms.Label lblRandInt;
        private System.Windows.Forms.PictureBox pbxHead;
        private System.Windows.Forms.PictureBox pbxTails;
    }
}

