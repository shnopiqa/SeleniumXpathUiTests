﻿using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumXpathUiTests.LoggerHelper
{
    public class Logger
    {
        private readonly static ILogger _logger = LogManager.GetCurrentClassLogger();
        public static void Debug(string message)
        {
            _logger.Debug(message);
        }
        public static void Error(string message) => _logger.Error(message);
        public static void Fatal(string message) => _logger.Fatal(message);
        public static void Info(string message) => _logger.Info(message);
        public static void Trace(string message) => _logger.Trace(message);
        public static void Warn(string message) => _logger.Warn(message);

    }
}
