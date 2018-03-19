﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameServer.network;

namespace GameServer.Buffers
{
    class herodungeon
    {
        public void info(User user)
        {
            PacketManager Write = new PacketManager();
            Write.OP(882);
            Write.Hex("00 05 86 60 00 00 00 04 00 00 00 3E 00 00 00 01 00 00 00 28 00 02 00 00 00 14 00 00 59 0E C5 F0 59 0E CC F8 00 01 59 0E D4 00 59 0E DB 08 00 02 59 0E DB 08 59 0E E2 10 00 03 59 0E F0 20 59 0E F7 28 00 04 59 0F 05 38 59 0F 0C 40 00 05 59 0F 1A 50 59 0F 21 58 00 06 59 0F 2F 68 59 0F 36 70 00 07 59 0F 44 80 59 0F 4B 88 00 08 59 0F 59 98 59 0F 60 A0 00 09 59 0F 6E B0 59 0F 75 B8 00 0A 59 0F 83 C8 59 0F 8A D0 00 0B 59 0F 98 E0 59 0F 9F E8 00 0C 59 0F AD F8 59 0F B5 00 00 0D 59 0F C3 10 59 0F CA 18 00 0E 59 0F CA 18 59 0F D1 20 00 0F 59 0F D8 28 59 0F DF 30 00 10 59 0F DF 30 59 0F E6 38 00 11 59 0F E6 38 59 0F ED 40 00 12 59 0F ED 40 59 0F F4 48 00 13 59 10 02 58 59 10 09 60 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 11 00 00 00 3F 00 00 00 01 00 00 00 1E 00 02 00 00 00 11 00 00 59 0E C5 F0 59 0E CC F8 00 01 59 0E D4 00 59 0E DB 08 00 02 59 0E DB 08 59 0E E2 10 00 03 59 0E F0 20 59 0E F7 28 00 04 59 0F 05 38 59 0F 0C 40 00 05 59 0F 1A 50 59 0F 21 58 00 06 59 0F 2F 68 59 0F 36 70 00 07 59 0F 44 80 59 0F 4B 88 00 08 59 0F 59 98 59 0F 60 A0 00 09 59 0F 6E B0 59 0F 75 B8 00 0A 59 0F 83 C8 59 0F 8A D0 00 0B 59 0F 98 E0 59 0F 9F E8 00 0C 59 0F AD F8 59 0F B5 00 00 0D 59 0F C3 10 59 0F CA 18 00 0E 59 0F D8 28 59 0F DF 30 00 0F 59 0F ED 40 59 0F F4 48 00 10 59 10 02 58 59 10 09 60 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 11 00 00 00 46 00 00 00 01 00 00 00 4B 00 03 00 00 00 18 00 00 59 0E CC F8 59 0E D1 A8 00 01 59 0E DB 08 59 0E DF B8 00 02 59 0E E9 18 59 0E ED C8 00 03 59 0E F7 28 59 0E FB D8 00 04 59 0F 05 38 59 0F 09 E8 00 05 59 0F 13 48 59 0F 17 F8 00 06 59 0F 21 58 59 0F 26 08 00 07 59 0F 2F 68 59 0F 34 18 00 08 59 0F 3D 78 59 0F 42 28 00 09 59 0F 4B 88 59 0F 50 38 00 0A 59 0F 59 98 59 0F 5E 48 00 0B 59 0F 67 A8 59 0F 6C 58 00 0C 59 0F 75 B8 59 0F 7A 68 00 0D 59 0F 83 C8 59 0F 88 78 00 0E 59 0F 91 D8 59 0F 96 88 00 0F 59 0F 9F E8 59 0F A4 98 00 10 59 0F AD F8 59 0F B2 A8 00 11 59 0F BC 08 59 0F C0 B8 00 12 59 0F CA 18 59 0F CE C8 00 13 59 0F D8 28 59 0F DC D8 00 14 59 0F E6 38 59 0F EA E8 00 15 59 0F F4 48 59 0F F8 F8 00 16 59 10 02 58 59 10 07 08 00 17 59 10 10 68 59 10 15 18 00 00 00 65 01 01 00 01 00 00 00 5F 00 00 00 0D 74 74 00 00 00 0D 74 74 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 01 00 0D 74 7E 00 00 00 0D 74 7E FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 02 00 0D 74 88 00 00 00 0D 74 88 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 03 00 0D 74 92 00 00 00 0D 74 92 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 04 00 0D 74 9C 00 00 00 0D 74 9C FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 05 00 0D 74 A6 00 00 00 0D 74 A6 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 06 00 0D 74 B0 00 00 00 0D 74 B0 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 07 00 0D 74 BA 00 00 00 0D 74 BA FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 08 00 0D 74 C4 00 00 00 0D 74 C4 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 09 00 0D 74 CE 00 00 00 0D 74 CE FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 0A 00 0D 74 D8 00 00 00 0D 74 D8 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 0B 00 0D 74 E2 00 00 00 0D 74 E2 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 0C 00 0D 74 EC 00 00 00 0D 74 EC FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 0D 00 0D 74 F6 00 00 00 0D 74 F6 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 0E 00 0D 75 00 00 00 00 0D 75 00 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 0F 00 0D 75 0A 00 00 00 0D 75 0A FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 10 00 0D 75 14 00 00 00 0D 75 14 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 11 00 0D 75 1E 00 00 00 0D 75 1E FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 12 00 0D 75 28 00 00 00 0D 75 28 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 13 00 0D 75 32 00 00 00 0D 75 32 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 14 00 0D 75 3C 00 00 00 0D 75 3C FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 15 00 0D 75 46 00 00 00 0D 75 46 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 16 00 0D 75 50 00 00 00 0D 75 50 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 17 00 0D 75 5A 00 00 00 0D 75 5A FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 18 00 0D 75 64 00 00 00 0D 75 64 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 19 00 0D 75 6E 00 00 00 0D 75 6E FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 1A 00 0D 75 78 00 00 00 0D 75 78 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 1B 00 0D 75 82 00 00 00 0D 75 82 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 1C 00 0D 75 8C 00 00 00 0D 75 8C FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 1D 00 0D 75 96 00 00 00 0D 75 96 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 1E 00 0D 75 A0 00 00 00 0D 75 A0 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 1F 00 0D 75 AA 00 00 00 0D 75 AA FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 20 00 0D 75 B4 00 00 00 0D 75 B4 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 21 00 0D 75 BE 00 00 00 0D 75 BE FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 22 00 0D 75 C8 00 00 00 0D 75 C8 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 23 00 0D 75 D2 00 00 00 0D 75 D2 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 24 00 0D 75 DC 00 00 00 0D 75 DC FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 25 00 0D 75 E6 00 00 00 0D 75 E6 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 26 00 0D 75 F0 00 00 00 0D 75 F0 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 27 00 0D 75 FA 00 00 00 0D 75 FA FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 28 00 0D 76 04 00 00 00 0D 76 04 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 29 00 0D 76 0E 00 00 00 0D 76 0E FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 2A 00 0D 76 18 00 00 00 0D 76 18 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 2B 00 0D 76 22 00 00 00 0D 76 22 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 2C 00 0D 76 2C 00 00 00 0D 76 2C FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 2D 00 0D 76 36 00 00 00 0D 76 36 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 2E 00 0D 76 40 00 00 00 0D 76 40 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 2F 00 0D 76 4A 00 00 00 0D 76 4A FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 30 00 0D 76 54 00 00 00 0D 76 54 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 31 00 0D 76 5E 00 00 00 0D 76 5E FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 32 00 0D 76 68 00 00 00 0D 76 68 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 33 00 0D 76 72 00 00 00 0D 76 72 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 34 00 0D 76 7C 00 00 00 0D 76 7C FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 35 00 0D 76 86 00 00 00 0D 76 86 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 36 00 0D 76 90 00 00 00 0D 76 90 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 37 00 0D 76 9A 00 00 00 0D 76 9A FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 38 00 0C 05 30 00 00 00 0C 05 30 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 39 00 0C 05 3A 00 00 00 0C 05 3A FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 3A 00 0C 05 44 00 00 00 0C 05 44 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 3B 00 0C 05 4E 00 00 00 0C 05 4E FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 3C 00 0C 05 58 00 00 00 0C 05 58 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 3D 00 0C 05 62 00 00 00 0C 05 62 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 3E 00 0C 05 6C 00 00 00 0C 05 6C FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 3F 00 0C 05 76 00 00 00 0C 05 76 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 40 00 0C 05 80 00 00 00 0C 05 80 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 41 00 0C 05 8A 00 00 00 0C 05 8A FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 42 00 0C 05 94 00 00 00 0C 05 94 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 43 00 0C 05 9E 00 00 00 0C 05 9E FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 44 00 0C 05 A8 00 00 00 0C 05 A8 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 45 00 0C 05 B2 00 00 00 0C 05 B2 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 46 00 0D 76 A4 00 00 00 0D 76 A4 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 47 00 0D 76 AE 00 00 00 0D 76 AE FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 48 00 0D 76 B8 00 00 00 0D 76 B8 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 49 00 0D 76 C2 00 00 00 0D 76 C2 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 4A 00 0C 47 34 00 00 00 0C 47 34 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 4B 00 0D D0 18 00 00 00 0D D0 18 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 4C 00 0D D0 22 00 00 00 0D D0 22 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 4D 00 0D D0 2C 00 00 00 0D D0 2C FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 4E 00 0D D0 36 00 00 00 0D D0 36 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 4F 00 0D CF 46 00 00 00 0D CF 46 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 50 00 0E 56 0A 00 00 00 0E 56 0A FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 51 00 0E 56 14 00 00 00 0E 56 14 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 52 00 0E 56 1E 00 00 00 0E 56 1E FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 53 00 0E 56 28 00 00 00 0E 56 28 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 54 00 0E 56 32 00 00 00 0E 56 32 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 55 00 11 E7 16 00 00 00 11 E7 16 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 56 00 11 E7 20 00 00 00 11 E7 20 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 57 00 11 E7 2A 00 00 00 11 E7 2A FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 58 00 11 E7 34 00 00 00 11 E7 34 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 59 00 11 E7 3E 00 00 00 11 E7 3E FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 5A 00 13 46 9C 00 00 00 13 46 9C FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 5B 00 13 46 A6 00 00 00 13 46 A6 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 5C 00 13 46 B0 00 00 00 13 46 B0 FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 5D 00 13 46 BA 00 00 00 13 46 BA FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 5E 00 13 46 EC 00 00 00 13 46 EC FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF FF 00 00 00 00 FF FF FF FF FF FF FF FF 00 00 00 11 00 00 00 4C 00 00 00 00 00 00 00 55 00 01 00 00 00 18 00 00 59 0E C5 F0 59 0E CA A0 00 01 59 0E D4 00 59 0E D8 B0 00 02 59 0E E2 10 59 0E E6 C0 00 03 59 0E F0 20 59 0E F4 D0 00 04 59 0E FE 30 59 0F 02 E0 00 05 59 0F 0C 40 59 0F 10 F0 00 06 59 0F 1A 50 59 0F 1F 00 00 07 59 0F 28 60 59 0F 2D 10 00 08 59 0F 36 70 59 0F 3B 20 00 09 59 0F 44 80 59 0F 49 30 00 0A 59 0F 52 90 59 0F 57 40 00 0B 59 0F 60 A0 59 0F 65 50 00 0C 59 0F 6E B0 59 0F 73 60 00 0D 59 0F 7C C0 59 0F 81 70 00 0E 59 0F 8A D0 59 0F 8F 80 00 0F 59 0F 98 E0 59 0F 9D 90 00 10 59 0F A6 F0 59 0F AB A0 00 11 59 0F B5 00 59 0F B9 B0 00 12 59 0F C3 10 59 0F C7 C0 00 13 59 0F D1 20 59 0F D5 D0 00 14 59 0F DF 30 59 0F E3 E0 00 15 59 0F ED 40 59 0F F1 F0 00 16 59 0F FB 50 59 10 00 00 00 17 59 10 09 60 59 10 0E 10 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 59 0E C5 F0");
            user.Send(Write.ack);
        }
    }
}
