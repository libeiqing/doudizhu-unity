﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClientSocket.Business;
using UnityEngine;
using MiniJSON;

namespace NetworkRequest
{
    class UserLoginEncoder
    {
        public static string encode(string userName, string password)
        {
            string deviceName = DeviceInfoHelper.getDeviceName();
            string osName = DeviceInfoHelper.getOsName();
            string osVersion = DeviceInfoHelper.getOsVersion();
            string appId = DeviceInfoHelper.getAppId();
            string deviceId = DeviceInfoHelper.getDeviceId();
            string appVersion = DeviceInfoHelper.getAppVersion();

            Dictionary<string, object> dict = new Dictionary<string, object>();

            dict["userName"] = userName;
            dict["password"] = password;

            dict["deviceName"] = deviceName;
            dict["osName"] = osName;
            dict["osVersion"] = osVersion;
            dict["deviceId"] = deviceId;

            dict["appId"] = appId;
            dict["appVersion"] = appVersion;

            return Json.Serialize(dict);
        }
    }
}