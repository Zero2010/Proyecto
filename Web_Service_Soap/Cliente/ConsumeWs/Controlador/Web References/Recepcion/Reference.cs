﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
// 
#pragma warning disable 1591

namespace Controlador.Recepcion {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1099.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="recepcionSoap", Namespace="localhost")]
    public partial class recepcion : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback RecepcionOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public recepcion() {
            this.Url = global::Controlador.Properties.Settings.Default.Controlador_recepcion_recepcion;
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
        public event RecepcionCompletedEventHandler RecepcionCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("localhost/Recepcion", RequestNamespace="localhost", ResponseNamespace="localhost", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] Recepcion(string codigo_dealer, string codigo_sucursal, string num_recepcion, string nombre_usuario, string nombre_cliente, string rut_cliente, string tel_cliente, string mail_cliente, string modelo_vehiculo, string medio_showroom, string marca_competencia, string modelo_competencia, string usuario, string password) {
            object[] results = this.Invoke("Recepcion", new object[] {
                        codigo_dealer,
                        codigo_sucursal,
                        num_recepcion,
                        nombre_usuario,
                        nombre_cliente,
                        rut_cliente,
                        tel_cliente,
                        mail_cliente,
                        modelo_vehiculo,
                        medio_showroom,
                        marca_competencia,
                        modelo_competencia,
                        usuario,
                        password});
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void RecepcionAsync(string codigo_dealer, string codigo_sucursal, string num_recepcion, string nombre_usuario, string nombre_cliente, string rut_cliente, string tel_cliente, string mail_cliente, string modelo_vehiculo, string medio_showroom, string marca_competencia, string modelo_competencia, string usuario, string password) {
            this.RecepcionAsync(codigo_dealer, codigo_sucursal, num_recepcion, nombre_usuario, nombre_cliente, rut_cliente, tel_cliente, mail_cliente, modelo_vehiculo, medio_showroom, marca_competencia, modelo_competencia, usuario, password, null);
        }
        
        /// <remarks/>
        public void RecepcionAsync(string codigo_dealer, string codigo_sucursal, string num_recepcion, string nombre_usuario, string nombre_cliente, string rut_cliente, string tel_cliente, string mail_cliente, string modelo_vehiculo, string medio_showroom, string marca_competencia, string modelo_competencia, string usuario, string password, object userState) {
            if ((this.RecepcionOperationCompleted == null)) {
                this.RecepcionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRecepcionOperationCompleted);
            }
            this.InvokeAsync("Recepcion", new object[] {
                        codigo_dealer,
                        codigo_sucursal,
                        num_recepcion,
                        nombre_usuario,
                        nombre_cliente,
                        rut_cliente,
                        tel_cliente,
                        mail_cliente,
                        modelo_vehiculo,
                        medio_showroom,
                        marca_competencia,
                        modelo_competencia,
                        usuario,
                        password}, this.RecepcionOperationCompleted, userState);
        }
        
        private void OnRecepcionOperationCompleted(object arg) {
            if ((this.RecepcionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RecepcionCompleted(this, new RecepcionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1099.0")]
    public delegate void RecepcionCompletedEventHandler(object sender, RecepcionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1099.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RecepcionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal RecepcionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591