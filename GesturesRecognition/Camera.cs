namespace GesturesRecognition
{
	using System;
	using System.Drawing;
	using System.Threading;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Text;
    using System.Windows.Forms;
    
    using AForge.Video;
    using AForge.GestureRecognition;
    using System.Diagnostics;
    using PowerPoint = Microsoft.Office.Interop.PowerPoint;
    using System.Runtime.InteropServices;
    using Microsoft.Office.Core;
    using SpeechLib;
	/// <summary>
	/// Camera class.
	/// </summary>
    /// 
	public class Camera
	{
		private IVideoSource	videoSource = null;
		private Bitmap			lastFrame = null;
        private string          lastVideoSourceError = null;

        private GesturesRecognizerFromVideo gesturesRecognizer = new GesturesRecognizerFromVideo( );

		// image dimension
		private int width = -1;
        private int height = -1;

        private Gesture gesture = new Gesture( );
        private int gestureShowTime = 0;

		// public events
		public event EventHandler NewFrame;
        public event EventHandler VideoSourceError;

        // Last video frame
		public Bitmap LastFrame
		{
			get { return lastFrame; }
		}

        // Last video source error
        public string LastVideoSourceError
        {
            get { return lastVideoSourceError; }
        }

		// Video frame width
		public int Width
		{
			get { return width; }
		}

		// Vodeo frame height
		public int Height
		{
			get { return height; }
		}

		// Frames received from the last access to the property
		public int FramesReceived
		{
			get { return ( videoSource == null ) ? 0 : videoSource.FramesReceived; }
		}

        // Bytes received from the last access to the property
		public int BytesReceived
		{
			get { return ( videoSource == null ) ? 0 : videoSource.BytesReceived; }
		}

		// Running property
		public bool IsRunning
		{
			get { return ( videoSource == null ) ? false : videoSource.IsRunning; }
		}

		// Constructor
        public Camera( IVideoSource source )
		{
			this.videoSource = source;
			videoSource.NewFrame += new NewFrameEventHandler( video_NewFrame );
            videoSource.VideoSourceError += new VideoSourceErrorEventHandler( video_VideoSourceError );

            gesturesRecognizer.GestureDetected += new GestureDetectionEventHandler( recognizer_GestureDetected );
		}

		// Start video source
		public void Start( )
		{
			if ( videoSource != null )
			{
                gestureShowTime = 0;
				videoSource.Start( );
			}
		}

		// Siganl video source to stop
		public void SignalToStop( )
		{
			if ( videoSource != null )
			{
				videoSource.SignalToStop( );
            }
		}

		// Wait video source for stop
		public void WaitForStop( )
		{
			// lock
			Monitor.Enter( this );

			if ( videoSource != null )
			{
				videoSource.WaitForStop( );
			}
			// unlock
			Monitor.Exit( this );
		}

		// Abort camera
		public void Stop( )
		{
			// lock
			Monitor.Enter( this );

			if ( videoSource != null )
			{
				videoSource.Stop( );
			}

			// unlock
			Monitor.Exit( this );
		}

		// Lock it
		public void Lock( )
		{
			Monitor.Enter( this );
		}

		// Unlock it
		public void Unlock( )
		{
			Monitor.Exit( this );
		}

		// On new frame
		private void video_NewFrame( object sender, NewFrameEventArgs e )
		{
			try
			{
				// lock
				Monitor.Enter( this );

				// dispose old frame
				if ( lastFrame != null )
				{
					lastFrame.Dispose( );
				}

                // reset error
                lastVideoSourceError = null;
                // get new frame
				lastFrame = (Bitmap) e.Frame.Clone( );

				// apply gestures recognizer
                gesturesRecognizer.ProcessFrame( ref lastFrame );

                
                // Idenifty the Gesture and 
                if ( gestureShowTime > 0 )
                {
                    if ((gesture.LeftHand == HandPosition.RaisedDiagonallyDown) && (gesture.RightHand == HandPosition.RaisedDiagonallyDown))
                    {
                        // Function to Open the Presentation
                        OpenPresentation();
                    }
                    else if ((gesture.LeftHand == HandPosition.RaisedStraigh) && (gesture.RightHand == HandPosition.NotRaised))
                    {
                        //Move Left the Presentation
                    }
                    else if ((gesture.LeftHand == HandPosition.NotRaised) && (gesture.RightHand == HandPosition.RaisedStraigh))
                    {
                        //Move Right the Presentation
                    }
                    else if ((gesture.LeftHand == HandPosition.RaisedDiagonallyDown) && (gesture.RightHand == HandPosition.NotRaised))
                    {
                        //Open the Media File
                        OpenMedia();
                    }
                    else if ((gesture.LeftHand == HandPosition.NotRaised) && (gesture.RightHand == HandPosition.RaisedDiagonallyDown))
                    {
                        //Open the File
                        WindowsSearch();
                    }
                    else if ((gesture.LeftHand == HandPosition.RaisedDiagonallyUp) && (gesture.RightHand == HandPosition.NotRaised))
                    {
                        //Internet URL
                        OpenBrowserURL();
                    }
                    else if ((gesture.LeftHand == HandPosition.NotRaised) && (gesture.RightHand == HandPosition.RaisedDiagonallyUp))
                    {
                        //Internet Google Search
                        OpenBrowserSearch();
                    }
                    else if ((gesture.LeftHand == HandPosition.RaisedStraigh) && (gesture.RightHand == HandPosition.RaisedDiagonallyDown))
                    {
                        //Open Email
                        EmailPerson();
                    }
                    else if ((gesture.LeftHand == HandPosition.RaisedDiagonallyUp) && (gesture.RightHand == HandPosition.RaisedDiagonallyUp))
                    {
                        //Make Speech
                        SpeechPC();
                    }
                    else
                    {
                        MessageBox.Show("Gesture Not Recognized", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    gestureShowTime--;
                }

                // image dimension
				width = lastFrame.Width;
				height = lastFrame.Height;
            }
			catch ( Exception )
			{
			}
			finally
			{
				// unlock
				Monitor.Exit( this );
			}

			// notify client
			if ( NewFrame != null )
				NewFrame( this, new EventArgs( ) );
		}

        // On video source error
        private void video_VideoSourceError( object sender, VideoSourceErrorEventArgs e )
        {
            // save video source error's description
            lastVideoSourceError = e.Description;

            // notify clients about the error
            if ( VideoSourceError != null )
            {
                VideoSourceError( this, new EventArgs( ) );
            }
        }

        // On gesture recognized
        private void recognizer_GestureDetected( object sender, Gesture gesture )
        {
            this.gesture = gesture;
            gestureShowTime = 1;
        }

        public void OpenPresentation()
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

        public void ClosePresentation()
        {
            
        }

        public void OpenMedia()
        {
            System.Diagnostics.Process.Start(FunctionVariables.MediaFileProperties.ToString());
        }

        public void WindowsSearch()
        {
            System.Diagnostics.Process.Start(FunctionVariables.SearchQueryProperties.ToString());
        }

        public void OpenBrowserURL()
        {
            System.Diagnostics.Process.Start(FunctionVariables.InternetURLProperties.ToString());
        }

        public void OpenBrowserSearch()
        {
            System.Diagnostics.Process.Start("http://google.com/search?q=" + FunctionVariables.GoogleSearchProperties.ToString());
        }

        public void EmailPerson()
        {
            System.Diagnostics.Process.Start(FunctionVariables.EmailProperties.ToString());
        }

        public void SpeechPC()
        {
            SpVoice voice = new SpVoice();
            voice.Voice = voice.GetVoices("Name=LH Michael", "Language=409").Item(0);
            voice.Speak("Hello From PC, Please go Forward with your other Gestures", SpeechVoiceSpeakFlags.SVSFDefault);


        }
	}

}
