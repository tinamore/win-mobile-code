﻿using System;

using System.Collections.Generic;
using System.Text;

namespace RFID_Wedge
{
    static class virtual_key_codes
    {
        /// <summary>
        /// a list of known VKEY values as enumeration
        /// </summary>
        public enum V_KEY : byte
        {
            VK_NULL,
            VK_LBUTTON,
            VK_RBUTTON,
            VK_CANCEL,
            VK_MBUTTON,
            undef_0x05,
            undef_0x06,
            undef_0x07,
            VK_BACK,
            VK_TAB,
            undef_0x0A,
            undef_0x0B,
            VK_CLEAR,
            VK_RETURN,
            undef_0x0E,
            undef_0x0F,
            VK_SHIFT,
            VK_CONTROL,
            VK_MENU,
            VK_PAUSE,
            VK_CAPITAL,
            VK_HANGUL,
            undef_0x16,
            VK_JUNJA,
            VK_FINAL,
            VK_KANJI,
            undef_0x1A,
            VK_ESCAPE,
            VK_CONVERT,
            VK_NOCONVERT,
            undef_0x1E,
            undef_0x1F,
            VK_SPACE,
            VK_PRIOR,
            VK_NEXT,
            VK_END,
            VK_HOME,
            VK_LEFT,
            VK_UP,
            VK_RIGHT,
            VK_DOWN,
            VK_SELECT,
            VK_PRINT,
            VK_EXECUTE,
            VK_SNAPSHOT,
            VK_INSERT,
            VK_DELETE,
            VK_HELP,
            VK_0,
            VK_1,
            VK_2,
            VK_3,
            VK_4,
            VK_5,
            VK_6,
            VK_7,
            VK_8,
            VK_9,
            undef_0x3A,
            undef_0x3B,
            undef_0x3C,
            undef_0x3D,
            undef_0x3E,
            undef_0x3F,
            undef_0x40,
            VK_A,
            VK_B,
            VK_C,
            VK_D,
            VK_E,
            VK_F,
            VK_G,
            VK_H,
            VK_I,
            VK_J,
            VK_K,
            VK_L,
            VK_M,
            VK_N,
            VK_O,
            VK_P,
            VK_Q,
            VK_R,
            VK_S,
            VK_T,
            VK_U,
            VK_V,
            VK_W,
            VK_X,
            VK_Y,
            VK_Z,
            VK_LWIN,
            VK_RWIN,
            VK_APPS,
            undef_0x5E,
            VK_SLEEP,
            VK_NUMPAD0,
            VK_NUMPAD1,
            VK_NUMPAD2,
            VK_NUMPAD3,
            VK_NUMPAD4,
            VK_NUMPAD5,
            VK_NUMPAD6,
            VK_NUMPAD7,
            VK_NUMPAD8,
            VK_NUMPAD9,
            VK_MULTIPLY,
            VK_ADD,
            VK_SEPARATOR,
            VK_SUBTRACT,
            VK_DECIMAL,
            VK_DIVIDE,
            VK_F1,
            VK_F2,
            VK_F3,
            VK_F4,
            VK_F5,
            VK_F6,
            VK_F7,
            VK_F8,
            VK_F9,
            VK_F10,
            VK_F11,
            VK_F12,
            VK_F13,
            VK_F14,
            VK_F15,
            VK_F16,
            VK_F17,
            VK_F18,
            VK_F19,
            VK_F20,
            VK_F21,
            VK_F22,
            VK_F23,
            VK_F24,
            undef_0x88,
            undef_0x89,
            undef_0x8A,
            undef_0x8B,
            undef_0x8C,
            undef_0x8D,
            undef_0x8E,
            undef_0x8F,
            VK_NUMLOCK,
            VK_SCROLL,
            undef_0x92,
            undef_0x93,
            undef_0x94,
            undef_0x95,
            undef_0x96,
            undef_0x97,
            undef_0x98,
            undef_0x99,
            undef_0x9A,
            undef_0x9B,
            undef_0x9C_light, //0x9c controls screen backlight on CN50
            undef_0x9D,
            undef_0x9E,
            undef_0x9F,
            VK_LSHIFT,
            VK_RSHIFT,
            VK_LCONTROL,
            VK_RCONTROL,
            VK_LMENU,
            VK_RMENU,
            VK_BROWSER_BACK,
            VK_BROWSER_FORWARD,
            VK_BROWSER_REFRESH,
            VK_BROWSER_STOP,
            VK_BROWSER_SEARCH,
            VK_BROWSER_FAVORITES,
            VK_BROWSER_HOME,
            VK_VOLUME_MUTE,
            VK_VOLUME_DOWN,
            VK_VOLUME_UP,
            VK_MEDIA_NEXT_TRACK,
            VK_MEDIA_PREV_TRACK,
            VK_MEDIA_STOP,
            VK_MEDIA_PLAY_PAUSE,
            VK_LAUNCH_MAIL,
            VK_LAUNCH_MEDIA_SELECT,
            VK_LAUNCH_APP1,
            VK_LAUNCH_APP2,
            undef_0xB8,
            undef_0xB9,
            VK_SEMICOLON,
            VK_EQUAL,
            VK_COMMA,
            VK_HYPHEN,
            VK_PERIOD,
            VK_SLASH,
            VK_BACKQUOTE,
            VK_APP1,
            VK_APP2,
            VK_APP3,
            VK_APP4,
            VK_APP5,
            VK_APP6,
            undef_0xC7,
            undef_0xC8,
            undef_0xC9,
            undef_0xCA,
            undef_0xCB,
            undef_0xCC,
            undef_0xCD,
            undef_0xCE,
            undef_0xCF,
            undef_0xD0,
            undef_0xD1,
            undef_0xD2,
            undef_0xD3,
            undef_0xD4,
            undef_0xD5,
            undef_0xD6,
            undef_0xD7,
            undef_0xD8,
            undef_0xD9,
            undef_0xDA,
            VK_LBRACKET,
            VK_BACKSLASH,
            VK_RBRACKET,
            VK_APOSTROPHE,
            VK_OFF,
            undef_0xE0,
            undef_0xE1_SCAN,
            VK_EXTEND_BSLASH,
            undef_0xE3,
            undef_0xE4,
            VK_PROCESSKEY,
            undef_0xE6,
            undef_0xE7,
            undef_0xE8,
            undef_0xE9,
            undef_0xEA,
            undef_0xEB,
            undef_0xEC,
            undef_0xED,
            undef_0xEE,
            undef_0xEF,
            undef_0xF0,
            undef_0xF1,
            undef_0xF2,
            undef_0xF3,
            undef_0xF4,
            undef_0xF5,
            VK_ATTN,
            VK_CRSEL,
            VK_EXSEL,
            VK_EREOF,
            VK_PLAY,
            VK_ZOOM,
            VK_NONAME,
            VK_PA1,
            VK_OEM_CLEAR,
            VK_undef_0xff
        }

