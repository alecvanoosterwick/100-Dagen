﻿#pragma checksum "..\..\BindingNaarObjectWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DAC1F842656F773618647B960D305AD3550C470B35AB05B07AED1951AC54EB8F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Databinding_WPF;
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


namespace Databinding_WPF {
    
    
    /// <summary>
    /// BindingNaarObjectWindow
    /// </summary>
    public partial class BindingNaarObjectWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\BindingNaarObjectWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtOrderID;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\BindingNaarObjectWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnZoeken;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\BindingNaarObjectWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid datagridOrderlijnen;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\BindingNaarObjectWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnVerwijderen;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\BindingNaarObjectWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtHoeveelheid;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\BindingNaarObjectWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbProducten;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\BindingNaarObjectWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnToevoegen;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\BindingNaarObjectWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAanpassen;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\BindingNaarObjectWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAnnuleren;
        
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
            System.Uri resourceLocater = new System.Uri("/Databinding_WPF;component/bindingnaarobjectwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\BindingNaarObjectWindow.xaml"
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
            
            #line 16 "..\..\BindingNaarObjectWindow.xaml"
            ((Databinding_WPF.BindingNaarObjectWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtOrderID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.btnZoeken = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\BindingNaarObjectWindow.xaml"
            this.btnZoeken.Click += new System.Windows.RoutedEventHandler(this.BtnZoeken_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.datagridOrderlijnen = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.btnVerwijderen = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\BindingNaarObjectWindow.xaml"
            this.btnVerwijderen.Click += new System.Windows.RoutedEventHandler(this.BtnVerwijderen_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtHoeveelheid = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.cmbProducten = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.btnToevoegen = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\BindingNaarObjectWindow.xaml"
            this.btnToevoegen.Click += new System.Windows.RoutedEventHandler(this.BtnToevoegen_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnAanpassen = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\BindingNaarObjectWindow.xaml"
            this.btnAanpassen.Click += new System.Windows.RoutedEventHandler(this.BtnAanpassen_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnAnnuleren = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\BindingNaarObjectWindow.xaml"
            this.btnAnnuleren.Click += new System.Windows.RoutedEventHandler(this.BtnAnnuleren_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
