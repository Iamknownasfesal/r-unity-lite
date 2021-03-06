﻿using UnityEngine;

namespace Assets.Resources.Scripts.Monitoring
{
    public sealed class Log
    {
        private static readonly bool enableLog = Utils.OnEditor(Application.platform);

        public static void Write(string format, params string[] args)
        {
            if (enableLog) Debug.LogFormat(format, args);
        }

        public static void Warn(string format, params string[] args)
        {
            if (enableLog) Debug.LogWarningFormat(format, args);
        }

        public static void Error(string format, params string[] args)
        {
            if (enableLog) Debug.LogErrorFormat(format, args);
        }

        public static void Assert(string format, params string[] args)
        {
            if (enableLog) Debug.LogAssertionFormat(format, args);
        }
    }
}