
namespace SupermarketTuto
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
            this.button1 = new System.Windows.Forms.Button();
            this.Hi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(292, 304);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Hi
            // 
            this.Hi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Hi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Hi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Hi.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Hi.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hi.ForeColor = System.Drawing.Color.Maroon;
            this.Hi.Location = new System.Drawing.Point(0, 45);
            this.Hi.MinimumSize = new System.Drawing.Size(30, 40);
            this.Hi.Name = "Hi";
            this.Hi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Hi.Size = new System.Drawing.Size(60, 104);
            this.Hi.TabIndex = 1;
            this.Hi.Text = "Hi";
            this.Hi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Hi.UseMnemonic = false;
            this.Hi.UseWaitCursor = true;
            this.Hi.Click += new System.EventHandler(this.Hi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(592, 304);
            this.Controls.Add(this.Hi);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Hi;
    }
}

