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

namespace Controlador.Facturacion {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="facturacionSoap", Namespace="localhost")]
    public partial class facturacion : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback FacturacionOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public facturacion() {
            this.Url = global::Controlador.Properties.Settings.Default.Controlador_facturacion_facturacion;
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
        public event FacturacionCompletedEventHandler FacturacionCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("localhost/Facturacion", RequestNamespace="localhost", ResponseNamespace="localhost", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] Facturacion(
                    string codigo_dealer, 
                    string codigo_sucursal, 
                    string tipo_factura, 
                    string fecha_factura, 
                    string numero_factura, 
                    string referencia, 
                    string nombre_usuario, 
                    string modelo_vehiculo, 
                    string num_stock, 
                    string version_vehiculo, 
                    string color_vehiculo, 
                    string stock_asig, 
                    string nombre_cliente, 
                    string rut_cliente, 
                    string tel_cliente, 
                    string nom_usua_final, 
                    string nom2_usua_final, 
                    string apep_usua_final, 
                    string apem_usua_final, 
                    string rut_usua_final, 
                    string mail_usua_final, 
                    string nom_vendedor, 
                    string rut_vendedor, 
                    string accesorios, 
                    string monto_factura, 
                    string moneda, 
                    string mar_vehi_retoma, 
                    string mod_vehi_retoma, 
                    string ano_vehi_retoma, 
                    string inst_credito, 
                    string tipo_credito, 
                    string inst_seguro, 
                    string usuario, 
                    string password) {
            object[] results = this.Invoke("Facturacion", new object[] {
                        codigo_dealer,
                        codigo_sucursal,
                        tipo_factura,
                        fecha_factura,
                        numero_factura,
                        referencia,
                        nombre_usuario,
                        modelo_vehiculo,
                        num_stock,
                        version_vehiculo,
                        color_vehiculo,
                        stock_asig,
                        nombre_cliente,
                        rut_cliente,
                        tel_cliente,
                        nom_usua_final,
                        nom2_usua_final,
                        apep_usua_final,
                        apem_usua_final,
                        rut_usua_final,
                        mail_usua_final,
                        nom_vendedor,
                        rut_vendedor,
                        accesorios,
                        monto_factura,
                        moneda,
                        mar_vehi_retoma,
                        mod_vehi_retoma,
                        ano_vehi_retoma,
                        inst_credito,
                        tipo_credito,
                        inst_seguro,
                        usuario,
                        password});
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void FacturacionAsync(
                    string codigo_dealer, 
                    string codigo_sucursal, 
                    string tipo_factura, 
                    string fecha_factura, 
                    string numero_factura, 
                    string referencia, 
                    string nombre_usuario, 
                    string modelo_vehiculo, 
                    string num_stock, 
                    string version_vehiculo, 
                    string color_vehiculo, 
                    string stock_asig, 
                    string nombre_cliente, 
                    string rut_cliente, 
                    string tel_cliente, 
                    string nom_usua_final, 
                    string nom2_usua_final, 
                    string apep_usua_final, 
                    string apem_usua_final, 
                    string rut_usua_final, 
                    string mail_usua_final, 
                    string nom_vendedor, 
                    string rut_vendedor, 
                    string accesorios, 
                    string monto_factura, 
                    string moneda, 
                    string mar_vehi_retoma, 
                    string mod_vehi_retoma, 
                    string ano_vehi_retoma, 
                    string inst_credito, 
                    string tipo_credito, 
                    string inst_seguro, 
                    string usuario, 
                    string password) {
            this.FacturacionAsync(codigo_dealer, codigo_sucursal, tipo_factura, fecha_factura, numero_factura, referencia, nombre_usuario, modelo_vehiculo, num_stock, version_vehiculo, color_vehiculo, stock_asig, nombre_cliente, rut_cliente, tel_cliente, nom_usua_final, nom2_usua_final, apep_usua_final, apem_usua_final, rut_usua_final, mail_usua_final, nom_vendedor, rut_vendedor, accesorios, monto_factura, moneda, mar_vehi_retoma, mod_vehi_retoma, ano_vehi_retoma, inst_credito, tipo_credito, inst_seguro, usuario, password, null);
        }
        
        /// <remarks/>
        public void FacturacionAsync(
                    string codigo_dealer, 
                    string codigo_sucursal, 
                    string tipo_factura, 
                    string fecha_factura, 
                    string numero_factura, 
                    string referencia, 
                    string nombre_usuario, 
                    string modelo_vehiculo, 
                    string num_stock, 
                    string version_vehiculo, 
                    string color_vehiculo, 
                    string stock_asig, 
                    string nombre_cliente, 
                    string rut_cliente, 
                    string tel_cliente, 
                    string nom_usua_final, 
                    string nom2_usua_final, 
                    string apep_usua_final, 
                    string apem_usua_final, 
                    string rut_usua_final, 
                    string mail_usua_final, 
                    string nom_vendedor, 
                    string rut_vendedor, 
                    string accesorios, 
                    string monto_factura, 
                    string moneda, 
                    string mar_vehi_retoma, 
                    string mod_vehi_retoma, 
                    string ano_vehi_retoma, 
                    string inst_credito, 
                    string tipo_credito, 
                    string inst_seguro, 
                    string usuario, 
                    string password, 
                    object userState) {
            if ((this.FacturacionOperationCompleted == null)) {
                this.FacturacionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnFacturacionOperationCompleted);
            }
            this.InvokeAsync("Facturacion", new object[] {
                        codigo_dealer,
                        codigo_sucursal,
                        tipo_factura,
                        fecha_factura,
                        numero_factura,
                        referencia,
                        nombre_usuario,
                        modelo_vehiculo,
                        num_stock,
                        version_vehiculo,
                        color_vehiculo,
                        stock_asig,
                        nombre_cliente,
                        rut_cliente,
                        tel_cliente,
                        nom_usua_final,
                        nom2_usua_final,
                        apep_usua_final,
                        apem_usua_final,
                        rut_usua_final,
                        mail_usua_final,
                        nom_vendedor,
                        rut_vendedor,
                        accesorios,
                        monto_factura,
                        moneda,
                        mar_vehi_retoma,
                        mod_vehi_retoma,
                        ano_vehi_retoma,
                        inst_credito,
                        tipo_credito,
                        inst_seguro,
                        usuario,
                        password}, this.FacturacionOperationCompleted, userState);
        }
        
        private void OnFacturacionOperationCompleted(object arg) {
            if ((this.FacturacionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.FacturacionCompleted(this, new FacturacionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public delegate void FacturacionCompletedEventHandler(object sender, FacturacionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1099.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FacturacionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal FacturacionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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