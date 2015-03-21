using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Thunder_Archive
{
    public partial class homeForm : Form
    {
        #region Constructor
        public homeForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            
        }
        #endregion //Constructor

        #region Defines
        private const int FILE_COLUMN_INDEX = 3;
        private const int BROWS_COLUMN_INDEX = 4;
        private const string EMPTY_STRING = "";
        #endregion //Defines
        /********************************************************************************/
        #region Private aux functions
        private string loadFile()
        {
            string filePath = "";
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Desktop|*.*";
            System.Windows.Forms.DialogResult dialogResult = fileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                filePath = fileDialog.FileName;
            }
            return filePath;
        }
        #endregion //Private aux functions
        /********************************************************************************/
        #region Events
        private void toDoEventRichTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            toDoEventRichTextBox.Clear();
        }
        /********************************************************************************/
        /*
         * event handler for showing a warning when deleting a row from the HomeWork-
         * data grid using 'delete' button
         */
        private void homeWorkDataGridView_UserDeletingRow(object sender,
                    DataGridViewRowCancelEventArgs e)
        {
            if (noWarningRemoveHWcheckBox.Checked) {
                return;
            }
            else if (!e.Row.IsNewRow)
            {
                DialogResult response = MessageBox.Show("Are you sure?", "Delete row?",
                                  MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question,
                                  MessageBoxDefaultButton.Button2);

                if (response == DialogResult.No)
                    e.Cancel = true;
            }
        }
        /********************************************************************************/
        /*
         * an event handler when clicking on the 'brows' link-word in the-
         * homeWork dataGrid link column
         * */
        private void homeWorkDataGridView_CellContentClick(object sender,
            DataGridViewCellEventArgs e)
        {            
            if ((e.RowIndex < 0) || (e.ColumnIndex != BROWS_COLUMN_INDEX)) 
            {
                return;
            }
            string homeWorkFilePath = loadFile();
            if (homeWorkFilePath == EMPTY_STRING)
            {
                return;
            }
            homeWorkDataGridView.Rows[e.RowIndex].Cells[FILE_COLUMN_INDEX].Value = homeWorkFilePath;
        }
        #endregion //Events
        /****************************_Button Click Functions_****************************/
        #region Buttons
        /*
         * adding the text in the richTextBox to the checkList
         */
        private void addTODOtodaybutton_Click(object sender, EventArgs e)
        {
            if (toDoEventRichTextBox.Text == "Click to type your \"TODO\" event ")
            {
                return;
            }
            TodoTodaycheckedListBox.Items.Add(toDoEventRichTextBox.Text);
        }
        /********************************************************************************/
        /*
         * Delete all the items in the checkList
         * */
        private void flushTodoTodaybutton_Click(object sender, EventArgs e)
        {
            TodoTodaycheckedListBox.Items.Clear();
        }
        /********************************************************************************/
        /*
         * Delete only the selected items in the checkList
         * */
        private void removeSelectedTodoTodaybutton_Click(object sender, EventArgs e)
        {
            int lastIndex = TodoTodaycheckedListBox.Items.Count - 1;
            for (int i = lastIndex; i >= 0; i--)
            {
                if (TodoTodaycheckedListBox.GetItemCheckState(i) == CheckState.Checked)
                {
                    TodoTodaycheckedListBox.Items.RemoveAt(i);
                }
            }
        }        
        /********************************************************************************/
        /*
         * clears all the rows n the dataGrid of the homeWorks
         */
        private void clearHW_Button_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Are you sure?", "Delete row?",
                                  MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question,
                                  MessageBoxDefaultButton.Button2);

            if (response == DialogResult.Yes)
            {
                homeWorkDataGridView.Rows.Clear();
            }


        }
        /********************************************************************************/
        /*
         * moves the selected items from the 'todo' checklist box to the 'stand by'
         * tasks check box
         * */
        private void moveToStandByButton_Click(object sender, EventArgs e)
        {
            int lastIndex = TodoTodaycheckedListBox.Items.Count - 1;
            for (int i = lastIndex; i >= 0; i--)
            {
                if (TodoTodaycheckedListBox.GetItemCheckState(i) == CheckState.Checked)
                {
                    standByCheckedListBox.Items.Add(TodoTodaycheckedListBox.Items[i]);
                    TodoTodaycheckedListBox.Items.RemoveAt(i);
                }
            }
        }
        /********************************************************************************/
        /*
         * clears all the items from the checkbox of stand by tasks
         * */
        private void clearStandBybutton_Click(object sender, EventArgs e)
        {
            standByCheckedListBox.Items.Clear();
        }        
        /********************************************************************************/
        /*
         * clears all the selected items from the stand-by ytasks in the checklist
         * */
        private void deleteSelectedStandBybutton_Click(object sender, EventArgs e)
        {
            int lastIndex = standByCheckedListBox.Items.Count - 1;
            for (int i = lastIndex; i >= 0; i--)
            {
                if (standByCheckedListBox.GetItemCheckState(i) == CheckState.Checked)
                {
                    standByCheckedListBox.Items.RemoveAt(i);
                }
            }
        }
        #endregion //Buttons

        

       

        

        
        
    }
}
