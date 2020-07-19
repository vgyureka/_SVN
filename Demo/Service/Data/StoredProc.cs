using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Service.Data
{
    public class StoredProc
    {
        Dictionary<string, object> _params;
        List<ParamCollection> _parmCollection;
        SqlConnection _connection;
        SqlCommand _command;
        public StoredProc(string procedureName)
        {
            _params = new Dictionary<string, object>();
            _parmCollection = new List<ParamCollection>();

        }
        public StoredProc Param(string name, object value)
        {
            _params[name] = value;
            _parmCollection.Add(new ParamCollection(name, ParamType.Input));
            return this;
        }
        public StoredProc Param(string name, object value, SqlDbType dbType)
        {
            _params[name] = value;
            _parmCollection.Add(new ParamCollection(name, ParamType.Input));
            //_outDbParams.Add(name, dbType);
            return this;
        }
        //StoredProc Execute(string connectionStringName)
        //{
        //    var result = ExecuteInternal(connectionStringName);
        //    return result;
        //}

        private object ExecuteInternal(string connectionStringName)
        {
            var line = string.Empty;
            var uid = UidGenerator.GetUid();
            var startTime = DateTime.Now;
            var duration = 0.0;
            try
            {
                //1. create the command, log time to open connection
                startTime = DateTime.Now;
                _command = Getcommand(connectionStringName);
                duration = (DateTime.Now - startTime).TotalMilliseconds;
                startTime = DateTime.Now;
                //_command.CommandText = _procedureName;
                _command.CommandType = CommandType.Text;

                var pb = new StringBuilder();
                foreach (var parm in _parmCollection)
                {
                    //2a. Add the input parameters
                    if (parm.type == ParamType.Input)
                    {
                        var name = parm.name;
                        var value = _params[parm.name];
                        if (value is List<string>)
                        {
                            var list = value as List<string>;
                            value = '[' + string.Join(",", list) + ']';
                        }
                        pb.Append(string.Format("{0}= {1}", name, value));
                        AddInputParameter(new KeyValuePair<string, object>(
                            parm.name, _params[parm.name]));
                    }
                    //2b. Add the output parameters
                    else if(parm.type == ParamType.Output)
                    {
                        //AddOutputParameter(new KeyValuePair<string, object>(
                        //    parm.name, _outParams[parm.name]));
                    }
                    else if (parm.type == ParamType.InputOutput)
                    {
                        //AddInputOutputParameter(new KeyValuePair<string, object>(
                        //    parm.name, _outParams[parm.name]),_params[parm.name]);
                    }
                    //3. Add the cursors
                    else if(parm.type == ParamType.Cursor)
                    {
                       // _command.Parameters.Add(new SqlParameter(parm.name,SqlDbType.));
                    }
                }
               // CursorDataSet = new DataSet;
                if (_command.CommandType == CommandType.StoredProcedure)
                {
                    //4a. log efore execute
                    //line = string.Format("SP={0}\Tuid={}\TwHEN={}\SP={0}\")
                    //4. EXECUTE THE PROCEDURE
                    _command.ExecuteNonQuery();

                    //5a. load cursors into dataset

                }
                else
                {
                    var reader = _command.ExecuteReader();
                    var table = new DataTable();
                    table.Load(reader);
                    table.TableName = string.Empty;
                    //CursorDataSet.Tables.Add(table);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                // log time to close connection
                startTime = DateTime.Now;
                if (_connection != null && _connection.State == ConnectionState.Open)
                    _connection.Close();
                _connection.Dispose();
                duration = (DateTime.Now - startTime).TotalMilliseconds;
            }
            return this;
        }

        private void AddInputParameter(KeyValuePair<string, object> parm)
        {
            parm = AddParameterWithInput(parm, ParameterDirection.Input);
        }

        private KeyValuePair<string, object> AddParameterWithInput(KeyValuePair<string, object> parm, ParameterDirection direction)
        {
            var name = parm.Key;
            var value = parm.Value;
            SqlParameter tempParam = null;
            if (value is string)
            {
                tempParam = new SqlParameter(name, SqlDbType.VarChar);//, value, direction);
            }
            else if (value is byte[])
            {
                tempParam = new SqlParameter();
                tempParam.ParameterName = name;
                tempParam.Direction = ParameterDirection.Input;
                tempParam.Value = (byte[])value;
                tempParam.Size = (value as byte[]).Length;
            }
            else if (value is IList)
            {
                var v1 = (value as IList).Cast<object>().ToArray();
                var dbType = value is IList<string> ? SqlDbType.VarChar : SqlDbType.Decimal;
                tempParam = new SqlParameter(name, dbType);//,direction);
                if (v1.Length == 0)
                    tempParam.Value = new object[] { DBNull.Value };
                else
                    tempParam.Value = v1;
                tempParam.Size = v1.Length;
            }
            else if (value is DateTime)
            {
                var date = (DateTime)value;
                if (date == DateTime.MinValue)
                {
                    value = string.Empty;
                    tempParam = new SqlParameter(name, SqlDbType.VarChar);//, string.Empty, direction);
                }
                else
                    tempParam = new SqlParameter(name, SqlDbType.Timestamp);//, string.Empty, direction);
            }
            else if (value is decimal || value is double || value is int || value is long || value is short)
                _command.Parameters.Add(new SqlParameter(name, SqlDbType.BigInt));
            else if(value is bool)
            {
                //value = (bool)value ? "Y" : _boolFalse;
                //tempParam = new SqlParameter(name,SqlDbType.VarChar);
            }
            else if (value is XmlDocument)
            {
                var xml = (XmlDocument)value;
                if (string.IsNullOrWhiteSpace(xml.InnerXml))
                    tempParam = new SqlParameter(name, SqlDbType.Xml);//,DBNull.Value,direction);
                else
                    tempParam = new SqlParameter(name, SqlDbType.Xml);//,xml.InnerXml, direction);
            }
            else if (value ==null)
            {
                tempParam = new SqlParameter(name,SqlDbType.VarChar);
            }

            if (tempParam !=null)
            {
                //if (_outDbParams.ContainsKey(name))
                //    tempParam.SqlDbType = _outDbParams[name];

                _command.Parameters.Add(tempParam);
            }
            return parm;
        }

        private SqlCommand Getcommand(string connectionStringName)
        {
            //_connection = new OracleConnection;
            _connection = new SqlConnection();
            _connection.ConnectionString = GetConnStr("ENV_KEY");

            var Command = _connection.CreateCommand();
            Command.CommandType = CommandType.StoredProcedure;
            _connection.Open();
            return Command;
        }

        private string GetConnStr(string key)
        {
            return ConfigurationManager.ConnectionStrings[key].ConnectionString;
        }

        public static class UidGenerator
        {
            static Random _random;
            public static string GetUid()
            {
                if (_random == null)
                    _random = new Random(DateTime.Now.Millisecond); ;

                return _random.Next(9999).ToString("0000");
            }
        }

        enum ParamType
        {
            Input,
            Output,
            Cursor,
            InputOutput
        }
        class ParamCollection
        {
            public ParamType type { get; set; }
            public string name { get; set; }
            public ParamCollection(string name, ParamType type)
            {
                this.name = name;
                this.type = type;
            }
        }
    }
}
