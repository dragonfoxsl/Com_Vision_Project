using System;
using System.Collections.Generic;
using System.Text;

namespace GesturesRecognition
{
    public class FunctionVariables
    {
        private static string presentationPathVariable = null;
        private static string searchQueryVariable = null;
        private static string internetUrlVariable = null;
        private static string googleSearchVariable = null;
        private static string emailVariable = null;
        private static string mediafileVariable = null;

        public static string PresentationPathProperties
        {
            get { return presentationPathVariable; }
            set { presentationPathVariable = value; }
        }

        public static string SearchQueryProperties
        {
            get { return searchQueryVariable; }
            set { searchQueryVariable = value; }
        }

        public static string InternetURLProperties
        {
            get { return internetUrlVariable; }
            set { internetUrlVariable = value; }
        }

        public static string GoogleSearchProperties
        {
            get { return googleSearchVariable; }
            set { googleSearchVariable = value; }
        }

        public static string EmailProperties
        {
            get { return emailVariable; }
            set { emailVariable = value; }
        }

        public static string MediaFileProperties
        {
            get { return mediafileVariable; }
            set { mediafileVariable = value; } 
        }

    }
}
