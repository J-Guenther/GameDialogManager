using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Data.SQLite;

namespace DialogManager {
    public partial class Form1 : Form {
        DataBase db = null;
        List<DialogLineContainer> dlcList = new List<DialogLineContainer>();
        DialogLineContainer activeDlc = null;
        DialogLine activeDialogLine = null;

        public Form1() {
            InitializeComponent();
            MnuMenuStrip.Renderer = new MyRenderer();
        }

        private void Form1_Load(object sender, EventArgs e) {
            DgvDataBase.ForeColor
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        // ==== Color Theme ====
        private class MyRenderer : ToolStripProfessionalRenderer {
            public MyRenderer() : base(new MyColors()) { }
        }

        private class MyColors : ProfessionalColorTable {
            public override Color MenuBorder
            {
                get { return Color.FromArgb(51, 51, 55); }
            }
            public override Color MenuItemSelected
            {
                get { return Color.FromArgb(51, 51, 52); }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.FromArgb(27, 27, 28); }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.FromArgb(51, 51, 52); }
            }
            public override Color MenuItemBorder
            {
                get { return Color.FromArgb(51, 51, 55); }
            }
        }

        // ===== MAIN MENU ====
        // Open DataBase File
        private void openDataBaseToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog() {
                Multiselect = false,
                InitialDirectory = "C:\\Temp",
                Filter = "DialogDataBase db |*.db",
                Title = "Select file to open"
            };
            ofd.ShowDialog();
            if (db != null)
                db.CloseConnection();
            db = new DataBase(ofd.FileName);
            db.OpenConnection();
            dlcList = db.GetUniqueDlcIds();
            UpdateTreeView();
        }

        private void newDataBaseToolStripMenuItem_Click(object sender, EventArgs e) {
            string dbPath;
            dbPath = Interaction.InputBox("Enter the path for the new DataBase. Example: C:\\Temp\\newDb.db");
            if (db != null)
                db.CloseConnection();
            db = new DataBase(dbPath);
            db.OpenConnection();
            db.Create();
        }

        // Updates Dialog TreeView
        private void UpdateTreeView() {

            TrvTreeView.Nodes.Clear();

            // Build up TreeView. This Part is "von hinten durch die Brust ins Auge". It works but is should be recoded some time.
            foreach (DialogLineContainer dlc in dlcList) {
                // Chapter ID does not exist in TreeView
                if (!TrvTreeView.Nodes.ContainsKey("" + dlc.dialogId.Chapter)) { 

                    // Create new Chapter entry
                    TreeNode chapterNode = new TreeNode("" + dlc.dialogId.Chapter);
                    chapterNode.Name = "" + dlc.dialogId.Chapter;
                    TrvTreeView.Nodes.Add(chapterNode);

                    // Create new Scene entry based on the scene ID
                    TreeNode sceneNode = new TreeNode("" + dlc.dialogId.Scene);
                    sceneNode.Name = "" + dlc.dialogId.Scene;
                    TrvTreeView.Nodes["" + dlc.dialogId.Chapter].Nodes.Add(sceneNode);

                    // Create new dlc entry for the scene
                    TreeNode dialogNode = new TreeNode("" + dlc.dialogId.DlcNumber);
                    dialogNode.Name = "" + dlc.dialogId.DlcNumber;
                    TrvTreeView.Nodes["" + dlc.dialogId.Chapter].Nodes["" + dlc.dialogId.Scene].Nodes.Add(dialogNode);

                }
                else { // Chapter ID already exists, now check if scene exists and add dialog to scene or create a new scene

                    bool sceneExists = false; // control variable to check if the scene is existing

                    // Go through all scenes of a chapter
                    for (int i = 0; i < TrvTreeView.Nodes["" + dlc.dialogId.Chapter].GetNodeCount(false); i++) {
                        if (TrvTreeView.Nodes["" + dlc.dialogId.Chapter].GetNodeCount(false) > 0) {
                            // if a scene == the scene ID then add a dialog to it
                            if (TrvTreeView.Nodes["" + dlc.dialogId.Chapter].Nodes[i].Name == "" + dlc.dialogId.Scene) {
                                TreeNode dialogNode = new TreeNode("" + dlc.dialogId.DlcNumber);
                                dialogNode.Name = "" + dlc.dialogId.DlcNumber;
                                TrvTreeView.Nodes["" + dlc.dialogId.Chapter].Nodes["" + dlc.dialogId.Scene].Nodes.Add(dialogNode);

                                sceneExists = true; // The scene did exist, dialog was added to the scene
                            }
                        }
                    }
                    // If the scene does not exist, add the scene and then dialog
                    if (!sceneExists) {
                        TreeNode sceneNode = new TreeNode("" + dlc.dialogId.Scene);
                        sceneNode.Name = "" + dlc.dialogId.Scene;
                        TrvTreeView.Nodes["" + dlc.dialogId.Chapter].Nodes.Add(sceneNode);

                        TreeNode dialogNode = new TreeNode("" + dlc.dialogId.DlcNumber);
                        dialogNode.Name = "" + dlc.dialogId.DlcNumber;
                        TrvTreeView.Nodes["" + dlc.dialogId.Chapter].Nodes["" + dlc.dialogId.Scene].Nodes.Add(dialogNode);
                    }
                }
            }
            TrvTreeView.ExpandAll();
        }

        private void CmdAddToDlcList_Click(object sender, EventArgs e) {
            if (db == null) {
                MessageBox.Show("No DataBase found.");
                return;
            }
                
            DialogLineContainer id = new DialogLineContainer((int)NumChapterSelect.Value, (int)NumSceneSelect.Value, (int)NumDlcSelect.Value);
            int index = dlcList.FindIndex(item => item.dialogId == id.dialogId);
            if (index < 0) {
                dlcList.Add(id);
                UpdateTreeView();
            }
            else {
                MessageBox.Show("Dialog with ID " + id.dialogId + " already exists. \nNo duplicates allowed!");
            }
        }

        // Deletes activeDlc itself and from List
        private void CmdDeleteFromDlcList_Click(object sender, EventArgs e) {
            if(activeDlc == null) {
                MessageBox.Show("No Dlc selected.");
                return;
            }
            DialogResult dr = MessageBox.Show("Do you really want to delete the DialogLineContainer with all its DialogLines from the DataBase? It cannot be restored.", "Delete DialogLineContainer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr != DialogResult.Yes)
                return;

            DialogId id = activeDlc.dialogId;
            DialogLineContainer dlc = dlcList.Find(item => item.dialogId == id);
            dlcList.Remove(dlc);
            db.DeleteLineByDlc(id);
            activeDlc = null;
            UpdateTreeView();
        }

        // Checks if selected Node is a Dlc. If true then set it as activeDlc
        private void TrvTreeView_AfterSelect(object sender, TreeViewEventArgs e) {
             TreeNode CurrentNode = e.Node;
            string fullpath = CurrentNode.FullPath;
            int firstIndex = fullpath.IndexOf("\\");
            bool result = firstIndex != fullpath.LastIndexOf("\\") && firstIndex != -1;

            if (result) {
                string[] splittedString = fullpath.Split('\\');
                DialogId id = new DialogId(Int32.Parse(splittedString[0]), Int32.Parse(splittedString[1]), Int32.Parse(splittedString[2]));
                DialogLineContainer dlc = dlcList.Find(item => item.dialogId == id);
                activeDlc = dlc;
                LblActiveDlc.Text = "Active Dlc: " + activeDlc;
                UpdateDataGridByActiveDlc(); // VERAENDERN, DAMIT ES ALLES AUF RECHTER SEITE AKTUALISIERT
            }
            else
                return;
        }

        private void CmdAddDialogLine_Click(object sender, EventArgs e) {
            if (activeDlc == null || db == null)
                throw new Exception("activeDlc || db== NULL");

            DialogLine dialogLine = new DialogLine(activeDlc);
            db.Insert(dialogLine);
            UpdateDataGridByActiveDlc();
            SelectDgvRowById(db.GetLatestId());
            
        }

        private void UpdateDataGrid(SQLiteConnection con, string sql) {
            DataSet dataSet = new DataSet();
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(sql, con);
            dataAdapter.Fill(dataSet);
            DgvDataBase.DataSource = dataSet.Tables[0].DefaultView;
        }

        private void UpdateDataGridByActiveDlc() {
            if (activeDlc == null)
                return;
            UpdateDataGrid(db.GetConnection(), "SELECT * " +
                    "FROM dialogDb WHERE chapter = " + activeDlc.dialogId.Chapter + " AND scene = " + activeDlc.dialogId.Scene + " AND dlcNumber = " + activeDlc.dialogId.DlcNumber + " ORDER BY id ASC");
        }

        private void DgvDataBase_SelectionChanged(object sender, EventArgs e) {
            try {
                int rowIndex = DgvDataBase.SelectedRows[0].Index;
                DataGridViewRow selectedRow = DgvDataBase.Rows[rowIndex];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                activeDialogLine = db.GetLineById(id);
                LblActiveDialogLine.Text = "Active DialogLine: " + activeDialogLine;
                LoadDialogLineContent();
            }
            catch {}
        }
       
        private void SelectDgvRowById(int id) {
            foreach (DataGridViewRow row in DgvDataBase.Rows) {
                // 0 is the column index
                if (row.Cells[0].Value.ToString().Equals("" + id)) {
                    row.Selected = true;
                    DgvDataBase.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }
        }

        private void CmdDeleteDialogLine_Click(object sender, EventArgs e) {
            if (activeDialogLine == null || db == null)
                return;
            DialogResult dr = MessageBox.Show("Do you really want to delete the DialogLine from the DataBase? It cannot be restored.", "Delete DialogLineContainer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr != DialogResult.Yes)
                return;
            db.DeleteLineById(activeDialogLine.Id);
            activeDialogLine = null;
            UpdateDataGridByActiveDlc();
        }

        private void LoadDialogLineContent() {
            BoxCharacterName.Text = activeDialogLine.Character;
            BoxContentGer.Text = activeDialogLine.ContentGer;
            BoxContentEng.Text = activeDialogLine.ContentEng;
            BoxRequirements.Text = activeDialogLine.Requirements;
            BoxAudioFileGer.Text = activeDialogLine.AudioFileGer;
            BoxAudioFileEng.Text = activeDialogLine.AudioFileEng;
            BoxIsEntry.Checked = activeDialogLine.IsEntry;
            BoxIsJump.Checked = activeDialogLine.IsJump;
            NumEventTrigger.Value = activeDialogLine.EventTrigger;
            NumPrevious.Value = activeDialogLine.previous;
            NumNext0.Value = activeDialogLine.next[0];
            NumNext1.Value = activeDialogLine.next[1];
            NumNext2.Value = activeDialogLine.next[2];
            NumNext3.Value = activeDialogLine.next[3];
            NumPause.Value = (int)activeDialogLine.Pause;
        }

        private void SaveDialogLineContent() {
            if (activeDialogLine == null)
                return;
            activeDialogLine.Character = BoxCharacterName.Text;
            activeDialogLine.ContentGer = BoxContentGer.Text;
            activeDialogLine.ContentEng = BoxContentEng.Text;
            activeDialogLine.Requirements = BoxRequirements.Text;
            activeDialogLine.AudioFileGer = BoxAudioFileGer.Text;
            activeDialogLine.AudioFileEng = BoxAudioFileEng.Text;
            activeDialogLine.IsEntry = BoxIsEntry.Checked;
            activeDialogLine.IsJump = BoxIsJump.Checked;
            activeDialogLine.EventTrigger = (int)NumEventTrigger.Value;
            activeDialogLine.previous = (int)NumPrevious.Value;
            activeDialogLine.next[0] = (int)NumNext0.Value;
            activeDialogLine.next[1] = (int)NumNext1.Value;
            activeDialogLine.next[2] = (int)NumNext2.Value;
            activeDialogLine.next[3] = (int)NumNext3.Value;
            activeDialogLine.Pause = (float)NumPause.Value;
            activeDialogLine.UpdateActiveNexts();
            db.UpdateLineByID(activeDialogLine);
        }

        private void CmdSaveDialogLineContent_Click(object sender, EventArgs e) {
            SaveDialogLineContent();
            UpdateDataGridByActiveDlc();
        }
    }

    

}
