﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inventario.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.Iinv2")]
    public interface Iinv2 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Iinv2/guardar", ReplyAction="http://tempuri.org/Iinv2/guardarResponse")]
        void guardar(int a, string b, int c, int d, string e);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Iinv2/buscar", ReplyAction="http://tempuri.org/Iinv2/buscarResponse")]
        string[] buscar(int cla);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Iinv2/convertir", ReplyAction="http://tempuri.org/Iinv2/convertirResponse")]
        string convertir(string n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Iinv2/toText", ReplyAction="http://tempuri.org/Iinv2/toTextResponse")]
        string toText(double value);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Iinv2Channel : Inventario.ServiceReference1.Iinv2, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Iinv2Client : System.ServiceModel.ClientBase<Inventario.ServiceReference1.Iinv2>, Inventario.ServiceReference1.Iinv2 {
        
        public Iinv2Client() {
        }
        
        public Iinv2Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Iinv2Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Iinv2Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Iinv2Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void guardar(int a, string b, int c, int d, string e) {
            base.Channel.guardar(a, b, c, d, e);
        }
        
        public string[] buscar(int cla) {
            return base.Channel.buscar(cla);
        }
        
        public string convertir(string n) {
            return base.Channel.convertir(n);
        }
        
        public string toText(double value) {
            return base.Channel.toText(value);
        }
    }
}
