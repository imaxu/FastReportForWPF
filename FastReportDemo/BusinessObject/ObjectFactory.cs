using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Reflection;

namespace Enjoy.MS.EntityFactory
{

    /// <summary>
    /// 表示一种可创建任意对象实例的工厂类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public sealed class ObjectFactory<T>
    {
        /// <summary>
        /// 初始化一个指定类型的实体类
        /// </summary>
        /// <returns></returns>
        public static T GetInstance()
        {
            try
            {
                return (T)Activator.CreateInstance(typeof(T), true);
            }
            catch (Exception)
            {
                return default(T);
            }
        }

        /// <summary>
        /// 初始化一个指定类型的实体类
        /// </summary>
        /// <param name="p_TypeName"></param>
        /// <returns></returns>
        public static T GetEntity(string p_AssemblyName,string p_TypeName)
        {
            try
            {
                string _assemblyName = p_AssemblyName;
                string _typeName = p_TypeName;
                return (T)Activator.CreateInstance
                    (
                        _assemblyName, 
                        _typeName,
                        false,
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
                        null,
                        null,
                        null,
                        null
                    ).Unwrap();
            }
            catch (Exception)
            {
                return default(T);
            }
        }
        /// <summary>
        /// 从字段中获取值并转换成<paramref name="T"/>
        /// </summary>
        /// <param name="p_DataRow"></param>
        /// <param name="p_FieldName"></param>
        /// <returns></returns>
        public static T GetFromField(DataRow p_DataRow, string p_FieldName)
        {

            object _val = null;
            try
            {
                if (p_DataRow == null)
                {
                    throw new ArgumentNullException();
                }
                if (!p_DataRow.Table.Columns.Contains(p_FieldName))
                {
                    return default(T);
                }
                _val = p_DataRow[p_FieldName];

                if (_val == DBNull.Value)
                {
                    if ("DateTime".Equals(typeof(T).Name))
                    {
                        return (T)Convert.ChangeType(System.Data.SqlTypes.SqlDateTime.MaxValue.Value, typeof(T));
                    }
                    return default(T);
                }

                if (_val is DateTime && typeof(T).Name == "String")//如果是DateTime则按照规定格式进行转换
                {
                    return (T)Convert.ChangeType(((DateTime)_val).ToString("yyyy-MM-dd HH:mm:ss"), typeof(T));
                }

                return (T)Convert.ChangeType(_val, typeof(T));
            }

            catch
            {
                return default(T);
            }
        }

        /// <summary>
        /// 进行一个转换，从object中获取指定类型的值，如果转换失败则返回该类型的默认值。
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static T GetObjectValue(object obj)
        {
            try
            {
                if (obj ==DBNull.Value)
                { 
                    return default (T);
                }
                return (T)Convert.ChangeType(obj, typeof(T));
            }
            catch (Exception) 
            {
                return default(T);
            }
        }
        /// <summary>
        /// 从当前指定的类型初始化一个DataTable
        /// </summary>
        /// <returns></returns>
        public static DataTable CreateTableFromT()
        {
            DataTable _ResultTable = new DataTable(typeof(T).ToString());

            foreach (PropertyInfo info in typeof(T).GetProperties())
            {
                _ResultTable.Columns.Add(info.Name, info.PropertyType);
            }
            return _ResultTable;
        }
    }
}
