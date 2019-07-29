using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContentHunter
{
    public partial class Form1 : Form
    {
        ToolTip itemSelected = new ToolTip();
        DataTable dataTable;

        public Form1()
        {
            InitializeComponent();
            //for (var x = 0; x < 100; x++)
            //    listBox1.Items.Add(x.ToString());
            toolTip1.SetToolTip(lblIgnoreInfo, "it will be compared on file's name only");

            txtDir1.Text = @"C:\Users\a0735914\OneDrive - Aon Service Corporation\Documents\SMTP-MIGRATION";
            txtDir2.Text = @"C:\Users\a0735914\OneDrive - Aon Service Corporation\Documents\SMTP-MIGRATION-TEST";
            dataTable = new DataTable();
        }

        private void lkbDir1_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtDir1.Text = folderBrowserDialog1.SelectedPath;
            }
            else
            {

            }
        }

        private void lkbDir2_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtDir2.Text = folderBrowserDialog1.SelectedPath;
            }
            else
            {

            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            LogClear();
            if (Validar(ValidarReplace: false))
            {
                Readonly(true);
                Hunt();
                Readonly(false);
                SaveLog();
            }

        }

        private void Readonly(bool p)
        {
            btnAddIgnore.Enabled = !p;
            btnAddSearch.Enabled = !p;
            btnDir1.Enabled = !p;
            btnDir2.Enabled = !p;
            btnReplace.Enabled = !p;
            btnSearch.Enabled = !p;

            checkBox1.Enabled = !p;

            txtDir1.Enabled = !p;
            txtDir2.Enabled = !p;
            txtIgnore.Enabled = !p;
            txtReplace.Enabled = !p;
            txtSearch.Enabled = !p;

            lstIgnore.Enabled = !p;
            lstSearch.Enabled = !p;

            if (checkBox1.Enabled)
                checkBox1_CheckedChanged(checkBox1, null);
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            LogClear();
            if (Validar(ValidarReplace: true))
            {
                Readonly(true);
                HuntAndReplace();
                Readonly(false);
                SaveLog();
            }
        }

        private void SaveLog()
        {
            string dirbackup = txtDir2.Text;
            string fileGrid = Path.Combine(dirbackup, DateTime.Now.ToString("yyyyMMddHHmmss") + "GridView.csv");

            string fileTxt = Path.Combine(dirbackup, DateTime.Now.ToString("yyyyMMddHHmmss") + "Log.txt");

            StringBuilder sb = new StringBuilder();
            DataTable dt = dataTable;
            IEnumerable<string> columnNames = dt.Columns.Cast<DataColumn>().
                                              Select(column => column.ColumnName);
            sb.AppendLine(string.Join(",", columnNames));

            foreach (DataRow row in dt.Rows)
            {
                IEnumerable<string> fields = row.ItemArray.Select(field => field.ToString());
                sb.AppendLine(string.Join(",", fields));
            }

            dt = new DataTable();
            File.WriteAllText(fileGrid, sb.ToString());
            File.WriteAllText(fileTxt, String.Join("\r\n", GetItens(lstLog.Items)));
        }

        public bool Validar(bool ValidarReplace = true)
        {
            string path1 = txtDir1.Text;
            if (string.IsNullOrEmpty(path1))
            {
                Log("Directory not found");
                return false;
            }
            if (!Directory.Exists(path1))
            {
                Log("Directory not found");
                return false;
            }

            string path2 = txtDir2.Text;
            if (string.IsNullOrEmpty(path2))
            {
                Log("Directory not found");
                return false;
            }
            if (!Directory.Exists(path2))
            {
                Log("Directory not found");
                return false;
            }

            if (lstSearch.Items.Count == 0)
            {
                Log("Search list is empty");
                return false;
            }

            if (ValidarReplace)
            {
                string valueReplace = txtReplace.Text;
                if (string.IsNullOrEmpty(valueReplace))
                {
                    Log("Replace value is empty");
                    return false;
                }
            }

            return true;

        }

        private void lkbAddSearch_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lstSearch.Items.Add(txtSearch.Text);
        }

        private void lstSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstSearch.Items.Remove(lstSearch.SelectedItem);
        }

        private void lkbAddIgnore_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lstIgnore.Items.Add(txtIgnore.Text);
        }

        private void lstIgnore_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstIgnore.Items.Remove(lstIgnore.SelectedItem);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            btnReplace.Enabled = checkBox1.Checked;
        }

        void HuntAndReplace()
        {
            string[] allfiles = null;
            string[] groupWhy = null;

            LogClear();
            dataGridView1.DataSource = null;

            string folderFiles = Path.Combine(txtDir1.Text);

            string diretorioBackup = Path.Combine(txtDir2.Text);

            string replaceFor = txtReplace.Text;

            groupWhy = GetItens(lstSearch.Items);

            allfiles = Directory.GetFiles(folderFiles, "*.*", SearchOption.AllDirectories);

            dataTable = new DataTable();
            dataTable.Columns.Add("Original", typeof(string));
            dataTable.Columns.Add("Backup", typeof(string));

            Log("The Hunt begins");

            foreach (var file in allfiles)
            {
                string currentFile = file;

                Log(currentFile);

                try
                {
                    bool skip = false;
                    var EXT = GetItens(lstIgnore.Items);
                    foreach (var e in EXT)
                    {
                        if (currentFile.ToUpper().Contains(e))
                        {
                            skip = true;
                            Log("The file [\"{0}\"] was ignored", currentFile);
                            Log("Next file");
                            break;
                        }
                    }
                    if (skip) continue;

                    string fileContent = "";

                    FileInfo fi = new FileInfo(file);

                    bool save = false;

                    fileContent = File.ReadAllText(file);

                    string newContent = fileContent;

                    foreach (string what in groupWhy)
                    {
                        if (fileContent.IndexOf(what) > 0)
                        {
                            newContent = newContent.Replace(what, replaceFor);
                            Log("The value \"{0}\" was replaced to \"{1}\" in file [\"{2}\"]", what, replaceFor, file);
                            save = true;
                        }
                    }
                    if (save)
                    {
                        string nf = String.Format("{0}/{1}/{2}/", diretorioBackup, fi.Directory.Parent.Name, fi.Directory.Name);
                        if (!Directory.Exists(nf))
                            Directory.CreateDirectory(nf);
                        nf += Path.GetFileName(file);

                        File.WriteAllText(nf, fileContent);
                        Log("A backup was created for file at [\"{0}\"]", nf);

                        var r = dataTable.NewRow();
                        r["Original"] = currentFile;
                        r["Backup"] = nf;
                        dataTable.Rows.Add(r);
                        dataGridView1.DataSource = dataTable;

                        File.WriteAllText(file, newContent);
                        Log("The origin file was changed with the new value");
                    }
                    Log("Next file");
                }
                catch (System.Exception ex)
                {
                    Log("An error ocurred at file [\"{0}\"]", currentFile);
                    Log("Exception: ", ex.Message);
                }
            }

            Log("The hunt is ended");
        }

        void Hunt()
        {
            string[] allfiles = null;
            string[] groupWhy = null;

            LogClear();
            dataGridView1.DataSource = null;

            string folderFiles = Path.Combine(txtDir1.Text);

            string replaceFor = txtReplace.Text;

            string tmpl = "{0}¬{1}¬{2}¬{3}";
            List<String> result = new List<string>();
            dataTable = new DataTable();
            dataTable.Columns.Add("File", typeof(string));
            dataTable.Columns.Add("Content", typeof(string));
            dataTable.Columns.Add("What", typeof(string));
            dataTable.Columns.Add("Line", typeof(string));
            dataTable.Columns.Add("Column", typeof(string));

            groupWhy = GetItens(lstSearch.Items);

            allfiles = Directory.GetFiles(folderFiles, "*.*", SearchOption.AllDirectories);

            List<Task<Action>> tks = new System.Collections.Generic.List<Task<Action>>();

            Log("The Hunt begins");

            foreach (var file in allfiles)
            {
                string currentFile = file;

                Log(currentFile);

                try
                {
                    bool skip = false;
                    var EXT = GetItens(lstIgnore.Items);
                    foreach (var e in EXT)
                    {
                        if (e.StartsWith("/"))
                        {
                            var rgx = e.Substring(1, e.Length - 2).ToUpper();
                            Regex rg = new Regex(rgx);
                            if (rg.IsMatch(currentFile.ToUpper()))
                            {
                                skip = true;
                                break;
                            }
                        }

                        else if (currentFile.ToUpper().Contains(e))
                        {
                            skip = true;
                            break;
                        }
                    }

                    if (skip)
                    {
                        Log("The file [\"{0}\"] was ignored", currentFile);
                        continue;
                    }

                    Task<Action> t = new Task<Action>(() =>
                    {
                        List<Action> executes = new List<Action>();
                        try
                        {
                            List<string> taskResult = new List<string>();
                            FileInfo info = new FileInfo(file);
                            int counter = 0;
                            string line;
                            using (System.IO.StreamReader sr = new System.IO.StreamReader(file))
                            {
                                while ((line = sr.ReadLine()) != null)
                                {
                                    foreach (string what in groupWhy)
                                    {
                                        int nx = line.IndexOf(what);
                                        string content = line;
                                        if (nx > 0)
                                        {
                                            executes.Add(() =>
                                            {
                                                Log("The value \"{0}\" was founded in file [\"{1}\"] at line \"{2}\" and column \"{3}\"", what, file, counter, nx);
                                                result.Add(string.Format(tmpl, file, content, what, counter, nx));
                                                var r = dataTable.NewRow();
                                                r["File"] = file;
                                                r["Content"] = content;
                                                r["What"] = what;
                                                r["Line"] = counter;
                                                r["Column"] = nx;
                                                dataTable.Rows.Add(r);
                                            });
                                        }
                                    }
                                    counter++;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            executes.Add(() =>
                            {
                                Log("An error ocurred at file [\"{0}\"]", currentFile);
                                Log("Exception: ", ex.Message);
                            });
                        }

                        return () => executes.ForEach(f => f());
                    });
                    t.Start();
                    tks.Add(t);
                }
                catch (System.Exception ex)
                {
                    Log("An error ocurred at file [\"{0}\"]", currentFile);
                    Log("Exception: ", ex.Message);
                }
            }

            while (tks.Count > 0)
            {
                var nt = Task.WhenAny(tks);
                if (nt.Result.Result != null)
                {
                    nt.Result.Result();
                    dataGridView1.DataSource = dataTable;
                    tks.Remove(nt.Result);
                }
            }

            Log("The hunt is ended");
        }

        private string[] GetItens(ListBox.ObjectCollection objectCollection)
        {
            List<string> lst = new List<string>();
            foreach (var o in objectCollection) lst.Add(o.ToString());
            return lst.ToArray();
        }

        void Log(string stringformat, params object[] prms)
        {

            lstLog.Items.Add(string.Format(stringformat, prms));

        }
        void LogClear()
        {

            lstLog.Items.Clear();

        }

        private void lstLog_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemSelected.SetToolTip(lstLog, lstLog.SelectedItem.ToString());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
