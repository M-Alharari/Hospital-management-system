namespace Presentation
{
    partial class PeopleList
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
            components = new System.ComponentModel.Container();
            dgPeople = new DataGridView();
            cmsPeople = new ContextMenuStrip(components);
            addToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            lblTitle = new Label();
            button1 = new Button();
            label1 = new Label();
            lblRecord = new Label();
            ((System.ComponentModel.ISupportInitialize)dgPeople).BeginInit();
            cmsPeople.SuspendLayout();
            SuspendLayout();
            // 
            // dgPeople
            // 
            dgPeople.AllowUserToAddRows = false;
            dgPeople.AllowUserToDeleteRows = false;
            dgPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPeople.ContextMenuStrip = cmsPeople;
            dgPeople.Location = new Point(12, 106);
            dgPeople.Name = "dgPeople";
            dgPeople.ReadOnly = true;
            dgPeople.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPeople.Size = new Size(731, 320);
            dgPeople.TabIndex = 1;
            // 
            // cmsPeople
            // 
            cmsPeople.Items.AddRange(new ToolStripItem[] { addToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem });
            cmsPeople.Name = "cmsPeople";
            cmsPeople.Size = new Size(108, 70);
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(107, 22);
            addToolStripMenuItem.Text = "Add";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(107, 22);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(107, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Red;
            lblTitle.Location = new Point(255, 36);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(239, 37);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Manage People";
            // 
            // button1
            // 
            button1.Location = new Point(665, 77);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Add New";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 439);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 4;
            label1.Text = "Record:";
            // 
            // lblRecord
            // 
            lblRecord.AutoSize = true;
            lblRecord.Location = new Point(65, 439);
            lblRecord.Name = "lblRecord";
            lblRecord.Size = new Size(30, 15);
            lblRecord.TabIndex = 5;
            lblRecord.Text = "[???]";
            // 
            // PeopleList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 463);
            Controls.Add(lblRecord);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(lblTitle);
            Controls.Add(dgPeople);
            Name = "PeopleList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PeopleList";
            Load += PeopleList_Load;
            ((System.ComponentModel.ISupportInitialize)dgPeople).EndInit();
            cmsPeople.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgPeople;
        private Label lblTitle;
        private Button button1;
        private ContextMenuStrip cmsPeople;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Label label1;
        private Label lblRecord;
    }
}