﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using NintrollerLib;

namespace WiinUPro
{
    [JsonObject]
    public class DevicePrefs
    {
        public string deviceId;
        public string defaultProfile;
        public bool autoConnect;
        public Dictionary<string, object> calibrations = new Dictionary<string, object>();
    }
}