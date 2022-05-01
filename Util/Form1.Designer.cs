
namespace Util
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
            this.txtPass = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHash = new System.Windows.Forms.TextBox();
            this.btnHash = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(268, 102);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(340, 22);
            this.txtPass.TabIndex = 0;
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.Location = new System.Drawing.Point(152, 106);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(39, 17);
            this.Pass.TabIndex = 1;
            this.Pass.Text = "Pass";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "HashPass";
            // 
            // txtHash
            // 
            this.txtHash.Location = new System.Drawing.Point(268, 174);
            this.txtHash.Name = "txtHash";
            this.txtHash.Size = new System.Drawing.Size(340, 22);
            this.txtHash.TabIndex = 3;
            // 
            // btnHash
            // 
            this.btnHash.Location = new System.Drawing.Point(531, 264);
            this.btnHash.Name = "btnHash";
            this.btnHash.Size = new System.Drawing.Size(75, 23);
            this.btnHash.TabIndex = 4;
            this.btnHash.Text = "GetHash";
            this.btnHash.UseVisualStyleBackColor = true;
            this.btnHash.Click += new System.EventHandler(this.btnHash_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHash);
            this.Controls.Add(this.txtHash);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.txtPass);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label Pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHash;
        private System.Windows.Forms.Button btnHash;
    }
}