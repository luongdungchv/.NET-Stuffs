using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;
using MongoDB.Driver;
using MongoDB.Bson;

namespace WebApplication1.Models
{
    public class DBFilter<T>
    {
        public virtual object Eq<U>(Expression<Func<T, U>> field, U value)
        {
            return null;
        }
        public virtual object Gt<U>(Expression<Func<T, U>> field, U value)
        {
            return null;
        }
        public virtual object Gte<U>(Expression<Func<T, U>> field, U value)
        {
            return null;
        }
        public virtual object In<U>(Expression<Func<T, U>> field, IEnumerable<U> value)
        {
            return null;
        }
        public virtual object Lt<U>(Expression<Func<T, U>> field, U value)
        {
            return null;
        }
        public virtual object Lte<U>(Expression<Func<T, U>> field, U value)
        {
            return null;
        }
       


    }
    public class MongoFilter<T>: DBFilter<T>
    {
        public List<FilterDefinition<T>> filterList;
        public MongoFilter()
        {
            filterList = new List<FilterDefinition<T>>();
        }
        public override DBFilter<T> Eq<U>(Expression<Func<T, U>> field, U value)
        {
            var res = Builders<T>.Filter.Eq(field, value);
            filterList.Add(res);
            return this;
        }
        public override DBFilter<T> Gt<U>(Expression<Func<T, U>> field, U value)
        {
            var res = Builders<T>.Filter.Gt(field, value);
            filterList.Add(res);
            return this;
        }
        public override DBFilter<T> Gte<U>(Expression<Func<T, U>> field, U value)
        {
            var res = Builders<T>.Filter.Gte(field, value);
            filterList.Add(res);
            return this;
        }
        public override DBFilter<T> In<U>(Expression<Func<T, U>> field, IEnumerable<U> value)
        {
            var res = Builders<T>.Filter.In(field, value);
            filterList.Add(res);
            return this;
        }
        public override DBFilter<T> Lt<U>(Expression<Func<T, U>> field, U value)
        {
            var res = Builders<T>.Filter.Lte(field, value);
            filterList.Add(res);
            return this;
        }
        public override DBFilter<T> Lte<U>(Expression<Func<T, U>> field, U value)
        {
            var res = Builders<T>.Filter.Eq(field, value);
            filterList.Add(res);
            return this;
        }
        
    }
   
    public enum FilterType
    {
        Eq,Gt,Gte,In,Lt,Lte
    }
}
