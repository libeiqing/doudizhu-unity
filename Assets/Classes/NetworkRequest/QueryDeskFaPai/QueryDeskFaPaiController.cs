﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClientSocket.Business;
using UnityEngine;

namespace NetworkRequest
{
    class QueryDeskFaPaiController : ISocketResponse
    {
        public void onReceiveData(short cmd, string response)
        {
            if (cmd == SocketConst.CMD_QUERY_DESK_FA_PAI)
            {
                QueryDeskFaPaiDecoder.decode(response);
                ReceivedDataStatusQueue.shareInstance().addStatus(cmd);
            }
        }
    }
}