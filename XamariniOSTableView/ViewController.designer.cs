// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace XamariniOSTableView
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView MyTable { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (MyTable != null) {
                MyTable.Dispose ();
                MyTable = null;
            }
        }
    }
}