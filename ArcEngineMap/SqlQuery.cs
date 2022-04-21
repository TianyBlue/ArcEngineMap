using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Geodatabase;
using System;
using System.Collections.Generic;
using Npgsql;
using System.Windows.Forms;

namespace ArcEngineMap
{
    class SqlQuery
    {
        private string dbname;
        public IWorkspace GetDBConnect(string dbaddress,string dbname,string username,string password)
        {
            this.dbname = dbname;
            // 创建SqlWorkspaceFactory的对象
            Type pFactoryType = Type.GetTypeFromProgID("esriDataSourcesGDB.SqlWorkspaceFactory");
            IWorkspaceFactory pWorkspaceFactory = (IWorkspaceFactory)Activator.CreateInstance(pFactoryType);
            // 构造连接数据库的参数
            IPropertySet pConnectionProps = new PropertySetClass();
            pConnectionProps.SetProperty("dbclient", "postgresql");
            pConnectionProps.SetProperty("serverinstance", dbaddress);
            pConnectionProps.SetProperty("authentication_mode", "DBMS");
            pConnectionProps.SetProperty("database", dbname);
            pConnectionProps.SetProperty("user", username);
            pConnectionProps.SetProperty("password", password);
            try
            {
                // 打开工作空间
                IWorkspace workspace = pWorkspaceFactory.Open(pConnectionProps, 0);
                return workspace;
            }
            catch (Exception e)
            {
                //throw e;
                MessageBox.Show(e.StackTrace, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

        }

        public List<string> GetAllLayerName(IWorkspace workspace)
        {
            IFeatureWorkspace featureWorkspace = workspace as IFeatureWorkspace;
            List<string> Layernames = new List<string>();

            ISqlWorkspace pSQLWorkspace = featureWorkspace as ISqlWorkspace;
            //获取数据库中的所有表的名称
            IStringArray pStringArray = pSQLWorkspace.GetTables();
            for (int i = 0; i < pStringArray.Count; i++)
            {
                //MessageBox.Show();
                string tableName = pStringArray.get_Element(i);
                tableName = tableName.Replace(dbname+".public.", "");
                Layernames.Add(tableName);
            }
            return Layernames;
        }


        public IFeatureLayer GetFeatureLayer(IWorkspace workspace,string tableName)
        {
            IFeatureWorkspace featureWorkspace = workspace as IFeatureWorkspace;

            ISqlWorkspace pSQLWorkspace = featureWorkspace as ISqlWorkspace;

            // 构造过滤条件 SELECT \* FROM PointQueryLayer
            // 普通的sql表无法读取
            IQueryDescription queryDescription = pSQLWorkspace.GetQueryDescription("SELECT * FROM "+tableName);
            string name2 = "";
            pSQLWorkspace.CheckDatasetName(tableName, queryDescription, out name2);
            ITable pTable = pSQLWorkspace.OpenQueryClass(name2, queryDescription);

            IFeatureLayer pFeatureLayer = new FeatureLayerClass();
            IFeatureClass featureclass = pTable as IFeatureClass;
            pFeatureLayer.FeatureClass = featureclass;
            pFeatureLayer.Name = featureclass.AliasName;
            return pFeatureLayer;
        }

        public bool CheckIfLoginSuccess(string username, string password)
        {
            string connStr = "server=serverip;Port=port;Database=db;uid=uid;pwd=pwd;Encoding=UNICODE";
            NpgsqlConnection conn = new NpgsqlConnection(connStr);
            string sql = "SELECT COUNT(*) FROM userinfo WHERE username='" + username + "' AND password='" + password + "'";
            conn.Open();
            //NpgsqlDataAdapter sda = new NpgsqlDataAdapter(sql, conn);
            NpgsqlCommand command = new NpgsqlCommand(sql, conn);
            NpgsqlDataReader reader = command.ExecuteReader();
            reader.Read();
            //Console.WriteLine(reader.GetString(0));
            int count = (int)reader.GetInt64(0);
            reader.Close();
            conn.Close();
            if (count == 1)
                return true;
            return false;
        }
    }
}