#pragma checksum "..\..\BindingNaarObjectVoorbeeld2.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FBB82B91FFE1CAEE6A7E9550A9C8786B233010BC75C153C16445A46F552A665D"
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
    /// BindingNaarObjectVoorbeeld2
    /// </summary>
    public partial class BindingNaarObjectVoorbeeld2 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\BindingNaarObjectVoorbeeld2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtOrderID;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\BindingNaarObjectVoorbeeld2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnZoeken;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\BindingNaarObjectVoorbeeld2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid datagridOrderlijnen;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\BindingNaarObjectVoorbeeld2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnVerwijderen;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\BindingNaarObjectVoorbeeld2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtHoeveelheid;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\BindingNaarObjectVoorbeeld2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbProducten;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\BindingNaarObjectVoorbeeld2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnToevoegen;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\BindingNaarObjectVoorbeeld2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAanpassen;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\BindingNaarObjectVoorbeeld2.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Databinding_WPF;component/bindingnaarobjectvoorbeeld2.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\BindingNaarObjectVoorbeeld2.xaml"
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
            
            #line 16 "..\..\BindingNaarObjectVoorbeeld2.xaml"
            ((Databinding_WPF.BindingNaarObjectVoorbeeld2)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtOrderID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.btnZoeken = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\BindingNaarObjectVoorbeeld2.xaml"
            this.btnZoeken.Click += new System.Windows.RoutedEventHandler(this.BtnZoeken_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.datagridOrderlijnen = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.btnVerwijderen = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\BindingNaarObjectVoorbeeld2.xaml"
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
            
            #line 67 "..\..\BindingNaarObjectVoorbeeld2.xaml"
            this.btnToevoegen.Click += new System.Windows.RoutedEventHandler(this.BtnToevoegen_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnAanpassen = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\BindingNaarObjectVoorbeeld2.xaml"
            this.btnAanpassen.Click += new System.Windows.RoutedEventHandler(this.BtnAanpassen_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnAnnuleren = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\BindingNaarObjectVoorbeeld2.xaml"
            this.btnAnnuleren.Click += new System.Windows.RoutedEventHandler(this.BtnAnnuleren_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

