﻿// <copyright file="LineProtocolWriteResult.cs" company="Allan Hardy">
// Copyright (c) Allan Hardy. All rights reserved.
// </copyright>

namespace App.Metrics.Reporting.InfluxDB.Client
{
    public struct LineProtocolWriteResult
    {
        public LineProtocolWriteResult(bool success)
        {
            Success = success;
            ErrorMessage = null;
        }

        public LineProtocolWriteResult(bool success, string errorMessage)
        {
            Success = success;
            ErrorMessage = errorMessage;
        }

        public string ErrorMessage { get; }

        public bool Success { get; }

        public static LineProtocolWriteResult Ok()
        {
            return new LineProtocolWriteResult(true);
        }

        public static LineProtocolWriteResult Error(string message)
        {
            return new LineProtocolWriteResult(false, message);
        }
    }
}