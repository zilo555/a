﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.312
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFClientApp.OrderService
{
    using System.Runtime.Serialization;
    using System;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.datacontract.org/2004/07/Wrox.ProCSharp.EnterpriseServices")]
    [System.SerializableAttribute()]
    public partial class Order : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string customerIdField;
        
        private System.DateTime orderDateField;
        
        private int orderIdField;
        
        private WCFClientApp.OrderService.OrderLine[] orderLinesField;
        
        private string shipAddressField;
        
        private string shipCityField;
        
        private string shipCountryField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string customerId
        {
            get
            {
                return this.customerIdField;
            }
            set
            {
                this.customerIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime orderDate
        {
            get
            {
                return this.orderDateField;
            }
            set
            {
                this.orderDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int orderId
        {
            get
            {
                return this.orderIdField;
            }
            set
            {
                this.orderIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public WCFClientApp.OrderService.OrderLine[] orderLines
        {
            get
            {
                return this.orderLinesField;
            }
            set
            {
                this.orderLinesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string shipAddress
        {
            get
            {
                return this.shipAddressField;
            }
            set
            {
                this.shipAddressField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string shipCity
        {
            get
            {
                return this.shipCityField;
            }
            set
            {
                this.shipCityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string shipCountry
        {
            get
            {
                return this.shipCountryField;
            }
            set
            {
                this.shipCountryField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.datacontract.org/2004/07/Wrox.ProCSharp.EnterpriseServices")]
    [System.SerializableAttribute()]
    public partial class OrderLine : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int productIdField;
        
        private int quantityField;
        
        private float unitPriceField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int productId
        {
            get
            {
                return this.productIdField;
            }
            set
            {
                this.productIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public float unitPrice
        {
            get
            {
                return this.unitPriceField;
            }
            set
            {
                this.unitPriceField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://tempuri.org/E1B02E09-EE48-3B6B-946F-E6A8BAEC6340", ConfigurationName="WCFClientApp.OrderService.IOrderControl", SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IOrderControl
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/E1B02E09-EE48-3B6B-946F-E6A8BAEC6340/IOrderControl/NewOrder", ReplyAction="http://tempuri.org/E1B02E09-EE48-3B6B-946F-E6A8BAEC6340/IOrderControl/NewOrderRes" +
            "ponse")]
        [System.ServiceModel.TransactionFlowAttribute(System.ServiceModel.TransactionFlowOption.Allowed)]
        void NewOrder(WCFClientApp.OrderService.Order order);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IOrderControlChannel : WCFClientApp.OrderService.IOrderControl, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class OrderControlClient : System.ServiceModel.ClientBase<WCFClientApp.OrderService.IOrderControl>, WCFClientApp.OrderService.IOrderControl
    {
        
        public OrderControlClient()
        {
        }
        
        public OrderControlClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public OrderControlClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public OrderControlClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public OrderControlClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public void NewOrder(WCFClientApp.OrderService.Order order)
        {
            base.Channel.NewOrder(order);
        }
    }
}
