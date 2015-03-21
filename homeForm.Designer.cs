namespace Thunder_Archive
{
    partial class homeForm
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
            System.Windows.Forms.TabPage tabPage1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homeForm));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.reminderListBox = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.deleteSelectedStandBybutton = new System.Windows.Forms.Button();
            this.clearStandBybutton = new System.Windows.Forms.Button();
            this.standByCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toDoEventRichTextBox = new System.Windows.Forms.RichTextBox();
            this.removeSelectedTodoTodaybutton = new System.Windows.Forms.Button();
            this.flushTodoTodaybutton = new System.Windows.Forms.Button();
            this.addTODOtodaybutton = new System.Windows.Forms.Button();
            this.TodoTodaycheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.homeTab = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.noWarningRemoveHWcheckBox = new System.Windows.Forms.CheckBox();
            this.clearHW_Button = new System.Windows.Forms.Button();
            this.homeWorkDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.excellExamButton = new System.Windows.Forms.Button();
            this.printExamsButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.examDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examTopic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.NavigatePrograme = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.semesterArchiveButton = new System.Windows.Forms.Button();
            this.personalButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.futureButton = new System.Windows.Forms.Button();
            this.foldersButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.moveToStandByButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HWfile = new System.Windows.Forms.DataGridViewLinkColumn();
            this.browsColmn = new System.Windows.Forms.DataGridViewLinkColumn();
            tabPage1 = new System.Windows.Forms.TabPage();
            tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.homeTab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeWorkDataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(this.groupBox4);
            tabPage1.Controls.Add(this.groupBox3);
            tabPage1.Controls.Add(this.groupBox2);
            tabPage1.Location = new System.Drawing.Point(4, 22);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(604, 418);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Manual";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.reminderListBox);
            this.groupBox4.Location = new System.Drawing.Point(277, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(281, 158);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Up Coming";
            // 
            // reminderListBox
            // 
            this.reminderListBox.FormattingEnabled = true;
            this.reminderListBox.Location = new System.Drawing.Point(18, 19);
            this.reminderListBox.Name = "reminderListBox";
            this.reminderListBox.Size = new System.Drawing.Size(245, 121);
            this.reminderListBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.deleteSelectedStandBybutton);
            this.groupBox3.Controls.Add(this.clearStandBybutton);
            this.groupBox3.Controls.Add(this.standByCheckedListBox);
            this.groupBox3.Location = new System.Drawing.Point(277, 190);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 222);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "StandBy Tasks";
            // 
            // deleteSelectedStandBybutton
            // 
            this.deleteSelectedStandBybutton.Location = new System.Drawing.Point(54, 19);
            this.deleteSelectedStandBybutton.Name = "deleteSelectedStandBybutton";
            this.deleteSelectedStandBybutton.Size = new System.Drawing.Size(75, 42);
            this.deleteSelectedStandBybutton.TabIndex = 2;
            this.deleteSelectedStandBybutton.Text = "Delete Selected";
            this.deleteSelectedStandBybutton.UseVisualStyleBackColor = true;
            this.deleteSelectedStandBybutton.Click += new System.EventHandler(this.deleteSelectedStandBybutton_Click);
            // 
            // clearStandBybutton
            // 
            this.clearStandBybutton.Location = new System.Drawing.Point(150, 19);
            this.clearStandBybutton.Name = "clearStandBybutton";
            this.clearStandBybutton.Size = new System.Drawing.Size(75, 42);
            this.clearStandBybutton.TabIndex = 1;
            this.clearStandBybutton.Text = "Clear All";
            this.clearStandBybutton.UseVisualStyleBackColor = true;
            this.clearStandBybutton.Click += new System.EventHandler(this.clearStandBybutton_Click);
            // 
            // standByCheckedListBox
            // 
            this.standByCheckedListBox.FormattingEnabled = true;
            this.standByCheckedListBox.Location = new System.Drawing.Point(18, 67);
            this.standByCheckedListBox.Name = "standByCheckedListBox";
            this.standByCheckedListBox.Size = new System.Drawing.Size(230, 139);
            this.standByCheckedListBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.moveToStandByButton);
            this.groupBox2.Controls.Add(this.toDoEventRichTextBox);
            this.groupBox2.Controls.Add(this.removeSelectedTodoTodaybutton);
            this.groupBox2.Controls.Add(this.flushTodoTodaybutton);
            this.groupBox2.Controls.Add(this.addTODOtodaybutton);
            this.groupBox2.Controls.Add(this.TodoTodaycheckedListBox);
            this.groupBox2.Location = new System.Drawing.Point(15, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 396);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ToDo Today";
            // 
            // toDoEventRichTextBox
            // 
            this.toDoEventRichTextBox.Location = new System.Drawing.Point(15, 79);
            this.toDoEventRichTextBox.MaxLength = 100;
            this.toDoEventRichTextBox.Name = "toDoEventRichTextBox";
            this.toDoEventRichTextBox.Size = new System.Drawing.Size(208, 36);
            this.toDoEventRichTextBox.TabIndex = 4;
            this.toDoEventRichTextBox.Text = "Click to type your \"TODO\" event ";
            this.toDoEventRichTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.toDoEventRichTextBox_MouseClick);
            // 
            // removeSelectedTodoTodaybutton
            // 
            this.removeSelectedTodoTodaybutton.Location = new System.Drawing.Point(47, 344);
            this.removeSelectedTodoTodaybutton.Name = "removeSelectedTodoTodaybutton";
            this.removeSelectedTodoTodaybutton.Size = new System.Drawing.Size(83, 42);
            this.removeSelectedTodoTodaybutton.TabIndex = 3;
            this.removeSelectedTodoTodaybutton.Text = "Remove Selected";
            this.removeSelectedTodoTodaybutton.UseVisualStyleBackColor = true;
            this.removeSelectedTodoTodaybutton.Click += new System.EventHandler(this.removeSelectedTodoTodaybutton_Click);
            // 
            // flushTodoTodaybutton
            // 
            this.flushTodoTodaybutton.Location = new System.Drawing.Point(136, 344);
            this.flushTodoTodaybutton.Name = "flushTodoTodaybutton";
            this.flushTodoTodaybutton.Size = new System.Drawing.Size(55, 42);
            this.flushTodoTodaybutton.TabIndex = 2;
            this.flushTodoTodaybutton.Text = "Flush";
            this.flushTodoTodaybutton.UseVisualStyleBackColor = true;
            this.flushTodoTodaybutton.Click += new System.EventHandler(this.flushTodoTodaybutton_Click);
            // 
            // addTODOtodaybutton
            // 
            this.addTODOtodaybutton.Location = new System.Drawing.Point(15, 32);
            this.addTODOtodaybutton.Name = "addTODOtodaybutton";
            this.addTODOtodaybutton.Size = new System.Drawing.Size(58, 42);
            this.addTODOtodaybutton.TabIndex = 1;
            this.addTODOtodaybutton.Text = "Add";
            this.addTODOtodaybutton.UseVisualStyleBackColor = true;
            this.addTODOtodaybutton.Click += new System.EventHandler(this.addTODOtodaybutton_Click);
            // 
            // TodoTodaycheckedListBox
            // 
            this.TodoTodaycheckedListBox.FormattingEnabled = true;
            this.TodoTodaycheckedListBox.Location = new System.Drawing.Point(15, 121);
            this.TodoTodaycheckedListBox.Name = "TodoTodaycheckedListBox";
            this.TodoTodaycheckedListBox.Size = new System.Drawing.Size(208, 214);
            this.TodoTodaycheckedListBox.TabIndex = 0;
            // 
            // homeTab
            // 
            this.homeTab.Controls.Add(tabPage1);
            this.homeTab.Controls.Add(this.tabPage2);
            this.homeTab.Controls.Add(this.tabPage3);
            this.homeTab.Location = new System.Drawing.Point(165, 44);
            this.homeTab.Name = "homeTab";
            this.homeTab.SelectedIndex = 0;
            this.homeTab.Size = new System.Drawing.Size(612, 444);
            this.homeTab.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.noWarningRemoveHWcheckBox);
            this.tabPage2.Controls.Add(this.clearHW_Button);
            this.tabPage2.Controls.Add(this.homeWorkDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(604, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Home Works";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // noWarningRemoveHWcheckBox
            // 
            this.noWarningRemoveHWcheckBox.AutoSize = true;
            this.noWarningRemoveHWcheckBox.Location = new System.Drawing.Point(27, 383);
            this.noWarningRemoveHWcheckBox.Name = "noWarningRemoveHWcheckBox";
            this.noWarningRemoveHWcheckBox.Size = new System.Drawing.Size(295, 17);
            this.noWarningRemoveHWcheckBox.TabIndex = 2;
            this.noWarningRemoveHWcheckBox.Text = "Don\'t show warning when deleting (NOT Recommended)";
            this.noWarningRemoveHWcheckBox.UseVisualStyleBackColor = true;
            // 
            // clearHW_Button
            // 
            this.clearHW_Button.Location = new System.Drawing.Point(480, 368);
            this.clearHW_Button.Name = "clearHW_Button";
            this.clearHW_Button.Size = new System.Drawing.Size(91, 44);
            this.clearHW_Button.TabIndex = 1;
            this.clearHW_Button.Text = "Clear All";
            this.clearHW_Button.UseVisualStyleBackColor = true;
            this.clearHW_Button.Click += new System.EventHandler(this.clearHW_Button_Click);
            // 
            // homeWorkDataGridView
            // 
            this.homeWorkDataGridView.AllowUserToResizeColumns = false;
            this.homeWorkDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.homeWorkDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.homeWorkDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Details,
            this.Column2,
            this.HWfile,
            this.browsColmn});
            this.homeWorkDataGridView.Location = new System.Drawing.Point(27, 28);
            this.homeWorkDataGridView.Name = "homeWorkDataGridView";
            this.homeWorkDataGridView.Size = new System.Drawing.Size(544, 334);
            this.homeWorkDataGridView.TabIndex = 0;
            this.homeWorkDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.homeWorkDataGridView_CellContentClick);
            this.homeWorkDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.homeWorkDataGridView_UserDeletingRow);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.excellExamButton);
            this.tabPage3.Controls.Add(this.printExamsButton);
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(604, 418);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Exams";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // excellExamButton
            // 
            this.excellExamButton.Location = new System.Drawing.Point(488, 120);
            this.excellExamButton.Name = "excellExamButton";
            this.excellExamButton.Size = new System.Drawing.Size(99, 47);
            this.excellExamButton.TabIndex = 2;
            this.excellExamButton.Text = "Export Excel";
            this.excellExamButton.UseVisualStyleBackColor = true;
            // 
            // printExamsButton
            // 
            this.printExamsButton.Location = new System.Drawing.Point(488, 57);
            this.printExamsButton.Name = "printExamsButton";
            this.printExamsButton.Size = new System.Drawing.Size(99, 47);
            this.printExamsButton.TabIndex = 1;
            this.printExamsButton.Text = "Print";
            this.printExamsButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.examDate,
            this.examTopic,
            this.examType,
            this.examClass});
            this.dataGridView2.Location = new System.Drawing.Point(24, 27);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(443, 335);
            this.dataGridView2.TabIndex = 0;
            // 
            // examDate
            // 
            this.examDate.HeaderText = "Date";
            this.examDate.Name = "examDate";
            // 
            // examTopic
            // 
            this.examTopic.HeaderText = "Topic";
            this.examTopic.Name = "examTopic";
            // 
            // examType
            // 
            this.examType.HeaderText = "Type";
            this.examType.Name = "examType";
            // 
            // examClass
            // 
            this.examClass.HeaderText = "Class/Building";
            this.examClass.Name = "examClass";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.NavigatePrograme,
            this.toolStripSeparator2,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(789, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // NavigatePrograme
            // 
            this.NavigatePrograme.Name = "NavigatePrograme";
            this.NavigatePrograme.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(40, 22);
            this.toolStripLabel1.Text = "Home";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 491);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ThunderWiring™ Productions";
            // 
            // semesterArchiveButton
            // 
            this.semesterArchiveButton.Location = new System.Drawing.Point(15, 109);
            this.semesterArchiveButton.Name = "semesterArchiveButton";
            this.semesterArchiveButton.Size = new System.Drawing.Size(91, 42);
            this.semesterArchiveButton.TabIndex = 4;
            this.semesterArchiveButton.Text = "Semester Archive";
            this.semesterArchiveButton.UseVisualStyleBackColor = true;
            // 
            // personalButton
            // 
            this.personalButton.Location = new System.Drawing.Point(15, 174);
            this.personalButton.Name = "personalButton";
            this.personalButton.Size = new System.Drawing.Size(91, 42);
            this.personalButton.TabIndex = 2;
            this.personalButton.Text = "Personal";
            this.personalButton.UseVisualStyleBackColor = true;
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(15, 48);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(91, 42);
            this.homeButton.TabIndex = 1;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            // 
            // futureButton
            // 
            this.futureButton.Location = new System.Drawing.Point(15, 239);
            this.futureButton.Name = "futureButton";
            this.futureButton.Size = new System.Drawing.Size(91, 42);
            this.futureButton.TabIndex = 3;
            this.futureButton.Text = "Future Plans";
            this.futureButton.UseVisualStyleBackColor = true;
            // 
            // foldersButton
            // 
            this.foldersButton.Location = new System.Drawing.Point(15, 304);
            this.foldersButton.Name = "foldersButton";
            this.foldersButton.Size = new System.Drawing.Size(91, 42);
            this.foldersButton.TabIndex = 5;
            this.foldersButton.Text = "Folders";
            this.foldersButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.foldersButton);
            this.groupBox1.Controls.Add(this.futureButton);
            this.groupBox1.Controls.Add(this.homeButton);
            this.groupBox1.Controls.Add(this.personalButton);
            this.groupBox1.Controls.Add(this.semesterArchiveButton);
            this.groupBox1.Location = new System.Drawing.Point(15, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 362);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Catagories";
            // 
            // moveToStandByButton
            // 
            this.moveToStandByButton.Location = new System.Drawing.Point(85, 32);
            this.moveToStandByButton.Name = "moveToStandByButton";
            this.moveToStandByButton.Size = new System.Drawing.Size(137, 41);
            this.moveToStandByButton.TabIndex = 5;
            this.moveToStandByButton.Text = "Move Selected to Stand-By";
            this.moveToStandByButton.UseVisualStyleBackColor = true;
            this.moveToStandByButton.Click += new System.EventHandler(this.moveToStandByButton_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Files";
            this.dataGridViewImageColumn1.Image = global::Thunder_Archive.Properties.Resources.archive;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.ToolTipText = "click to view file";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Topic";
            this.Column1.Name = "Column1";
            // 
            // Details
            // 
            this.Details.Frozen = true;
            this.Details.HeaderText = "Details";
            this.Details.Name = "Details";
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Due To Date";
            this.Column2.Name = "Column2";
            // 
            // HWfile
            // 
            this.HWfile.HeaderText = "Files";
            this.HWfile.Name = "HWfile";
            this.HWfile.ReadOnly = true;
            this.HWfile.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.HWfile.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.HWfile.Text = "View";
            this.HWfile.ToolTipText = "click to view file";
            this.HWfile.UseColumnTextForLinkValue = true;
            // 
            // browsColmn
            // 
            this.browsColmn.ActiveLinkColor = System.Drawing.Color.Navy;
            this.browsColmn.HeaderText = "Brows";
            this.browsColmn.Name = "browsColmn";
            this.browsColmn.ReadOnly = true;
            this.browsColmn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.browsColmn.Text = "Brows";
            this.browsColmn.UseColumnTextForLinkValue = true;
            // 
            // homeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 513);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.homeTab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "homeForm";
            this.Text = "Thunder Archive ";
            this.Load += new System.EventHandler(this.Form1_Load);
            tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.homeTab.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeWorkDataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl homeTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox NavigatePrograme;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView homeWorkDataGridView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox TodoTodaycheckedListBox;
        private System.Windows.Forms.Button removeSelectedTodoTodaybutton;
        private System.Windows.Forms.Button flushTodoTodaybutton;
        private System.Windows.Forms.Button addTODOtodaybutton;
        private System.Windows.Forms.Button deleteSelectedStandBybutton;
        private System.Windows.Forms.Button clearStandBybutton;
        private System.Windows.Forms.CheckedListBox standByCheckedListBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox reminderListBox;
        private System.Windows.Forms.Button excellExamButton;
        private System.Windows.Forms.Button printExamsButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn examDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn examTopic;
        private System.Windows.Forms.DataGridViewTextBoxColumn examType;
        private System.Windows.Forms.DataGridViewTextBoxColumn examClass;
        private System.Windows.Forms.RichTextBox toDoEventRichTextBox;
        private System.Windows.Forms.Button clearHW_Button;
        private System.Windows.Forms.CheckBox noWarningRemoveHWcheckBox;
        private System.Windows.Forms.Button semesterArchiveButton;
        private System.Windows.Forms.Button personalButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button futureButton;
        private System.Windows.Forms.Button foldersButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button moveToStandByButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Details;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewLinkColumn HWfile;
        private System.Windows.Forms.DataGridViewLinkColumn browsColmn;






    }
}

