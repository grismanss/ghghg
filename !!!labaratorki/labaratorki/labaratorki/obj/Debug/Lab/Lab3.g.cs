﻿#pragma checksum "..\..\..\Lab\Lab3.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "20A67FCBF1527018ECD5FFE39680307E4878208BE842C3B84F628E040DA8C2DD"
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
using labaratorki.Lab;


namespace labaratorki.Lab {
    
    
    /// <summary>
    /// Lab3
    /// </summary>
    public partial class Lab3 : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\Lab\Lab3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBox_X0;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Lab\Lab3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBox_xk;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Lab\Lab3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBox_dx;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Lab\Lab3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBox_B;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Lab\Lab3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox vuvod;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Lab\Lab3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Vivod;
        
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
            System.Uri resourceLocater = new System.Uri("/labaratorki;component/lab/lab3.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Lab\Lab3.xaml"
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
            this.TextBox_X0 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TextBox_xk = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TextBox_dx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TextBox_B = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.vuvod = ((System.Windows.Controls.TextBox)(target));
            
            #line 47 "..\..\..\Lab\Lab3.xaml"
            this.vuvod.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.vuvod_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Vivod = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\Lab\Lab3.xaml"
            this.Vivod.Click += new System.Windows.RoutedEventHandler(this.Vivod_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

