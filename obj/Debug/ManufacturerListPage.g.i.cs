﻿#pragma checksum "..\..\ManufacturerListPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9A8EF78398D78E2CBD8067F7234FD84F041FF144"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using AutoService_WS;
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


namespace AutoService_WS {
    
    
    /// <summary>
    /// ManufacturerListPage
    /// </summary>
    public partial class ManufacturerListPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\ManufacturerListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer viewer;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\ManufacturerListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel stackPanel;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\ManufacturerListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textblockCountItems;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\ManufacturerListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboDiscounts;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\ManufacturerListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radioOrderByPrice;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\ManufacturerListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radioOrderByPriceDesc;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\ManufacturerListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton defaultSort;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\ManufacturerListPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonReset;
        
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
            System.Uri resourceLocater = new System.Uri("/AutoService WS;component/manufacturerlistpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ManufacturerListPage.xaml"
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
            this.viewer = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 2:
            this.stackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.textblockCountItems = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.comboDiscounts = ((System.Windows.Controls.ComboBox)(target));
            
            #line 37 "..\..\ManufacturerListPage.xaml"
            this.comboDiscounts.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboDiscounts_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.radioOrderByPrice = ((System.Windows.Controls.RadioButton)(target));
            
            #line 47 "..\..\ManufacturerListPage.xaml"
            this.radioOrderByPrice.Checked += new System.Windows.RoutedEventHandler(this.RadioOrderByPriceDesc_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.radioOrderByPriceDesc = ((System.Windows.Controls.RadioButton)(target));
            
            #line 51 "..\..\ManufacturerListPage.xaml"
            this.radioOrderByPriceDesc.Checked += new System.Windows.RoutedEventHandler(this.RadioOrderByPrice_Checked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.defaultSort = ((System.Windows.Controls.RadioButton)(target));
            
            #line 55 "..\..\ManufacturerListPage.xaml"
            this.defaultSort.Checked += new System.Windows.RoutedEventHandler(this.DefaultSort_Checked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.buttonReset = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\ManufacturerListPage.xaml"
            this.buttonReset.Click += new System.Windows.RoutedEventHandler(this.ButtonReset_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
