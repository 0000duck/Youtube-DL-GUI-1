﻿namespace youtube_dl
{
    partial class Form1
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
            this.UrlBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.DownloadStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.downloadSpeedLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.FiletypeBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.DownloadGrid = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VideoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.destinationBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.filenameBox = new System.Windows.Forms.TextBox();
            this.useTitleCheckbox = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.queueButton = new System.Windows.Forms.Button();
            this.downloadVideoWorker = new System.ComponentModel.BackgroundWorker();
            this.deleteButton = new System.Windows.Forms.Button();
            this.ThumbnailBox = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TitleCard = new System.Windows.Forms.Label();
            this.IDCard = new System.Windows.Forms.Label();
            this.FiletypeCard = new System.Windows.Forms.Label();
            this.PathCard = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DownloadGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UrlBox
            // 
            this.UrlBox.Location = new System.Drawing.Point(81, 23);
            this.UrlBox.Name = "UrlBox";
            this.UrlBox.Size = new System.Drawing.Size(503, 20);
            this.UrlBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL/ID:";
            // 
            // DownloadButton
            // 
            this.DownloadButton.Enabled = false;
            this.DownloadButton.Location = new System.Drawing.Point(447, 529);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(137, 23);
            this.DownloadButton.TabIndex = 2;
            this.DownloadButton.Text = "Download";
            this.DownloadButton.UseVisualStyleBackColor = true;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DownloadStatus,
            this.downloadSpeedLabel,
            this.toolStripStatusLabel1,
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 565);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(596, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip";
            // 
            // DownloadStatus
            // 
            this.DownloadStatus.Name = "DownloadStatus";
            this.DownloadStatus.Size = new System.Drawing.Size(80, 17);
            this.DownloadStatus.Text = "No Download";
            // 
            // downloadSpeedLabel
            // 
            this.downloadSpeedLabel.Name = "downloadSpeedLabel";
            this.downloadSpeedLabel.Size = new System.Drawing.Size(56, 17);
            this.downloadSpeedLabel.Text = "0.0 MiB/s";
            this.downloadSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // FiletypeBox
            // 
            this.FiletypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiletypeBox.FormattingEnabled = true;
            this.FiletypeBox.Items.AddRange(new object[] {
            "m4a (audio only)",
            "mp4 - 144p (video only)",
            "mp4 - 240p (video only)",
            "mp4 - 360p (video only)",
            "mp4 - 480p (video only)",
            "mp4 - 720p (video only)",
            "3gp - 176x144     ",
            "3gp - 320x240     ",
            "flv - 400x240     ",
            "webm - 640x360     ",
            "mp4 - 640x360 (video and audio)",
            "mp4 -1280x720 (video and audio)",
            "default"});
            this.FiletypeBox.Location = new System.Drawing.Point(81, 101);
            this.FiletypeBox.Name = "FiletypeBox";
            this.FiletypeBox.Size = new System.Drawing.Size(502, 21);
            this.FiletypeBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "File Type:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 500);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(571, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // DownloadGrid
            // 
            this.DownloadGrid.AllowUserToAddRows = false;
            this.DownloadGrid.AllowUserToDeleteRows = false;
            this.DownloadGrid.AllowUserToOrderColumns = true;
            this.DownloadGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DownloadGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Title,
            this.VideoID});
            this.DownloadGrid.Location = new System.Drawing.Point(12, 141);
            this.DownloadGrid.MultiSelect = false;
            this.DownloadGrid.Name = "DownloadGrid";
            this.DownloadGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DownloadGrid.Size = new System.Drawing.Size(571, 231);
            this.DownloadGrid.TabIndex = 8;
            this.DownloadGrid.SelectionChanged += new System.EventHandler(this.DownloadGrid_SelectionChanged);
            // 
            // Number
            // 
            this.Number.HeaderText = "#";
            this.Number.Name = "Number";
            this.Number.Width = 20;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.Width = 305;
            // 
            // VideoID
            // 
            this.VideoID.HeaderText = "VideoID";
            this.VideoID.Name = "VideoID";
            this.VideoID.Width = 200;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(480, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Select Folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Destination:";
            // 
            // destinationBox
            // 
            this.destinationBox.Location = new System.Drawing.Point(81, 49);
            this.destinationBox.Name = "destinationBox";
            this.destinationBox.Size = new System.Drawing.Size(393, 20);
            this.destinationBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "File Name:";
            // 
            // filenameBox
            // 
            this.filenameBox.Location = new System.Drawing.Point(81, 75);
            this.filenameBox.Name = "filenameBox";
            this.filenameBox.Size = new System.Drawing.Size(393, 20);
            this.filenameBox.TabIndex = 13;
            // 
            // useTitleCheckbox
            // 
            this.useTitleCheckbox.AutoSize = true;
            this.useTitleCheckbox.Checked = true;
            this.useTitleCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useTitleCheckbox.Location = new System.Drawing.Point(480, 78);
            this.useTitleCheckbox.Name = "useTitleCheckbox";
            this.useTitleCheckbox.Size = new System.Drawing.Size(98, 17);
            this.useTitleCheckbox.TabIndex = 14;
            this.useTitleCheckbox.Text = "Use Video Title";
            this.useTitleCheckbox.UseVisualStyleBackColor = true;
            this.useTitleCheckbox.CheckedChanged += new System.EventHandler(this.useTitleCheckbox_CheckedChanged);
            // 
            // queueButton
            // 
            this.queueButton.Location = new System.Drawing.Point(12, 529);
            this.queueButton.Name = "queueButton";
            this.queueButton.Size = new System.Drawing.Size(147, 23);
            this.queueButton.TabIndex = 16;
            this.queueButton.Text = "Add to Queue";
            this.queueButton.UseVisualStyleBackColor = true;
            this.queueButton.Click += new System.EventHandler(this.queueButton_Click);
            // 
            // downloadVideoWorker
            // 
            this.downloadVideoWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.downloadVideoWorker_DoWork);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(188, 529);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(137, 23);
            this.deleteButton.TabIndex = 17;
            this.deleteButton.Text = "Delete from Queue";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // ThumbnailBox
            // 
            this.ThumbnailBox.Location = new System.Drawing.Point(15, 392);
            this.ThumbnailBox.Name = "ThumbnailBox";
            this.ThumbnailBox.Size = new System.Drawing.Size(148, 102);
            this.ThumbnailBox.TabIndex = 18;
            this.ThumbnailBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Video Title:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Video ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(169, 442);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Filetype:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(169, 469);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Download Location:";
            // 
            // TitleCard
            // 
            this.TitleCard.AutoSize = true;
            this.TitleCard.Location = new System.Drawing.Point(277, 392);
            this.TitleCard.Name = "TitleCard";
            this.TitleCard.Size = new System.Drawing.Size(0, 13);
            this.TitleCard.TabIndex = 23;
            // 
            // IDCard
            // 
            this.IDCard.AutoSize = true;
            this.IDCard.Location = new System.Drawing.Point(277, 417);
            this.IDCard.Name = "IDCard";
            this.IDCard.Size = new System.Drawing.Size(0, 13);
            this.IDCard.TabIndex = 24;
            // 
            // FiletypeCard
            // 
            this.FiletypeCard.AutoSize = true;
            this.FiletypeCard.Location = new System.Drawing.Point(277, 442);
            this.FiletypeCard.Name = "FiletypeCard";
            this.FiletypeCard.Size = new System.Drawing.Size(0, 13);
            this.FiletypeCard.TabIndex = 25;
            // 
            // PathCard
            // 
            this.PathCard.AutoSize = true;
            this.PathCard.Location = new System.Drawing.Point(277, 469);
            this.PathCard.Name = "PathCard";
            this.PathCard.Size = new System.Drawing.Size(0, 13);
            this.PathCard.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 587);
            this.Controls.Add(this.PathCard);
            this.Controls.Add(this.FiletypeCard);
            this.Controls.Add(this.IDCard);
            this.Controls.Add(this.TitleCard);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ThumbnailBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.queueButton);
            this.Controls.Add(this.useTitleCheckbox);
            this.Controls.Add(this.filenameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.destinationBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DownloadGrid);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FiletypeBox);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UrlBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Youtube-DL GUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DownloadGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UrlBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ComboBox FiletypeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridView DownloadGrid;
        private System.Windows.Forms.ToolStripStatusLabel DownloadStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn VideoID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox destinationBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox filenameBox;
        private System.Windows.Forms.CheckBox useTitleCheckbox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ToolStripStatusLabel downloadSpeedLabel;
        private System.Windows.Forms.Button queueButton;
        private System.ComponentModel.BackgroundWorker downloadVideoWorker;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.PictureBox ThumbnailBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label TitleCard;
        private System.Windows.Forms.Label IDCard;
        private System.Windows.Forms.Label FiletypeCard;
        private System.Windows.Forms.Label PathCard;
    }
}

