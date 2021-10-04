using Microsoft.VisualStudio.Shell;
using System;
using System.Runtime.InteropServices;

namespace VSIXProjectMiqueas
{
    /// <summary>
    /// This class implements the tool window exposed by this package and hosts a user control.
    /// </summary>
    /// <remarks>
    /// In Visual Studio tool windows are composed of a frame (implemented by the shell) and a pane,
    /// usually implemented by the package implementer.
    /// <para>
    /// This class derives from the ToolWindowPane class provided from the MPF in order to use its
    /// implementation of the IVsUIElementPane interface.
    /// </para>
    /// </remarks>
    [Guid("0e49907d-c9a4-4d82-93e1-00045e08c6a5")]
    public class ShowInfoWindow : ToolWindowPane
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShowInfoWindow"/> class.
        /// </summary>
        public ShowInfoWindow() : base(null)
        {
            this.Caption = "ShowInfoWindow";

            // This is the user control hosted by the tool window; Note that, even if this class implements IDisposable,
            // we are not calling Dispose on this object. This is because ToolWindowPane calls Dispose on
            // the object returned by the Content property.
            this.Content = new ShowInfoWindowControl();
        }
    }
}
