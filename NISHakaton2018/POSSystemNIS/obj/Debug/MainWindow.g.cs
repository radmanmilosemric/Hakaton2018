﻿#pragma checksum "..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9A04C08EE20AE6D7E22D29151FFF523F1DFFD2EA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using NisHakaton2018.DataModels;
using POSSystemNIS;
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


namespace POSSystemNIS {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 307 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbArtikliNaStanju;
        
        #line default
        #line hidden
        
        
        #line 353 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtCena;
        
        #line default
        #line hidden
        
        
        #line 357 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtUnos;
        
        #line default
        #line hidden
        
        
        #line 439 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgTransakcija;
        
        #line default
        #line hidden
        
        
        #line 494 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbVrstaPumpe;
        
        #line default
        #line hidden
        
        
        #line 537 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbDobaDana;
        
        #line default
        #line hidden
        
        
        #line 579 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkVikend;
        
        #line default
        #line hidden
        
        
        #line 582 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtLoyality;
        
        #line default
        #line hidden
        
        
        #line 584 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSet;
        
        #line default
        #line hidden
        
        
        #line 587 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgPredlozeniArtikli;
        
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
            System.Uri resourceLocater = new System.Uri("/POSSystemNIS;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.cbArtikliNaStanju = ((System.Windows.Controls.ComboBox)(target));
            
            #line 307 "..\..\MainWindow.xaml"
            this.cbArtikliNaStanju.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbArtikliNaStanju_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 307 "..\..\MainWindow.xaml"
            this.cbArtikliNaStanju.KeyDown += new System.Windows.Input.KeyEventHandler(this.cbArtikliNaStanju_KeyDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtCena = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.txtUnos = ((System.Windows.Controls.TextBox)(target));
            
            #line 357 "..\..\MainWindow.xaml"
            this.txtUnos.KeyDown += new System.Windows.Input.KeyEventHandler(this.txtUnos_KeyDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.dgTransakcija = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.cbVrstaPumpe = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.cbDobaDana = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.chkVikend = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 8:
            this.txtLoyality = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.btnSet = ((System.Windows.Controls.Button)(target));
            
            #line 584 "..\..\MainWindow.xaml"
            this.btnSet.Click += new System.Windows.RoutedEventHandler(this.btnSet_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.dgPredlozeniArtikli = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

