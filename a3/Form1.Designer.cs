namespace a3
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            visibilityToolStripMenuItem = new ToolStripMenuItem();
            backgroundToolStripMenuItem = new ToolStripMenuItem();
            lightToolStripMenuItem1 = new ToolStripMenuItem();
            darkToolStripMenuItem1 = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            toolbarToolStripMenuItem = new ToolStripMenuItem();
            statusbarToolStripMenuItem = new ToolStripMenuItem();
            lastFilesToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            filesToolStripMenuItem = new ToolStripMenuItem();
            textBox1 = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            copyToolStripMenuItem = new ToolStripMenuItem();
            putToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            bindingSource1 = new BindingSource(components);
            button1 = new Button();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, visibilityToolStripMenuItem, lastFilesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, closeToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(180, 22);
            openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(180, 22);
            saveToolStripMenuItem.Text = "Save";
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            closeToolStripMenuItem.Size = new Size(180, 22);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // visibilityToolStripMenuItem
            // 
            visibilityToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { backgroundToolStripMenuItem, optionsToolStripMenuItem });
            visibilityToolStripMenuItem.Name = "visibilityToolStripMenuItem";
            visibilityToolStripMenuItem.Size = new Size(63, 20);
            visibilityToolStripMenuItem.Text = "Visibility";
            // 
            // backgroundToolStripMenuItem
            // 
            backgroundToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lightToolStripMenuItem1, darkToolStripMenuItem1 });
            backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            backgroundToolStripMenuItem.Size = new Size(138, 22);
            backgroundToolStripMenuItem.Text = "Background";
            // 
            // lightToolStripMenuItem1
            // 
            lightToolStripMenuItem1.Name = "lightToolStripMenuItem1";
            lightToolStripMenuItem1.Size = new Size(101, 22);
            lightToolStripMenuItem1.Text = "Light";
            lightToolStripMenuItem1.Click += lightToolStripMenuItem1_Click;
            // 
            // darkToolStripMenuItem1
            // 
            darkToolStripMenuItem1.Name = "darkToolStripMenuItem1";
            darkToolStripMenuItem1.Size = new Size(101, 22);
            darkToolStripMenuItem1.Text = "Dark";
            darkToolStripMenuItem1.Click += darkToolStripMenuItem1_Click;
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolbarToolStripMenuItem, statusbarToolStripMenuItem });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(138, 22);
            optionsToolStripMenuItem.Text = "Options";
            // 
            // toolbarToolStripMenuItem
            // 
            toolbarToolStripMenuItem.Name = "toolbarToolStripMenuItem";
            toolbarToolStripMenuItem.Size = new Size(123, 22);
            toolbarToolStripMenuItem.Text = "Toolbar";
            // 
            // statusbarToolStripMenuItem
            // 
            statusbarToolStripMenuItem.Name = "statusbarToolStripMenuItem";
            statusbarToolStripMenuItem.Size = new Size(123, 22);
            statusbarToolStripMenuItem.Text = "Statusbar";
            // 
            // lastFilesToolStripMenuItem
            // 
            lastFilesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem, filesToolStripMenuItem });
            lastFilesToolStripMenuItem.Name = "lastFilesToolStripMenuItem";
            lastFilesToolStripMenuItem.Size = new Size(66, 20);
            lastFilesToolStripMenuItem.Text = "Last Files";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(97, 22);
            addToolStripMenuItem.Text = "Add";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // filesToolStripMenuItem
            // 
            filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            filesToolStripMenuItem.Size = new Size(97, 22);
            filesToolStripMenuItem.Text = "Files";
            filesToolStripMenuItem.Click += filesToolStripMenuItem_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.ContextMenuStrip = contextMenuStrip1;
            textBox1.Location = new Point(12, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { copyToolStripMenuItem, putToolStripMenuItem, deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(108, 70);
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(107, 22);
            copyToolStripMenuItem.Text = "Copy";
            // 
            // putToolStripMenuItem
            // 
            putToolStripMenuItem.Name = "putToolStripMenuItem";
            putToolStripMenuItem.Size = new Size(107, 22);
            putToolStripMenuItem.Text = "Put";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(107, 22);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // button1
            // 
            button1.Location = new Point(12, 79);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 2;
            button1.Text = "Tic";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 120);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private TextBox textBox1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem putToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem visibilityToolStripMenuItem;
        private ToolStripMenuItem lastFilesToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem filesToolStripMenuItem;
        private ToolStripMenuItem backgroundToolStripMenuItem;
        private ToolStripMenuItem lightToolStripMenuItem1;
        private ToolStripMenuItem darkToolStripMenuItem1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem toolbarToolStripMenuItem;
        private ToolStripMenuItem statusbarToolStripMenuItem;
        private BindingSource bindingSource1;
        private Button button1;
        private Label label1;
    }
}
