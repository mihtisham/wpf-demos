﻿#pragma checksum "..\..\..\Document Container\WindowStateRestrictionDemo.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "338C6CA82139D754C095CBA5383E09D0127C68DF06BA01E1CBAE28CF7F338E1E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Syncfusion;
using Syncfusion.UI.Xaml.Charts;
using Syncfusion.UI.Xaml.Controls.DataPager;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.RowFilter;
using Syncfusion.UI.Xaml.TextInputLayout;
using Syncfusion.UI.Xaml.TreeGrid;
using Syncfusion.UI.Xaml.TreeGrid.Filtering;
using Syncfusion.Windows;
using Syncfusion.Windows.Controls.Input;
using Syncfusion.Windows.Controls.Notification;
using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Tools;
using Syncfusion.Windows.Tools.Controls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using syncfusion.demoscommon.wpf;
using syncfusion.layoutdemos.wpf;


namespace syncfusion.layoutdemos.wpf {
    
    
    /// <summary>
    /// WindowStateRestrictionDemo
    /// </summary>
    public partial class WindowStateRestrictionDemo : syncfusion.demoscommon.wpf.DemoControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\Document Container\WindowStateRestrictionDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CanCloseCheckBox;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Document Container\WindowStateRestrictionDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.Windows.Tools.Controls.DocumentContainer DocumentContainer;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\Document Container\WindowStateRestrictionDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.FlowDocumentScrollViewer firstdoc;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\Document Container\WindowStateRestrictionDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.FlowDocumentScrollViewer seconddoc;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\Document Container\WindowStateRestrictionDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.FlowDocumentScrollViewer ThirdDoc;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/syncfusion.layoutdemos.wpf;component/document%20container/windowstaterestriction" +
                    "demo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Document Container\WindowStateRestrictionDemo.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.CanCloseCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 2:
            this.DocumentContainer = ((Syncfusion.Windows.Tools.Controls.DocumentContainer)(target));
            return;
            case 3:
            this.firstdoc = ((System.Windows.Controls.FlowDocumentScrollViewer)(target));
            return;
            case 4:
            this.seconddoc = ((System.Windows.Controls.FlowDocumentScrollViewer)(target));
            return;
            case 5:
            this.ThirdDoc = ((System.Windows.Controls.FlowDocumentScrollViewer)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
