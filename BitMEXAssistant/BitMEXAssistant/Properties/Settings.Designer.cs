﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BitMEXAssistant.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.7.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string APIKey {
            get {
                return ((string)(this["APIKey"]));
            }
            set {
                this["APIKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string APISecret {
            get {
                return ((string)(this["APISecret"]));
            }
            set {
                this["APISecret"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        public int DCAContracts {
            get {
                return ((int)(this["DCAContracts"]));
            }
            set {
                this["DCAContracts"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int DCAHours {
            get {
                return ((int)(this["DCAHours"]));
            }
            set {
                this["DCAHours"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int DCAMinutes {
            get {
                return ((int)(this["DCAMinutes"]));
            }
            set {
                this["DCAMinutes"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public int DCASeconds {
            get {
                return ((int)(this["DCASeconds"]));
            }
            set {
                this["DCASeconds"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public int DCATimes {
            get {
                return ((int)(this["DCATimes"]));
            }
            set {
                this["DCATimes"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DCAReduceOnly {
            get {
                return ((bool)(this["DCAReduceOnly"]));
            }
            set {
                this["DCAReduceOnly"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool DCAExecuteImmediately {
            get {
                return ((bool)(this["DCAExecuteImmediately"]));
            }
            set {
                this["DCAExecuteImmediately"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool OverloadRetry {
            get {
                return ((bool)(this["OverloadRetry"]));
            }
            set {
                this["OverloadRetry"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int OverloadRetryAttempts {
            get {
                return ((int)(this["OverloadRetryAttempts"]));
            }
            set {
                this["OverloadRetryAttempts"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("500")]
        public int RetryAttemptWaitTime {
            get {
                return ((int)(this["RetryAttemptWaitTime"]));
            }
            set {
                this["RetryAttemptWaitTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public int SpreadBuyOrders {
            get {
                return ((int)(this["SpreadBuyOrders"]));
            }
            set {
                this["SpreadBuyOrders"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public int SpreadSellOrders {
            get {
                return ((int)(this["SpreadSellOrders"]));
            }
            set {
                this["SpreadSellOrders"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("25.0")]
        public decimal SpreadBuyValueApart {
            get {
                return ((decimal)(this["SpreadBuyValueApart"]));
            }
            set {
                this["SpreadBuyValueApart"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("25.0")]
        public decimal SpreadSellValueApart {
            get {
                return ((decimal)(this["SpreadSellValueApart"]));
            }
            set {
                this["SpreadSellValueApart"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("50")]
        public int SpreadBuyContractsEach {
            get {
                return ((int)(this["SpreadBuyContractsEach"]));
            }
            set {
                this["SpreadBuyContractsEach"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("50")]
        public int SpreadSellContractsEach {
            get {
                return ((int)(this["SpreadSellContractsEach"]));
            }
            set {
                this["SpreadSellContractsEach"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SpreadBuyReduceOnly {
            get {
                return ((bool)(this["SpreadBuyReduceOnly"]));
            }
            set {
                this["SpreadBuyReduceOnly"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SpreadSellReduceOnly {
            get {
                return ((bool)(this["SpreadSellReduceOnly"]));
            }
            set {
                this["SpreadSellReduceOnly"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SpreadBuyPostOnly {
            get {
                return ((bool)(this["SpreadBuyPostOnly"]));
            }
            set {
                this["SpreadBuyPostOnly"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SpreadSellPostOnly {
            get {
                return ((bool)(this["SpreadSellPostOnly"]));
            }
            set {
                this["SpreadSellPostOnly"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SpreadBuyExecute {
            get {
                return ((bool)(this["SpreadBuyExecute"]));
            }
            set {
                this["SpreadBuyExecute"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SpreadSellExecute {
            get {
                return ((bool)(this["SpreadSellExecute"]));
            }
            set {
                this["SpreadSellExecute"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SpreadCancelBeforeOrdering {
            get {
                return ((bool)(this["SpreadCancelBeforeOrdering"]));
            }
            set {
                this["SpreadCancelBeforeOrdering"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Real")]
        public string Network {
            get {
                return ((string)(this["Network"]));
            }
            set {
                this["Network"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string TestAPIKey {
            get {
                return ((string)(this["TestAPIKey"]));
            }
            set {
                this["TestAPIKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string TestAPISecret {
            get {
                return ((string)(this["TestAPISecret"]));
            }
            set {
                this["TestAPISecret"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Consent {
            get {
                return ((bool)(this["Consent"]));
            }
            set {
                this["Consent"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int ManualMarketContracts {
            get {
                return ((int)(this["ManualMarketContracts"]));
            }
            set {
                this["ManualMarketContracts"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ManualMarketReduceOnly {
            get {
                return ((bool)(this["ManualMarketReduceOnly"]));
            }
            set {
                this["ManualMarketReduceOnly"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int ManualLimitContracts {
            get {
                return ((int)(this["ManualLimitContracts"]));
            }
            set {
                this["ManualLimitContracts"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public decimal ManualLimitPrice {
            get {
                return ((decimal)(this["ManualLimitPrice"]));
            }
            set {
                this["ManualLimitPrice"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ManualLimitReduceOnly {
            get {
                return ((bool)(this["ManualLimitReduceOnly"]));
            }
            set {
                this["ManualLimitReduceOnly"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ManualLimitPostOnly {
            get {
                return ((bool)(this["ManualLimitPostOnly"]));
            }
            set {
                this["ManualLimitPostOnly"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ManualLimitCancelOpenOrders {
            get {
                return ((bool)(this["ManualLimitCancelOpenOrders"]));
            }
            set {
                this["ManualLimitCancelOpenOrders"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ManualLimitHiddenOrder {
            get {
                return ((bool)(this["ManualLimitHiddenOrder"]));
            }
            set {
                this["ManualLimitHiddenOrder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.25")]
        public decimal ManualLimitPercentModifier1 {
            get {
                return ((decimal)(this["ManualLimitPercentModifier1"]));
            }
            set {
                this["ManualLimitPercentModifier1"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.5")]
        public decimal ManualLimitPercentModifier2 {
            get {
                return ((decimal)(this["ManualLimitPercentModifier2"]));
            }
            set {
                this["ManualLimitPercentModifier2"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public decimal ManualLimitPercentModifier3 {
            get {
                return ((decimal)(this["ManualLimitPercentModifier3"]));
            }
            set {
                this["ManualLimitPercentModifier3"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2.5")]
        public decimal ManualLimitPercentModifier4 {
            get {
                return ((decimal)(this["ManualLimitPercentModifier4"]));
            }
            set {
                this["ManualLimitPercentModifier4"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ManualLimitPercentModifierUseCurrentPrice {
            get {
                return ((bool)(this["ManualLimitPercentModifierUseCurrentPrice"]));
            }
            set {
                this["ManualLimitPercentModifierUseCurrentPrice"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int LimitNowBuyContracts {
            get {
                return ((int)(this["LimitNowBuyContracts"]));
            }
            set {
                this["LimitNowBuyContracts"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int LimitNowBuyTicksFromCenter {
            get {
                return ((int)(this["LimitNowBuyTicksFromCenter"]));
            }
            set {
                this["LimitNowBuyTicksFromCenter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1000")]
        public int LimitNowBuyDelay {
            get {
                return ((int)(this["LimitNowBuyDelay"]));
            }
            set {
                this["LimitNowBuyDelay"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool LimitNowBuyContinue {
            get {
                return ((bool)(this["LimitNowBuyContinue"]));
            }
            set {
                this["LimitNowBuyContinue"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int LimitNowSellContracts {
            get {
                return ((int)(this["LimitNowSellContracts"]));
            }
            set {
                this["LimitNowSellContracts"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int LimitNowSellTicksFromCenter {
            get {
                return ((int)(this["LimitNowSellTicksFromCenter"]));
            }
            set {
                this["LimitNowSellTicksFromCenter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1000")]
        public int LimitNowSellDelay {
            get {
                return ((int)(this["LimitNowSellDelay"]));
            }
            set {
                this["LimitNowSellDelay"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool LimitNowSellContinue {
            get {
                return ((bool)(this["LimitNowSellContinue"]));
            }
            set {
                this["LimitNowSellContinue"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Best Price")]
        public string LimitNowBuyMethod {
            get {
                return ((string)(this["LimitNowBuyMethod"]));
            }
            set {
                this["LimitNowBuyMethod"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Best Price")]
        public string LimitNowSellMethod {
            get {
                return ((string)(this["LimitNowSellMethod"]));
            }
            set {
                this["LimitNowSellMethod"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool LimitNowBuyReduceOnly {
            get {
                return ((bool)(this["LimitNowBuyReduceOnly"]));
            }
            set {
                this["LimitNowBuyReduceOnly"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool LimitNowSellReduceOnly {
            get {
                return ((bool)(this["LimitNowSellReduceOnly"]));
            }
            set {
                this["LimitNowSellReduceOnly"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int TrailingStopContracts {
            get {
                return ((int)(this["TrailingStopContracts"]));
            }
            set {
                this["TrailingStopContracts"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public decimal TrailingStopTrail {
            get {
                return ((decimal)(this["TrailingStopTrail"]));
            }
            set {
                this["TrailingStopTrail"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Limit")]
        public string TrailingStopMethod {
            get {
                return ((string)(this["TrailingStopMethod"]));
            }
            set {
                this["TrailingStopMethod"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public decimal TrailingStopLimitOffset {
            get {
                return ((decimal)(this["TrailingStopLimitOffset"]));
            }
            set {
                this["TrailingStopLimitOffset"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool TrailingStopCloseInFull {
            get {
                return ((bool)(this["TrailingStopCloseInFull"]));
            }
            set {
                this["TrailingStopCloseInFull"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public decimal XBTUSDReferencePrice {
            get {
                return ((decimal)(this["XBTUSDReferencePrice"]));
            }
            set {
                this["XBTUSDReferencePrice"] = value;
            }
        }
    }
}
