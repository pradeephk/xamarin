// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace XamariniOS
{
    [Register ("ListViewController")]
    partial class ListViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView ListView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ListView != null) {
                ListView.Dispose ();
                ListView = null;
            }
        }
    }
}