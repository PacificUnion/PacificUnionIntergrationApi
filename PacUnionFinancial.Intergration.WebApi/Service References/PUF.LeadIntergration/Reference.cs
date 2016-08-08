﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PacUnionFinancial.Intergration.WebApi.PUF.LeadIntergration {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LoanApplication", Namespace="http://schemas.datacontract.org/2004/07/PUF.LeadIntegrationService")]
    [System.SerializableAttribute()]
    public partial class LoanApplication : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PacUnionFinancial.Intergration.WebApi.PUF.LeadIntergration.AppLog[] AppLogsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> AppRetrievalErrorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApplicationIdentifierField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> DatePostedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateReceivedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long LoanApplicationIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int LosPostAttemptsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> PostToLosSuccessfulField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RetrievalAttemptsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> VelocifyUpdateDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> VelocifyUpdatedField;
        
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
        public PacUnionFinancial.Intergration.WebApi.PUF.LeadIntergration.AppLog[] AppLogs {
            get {
                return this.AppLogsField;
            }
            set {
                if ((object.ReferenceEquals(this.AppLogsField, value) != true)) {
                    this.AppLogsField = value;
                    this.RaisePropertyChanged("AppLogs");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> AppRetrievalError {
            get {
                return this.AppRetrievalErrorField;
            }
            set {
                if ((this.AppRetrievalErrorField.Equals(value) != true)) {
                    this.AppRetrievalErrorField = value;
                    this.RaisePropertyChanged("AppRetrievalError");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ApplicationIdentifier {
            get {
                return this.ApplicationIdentifierField;
            }
            set {
                if ((object.ReferenceEquals(this.ApplicationIdentifierField, value) != true)) {
                    this.ApplicationIdentifierField = value;
                    this.RaisePropertyChanged("ApplicationIdentifier");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> DatePosted {
            get {
                return this.DatePostedField;
            }
            set {
                if ((this.DatePostedField.Equals(value) != true)) {
                    this.DatePostedField = value;
                    this.RaisePropertyChanged("DatePosted");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateReceived {
            get {
                return this.DateReceivedField;
            }
            set {
                if ((this.DateReceivedField.Equals(value) != true)) {
                    this.DateReceivedField = value;
                    this.RaisePropertyChanged("DateReceived");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long LoanApplicationID {
            get {
                return this.LoanApplicationIDField;
            }
            set {
                if ((this.LoanApplicationIDField.Equals(value) != true)) {
                    this.LoanApplicationIDField = value;
                    this.RaisePropertyChanged("LoanApplicationID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int LosPostAttempts {
            get {
                return this.LosPostAttemptsField;
            }
            set {
                if ((this.LosPostAttemptsField.Equals(value) != true)) {
                    this.LosPostAttemptsField = value;
                    this.RaisePropertyChanged("LosPostAttempts");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> PostToLosSuccessful {
            get {
                return this.PostToLosSuccessfulField;
            }
            set {
                if ((this.PostToLosSuccessfulField.Equals(value) != true)) {
                    this.PostToLosSuccessfulField = value;
                    this.RaisePropertyChanged("PostToLosSuccessful");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int RetrievalAttempts {
            get {
                return this.RetrievalAttemptsField;
            }
            set {
                if ((this.RetrievalAttemptsField.Equals(value) != true)) {
                    this.RetrievalAttemptsField = value;
                    this.RaisePropertyChanged("RetrievalAttempts");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> VelocifyUpdateDate {
            get {
                return this.VelocifyUpdateDateField;
            }
            set {
                if ((this.VelocifyUpdateDateField.Equals(value) != true)) {
                    this.VelocifyUpdateDateField = value;
                    this.RaisePropertyChanged("VelocifyUpdateDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> VelocifyUpdated {
            get {
                return this.VelocifyUpdatedField;
            }
            set {
                if ((this.VelocifyUpdatedField.Equals(value) != true)) {
                    this.VelocifyUpdatedField = value;
                    this.RaisePropertyChanged("VelocifyUpdated");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="AppLog", Namespace="http://schemas.datacontract.org/2004/07/PUF.LeadIntegrationService")]
    [System.SerializableAttribute()]
    public partial class AppLog : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateCreatedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> IsErrorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PacUnionFinancial.Intergration.WebApi.PUF.LeadIntergration.LoanApplication LoanApplicationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<long> LoanApplicationIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long LogIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LogTextField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StackTraceField;
        
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
        public System.DateTime DateCreated {
            get {
                return this.DateCreatedField;
            }
            set {
                if ((this.DateCreatedField.Equals(value) != true)) {
                    this.DateCreatedField = value;
                    this.RaisePropertyChanged("DateCreated");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> IsError {
            get {
                return this.IsErrorField;
            }
            set {
                if ((this.IsErrorField.Equals(value) != true)) {
                    this.IsErrorField = value;
                    this.RaisePropertyChanged("IsError");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PacUnionFinancial.Intergration.WebApi.PUF.LeadIntergration.LoanApplication LoanApplication {
            get {
                return this.LoanApplicationField;
            }
            set {
                if ((object.ReferenceEquals(this.LoanApplicationField, value) != true)) {
                    this.LoanApplicationField = value;
                    this.RaisePropertyChanged("LoanApplication");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<long> LoanApplicationID {
            get {
                return this.LoanApplicationIDField;
            }
            set {
                if ((this.LoanApplicationIDField.Equals(value) != true)) {
                    this.LoanApplicationIDField = value;
                    this.RaisePropertyChanged("LoanApplicationID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long LogID {
            get {
                return this.LogIDField;
            }
            set {
                if ((this.LogIDField.Equals(value) != true)) {
                    this.LogIDField = value;
                    this.RaisePropertyChanged("LogID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LogText {
            get {
                return this.LogTextField;
            }
            set {
                if ((object.ReferenceEquals(this.LogTextField, value) != true)) {
                    this.LogTextField = value;
                    this.RaisePropertyChanged("LogText");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StackTrace {
            get {
                return this.StackTraceField;
            }
            set {
                if ((object.ReferenceEquals(this.StackTraceField, value) != true)) {
                    this.StackTraceField = value;
                    this.RaisePropertyChanged("StackTrace");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PUF.LeadIntergration.ILeadIntegrationService")]
    public interface ILeadIntegrationService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILeadIntegrationService/GetLoanApplicationByAppIdentifier", ReplyAction="http://tempuri.org/ILeadIntegrationService/GetLoanApplicationByAppIdentifierRespo" +
            "nse")]
        PacUnionFinancial.Intergration.WebApi.PUF.LeadIntergration.LoanApplication GetLoanApplicationByAppIdentifier(string applicationIdentifier);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILeadIntegrationService/GetLoanApplicationByAppIdentifier", ReplyAction="http://tempuri.org/ILeadIntegrationService/GetLoanApplicationByAppIdentifierRespo" +
            "nse")]
        System.Threading.Tasks.Task<PacUnionFinancial.Intergration.WebApi.PUF.LeadIntergration.LoanApplication> GetLoanApplicationByAppIdentifierAsync(string applicationIdentifier);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILeadIntegrationService/SaveLoanApplication", ReplyAction="http://tempuri.org/ILeadIntegrationService/SaveLoanApplicationResponse")]
        PacUnionFinancial.Intergration.WebApi.PUF.LeadIntergration.LoanApplication SaveLoanApplication(PacUnionFinancial.Intergration.WebApi.PUF.LeadIntergration.LoanApplication loanApplication);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILeadIntegrationService/SaveLoanApplication", ReplyAction="http://tempuri.org/ILeadIntegrationService/SaveLoanApplicationResponse")]
        System.Threading.Tasks.Task<PacUnionFinancial.Intergration.WebApi.PUF.LeadIntergration.LoanApplication> SaveLoanApplicationAsync(PacUnionFinancial.Intergration.WebApi.PUF.LeadIntergration.LoanApplication loanApplication);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILeadIntegrationService/SaveAppLog", ReplyAction="http://tempuri.org/ILeadIntegrationService/SaveAppLogResponse")]
        void SaveAppLog(PacUnionFinancial.Intergration.WebApi.PUF.LeadIntergration.AppLog appLog);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILeadIntegrationService/SaveAppLog", ReplyAction="http://tempuri.org/ILeadIntegrationService/SaveAppLogResponse")]
        System.Threading.Tasks.Task SaveAppLogAsync(PacUnionFinancial.Intergration.WebApi.PUF.LeadIntergration.AppLog appLog);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILeadIntegrationServiceChannel : PacUnionFinancial.Intergration.WebApi.PUF.LeadIntergration.ILeadIntegrationService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LeadIntegrationServiceClient : System.ServiceModel.ClientBase<PacUnionFinancial.Intergration.WebApi.PUF.LeadIntergration.ILeadIntegrationService>, PacUnionFinancial.Intergration.WebApi.PUF.LeadIntergration.ILeadIntegrationService {
        
        public LeadIntegrationServiceClient() {
        }
        
        public LeadIntegrationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LeadIntegrationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LeadIntegrationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LeadIntegrationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public PacUnionFinancial.Intergration.WebApi.PUF.LeadIntergration.LoanApplication GetLoanApplicationByAppIdentifier(string applicationIdentifier) {
            return base.Channel.GetLoanApplicationByAppIdentifier(applicationIdentifier);
        }
        
        public System.Threading.Tasks.Task<PacUnionFinancial.Intergration.WebApi.PUF.LeadIntergration.LoanApplication> GetLoanApplicationByAppIdentifierAsync(string applicationIdentifier) {
            return base.Channel.GetLoanApplicationByAppIdentifierAsync(applicationIdentifier);
        }
        
        public PacUnionFinancial.Intergration.WebApi.PUF.LeadIntergration.LoanApplication SaveLoanApplication(PacUnionFinancial.Intergration.WebApi.PUF.LeadIntergration.LoanApplication loanApplication) {
            return base.Channel.SaveLoanApplication(loanApplication);
        }
        
        public System.Threading.Tasks.Task<PacUnionFinancial.Intergration.WebApi.PUF.LeadIntergration.LoanApplication> SaveLoanApplicationAsync(PacUnionFinancial.Intergration.WebApi.PUF.LeadIntergration.LoanApplication loanApplication) {
            return base.Channel.SaveLoanApplicationAsync(loanApplication);
        }
        
        public void SaveAppLog(PacUnionFinancial.Intergration.WebApi.PUF.LeadIntergration.AppLog appLog) {
            base.Channel.SaveAppLog(appLog);
        }
        
        public System.Threading.Tasks.Task SaveAppLogAsync(PacUnionFinancial.Intergration.WebApi.PUF.LeadIntergration.AppLog appLog) {
            return base.Channel.SaveAppLogAsync(appLog);
        }
    }
}
