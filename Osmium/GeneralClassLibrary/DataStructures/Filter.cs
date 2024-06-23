using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneralClassLibrary.Enums;

namespace GeneralClassLibrary.DataStructures
{
    public class Filter
    {
        public LogicalOperator LogicalOperator { get; set; } = LogicalOperator.And;
        public string PropertyName { get; set; }
        public Type Type { get; set; }
        public ComparisonOperator ComparisonOperator { get; set; }
        public dynamic Value { get; set; }

        public Filter()
        {

        }

        public Filter(string PropertyName, Type type, ComparisonOperator comparisonOperator, dynamic Value)
        {
            this.PropertyName = PropertyName;
            this.Type = type;
            this.ComparisonOperator = comparisonOperator;
            this.Value = Value;
        }

        public Filter(LogicalOperator logicalOperator, string PropertyName, Type type, ComparisonOperator comparisonOperator, dynamic Value)
        {
            this.LogicalOperator = LogicalOperator;
            this.PropertyName = PropertyName;
            this.Type = type;
            this.ComparisonOperator = comparisonOperator;
            this.Value = Value;
        }
    }
}
