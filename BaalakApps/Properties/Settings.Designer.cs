﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BaalakApps.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.13.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("White")]
        public global::System.Drawing.Color ReminderBackColor {
            get {
                return ((global::System.Drawing.Color)(this["ReminderBackColor"]));
            }
            set {
                this["ReminderBackColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("60, 120, 160")]
        public global::System.Drawing.Color ReminderForeColor {
            get {
                return ((global::System.Drawing.Color)(this["ReminderForeColor"]));
            }
            set {
                this["ReminderForeColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("60, 120, 160")]
        public global::System.Drawing.Color ReminderForeColorPdf {
            get {
                return ((global::System.Drawing.Color)(this["ReminderForeColorPdf"]));
            }
            set {
                this["ReminderForeColorPdf"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsd=\"http://www.w3." +
            "org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" />")]
        public global::System.Collections.Specialized.StringCollection MsjOpc {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["MsjOpc"]));
            }
            set {
                this["MsjOpc"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("White")]
        public global::System.Drawing.Color ReportBackColor {
            get {
                return ((global::System.Drawing.Color)(this["ReportBackColor"]));
            }
            set {
                this["ReportBackColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("60, 120, 160")]
        public global::System.Drawing.Color ReportForeColor {
            get {
                return ((global::System.Drawing.Color)(this["ReportForeColor"]));
            }
            set {
                this["ReportForeColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("60, 120, 160")]
        public global::System.Drawing.Color ReportForeColorPdf {
            get {
                return ((global::System.Drawing.Color)(this["ReportForeColorPdf"]));
            }
            set {
                this["ReportForeColorPdf"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsd=\"http://www.w3." +
            "org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">\r\n  <s" +
            "tring>NUEVA WALMART DE MEXICO</string>\r\n</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection Proveedores {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["Proveedores"]));
            }
            set {
                this["Proveedores"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsd=\"http://www.w3." +
            "org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">\r\n  <s" +
            "tring>ENVIOS DE PAQUETERIA</string>\r\n</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection Conceptos {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["Conceptos"]));
            }
            set {
                this["Conceptos"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Animalia")]
        public string Center {
            get {
                return ((string)(this["Center"]));
            }
            set {
                this["Center"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("9212650547")]
        public string CenterId {
            get {
                return ((string)(this["CenterId"]));
            }
            set {
                this["CenterId"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://animalia.veterinariabaalak.com/")]
        public string Url {
            get {
                return ((string)(this["Url"]));
            }
            set {
                this["Url"] = value;
            }
        }
    }
}
