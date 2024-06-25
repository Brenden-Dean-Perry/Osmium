using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLibrary.Enums;

namespace BusinessLogicLibrary.Utilities
{
    public static class ComparisonOperatorUtilities
    {
        public static string GetSymbolText(ComparisonOperator comparisonOperator)
        {
            switch (comparisonOperator)
            {
                case ComparisonOperator.EqualTo:
                    return "=";
                case ComparisonOperator.NotEqualTo:
                    return "!=";
                case ComparisonOperator.GreaterThan:
                    return ">";
                case ComparisonOperator.GreaterThanOrEqualTo:
                    return ">=";
                case ComparisonOperator.LessThan:
                    return "<";
                case ComparisonOperator.LessThanOrEqualTo:
                    return "<=";
                case ComparisonOperator.Contains:
                    return "Contains";
                case ComparisonOperator.AbsoluteGreaterThan:
                    return "Abs >";
                case ComparisonOperator.AbsoluteGreaterThanOrEqualTo:
                    return "Abs >=";
                case ComparisonOperator.AbsoluteLessThan:
                    return "Abs <";
                case ComparisonOperator.AbsoluteLessThanOrEqualTo:
                    return "Abs <=";
                default:
                    throw new ArgumentException();   
            }
        }
    }
}
