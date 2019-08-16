﻿// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace FabricObserver.Interfaces
{
    interface IDataTableFileLogger<TLogger>
    {
        bool EnableCsvLogging { get; set; }
        string DataLogFolderPath { get; set; }
        void ConfigureLogger(string filename);
        void LogData(string fileName,
                     string target,
                     string metric,
                     string stat,
                     double value);
    }
}
