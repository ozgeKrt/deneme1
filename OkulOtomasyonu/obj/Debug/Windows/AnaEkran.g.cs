﻿#pragma checksum "..\..\..\Windows\AnaEkran.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5D641B235C1804C2C311AB02483C88019D258F78042FA8FE83E8CC9E9739219B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.MahApps;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using OkulOtomasyonu.Windows;
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


namespace OkulOtomasyonu.Windows {
    
    
    /// <summary>
    /// AnaEkran
    /// </summary>
    public partial class AnaEkran : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 98 "..\..\..\Windows\AnaEkran.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ogrencibtn;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\Windows\AnaEkran.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button derslerbtn;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\..\Windows\AnaEkran.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid menuGrid;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\..\Windows\AnaEkran.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton menuButton;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\..\Windows\AnaEkran.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MenuUserControlGrid;
        
        #line default
        #line hidden
        
        
        #line 143 "..\..\..\Windows\AnaEkran.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid UserControlGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/OkulOtomasyonu;component/windows/anaekran.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\AnaEkran.xaml"
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
            
            #line 41 "..\..\..\Windows\AnaEkran.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).PreviewDragOver += new System.Windows.DragEventHandler(this.Rectangle_PreviewDragOver);
            
            #line default
            #line hidden
            
            #line 41 "..\..\..\Windows\AnaEkran.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Rectangle_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 70 "..\..\..\Windows\AnaEkran.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ogrencibtn = ((System.Windows.Controls.Button)(target));
            
            #line 98 "..\..\..\Windows\AnaEkran.xaml"
            this.ogrencibtn.Click += new System.Windows.RoutedEventHandler(this.ogrencibtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 104 "..\..\..\Windows\AnaEkran.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.derslerbtn = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.menuGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            this.menuButton = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 134 "..\..\..\Windows\AnaEkran.xaml"
            this.menuButton.Click += new System.Windows.RoutedEventHandler(this.menuButton_Click);
            
            #line default
            #line hidden
            
            #line 134 "..\..\..\Windows\AnaEkran.xaml"
            this.menuButton.Checked += new System.Windows.RoutedEventHandler(this.menuButton_Checked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.MenuUserControlGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 9:
            this.UserControlGrid = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

