﻿#pragma checksum "..\..\BookInformation.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BCF9FD557E945B200642DFE116DE7F31CDB787654B00E652D94A548387FCEA1F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BetaBookStoreApp;
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


namespace BetaBookStoreApp {
    
    
    /// <summary>
    /// BookInformation
    /// </summary>
    public partial class BookInformation : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\BookInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BSeachEM;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\BookInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BDeleteEm;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\BookInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BEditEm;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\BookInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BAddEm;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\BookInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAddress;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\BookInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCusName;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\BookInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEmail;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\BookInformation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtIdCusID;
        
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
            System.Uri resourceLocater = new System.Uri("/BetaBookStoreApp;component/bookinformation.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\BookInformation.xaml"
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
            this.BSeachEM = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\BookInformation.xaml"
            this.BSeachEM.Click += new System.Windows.RoutedEventHandler(this.BShowAllEM_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BDeleteEm = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\BookInformation.xaml"
            this.BDeleteEm.Click += new System.Windows.RoutedEventHandler(this.BDeleteEm_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BEditEm = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\BookInformation.xaml"
            this.BEditEm.Click += new System.Windows.RoutedEventHandler(this.BEditEm_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BAddEm = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\BookInformation.xaml"
            this.BAddEm.Click += new System.Windows.RoutedEventHandler(this.BAddEm_click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtAddress = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtCusName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtEmail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txtIdCusID = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

