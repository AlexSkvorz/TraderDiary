#pragma checksum "..\..\Statistic.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FA948459944F15F7B1CBEA2C2413B442C003C75D122149A8290FB4E1AABAA823"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Windows.Themes;
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
using TraderDiary;


namespace TraderDiary {
    
    
    /// <summary>
    /// Statistic
    /// </summary>
    public partial class Statistic : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\Statistic.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal TraderDiary.Statistic StatisticWindow;
        
        #line default
        #line hidden
        
        
        #line 348 "..\..\Statistic.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxStat;
        
        #line default
        #line hidden
        
        
        #line 359 "..\..\Statistic.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DatePickerStartStat;
        
        #line default
        #line hidden
        
        
        #line 360 "..\..\Statistic.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DatePickerEndStat;
        
        #line default
        #line hidden
        
        
        #line 361 "..\..\Statistic.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveButtonStat;
        
        #line default
        #line hidden
        
        
        #line 362 "..\..\Statistic.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FileNameBox;
        
        #line default
        #line hidden
        
        
        #line 363 "..\..\Statistic.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ChooseToken;
        
        #line default
        #line hidden
        
        
        #line 364 "..\..\Statistic.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ChooseStartPeriod;
        
        #line default
        #line hidden
        
        
        #line 365 "..\..\Statistic.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ChooseEndPeriod;
        
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
            System.Uri resourceLocater = new System.Uri("/TraderDiary;component/statistic.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Statistic.xaml"
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
            this.StatisticWindow = ((TraderDiary.Statistic)(target));
            
            #line 9 "..\..\Statistic.xaml"
            this.StatisticWindow.Loaded += new System.Windows.RoutedEventHandler(this.StatisticWindow_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ComboBoxStat = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.DatePickerStartStat = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.DatePickerEndStat = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.SaveButtonStat = ((System.Windows.Controls.Button)(target));
            
            #line 361 "..\..\Statistic.xaml"
            this.SaveButtonStat.Click += new System.Windows.RoutedEventHandler(this.SaveButtonStat_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.FileNameBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.ChooseToken = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.ChooseStartPeriod = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.ChooseEndPeriod = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

