
namespace TheToDoList
{
    partial class CreateToDoForm
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
            this.createNewToDoButton = new System.Windows.Forms.Button();
            this.cancelCreateToDoButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.createNewToDoTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // createNewToDoButton
            // 
            this.createNewToDoButton.Location = new System.Drawing.Point(141, 221);
            this.createNewToDoButton.Name = "createNewToDoButton";
            this.createNewToDoButton.Size = new System.Drawing.Size(162, 59);
            this.createNewToDoButton.TabIndex = 0;
            this.createNewToDoButton.Text = "Create New";
            this.createNewToDoButton.UseVisualStyleBackColor = true;
            this.createNewToDoButton.Click += new System.EventHandler(this.createNewToDoButton_Click);
            // 
            // cancelCreateToDoButton
            // 
            this.cancelCreateToDoButton.Location = new System.Drawing.Point(485, 221);
            this.cancelCreateToDoButton.Name = "cancelCreateToDoButton";
            this.cancelCreateToDoButton.Size = new System.Drawing.Size(162, 59);
            this.cancelCreateToDoButton.TabIndex = 1;
            this.cancelCreateToDoButton.Text = "Cancel";
            this.cancelCreateToDoButton.UseVisualStyleBackColor = true;
            this.cancelCreateToDoButton.Click += new System.EventHandler(this.cancelCreateToDoButton_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.Location = new System.Drawing.Point(266, 41);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(256, 40);
            this.headerLabel.TabIndex = 2;
            this.headerLabel.Text = "Create New To Do!";
            // 
            // createNewToDoTextBox
            // 
            this.createNewToDoTextBox.Location = new System.Drawing.Point(141, 149);
            this.createNewToDoTextBox.Name = "createNewToDoTextBox";
            this.createNewToDoTextBox.Size = new System.Drawing.Size(506, 35);
            this.createNewToDoTextBox.TabIndex = 3;
            // 
            // CreateToDoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(788, 364);
            this.Controls.Add(this.createNewToDoTextBox);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.cancelCreateToDoButton);
            this.Controls.Add(this.createNewToDoButton);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreateToDoForm";
            this.Text = "Create New Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createNewToDoButton;
        private System.Windows.Forms.Button cancelCreateToDoButton;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox createNewToDoTextBox;
    }
}