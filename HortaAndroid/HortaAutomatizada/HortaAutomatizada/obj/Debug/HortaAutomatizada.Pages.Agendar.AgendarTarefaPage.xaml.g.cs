//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HortaAutomatizada.Pages {
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    
    
    public partial class AgendarTarefaPage : global::Xamarin.Forms.ContentPage {
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Picker DiaSemana;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.TimePicker DiaTempo;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Entry entryTempBelow;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::HortaAutomatizada.Controls.CustomTimePicker24 TempRegacao;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::HortaAutomatizada.Controls.CustomTimePicker24 TempLuminosidade;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private void InitializeComponent() {
            this.LoadFromXaml(typeof(AgendarTarefaPage));
            DiaSemana = this.FindByName<global::Xamarin.Forms.Picker>("DiaSemana");
            DiaTempo = this.FindByName<global::Xamarin.Forms.TimePicker>("DiaTempo");
            entryTempBelow = this.FindByName<global::Xamarin.Forms.Entry>("entryTempBelow");
            TempRegacao = this.FindByName<global::HortaAutomatizada.Controls.CustomTimePicker24>("TempRegacao");
            TempLuminosidade = this.FindByName<global::HortaAutomatizada.Controls.CustomTimePicker24>("TempLuminosidade");
        }
    }
}
