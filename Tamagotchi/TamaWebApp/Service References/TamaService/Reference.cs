﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TamaWebApp.TamaService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Tamagotchi", Namespace="http://schemas.datacontract.org/2004/07/TamaService")]
    [System.SerializableAttribute()]
    public partial class Tamagotchi : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ActionDoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short BoredomField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreationDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TamaWebApp.TamaService.TamaFlags FlagsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short HealthField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short HungerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ImgIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime LastUpdateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short SleepField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool isDeadField;
        
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
        public System.DateTime ActionDone {
            get {
                return this.ActionDoneField;
            }
            set {
                if ((this.ActionDoneField.Equals(value) != true)) {
                    this.ActionDoneField = value;
                    this.RaisePropertyChanged("ActionDone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short Boredom {
            get {
                return this.BoredomField;
            }
            set {
                if ((this.BoredomField.Equals(value) != true)) {
                    this.BoredomField = value;
                    this.RaisePropertyChanged("Boredom");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreationData {
            get {
                return this.CreationDataField;
            }
            set {
                if ((this.CreationDataField.Equals(value) != true)) {
                    this.CreationDataField = value;
                    this.RaisePropertyChanged("CreationData");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TamaWebApp.TamaService.TamaFlags Flags {
            get {
                return this.FlagsField;
            }
            set {
                if ((object.ReferenceEquals(this.FlagsField, value) != true)) {
                    this.FlagsField = value;
                    this.RaisePropertyChanged("Flags");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short Health {
            get {
                return this.HealthField;
            }
            set {
                if ((this.HealthField.Equals(value) != true)) {
                    this.HealthField = value;
                    this.RaisePropertyChanged("Health");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short Hunger {
            get {
                return this.HungerField;
            }
            set {
                if ((this.HungerField.Equals(value) != true)) {
                    this.HungerField = value;
                    this.RaisePropertyChanged("Hunger");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
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
        public int ImgId {
            get {
                return this.ImgIdField;
            }
            set {
                if ((this.ImgIdField.Equals(value) != true)) {
                    this.ImgIdField = value;
                    this.RaisePropertyChanged("ImgId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime LastUpdate {
            get {
                return this.LastUpdateField;
            }
            set {
                if ((this.LastUpdateField.Equals(value) != true)) {
                    this.LastUpdateField = value;
                    this.RaisePropertyChanged("LastUpdate");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short Sleep {
            get {
                return this.SleepField;
            }
            set {
                if ((this.SleepField.Equals(value) != true)) {
                    this.SleepField = value;
                    this.RaisePropertyChanged("Sleep");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool isDead {
            get {
                return this.isDeadField;
            }
            set {
                if ((this.isDeadField.Equals(value) != true)) {
                    this.isDeadField = value;
                    this.RaisePropertyChanged("isDead");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="TamaFlags", Namespace="http://schemas.datacontract.org/2004/07/TamaService")]
    [System.SerializableAttribute()]
    public partial class TamaFlags : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool CrazyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool HongerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsolatieField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool MunchiesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool SlaaptekortField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool TopatleetField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool VermoeidheidField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool VervelingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool VoedseltekortField;
        
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
        public bool Crazy {
            get {
                return this.CrazyField;
            }
            set {
                if ((this.CrazyField.Equals(value) != true)) {
                    this.CrazyField = value;
                    this.RaisePropertyChanged("Crazy");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Honger {
            get {
                return this.HongerField;
            }
            set {
                if ((this.HongerField.Equals(value) != true)) {
                    this.HongerField = value;
                    this.RaisePropertyChanged("Honger");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Isolatie {
            get {
                return this.IsolatieField;
            }
            set {
                if ((this.IsolatieField.Equals(value) != true)) {
                    this.IsolatieField = value;
                    this.RaisePropertyChanged("Isolatie");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Munchies {
            get {
                return this.MunchiesField;
            }
            set {
                if ((this.MunchiesField.Equals(value) != true)) {
                    this.MunchiesField = value;
                    this.RaisePropertyChanged("Munchies");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Slaaptekort {
            get {
                return this.SlaaptekortField;
            }
            set {
                if ((this.SlaaptekortField.Equals(value) != true)) {
                    this.SlaaptekortField = value;
                    this.RaisePropertyChanged("Slaaptekort");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Topatleet {
            get {
                return this.TopatleetField;
            }
            set {
                if ((this.TopatleetField.Equals(value) != true)) {
                    this.TopatleetField = value;
                    this.RaisePropertyChanged("Topatleet");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Vermoeidheid {
            get {
                return this.VermoeidheidField;
            }
            set {
                if ((this.VermoeidheidField.Equals(value) != true)) {
                    this.VermoeidheidField = value;
                    this.RaisePropertyChanged("Vermoeidheid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Verveling {
            get {
                return this.VervelingField;
            }
            set {
                if ((this.VervelingField.Equals(value) != true)) {
                    this.VervelingField = value;
                    this.RaisePropertyChanged("Verveling");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Voedseltekort {
            get {
                return this.VoedseltekortField;
            }
            set {
                if ((this.VoedseltekortField.Equals(value) != true)) {
                    this.VoedseltekortField = value;
                    this.RaisePropertyChanged("Voedseltekort");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TamaService.ITamaLogic")]
    public interface ITamaLogic {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamaLogic/GetTamagotchi", ReplyAction="http://tempuri.org/ITamaLogic/GetTamagotchiResponse")]
        TamaWebApp.TamaService.Tamagotchi GetTamagotchi(int TamaID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamaLogic/GetTamagotchi", ReplyAction="http://tempuri.org/ITamaLogic/GetTamagotchiResponse")]
        System.Threading.Tasks.Task<TamaWebApp.TamaService.Tamagotchi> GetTamagotchiAsync(int TamaID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamaLogic/AddTamagotchi", ReplyAction="http://tempuri.org/ITamaLogic/AddTamagotchiResponse")]
        int AddTamagotchi(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamaLogic/AddTamagotchi", ReplyAction="http://tempuri.org/ITamaLogic/AddTamagotchiResponse")]
        System.Threading.Tasks.Task<int> AddTamagotchiAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamaLogic/GetAllTamagotchi", ReplyAction="http://tempuri.org/ITamaLogic/GetAllTamagotchiResponse")]
        TamaWebApp.TamaService.Tamagotchi[] GetAllTamagotchi();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamaLogic/GetAllTamagotchi", ReplyAction="http://tempuri.org/ITamaLogic/GetAllTamagotchiResponse")]
        System.Threading.Tasks.Task<TamaWebApp.TamaService.Tamagotchi[]> GetAllTamagotchiAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamaLogic/UpdateTamagochi", ReplyAction="http://tempuri.org/ITamaLogic/UpdateTamagochiResponse")]
        bool UpdateTamagochi(int TamaID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamaLogic/UpdateTamagochi", ReplyAction="http://tempuri.org/ITamaLogic/UpdateTamagochiResponse")]
        System.Threading.Tasks.Task<bool> UpdateTamagochiAsync(int TamaID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamaLogic/FlipFlag", ReplyAction="http://tempuri.org/ITamaLogic/FlipFlagResponse")]
        bool FlipFlag(string name, int tamaID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamaLogic/FlipFlag", ReplyAction="http://tempuri.org/ITamaLogic/FlipFlagResponse")]
        System.Threading.Tasks.Task<bool> FlipFlagAsync(string name, int tamaID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamaLogic/Eat", ReplyAction="http://tempuri.org/ITamaLogic/EatResponse")]
        bool Eat(int TamaID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamaLogic/Eat", ReplyAction="http://tempuri.org/ITamaLogic/EatResponse")]
        System.Threading.Tasks.Task<bool> EatAsync(int TamaID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamaLogic/Sleep", ReplyAction="http://tempuri.org/ITamaLogic/SleepResponse")]
        bool Sleep(int TamaID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamaLogic/Sleep", ReplyAction="http://tempuri.org/ITamaLogic/SleepResponse")]
        System.Threading.Tasks.Task<bool> SleepAsync(int TamaID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamaLogic/Play", ReplyAction="http://tempuri.org/ITamaLogic/PlayResponse")]
        bool Play(int TamaID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamaLogic/Play", ReplyAction="http://tempuri.org/ITamaLogic/PlayResponse")]
        System.Threading.Tasks.Task<bool> PlayAsync(int TamaID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamaLogic/Workout", ReplyAction="http://tempuri.org/ITamaLogic/WorkoutResponse")]
        bool Workout(int TamaID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamaLogic/Workout", ReplyAction="http://tempuri.org/ITamaLogic/WorkoutResponse")]
        System.Threading.Tasks.Task<bool> WorkoutAsync(int TamaID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamaLogic/Hug", ReplyAction="http://tempuri.org/ITamaLogic/HugResponse")]
        bool Hug(int TamaID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamaLogic/Hug", ReplyAction="http://tempuri.org/ITamaLogic/HugResponse")]
        System.Threading.Tasks.Task<bool> HugAsync(int TamaID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamaLogic/GetStatus", ReplyAction="http://tempuri.org/ITamaLogic/GetStatusResponse")]
        string GetStatus(int tamaID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamaLogic/GetStatus", ReplyAction="http://tempuri.org/ITamaLogic/GetStatusResponse")]
        System.Threading.Tasks.Task<string> GetStatusAsync(int tamaID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamaLogic/SecTillAction", ReplyAction="http://tempuri.org/ITamaLogic/SecTillActionResponse")]
        int SecTillAction(int tamaID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITamaLogic/SecTillAction", ReplyAction="http://tempuri.org/ITamaLogic/SecTillActionResponse")]
        System.Threading.Tasks.Task<int> SecTillActionAsync(int tamaID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITamaLogicChannel : TamaWebApp.TamaService.ITamaLogic, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TamaLogicClient : System.ServiceModel.ClientBase<TamaWebApp.TamaService.ITamaLogic>, TamaWebApp.TamaService.ITamaLogic {
        
        public TamaLogicClient() {
        }
        
        public TamaLogicClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TamaLogicClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TamaLogicClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TamaLogicClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public TamaWebApp.TamaService.Tamagotchi GetTamagotchi(int TamaID) {
            return base.Channel.GetTamagotchi(TamaID);
        }
        
        public System.Threading.Tasks.Task<TamaWebApp.TamaService.Tamagotchi> GetTamagotchiAsync(int TamaID) {
            return base.Channel.GetTamagotchiAsync(TamaID);
        }
        
        public int AddTamagotchi(string name) {
            return base.Channel.AddTamagotchi(name);
        }
        
        public System.Threading.Tasks.Task<int> AddTamagotchiAsync(string name) {
            return base.Channel.AddTamagotchiAsync(name);
        }
        
        public TamaWebApp.TamaService.Tamagotchi[] GetAllTamagotchi() {
            return base.Channel.GetAllTamagotchi();
        }
        
        public System.Threading.Tasks.Task<TamaWebApp.TamaService.Tamagotchi[]> GetAllTamagotchiAsync() {
            return base.Channel.GetAllTamagotchiAsync();
        }
        
        public bool UpdateTamagochi(int TamaID) {
            return base.Channel.UpdateTamagochi(TamaID);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateTamagochiAsync(int TamaID) {
            return base.Channel.UpdateTamagochiAsync(TamaID);
        }
        
        public bool FlipFlag(string name, int tamaID) {
            return base.Channel.FlipFlag(name, tamaID);
        }
        
        public System.Threading.Tasks.Task<bool> FlipFlagAsync(string name, int tamaID) {
            return base.Channel.FlipFlagAsync(name, tamaID);
        }
        
        public bool Eat(int TamaID) {
            return base.Channel.Eat(TamaID);
        }
        
        public System.Threading.Tasks.Task<bool> EatAsync(int TamaID) {
            return base.Channel.EatAsync(TamaID);
        }
        
        public bool Sleep(int TamaID) {
            return base.Channel.Sleep(TamaID);
        }
        
        public System.Threading.Tasks.Task<bool> SleepAsync(int TamaID) {
            return base.Channel.SleepAsync(TamaID);
        }
        
        public bool Play(int TamaID) {
            return base.Channel.Play(TamaID);
        }
        
        public System.Threading.Tasks.Task<bool> PlayAsync(int TamaID) {
            return base.Channel.PlayAsync(TamaID);
        }
        
        public bool Workout(int TamaID) {
            return base.Channel.Workout(TamaID);
        }
        
        public System.Threading.Tasks.Task<bool> WorkoutAsync(int TamaID) {
            return base.Channel.WorkoutAsync(TamaID);
        }
        
        public bool Hug(int TamaID) {
            return base.Channel.Hug(TamaID);
        }
        
        public System.Threading.Tasks.Task<bool> HugAsync(int TamaID) {
            return base.Channel.HugAsync(TamaID);
        }
        
        public string GetStatus(int tamaID) {
            return base.Channel.GetStatus(tamaID);
        }
        
        public System.Threading.Tasks.Task<string> GetStatusAsync(int tamaID) {
            return base.Channel.GetStatusAsync(tamaID);
        }
        
        public int SecTillAction(int tamaID) {
            return base.Channel.SecTillAction(tamaID);
        }
        
        public System.Threading.Tasks.Task<int> SecTillActionAsync(int tamaID) {
            return base.Channel.SecTillActionAsync(tamaID);
        }
    }
}
