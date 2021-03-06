﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClientSocket.Business;
using UnityEngine;
using MiniJSON;

namespace NetworkRequest
{
    class UserCheckResumePlayDecoder
    {
        public static void decode(string jsonInfo)
        {
            UserCheckResumePlayObject userCheckResumePlayObject = ModelManager.shareInstance().getUserCheckResumePlayObject();

            Dictionary<string, object> data = Json.Deserialize(jsonInfo) as Dictionary<string, object>;

            bool shouldResumePlay = Convert.ToBoolean(data["shouldResumePlay"]);
            userCheckResumePlayObject.setShouldResumePlay(shouldResumePlay);
        }
    }
}