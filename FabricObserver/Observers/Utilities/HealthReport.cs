﻿// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

using System;
using System.Fabric.Health;

namespace FabricObserver.Utilities
{
    public class HealthReport
    {
        public Uri AppName { get; set; }

        public string Code { get; set; }

        public TimeSpan HealthReportTimeToLive { get; set; }

        public string HealthMessage { get; set; }

        public bool EmitLogEvent { get; set; } = true;

        public HealthReportType ReportType { get; set; }

        public HealthState State { get; set; }

        public string NodeName { get; set; }

        public string Observer { get; set; }

        public string ResourceUsageDataProperty { get; set; }
    }
}