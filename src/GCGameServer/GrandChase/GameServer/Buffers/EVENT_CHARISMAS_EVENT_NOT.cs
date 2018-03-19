﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameServer.network;

namespace GameServer.Buffers
{
    class Charismas
    {
        public void charismas(User user)
        {
            PacketManager Write = new PacketManager();
            Write.OP(1266);
            Write.Hex("00 0D EA 26 00 00 00 09 00 0B E5 82 00 00 00 01 FF FF FF FF 00 FF 00 00 00 00 00 01 00 00 00 01 00 0B E5 8C 00 00 00 01 FF FF FF FF 00 FF 00 00 00 00 00 0A 00 00 00 0A 00 0B E5 AA 00 00 00 01 FF FF FF FF 00 FF 00 00 00 00 00 14 00 00 00 14 00 0B E5 B4 00 00 00 01 FF FF FF FF 00 FF 00 00 00 00 00 0A 00 00 00 0A 00 0C E4 FA 00 00 00 01 FF FF FF FF 00 FF 00 00 00 00 00 14 00 00 00 14 00 0C E5 04 00 00 00 01 FF FF FF FF 00 FF 00 00 00 00 00 28 00 00 00 28 00 0C E5 18 00 00 00 01 FF FF FF FF 00 FF 00 00 00 00 00 14 00 00 00 14 00 0C E5 22 00 00 00 01 FF FF FF FF 00 FF 00 00 00 00 00 19 00 00 00 19 00 0C E5 2C 00 00 00 01 FF FF FF FF 00 FF 00 00 00 00 00 19 00 00 00 19 00 00 00 12 00 00 00 0A 00 00 00 0B 00 00 00 14 00 00 00 16 00 00 00 1E 00 00 00 21 00 00 00 28 00 00 00 2C 00 00 00 32 00 00 00 37 00 00 00 3C 00 00 00 42 00 00 00 46 00 00 00 4D 00 00 00 50 00 00 00 58 00 00 00 5A 00 00 00 63 00 00 00 64 00 00 00 6E 00 00 00 6E 00 00 00 79 00 00 00 78 00 00 00 84 00 00 00 82 00 00 00 8F 00 00 00 8C 00 00 00 9A 00 00 00 96 00 00 00 A5 00 00 00 A0 00 00 00 B0 00 00 00 AA 00 00 00 BB 00 00 00 B4 00 00 00 C6 00 00 00 07 00 00 00 01 00 00 00 01 00 0B E5 BE 00 00 00 01 FF FF FF FF 00 FF 00 00 00 00 00 02 00 00 00 01 00 0B E5 C8 00 00 00 01 FF FF FF FF 00 FF 00 00 00 00 00 03 00 00 00 01 00 0B E5 D2 00 00 00 01 FF FF FF FF 00 FF 00 00 00 00 00 04 00 00 00 01 00 0B E5 DC 00 00 00 01 FF FF FF FF 00 FF 00 00 00 00 00 05 00 00 00 01 00 0B E5 AA 00 00 00 01 FF FF FF FF 00 FF 00 00 00 00 00 06 00 00 00 01 00 0D EA A8 00 00 00 01 FF FF FF FF 00 FF 00 00 00 00 00 07 00 00 00 01 00 0D EA B2 00 00 00 01 FF FF FF FF 00 FF 00 00 00 00 00 07 00 00 00 01 00 00 00 00 00 00 00 1E 00 00 00 02 00 00 00 1F 00 00 00 3C 00 00 00 03 00 00 00 3D 00 00 00 5A 00 00 00 04 00 00 00 5B 00 00 00 78 00 00 00 05 00 00 00 79 00 00 00 96 00 00 00 06 00 00 00 97 00 00 00 B4 00 00 00 07 00 00 00 B5 00 00 00 D2 00 00 00 00 01 02 03 04 04 05 B4 00 00 09 2C 00 00 00 00 12 00 00 00 00 0E 00 0F 42 54 00 00 00 50 00 12 C8 FC 00 00 00 00 00 0F 42 FE 00 00 00 50 00 12 D3 74 00 00 00 50 00 12 D3 7E 00 00 00 50 00 12 D3 88 00 00 00 50 00 12 D3 92 00 00 00 50 00 12 D3 9C 00 00 00 50 00 12 D3 A6 00 00 00 50 00 12 DA 36 00 00 00 50 00 12 DA 40 00 00 00 50 00 12 DA 4A 00 00 00 50 00 12 DA 54 00 00 00 50 00 12 DD 06 00 00 00 50 01 00 00 00 0E 00 0F 42 5E 00 00 00 50 00 12 C8 FC 00 00 00 00 00 0F 43 08 00 00 00 50 00 12 D3 BA 00 00 00 50 00 12 D3 C4 00 00 00 50 00 12 D3 CE 00 00 00 50 00 12 D3 D8 00 00 00 50 00 12 D3 E2 00 00 00 50 00 12 D3 EC 00 00 00 50 00 12 DA 5E 00 00 00 50 00 12 DA 68 00 00 00 50 00 12 DA 72 00 00 00 50 00 12 DA 7C 00 00 00 50 00 12 DD 10 00 00 00 50 02 00 00 00 0E 00 0F 42 68 00 00 00 50 00 12 C8 FC 00 00 00 00 00 0F 43 12 00 00 00 50 00 12 D4 00 00 00 00 50 00 12 D4 0A 00 00 00 50 00 12 D4 14 00 00 00 50 00 12 D4 1E 00 00 00 50 00 12 D4 28 00 00 00 50 00 12 D4 32 00 00 00 50 00 12 DA 86 00 00 00 50 00 12 DA 90 00 00 00 50 00 12 DA 9A 00 00 00 50 00 12 DA A4 00 00 00 50 00 12 DD 1A 00 00 00 50 03 00 00 00 0E 00 0F 42 72 00 00 00 50 00 12 C8 FC 00 00 00 00 00 0F 43 1C 00 00 00 50 00 12 D4 46 00 00 00 50 00 12 D4 50 00 00 00 50 00 12 D4 5A 00 00 00 50 00 12 D4 64 00 00 00 50 00 12 D4 6E 00 00 00 50 00 12 D4 78 00 00 00 50 00 12 DA AE 00 00 00 50 00 12 DA B8 00 00 00 50 00 12 DA C2 00 00 00 50 00 12 DA CC 00 00 00 50 00 12 DD 24 00 00 00 50 04 00 00 00 0E 00 0F 42 7C 00 00 00 50 00 12 C8 FC 00 00 00 00 00 0F 43 26 00 00 00 50 00 12 D4 8C 00 00 00 50 00 12 D4 96 00 00 00 50 00 12 D4 A0 00 00 00 50 00 12 D4 AA 00 00 00 50 00 12 D4 B4 00 00 00 50 00 12 D4 BE 00 00 00 50 00 12 DA D6 00 00 00 50 00 12 DA E0 00 00 00 50 00 12 DA EA 00 00 00 50 00 12 DA F4 00 00 00 50 00 12 DD 2E 00 00 00 50 05 00 00 00 0E 00 0F 42 86 00 00 00 50 00 12 C8 FC 00 00 00 00 00 0F 43 30 00 00 00 50 00 12 D4 D2 00 00 00 50 00 12 D4 DC 00 00 00 50 00 12 D4 E6 00 00 00 50 00 12 D4 F0 00 00 00 50 00 12 D4 FA 00 00 00 50 00 12 D5 04 00 00 00 50 00 12 DA FE 00 00 00 50 00 12 DB 08 00 00 00 50 00 12 DB 12 00 00 00 50 00 12 DB 1C 00 00 00 50 00 12 DD 38 00 00 00 50 06 00 00 00 0E 00 0F 42 90 00 00 00 50 00 12 C8 FC 00 00 00 00 00 0F 43 3A 00 00 00 50 00 12 D5 18 00 00 00 50 00 12 D5 22 00 00 00 50 00 12 D5 2C 00 00 00 50 00 12 D5 36 00 00 00 50 00 12 D5 40 00 00 00 50 00 12 D5 4A 00 00 00 50 00 12 DB 26 00 00 00 50 00 12 DB 30 00 00 00 50 00 12 DB 3A 00 00 00 50 00 12 DB 44 00 00 00 50 00 12 DD 42 00 00 00 50 07 00 00 00 0E 00 0F 42 9A 00 00 00 50 00 12 C8 FC 00 00 00 00 00 0F 43 44 00 00 00 50 00 12 D5 5E 00 00 00 50 00 12 D5 68 00 00 00 50 00 12 D5 72 00 00 00 50 00 12 D5 7C 00 00 00 50 00 12 D5 86 00 00 00 50 00 12 D5 90 00 00 00 50 00 12 DB 4E 00 00 00 50 00 12 DB 58 00 00 00 50 00 12 DB 62 00 00 00 50 00 12 DB 6C 00 00 00 50 00 12 DD 4C 00 00 00 50 08 00 00 00 0E 00 0F 42 A4 00 00 00 50 00 12 C8 FC 00 00 00 00 00 0F 43 4E 00 00 00 50 00 12 D5 A4 00 00 00 50 00 12 D5 AE 00 00 00 50 00 12 D5 B8 00 00 00 50 00 12 D5 C2 00 00 00 50 00 12 D5 CC 00 00 00 50 00 12 D5 D6 00 00 00 50 00 12 DB 76 00 00 00 50 00 12 DB 80 00 00 00 50 00 12 DB 8A 00 00 00 50 00 12 DB 94 00 00 00 50 00 12 DD 56 00 00 00 50 09 00 00 00 0E 00 0F 42 AE 00 00 00 50 00 12 C8 FC 00 00 00 00 00 0F 43 58 00 00 00 50 00 12 D5 EA 00 00 00 50 00 12 D5 F4 00 00 00 50 00 12 D5 FE 00 00 00 50 00 12 D6 08 00 00 00 50 00 12 D6 12 00 00 00 50 00 12 D6 1C 00 00 00 50 00 12 DB 9E 00 00 00 50 00 12 DB A8 00 00 00 50 00 12 DB B2 00 00 00 50 00 12 DB BC 00 00 00 50 00 12 DD 60 00 00 00 50 0A 00 00 00 0E 00 0F 42 B8 00 00 00 50 00 12 C8 FC 00 00 00 00 00 0F 43 62 00 00 00 50 00 12 D6 30 00 00 00 50 00 12 D6 3A 00 00 00 50 00 12 D6 44 00 00 00 50 00 12 D6 4E 00 00 00 50 00 12 D6 58 00 00 00 50 00 12 D6 62 00 00 00 50 00 12 DB C6 00 00 00 50 00 12 DB D0 00 00 00 50 00 12 DB DA 00 00 00 50 00 12 DB E4 00 00 00 50 00 12 DD 6A 00 00 00 50 0B 00 00 00 0E 00 0F 42 C2 00 00 00 50 00 12 C8 FC 00 00 00 00 00 0F 43 6C 00 00 00 50 00 12 D6 76 00 00 00 50 00 12 D6 80 00 00 00 50 00 12 D6 8A 00 00 00 50 00 12 D6 94 00 00 00 50 00 12 D6 9E 00 00 00 50 00 12 D6 A8 00 00 00 50 00 12 DB EE 00 00 00 50 00 12 DB F8 00 00 00 50 00 12 DC 02 00 00 00 50 00 12 DC 0C 00 00 00 50 00 12 DD 74 00 00 00 50 0C 00 00 00 0E 00 0F 42 CC 00 00 00 50 00 12 C8 FC 00 00 00 00 00 0F 43 76 00 00 00 50 00 12 D6 BC 00 00 00 50 00 12 D6 C6 00 00 00 50 00 12 D6 D0 00 00 00 50 00 12 D6 DA 00 00 00 50 00 12 D6 E4 00 00 00 50 00 12 D6 EE 00 00 00 50 00 12 DC 16 00 00 00 50 00 12 DC 20 00 00 00 50 00 12 DC 2A 00 00 00 50 00 12 DC 34 00 00 00 50 00 12 DD 7E 00 00 00 50 0D 00 00 00 0E 00 0F 42 D6 00 00 00 50 00 12 C8 FC 00 00 00 00 00 0F 43 80 00 00 00 50 00 12 D7 02 00 00 00 50 00 12 D7 0C 00 00 00 50 00 12 D7 16 00 00 00 50 00 12 D7 20 00 00 00 50 00 12 D7 2A 00 00 00 50 00 12 D7 34 00 00 00 50 00 12 DC 3E 00 00 00 50 00 12 DC 48 00 00 00 50 00 12 DC 52 00 00 00 50 00 12 DC 5C 00 00 00 50 00 12 DD 88 00 00 00 50 0E 00 00 00 0E 00 0F 42 E0 00 00 00 50 00 12 C8 FC 00 00 00 00 00 0F 43 8A 00 00 00 50 00 12 D7 48 00 00 00 50 00 12 D7 52 00 00 00 50 00 12 D7 5C 00 00 00 50 00 12 D7 66 00 00 00 50 00 12 D7 70 00 00 00 50 00 12 D7 7A 00 00 00 50 00 12 DC 66 00 00 00 50 00 12 DC 70 00 00 00 50 00 12 DC 7A 00 00 00 50 00 12 DC 84 00 00 00 50 00 12 DD 92 00 00 00 50 0F 00 00 00 0E 00 0F 42 EA 00 00 00 50 00 12 C8 FC 00 00 00 00 00 0F 43 94 00 00 00 50 00 12 D7 8E 00 00 00 50 00 12 D7 98 00 00 00 50 00 12 D7 A2 00 00 00 50 00 12 D7 AC 00 00 00 50 00 12 D7 B6 00 00 00 50 00 12 D7 C0 00 00 00 50 00 12 DC 8E 00 00 00 50 00 12 DC 98 00 00 00 50 00 12 DC A2 00 00 00 50 00 12 DC AC 00 00 00 50 00 12 DD 9C 00 00 00 50 10 00 00 00 0E 00 0F 42 F4 00 00 00 50 00 12 C8 FC 00 00 00 00 00 0F 43 9E 00 00 00 50 00 12 D7 D4 00 00 00 50 00 12 D7 DE 00 00 00 50 00 12 D7 E8 00 00 00 50 00 12 D7 F2 00 00 00 50 00 12 D7 FC 00 00 00 50 00 12 D8 06 00 00 00 50 00 12 DC B6 00 00 00 50 00 12 DC C0 00 00 00 50 00 12 DC CA 00 00 00 50 00 12 DC D4 00 00 00 50 00 12 DD A6 00 00 00 50 11 00 00 00 0E 00 13 0C 90 00 00 00 50 00 12 C8 FC 00 00 00 00 00 13 0C 9A 00 00 00 50 00 12 D8 1A 00 00 00 50 00 12 D8 24 00 00 00 50 00 12 D8 2E 00 00 00 50 00 12 D8 38 00 00 00 50 00 12 D8 42 00 00 00 50 00 12 D8 4C 00 00 00 50 00 12 DC DE 00 00 00 50 00 12 DC E8 00 00 00 50 00 12 DC F2 00 00 00 50 00 12 DC FC 00 00 00 50 00 12 DD B0 00 00 00 50 00 00 00 12 00 00 00 00 01 00 0F 43 A8 00 00 00 50 01 00 00 00 01 00 0F 43 A8 00 00 00 50 02 00 00 00 01 00 0F 43 A8 00 00 00 50 03 00 00 00 01 00 0F 43 A8 00 00 00 50 04 00 00 00 01 00 0F 43 A8 00 00 00 50 05 00 00 00 01 00 0F 43 A8 00 00 00 50 06 00 00 00 01 00 0F 43 A8 00 00 00 50 07 00 00 00 01 00 0F 43 A8 00 00 00 50 08 00 00 00 01 00 0F 43 A8 00 00 00 50 09 00 00 00 01 00 0F 43 A8 00 00 00 50 0A 00 00 00 01 00 0F 43 A8 00 00 00 50 0B 00 00 00 01 00 0F 43 A8 00 00 00 50 0C 00 00 00 01 00 0F 43 A8 00 00 00 50 0D 00 00 00 01 00 0F 43 A8 00 00 00 50 0E 00 00 00 01 00 0F 43 A8 00 00 00 50 0F 00 00 00 01 00 0F 43 A8 00 00 00 50 10 00 00 00 01 00 0F 43 A8 00 00 00 50 11 00 00 00 01 00 0F 43 A8 00 00 00 50 00 00 00");
            user.Send(Write.ack);
        }
    }
}