﻿// This file was generated by a T4 Template. Do not modify directly, instead update the SmoQueryModelDefinition.xml file
// and re-run the T4 template. This can be done in Visual Studio by right-click in and choosing "Run Custom Tool",
// or from the command-line on any platform by running "build.cmd -Target=CodeGen" or "build.sh -Target=CodeGen".

using System;
using System.Collections.Generic;
using System.Composition;
using System.Linq;
using Microsoft.Kusto.ServiceLayer.DataSource;

namespace Microsoft.Kusto.ServiceLayer.ObjectExplorer.DataSourceModel
{

    // TODOKusto: Do we need the Querier. This has been short circuited in smoChildFactoryBase. There is no caller to the "Query" function.
    [Export(typeof(DataSourceQuerier))]
    internal partial class DatabaseQuerier: DataSourceQuerier
    {
        public override  IEnumerable<DataSourceObjectMetadata> Query(QueryContext context, string filter, bool refresh, IEnumerable<string> extraProperties)
        {
            if (context.DataSource != null)
            {
                return context.DataSource.GetChildObjects(context.ParentObjectMetadata);
            }
            return Enumerable.Empty<DataSourceObjectMetadata>();
        }
    }

    [Export(typeof(DataSourceQuerier))]
    internal partial class TableQuerier: DataSourceQuerier
    {
        public override  IEnumerable<DataSourceObjectMetadata> Query(QueryContext context, string filter, bool refresh, IEnumerable<string> extraProperties)
        {
            if (context.ParentObjectMetadata != null)
            {
                return context.DataSource.GetChildObjects(context.ParentObjectMetadata);
            }
            return Enumerable.Empty<DataSourceObjectMetadata>();
        }
    }
    
    [Export(typeof(DataSourceQuerier))]
    internal partial class ColumnQuerier: DataSourceQuerier
    {
        public override  IEnumerable<DataSourceObjectMetadata> Query(QueryContext context, string filter, bool refresh, IEnumerable<string> extraProperties)
        {
            if (context.ParentObjectMetadata != null)
            {
                return context.DataSource.GetChildObjects(context.ParentObjectMetadata);
            }
            return Enumerable.Empty<DataSourceObjectMetadata>();
        }
    }
}