﻿
namespace BoardUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            HeaderLabel = new TextBox();
            PersonListBox = new ListBox();
            ProjectsListBox = new ListBox();
            ProjectsListLabel = new TextBox();
            PersonListLabel = new TextBox();
            CreatePersonFormButton = new Button();
            CreateTaskFormButton = new Button();
            CreateProjectFormButton = new Button();
            splitContainer1 = new SplitContainer();
            ToDoLabel = new TextBox();
            splitContainer2 = new SplitContainer();
            CompletedLabel = new TextBox();
            IncompleteLabel = new TextBox();
            ChangeCompletedButton = new Button();
            ChangeIncompleteButton = new Button();
            RemoveTaskButton = new Button();
            UndoButton = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            SuspendLayout();
            // 
            // HeaderLabel
            // 
            HeaderLabel.BorderStyle = BorderStyle.None;
            HeaderLabel.Font = new Font("Segoe UI Historic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HeaderLabel.ForeColor = SystemColors.Highlight;
            HeaderLabel.Location = new Point(3, 3);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(193, 36);
            HeaderLabel.TabIndex = 0;
            HeaderLabel.Text = "Task Board";
            HeaderLabel.TextChanged += textBox1_TextChanged;
            // 
            // PersonListBox
            // 
            PersonListBox.FormattingEnabled = true;
            PersonListBox.Location = new Point(20, 296);
            PersonListBox.Name = "PersonListBox";
            PersonListBox.Size = new Size(289, 224);
            PersonListBox.TabIndex = 1;
            PersonListBox.SelectedIndexChanged += PersonListBox_SelectedIndexChanged;
            // 
            // ProjectsListBox
            // 
            ProjectsListBox.FormattingEnabled = true;
            ProjectsListBox.Location = new Point(20, 586);
            ProjectsListBox.Name = "ProjectsListBox";
            ProjectsListBox.Size = new Size(289, 224);
            ProjectsListBox.TabIndex = 2;
            // 
            // ProjectsListLabel
            // 
            ProjectsListLabel.BorderStyle = BorderStyle.None;
            ProjectsListLabel.Font = new Font("Segoe UI Historic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProjectsListLabel.ForeColor = SystemColors.Highlight;
            ProjectsListLabel.Location = new Point(3, 544);
            ProjectsListLabel.Name = "ProjectsListLabel";
            ProjectsListLabel.Size = new Size(193, 36);
            ProjectsListLabel.TabIndex = 3;
            ProjectsListLabel.Text = "List of projects";
            // 
            // PersonListLabel
            // 
            PersonListLabel.BorderStyle = BorderStyle.None;
            PersonListLabel.Font = new Font("Segoe UI Historic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PersonListLabel.ForeColor = SystemColors.Highlight;
            PersonListLabel.Location = new Point(3, 254);
            PersonListLabel.Name = "PersonListLabel";
            PersonListLabel.Size = new Size(193, 36);
            PersonListLabel.TabIndex = 4;
            PersonListLabel.Text = "List of persons";
            // 
            // CreatePersonFormButton
            // 
            CreatePersonFormButton.BackColor = Color.LightSkyBlue;
            CreatePersonFormButton.Location = new Point(46, 63);
            CreatePersonFormButton.Name = "CreatePersonFormButton";
            CreatePersonFormButton.Size = new Size(229, 45);
            CreatePersonFormButton.TabIndex = 5;
            CreatePersonFormButton.Text = "Create Person";
            CreatePersonFormButton.UseVisualStyleBackColor = false;
            // 
            // CreateTaskFormButton
            // 
            CreateTaskFormButton.BackColor = Color.LightSkyBlue;
            CreateTaskFormButton.Location = new Point(46, 114);
            CreateTaskFormButton.Name = "CreateTaskFormButton";
            CreateTaskFormButton.Size = new Size(229, 43);
            CreateTaskFormButton.TabIndex = 6;
            CreateTaskFormButton.Text = "Create a Task";
            CreateTaskFormButton.UseVisualStyleBackColor = false;
            // 
            // CreateProjectFormButton
            // 
            CreateProjectFormButton.BackColor = Color.LightSkyBlue;
            CreateProjectFormButton.Location = new Point(46, 163);
            CreateProjectFormButton.Name = "CreateProjectFormButton";
            CreateProjectFormButton.Size = new Size(229, 38);
            CreateProjectFormButton.TabIndex = 7;
            CreateProjectFormButton.Text = "Create a project";
            CreateProjectFormButton.UseVisualStyleBackColor = false;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(12, 12);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(CreatePersonFormButton);
            splitContainer1.Panel1.Controls.Add(HeaderLabel);
            splitContainer1.Panel1.Controls.Add(ProjectsListBox);
            splitContainer1.Panel1.Controls.Add(ProjectsListLabel);
            splitContainer1.Panel1.Controls.Add(PersonListLabel);
            splitContainer1.Panel1.Controls.Add(CreateProjectFormButton);
            splitContainer1.Panel1.Controls.Add(PersonListBox);
            splitContainer1.Panel1.Controls.Add(CreateTaskFormButton);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.Azure;
            splitContainer1.Panel2.Controls.Add(ToDoLabel);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(756, 829);
            splitContainer1.SplitterDistance = 327;
            splitContainer1.TabIndex = 8;
            // 
            // ToDoLabel
            // 
            ToDoLabel.BackColor = Color.Azure;
            ToDoLabel.BorderStyle = BorderStyle.None;
            ToDoLabel.Font = new Font("Segoe UI Historic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ToDoLabel.ForeColor = SystemColors.MenuHighlight;
            ToDoLabel.Location = new Point(171, 3);
            ToDoLabel.Name = "ToDoLabel";
            ToDoLabel.Size = new Size(82, 36);
            ToDoLabel.TabIndex = 1;
            ToDoLabel.Text = "To do:";
            ToDoLabel.TextChanged += ToDoLabel_TextChanged;
            // 
            // splitContainer2
            // 
            splitContainer2.Location = new Point(774, 12);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.BackColor = Color.Honeydew;
            splitContainer2.Panel1.Controls.Add(CompletedLabel);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.BackColor = Color.SeaShell;
            splitContainer2.Panel2.Controls.Add(IncompleteLabel);
            splitContainer2.Size = new Size(796, 586);
            splitContainer2.SplitterDistance = 403;
            splitContainer2.TabIndex = 9;
            // 
            // CompletedLabel
            // 
            CompletedLabel.BackColor = Color.Honeydew;
            CompletedLabel.BorderStyle = BorderStyle.None;
            CompletedLabel.Font = new Font("Segoe UI Historic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CompletedLabel.ForeColor = Color.LimeGreen;
            CompletedLabel.Location = new Point(135, 12);
            CompletedLabel.Name = "CompletedLabel";
            CompletedLabel.Size = new Size(141, 36);
            CompletedLabel.TabIndex = 0;
            CompletedLabel.Text = "Completed:";
            // 
            // IncompleteLabel
            // 
            IncompleteLabel.BackColor = Color.SeaShell;
            IncompleteLabel.BorderStyle = BorderStyle.None;
            IncompleteLabel.Font = new Font("Segoe UI Historic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IncompleteLabel.ForeColor = Color.Red;
            IncompleteLabel.Location = new Point(131, 12);
            IncompleteLabel.Name = "IncompleteLabel";
            IncompleteLabel.Size = new Size(145, 36);
            IncompleteLabel.TabIndex = 0;
            IncompleteLabel.Text = "Incomplete:";
            // 
            // ChangeCompletedButton
            // 
            ChangeCompletedButton.BackColor = Color.White;
            ChangeCompletedButton.FlatStyle = FlatStyle.Popup;
            ChangeCompletedButton.Location = new Point(774, 604);
            ChangeCompletedButton.Name = "ChangeCompletedButton";
            ChangeCompletedButton.Size = new Size(402, 112);
            ChangeCompletedButton.TabIndex = 10;
            ChangeCompletedButton.Text = "Change to Completed";
            ChangeCompletedButton.UseVisualStyleBackColor = false;
            ChangeCompletedButton.Click += ChangeCompletedButton_Click;
            // 
            // ChangeIncompleteButton
            // 
            ChangeIncompleteButton.FlatStyle = FlatStyle.Popup;
            ChangeIncompleteButton.Location = new Point(774, 722);
            ChangeIncompleteButton.Name = "ChangeIncompleteButton";
            ChangeIncompleteButton.Size = new Size(402, 119);
            ChangeIncompleteButton.TabIndex = 11;
            ChangeIncompleteButton.Text = "Change to Incomplete";
            ChangeIncompleteButton.UseVisualStyleBackColor = true;
            // 
            // RemoveTaskButton
            // 
            RemoveTaskButton.FlatStyle = FlatStyle.Popup;
            RemoveTaskButton.Location = new Point(1182, 604);
            RemoveTaskButton.Name = "RemoveTaskButton";
            RemoveTaskButton.Size = new Size(388, 112);
            RemoveTaskButton.TabIndex = 12;
            RemoveTaskButton.Text = "Remove a Task";
            RemoveTaskButton.UseVisualStyleBackColor = true;
            RemoveTaskButton.Click += button3_Click;
            // 
            // UndoButton
            // 
            UndoButton.FlatStyle = FlatStyle.Popup;
            UndoButton.Location = new Point(1182, 722);
            UndoButton.Name = "UndoButton";
            UndoButton.Size = new Size(388, 119);
            UndoButton.TabIndex = 13;
            UndoButton.Text = "Undo";
            UndoButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1582, 853);
            Controls.Add(UndoButton);
            Controls.Add(RemoveTaskButton);
            Controls.Add(ChangeIncompleteButton);
            Controls.Add(ChangeCompletedButton);
            Controls.Add(splitContainer2);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ToDoLabel_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void PersonListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox HeaderLabel;
        private ListBox PersonListBox;
        private ListBox ProjectsListBox;
        private TextBox ProjectsListLabel;
        private TextBox PersonListLabel;
        private Button CreatePersonFormButton;
        private Button CreateTaskFormButton;
        private Button CreateProjectFormButton;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private TextBox ToDoLabel;
        private TextBox CompletedLabel;
        private TextBox IncompleteLabel;
        private Button ChangeCompletedButton;
        private Button ChangeIncompleteButton;
        private Button RemoveTaskButton;
        private Button UndoButton;
    }
}
