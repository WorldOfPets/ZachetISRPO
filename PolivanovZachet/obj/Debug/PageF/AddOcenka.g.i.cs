﻿#pragma checksum "..\..\..\PageF\AddOcenka.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "938B1A435D8AE3B6CB32B4854166D3BE7E4130F9B57CACB7B060F87BA7F3F7CD"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using PolivanovZachet.PageF;
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


namespace PolivanovZachet.PageF {
    
    
    /// <summary>
    /// AddOcenka
    /// </summary>
    public partial class AddOcenka : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\PageF\AddOcenka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBack;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\PageF\AddOcenka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbGroup;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\PageF\AddOcenka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbStudent;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\PageF\AddOcenka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbDescip;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\PageF\AddOcenka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbOcenka;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\PageF\AddOcenka.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddO;
        
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
            System.Uri resourceLocater = new System.Uri("/PolivanovZachet;component/pagef/addocenka.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PageF\AddOcenka.xaml"
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
            this.btnBack = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\PageF\AddOcenka.xaml"
            this.btnBack.Click += new System.Windows.RoutedEventHandler(this.btnBack_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cmbGroup = ((System.Windows.Controls.ComboBox)(target));
            
            #line 38 "..\..\..\PageF\AddOcenka.xaml"
            this.cmbGroup.DropDownClosed += new System.EventHandler(this.cmbGroup_DropDownClosed);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cmbStudent = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.cmbDescip = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.tbOcenka = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btnAddO = ((System.Windows.Controls.Button)(target));
            
            #line 84 "..\..\..\PageF\AddOcenka.xaml"
            this.btnAddO.Click += new System.Windows.RoutedEventHandler(this.btnAddO_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

