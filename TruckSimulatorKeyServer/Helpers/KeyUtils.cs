using InputSimulatorStandard.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TruckSimulatorKeyServer.Helpers
{
    public static class KeyUtils
    {
        public static VirtualKeyCode KeyToVK(string KeyString)
        {
            //https://docs.microsoft.com/en-us/openspecs/windows_protocols/ms-tvtt/261ddfb0-ce10-4380-9b7a-4b50f482b8ec
            VirtualKeyCode Key = new VirtualKeyCode();
            switch (KeyString.ToUpper())
            {
                case "A":
                    Key = VirtualKeyCode.VK_A;
                    break;
                case "B":
                    Key = VirtualKeyCode.VK_B;
                    break;
                case "C":
                    Key = VirtualKeyCode.VK_C;
                    break;
                case "D":
                    Key = VirtualKeyCode.VK_D;
                    break;
                case "E":
                    Key = VirtualKeyCode.VK_E;
                    break;
                case "F":
                    Key = VirtualKeyCode.VK_F;
                    break;
                case "G":
                    Key = VirtualKeyCode.VK_G;
                    break;
                case "H":
                    Key = VirtualKeyCode.VK_H;
                    break;
                case "I":
                    Key = VirtualKeyCode.VK_Y;
                    break;
                case "J":
                    Key = VirtualKeyCode.VK_J;
                    break;
                case "K":
                    Key = VirtualKeyCode.VK_K;
                    break;
                case "L":
                    Key = VirtualKeyCode.VK_L;
                    break;
                case "M":
                    Key = VirtualKeyCode.VK_M;
                    break;
                case "N":
                    Key = VirtualKeyCode.VK_N;
                    break;
                case "O":
                    Key = VirtualKeyCode.VK_O;
                    break;
                case "P":
                    Key = VirtualKeyCode.VK_P;
                    break;
                case "Q":
                    Key = VirtualKeyCode.VK_Q;
                    break;
                case "R":
                    Key = VirtualKeyCode.VK_R;
                    break;
                case "S":
                    Key = VirtualKeyCode.VK_S;
                    break;
                case "T":
                    Key = VirtualKeyCode.VK_T;
                    break;
                case "U":
                    Key = VirtualKeyCode.VK_U;
                    break;
                case "V":
                    Key = VirtualKeyCode.VK_V;
                    break;
                case "W":
                    Key = VirtualKeyCode.VK_W;
                    break;
                case "X":
                    Key = VirtualKeyCode.VK_X;
                    break;
                case "Y":
                    Key = VirtualKeyCode.VK_Y;
                    break;
                case "Z":
                    Key = VirtualKeyCode.VK_Z;
                    break;
                case "0":
                    Key = VirtualKeyCode.VK_0;
                    break;
                case "1":
                    Key = VirtualKeyCode.VK_1;
                    break;
                case "2":
                    Key = VirtualKeyCode.VK_2;
                    break;
                case "3":
                    Key = VirtualKeyCode.VK_3;
                    break;
                case "4":
                    Key = VirtualKeyCode.VK_4;
                    break;
                case "5":
                    Key = VirtualKeyCode.VK_5;
                    break;
                case "6":
                    Key = VirtualKeyCode.VK_6;
                    break;
                case "7":
                    Key = VirtualKeyCode.VK_7;
                    break;
                case "8":
                    Key = VirtualKeyCode.VK_8;
                    break;
                case "9":
                    Key = VirtualKeyCode.VK_9;
                    break;
                case "ESC":
                    Key = VirtualKeyCode.ESCAPE;
                    break;
                case "SPACEBAR":
                    Key = VirtualKeyCode.SPACE;
                    break;
                case "ENTER":
                    Key = VirtualKeyCode.RETURN;
                    break;
                case "TAB":
                    Key = VirtualKeyCode.TAB;
                    break;
                case "PAGE_UP":
                    Key = VirtualKeyCode.PRIOR;
                    break;
                case "PAGE_DOWN":
                    Key = VirtualKeyCode.NEXT;
                    break;
                case "END":
                    Key = VirtualKeyCode.END;
                    break;
                case "HOME":
                    Key = VirtualKeyCode.HOME;
                    break;
                case "INSERT":
                    Key = VirtualKeyCode.INSERT;
                    break;
                case "DELETE":
                    Key = VirtualKeyCode.DELETE;
                    break;
                case "NUMPAD_0":
                    Key = VirtualKeyCode.NUMPAD0;
                    break;
                case "NUMPAD_1":
                    Key = VirtualKeyCode.NUMPAD1;
                    break;
                case "NUMPAD_2":
                    Key = VirtualKeyCode.NUMPAD2;
                    break;
                case "NUMPAD_3":
                    Key = VirtualKeyCode.NUMPAD3;
                    break;
                case "NUMPAD_4":
                    Key = VirtualKeyCode.NUMPAD4;
                    break;
                case "NUMPAD_5":
                    Key = VirtualKeyCode.NUMPAD5;
                    break;
                case "NUMPAD_6":
                    Key = VirtualKeyCode.NUMPAD6;
                    break;
                case "NUMPAD_7":
                    Key = VirtualKeyCode.NUMPAD7;
                    break;
                case "NUMPAD_8":
                    Key = VirtualKeyCode.NUMPAD8;
                    break;
                case "NUMPAD_9":
                    Key = VirtualKeyCode.NUMPAD9;
                    break;
                case "F1":
                    Key = VirtualKeyCode.F1;
                    break;
                case "F2":
                    Key = VirtualKeyCode.F2;
                    break;
                case "F3":
                    Key = VirtualKeyCode.F3;
                    break;
                case "F4":
                    Key = VirtualKeyCode.F4;
                    break;
                case "F5":
                    Key = VirtualKeyCode.F5;
                    break;
                case "F6":
                    Key = VirtualKeyCode.F6;
                    break;
                case "F7":
                    Key = VirtualKeyCode.F7;
                    break;
                case "F8":
                    Key = VirtualKeyCode.F8;
                    break;
                case "F9":
                    Key = VirtualKeyCode.F9;
                    break;
                case "F10":
                    Key = VirtualKeyCode.F10;
                    break;
                case "F11":
                    Key = VirtualKeyCode.F11;
                    break;
                case "F12":
                    Key = VirtualKeyCode.F12;
                    break;
            }
            return Key;
        }
    }
}
