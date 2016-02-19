﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DotNetAnalytics.Google.Dimensions;
using DotNetAnalytics.Google.Linq.Core;
using DotNetAnalytics.Google.Linq.RecordQueries;
using DotNetAnalytics.Google.Metrics;
using DotNetAnalytics.Google.Queries;
using DotNetAnalytics.Google.Records;

namespace DotNetAnalytics.Google.Linq.Queryables
{
    /// <summary>
    /// A LINQ Provider that executes API Queries over an API Client
    /// </summary>
    internal class RecordsQueryProvider<T> : QueryProvider where T : IRecord
    {
        private readonly IReportingClient _client;
        private List<object> _includes;

        public RecordsQueryProvider(IReportingClient client)
        {
            _client = client;
        }

        private static QueryableRecordQuery Translate(Expression expression)
        {
            expression = Evaluator.PartialEval(expression);
            return new RecordsQueryTranslator().Translate(expression);
        }

        public List<object> Includes
        {
            get { return _includes ?? (_includes = new List<object>()); }
            set { _includes = value; }
        }

        public override object Execute(Expression expression)
        {
            var query = Translate(expression);
            query.DimensionsList = Includes.OfType<IDimension>().ToList();
            query.MetricsList = Includes.OfType<IMetric>().ToList();
            int? totalRecords;
            return query.QueryAll
                ? _client.GetAllRecords(query)
                : _client.GetRecords(query, out totalRecords, query.StartIndex ?? 1,
                    query.RecordsCount ?? RecordQuery.MaxRecordsPerQuery);
        }
    }
}
