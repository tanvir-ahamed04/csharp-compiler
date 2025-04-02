using System.Windows.Forms;

namespace project_complier_class_task
{
    partial class Form1
    {
        private TextBox textBox1;
        private Button button1;
        private ListBox listBox1;
        private Button button2;
        private Button button3;
        private ListBox listBox2;
        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;



        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            button1 = new Button();
            listBox1 = new ListBox();
            button2 = new Button();
            button3 = new Button();
            listBox2 = new ListBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            toolStrip = new ToolStrip();
            themeButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            statusStrip = new StatusStrip();
            toolStripStatusLabelCopyright = new ToolStripStatusLabel();
            toolStripStatusLabelGitHub = new ToolStripStatusLabel();
            lightThemeMenuItem = new ToolStripMenuItem();
            darkThemeMenuItem = new ToolStripMenuItem();
            customThemeMenuItem = new ToolStripMenuItem();
            toolStripButton1 = new ToolStripButton();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.AllowDrop = true;
            textBox1.BackColor = Color.FromArgb(45, 45, 48);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(241, 241, 241);
            textBox1.Location = new Point(4, 4);
            textBox1.Margin = new Padding(4);
            textBox1.MaxLength = 30000;
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(508, 744);
            textBox1.TabIndex = 0;
            textBox1.Text = "Enter your source code:";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(45, 45, 45);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 70);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(5, 6);
            button1.Margin = new Padding(5, 6, 5, 6);
            button1.Name = "button1";
            button1.Size = new Size(169, 45);
            button1.TabIndex = 2;
            button1.Text = "Lexical analysis";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.AllowDrop = true;
            listBox1.BackColor = Color.FromArgb(45, 45, 48);
            listBox1.BorderStyle = BorderStyle.FixedSingle;
            listBox1.Dock = DockStyle.Fill;
            listBox1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.ForeColor = Color.FromArgb(241, 241, 241);
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 28;
            listBox1.Items.AddRange(new object[] { "" });
            listBox1.Location = new Point(520, 4);
            listBox1.Margin = new Padding(4);
            listBox1.Name = "listBox1";
            listBox1.RightToLeft = RightToLeft.No;
            listBox1.Size = new Size(508, 744);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(45, 45, 45);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 70);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(184, 6);
            button2.Margin = new Padding(5, 6, 5, 6);
            button2.Name = "button2";
            button2.Size = new Size(169, 45);
            button2.TabIndex = 5;
            button2.Text = "Syntax Analyser";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(45, 45, 45);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 70);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(363, 6);
            button3.Margin = new Padding(5, 6, 5, 6);
            button3.Name = "button3";
            button3.Size = new Size(169, 45);
            button3.TabIndex = 6;
            button3.Text = "Mid-Code";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.FromArgb(45, 45, 48);
            listBox2.BorderStyle = BorderStyle.FixedSingle;
            listBox2.Dock = DockStyle.Fill;
            listBox2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox2.ForeColor = Color.FromArgb(241, 241, 241);
            listBox2.FormattingEnabled = true;
            listBox2.HorizontalScrollbar = true;
            listBox2.ItemHeight = 28;
            listBox2.Location = new Point(1036, 4);
            listBox2.Margin = new Padding(4);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(510, 744);
            listBox2.TabIndex = 2;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(toolStrip);
            flowLayoutPanel1.Controls.Add(themeButton);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1550, 56);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // toolStrip
            // 
            toolStrip.Enabled = false;
            toolStrip.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip.ImageScalingSize = new Size(24, 24);
            toolStrip.Location = new Point(537, 0);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(102, 33);
            toolStrip.TabIndex = 7;
            toolStrip.Visible = false;
            toolStrip.ItemClicked += toolStrip_ItemClicked;
            // 
            // themeButton
            // 
            themeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            themeButton.BackColor = Color.FromArgb(45, 45, 45);
            themeButton.FlatAppearance.BorderSize = 0;
            themeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 70);
            themeButton.FlatStyle = FlatStyle.Flat;
            flowLayoutPanel1.SetFlowBreak(themeButton, true);
            themeButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            themeButton.ForeColor = Color.White;
            themeButton.Location = new Point(542, 6);
            themeButton.Margin = new Padding(5, 6, 5, 6);
            themeButton.Name = "themeButton";
            themeButton.Size = new Size(169, 45);
            themeButton.TabIndex = 7;
            themeButton.Text = "Theme ";
            themeButton.UseVisualStyleBackColor = false;
            themeButton.Click += themeButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel1.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(listBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(listBox2, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 56);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1550, 752);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 833);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1550, 7);
            label1.TabIndex = 2;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(24, 24);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelCopyright, toolStripStatusLabelGitHub });
            statusStrip.Location = new Point(0, 808);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1550, 25);
            statusStrip.TabIndex = 3;
            statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabelCopyright
            // 
            toolStripStatusLabelCopyright.ActiveLinkColor = Color.Blue;
            toolStripStatusLabelCopyright.BackColor = Color.Transparent;
            toolStripStatusLabelCopyright.Font = new Font("SimSun", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripStatusLabelCopyright.ForeColor = Color.Navy;
            toolStripStatusLabelCopyright.Name = "toolStripStatusLabelCopyright";
            toolStripStatusLabelCopyright.Size = new Size(468, 18);
            toolStripStatusLabelCopyright.Text = "   © 2025 Tanvir Ahamed. All rights reserved. ";
            toolStripStatusLabelCopyright.Click += toolStripStatusLabelCopyright_Click;
            // 
            // toolStripStatusLabelGitHub
            // 
            toolStripStatusLabelGitHub.ActiveLinkColor = Color.Blue;
            toolStripStatusLabelGitHub.BackColor = Color.White;
            toolStripStatusLabelGitHub.Font = new Font("SimSun", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripStatusLabelGitHub.ForeColor = Color.Crimson;
            toolStripStatusLabelGitHub.Name = "toolStripStatusLabelGitHub";
            toolStripStatusLabelGitHub.Size = new Size(708, 18);
            toolStripStatusLabelGitHub.Text = "GitHub Repository:  https://github.com/tanvir-ahamed04/csharp-compiler";
            // 
            // lightThemeMenuItem
            // 
            lightThemeMenuItem.Name = "lightThemeMenuItem";
            lightThemeMenuItem.Size = new Size(180, 22);
            lightThemeMenuItem.Text = "Light Theme";
            lightThemeMenuItem.Click += lightThemeMenuItem_Click;
            // 
            // darkThemeMenuItem
            // 
            darkThemeMenuItem.Name = "darkThemeMenuItem";
            darkThemeMenuItem.Size = new Size(180, 22);
            darkThemeMenuItem.Text = "Dark Theme";
            darkThemeMenuItem.Click += darkThemeMenuItem_Click;
            // 
            // customThemeMenuItem
            // 
            customThemeMenuItem.Name = "customThemeMenuItem";
            customThemeMenuItem.Size = new Size(180, 22);
            customThemeMenuItem.Text = "Custom Theme";
            customThemeMenuItem.Click += customThemeMenuItem_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(34, 28);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 37, 38);
            ClientSize = new Size(1550, 840);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(statusStrip);
            Controls.Add(label1);
            Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Compiler - Tanvir Ahamed";
            Load += Form1_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        // Add this method to the Form1 class
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Handle the text changed event here
        }
        // Add this method to the Form1 class
        private void Form1_Load(object sender, EventArgs e)
        {
            // Handle the form load event here
        }

        private void themeButton_Click(object sender, EventArgs e)
        {
            // Show a context menu or perform the theme change logic here
            ContextMenuStrip themeMenu = new ContextMenuStrip();
            themeMenu.Items.Add("Light Theme", null, lightThemeMenuItem_Click);
            themeMenu.Items.Add("Dark Theme", null, darkThemeMenuItem_Click);
            themeMenu.Items.Add("Custom Theme", null, customThemeMenuItem_Click);
            themeMenu.Show((Button)sender, new Point(0, ((Button)sender).Height));
        }
        private ToolStrip toolStrip;
        //private ToolStripDropDownButton themeDropDownButton;
        private Button themeButton;
        private ToolStripMenuItem lightThemeMenuItem;
        private ToolStripMenuItem darkThemeMenuItem;
        private ToolStripMenuItem customThemeMenuItem;
        private ToolStripButton toolStripButton1;
    }
}
