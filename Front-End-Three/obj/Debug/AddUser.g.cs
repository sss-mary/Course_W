#pragma checksum "..\..\AddUser.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C153CAAF1E1371259EC3DC7253603E020F52CC4C4DCDFF5C224C84380AC2E742"
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
    /// AddUser
    /// </summary>
    public partial class AddUser : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox loginInputBox;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox passwordInputBox;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox passwordInputBoxRepeat;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddPhoto;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\AddUser.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Front-End-Three;component/adduser.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddUser.xaml"
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
            this.loginInputBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\AddUser.xaml"
            this.loginInputBox.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.loginInputBox_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.passwordInputBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 28 "..\..\AddUser.xaml"
            this.passwordInputBox.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.passwordInputBox_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.passwordInputBoxRepeat = ((System.Windows.Controls.TextBox)(target));
            
            #line 29 "..\..\AddUser.xaml"
            this.passwordInputBoxRepeat.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.passwordInputBoxRepeat_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AddPhoto = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\AddUser.xaml"
            this.AddPhoto.Click += new System.Windows.RoutedEventHandler(this.AddPhoto_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 32 "..\..\AddUser.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddUser_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.GoBack = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\AddUser.xaml"
            this.GoBack.Click += new System.Windows.RoutedEventHandler(this.GoBack_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

