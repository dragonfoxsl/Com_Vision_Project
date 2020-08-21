using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

using AForge.Video;
using AForge.Video.DirectShow;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using System.Runtime.InteropServices;
using Microsoft.Office.Core;


namespace GesturesRecognition
{
    public partial class MainForm : Form
    {
        // statistics length
        private const int statLength = 15;
        // current statistics index
        private int statIndex = 0;
        // ready statistics values
        private int statReady = 0;
        // statistics array
        private int[] statCount = new int[statLength];

        // Constructor
        public MainForm( )
        {
            InitializeComponent( );

            cameraWindow.AutoSizeControl = false;
        }

        // Application's main form is closing
        private void MainForm_FormClosing( object sender, FormClosingEventArgs e )
        {
            CloseVideoSource( );
        }

        // "Exit" menu item clicked
        private void exitToolStripMenuItem_Click( object sender, EventArgs e )
        {
            this.Close( );
        }

       
        // Open local video camera
        private void openLocalcameraToolStripMenuItem_Click( object sender, EventArgs e )
        {
            
        }

        // Open video source
        private void OpenVideoSource( IVideoSource source )
        {
            // set busy cursor
            this.Cursor = Cursors.WaitCursor;

            // close previous video source
            CloseVideoSource( );

            // create camera
            Camera camera = new Camera( source );
            // start camera
            camera.Start( );

            // attach camera to camera window
            cameraWindow.Camera = camera;

            // reset statistics
            statIndex = statReady = 0;

            // start timer
            timer.Start( );

            this.Cursor = Cursors.Default;
        }

        // Open video source
        private void OpenVideoSourceFunction(IVideoSource source)
        {
            // set busy cursor
            this.Cursor = Cursors.WaitCursor;

            // close previous video source
            CloseVideoSource();

            // create camera
            Camera camera = new Camera(source);
            // start camera
            camera.Start();

            // attach camera to camera window
            cameraWindow.Camera = camera;

            // reset statistics
            statIndex = statReady = 0;

            // start timer
            timer.Start();

            this.Cursor = Cursors.Default;
        }

        // Close current video source
        private void CloseVideoSource( )
        {
            Camera camera = cameraWindow.Camera;

            if ( camera != null )
            {
                // stop timer
                timer.Stop( );

                // detach camera from camera window
                cameraWindow.Camera = null;
                Application.DoEvents( );

                // signal camera to stop
                camera.SignalToStop( );
                // wait 2 seconds until camera stops
                for ( int i = 0; ( i < 20 ) && ( camera.IsRunning ); i++ )
                {
                    Thread.Sleep( 100 );
                }
                if ( camera.IsRunning )
                {
                    camera.Stop( );
                }
                camera = null;
           }
        }

        // On timer event - gather statistics
        private void timer_Tick( object sender, EventArgs e )
        {
            Camera camera = cameraWindow.Camera;

            if ( camera != null )
            {
                // get number of frames for the last second
                statCount[statIndex] = camera.FramesReceived;

                // increment indexes
                if ( ++statIndex >= statLength )
                    statIndex = 0;
                if ( statReady < statLength )
                    statReady++;

                float fps = 0;

                // calculate average value
                for ( int i = 0; i < statReady; i++ )
                {
                    fps += statCount[i];
                }
                fps /= statReady;

                statCount[statIndex] = 0;

                fpsLabelMain.Text = fps.ToString( "F2" ) + " fps";
            }
        }

        // Main window was resized
        private void MainForm_SizeChanged( object sender, EventArgs e )
        {
            cameraWindow.UpdatePosition( );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filename = FunctionVariables.PresentationPathProperties.ToString();
            txtEmail.Text = filename;
            PowerPoint.Application application = new PowerPoint.Application();
            PowerPoint.Presentation presesntation = application.Presentations.Open2007(filename, Microsoft.Office.Core.MsoTriState.msoTrue, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoTrue);
            PowerPoint.SlideShowSettings sst = presesntation.SlideShowSettings;
            sst.ShowType = Microsoft.Office.Interop.PowerPoint.PpSlideShowType.ppShowTypeSpeaker;
            sst.Run();

        }

