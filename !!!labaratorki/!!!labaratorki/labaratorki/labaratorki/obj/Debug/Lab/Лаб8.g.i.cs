﻿#pragma checksum "..\..\..\Lab\Лаб8.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5F342F1B610A5A392ED66224FFA54B8D4549C1E174E2CBD60694AB2BFE471FA0"
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
    /// Лаб8
    /// </summary>
    public partial class Лаб8 : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\Lab\Лаб8.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas myCanvas;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Lab\Лаб8.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Polyline mypoly;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Lab\Лаб8.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BT;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Lab\Лаб8.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBx0;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Lab\Лаб8.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBxk;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Lab\Лаб8.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBdx;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Lab\Лаб8.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBb;
        
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
            System.Uri resourceLocater = new System.Uri("/labaratorki;component/lab/%d0%9b%d0%b0%d0%b18.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Lab\Лаб8.xaml"
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
            this.myCanvas = ((System.Windows.Controls.Canvas)(target));
            return;
            case 2:
            this.mypoly = ((System.Windows.Shapes.Polyline)(target));
            return;
            case 3:
            this.BT = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\Lab\Лаб8.xaml"
            this.BT.Click += new System.Windows.RoutedEventHandler(this.BT_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TBx0 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TBxk = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.TBdx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.TBb = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

