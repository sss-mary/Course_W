#pragma checksum "..\..\DeleteUser.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C6421044CDC2BDF939D533F94B2535A53B89C43EEFC7635C56B424F6697627E7"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Front_End_Three;
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


namespace Front_End_Three {
    
    
    /// <summary>
    /// DeleteUser
    /// </summary>
    public partial class DeleteUser : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\DeleteUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu MainMenuFind;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\DeleteUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem TopMenuItem;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\DeleteUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem FindByLogin;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\DeleteUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ShowAll;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\DeleteUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image UserImage;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\DeleteUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock UserLogin;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\DeleteUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock UserStatus;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\DeleteUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock UserLastOnline;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\DeleteUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LeftArrow;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\DeleteUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RightArrow;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\DeleteUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DataInput;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\DeleteUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GoBack;
        
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
            System.Uri resourceLocater = new System.Uri("/Front-End-Three;component/deleteuser.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DeleteUser.xaml"
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
            this.MainMenuFind = ((System.Windows.Controls.Menu)(target));
            return;
            case 2:
            this.TopMenuItem = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 3:
            this.FindByLogin = ((System.Windows.Controls.MenuItem)(target));
            
            #line 36 "..\..\DeleteUser.xaml"
            this.FindByLogin.Click += new System.Windows.RoutedEventHandler(this.FindByLogin_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ShowAll = ((System.Windows.Controls.MenuItem)(target));
            
            #line 39 "..\..\DeleteUser.xaml"
            this.ShowAll.Click += new System.Windows.RoutedEventHandler(this.ShowAll_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 44 "..\..\DeleteUser.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.FindUser_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.UserImage = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.UserLogin = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.UserStatus = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.UserLastOnline = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.LeftArrow = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\DeleteUser.xaml"
            this.LeftArrow.Click += new System.Windows.RoutedEventHandler(this.LeftArrow_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.RightArrow = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\DeleteUser.xaml"
            this.RightArrow.Click += new System.Windows.RoutedEventHandler(this.RightArrow_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.DataInput = ((System.Windows.Controls.TextBox)(target));
            
            #line 85 "..\..\DeleteUser.xaml"
            this.DataInput.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.DataInput_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 86 "..\..\DeleteUser.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.FindUser_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.GoBack = ((System.Windows.Controls.Button)(target));
            
            #line 87 "..\..\DeleteUser.xaml"
            this.GoBack.Click += new System.Windows.RoutedEventHandler(this.GoBack_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

