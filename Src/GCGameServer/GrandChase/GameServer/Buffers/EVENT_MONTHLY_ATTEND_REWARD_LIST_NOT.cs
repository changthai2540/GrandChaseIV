﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameServer.network;

namespace GameServer.Buffers
{
    class monthlyattend
    {
        public void attend(User user)
        {
            PacketManager Write = new PacketManager();
            Write.OP(264);
            Write.Hex("00 00 00 00 00 00 00");
            user.Send(Write.ack);
        }
    }
}