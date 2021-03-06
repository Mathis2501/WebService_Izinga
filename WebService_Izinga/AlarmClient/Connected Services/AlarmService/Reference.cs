﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlarmClient.AlarmService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Alarm", Namespace="http://schemas.datacontract.org/2004/07/IzingaWebService")]
    [System.SerializableAttribute()]
    public partial class Alarm : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime TimeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Content {
            get {
                return this.ContentField;
            }
            set {
                if ((object.ReferenceEquals(this.ContentField, value) != true)) {
                    this.ContentField = value;
                    this.RaisePropertyChanged("Content");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Number {
            get {
                return this.NumberField;
            }
            set {
                if ((object.ReferenceEquals(this.NumberField, value) != true)) {
                    this.NumberField = value;
                    this.RaisePropertyChanged("Number");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Time {
            get {
                return this.TimeField;
            }
            set {
                if ((this.TimeField.Equals(value) != true)) {
                    this.TimeField = value;
                    this.RaisePropertyChanged("Time");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AlarmService.IAlarmService")]
    public interface IAlarmService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlarmService/GetAlarms", ReplyAction="http://tempuri.org/IAlarmService/GetAlarmsResponse")]
        AlarmClient.AlarmService.Alarm[] GetAlarms();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IAlarmService/GetAlarms", ReplyAction="http://tempuri.org/IAlarmService/GetAlarmsResponse")]
        System.IAsyncResult BeginGetAlarms(System.AsyncCallback callback, object asyncState);
        
        AlarmClient.AlarmService.Alarm[] EndGetAlarms(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlarmService/PostAlarm", ReplyAction="http://tempuri.org/IAlarmService/PostAlarmResponse")]
        void PostAlarm(AlarmClient.AlarmService.Alarm a);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IAlarmService/PostAlarm", ReplyAction="http://tempuri.org/IAlarmService/PostAlarmResponse")]
        System.IAsyncResult BeginPostAlarm(AlarmClient.AlarmService.Alarm a, System.AsyncCallback callback, object asyncState);
        
        void EndPostAlarm(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAlarmServiceChannel : AlarmClient.AlarmService.IAlarmService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetAlarmsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetAlarmsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public AlarmClient.AlarmService.Alarm[] Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((AlarmClient.AlarmService.Alarm[])(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AlarmServiceClient : System.ServiceModel.ClientBase<AlarmClient.AlarmService.IAlarmService>, AlarmClient.AlarmService.IAlarmService {
        
        private BeginOperationDelegate onBeginGetAlarmsDelegate;
        
        private EndOperationDelegate onEndGetAlarmsDelegate;
        
        private System.Threading.SendOrPostCallback onGetAlarmsCompletedDelegate;
        
        private BeginOperationDelegate onBeginPostAlarmDelegate;
        
        private EndOperationDelegate onEndPostAlarmDelegate;
        
        private System.Threading.SendOrPostCallback onPostAlarmCompletedDelegate;
        
        public AlarmServiceClient() {
        }
        
        public AlarmServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AlarmServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AlarmServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AlarmServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<GetAlarmsCompletedEventArgs> GetAlarmsCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> PostAlarmCompleted;
        
        public AlarmClient.AlarmService.Alarm[] GetAlarms() {
            return base.Channel.GetAlarms();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetAlarms(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetAlarms(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public AlarmClient.AlarmService.Alarm[] EndGetAlarms(System.IAsyncResult result) {
            return base.Channel.EndGetAlarms(result);
        }
        
        private System.IAsyncResult OnBeginGetAlarms(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginGetAlarms(callback, asyncState);
        }
        
        private object[] OnEndGetAlarms(System.IAsyncResult result) {
            AlarmClient.AlarmService.Alarm[] retVal = this.EndGetAlarms(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetAlarmsCompleted(object state) {
            if ((this.GetAlarmsCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetAlarmsCompleted(this, new GetAlarmsCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetAlarmsAsync() {
            this.GetAlarmsAsync(null);
        }
        
        public void GetAlarmsAsync(object userState) {
            if ((this.onBeginGetAlarmsDelegate == null)) {
                this.onBeginGetAlarmsDelegate = new BeginOperationDelegate(this.OnBeginGetAlarms);
            }
            if ((this.onEndGetAlarmsDelegate == null)) {
                this.onEndGetAlarmsDelegate = new EndOperationDelegate(this.OnEndGetAlarms);
            }
            if ((this.onGetAlarmsCompletedDelegate == null)) {
                this.onGetAlarmsCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetAlarmsCompleted);
            }
            base.InvokeAsync(this.onBeginGetAlarmsDelegate, null, this.onEndGetAlarmsDelegate, this.onGetAlarmsCompletedDelegate, userState);
        }
        
        public void PostAlarm(AlarmClient.AlarmService.Alarm a) {
            base.Channel.PostAlarm(a);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginPostAlarm(AlarmClient.AlarmService.Alarm a, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginPostAlarm(a, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public void EndPostAlarm(System.IAsyncResult result) {
            base.Channel.EndPostAlarm(result);
        }
        
        private System.IAsyncResult OnBeginPostAlarm(object[] inValues, System.AsyncCallback callback, object asyncState) {
            AlarmClient.AlarmService.Alarm a = ((AlarmClient.AlarmService.Alarm)(inValues[0]));
            return this.BeginPostAlarm(a, callback, asyncState);
        }
        
        private object[] OnEndPostAlarm(System.IAsyncResult result) {
            this.EndPostAlarm(result);
            return null;
        }
        
        private void OnPostAlarmCompleted(object state) {
            if ((this.PostAlarmCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.PostAlarmCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void PostAlarmAsync(AlarmClient.AlarmService.Alarm a) {
            this.PostAlarmAsync(a, null);
        }
        
        public void PostAlarmAsync(AlarmClient.AlarmService.Alarm a, object userState) {
            if ((this.onBeginPostAlarmDelegate == null)) {
                this.onBeginPostAlarmDelegate = new BeginOperationDelegate(this.OnBeginPostAlarm);
            }
            if ((this.onEndPostAlarmDelegate == null)) {
                this.onEndPostAlarmDelegate = new EndOperationDelegate(this.OnEndPostAlarm);
            }
            if ((this.onPostAlarmCompletedDelegate == null)) {
                this.onPostAlarmCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnPostAlarmCompleted);
            }
            base.InvokeAsync(this.onBeginPostAlarmDelegate, new object[] {
                        a}, this.onEndPostAlarmDelegate, this.onPostAlarmCompletedDelegate, userState);
        }
    }
}
