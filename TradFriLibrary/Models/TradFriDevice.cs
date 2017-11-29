﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TradFriLibrary.Extensions;

namespace TradFriLibrary.Models
{
    public enum DeviceType
    {
        Remote = 0,
        Unknown_1 = 1,
        Light = 2,
        Unknown_2 = 3,
    }
    public class TradFriDevice
    {
        [JsonProperty("15009")]
        public List<RootSwitch> RootSwitch { get; set; }

        [JsonProperty("3")]
        public DeviceInfo Info { get; set; }

        //0 - remote, 2 - light
        [JsonProperty("5750")]
        public DeviceType ApplicationType { get; set; }

        [JsonProperty("9001")]
        public string Name { get; set; }

        [JsonProperty("9002")]
        [JsonConverter(typeof(MicrosecondEpochConverter))]
        public DateTime CreatedAt { get; set; }
       
        [JsonProperty("9003")]
        public long ID { get; set; }

        [JsonProperty("9019")]
        public long ReachableState { get; set; }

        [JsonProperty("9020")]
        [JsonConverter(typeof(MicrosecondEpochConverter))]
        public DateTime LastSeen { get; set; }

        [JsonProperty("9054")]
        public long OtaUpdateState { get; set; }

        [JsonProperty("3311")]
        public List<LightControl> LightControl { get; set; }
    }

    public class DeviceInfo
    {
        [JsonProperty("0")]
        public string Manufacturer { get; set; }

        [JsonProperty("1")]
        public string DeviceType { get; set; }

        [JsonProperty("2")]
        public string Serial { get; set; }

        [JsonProperty("3")]
        public string FirmwareVersion { get; set; }

        [JsonProperty("6")]
        public long PowerSource { get; set; }

        [JsonProperty("9")]
        public long Battery { get; set; }
    }

    public class RootSwitch
    {
        [JsonProperty("9003")]
        public long RootSwitchID { get; set; }
    }

    public class LightControl
    {
        [JsonProperty("5706")]
        public string ColorHex { get; set; }

        [JsonProperty("5709")]
        public long ColorX { get; set; }

        [JsonProperty("5710")]
        public long ColorY { get; set; }
        
        [JsonProperty("5711")]
        public long Mireds { get; set; }

        [JsonProperty("5850")]
        public Bool State { get; set; }

        [JsonProperty("5851")]
        public long Dimmer { get; set; }

        [JsonProperty("9003")]
        public long ID { get; set; }
    }

    public class DeviceList
    {
        [JsonProperty("9003")]
        public List<long> DevicesIds { get; set; }
    }
}