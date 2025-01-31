﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace GETNearestGUI.GeoService {
    using System.Diagnostics;
    using System;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ArchitecturalFirmsWebServiceSoap", Namespace="http://tempuri.org/")]
    public partial class ArchitecturalFirmsWebService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetNearestArchitecturalFirmOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ArchitecturalFirmsWebService() {
            this.Url = global::GETNearestGUI.Properties.Settings.Default.GETNearestGUI_GeoService_ArchitecturalFirmsWebService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetNearestArchitecturalFirmCompletedEventHandler GetNearestArchitecturalFirmCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetNearestArchitecturalFirm", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public architectural_firms GetNearestArchitecturalFirm(double x, double y) {
            object[] results = this.Invoke("GetNearestArchitecturalFirm", new object[] {
                        x,
                        y});
            return ((architectural_firms)(results[0]));
        }
        
        /// <remarks/>
        public void GetNearestArchitecturalFirmAsync(double x, double y) {
            this.GetNearestArchitecturalFirmAsync(x, y, null);
        }
        
        /// <remarks/>
        public void GetNearestArchitecturalFirmAsync(double x, double y, object userState) {
            if ((this.GetNearestArchitecturalFirmOperationCompleted == null)) {
                this.GetNearestArchitecturalFirmOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetNearestArchitecturalFirmOperationCompleted);
            }
            this.InvokeAsync("GetNearestArchitecturalFirm", new object[] {
                        x,
                        y}, this.GetNearestArchitecturalFirmOperationCompleted, userState);
        }
        
        private void OnGetNearestArchitecturalFirmOperationCompleted(object arg) {
            if ((this.GetNearestArchitecturalFirmCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetNearestArchitecturalFirmCompleted(this, new GetNearestArchitecturalFirmCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9037.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class architectural_firms {
        
        private int idField;
        
        private double xField;
        
        private double yField;
        
        private string nameField;
        
        private string founderField;
        
        private string countryField;
        
        private string[] projectsField;
        
        private string contactInfoField;
        
        /// <remarks/>
        public int ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public double X {
            get {
                return this.xField;
            }
            set {
                this.xField = value;
            }
        }
        
        /// <remarks/>
        public double Y {
            get {
                return this.yField;
            }
            set {
                this.yField = value;
            }
        }
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string Founder {
            get {
                return this.founderField;
            }
            set {
                this.founderField = value;
            }
        }
        
        /// <remarks/>
        public string Country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
            }
        }
        
        /// <remarks/>
        public string[] Projects {
            get {
                return this.projectsField;
            }
            set {
                this.projectsField = value;
            }
        }
        
        /// <remarks/>
        public string ContactInfo {
            get {
                return this.contactInfoField;
            }
            set {
                this.contactInfoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    public delegate void GetNearestArchitecturalFirmCompletedEventHandler(object sender, GetNearestArchitecturalFirmCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetNearestArchitecturalFirmCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetNearestArchitecturalFirmCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public architectural_firms Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((architectural_firms)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591