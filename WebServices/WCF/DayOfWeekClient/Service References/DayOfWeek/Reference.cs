﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DayOfWeekClient.DayOfWeek {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DayOfWeek.IDayOfWeekService")]
    public interface IDayOfWeekService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDayOfWeekService/GetDayOfWeek", ReplyAction="http://tempuri.org/IDayOfWeekService/GetDayOfWeekResponse")]
        string GetDayOfWeek(System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDayOfWeekService/GetDayOfWeek", ReplyAction="http://tempuri.org/IDayOfWeekService/GetDayOfWeekResponse")]
        System.Threading.Tasks.Task<string> GetDayOfWeekAsync(System.DateTime date);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDayOfWeekServiceChannel : DayOfWeekClient.DayOfWeek.IDayOfWeekService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DayOfWeekServiceClient : System.ServiceModel.ClientBase<DayOfWeekClient.DayOfWeek.IDayOfWeekService>, DayOfWeekClient.DayOfWeek.IDayOfWeekService {
        
        public DayOfWeekServiceClient() {
        }
        
        public DayOfWeekServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DayOfWeekServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DayOfWeekServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DayOfWeekServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetDayOfWeek(System.DateTime date) {
            return base.Channel.GetDayOfWeek(date);
        }
        
        public System.Threading.Tasks.Task<string> GetDayOfWeekAsync(System.DateTime date) {
            return base.Channel.GetDayOfWeekAsync(date);
        }
    }
}