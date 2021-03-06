﻿using Griffin.Data.Mapper;
using Newtonsoft.Json;
using OneTrueError.ReportAnalyzer.Domain.Reports;
using OneTrueError.SqlServer.Tools;

namespace OneTrueError.SqlServer.Analysis
{
    public class ErrorReportEntityMapper : CrudEntityMapper<ErrorReportEntity>
    {
        public ErrorReportEntityMapper() : base("ErrorReports")
        {
            Property(x => x.Exception)
                .ToPropertyValue(EntitySerializer.Deserialize<ErrorReportException>)
                .ToColumnValue(EntitySerializer.Serialize);

            Property(x => x.ContextInfo)
                .ToPropertyValue(EntitySerializer.Deserialize<ErrorReportContext[]>)
                .ToColumnValue(EntitySerializer.Serialize);

            Property(x => x.ClientReportId)
                .ColumnName("ErrorId");
        }
    }
}