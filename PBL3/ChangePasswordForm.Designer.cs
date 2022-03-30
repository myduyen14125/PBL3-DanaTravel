
namespace PBL3
{
    partial class ChangePasswordForm
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
            this.lbNewPass = new System.Windows.Forms.Label();
            this.lbConfỉmPass = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.lbCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNewPass
            // 
            this.lbNewPass.AutoSize = true;
            this.lbNewPass.Location = new System.Drawing.Point(169, 95);
            this.lbNewPass.Name = "lbNewPass";
            this.lbNewPass.Size = new System.Drawing.Size(100, 17);
            this.lbNewPass.TabIndex = 0;
            this.lbNewPass.Text = "New Password";
            // 
            // lbConfỉmPass
            // 
            this.lbConfỉmPass.AutoSize = true;
            this.lbConfỉmPass.Location = new System.Drawing.Point(169, 151);
            this.lbConfỉmPass.Name = "lbConfỉmPass";
            this.lbConfỉmPass.Size = new System.Drawing.Size(121, 17);
            this.lbConfỉmPass.TabIndex = 1;
            this.lbConfỉmPass.Text = "Confirm Password";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(337, 95);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(186, 22);
            this.txtNewPass.TabIndex = 2;
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(337, 146);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(186, 22);
            this.txtConfirmPass.TabIndex = 3;
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.Location = new System.Drawing.Point(169, 198);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(41, 17);
            this.lbCode.TabIndex = 4;
            this.lbCode.Text = "Code";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(337, 198);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(186, 22);
            this.txtCode.TabIndex = 5;
            // 
            // btnChangePass
            // 
            this.btnChangePass.Location = new System.Drawing.Point(438, 253);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(85, 29);
            this.btnChangePass.TabIndex = 6;
            this.btnChangePass.Text = "Change Password";
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lbCode);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.lbConfỉmPass);
            this.Controls.Add(this.lbNewPass);
            this.Name = "ChangePasswordForm";
            this.Text = "ChangePasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNewPass;
        private System.Windows.Forms.Label lbConfỉmPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Label lbCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnChangePass;
    }
}