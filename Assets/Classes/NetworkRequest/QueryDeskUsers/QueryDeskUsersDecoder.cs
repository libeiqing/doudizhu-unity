﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClientSocket.Business;
using UnityEngine;
using MiniJSON;

namespace NetworkRequest
{
    class QueryDeskUsersDecoder
    {
        public static void decode(string jsonInfo)
        {
            UserSitOnDeskDecoder.decode(jsonInfo);
        }
    }
}