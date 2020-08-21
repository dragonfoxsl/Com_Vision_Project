namespace GesturesRecognition
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            this.components = new System.ComponentModel.Container();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openLocalcameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openvideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.fpsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.cameraWindow = new GesturesRecognition.CameraWindow();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.variableListgroupbox = new System.Windows.Forms.GroupBox();
            this.openFile = new System.Windows.Forms.Button();
            this.btnMediaBrowseBotton = new System.Windows.Forms.Button();
            this.txtMediaFile = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnResetProperties = new System.Windows.Forms.Button();
            this.btnSetProperties = new System.Windows.Forms.Button();
            this.btnBrowsePresentation = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtGoogleSearch = new System.Windows.Forms.TextBox();
            this.txtInternetURL = new System.Windows.Forms.TextBox();
            this.txtSearchVariable = new System.Windows.Forms.TextBox();
            this.txtPrsentationPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRecordedVideo = new System.Windows.Forms.Button();
            this.btnLiveStream = new System.Windows.Forms.Button();
            this.openFileDialogPresentation = new System.Windows.Forms.OpenFileDialog();
            this.fpsLabelMain = new System.Windows.Forms.Label();
            this.openFileDialogMedia = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogAnyFile = new System.Windows.Forms.OpenFileDialog();
            this.statusBar.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.variableListgroupbox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileMenu
            // 
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";
            // 
            // openLocalcameraToolStripMenuItem
            // 
            this.openLocalcameraToolStripMenuItem.Name = "openLocalcameraToolStripMenuItem";
            this.openLocalcameraToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.openLocalcameraToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.openLocalcameraToolStripMenuItem.Text = "Open local &camera";
            // 
            // openvideoToolStripMenuItem
            // 
            this.openvideoToolStripMenuItem.Name = "openvideoToolStripMenuItem";
            this.openvideoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.openvideoToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(212, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "AVI files (*.avi)|*.avi|All files (*.*)|*.*";
            this.openFileDialog.Title = "Opem video";
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusBar.Location = new System.Drawing.Point(0, 384);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1129, 22);
            this.statusBar.TabIndex = 1;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(434, 17);
            this.toolStripStatusLabel2.Text = "Gesture Recognition V 0.4 Copyright @ Bisina Keshara Wickremasinghe - 1025619";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 17);
            // 
            // fpsLabel
            // 
            this.fpsLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.fpsLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.fpsLabel.Name = "fpsLabel";
            this.fpsLabel.Size = new System.Drawing.Size(700, 17);
            this.fpsLabel.Spring = true;
            this.fpsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(414, 17);
            this.toolStripStatusLabel1.Text = "Copyright @ Gesture Recognition - Bisina Keshara Wickremasinghe - 1025619";
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.cameraWindow);
            this.mainPanel.Location = new System.Drawing.Point(4, 13);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(333, 272);
            this.mainPanel.TabIndex = 2;
            // 
            // cameraWindow
            // 
            this.cameraWindow.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cameraWindow.Camera = null;
            this.cameraWindow.Location = new System.Drawing.Point(10, 10);
            this.cameraWindow.Name = "cameraWindow";
            this.cameraWindow.Size = new System.Drawing.Size(320, 256);
            this.cameraWindow.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            // 
            // variableListgroupbox
            // 
            this.variableListgroupbox.Controls.Add(this.openFile);
            this.variableListgroupbox.Controls.Add(this.btnMediaBrowseBotton);
            this.variableListgroupbox.Controls.Add(this.txtMediaFile);
            this.variableListgroupbox.Controls.Add(this.label6);
            this.variableListgroupbox.Controls.Add(this.btnResetProperties);
            this.variableListgroupbox.Controls.Add(this.btnSetProperties);
            this.variableListgroupbox.Controls.Add(this.btnBrowsePresentation);
            this.variableListgroupbox.Controls.Add(this.txtEmail);
            this.variableListgroupbox.Controls.Add(this.txtGoogleSearch);
            this.variableListgroupbox.Controls.Add(this.txtInternetURL);
            this.variableListgroupbox.Controls.Add(this.txtSearchVariable);
            this.variableListgroupbox.Controls.Add(this.txtPrsentationPath);
            this.variableListgroupbox.Controls.Add(this.label5);
            this.variableListgroupbox.Controls.Add(this.label4);
            this.variableListgroupbox.Controls.Add(this.label3);
            this.variableListgroupbox.Controls.Add(this.label2);
            this.variableListgroupbox.Controls.Add(this.label1);
            this.variableListgroupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variableListgroupbox.Location = new System.Drawing.Point(361, 12);
            this.variableListgroupbox.Name = "variableListgroupbox";
            this.variableListgroupbox.Size = new System.Drawing.Size(757, 345);
            this.variableListgroupbox.TabIndex = 6;
            this.variableListgroupbox.TabStop = false;
            this.variableListgroupbox.Text = "Variable List";
            // 
            // openFile
            // 
            this.openFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFile.Location = new System.Drawing.Point(602, 119);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(75, 23);
            this.openFile.TabIndex = 17;
            this.openFile.Text = "Browse";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // btnMediaBrowseBotton
            // 
            this.btnMediaBrowseBotton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMediaBrowseBotton.Location = new System.Drawing.Point(602, 81);
            this.btnMediaBrowseBotton.Name = "btnMediaBrowseBotton";
            this.btnMediaBrowseBotton.Size = new System.Drawing.Size(75, 23);
            this.btnMediaBrowseBotton.TabIndex = 15;
            this.btnMediaBrowseBotton.Text = "Browse";
            this.btnMediaBrowseBotton.UseVisualStyleBackColor = true;
            this.btnMediaBrowseBotton.Click += new System.EventHandler(this.txtMediaBrowseBotton_Click);
            // 
            // txtMediaFile
            // 
            this.txtMediaFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMediaFile.Location = new System.Drawing.Point(178, 82);
            this.txtMediaFile.Name = "txtMediaFile";
            this.txtMediaFile.Size = new System.Drawing.Size(394, 21);
            this.txtMediaFile.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Media File";
            // 
            // btnResetProperties
            // 
            this.btnResetProperties.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnResetProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetProperties.Location = new System.Drawing.Point(295, 296);
            this.btnResetProperties.Name = "btnResetProperties";
            this.btnResetProperties.Size = new System.Drawing.Size(111, 39);
            this.btnResetProperties.TabIndex = 12;
            this.btnResetProperties.Text = "Reset Properties";
            this.btnResetProperties.UseVisualStyleBackColor = false;
            this.btnResetProperties.Click += new System.EventHandler(this.btnResetProperties_Click_1);
            // 
            // btnSetProperties
            // 
            this.btnSetProperties.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSetProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetProperties.Location = new System.Drawing.Point(178, 296);
            this.btnSetProperties.Name = "btnSetProperties";
            this.btnSetProperties.Size = new System.Drawing.Size(111, 39);
            this.btnSetProperties.TabIndex = 11;
            this.btnSetProperties.Text = "Set Properties";
            this.btnSetProperties.UseVisualStyleBackColor = false;
            this.btnSetProperties.Click += new System.EventHandler(this.btnSetProperties_Click_1);
            // 
            // btnBrowsePresentation
            // 
            this.btnBrowsePresentation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowsePresentation.Location = new System.Drawing.Point(602, 39);
            this.btnBrowsePresentation.Name = "btnBrowsePresentation";
            this.btnBrowsePresentation.Size = new System.Drawing.Size(75, 23);
            this.btnBrowsePresentation.TabIndex = 10;
            this.btnBrowsePresentation.Text = "Browse";
            this.btnBrowsePresentation.UseVisualStyleBackColor = true;
            this.btnBrowsePresentation.Click += new System.EventHandler(this.btnBrowsePresentation_Click_1);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(178, 249);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(394, 21);
            this.txtEmail.TabIndex = 9;
            // 
            // txtGoogleSearch
            // 
            this.txtGoogleSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGoogleSearch.Location = new System.Drawing.Point(178, 203);
            this.txtGoogleSearch.Name = "txtGoogleSearch";
            this.txtGoogleSearch.Size = new System.Drawing.Size(394, 21);
            this.txtGoogleSearch.TabIndex = 8;
            // 
            // txtInternetURL
            // 
            this.txtInternetURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInternetURL.Location = new System.Drawing.Point(178, 161);
            this.txtInternetURL.Name = "txtInternetURL";
            this.txtInternetURL.Size = new System.Drawing.Size(394, 21);
            this.txtInternetURL.TabIndex = 7;
            // 
            // txtSearchVariable
            // 
            this.txtSearchVariable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchVariable.Location = new System.Drawing.Point(178, 120);
            this.txtSearchVariable.Name = "txtSearchVariable";
            this.txtSearchVariable.Size = new System.Drawing.Size(394, 21);
            this.txtSearchVariable.TabIndex = 6;
            this.txtSearchVariable.Text = "E:\\Dropbox\\University of Wolverhampton\\6MM006 1025619 Wickremasinghe.docx";
            this.txtSearchVariable.TextChanged += new System.EventHandler(this.txtSearchVariable_TextChanged);
            // 
            // txtPrsentationPath
            // 
            this.txtPrsentationPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrsentationPath.Location = new System.Drawing.Point(178, 40);
            this.txtPrsentationPath.Name = "txtPrsentationPath";
            this.txtPrsentationPath.Size = new System.Drawing.Size(394, 21);
            this.txtPrsentationPath.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Google Search";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Internet URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Open File";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Presentation Path";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRecordedVideo);
            this.groupBox1.Controls.Add(this.btnLiveStream);
            this.groupBox1.Controls.Add(this.mainPanel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 345);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Video Stream";
            // 
            // btnRecordedVideo
            // 
            this.btnRecordedVideo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRecordedVideo.Location = new System.Drawing.Point(178, 291);
            this.btnRecordedVideo.Name = "btnRecordedVideo";
            this.btnRecordedVideo.Size = new System.Drawing.Size(147, 48);
            this.btnRecordedVideo.TabIndex = 4;
            this.btnRecordedVideo.Text = "Select Recorded Video";
            this.btnRecordedVideo.UseVisualStyleBackColor = false;
            this.btnRecordedVideo.Click += new System.EventHandler(this.btnRecordedVideo_Click);
            // 
            // btnLiveStream
            // 
            this.btnLiveStream.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLiveStream.Location = new System.Drawing.Point(14, 291);
            this.btnLiveStream.Name = "btnLiveStream";
            this.btnLiveStream.Size = new System.Drawing.Size(147, 48);
            this.btnLiveStream.TabIndex = 3;
            this.btnLiveStream.Text = "Select Live Stream";
            this.btnLiveStream.UseVisualStyleBackColor = false;
            this.btnLiveStream.Click += new System.EventHandler(this.btnLiveStream_Click_1);
            // 
            // openFileDialogPresentation
            // 
            this.openFileDialogPresentation.FileName = "openFileDialogPresentation";
            this.openFileDialogPresentation.Filter = "Slid Show|*.ppsx|Presentation|*.pptx|Presentation 97-2003|*ppt|All|*.*";
            // 
            // fpsLabelMain
            // 
            this.fpsLabelMain.AutoSize = true;
            this.fpsLabelMain.Location = new System.Drawing.Point(13, 364);
            this.fpsLabelMain.Name = "fpsLabelMain";
            this.fpsLabelMain.Size = new System.Drawing.Size(0, 13);
            this.fpsLabelMain.TabIndex = 8;
            // 
            // openFileDialogMedia
            // 
            this.openFileDialogMedia.FileName = "openFileDialog1";
            // 
            // openFileDialogAnyFile
            // 
            this.openFileDialogAnyFile.FileName = "openFileDialogAnyFile";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 406);
            this.Controls.Add(this.fpsLabelMain);
            this.Controls.Add(this.variableListgroupbox);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Gestures Recognition";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.variableListgroupbox.ResumeLayout(false);
            this.variableListgroupbox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem openLocalcameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openvideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel fpsLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer timer;
        private CameraWindow cameraWindow;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox variableListgroupbox;
        private System.Windows.Forms.Button btnSetProperties;
        private System.Windows.Forms.Button btnBrowsePresentation;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtGoogleSearch;
        private System.Windows.Forms.TextBox txtInternetURL;
        private System.Windows.Forms.TextBox txtSearchVariable;
        private System.Windows.Forms.TextBox txtPrsentationPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialogPresentation;
        private System.Windows.Forms.Button btnResetProperties;
        private System.Windows.Forms.Button btnRecordedVideo;
        private System.Windows.Forms.Button btnLiveStream;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Label fpsLabelMain;
        private System.Windows.Forms.TextBox txtMediaFile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnMediaBrowseBotton;
        private System.Windows.Forms.OpenFileDialog openFileDialogMedia;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.OpenFileDialog openFileDialogAnyFile;
    }
}