        // the struct used to save a ASCII <-> VK_ table
        public class KTABLE{
             byte kByte; // key byte
             string txt; // description
             byte kVKval; //the VK value to send for kByte
             public byte VKval
             {
                 get { return kVKval; }
             }
             bool kShift;
             public bool bShift
             {
                 get { return kShift; }
             }
             public KTABLE(byte b, string s, byte val, bool bShift){
                kByte=b;
                txt=s;
                kVKval = val;
                kShift = bShift;
            }
             public KTABLE(byte b, string s, V_KEY val, bool bShift)
             {
                 kByte = b;
                 txt = s;
                 kVKval = (byte)val;
                 kShift = bShift;
             }
        };

        // the translation tabel for ASCII to VK_ values
        // first val is byte code to translate and third val is VK_ value to be used with keybd_event and other VK_ functions
        public static KTABLE[] vkTable = {
	        new KTABLE (0x00, "NUL", V_KEY.VK_NULL, false), 
	        new KTABLE (0x01, "SOH", V_KEY.VK_undef_0xff, false), 
	        new KTABLE (0x02, "STX", V_KEY.VK_undef_0xff, false), 
	        new KTABLE (0x03, "ETX", V_KEY.VK_undef_0xff, false), 
	        new KTABLE (0x04, "EOT", V_KEY.VK_undef_0xff, false), 
	        new KTABLE (0x05, "ENQ", V_KEY.VK_undef_0xff, false), 
	        new KTABLE (0x06, "ACK", V_KEY.VK_undef_0xff, false), 
	        new KTABLE (0x07, "BEL", V_KEY.VK_undef_0xff, false), 
	        new KTABLE (0x08, "BS", V_KEY.VK_BACK, false), 
	        new KTABLE (0x09, "HT", V_KEY.VK_TAB, false), 
	        new KTABLE (0x0A, "LF", V_KEY.VK_RETURN, false), 
	        new KTABLE (0x0B, "VT", V_KEY.VK_TAB, false), 
	        new KTABLE (0x0C, "FF", V_KEY.VK_undef_0xff, false), 
	        new KTABLE (0x0D, "CR", V_KEY.VK_RETURN, false), 
	        new KTABLE (0x0E, "SO", V_KEY.VK_undef_0xff, false), 
	        new KTABLE (0x0F, "SI", V_KEY.VK_undef_0xff, false), 
	        new KTABLE (0x10, "DLE", V_KEY.VK_undef_0xff, false), 
	        new KTABLE (0x11, "DC1", V_KEY.VK_undef_0xff, false), 
	        new KTABLE (0x12, "DC2", V_KEY.VK_undef_0xff, false), 
	        new KTABLE (0x13, "DC3", V_KEY.VK_undef_0xff, false), 
	        new KTABLE (0x14, "DC4", V_KEY.VK_undef_0xff, false), 
	        new KTABLE (0x15, "NAK", V_KEY.VK_undef_0xff, false), 
	        new KTABLE (0x16, "SYN", V_KEY.VK_undef_0xff, false), 
	        new KTABLE (0x17, "ETB", V_KEY.VK_undef_0xff, false), 
	        new KTABLE (0x18, "CAN", V_KEY.VK_undef_0xff, false), 
	        new KTABLE (0x19, "EM", V_KEY.VK_undef_0xff, false), 
	        new KTABLE (0x1A, "SUB", V_KEY.VK_undef_0xff, false), 
	        new KTABLE (0x1B, "ESC", V_KEY.VK_ESCAPE, false), 
	        new KTABLE (0x1C, "FS", V_KEY.VK_undef_0xff, false), 
	        new KTABLE (0x1D, "GS", V_KEY.VK_undef_0xff, false), 
	        new KTABLE (0x1E, "RS", V_KEY.VK_undef_0xff, false), 
	        new KTABLE (0x1F, "US", V_KEY.VK_undef_0xff, false), 
	        new KTABLE (0x20, " ", V_KEY.VK_SPACE, false), 
	        new KTABLE (0x21, "!", V_KEY.VK_1, true), 
	        new KTABLE (0x22, "\"", V_KEY.VK_APOSTROPHE, true), 
	        new KTABLE (0x23, "#", V_KEY.VK_3, true), 
	        new KTABLE (0x24, "$", V_KEY.VK_4, true), 
	        new KTABLE (0x25, "%", V_KEY.VK_5, true), 
	        new KTABLE (0x26, "&", V_KEY.VK_7, true), 
	        new KTABLE (0x27, "'", V_KEY.VK_APOSTROPHE, false), 
	        new KTABLE (0x28, "(", V_KEY.VK_9, true), 
	        new KTABLE (0x29, ")", V_KEY.VK_0, true), 
	        new KTABLE (0x2A, "*", V_KEY.VK_8, true), 
	        new KTABLE (0x2B, "+", V_KEY.VK_EQUAL, true), 
	        new KTABLE (0x2C, ",", V_KEY.VK_COMMA, false), 
	        new KTABLE (0x2D, "-", V_KEY.VK_HYPHEN, false), 
	        new KTABLE (0x2E, ".", V_KEY.VK_PERIOD, false), 
	        new KTABLE (0x2F, "/", V_KEY.VK_SLASH, false), 
	        new KTABLE (0x30, "0", V_KEY.VK_0, false), 
	        new KTABLE (0x31, "1", V_KEY.VK_1, false), 
	        new KTABLE (0x32, "2", V_KEY.VK_2, false), 
	        new KTABLE (0x33, "3", V_KEY.VK_3, false), 
	        new KTABLE (0x34, "4", V_KEY.VK_4, false), 
	        new KTABLE (0x35, "5", V_KEY.VK_5, false), 
	        new KTABLE (0x36, "6", V_KEY.VK_6, false), 
	        new KTABLE (0x37, "7", V_KEY.VK_7, false), 
	        new KTABLE (0x38, "8", V_KEY.VK_8, false), 
	        new KTABLE (0x39, "9", V_KEY.VK_9, false), 
	        new KTABLE (0x3A, ":", V_KEY.VK_SEMICOLON, true), 
	        new KTABLE (0x3B, ";", V_KEY.VK_SEMICOLON, false), 
	        new KTABLE (0x3C, "<", V_KEY.VK_COMMA, true), 
	        new KTABLE (0x3D, "=", V_KEY.VK_EQUAL, false), 
	        new KTABLE (0x3E, ">", V_KEY.VK_PERIOD, true), 
	        new KTABLE (0x3F, "?", V_KEY.VK_SLASH, true), 
	        new KTABLE (0x40, "@", V_KEY.VK_2, true), 
	        new KTABLE (0x41, "A", V_KEY.VK_A, true), 
	        new KTABLE (0x42, "B", V_KEY.VK_B, true), 
	        new KTABLE (0x43, "C", V_KEY.VK_C, true), 
	        new KTABLE (0x44, "D", V_KEY.VK_D, true), 
	        new KTABLE (0x45, "E", V_KEY.VK_E, true), 
	        new KTABLE (0x46, "F", V_KEY.VK_F, true), 
	        new KTABLE (0x47, "G", V_KEY.VK_G, true), 
	        new KTABLE (0x48, "H", V_KEY.VK_H, true), 
	        new KTABLE (0x49, "I", V_KEY.VK_I, true), 
	        new KTABLE (0x4A, "J", V_KEY.VK_J, true), 
	        new KTABLE (0x4B, "K", V_KEY.VK_K, true), 
	        new KTABLE (0x4C, "L", V_KEY.VK_L, true), 
	        new KTABLE (0x4D, "M", V_KEY.VK_M, true), 
	        new KTABLE (0x4E, "N", V_KEY.VK_N, true), 
	        new KTABLE (0x4F, "O", V_KEY.VK_O, true), 
	        new KTABLE (0x50, "P", V_KEY.VK_P, true), 
	        new KTABLE (0x51, "Q", V_KEY.VK_Q, true), 
	        new KTABLE (0x52, "R", V_KEY.VK_R, true), 
	        new KTABLE (0x53, "S", V_KEY.VK_S, true), 
	        new KTABLE (0x54, "T", V_KEY.VK_T, true), 
	        new KTABLE (0x55, "U", V_KEY.VK_U, true), 
	        new KTABLE (0x56, "V", V_KEY.VK_V, true), 
	        new KTABLE (0x57, "W", V_KEY.VK_W, true), 
	        new KTABLE (0x58, "X", V_KEY.VK_X, true), 
	        new KTABLE (0x59, "Y", V_KEY.VK_Y, true), 
	        new KTABLE (0x5A, "Z", V_KEY.VK_Z, true), 
	        new KTABLE (0x5B, "[", V_KEY.VK_LBRACKET, false), 
	        new KTABLE (0x5C, "\\", V_KEY.VK_BACKSLASH, false), 
	        new KTABLE (0x5D, "]", V_KEY.VK_RBRACKET, false), 
	        new KTABLE (0x5E, "^", V_KEY.VK_6, true), 
	        new KTABLE (0x5F, "_", V_KEY.VK_HYPHEN, true), 
	        new KTABLE (0x60, "`", V_KEY.VK_BACKQUOTE, false), 
	        new KTABLE (0x61, "a", V_KEY.VK_A, false), 
	        new KTABLE (0x62, "b", V_KEY.VK_B, false), 
	        new KTABLE (0x63, "c", V_KEY.VK_C, false), 
	        new KTABLE (0x64, "d", V_KEY.VK_D, false), 
	        new KTABLE (0x65, "e", V_KEY.VK_E, false), 
	        new KTABLE (0x66, "f", V_KEY.VK_F, false), 
	        new KTABLE (0x67, "g", V_KEY.VK_G, false), 
	        new KTABLE (0x68, "h", V_KEY.VK_H, false), 
	        new KTABLE (0x69, "i", V_KEY.VK_I, false), 
	        new KTABLE (0x6A, "j", V_KEY.VK_J, false), 
	        new KTABLE (0x6B, "k", V_KEY.VK_K, false), 
	        new KTABLE (0x6C, "l", V_KEY.VK_L, false), 
	        new KTABLE (0x6D, "m", V_KEY.VK_M, false), 
	        new KTABLE (0x6E, "n", V_KEY.VK_N, false), 
	        new KTABLE (0x6F, "o", V_KEY.VK_O, false), 
	        new KTABLE (0x70, "p", V_KEY.VK_P, false), 
	        new KTABLE (0x71, "q", V_KEY.VK_Q, false), 
	        new KTABLE (0x72, "r", V_KEY.VK_R, false), 
	        new KTABLE (0x73, "s", V_KEY.VK_S, false), 
	        new KTABLE (0x74, "t", V_KEY.VK_T, false), 
	        new KTABLE (0x75, "u", V_KEY.VK_U, false), 
	        new KTABLE (0x76, "v", V_KEY.VK_V, false), 
	        new KTABLE (0x77, "w", V_KEY.VK_W, false), 
	        new KTABLE (0x78, "x", V_KEY.VK_X, false), 
	        new KTABLE (0x79, "y", V_KEY.VK_Y, false), 
	        new KTABLE (0x7A, "z", V_KEY.VK_Z, false), 
	        new KTABLE (0x7B, "{", V_KEY.VK_LBRACKET, true), 
	        new KTABLE (0x7C, "|", V_KEY.VK_BACKSLASH, true), 
	        new KTABLE (0x7D, "}", V_KEY.VK_RBRACKET, true), 
	        new KTABLE (0x7E, "~", V_KEY.VK_BACKQUOTE, true), 
	        new KTABLE (0x7F, "DEL", V_KEY.VK_DELETE, false),
        //this will not come from ASCII barcode readers
	        new KTABLE (0x80, "\x80", 0x80, true), 
	        new KTABLE (0x81, "\x81", 0x81, true), 
	        new KTABLE (0x82, "\x82", 0x82, true), 
	        new KTABLE (0x83, "\x83", 0x83, true), 
	        new KTABLE (0x84, "\x84", 0x84, true), 
	        new KTABLE (0x85, "\x85", 0x85, true), 
	        new KTABLE (0x86, "\x86", 0x86, true), 
	        new KTABLE (0x87, "\x87", 0x87, true), 
	        new KTABLE (0x88, "\x88", 0x88, true), 
	        new KTABLE (0x89, "\x89", 0x89, true), 
	        new KTABLE (0x8A, "\x8A", 0x8A, true), 
	        new KTABLE (0x8B, "\x8B", 0x8B, true), 
	        new KTABLE (0x8C, "\x8C", 0x8C, true), 
	        new KTABLE (0x8D, "\x8D", 0x8D, true), 
	        new KTABLE (0x8E, "\x8E", 0x8E, true), 
	        new KTABLE (0x8F, "\x8F", 0x8F, true), 
	        new KTABLE (0x90, "\x90", 0x90, true), 
	        new KTABLE (0x91, "\x91", 0x91, true), 
	        new KTABLE (0x92, "\x92", 0x92, true), 
	        new KTABLE (0x93, "\x93", 0x93, true), 
	        new KTABLE (0x94, "\x94", 0x94, true), 
	        new KTABLE (0x95, "\x95", 0x95, true), 
	        new KTABLE (0x96, "\x96", 0x96, true), 
	        new KTABLE (0x97, "\x97", 0x97, true), 
	        new KTABLE (0x98, "\x98", 0x98, true), 
	        new KTABLE (0x99, "\x99", 0x99, true), 
	        new KTABLE (0x9A, "\x9A", 0x9A, true), 
	        new KTABLE (0x9B, "\x9B", 0x9B, true), 
	        new KTABLE (0x9C, "\x9C", 0x9C, true), 
	        new KTABLE (0x9D, "\x9D", 0x9D, true), 
	        new KTABLE (0x9E, "\x9E", 0x9E, true), 
	        new KTABLE (0x9F, "\x9F", 0x9F, true), 
	        new KTABLE (0xA0, "\xA0", 0xA0, true), 
	        new KTABLE (0xA1, "¡", 0xA1, true), 
	        new KTABLE (0xA2, "¢", 0xA2, true), 
	        new KTABLE (0xA3, "£", 0xA3, true), 
	        new KTABLE (0xA4, "¤", 0xA4, true), 
	        new KTABLE (0xA5, "¥", 0xA5, true), 
	        new KTABLE (0xA6, "¦", 0xA6, true), 
	        new KTABLE (0xA7, "§", 0xA7, true), 
	        new KTABLE (0xA8, "¨", 0xA8, true), 
	        new KTABLE (0xA9, "©", 0xA9, true), 
	        new KTABLE (0xAA, "ª", 0xAA, true), 
	        new KTABLE (0xAB, "«", 0xAB, true), 
	        new KTABLE (0xAC, "¬", 0xAC, true), 
	        new KTABLE (0xAD, "­", 0xAD, true), 
	        new KTABLE (0xAE, "®", 0xAE, true), 
	        new KTABLE (0xAF, "¯", 0xAF, true), 
	        new KTABLE (0xB0, "°", 0xB0, true), 
	        new KTABLE (0xB1, "±", 0xB1, true), 
	        new KTABLE (0xB2, "²", 0xB2, true), 
	        new KTABLE (0xB3, "³", 0xB3, true), 
	        new KTABLE (0xB4, "´", 0xB4, true), 
	        new KTABLE (0xB5, "µ", 0xB5, true), 
	        new KTABLE (0xB6, "¶", 0xB6, true), 
	        new KTABLE (0xB7, "·", 0xB7, true), 
	        new KTABLE (0xB8, "¸", 0xB8, true), 
	        new KTABLE (0xB9, "¹", 0xB9, true), 
	        new KTABLE (0xBA, "º", 0xBA, true), 
	        new KTABLE (0xBB, "»", 0xBB, true), 
	        new KTABLE (0xBC, "¼", 0xBC, true), 
	        new KTABLE (0xBD, "½", 0xBD, true), 
	        new KTABLE (0xBE, "¾", 0xBE, true), 
	        new KTABLE (0xBF, "¿", 0xBF, true), 
	        new KTABLE (0xC0, "À", 0xC0, true), 
	        new KTABLE (0xC1, "Á", 0xC1, true), 
	        new KTABLE (0xC2, "Â", 0xC2, true), 
	        new KTABLE (0xC3, "Ã", 0xC3, true), 
	        new KTABLE (0xC4, "Ä", 0xC4, true), 
	        new KTABLE (0xC5, "Å", 0xC5, true), 
	        new KTABLE (0xC6, "Æ", 0xC6, true), 
	        new KTABLE (0xC7, "Ç", 0xC7, true), 
	        new KTABLE (0xC8, "È", 0xC8, true), 
	        new KTABLE (0xC9, "É", 0xC9, true), 
	        new KTABLE (0xCA, "Ê", 0xCA, true), 
	        new KTABLE (0xCB, "Ë", 0xCB, true), 
	        new KTABLE (0xCC, "Ì", 0xCC, true), 
	        new KTABLE (0xCD, "Í", 0xCD, true), 
	        new KTABLE (0xCE, "Î", 0xCE, true), 
	        new KTABLE (0xCF, "Ï", 0xCF, true), 
	        new KTABLE (0xD0, "Ð", 0xD0, true), 
	        new KTABLE (0xD1, "Ñ", 0xD1, true), 
	        new KTABLE (0xD2, "Ò", 0xD2, true), 
	        new KTABLE (0xD3, "Ó", 0xD3, true), 
	        new KTABLE (0xD4, "Ô", 0xD4, true), 
	        new KTABLE (0xD5, "Õ", 0xD5, true), 
	        new KTABLE (0xD6, "Ö", 0xD6, true), 
	        new KTABLE (0xD7, "×", 0xD7, true), 
	        new KTABLE (0xD8, "Ø", 0xD8, true), 
	        new KTABLE (0xD9, "Ù", 0xD9, true), 
	        new KTABLE (0xDA, "Ú", 0xDA, true), 
	        new KTABLE (0xDB, "Û", 0xDB, true), 
	        new KTABLE (0xDC, "Ü", 0xDC, true), 
	        new KTABLE (0xDD, "Ý", 0xDD, true), 
	        new KTABLE (0xDE, "Þ", 0xDE, true), 
	        new KTABLE (0xDF, "ß", 0xDF, true), 
	        new KTABLE (0xE0, "à", 0xE0, true), 
	        new KTABLE (0xE1, "á", 0xE1, true), 
	        new KTABLE (0xE2, "â", 0xE2, true), 
	        new KTABLE (0xE3, "ã", 0xE3, true), 
	        new KTABLE (0xE4, "ä", 0xE4, true), 
	        new KTABLE (0xE5, "å", 0xE5, true), 
	        new KTABLE (0xE6, "æ", 0xE6, true), 
	        new KTABLE (0xE7, "ç", 0xE7, true), 
	        new KTABLE (0xE8, "è", 0xE8, true), 
	        new KTABLE (0xE9, "é", 0xE9, true), 
	        new KTABLE (0xEA, "ê", 0xEA, true), 
	        new KTABLE (0xEB, "ë", 0xEB, true), 
	        new KTABLE (0xEC, "ì", 0xEC, true), 
	        new KTABLE (0xED, "í", 0xED, true), 
	        new KTABLE (0xEE, "î", 0xEE, true), 
	        new KTABLE (0xEF, "ï", 0xEF, true), 
	        new KTABLE (0xF0, "ð", 0xF0, true), 
	        new KTABLE (0xF1, "ñ", 0xF1, true), 
	        new KTABLE (0xF2, "ò", 0xF2, true), 
	        new KTABLE (0xF3, "ó", 0xF3, true), 
	        new KTABLE (0xF4, "ô", 0xF4, true), 
	        new KTABLE (0xF5, "õ", 0xF5, true), 
	        new KTABLE (0xF6, "ö", 0xF6, true), 
	        new KTABLE (0xF7, "÷", 0xF7, true), 
	        new KTABLE (0xF8, "ø", 0xF8, true), 
	        new KTABLE (0xF9, "ù", 0xF9, true), 
	        new KTABLE (0xFA, "ú", 0xFA, true), 
	        new KTABLE (0xFB, "û", 0xFB, true), 
	        new KTABLE (0xFC, "ü", 0xFC, true), 
	        new KTABLE (0xFD, "ý", 0xFD, true), 
	        new KTABLE (0xFE, "þ", 0xFE, true), 
	        new KTABLE (0xFF, "ÿ", 0xFF, true)
        };
    }
}
