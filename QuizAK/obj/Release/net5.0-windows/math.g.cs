﻿#pragma checksum "..\..\..\math.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4C44D1C6DA49C7CF2BE3DA38167A8A6FE774A994"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using Интелектуальная_викторина;


namespace Интелектуальная_викторина {
    
    
    /// <summary>
    /// math
    /// </summary>
    public partial class math : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\math.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas myCanvas;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\math.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label scoreText;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\math.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label questionOrder;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\math.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtQuestion;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\math.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ans1;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\math.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ans2;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\math.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ans3;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\math.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ans4;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\math.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Quebio;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Интелектуальная викторина;component/math.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\math.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.myCanvas = ((System.Windows.Controls.Canvas)(target));
            return;
            case 2:
            this.scoreText = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.questionOrder = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.txtQuestion = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.ans1 = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\math.xaml"
            this.ans1.Click += new System.Windows.RoutedEventHandler(this.checkAnswer);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ans2 = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\math.xaml"
            this.ans2.Click += new System.Windows.RoutedEventHandler(this.checkAnswer);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ans3 = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\math.xaml"
            this.ans3.Click += new System.Windows.RoutedEventHandler(this.checkAnswer);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ans4 = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\math.xaml"
            this.ans4.Click += new System.Windows.RoutedEventHandler(this.checkAnswer);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Quebio = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            
            #line 36 "..\..\..\math.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

