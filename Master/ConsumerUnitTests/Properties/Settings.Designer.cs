﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18063
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsumerUnitTests.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("..\\..\\..\\..\\AspenSinter\\Flash_Example\\trunk\\Aspen_Plus\\Flash_Example_AP.json")]
        public string sinterConfiguration {
            get {
                return ((string)(this["sinterConfiguration"]));
            }
            set {
                this["sinterConfiguration"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("..\\..\\..\\..\\AspenSinter\\Flash_Example\\trunk\\Aspen_Plus\\Flash_Example.bkp")]
        public string simulationBackup {
            get {
                return ((string)(this["simulationBackup"]));
            }
            set {
                this["simulationBackup"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("..\\..\\..\\..\\AspenSinter\\Flash_Example\\trunk\\Aspen_Plus\\Flash_Example_AP.json")]
        public string jsonConfiguration {
            get {
                return ((string)(this["jsonConfiguration"]));
            }
            set {
                this["jsonConfiguration"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("..\\..\\..\\..\\AspenSinter\\Flash_Example\\trunk\\ACM\\Flash_Example_ACM.json")]
        public string ACMConfiguration {
            get {
                return ((string)(this["ACMConfiguration"]));
            }
            set {
                this["ACMConfiguration"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Flash_Example_ACM.json")]
        public string ACMFilename {
            get {
                return ((string)(this["ACMFilename"]));
            }
            set {
                this["ACMFilename"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Flash_Example_AP.json")]
        public string APFilename {
            get {
                return ((string)(this["APFilename"]));
            }
            set {
                this["APFilename"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("..\\..\\..\\..\\AspenSinter\\Flash_Example\\trunk\\ACM")]
        public string ACMDir {
            get {
                return ((string)(this["ACMDir"]));
            }
            set {
                this["ACMDir"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("..\\..\\..\\..\\AspenSinter\\Flash_Example\\trunk\\Aspen_Plus\\")]
        public string APDir {
            get {
                return ((string)(this["APDir"]));
            }
            set {
                this["APDir"] = value;
            }
        }
    }
}
