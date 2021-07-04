﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DynamicCalculator.Presentation.CalculatorServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CalculatorServiceReference.ICalculator")]
    public interface ICalculator {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Add", ReplyAction="http://tempuri.org/ICalculator/AddResponse")]
        double Add(double firstValue, double secondValue);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Add", ReplyAction="http://tempuri.org/ICalculator/AddResponse")]
        System.Threading.Tasks.Task<double> AddAsync(double firstValue, double secondValue);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Divide", ReplyAction="http://tempuri.org/ICalculator/DivideResponse")]
        double Divide(double firstValue, double secondValue);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Divide", ReplyAction="http://tempuri.org/ICalculator/DivideResponse")]
        System.Threading.Tasks.Task<double> DivideAsync(double firstValue, double secondValue);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Multiply", ReplyAction="http://tempuri.org/ICalculator/MultiplyResponse")]
        double Multiply(double firstValue, double secondValue);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Multiply", ReplyAction="http://tempuri.org/ICalculator/MultiplyResponse")]
        System.Threading.Tasks.Task<double> MultiplyAsync(double firstValue, double secondValue);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Substract", ReplyAction="http://tempuri.org/ICalculator/SubstractResponse")]
        double Substract(double firstValue, double secondValue);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Substract", ReplyAction="http://tempuri.org/ICalculator/SubstractResponse")]
        System.Threading.Tasks.Task<double> SubstractAsync(double firstValue, double secondValue);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/CalculatAsString", ReplyAction="http://tempuri.org/ICalculator/CalculatAsStringResponse")]
        string CalculatAsString(string data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/CalculatAsString", ReplyAction="http://tempuri.org/ICalculator/CalculatAsStringResponse")]
        System.Threading.Tasks.Task<string> CalculatAsStringAsync(string data);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculatorChannel : DynamicCalculator.Presentation.CalculatorServiceReference.ICalculator, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorClient : System.ServiceModel.ClientBase<DynamicCalculator.Presentation.CalculatorServiceReference.ICalculator>, DynamicCalculator.Presentation.CalculatorServiceReference.ICalculator {
        
        public CalculatorClient() {
        }
        
        public CalculatorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double Add(double firstValue, double secondValue) {
            return base.Channel.Add(firstValue, secondValue);
        }
        
        public System.Threading.Tasks.Task<double> AddAsync(double firstValue, double secondValue) {
            return base.Channel.AddAsync(firstValue, secondValue);
        }
        
        public double Divide(double firstValue, double secondValue) {
            return base.Channel.Divide(firstValue, secondValue);
        }
        
        public System.Threading.Tasks.Task<double> DivideAsync(double firstValue, double secondValue) {
            return base.Channel.DivideAsync(firstValue, secondValue);
        }
        
        public double Multiply(double firstValue, double secondValue) {
            return base.Channel.Multiply(firstValue, secondValue);
        }
        
        public System.Threading.Tasks.Task<double> MultiplyAsync(double firstValue, double secondValue) {
            return base.Channel.MultiplyAsync(firstValue, secondValue);
        }
        
        public double Substract(double firstValue, double secondValue) {
            return base.Channel.Substract(firstValue, secondValue);
        }
        
        public System.Threading.Tasks.Task<double> SubstractAsync(double firstValue, double secondValue) {
            return base.Channel.SubstractAsync(firstValue, secondValue);
        }
        
        public string CalculatAsString(string data) {
            return base.Channel.CalculatAsString(data);
        }
        
        public System.Threading.Tasks.Task<string> CalculatAsStringAsync(string data) {
            return base.Channel.CalculatAsStringAsync(data);
        }
    }
}
