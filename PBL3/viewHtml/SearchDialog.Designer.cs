namespace PBL3.viewHtml
{
    partial class SearchDialog
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
            this.matchCase = new System.Windows.Forms.CheckBox();
            this.matchWholeWord = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.downButton = new System.Windows.Forms.RadioButton();
            this.upButton = new System.Windows.Forms.RadioButton();
            this.cancelButton = new System.Windows.Forms.Button();
            this.findButton = new System.Windows.Forms.Button();
            this.searchString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // matchCase
            // 
            this.matchCase.AutoSize = true;
            this.matchCase.Location = new System.Drawing.Point(19, 90);
            this.matchCase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.matchCase.Name = "matchCase";
            this.matchCase.Size = new System.Drawing.Size(98, 20);
            this.matchCase.TabIndex = 13;
            this.matchCase.Text = "Match &case";
            this.matchCase.UseVisualStyleBackColor = true;
            // 
            // matchWholeWord
            // 
            this.matchWholeWord.AutoSize = true;
            this.matchWholeWord.Location = new System.Drawing.Point(19, 58);
            this.matchWholeWord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.matchWholeWord.Name = "matchWholeWord";
            this.matchWholeWord.Size = new System.Drawing.Size(163, 20);
            this.matchWholeWord.TabIndex = 12;
            this.matchWholeWord.Text = "Match &whole word only";
            this.matchWholeWord.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.downButton);
            this.groupBox1.Controls.Add(this.upButton);
            this.groupBox1.Location = new System.Drawing.Point(207, 53);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(149, 58);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Direction";
            // 
            // downButton
            // 
            this.downButton.AutoSize = true;
            this.downButton.Location = new System.Drawing.Point(68, 23);
            this.downButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(62, 20);
            this.downButton.TabIndex = 1;
            this.downButton.TabStop = true;
            this.downButton.Text = "&Down";
            this.downButton.UseVisualStyleBackColor = true;
            // 
            // upButton
            // 
            this.upButton.AutoSize = true;
            this.upButton.Location = new System.Drawing.Point(8, 23);
            this.upButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(46, 20);
            this.upButton.TabIndex = 0;
            this.upButton.TabStop = true;
            this.upButton.Text = "&Up";
            this.upButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(376, 53);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 28);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(376, 16);
            this.findButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(100, 28);
            this.findButton.TabIndex = 9;
            this.findButton.Text = "&Find Next";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // searchString
            // 
            this.searchString.Location = new System.Drawing.Point(103, 17);
            this.searchString.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchString.Name = "searchString";
            this.searchString.Size = new System.Drawing.Size(252, 22);
            this.searchString.TabIndex = 8;
            this.searchString.VisibleChanged += new System.EventHandler(this.searchString_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fi&nd What:";
            // 
            // SearchDialog
            // 
            this.AcceptButton = this.findButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(491, 127);
            this.Controls.Add(this.matchCase);
            this.Controls.Add(this.matchWholeWord);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.searchString);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SearchDialog";
            this.Text = "SearchDialog";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox matchCase;
        private System.Windows.Forms.CheckBox matchWholeWord;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton downButton;
        private System.Windows.Forms.RadioButton upButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.TextBox searchString;
        private System.Windows.Forms.Label label1;
    }
}