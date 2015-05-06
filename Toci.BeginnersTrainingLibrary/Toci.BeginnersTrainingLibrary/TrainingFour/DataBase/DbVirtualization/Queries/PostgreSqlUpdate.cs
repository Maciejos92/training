﻿using System.Collections.Generic;
using Toci.BeginnersTrainingLibrary.TrainingFour.DataBase.Interfaces;

namespace Toci.BeginnersTrainingLibrary.TrainingFour.DataBase.DbVirtualization.Queries
{
    public class PostgreSqlUpdate : SqlQuery, IUpdate
    {
        private const string Pattern = "UPDATE {0} SET {1} WHERE {2};";
        private const string AssignmentPattern = "{0} = {1}";
        private const string AndOperator = " AND ";
        private const string Comma = ", ";
        private const int MinStatementLength = 2;

        public override string GetQuery(IModel model)
        {
            var where = GetWhereStatement(model);
            if (where.Length < MinStatementLength)
            {
                return string.Empty;
            }

            return string.Format(Pattern, model.TableName, GetSetStatement(model), where);
        }

        private string GetSetStatement(IModel model)
        {
            var list = new List<string>();
            foreach (var item in model.GetDbTableRow())
            {
                list.Add(string.Format(AssignmentPattern, item.Key, GetSurroundedValue(item.Value.GetValue())));
            }
            return string.Join(Comma, list);
        }

        private string GetWhereStatement(IModel model)
        {
            var list = new List<string>();
            foreach (var item in model.GetDbTableRow())
            {
                if (item.Value.IsWhere())
                {
                    list.Add(string.Format(AssignmentPattern, item.Key, GetSurroundedValue(item.Value.GetValue())));
                }
            }
            return string.Join(AndOperator, list);
        }
    }
}