﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18063
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web.masService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://fts.sxsh.com/", ConfigurationName="masService.FtsSoap")]
    public interface FtsSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fts.sxsh.com/GetDocumentListCount", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        int GetDocumentListCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fts.sxsh.com/GetDocumentListCount", ReplyAction="*")]
        System.Threading.Tasks.Task<int> GetDocumentListCountAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fts.sxsh.com/GetDocumentList", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        string[] GetDocumentList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fts.sxsh.com/GetDocumentList", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> GetDocumentListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fts.sxsh.com/GetDocumentListCountByName", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        int GetDocumentListCountByName(string docName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fts.sxsh.com/GetDocumentListCountByName", ReplyAction="*")]
        System.Threading.Tasks.Task<int> GetDocumentListCountByNameAsync(string docName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fts.sxsh.com/GetDocumentListByName", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        string[] GetDocumentListByName(string docName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fts.sxsh.com/GetDocumentListByName", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> GetDocumentListByNameAsync(string docName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fts.sxsh.com/GetLastDocumentName", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        string GetLastDocumentName(string docName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fts.sxsh.com/GetLastDocumentName", ReplyAction="*")]
        System.Threading.Tasks.Task<string> GetLastDocumentNameAsync(string docName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fts.sxsh.com/GetDocumentLen", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        int GetDocumentLen(string docName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fts.sxsh.com/GetDocumentLen", ReplyAction="*")]
        System.Threading.Tasks.Task<int> GetDocumentLenAsync(string docName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fts.sxsh.com/GetDocument", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.Xml.Serialization.SoapElementAttribute(DataType="base64Binary")]
        byte[] GetDocument(string docName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fts.sxsh.com/GetDocument", ReplyAction="*")]
        [return: System.Xml.Serialization.SoapElementAttribute(DataType="base64Binary")]
        System.Threading.Tasks.Task<byte[]> GetDocumentAsync(string docName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fts.sxsh.com/SendDocument", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        int SendDocument(string docName, [System.Xml.Serialization.SoapElementAttribute(DataType="base64Binary")] byte[] docBuffer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fts.sxsh.com/SendDocument", ReplyAction="*")]
        System.Threading.Tasks.Task<int> SendDocumentAsync(string docName, [System.Xml.Serialization.SoapElementAttribute(DataType="base64Binary")] byte[] docBuffer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fts.sxsh.com/ThingSend_Ds", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        int ThingSend_Ds(string Phones, string Subject, string Desc, [System.Xml.Serialization.SoapElementAttribute(DataType="base64Binary")] byte[] Buff, int BuffLen, string SendDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fts.sxsh.com/ThingSend_Ds", ReplyAction="*")]
        System.Threading.Tasks.Task<int> ThingSend_DsAsync(string Phones, string Subject, string Desc, [System.Xml.Serialization.SoapElementAttribute(DataType="base64Binary")] byte[] Buff, int BuffLen, string SendDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fts.sxsh.com/ThingSend", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        int ThingSend(string Phones, string Subject, string Desc, [System.Xml.Serialization.SoapElementAttribute(DataType="base64Binary")] byte[] Buff, int BuffLen);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fts.sxsh.com/ThingSend", ReplyAction="*")]
        System.Threading.Tasks.Task<int> ThingSendAsync(string Phones, string Subject, string Desc, [System.Xml.Serialization.SoapElementAttribute(DataType="base64Binary")] byte[] Buff, int BuffLen);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fts.sxsh.com/SendToInfo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        bool SendToInfo(string Phones, string Desc, int SendTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fts.sxsh.com/SendToInfo", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> SendToInfoAsync(string Phones, string Desc, int SendTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fts.sxsh.com/SendToInfo_Ds", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        bool SendToInfo_Ds(string Phones, string Desc, int SendTime, string SendDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fts.sxsh.com/SendToInfo_Ds", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> SendToInfo_DsAsync(string Phones, string Desc, int SendTime, string SendDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fts.sxsh.com/Ping", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        bool Ping();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fts.sxsh.com/Ping", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> PingAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fts.sxsh.com/SendSMS", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        bool SendSMS(string Phones, string SMS, string UserName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://fts.sxsh.com/SendSMS", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> SendSMSAsync(string Phones, string SMS, string UserName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface FtsSoapChannel : Web.masService.FtsSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FtsSoapClient : System.ServiceModel.ClientBase<Web.masService.FtsSoap>, Web.masService.FtsSoap {
        
        public FtsSoapClient() {
        }
        
        public FtsSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FtsSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FtsSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FtsSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int GetDocumentListCount() {
            return base.Channel.GetDocumentListCount();
        }
        
        public System.Threading.Tasks.Task<int> GetDocumentListCountAsync() {
            return base.Channel.GetDocumentListCountAsync();
        }
        
        public string[] GetDocumentList() {
            return base.Channel.GetDocumentList();
        }
        
        public System.Threading.Tasks.Task<string[]> GetDocumentListAsync() {
            return base.Channel.GetDocumentListAsync();
        }
        
        public int GetDocumentListCountByName(string docName) {
            return base.Channel.GetDocumentListCountByName(docName);
        }
        
        public System.Threading.Tasks.Task<int> GetDocumentListCountByNameAsync(string docName) {
            return base.Channel.GetDocumentListCountByNameAsync(docName);
        }
        
        public string[] GetDocumentListByName(string docName) {
            return base.Channel.GetDocumentListByName(docName);
        }
        
        public System.Threading.Tasks.Task<string[]> GetDocumentListByNameAsync(string docName) {
            return base.Channel.GetDocumentListByNameAsync(docName);
        }
        
        public string GetLastDocumentName(string docName) {
            return base.Channel.GetLastDocumentName(docName);
        }
        
        public System.Threading.Tasks.Task<string> GetLastDocumentNameAsync(string docName) {
            return base.Channel.GetLastDocumentNameAsync(docName);
        }
        
        public int GetDocumentLen(string docName) {
            return base.Channel.GetDocumentLen(docName);
        }
        
        public System.Threading.Tasks.Task<int> GetDocumentLenAsync(string docName) {
            return base.Channel.GetDocumentLenAsync(docName);
        }
        
        public byte[] GetDocument(string docName) {
            return base.Channel.GetDocument(docName);
        }
        
        public System.Threading.Tasks.Task<byte[]> GetDocumentAsync(string docName) {
            return base.Channel.GetDocumentAsync(docName);
        }
        
        public int SendDocument(string docName, byte[] docBuffer) {
            return base.Channel.SendDocument(docName, docBuffer);
        }
        
        public System.Threading.Tasks.Task<int> SendDocumentAsync(string docName, byte[] docBuffer) {
            return base.Channel.SendDocumentAsync(docName, docBuffer);
        }
        
        public int ThingSend_Ds(string Phones, string Subject, string Desc, byte[] Buff, int BuffLen, string SendDate) {
            return base.Channel.ThingSend_Ds(Phones, Subject, Desc, Buff, BuffLen, SendDate);
        }
        
        public System.Threading.Tasks.Task<int> ThingSend_DsAsync(string Phones, string Subject, string Desc, byte[] Buff, int BuffLen, string SendDate) {
            return base.Channel.ThingSend_DsAsync(Phones, Subject, Desc, Buff, BuffLen, SendDate);
        }
        
        public int ThingSend(string Phones, string Subject, string Desc, byte[] Buff, int BuffLen) {
            return base.Channel.ThingSend(Phones, Subject, Desc, Buff, BuffLen);
        }
        
        public System.Threading.Tasks.Task<int> ThingSendAsync(string Phones, string Subject, string Desc, byte[] Buff, int BuffLen) {
            return base.Channel.ThingSendAsync(Phones, Subject, Desc, Buff, BuffLen);
        }
        
        public bool SendToInfo(string Phones, string Desc, int SendTime) {
            return base.Channel.SendToInfo(Phones, Desc, SendTime);
        }
        
        public System.Threading.Tasks.Task<bool> SendToInfoAsync(string Phones, string Desc, int SendTime) {
            return base.Channel.SendToInfoAsync(Phones, Desc, SendTime);
        }
        
        public bool SendToInfo_Ds(string Phones, string Desc, int SendTime, string SendDate) {
            return base.Channel.SendToInfo_Ds(Phones, Desc, SendTime, SendDate);
        }
        
        public System.Threading.Tasks.Task<bool> SendToInfo_DsAsync(string Phones, string Desc, int SendTime, string SendDate) {
            return base.Channel.SendToInfo_DsAsync(Phones, Desc, SendTime, SendDate);
        }
        
        public bool Ping() {
            return base.Channel.Ping();
        }
        
        public System.Threading.Tasks.Task<bool> PingAsync() {
            return base.Channel.PingAsync();
        }
        
        public bool SendSMS(string Phones, string SMS, string UserName) {
            return base.Channel.SendSMS(Phones, SMS, UserName);
        }
        
        public System.Threading.Tasks.Task<bool> SendSMSAsync(string Phones, string SMS, string UserName) {
            return base.Channel.SendSMSAsync(Phones, SMS, UserName);
        }
    }
}
