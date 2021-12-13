
namespace TheToDoList
{
    partial class ToDoDashboardForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.createNewToDoButton = new System.Windows.Forms.Button();
            this.deleteSelectedTaskButton = new System.Windows.Forms.Button();
            this.todosListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.Location = new System.Drawing.Point(230, 88);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(173, 47);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "To Do List";
            // 
            // createNewToDoButton
            // 
            this.createNewToDoButton.Location = new System.Drawing.Point(115, 522);
            this.createNewToDoButton.Name = "createNewToDoButton";
            this.createNewToDoButton.Size = new System.Drawing.Size(135, 114);
            this.createNewToDoButton.TabIndex = 1;
            this.createNewToDoButton.Text = "Create New Task";
            this.createNewToDoButton.UseVisualStyleBackColor = true;
            this.createNewToDoButton.Click += new System.EventHandler(this.createNewToDoButton_Click);
            // 
            // deleteSelectedTaskButton
            // 
            this.deleteSelectedTaskButton.Location = new System.Drawing.Point(364, 522);
            this.deleteSelectedTaskButton.Name = "deleteSelectedTaskButton";
            this.deleteSelectedTaskButton.Size = new System.Drawing.Size(135, 114);
            this.deleteSelectedTaskButton.TabIndex = 3;
            this.deleteSelectedTaskButton.Text = "Delete Selected Task";
            this.deleteSelectedTaskButton.UseVisualStyleBackColor = true;
            this.deleteSelectedTaskButton.Click += new System.EventHandler(this.deleteSelectedTaskButton_Click);
            // 
            // todosListBox
            // 
            this.todosListBox.FormattingEnabled = true;
            this.todosListBox.ItemHeight = 30;
            this.todosListBox.Location = new System.Drawing.Point(115, 162);
            this.todosListBox.Name = "todosListBox";
            this.todosListBox.Size = new System.Drawing.Size(384, 304);
            this.todosListBox.TabIndex = 4;
            // 
            // ToDoDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(632, 720);
            this.Controls.Add(this.todosListBox);
            this.Controls.Add(this.deleteSelectedTaskButton);
            this.Controls.Add(this.createNewToDoButton);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ToDoDashboardForm";
            this.Text = "To Do Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button createNewToDoButton;
        private System.Windows.Forms.Button deleteSelectedTaskButton;
        private System.Windows.Forms.ListBox todosListBox;
    }
}