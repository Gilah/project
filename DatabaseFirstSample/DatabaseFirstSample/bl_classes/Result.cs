﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Reflection;
using System.Collections;

namespace DatabaseFirstSample.bl_classes
{
    [Serializable]
    [DataContract]
    public class Result<T>
    {
        [DataMember]
        public bool Success { get; set; }
        [DataMember]
        public int ErrorMessage { get; set; }
        [DataMember]
        public T returnObject { get; set; }
        public Result(bool seccess,int errorMessage)
        {
            this.Success = Success;
            this.ErrorMessage = errorMessage;
        }
        public Result(bool success, T returnObject)
        {
            this.getType(returnObject);
            this.Success = success;
            this.returnObject = returnObject;
        }
        public Result(bool success, T returnObject,int errorMessage)
        {
            this.Success = success;
            this.returnObject = returnObject;
            this.ErrorMessage = errorMessage;
        }
        public T getType(T returnObject)
        {
            Type obj = returnObject.GetType();
            PropertyInfo[] propertyInfos = returnObject.GetType().GetProperties();
            returnObject.GetType().GetProperties().Where(m =>
            m.PropertyType.IsGenericType &&
            m.PropertyType.GetGenericTypeDefinition() == typeof(ICollection<>)).ToList();
            foreach (PropertyInfo m in returnObject.GetType().GetProperties())
            {
                if (m.PropertyType.IsGenericType && m.PropertyType.GetGenericTypeDefinition() == typeof(ICollection<>))
                {
                    m.SetValue(returnObject, null);
                }
            }
            return returnObject;
        }
    }
}
