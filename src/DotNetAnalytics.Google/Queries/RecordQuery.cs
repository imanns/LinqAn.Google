﻿using System;
using System.Collections.Generic;
using System.Linq;
using DotNetAnalytics.Google.Dimensions;
using DotNetAnalytics.Google.Metrics;

namespace DotNetAnalytics.Google.Queries
{
    public class RecordQuery : IRecordQuery
    {
        public const uint MaxRecordsPerQuery = 10000U;
        public RecordQuery(uint viewId, DateTime startDate, DateTime endDate, IEnumerable<IMetric> metrics,
            IEnumerable<IDimension> dimensions = null)
        {
            ViewId = viewId;
            StartDate = startDate;
            EndDate = endDate;
            Metrics = metrics;
            Dimensions = dimensions ?? Enumerable.Empty<IDimension>();
        }

        public uint ViewId { get; }
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }
        public IEnumerable<IMetric> Metrics { get; }
        public IEnumerable<IDimension> Dimensions { get; }
    }
}