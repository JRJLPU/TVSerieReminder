﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfReminder.WpfReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WpfReference.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllSeries", ReplyAction="http://tempuri.org/IService1/GetAllSeriesResponse")]
        System.Collections.Generic.Dictionary<string, int> GetAllSeries();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllSeries", ReplyAction="http://tempuri.org/IService1/GetAllSeriesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, int>> GetAllSeriesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SearchSeries", ReplyAction="http://tempuri.org/IService1/SearchSeriesResponse")]
        SerieDatabase.SerieInfo[] SearchSeries(string title);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SearchSeries", ReplyAction="http://tempuri.org/IService1/SearchSeriesResponse")]
        System.Threading.Tasks.Task<SerieDatabase.SerieInfo[]> SearchSeriesAsync(string title);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Timer", ReplyAction="http://tempuri.org/IService1/TimerResponse")]
        string Timer(string episode, string serie);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Timer", ReplyAction="http://tempuri.org/IService1/TimerResponse")]
        System.Threading.Tasks.Task<string> TimerAsync(string episode, string serie);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WpfReminder.WpfReference.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WpfReminder.WpfReference.IService1>, WpfReminder.WpfReference.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.Dictionary<string, int> GetAllSeries() {
            return base.Channel.GetAllSeries();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, int>> GetAllSeriesAsync() {
            return base.Channel.GetAllSeriesAsync();
        }
        
        public SerieDatabase.SerieInfo[] SearchSeries(string title) {
            return base.Channel.SearchSeries(title);
        }
        
        public System.Threading.Tasks.Task<SerieDatabase.SerieInfo[]> SearchSeriesAsync(string title) {
            return base.Channel.SearchSeriesAsync(title);
        }
        
        public string Timer(string episode, string serie) {
            return base.Channel.Timer(episode, serie);
        }
        
        public System.Threading.Tasks.Task<string> TimerAsync(string episode, string serie) {
            return base.Channel.TimerAsync(episode, serie);
        }
    }
}
