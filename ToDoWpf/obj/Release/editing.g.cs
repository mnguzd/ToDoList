﻿#pragma checksum "..\..\editing.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FBDA18CEC7F4D4B536ADEA63D127ED102FC297518DB561B9907EFF629EF9B91C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using ToDoWpf;


namespace ToDoWpf {
    
    
    /// <summary>
    /// editing
    /// </summary>
    public partial class editing : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 86 "..\..\editing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid TopBar;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\editing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label DateLabel;
        
        #line default
        #line hidden
        
        
        #line 133 "..\..\editing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextInput;
        
        #line default
        #line hidden
        
        
        #line 150 "..\..\editing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Delete;
        
        #line default
        #line hidden
        
        
        #line 177 "..\..\editing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Updatetime;
        
        #line default
        #line hidden
        
        
        #line 192 "..\..\editing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DoneLabel;
        
        #line default
        #line hidden
        
        
        #line 194 "..\..\editing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Run DoneText;
        
        #line default
        #line hidden
        
        
        #line 195 "..\..\editing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Run NotDoneText;
        
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
            System.Uri resourceLocater = new System.Uri("/ToDoWpf;component/editing.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\editing.xaml"
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
            
            #line 11 "..\..\editing.xaml"
            ((ToDoWpf.editing)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.Window_KeyDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TopBar = ((System.Windows.Controls.Grid)(target));
            
            #line 86 "..\..\editing.xaml"
            this.TopBar.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.TopBar_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.DateLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            
            #line 120 "..\..\editing.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.TextInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 149 "..\..\editing.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.DeleteTask_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Delete = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            
            #line 176 "..\..\editing.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.UpdateTime_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Updatetime = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            this.DoneLabel = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 13:
            this.DoneText = ((System.Windows.Documents.Run)(target));
            
            #line 195 "..\..\editing.xaml"
            this.DoneText.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.DoneText_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 14:
            this.NotDoneText = ((System.Windows.Documents.Run)(target));
            
            #line 196 "..\..\editing.xaml"
            this.NotDoneText.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.NotDoneText_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 2:
            
            #line 14 "..\..\editing.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ExitBar_MouseLeftButtonDown);
            
            #line default
            #line hidden
            break;
            case 3:
            
            #line 43 "..\..\editing.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.EditButton_MouseLeftButtonDown);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

