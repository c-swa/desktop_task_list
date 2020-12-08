

namespace desktop_task_list
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
            this.userTextInput = new System.Windows.Forms.GroupBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categoryListBox = new System.Windows.Forms.ListBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.newTaskTextbox = new System.Windows.Forms.TextBox();
            this.newTaskLabel = new System.Windows.Forms.Label();
            this.userTextInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // userTextInput
            // 
            this.userTextInput.Controls.Add(this.categoryLabel);
            this.userTextInput.Controls.Add(this.categoryListBox);
            this.userTextInput.Controls.Add(this.submitButton);
            this.userTextInput.Controls.Add(this.newTaskTextbox);
            this.userTextInput.Controls.Add(this.newTaskLabel);
            this.userTextInput.Location = new System.Drawing.Point(12, 12);
            this.userTextInput.Name = "userTextInput";
            this.userTextInput.Size = new System.Drawing.Size(668, 95);
            this.userTextInput.TabIndex = 0;
            this.userTextInput.TabStop = false;
            this.userTextInput.Text = "UserInput";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(13, 42);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(52, 13);
            this.categoryLabel.TabIndex = 4;
            this.categoryLabel.Text = "Category:";
            // 
            // categoryListBox
            // 
            this.categoryListBox.FormattingEnabled = true;
            this.categoryListBox.Items.AddRange(new object[] {
            "Home",
            "Work",
            "School"});
            this.categoryListBox.Location = new System.Drawing.Point(72, 42);
            this.categoryListBox.Name = "categoryListBox";
            this.categoryListBox.Size = new System.Drawing.Size(115, 43);
            this.categoryListBox.TabIndex = 3;
            this.categoryListBox.SelectedIndexChanged += new System.EventHandler(this.categoryListBox_SelectedIndexChanged);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(587, 14);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // newTaskTextbox
            // 
            this.newTaskTextbox.Location = new System.Drawing.Point(72, 16);
            this.newTaskTextbox.Name = "newTaskTextbox";
            this.newTaskTextbox.Size = new System.Drawing.Size(509, 20);
            this.newTaskTextbox.TabIndex = 1;
            // 
            // newTaskLabel
            // 
            this.newTaskLabel.AutoSize = true;
            this.newTaskLabel.Location = new System.Drawing.Point(6, 19);
            this.newTaskLabel.Name = "newTaskLabel";
            this.newTaskLabel.Size = new System.Drawing.Size(59, 13);
            this.newTaskLabel.TabIndex = 0;
            this.newTaskLabel.Text = "New Task:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 356);
            this.Controls.Add(this.userTextInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.userTextInput.ResumeLayout(false);
            this.userTextInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox userTextInput;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.ListBox categoryListBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox newTaskTextbox;
        private System.Windows.Forms.Label newTaskLabel;
    }
}

