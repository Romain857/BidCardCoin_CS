﻿#pragma checksum "..\..\..\Vue\AjouterCategorieWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7004C102AAC6705C761F2DE584B29852829BB943818F808D69FB5995997F4322"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using ProjetBCC.Vue;
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


namespace ProjetBCC.Vue {
    
    
    /// <summary>
    /// AjouterCategorieWindow
    /// </summary>
    public partial class AjouterCategorieWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Vue\AjouterCategorieWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nomTextBox;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Vue\AjouterCategorieWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button nomCategorieButton;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Vue\AjouterCategorieWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid listeCategories;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Vue\AjouterCategorieWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button supprimerButton;
        
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
            System.Uri resourceLocater = new System.Uri("/ProjetBCC;component/vue/ajoutercategoriewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Vue\AjouterCategorieWindow.xaml"
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
            this.nomTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 12 "..\..\..\Vue\AjouterCategorieWindow.xaml"
            this.nomTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.nomChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.nomCategorieButton = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\Vue\AjouterCategorieWindow.xaml"
            this.nomCategorieButton.Click += new System.Windows.RoutedEventHandler(this.nomCategorieButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.listeCategories = ((System.Windows.Controls.DataGrid)(target));
            
            #line 15 "..\..\..\Vue\AjouterCategorieWindow.xaml"
            this.listeCategories.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listeCategorie_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.supprimerButton = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\Vue\AjouterCategorieWindow.xaml"
            this.supprimerButton.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.supprimerButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

