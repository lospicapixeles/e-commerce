﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tienda.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.TransaccionSoap")]
    public interface TransaccionSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento HelloWorldResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        Tienda.ServiceReference1.HelloWorldResponse HelloWorld(Tienda.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<Tienda.ServiceReference1.HelloWorldResponse> HelloWorldAsync(Tienda.ServiceReference1.HelloWorldRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento nro del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PagoService", ReplyAction="*")]
        Tienda.ServiceReference1.PagoServiceResponse PagoService(Tienda.ServiceReference1.PagoServiceRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PagoService", ReplyAction="*")]
        System.Threading.Tasks.Task<Tienda.ServiceReference1.PagoServiceResponse> PagoServiceAsync(Tienda.ServiceReference1.PagoServiceRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento nro del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PagoSeguro", ReplyAction="*")]
        Tienda.ServiceReference1.PagoSeguroResponse PagoSeguro(Tienda.ServiceReference1.PagoSeguroRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PagoSeguro", ReplyAction="*")]
        System.Threading.Tasks.Task<Tienda.ServiceReference1.PagoSeguroResponse> PagoSeguroAsync(Tienda.ServiceReference1.PagoSeguroRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public Tienda.ServiceReference1.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(Tienda.ServiceReference1.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public Tienda.ServiceReference1.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(Tienda.ServiceReference1.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PagoServiceRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PagoService", Namespace="http://tempuri.org/", Order=0)]
        public Tienda.ServiceReference1.PagoServiceRequestBody Body;
        
        public PagoServiceRequest() {
        }
        
        public PagoServiceRequest(Tienda.ServiceReference1.PagoServiceRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class PagoServiceRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string nro;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string fecha;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string ccv;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public decimal monto;
        
        public PagoServiceRequestBody() {
        }
        
        public PagoServiceRequestBody(string nro, string fecha, string ccv, decimal monto) {
            this.nro = nro;
            this.fecha = fecha;
            this.ccv = ccv;
            this.monto = monto;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PagoServiceResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PagoServiceResponse", Namespace="http://tempuri.org/", Order=0)]
        public Tienda.ServiceReference1.PagoServiceResponseBody Body;
        
        public PagoServiceResponse() {
        }
        
        public PagoServiceResponse(Tienda.ServiceReference1.PagoServiceResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class PagoServiceResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string PagoServiceResult;
        
        public PagoServiceResponseBody() {
        }
        
        public PagoServiceResponseBody(string PagoServiceResult) {
            this.PagoServiceResult = PagoServiceResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PagoSeguroRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PagoSeguro", Namespace="http://tempuri.org/", Order=0)]
        public Tienda.ServiceReference1.PagoSeguroRequestBody Body;
        
        public PagoSeguroRequest() {
        }
        
        public PagoSeguroRequest(Tienda.ServiceReference1.PagoSeguroRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class PagoSeguroRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string nro;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string fecha;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string ccv;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public decimal monto;
        
        public PagoSeguroRequestBody() {
        }
        
        public PagoSeguroRequestBody(string nro, string fecha, string ccv, decimal monto) {
            this.nro = nro;
            this.fecha = fecha;
            this.ccv = ccv;
            this.monto = monto;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PagoSeguroResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PagoSeguroResponse", Namespace="http://tempuri.org/", Order=0)]
        public Tienda.ServiceReference1.PagoSeguroResponseBody Body;
        
        public PagoSeguroResponse() {
        }
        
        public PagoSeguroResponse(Tienda.ServiceReference1.PagoSeguroResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class PagoSeguroResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string PagoSeguroResult;
        
        public PagoSeguroResponseBody() {
        }
        
        public PagoSeguroResponseBody(string PagoSeguroResult) {
            this.PagoSeguroResult = PagoSeguroResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface TransaccionSoapChannel : Tienda.ServiceReference1.TransaccionSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TransaccionSoapClient : System.ServiceModel.ClientBase<Tienda.ServiceReference1.TransaccionSoap>, Tienda.ServiceReference1.TransaccionSoap {
        
        public TransaccionSoapClient() {
        }
        
        public TransaccionSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TransaccionSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TransaccionSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TransaccionSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Tienda.ServiceReference1.HelloWorldResponse Tienda.ServiceReference1.TransaccionSoap.HelloWorld(Tienda.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            Tienda.ServiceReference1.HelloWorldRequest inValue = new Tienda.ServiceReference1.HelloWorldRequest();
            inValue.Body = new Tienda.ServiceReference1.HelloWorldRequestBody();
            Tienda.ServiceReference1.HelloWorldResponse retVal = ((Tienda.ServiceReference1.TransaccionSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Tienda.ServiceReference1.HelloWorldResponse> Tienda.ServiceReference1.TransaccionSoap.HelloWorldAsync(Tienda.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<Tienda.ServiceReference1.HelloWorldResponse> HelloWorldAsync() {
            Tienda.ServiceReference1.HelloWorldRequest inValue = new Tienda.ServiceReference1.HelloWorldRequest();
            inValue.Body = new Tienda.ServiceReference1.HelloWorldRequestBody();
            return ((Tienda.ServiceReference1.TransaccionSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Tienda.ServiceReference1.PagoServiceResponse Tienda.ServiceReference1.TransaccionSoap.PagoService(Tienda.ServiceReference1.PagoServiceRequest request) {
            return base.Channel.PagoService(request);
        }
        
        public string PagoService(string nro, string fecha, string ccv, decimal monto) {
            Tienda.ServiceReference1.PagoServiceRequest inValue = new Tienda.ServiceReference1.PagoServiceRequest();
            inValue.Body = new Tienda.ServiceReference1.PagoServiceRequestBody();
            inValue.Body.nro = nro;
            inValue.Body.fecha = fecha;
            inValue.Body.ccv = ccv;
            inValue.Body.monto = monto;
            Tienda.ServiceReference1.PagoServiceResponse retVal = ((Tienda.ServiceReference1.TransaccionSoap)(this)).PagoService(inValue);
            return retVal.Body.PagoServiceResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Tienda.ServiceReference1.PagoServiceResponse> Tienda.ServiceReference1.TransaccionSoap.PagoServiceAsync(Tienda.ServiceReference1.PagoServiceRequest request) {
            return base.Channel.PagoServiceAsync(request);
        }
        
        public System.Threading.Tasks.Task<Tienda.ServiceReference1.PagoServiceResponse> PagoServiceAsync(string nro, string fecha, string ccv, decimal monto) {
            Tienda.ServiceReference1.PagoServiceRequest inValue = new Tienda.ServiceReference1.PagoServiceRequest();
            inValue.Body = new Tienda.ServiceReference1.PagoServiceRequestBody();
            inValue.Body.nro = nro;
            inValue.Body.fecha = fecha;
            inValue.Body.ccv = ccv;
            inValue.Body.monto = monto;
            return ((Tienda.ServiceReference1.TransaccionSoap)(this)).PagoServiceAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Tienda.ServiceReference1.PagoSeguroResponse Tienda.ServiceReference1.TransaccionSoap.PagoSeguro(Tienda.ServiceReference1.PagoSeguroRequest request) {
            return base.Channel.PagoSeguro(request);
        }
        
        public string PagoSeguro(string nro, string fecha, string ccv, decimal monto) {
            Tienda.ServiceReference1.PagoSeguroRequest inValue = new Tienda.ServiceReference1.PagoSeguroRequest();
            inValue.Body = new Tienda.ServiceReference1.PagoSeguroRequestBody();
            inValue.Body.nro = nro;
            inValue.Body.fecha = fecha;
            inValue.Body.ccv = ccv;
            inValue.Body.monto = monto;
            Tienda.ServiceReference1.PagoSeguroResponse retVal = ((Tienda.ServiceReference1.TransaccionSoap)(this)).PagoSeguro(inValue);
            return retVal.Body.PagoSeguroResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Tienda.ServiceReference1.PagoSeguroResponse> Tienda.ServiceReference1.TransaccionSoap.PagoSeguroAsync(Tienda.ServiceReference1.PagoSeguroRequest request) {
            return base.Channel.PagoSeguroAsync(request);
        }
        
        public System.Threading.Tasks.Task<Tienda.ServiceReference1.PagoSeguroResponse> PagoSeguroAsync(string nro, string fecha, string ccv, decimal monto) {
            Tienda.ServiceReference1.PagoSeguroRequest inValue = new Tienda.ServiceReference1.PagoSeguroRequest();
            inValue.Body = new Tienda.ServiceReference1.PagoSeguroRequestBody();
            inValue.Body.nro = nro;
            inValue.Body.fecha = fecha;
            inValue.Body.ccv = ccv;
            inValue.Body.monto = monto;
            return ((Tienda.ServiceReference1.TransaccionSoap)(this)).PagoSeguroAsync(inValue);
        }
    }
}
