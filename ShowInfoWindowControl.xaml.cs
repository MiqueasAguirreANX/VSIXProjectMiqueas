using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;
using System;
using System.IO;
using System.Net;

namespace VSIXProjectMiqueas
{
    /// <summary>
    /// Interaction logic for ShowInfoWindowControl.
    /// </summary>
    public partial class ShowInfoWindowControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShowInfoWindowControl"/> class.
        /// </summary>
        public ShowInfoWindowControl()
        {
            this.InitializeComponent();
            string result = GettingData();
            showResponseText.Text = result;
        }


        public string GettingData()
        {
            string sURL;
            sURL = "http://localhost:8000/api/get-report/?id=66";
            
            try
            {
                var request = WebRequest.Create(sURL);
                request.Method = "GET";
                var webResponse = request.GetResponse();
                var webStream = webResponse.GetResponseStream();

                var reader = new StreamReader(webStream);
                var data = reader.ReadToEnd();
                return data;
            }
            catch (Exception) // Invalid JSON
            {
                return "Error in getting the data";
            }
        }
    }
}