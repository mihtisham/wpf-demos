﻿#pragma checksum "..\..\..\Views\DocumentEditorDemo.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A18C2ABBFA9EAB8BE6FE9A572E23959278D5B92D0E8F9FA957967B730FE41028"
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
using Syncfusion.Windows;
using Syncfusion.Windows.Controls.Input;
using Syncfusion.Windows.Controls.Notification;
using Syncfusion.Windows.Controls.RichTextBoxAdv;
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
using syncfusion.documenteditor.wpf;
using syncfusion.richtextboxdemos.wpf;


namespace syncfusion.richtextboxdemos.wpf {
    
    
    /// <summary>
    /// DocumentEditorDemo
    /// </summary>
    public partial class DocumentEditorDemo : Syncfusion.Windows.Tools.Controls.RibbonWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\Views\DocumentEditorDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal syncfusion.richtextboxdemos.wpf.DocumentEditorDemo ribbonWindow;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Views\DocumentEditorDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal syncfusion.documenteditor.wpf.RunAdv currentPageNumberRun;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Views\DocumentEditorDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal syncfusion.documenteditor.wpf.RunAdv pagecountRun;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Views\DocumentEditorDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider rangeslider;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Views\DocumentEditorDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Root;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\Views\DocumentEditorDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.Windows.Controls.RichTextBoxAdv.SfRichTextRibbon richTextRibbon;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Views\DocumentEditorDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.Windows.Controls.RichTextBoxAdv.SfRichTextBoxAdv richTextBoxAdv;
        
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
            System.Uri resourceLocater = new System.Uri("/syncfusion.richtextboxdemos.wpf;component/views/documenteditordemo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\DocumentEditorDemo.xaml"
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
            this.ribbonWindow = ((syncfusion.richtextboxdemos.wpf.DocumentEditorDemo)(target));
            return;
            case 2:
            this.currentPageNumberRun = ((syncfusion.documenteditor.wpf.RunAdv)(target));
            return;
            case 3:
            this.pagecountRun = ((syncfusion.documenteditor.wpf.RunAdv)(target));
            return;
            case 4:
            this.rangeslider = ((System.Windows.Controls.Slider)(target));
            return;
            case 5:
            this.Root = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.richTextRibbon = ((Syncfusion.Windows.Controls.RichTextBoxAdv.SfRichTextRibbon)(target));
            return;
            case 7:
            this.richTextBoxAdv = ((Syncfusion.Windows.Controls.RichTextBoxAdv.SfRichTextBoxAdv)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
