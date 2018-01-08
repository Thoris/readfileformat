namespace Tap.Reader.View
{
    partial class frmFile
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
            this.stbStatus = new System.Windows.Forms.StatusStrip();
            this.splitBase = new System.Windows.Forms.SplitContainer();
            this.splitProperties = new System.Windows.Forms.SplitContainer();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlRecord = new System.Windows.Forms.Panel();
            this.livRecords = new System.Windows.Forms.ListView();
            this.clmRecordPos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblRecordText = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.livFooter = new System.Windows.Forms.ListView();
            this.clmFooterPos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblFooterText = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.livHeaders = new System.Windows.Forms.ListView();
            this.clmHeaderPos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblHeaderText = new System.Windows.Forms.Label();
            this.pnlFileDescription = new System.Windows.Forms.Panel();
            this.lblFileName = new System.Windows.Forms.Label();
            this.livProperties = new System.Windows.Forms.ListView();
            this.clmPropIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPropName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPropType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPropPos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPropSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPropValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.pnlProperties = new System.Windows.Forms.Panel();
            this.txtLine = new System.Windows.Forms.TextBox();
            this.lblLineName = new System.Windows.Forms.Label();
            this.livLog = new System.Windows.Forms.ListView();
            this.clmType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTypeDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmRow = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblLogText = new System.Windows.Forms.Label();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pfdFile = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitBase)).BeginInit();
            this.splitBase.Panel1.SuspendLayout();
            this.splitBase.Panel2.SuspendLayout();
            this.splitBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitProperties)).BeginInit();
            this.splitProperties.Panel1.SuspendLayout();
            this.splitProperties.Panel2.SuspendLayout();
            this.splitProperties.SuspendLayout();
            this.pnlRecord.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlFileDescription.SuspendLayout();
            this.pnlProperties.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // stbStatus
            // 
            this.stbStatus.Location = new System.Drawing.Point(0, 430);
            this.stbStatus.Name = "stbStatus";
            this.stbStatus.Size = new System.Drawing.Size(733, 22);
            this.stbStatus.TabIndex = 0;
            this.stbStatus.Text = "statusStrip1";
            // 
            // splitBase
            // 
            this.splitBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitBase.Location = new System.Drawing.Point(0, 24);
            this.splitBase.Name = "splitBase";
            this.splitBase.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitBase.Panel1
            // 
            this.splitBase.Panel1.Controls.Add(this.splitProperties);
            // 
            // splitBase.Panel2
            // 
            this.splitBase.Panel2.Controls.Add(this.livLog);
            this.splitBase.Panel2.Controls.Add(this.lblLogText);
            this.splitBase.Size = new System.Drawing.Size(733, 406);
            this.splitBase.SplitterDistance = 321;
            this.splitBase.TabIndex = 1;
            // 
            // splitProperties
            // 
            this.splitProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitProperties.Location = new System.Drawing.Point(0, 0);
            this.splitProperties.Name = "splitProperties";
            // 
            // splitProperties.Panel1
            // 
            this.splitProperties.Panel1.Controls.Add(this.splitter2);
            this.splitProperties.Panel1.Controls.Add(this.splitter1);
            this.splitProperties.Panel1.Controls.Add(this.pnlRecord);
            this.splitProperties.Panel1.Controls.Add(this.pnlFooter);
            this.splitProperties.Panel1.Controls.Add(this.pnlHeader);
            // 
            // splitProperties.Panel2
            // 
            this.splitProperties.Panel2.Controls.Add(this.livProperties);
            this.splitProperties.Panel2.Controls.Add(this.label1);
            this.splitProperties.Panel2.Controls.Add(this.pnlProperties);
            this.splitProperties.Size = new System.Drawing.Size(733, 321);
            this.splitProperties.SplitterDistance = 354;
            this.splitProperties.TabIndex = 0;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Location = new System.Drawing.Point(0, 254);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(354, 3);
            this.splitter2.TabIndex = 4;
            this.splitter2.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 101);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(354, 3);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // pnlRecord
            // 
            this.pnlRecord.Controls.Add(this.livRecords);
            this.pnlRecord.Controls.Add(this.lblRecordText);
            this.pnlRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRecord.Location = new System.Drawing.Point(0, 101);
            this.pnlRecord.Name = "pnlRecord";
            this.pnlRecord.Size = new System.Drawing.Size(354, 156);
            this.pnlRecord.TabIndex = 2;
            // 
            // livRecords
            // 
            this.livRecords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmRecordPos});
            this.livRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.livRecords.FullRowSelect = true;
            this.livRecords.Location = new System.Drawing.Point(0, 13);
            this.livRecords.Name = "livRecords";
            this.livRecords.Size = new System.Drawing.Size(354, 143);
            this.livRecords.TabIndex = 1;
            this.livRecords.UseCompatibleStateImageBehavior = false;
            this.livRecords.View = System.Windows.Forms.View.Details;
            this.livRecords.SelectedIndexChanged += new System.EventHandler(this.livRecords_SelectedIndexChanged);
            // 
            // clmRecordPos
            // 
            this.clmRecordPos.Text = "#";
            this.clmRecordPos.Width = 43;
            // 
            // lblRecordText
            // 
            this.lblRecordText.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblRecordText.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRecordText.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblRecordText.Location = new System.Drawing.Point(0, 0);
            this.lblRecordText.Name = "lblRecordText";
            this.lblRecordText.Size = new System.Drawing.Size(354, 13);
            this.lblRecordText.TabIndex = 0;
            this.lblRecordText.Text = "Records";
            this.lblRecordText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.livFooter);
            this.pnlFooter.Controls.Add(this.lblFooterText);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 257);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(354, 64);
            this.pnlFooter.TabIndex = 1;
            // 
            // livFooter
            // 
            this.livFooter.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmFooterPos});
            this.livFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.livFooter.FullRowSelect = true;
            this.livFooter.Location = new System.Drawing.Point(0, 13);
            this.livFooter.Name = "livFooter";
            this.livFooter.Size = new System.Drawing.Size(354, 51);
            this.livFooter.TabIndex = 1;
            this.livFooter.UseCompatibleStateImageBehavior = false;
            this.livFooter.View = System.Windows.Forms.View.Details;
            this.livFooter.SelectedIndexChanged += new System.EventHandler(this.livFooter_SelectedIndexChanged);
            // 
            // clmFooterPos
            // 
            this.clmFooterPos.Text = "#";
            this.clmFooterPos.Width = 46;
            // 
            // lblFooterText
            // 
            this.lblFooterText.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblFooterText.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFooterText.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblFooterText.Location = new System.Drawing.Point(0, 0);
            this.lblFooterText.Name = "lblFooterText";
            this.lblFooterText.Size = new System.Drawing.Size(354, 13);
            this.lblFooterText.TabIndex = 0;
            this.lblFooterText.Text = "Footer";
            this.lblFooterText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.livHeaders);
            this.pnlHeader.Controls.Add(this.lblHeaderText);
            this.pnlHeader.Controls.Add(this.pnlFileDescription);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(354, 101);
            this.pnlHeader.TabIndex = 0;
            // 
            // livHeaders
            // 
            this.livHeaders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmHeaderPos});
            this.livHeaders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.livHeaders.FullRowSelect = true;
            this.livHeaders.Location = new System.Drawing.Point(0, 34);
            this.livHeaders.Name = "livHeaders";
            this.livHeaders.Size = new System.Drawing.Size(354, 67);
            this.livHeaders.TabIndex = 1;
            this.livHeaders.UseCompatibleStateImageBehavior = false;
            this.livHeaders.View = System.Windows.Forms.View.Details;
            this.livHeaders.SelectedIndexChanged += new System.EventHandler(this.livHeaders_SelectedIndexChanged);
            // 
            // clmHeaderPos
            // 
            this.clmHeaderPos.Text = "#";
            this.clmHeaderPos.Width = 41;
            // 
            // lblHeaderText
            // 
            this.lblHeaderText.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblHeaderText.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeaderText.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblHeaderText.Location = new System.Drawing.Point(0, 21);
            this.lblHeaderText.Name = "lblHeaderText";
            this.lblHeaderText.Size = new System.Drawing.Size(354, 13);
            this.lblHeaderText.TabIndex = 0;
            this.lblHeaderText.Text = "Header";
            this.lblHeaderText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlFileDescription
            // 
            this.pnlFileDescription.Controls.Add(this.lblFileName);
            this.pnlFileDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFileDescription.Location = new System.Drawing.Point(0, 0);
            this.pnlFileDescription.Name = "pnlFileDescription";
            this.pnlFileDescription.Size = new System.Drawing.Size(354, 21);
            this.pnlFileDescription.TabIndex = 2;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(3, 4);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(52, 13);
            this.lblFileName.TabIndex = 0;
            this.lblFileName.Text = "File name";
            // 
            // livProperties
            // 
            this.livProperties.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmPropIndex,
            this.clmPropName,
            this.clmPropType,
            this.clmPropPos,
            this.clmPropSize,
            this.clmPropValue});
            this.livProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.livProperties.FullRowSelect = true;
            this.livProperties.Location = new System.Drawing.Point(0, 114);
            this.livProperties.Name = "livProperties";
            this.livProperties.Size = new System.Drawing.Size(375, 207);
            this.livProperties.TabIndex = 2;
            this.livProperties.UseCompatibleStateImageBehavior = false;
            this.livProperties.View = System.Windows.Forms.View.Details;
            // 
            // clmPropIndex
            // 
            this.clmPropIndex.Text = "#";
            this.clmPropIndex.Width = 30;
            // 
            // clmPropName
            // 
            this.clmPropName.Text = "Name";
            // 
            // clmPropType
            // 
            this.clmPropType.Text = "Type";
            this.clmPropType.Width = 48;
            // 
            // clmPropPos
            // 
            this.clmPropPos.Text = "Pos";
            this.clmPropPos.Width = 43;
            // 
            // clmPropSize
            // 
            this.clmPropSize.Text = "Size";
            this.clmPropSize.Width = 44;
            // 
            // clmPropValue
            // 
            this.clmPropValue.Text = "Value";
            this.clmPropValue.Width = 59;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(0, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Values";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlProperties
            // 
            this.pnlProperties.Controls.Add(this.txtLine);
            this.pnlProperties.Controls.Add(this.lblLineName);
            this.pnlProperties.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProperties.Location = new System.Drawing.Point(0, 0);
            this.pnlProperties.Name = "pnlProperties";
            this.pnlProperties.Size = new System.Drawing.Size(375, 101);
            this.pnlProperties.TabIndex = 3;
            // 
            // txtLine
            // 
            this.txtLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLine.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLine.Location = new System.Drawing.Point(0, 21);
            this.txtLine.Multiline = true;
            this.txtLine.Name = "txtLine";
            this.txtLine.Size = new System.Drawing.Size(375, 80);
            this.txtLine.TabIndex = 1;
            // 
            // lblLineName
            // 
            this.lblLineName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLineName.Location = new System.Drawing.Point(0, 0);
            this.lblLineName.Name = "lblLineName";
            this.lblLineName.Size = new System.Drawing.Size(375, 21);
            this.lblLineName.TabIndex = 2;
            this.lblLineName.Text = "Name";
            this.lblLineName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // livLog
            // 
            this.livLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmType,
            this.clmDateTime,
            this.clmTypeDescription,
            this.clmFile,
            this.clmRow,
            this.clmColumn,
            this.clmDescription});
            this.livLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.livLog.Location = new System.Drawing.Point(0, 13);
            this.livLog.Name = "livLog";
            this.livLog.Size = new System.Drawing.Size(733, 68);
            this.livLog.TabIndex = 2;
            this.livLog.UseCompatibleStateImageBehavior = false;
            this.livLog.View = System.Windows.Forms.View.Details;
            // 
            // clmType
            // 
            this.clmType.Text = "";
            this.clmType.Width = 37;
            // 
            // clmDateTime
            // 
            this.clmDateTime.Text = "DateTime";
            this.clmDateTime.Width = 143;
            // 
            // clmTypeDescription
            // 
            this.clmTypeDescription.Text = "Type";
            this.clmTypeDescription.Width = 75;
            // 
            // clmFile
            // 
            this.clmFile.Text = "File";
            this.clmFile.Width = 77;
            // 
            // clmRow
            // 
            this.clmRow.Text = "Row";
            this.clmRow.Width = 66;
            // 
            // clmColumn
            // 
            this.clmColumn.Text = "Column";
            this.clmColumn.Width = 64;
            // 
            // clmDescription
            // 
            this.clmDescription.Text = "Description";
            this.clmDescription.Width = 238;
            // 
            // lblLogText
            // 
            this.lblLogText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblLogText.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLogText.Location = new System.Drawing.Point(0, 0);
            this.lblLogText.Name = "lblLogText";
            this.lblLogText.Size = new System.Drawing.Size(733, 13);
            this.lblLogText.TabIndex = 1;
            this.lblLogText.Text = "Log";
            this.lblLogText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(733, 24);
            this.mnuMain.TabIndex = 2;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLoadFile,
            this.toolStripMenuItem1,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuLoadFile
            // 
            this.mnuLoadFile.Name = "mnuLoadFile";
            this.mnuLoadFile.Size = new System.Drawing.Size(152, 22);
            this.mnuLoadFile.Text = "&Load File...";
            this.mnuLoadFile.Click += new System.EventHandler(this.mnuLoadFile_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(152, 22);
            this.mnuExit.Text = "&Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // pfdFile
            // 
            this.pfdFile.FileName = "File";
            // 
            // frmFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 452);
            this.Controls.Add(this.splitBase);
            this.Controls.Add(this.stbStatus);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmFile";
            this.Text = "File Reader";
            this.Load += new System.EventHandler(this.frmFile_Load);
            this.splitBase.Panel1.ResumeLayout(false);
            this.splitBase.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitBase)).EndInit();
            this.splitBase.ResumeLayout(false);
            this.splitProperties.Panel1.ResumeLayout(false);
            this.splitProperties.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitProperties)).EndInit();
            this.splitProperties.ResumeLayout(false);
            this.pnlRecord.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlFileDescription.ResumeLayout(false);
            this.pnlFileDescription.PerformLayout();
            this.pnlProperties.ResumeLayout(false);
            this.pnlProperties.PerformLayout();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip stbStatus;
        private System.Windows.Forms.SplitContainer splitBase;
        private System.Windows.Forms.SplitContainer splitProperties;
        private System.Windows.Forms.Panel pnlRecord;
        private System.Windows.Forms.ListView livRecords;
        private System.Windows.Forms.Label lblRecordText;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.ListView livFooter;
        private System.Windows.Forms.Label lblFooterText;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.ListView livHeaders;
        private System.Windows.Forms.Label lblHeaderText;
        private System.Windows.Forms.ListView livProperties;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView livLog;
        private System.Windows.Forms.Label lblLogText;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ColumnHeader clmType;
        private System.Windows.Forms.ColumnHeader clmTypeDescription;
        private System.Windows.Forms.ColumnHeader clmFile;
        private System.Windows.Forms.ColumnHeader clmRow;
        private System.Windows.Forms.ColumnHeader clmColumn;
        private System.Windows.Forms.ColumnHeader clmDescription;
        private System.Windows.Forms.Panel pnlFileDescription;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuLoadFile;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Panel pnlProperties;
        private System.Windows.Forms.ColumnHeader clmDateTime;
        private System.Windows.Forms.ColumnHeader clmPropName;
        private System.Windows.Forms.ColumnHeader clmPropType;
        private System.Windows.Forms.ColumnHeader clmPropPos;
        private System.Windows.Forms.ColumnHeader clmPropSize;
        private System.Windows.Forms.ColumnHeader clmPropValue;
        private System.Windows.Forms.TextBox txtLine;
        private System.Windows.Forms.ColumnHeader clmRecordPos;
        private System.Windows.Forms.ColumnHeader clmFooterPos;
        private System.Windows.Forms.ColumnHeader clmHeaderPos;
        private System.Windows.Forms.ColumnHeader clmPropIndex;
        private System.Windows.Forms.Label lblLineName;
        private System.Windows.Forms.OpenFileDialog pfdFile;
    }
}

