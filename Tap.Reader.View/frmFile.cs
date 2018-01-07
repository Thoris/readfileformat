using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tap.Reader.View
{
    public partial class frmFile : Form
    {
        #region Variables

        private Core.Reading.Results.FileValue _currentFile;

        #endregion

        #region Constructors/Destructors

        public frmFile()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods




        public void ShowResult(Core.Reading.Results.FileValue file)
        {
            this.lblFileName.Text = file.FileName;




            ShowHeaders(file);
            ShowRecords(file);
            ShowFooters(file);
        }
        private void ShowHeaders(Core.Reading.Results.FileValue file)
        {
            for (int c=0; c < file.Headers.Count; c++)
            {
                this.livHeaders.Items.Add(CreateLine(this.livHeaders, file.Headers[c]));
            }
        }
        private void ShowFooters(Core.Reading.Results.FileValue file)
        {
            for (int c = 0; c < file.Footers.Count; c++)
            {
                this.livFooter.Items.Add(CreateLine(this.livFooter, file.Footers[c]));
            }
        }
        private void ShowRecords(Core.Reading.Results.FileValue file)
        {
            for (int c = 0; c < file.Records.Count; c++)
            {
                this.livRecords.Items.Add(CreateLine(this.livRecords, file.Records[c]));
            }
        }


        private void ShowPropertiesLine(Core.Reading.Results.LineValue line)
        {
            if (line == null)
            {
                this.txtLine.Text = "";
                this.livProperties.Items.Clear();
                return;
            }


            this.txtLine.Text = line.Line;

            this.livProperties.Items.Clear();

            for (int c=0; c < line.Parameters.Count; c++)
            {
                this.livProperties.Items.Add(CreateParameterLine(line.Parameters[c]));
            }
        }
        private ListViewItem CreateLine(ListView control, Core.Reading.Results.LineValue line)
        {
            ListViewItem item = new ListViewItem(line.LineNumber.ToString());

            if (control.Columns.Count < line.Parameters.Count)
            {
                for (int c=control.Columns.Count - 1; c < line.Parameters.Count; c++)
                {
                    control.Columns.Add("Col " + (c + 1));
                }
            }

            for (int c = 0; c < line.Parameters.Count; c++ )
            {
                //item.SubItems.Add("[" + line.Parameters[c].Name + ":" + line.Parameters[c].Value + "]");
                item.SubItems.Add(line.Parameters[c].ReadValue);
                item.Tag = line;
            }

            return item;
        }
        private ListViewItem CreateParameterLine(Core.Reading.Results.ParameterValue parameter)
        {
            ListViewItem entry = new ListViewItem(parameter.Name);
            entry.SubItems.Add(parameter.Type);
            entry.SubItems.Add(parameter.Position.ToString());
            entry.SubItems.Add(parameter.ValueLenght.ToString());
            entry.SubItems.Add(parameter.ReadValue);

            return entry;
        }


        #endregion

        #region Events

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void livHeaders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.livHeaders.SelectedItems.Count == 0)
            {
                ShowPropertiesLine(null);
            }
            else
            {
                Core.Reading.Results.LineValue line = (Core.Reading.Results.LineValue)
                    this.livHeaders.SelectedItems[0].Tag;

                ShowPropertiesLine(line);
            }
        }
        private void livRecords_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.livRecords.SelectedItems.Count == 0)
            {
                ShowPropertiesLine(null);
            }
            else
            {
                Core.Reading.Results.LineValue line = (Core.Reading.Results.LineValue)
                    this.livRecords.SelectedItems[0].Tag;

                ShowPropertiesLine(line);
            }
        }
        private void livFooter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.livFooter.SelectedItems.Count == 0)
            {
                ShowPropertiesLine(null);
            }
            else
            {
                Core.Reading.Results.LineValue line = (Core.Reading.Results.LineValue)
                    this.livFooter.SelectedItems[0].Tag;

                ShowPropertiesLine(line);
            }
        }
        private void frmFile_Load(object sender, EventArgs e)
        {
            Core.Configuration.ConfigurationReader configReader = new Core.Configuration.ConfigurationReader();
            Core.Configuration.FileConfiguration config = configReader.Load("Configuration.xml");


            Core.Reading.FileReader reader = new Core.Reading.FileReader();
            Core.Reading.Results.FileValue file = reader.Execute("sample.txt", config);

            _currentFile = file;
            ShowResult(file);
        }

        #endregion

    }
}
