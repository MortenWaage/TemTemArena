﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using TemTemArena.Scripts.Data;
using TemTemArena.Scripts.Singletons;

namespace TemTemArena.Scripts.GUI
{
    public static class GUI
    {
        public static IEnumerable<string> Buffer => Game.Manager.ScreenBuffer.Buffer;

        public static void AddEntry(EntryType type, string message)
        {
            Game.Manager.EventLog.AddEntry(type, message);
        }
        public static void AddEntry(EntryType type, string message, bool update)
        {
            Game.Manager.EventLog.AddEntry(type, message);
            if (!update) return;
            Update();
            Draw();
        }
        public static void AddEntry(EntryType type, string[] messages, bool update)
        {
            Game.Manager.EventLog.AddEntry(type, messages);
            if (!update) return;
            Update();
            Draw();
        }
        public static void AddEntry(EntryType type, string[] messages)
        {
            Game.Manager.EventLog.AddEntry(type, messages);
        }

        public static void Draw()
        {
            Game.Manager.Renderer.DrawScreenBuffer();
        }

        public static void Update()
        {
            Game.Manager.ScreenBuffer.ReloadBuffer();
        }

        public static void Refresh()
        {
            Update();
            Draw();
        }
        public static void MergeBuffer()
        {
            Game.Manager.ScreenBuffer.PushBuffer();
        }

        public static string ReadLine()
        {
            return Game.Manager.EventLog.ReadLine(ScreenData.InputPosition);
        }

        public static string ReadLine(Vector2 position)
        {
            return Game.Manager.EventLog.ReadLine(position);
        }

        public static void ReloadInputArea()
        {
            Game.Manager.ScreenBuffer.LoadInputField();
            Refresh();
        }

        public static string[] CreateMessage(string[] availableAbilities)
        {
            var message = new string[availableAbilities.Length + 2];
            message[0] = "Available attacks actions are:";
            for (var j = 0; j < availableAbilities.Length; j++)
                message[j + 1] = availableAbilities[j];
            message[^1] = "Choose ability 1, 2 or 3";
            return message;
        }
    }
}
