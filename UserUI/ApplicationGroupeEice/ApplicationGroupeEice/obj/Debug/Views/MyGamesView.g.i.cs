﻿#pragma checksum "..\..\..\Views\MyGamesView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E3C2B0ABB43F2DE649D3B19FB1631F515CC5073BDA9CE272B339D2D022FB2DE6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using ApplicationGroupeEice.Views;
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


namespace ApplicationGroupeEice.Views {
    
    
    /// <summary>
    /// MyGamesView
    /// </summary>
    public partial class MyGamesView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\Views\MyGamesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox UserGames;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Views\MyGamesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LinkButton;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\Views\MyGamesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SelectedGame_GameName;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\Views\MyGamesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SelectedGame_GameDescription;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\Views\MyGamesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl SelectedGame_GameGenres;
        
        #line default
        #line hidden
        
        
        #line 140 "..\..\..\Views\MyGamesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl SelectedGame_GameDevelopers;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\..\Views\MyGamesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SelectedGame_GameReleaseDate;
        
        #line default
        #line hidden
        
        
        #line 165 "..\..\..\Views\MyGamesView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView SelectedGame_GameAchievements;
        
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
            System.Uri resourceLocater = new System.Uri("/ApplicationGroupeEice;component/views/mygamesview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\MyGamesView.xaml"
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
            this.UserGames = ((System.Windows.Controls.ListBox)(target));
            return;
            case 2:
            this.LinkButton = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.SelectedGame_GameName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.SelectedGame_GameDescription = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.SelectedGame_GameGenres = ((System.Windows.Controls.ItemsControl)(target));
            return;
            case 6:
            this.SelectedGame_GameDevelopers = ((System.Windows.Controls.ItemsControl)(target));
            return;
            case 7:
            this.SelectedGame_GameReleaseDate = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.SelectedGame_GameAchievements = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