        private void btnRecordedVideo_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileVideoSource fileSource = new FileVideoSource(openFileDialog.FileName);
                OpenVideoSource(fileSource);
            }
        }

        private void btnLiveStream_Click_1(object sender, EventArgs e)
        {
            VideoCaptureDeviceForm form = new VideoCaptureDeviceForm();

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                VideoCaptureDevice videoSource = new VideoCaptureDevice(form.VideoDevice);
                OpenVideoSource(videoSource);
            }
        }

        private void btnSetProperties_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtEmail.Text == "" || txtGoogleSearch.Text == "" || txtInternetURL.Text == "" || txtPrsentationPath.Text == "" || txtSearchVariable.Text == "" || txtMediaFile.Text == "")
                {
                    MessageBox.Show("Please Set All the Varibles", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    FunctionVariables.PresentationPathProperties = txtPrsentationPath.Text;
                    FunctionVariables.SearchQueryProperties = txtSearchVariable.Text;
                    FunctionVariables.InternetURLProperties = txtInternetURL.Text;
                    FunctionVariables.GoogleSearchProperties = txtGoogleSearch.Text;
                    FunctionVariables.EmailProperties = "mailto:"+txtEmail.Text;
                    FunctionVariables.MediaFileProperties = txtMediaFile.Text;

                    txtEmail.Enabled = false;
                    txtGoogleSearch.Enabled = false;
                    txtInternetURL.Enabled = false;
                    txtPrsentationPath.Enabled = false;
                    txtSearchVariable.Enabled = false;
                    txtMediaFile.Enabled = false;
                    btnSetProperties.Enabled = false;
                    btnBrowsePresentation.Enabled = false;
                    btnMediaBrowseBotton.Enabled = false;
                    openFile.Enabled = false;

                    MessageBox.Show("Varibles Added Sucessfully", "System Message",MessageBoxButtons.OK,MessageBoxIcon.Information);

                }
            }
            catch (Exception variableexception)
            {
                MessageBox.Show(variableexception.Message, "Error Occured Please Try Again");
            }
        }

        private void btnResetProperties_Click_1(object sender, EventArgs e)
        {
            txtEmail.Enabled = true;
            txtGoogleSearch.Enabled = true;
            txtInternetURL.Enabled = true;
            txtPrsentationPath.Enabled = true;
            txtSearchVariable.Enabled = true;
            txtMediaFile.Enabled = true;
            btnSetProperties.Enabled = true;
            btnBrowsePresentation.Enabled = true;
            btnMediaBrowseBotton.Enabled = true;
        }

        private void btnBrowsePresentation_Click_1(object sender, EventArgs e)
        {
            if (openFileDialogPresentation.ShowDialog() == DialogResult.OK)
            {
                string presentationpath;
                presentationpath = openFileDialogPresentation.FileName;
                txtPrsentationPath.Text = presentationpath.ToString();

            }
        }

        private void txtMediaBrowseBotton_Click(object sender, EventArgs e)
        {
            if (openFileDialogMedia.ShowDialog() == DialogResult.OK)
            {
                string mediapath;
                mediapath = openFileDialogMedia.FileName;
                txtMediaFile.Text = mediapath.ToString();

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result;

            PowerPoint._Application ppApp;
            PowerPoint.Presentation ppMP;
            ppApp = new PowerPoint.ApplicationClass();

            try
            {
                ppMP = ppApp.Presentations.Open(FunctionVariables.PresentationPathProperties.ToString(),
                   MsoTriState.msoFalse, MsoTriState.msoFalse, MsoTriState.msoTrue);
            }
            catch (Exception err)
            {
                result = MessageBox.Show("[Exception error: {0}]", err.ToString());
                return;
            }
        }

        private void openFile_Click(object sender, EventArgs e)
        {

            if (openFileDialogAnyFile.ShowDialog() == DialogResult.OK)
            {
                string filepath;
                filepath = openFileDialogAnyFile.FileName;
                txtSearchVariable.Text = filepath.ToString();

            }
        }

        private void txtSearchVariable_TextChanged(object sender, EventArgs e)
        {

        }

    }
}