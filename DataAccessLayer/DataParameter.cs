using System.Data;//se debe agregar este Using porque vamos a trabajar con datos

namespace DataAccessLayer
{
    public class DataParameter
    {
        //Declaramos los parametros. Se ponen los atributos de los parametros en SQL

        public string Name { get; set; }
        public object Value { get; set; }
        public SqlDbType DataType { get; set; }
        public int Size { get; set; }
        public ParameterDirection Direction { get; set; }

        //Declaramos los constructores
        //Parametros de entrada en SQL
        public DataParameter(string _name, object _value)
        {
            Name = _name;
            Value = _value;
            Direction = ParameterDirection.Input;
        }
        //Parametros de salida en SQL

        public DataParameter(string _name, SqlDbType _datatype, int _size)
        {
            Name = _name;
            DataType = _datatype;
            Size = _size;
            Direction = ParameterDirection.Output;
        }

    }
}
