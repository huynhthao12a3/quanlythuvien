﻿#pragma checksum "..\..\DangKy.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2F3C001C1870D8CACD89C83CFE6B4509AA570A5F53F08D6C78F0AB86F669299C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HuynhVanThao_141800706;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace HuynhVanThao_141800706 {
    
    
    /// <summary>
    /// DangKy
    /// </summary>
    public partial class DangKy : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\DangKy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMaSV;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\DangKy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtHoTenSV;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\DangKy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtLop;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\DangKy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtGioiTinhSV;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\DangKy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNgaySinhSV;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\DangKy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSdtSV;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\DangKy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtMatKhauSV;
        
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
            System.Uri resourceLocater = new System.Uri("/HuynhVanThao_141800706;component/dangky.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DangKy.xaml"
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
            
            #line 25 "..\..\DangKy.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Thoat_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtMaSV = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtHoTenSV = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtLop = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtGioiTinhSV = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtNgaySinhSV = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtSdtSV = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txtMatKhauSV = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 9:
            
            #line 76 "..\..\DangKy.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DangKy_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

