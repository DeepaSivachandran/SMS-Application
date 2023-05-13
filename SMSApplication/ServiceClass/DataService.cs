using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSApplication.ServiceClass
{
    class DataService
    {
        public System.Data.SqlClient.SqlConnection ObjConn;
        public System.Data.SqlClient.SqlCommand objCmd;
        public System.Data.SqlClient.SqlDataAdapter objDA;
        public System.Data.SqlClient.SqlCommandBuilder objCB;
        public DataSet objDS;
        public DataTable ObjDT;
        SPCall tmpspcall = new SPCall();
        string strQuery;
        DataError objError;
        DataBind objbind = new DataBind();
        public DataService()
        {
            try
            {
                string connectstring = tmpspcall.connectionstring();
                ObjConn = new System.Data.SqlClient.SqlConnection(connectstring);
                if (ObjConn.State == ConnectionState.Closed)
                    ObjConn.Open();
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }

        }
        public bool blnFindRecord(string strTableName, string strCondition)
        {
            bool blnString = false;
            try
            {
                tmpspcall = new SPCall();
                strQuery = "SELECT COUNT(*) FROM " + strTableName + " WHERE " + strCondition;
                objCmd = new System.Data.SqlClient.SqlCommand(strQuery, tmpspcall.objConn);
                if (Convert.ToInt32(objCmd.ExecuteScalar()) != 0)
                {
                    blnString = true;
                }
                else
                {
                    blnString = false;
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
            return blnString;
        }
        public string ReplaceQuotes(string strValue)
        {
            strValue = strValue.Replace("'", "''");
            return strValue;
        }
        public void CloseConnection()
        {
            if ((ObjConn == null) == true)
                return;
            if (ObjConn.State == ConnectionState.Open)
                ObjConn.Close();
            ObjConn = null;
            objCmd = null;
            objCB = null;
            objDS = null;
            ObjDT = null;
        }
        public string displaydata(string strQuery)
        {
            string functionReturnValue = null;
            try
            {
                objCmd = new SqlCommand(strQuery, ObjConn);
                objDA = new SqlDataAdapter(strQuery, ObjConn);
                objDS = new DataSet();
                objDA.Fill(objDS);
                ObjDT = objDS.Tables[0];
                if (objDS.Tables[0].Rows.Count > 0)
                {
                    functionReturnValue = objDS.Tables[0].Rows[0][0].ToString();
                }
                else
                {
                    functionReturnValue = "";
                }
                if (functionReturnValue == null)
                    functionReturnValue = "";
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
            return functionReturnValue;
        }
        public DataSet GetDataset(string strSQL)
        {
            tmpspcall = new SPCall();
            DataSet functionReturnValue = default(DataSet);
            objCmd = new System.Data.SqlClient.SqlCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED " + strSQL + " SET TRANSACTION ISOLATION LEVEL READ COMMITTED", ObjConn);
            objCmd.CommandText = strSQL;
            dynamic objDS = new DataSet();
            dynamic objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, tmpspcall.objConn);
            objDA.Fill(objDS);
            functionReturnValue = null;
            functionReturnValue = objDS;
            return functionReturnValue;
        }
        public void FillDataSetSelectedField(string strTableName, string strCondition, string strCondition2)
        {
            try
            {
                strQuery = "SELECT " + strCondition2 + " FROM " + strTableName + " WHERE " + strCondition;
                objCmd = new System.Data.SqlClient.SqlCommand(strQuery, ObjConn);
                objDA = new System.Data.SqlClient.SqlDataAdapter(strQuery, ObjConn);
                objDS = new DataSet();
                objDA.Fill(objDS, strTableName);
                ObjDT = objDS.Tables[strTableName];
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
    }
}
