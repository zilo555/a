﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1378
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFClientApp.NorthwindService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Order", Namespace="http://schemas.datacontract.org/2004/07/Wrox.ProCSharp.EnterpriseServices")]
    [System.SerializableAttribute()]
    public partial class Order : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string customerIdField;
        
        private System.DateTime orderDateField;
        
        private int orderIdField;
        
        private WCFClientApp.NorthwindService.OrderLine[] orderLinesField;
        
        private string shipAddressField;
        
        private string shipCityField;
        
        private string shipCountryField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string customerId {
            get {
                return this.customerIdField;
            }
            set {
                if ((object.ReferenceEquals(this.customerIdField, value) != true)) {
                    this.customerIdField = value;
                    this.RaisePropertyChanged("customerId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime orderDate {
            get {
                return this.orderDateField;
            }
            set {
                if ((this.orderDateField.Equals(value) != true)) {
                    this.orderDateField = value;
                    this.RaisePropertyChanged("orderDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int orderId {
            get {
                return this.orderIdField;
            }
            set {
                if ((this.orderIdField.Equals(value) != true)) {
                    this.orderIdField = value;
                    this.RaisePropertyChanged("orderId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public WCFClientApp.NorthwindService.OrderLine[] orderLines {
            get {
                return this.orderLinesField;
            }
            set {
                if ((object.ReferenceEquals(this.orderLinesField, value) != true)) {
                    this.orderLinesField = value;
                    this.RaisePropertyChanged("orderLines");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string shipAddress {
            get {
                return this.shipAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.shipAddressField, value) != true)) {
                    this.shipAddressField = value;
                    this.RaisePropertyChanged("shipAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string shipCity {
            get {
                return this.shipCityField;
            }
            set {
                if ((object.ReferenceEquals(this.shipCityField, value) != true)) {
                    this.shipCityField = value;
                    this.RaisePropertyChanged("shipCity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string shipCountry {
            get {
                return this.shipCountryField;
            }
            set {
                if ((object.ReferenceEquals(this.shipCountryField, value) != true)) {
                    this.shipCountryField = value;
                    this.RaisePropertyChanged("shipCountry");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OrderLine", Namespace="http://schemas.datacontract.org/2004/07/Wrox.ProCSharp.EnterpriseServices")]
    [System.SerializableAttribute()]
    public partial class OrderLine : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int ProductIdk__BackingFieldField;
        
        private int Quantityk__BackingFieldField;
        
        private float UnitPricek__BackingFieldField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<ProductId>k__BackingField", IsRequired=true)]
        public int ProductIdk__BackingField {
            get {
                return this.ProductIdk__BackingFieldField;
            }
            set {
                if ((this.ProductIdk__BackingFieldField.Equals(value) != true)) {
                    this.ProductIdk__BackingFieldField = value;
                    this.RaisePropertyChanged("ProductIdk__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Quantity>k__BackingField", IsRequired=true)]
        public int Quantityk__BackingField {
            get {
                return this.Quantityk__BackingFieldField;
            }
            set {
                if ((this.Quantityk__BackingFieldField.Equals(value) != true)) {
                    this.Quantityk__BackingFieldField = value;
                    this.RaisePropertyChanged("Quantityk__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<UnitPrice>k__BackingField", IsRequired=true)]
        public float UnitPricek__BackingField {
            get {
                return this.UnitPricek__BackingFieldField;
            }
            set {
                if ((this.UnitPricek__BackingFieldField.Equals(value) != true)) {
                    this.UnitPricek__BackingFieldField = value;
                    this.RaisePropertyChanged("UnitPricek__BackingField");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://tempuri.org/E1B02E09-EE48-3B6B-946F-E6A8BAEC6340", ConfigurationName="NorthwindService.IOrderControl", SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IOrderControl {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/E1B02E09-EE48-3B6B-946F-E6A8BAEC6340/IOrderControl/NewOrder", ReplyAction="http://tempuri.org/E1B02E09-EE48-3B6B-946F-E6A8BAEC6340/IOrderControl/NewOrderRes" +
            "ponse")]
        [System.ServiceModel.TransactionFlowAttribute(System.ServiceModel.TransactionFlowOption.Allowed)]
        void NewOrder(WCFClientApp.NorthwindService.Order order);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IOrderControlChannel : WCFClientApp.NorthwindService.IOrderControl, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class OrderControlClient : System.ServiceModel.ClientBase<WCFClientApp.NorthwindService.IOrderControl>, WCFClientApp.NorthwindService.IOrderControl {
        
        public OrderControlClient() {
        }
        
        public OrderControlClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OrderControlClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrderControlClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrderControlClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void NewOrder(WCFClientApp.NorthwindService.Order order) {
            base.Channel.NewOrder(order);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://schemas.microsoft.com/2006/04/mex", ConfigurationName="NorthwindService.IMetadataExchange")]
    public interface IMetadataExchange {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.xmlsoap.org/ws/2004/09/transfer/Get", ReplyAction="http://schemas.xmlsoap.org/ws/2004/09/transfer/GetResponse")]
        System.ServiceModel.Channels.Message Get(System.ServiceModel.Channels.Message request);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IMetadataExchangeChannel : WCFClientApp.NorthwindService.IMetadataExchange, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class MetadataExchangeClient : System.ServiceModel.ClientBase<WCFClientApp.NorthwindService.IMetadataExchange>, WCFClientApp.NorthwindService.IMetadataExchange {
        
        public MetadataExchangeClient() {
        }
        
        public MetadataExchangeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MetadataExchangeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MetadataExchangeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MetadataExchangeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.ServiceModel.Channels.Message Get(System.ServiceModel.Channels.Message request) {
            return base.Channel.Get(request);
        }
    }
}
