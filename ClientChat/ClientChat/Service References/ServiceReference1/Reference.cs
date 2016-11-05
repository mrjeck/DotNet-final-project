﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientChat.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Message", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class Message : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ClientChat.ServiceReference1.Visitor addresseeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string messageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ClientChat.ServiceReference1.Visitor senderField;
        
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
        public ClientChat.ServiceReference1.Visitor addressee {
            get {
                return this.addresseeField;
            }
            set {
                if ((object.ReferenceEquals(this.addresseeField, value) != true)) {
                    this.addresseeField = value;
                    this.RaisePropertyChanged("addressee");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string message {
            get {
                return this.messageField;
            }
            set {
                if ((object.ReferenceEquals(this.messageField, value) != true)) {
                    this.messageField = value;
                    this.RaisePropertyChanged("message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ClientChat.ServiceReference1.Visitor sender {
            get {
                return this.senderField;
            }
            set {
                if ((object.ReferenceEquals(this.senderField, value) != true)) {
                    this.senderField = value;
                    this.RaisePropertyChanged("sender");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Visitor", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class Visitor : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nicknameField;
        
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
        public string nickname {
            get {
                return this.nicknameField;
            }
            set {
                if ((object.ReferenceEquals(this.nicknameField, value) != true)) {
                    this.nicknameField = value;
                    this.RaisePropertyChanged("nickname");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService_Chat", CallbackContract=typeof(ClientChat.ServiceReference1.IService_ChatCallback))]
    public interface IService_Chat {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_Chat/Join", ReplyAction="http://tempuri.org/IService_Chat/JoinResponse")]
        bool Join(string nickname, string password, bool register);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_Chat/Join", ReplyAction="http://tempuri.org/IService_Chat/JoinResponse")]
        System.Threading.Tasks.Task<bool> JoinAsync(string nickname, string password, bool register);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService_Chat/Send_messageToServer")]
        void Send_messageToServer(ClientChat.ServiceReference1.Message msg);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService_Chat/Send_messageToServer")]
        System.Threading.Tasks.Task Send_messageToServerAsync(ClientChat.ServiceReference1.Message msg);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService_Chat/Leave")]
        void Leave();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService_Chat/Leave")]
        System.Threading.Tasks.Task LeaveAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService_ChatCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService_Chat/Update_visitors_list")]
        void Update_visitors_list(ClientChat.ServiceReference1.Visitor[] visitors);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService_Chat/Send_messageToClient")]
        void Send_messageToClient(ClientChat.ServiceReference1.Message msg);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService_ChatChannel : ClientChat.ServiceReference1.IService_Chat, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service_ChatClient : System.ServiceModel.DuplexClientBase<ClientChat.ServiceReference1.IService_Chat>, ClientChat.ServiceReference1.IService_Chat {
        
        public Service_ChatClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public Service_ChatClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public Service_ChatClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public Service_ChatClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public Service_ChatClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public bool Join(string nickname, string password, bool register) {
            return base.Channel.Join(nickname, password, register);
        }
        
        public System.Threading.Tasks.Task<bool> JoinAsync(string nickname, string password, bool register) {
            return base.Channel.JoinAsync(nickname, password, register);
        }
        
        public void Send_messageToServer(ClientChat.ServiceReference1.Message msg) {
            base.Channel.Send_messageToServer(msg);
        }
        
        public System.Threading.Tasks.Task Send_messageToServerAsync(ClientChat.ServiceReference1.Message msg) {
            return base.Channel.Send_messageToServerAsync(msg);
        }
        
        public void Leave() {
            base.Channel.Leave();
        }
        
        public System.Threading.Tasks.Task LeaveAsync() {
            return base.Channel.LeaveAsync();
        }
    }
}