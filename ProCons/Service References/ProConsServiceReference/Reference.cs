﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.18444
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProCons.ProConsServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AccountWS", Namespace="http://schemas.datacontract.org/2004/07/ProConsService.Business_Objects")]
    [System.SerializableAttribute()]
    public partial class AccountWS : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public System.Guid Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="RetrieveMultipleRequest", Namespace="http://schemas.datacontract.org/2004/07/ProConsService.Service_Objects")]
    [System.SerializableAttribute()]
    public partial class RetrieveMultipleRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<ProCons.ProConsServiceReference.FilterCondition> CriteriaField;
        
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
        public System.Collections.Generic.List<ProCons.ProConsServiceReference.FilterCondition> Criteria {
            get {
                return this.CriteriaField;
            }
            set {
                if ((object.ReferenceEquals(this.CriteriaField, value) != true)) {
                    this.CriteriaField = value;
                    this.RaisePropertyChanged("Criteria");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="FilterCondition", Namespace="http://schemas.datacontract.org/2004/07/ProConsService.Service_Objects")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ProCons.ProConsServiceReference.RetrieveMultipleRequest))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.Collections.Generic.List<ProCons.ProConsServiceReference.FilterCondition>))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ProCons.ProConsServiceReference.FilterOperators))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ProCons.ProConsServiceReference.AccountWS))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.Collections.Generic.List<ProCons.ProConsServiceReference.AccountWS>))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.Collections.Generic.List<ProCons.ProConsServiceReference.RecordWs>))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ProCons.ProConsServiceReference.RecordWs))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ProCons.ProConsServiceReference.CategoryWS))]
    public partial class FilterCondition : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FieldNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ProCons.ProConsServiceReference.FilterOperators FilterOperatorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private object ValueField;
        
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
        public string FieldName {
            get {
                return this.FieldNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FieldNameField, value) != true)) {
                    this.FieldNameField = value;
                    this.RaisePropertyChanged("FieldName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ProCons.ProConsServiceReference.FilterOperators FilterOperator {
            get {
                return this.FilterOperatorField;
            }
            set {
                if ((this.FilterOperatorField.Equals(value) != true)) {
                    this.FilterOperatorField = value;
                    this.RaisePropertyChanged("FilterOperator");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public object Value {
            get {
                return this.ValueField;
            }
            set {
                if ((object.ReferenceEquals(this.ValueField, value) != true)) {
                    this.ValueField = value;
                    this.RaisePropertyChanged("Value");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FilterOperators", Namespace="http://schemas.datacontract.org/2004/07/ProConsService.Service_Objects")]
    public enum FilterOperators : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Equal = 1,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RecordWs", Namespace="http://schemas.datacontract.org/2004/07/ProConsService.Business_Objects")]
    [System.SerializableAttribute()]
    public partial class RecordWs : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ProCons.ProConsServiceReference.AccountWS AccountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid AccountIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ProCons.ProConsServiceReference.CategoryWS CategoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid CategoryIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CommentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal TotalField;
        
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
        public ProCons.ProConsServiceReference.AccountWS Account {
            get {
                return this.AccountField;
            }
            set {
                if ((object.ReferenceEquals(this.AccountField, value) != true)) {
                    this.AccountField = value;
                    this.RaisePropertyChanged("Account");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid AccountId {
            get {
                return this.AccountIdField;
            }
            set {
                if ((this.AccountIdField.Equals(value) != true)) {
                    this.AccountIdField = value;
                    this.RaisePropertyChanged("AccountId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ProCons.ProConsServiceReference.CategoryWS Category {
            get {
                return this.CategoryField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoryField, value) != true)) {
                    this.CategoryField = value;
                    this.RaisePropertyChanged("Category");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid CategoryId {
            get {
                return this.CategoryIdField;
            }
            set {
                if ((this.CategoryIdField.Equals(value) != true)) {
                    this.CategoryIdField = value;
                    this.RaisePropertyChanged("CategoryId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Comment {
            get {
                return this.CommentField;
            }
            set {
                if ((object.ReferenceEquals(this.CommentField, value) != true)) {
                    this.CommentField = value;
                    this.RaisePropertyChanged("Comment");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Total {
            get {
                return this.TotalField;
            }
            set {
                if ((this.TotalField.Equals(value) != true)) {
                    this.TotalField = value;
                    this.RaisePropertyChanged("Total");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CategoryWS", Namespace="http://schemas.datacontract.org/2004/07/ProConsService.Business_Objects")]
    [System.SerializableAttribute()]
    public partial class CategoryWS : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public System.Guid Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProConsServiceReference.IProConsService")]
    public interface IProConsService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProConsService/RetrieveAccount", ReplyAction="http://tempuri.org/IProConsService/RetrieveAccountResponse")]
        ProCons.ProConsServiceReference.AccountWS RetrieveAccount(System.Guid accountId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProConsService/RetrieveAccount", ReplyAction="http://tempuri.org/IProConsService/RetrieveAccountResponse")]
        System.Threading.Tasks.Task<ProCons.ProConsServiceReference.AccountWS> RetrieveAccountAsync(System.Guid accountId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProConsService/RetrieveAccounts", ReplyAction="http://tempuri.org/IProConsService/RetrieveAccountsResponse")]
        System.Collections.Generic.List<ProCons.ProConsServiceReference.AccountWS> RetrieveAccounts(ProCons.ProConsServiceReference.RetrieveMultipleRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProConsService/RetrieveAccounts", ReplyAction="http://tempuri.org/IProConsService/RetrieveAccountsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ProCons.ProConsServiceReference.AccountWS>> RetrieveAccountsAsync(ProCons.ProConsServiceReference.RetrieveMultipleRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProConsService/CreateAccount", ReplyAction="http://tempuri.org/IProConsService/CreateAccountResponse")]
        System.Guid CreateAccount(ProCons.ProConsServiceReference.AccountWS account);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProConsService/CreateAccount", ReplyAction="http://tempuri.org/IProConsService/CreateAccountResponse")]
        System.Threading.Tasks.Task<System.Guid> CreateAccountAsync(ProCons.ProConsServiceReference.AccountWS account);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProConsService/RetrieveRecords", ReplyAction="http://tempuri.org/IProConsService/RetrieveRecordsResponse")]
        System.Collections.Generic.List<ProCons.ProConsServiceReference.RecordWs> RetrieveRecords(ProCons.ProConsServiceReference.RetrieveMultipleRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProConsService/RetrieveRecords", ReplyAction="http://tempuri.org/IProConsService/RetrieveRecordsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ProCons.ProConsServiceReference.RecordWs>> RetrieveRecordsAsync(ProCons.ProConsServiceReference.RetrieveMultipleRequest request);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProConsServiceChannel : ProCons.ProConsServiceReference.IProConsService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProConsServiceClient : System.ServiceModel.ClientBase<ProCons.ProConsServiceReference.IProConsService>, ProCons.ProConsServiceReference.IProConsService {
        
        public ProConsServiceClient() {
        }
        
        public ProConsServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProConsServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProConsServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProConsServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ProCons.ProConsServiceReference.AccountWS RetrieveAccount(System.Guid accountId) {
            return base.Channel.RetrieveAccount(accountId);
        }
        
        public System.Threading.Tasks.Task<ProCons.ProConsServiceReference.AccountWS> RetrieveAccountAsync(System.Guid accountId) {
            return base.Channel.RetrieveAccountAsync(accountId);
        }
        
        public System.Collections.Generic.List<ProCons.ProConsServiceReference.AccountWS> RetrieveAccounts(ProCons.ProConsServiceReference.RetrieveMultipleRequest request) {
            return base.Channel.RetrieveAccounts(request);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ProCons.ProConsServiceReference.AccountWS>> RetrieveAccountsAsync(ProCons.ProConsServiceReference.RetrieveMultipleRequest request) {
            return base.Channel.RetrieveAccountsAsync(request);
        }
        
        public System.Guid CreateAccount(ProCons.ProConsServiceReference.AccountWS account) {
            return base.Channel.CreateAccount(account);
        }
        
        public System.Threading.Tasks.Task<System.Guid> CreateAccountAsync(ProCons.ProConsServiceReference.AccountWS account) {
            return base.Channel.CreateAccountAsync(account);
        }
        
        public System.Collections.Generic.List<ProCons.ProConsServiceReference.RecordWs> RetrieveRecords(ProCons.ProConsServiceReference.RetrieveMultipleRequest request) {
            return base.Channel.RetrieveRecords(request);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ProCons.ProConsServiceReference.RecordWs>> RetrieveRecordsAsync(ProCons.ProConsServiceReference.RetrieveMultipleRequest request) {
            return base.Channel.RetrieveRecordsAsync(request);
        }
    }
}
