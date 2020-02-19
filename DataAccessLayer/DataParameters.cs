using System;
using System.Collections.Generic;
using System.Text;
using System.Data;//se debe agregar este Using porque vamos a trabajar con datos

namespace DataAccessLayer
{
    public class DataParameters
    {
        //Declaramos los parametros. Se ponen los atributos de los parametros en SQL

        private string Name { get; set; }
        private object Value { get; set; }
        private SqlDbType DataType { get; set; }
        private int Size { get; set; }
        private ParameterDirection Direction { get; set; }

        //Declaramos los constructores
        //Parametros de entrada en SQL
        public DataParameters(string _name, object _value)
        {
            Name = _name;
            Value = _value;
            Direction = ParameterDirection.Input;
        }
        //Parametros de salida en SQL

        public DataParameters(string _name,SqlDbType _datatype,int _size)
        {
            Name = _name;
            DataType = _datatype;
            Size = _size;
            Direction = ParameterDirection.Output;
        }

    }
}
