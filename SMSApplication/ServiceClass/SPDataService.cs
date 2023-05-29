using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSApplication.ServiceClass
{
    class SPDataService
    {
        DataError objError;

        SPCall tmpspcall = new SPCall();
        public System.Data.SqlClient.SqlConnection objConn;
        DataBind objbind = new DataBind();

        public SPDataService()
        {
            try
            {
                string connectstring = tmpspcall.connectionstring();
                objConn = new System.Data.SqlClient.SqlConnection(connectstring);
                if (objConn.State == ConnectionState.Closed)
                    objConn.Open();
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }

        }
        public string spdbbackup(string path)
        {
            DataSet ds = new DataSet();
            try
            {
                tmpspcall = new SPCall();
                SqlCommand varSqlCommand = new SqlCommand("SpDBbackup", tmpspcall.objConn);
                varSqlCommand.CommandType = CommandType.StoredProcedure;
                varSqlCommand.Parameters.AddWithValue("@path", path);
                varSqlCommand.CommandTimeout = 0;
                varSqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                tmpspcall.CloseConnection();
            }
            return "success";
        }
        public void CloseConnection()
        {
            if ((objConn == null) == true)
                return;
            if (objConn.State == ConnectionState.Open)
                objConn.Close();

        }     
        public int udfnExecuteQuery(string paraConnectedQuery)
        {
            int udfn = 0;
            try
            {
                tmpspcall = new SPCall();
                SqlCommand varSqlCommand = new SqlCommand("PROC_DEF_ExecuteQuery", tmpspcall.objConn);
                varSqlCommand.CommandType = CommandType.StoredProcedure;
                varSqlCommand.Parameters.AddWithValue("@paraConnectedQuery", paraConnectedQuery);
                varSqlCommand.CommandTimeout = 0;
                varSqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
            finally
            {
                tmpspcall.CloseConnection();
            }
            return udfn;
        }
        public int udfnExecuteQuery2Parameter(string paraConnectedQuery1, string paraConnectedQuery2)
        {
            int udfn = 0;

            try
            {
                tmpspcall = new SPCall();
                SqlCommand varSqlCommand = new SqlCommand("SpExecuteQuery2Parameter", tmpspcall.objConn);
                varSqlCommand.CommandType = CommandType.StoredProcedure;
                varSqlCommand.Parameters.AddWithValue("@connectedQuery1", paraConnectedQuery1);
                varSqlCommand.Parameters.AddWithValue("@connectedQuery2", paraConnectedQuery2);
                varSqlCommand.CommandTimeout = 0;
                varSqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
            finally
            {
                tmpspcall.CloseConnection();
            }
            return udfn;
        }
        public int udfnExecuteQuery3Parameter(string paraConnectedQuery1, string paraConnectedQuery2, string paraConnectedQuery3)
        {
            int udfn = 0;

            try
            {
                tmpspcall = new SPCall();
                SqlCommand varSqlCommand = new SqlCommand("SpExecuteQuery3Parameter", tmpspcall.objConn);
                varSqlCommand.CommandType = CommandType.StoredProcedure;
                varSqlCommand.Parameters.AddWithValue("@connectedQuery1", paraConnectedQuery1);
                varSqlCommand.Parameters.AddWithValue("@connectedQuery2", paraConnectedQuery2);
                varSqlCommand.Parameters.AddWithValue("@connectedQuery3", paraConnectedQuery3);
                varSqlCommand.CommandTimeout = 0;
                varSqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
            finally
            {
                tmpspcall.CloseConnection();
            }
            return udfn;
        }       
        public DataSet udfnsubmenu(string process)
        {
            DataSet ds = new DataSet();
            try
            {
                tmpspcall = new SPCall();
                SqlCommand varSqlCommand = new SqlCommand("SPSubMenu", tmpspcall.objConn);
                varSqlCommand.CommandType = CommandType.StoredProcedure;
                varSqlCommand.Parameters.AddWithValue("@Process", process);
                varSqlCommand.CommandTimeout = 0;
                SqlDataAdapter sa = new SqlDataAdapter(varSqlCommand);
                sa.Fill(ds);
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
            finally
            {
                tmpspcall.CloseConnection();
            }
            return ds;

        }
        public DataSet udfnGetDataset(string Process, string Condition)
        {
            DataSet ds = new DataSet();

            try
            {
                tmpspcall = new SPCall();
                SqlCommand varSqlCommand = new SqlCommand("[PROC_DEF_GetMasters]", tmpspcall.objConn);
                varSqlCommand.CommandType = CommandType.StoredProcedure;
                varSqlCommand.Parameters.AddWithValue("@paraProcess", Process);
                varSqlCommand.Parameters.AddWithValue("@paraCondition", Condition);
                varSqlCommand.CommandTimeout = 0;
                SqlDataAdapter sa = new SqlDataAdapter(varSqlCommand);
                sa.Fill(ds);
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
            finally
            {
                tmpspcall.CloseConnection();
            }
            return ds;
        }



        //--  change password ---
      

        public string udfnchangepassword(string paraUserID, string paraOldPassword, string paranewpassword, string paraoriginator)
        {
            string result = "";
            try
            {
                tmpspcall = new SPCall();
                SqlCommand varSqlCommand = new SqlCommand("[PROC_CHANGE_PASSWORD]", tmpspcall.objConn);
                varSqlCommand.CommandType = CommandType.StoredProcedure;
                varSqlCommand.Parameters.AddWithValue("@paranewpassword", paranewpassword);
                varSqlCommand.Parameters.AddWithValue("@paraOldPassword", paraOldPassword);
                varSqlCommand.Parameters.AddWithValue("@paraUserID", paraUserID); 
                varSqlCommand.Parameters.AddWithValue("@paraoriginator", paraoriginator);
                varSqlCommand.CommandTimeout = 0;
                result = varSqlCommand.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
            finally
            {
                tmpspcall.CloseConnection();
            }
            return result;
        }


        //--  staff master ---
        public string udfnStaffMaster(string paraprocess, string parastaffid, string parastaffname, string paramobile, string paraDOB, string paraBloodGroup, string paraDesignation, string paraUserID, 
                 string paraStatus, string paraOriginator, string paraaddress1, string paraaddress2, string paraaddress3, string paracity,string parapincode,string paraRfCardno,string parasource)
        {
            string result = "";
            try
            {
                tmpspcall = new SPCall();
                SqlCommand varSqlCommand = new SqlCommand("[PROC_STAFF]", tmpspcall.objConn);
                varSqlCommand.CommandType = CommandType.StoredProcedure;
                varSqlCommand.Parameters.AddWithValue("@paraProcess", paraprocess);
                varSqlCommand.Parameters.AddWithValue("@ParaStaffId", parastaffid);
                varSqlCommand.Parameters.AddWithValue("@paraStaffName", parastaffname);
                varSqlCommand.Parameters.AddWithValue("@paramobile", paramobile);
                varSqlCommand.Parameters.AddWithValue("@paraDOB", paraDOB);
                varSqlCommand.Parameters.AddWithValue("@paraBloodGroup", paraBloodGroup);
                varSqlCommand.Parameters.AddWithValue("@paraDesignation", paraDesignation);
                varSqlCommand.Parameters.AddWithValue("@paraUserID", paraUserID);
                varSqlCommand.Parameters.AddWithValue("@paraStatus", paraStatus);
                varSqlCommand.Parameters.AddWithValue("@paraOriginator", paraOriginator);
                varSqlCommand.Parameters.AddWithValue("@paraaddress1", paraaddress1);
                varSqlCommand.Parameters.AddWithValue("@paraaddress2", paraaddress2);
                varSqlCommand.Parameters.AddWithValue("@paraaddress3", paraaddress3);
                varSqlCommand.Parameters.AddWithValue("@paracity", paracity);
                varSqlCommand.Parameters.AddWithValue("@parapincode", parapincode);
                varSqlCommand.Parameters.AddWithValue("@paraRfCardno", paraRfCardno);
                varSqlCommand.Parameters.AddWithValue("@parasource", parasource);
                

                varSqlCommand.CommandTimeout = 0;
                result = varSqlCommand.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
            finally
            {
                tmpspcall.CloseConnection();
            }
            return result;
        }
        

        public DataSet udfnStaffMasterLIST(string paraprocess, string parastaffid, string paraUserID)
        {
            DataSet ds = new DataSet();
            try
            {
                tmpspcall = new SPCall();
                SqlCommand varSqlCommand = new SqlCommand("[PROC_STAFF_LIST]", tmpspcall.objConn);
                varSqlCommand.CommandType = CommandType.StoredProcedure;
                varSqlCommand.Parameters.AddWithValue("@paraProcess", paraprocess);
                varSqlCommand.Parameters.AddWithValue("@ParaStaffId", parastaffid);
                varSqlCommand.Parameters.AddWithValue("@paraUserID", paraUserID);
                varSqlCommand.CommandTimeout = 0;
                SqlDataAdapter sa = new SqlDataAdapter(varSqlCommand);
                sa.Fill(ds);
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
            finally
            {
                tmpspcall.CloseConnection();
            }
            return ds;
        }


        //--  student master ---

        public string udfnStudentMaster(string paraprocess, string paraStudentId, string paraStudentname,string paraAdmissinno, string paramobile,string paraalternativemobile, string paraDOB,
            string paraBloodGroup, string paraclassSection, string paraUserID,
            string paraStatus, string paraOriginator, string paraaddress1, string paraaddress2, string paraaddress3, string paracity, string parapincode,string paraparentname,string pararfidno,string parasource)
        {
            string result = "";
            try
            {
                tmpspcall = new SPCall();
                SqlCommand varSqlCommand = new SqlCommand("[PROC_Student]", tmpspcall.objConn);
                varSqlCommand.CommandType = CommandType.StoredProcedure;
                varSqlCommand.Parameters.AddWithValue("@paraProcess", paraprocess);
                varSqlCommand.Parameters.AddWithValue("@paraStudentId", paraStudentId);
                varSqlCommand.Parameters.AddWithValue("@paraStudentname", paraStudentname);
                varSqlCommand.Parameters.AddWithValue("@paraAdmissinno", paraAdmissinno);
                varSqlCommand.Parameters.AddWithValue("@paraDOB", paraDOB); 
                varSqlCommand.Parameters.AddWithValue("@paraBloodGroup", paraBloodGroup); 
                varSqlCommand.Parameters.AddWithValue("@paramobile", paramobile); 
                varSqlCommand.Parameters.AddWithValue("@paraalternativemobile", paraalternativemobile); 
                varSqlCommand.Parameters.AddWithValue("@paraclassSection", paraclassSection);
                varSqlCommand.Parameters.AddWithValue("@paraUserID", paraUserID);
                varSqlCommand.Parameters.AddWithValue("@paraStatus", paraStatus);
                varSqlCommand.Parameters.AddWithValue("@paraOriginator", paraOriginator);
                varSqlCommand.Parameters.AddWithValue("@paraaddress1", paraaddress1);
                varSqlCommand.Parameters.AddWithValue("@paraaddress2", paraaddress2);
                varSqlCommand.Parameters.AddWithValue("@paraaddress3", paraaddress3);
                varSqlCommand.Parameters.AddWithValue("@paracity", paracity);
                varSqlCommand.Parameters.AddWithValue("@parapincode", parapincode);
                varSqlCommand.Parameters.AddWithValue("@paraparentname", paraparentname); 
                varSqlCommand.Parameters.AddWithValue("@pararfidno", pararfidno);
                varSqlCommand.Parameters.AddWithValue("@parasource", parasource);

                varSqlCommand.CommandTimeout = 0;
                result = varSqlCommand.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
            finally
            {
                tmpspcall.CloseConnection();
            }
            return result;
        }



        public DataSet udfnStudentMasterlist(string paraprocess, string paraStudentid, string paraUserID,string paraclassid)
        {
            DataSet ds = new DataSet();
            try
            {
                tmpspcall = new SPCall();
                SqlCommand varSqlCommand = new SqlCommand("[PROC_Student_LIST]", tmpspcall.objConn);
                varSqlCommand.CommandType = CommandType.StoredProcedure;
                varSqlCommand.Parameters.AddWithValue("@paraProcess", paraprocess);
                varSqlCommand.Parameters.AddWithValue("@ParastudentId", paraStudentid);
                varSqlCommand.Parameters.AddWithValue("@paraUserID", paraUserID);
                varSqlCommand.Parameters.AddWithValue("@paraclassid", paraclassid); 
                varSqlCommand.CommandTimeout = 0;
                SqlDataAdapter sa = new SqlDataAdapter(varSqlCommand);
                sa.Fill(ds);
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
            finally
            {
                tmpspcall.CloseConnection();
            }
            return ds;
        }

        public string udfnstudentmasterimport(string paraProcess,  DataTable paramr_Student, string paraUserID,string paraOriginator)
        {
            string result = "";
            try
            {
                tmpspcall = new SPCall();
                SqlCommand varSqlCommand = new SqlCommand("[PROC_STUDENT_IMPORT]", tmpspcall.objConn);
                varSqlCommand.CommandType = CommandType.StoredProcedure;
                varSqlCommand.Parameters.AddWithValue("@paraProcess", paraProcess);
                varSqlCommand.Parameters.AddWithValue("@paramr_Student", paramr_Student);
                varSqlCommand.Parameters.AddWithValue("@paraUserID", paraUserID);
                varSqlCommand.Parameters.AddWithValue("@paraOriginator", paraOriginator);
                varSqlCommand.CommandTimeout = 0;
                result = varSqlCommand.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
            finally
            {
                tmpspcall.CloseConnection();
            }
            return result;
        }
        //--STAFF MASTER IMPORT--
        public string udfnstaffmasterimport(string paraProcess, DataTable paramr_Staff, string paraUserID, string paraOriginator)
        {
            string result = "";
            try
            {
                tmpspcall = new SPCall();
                SqlCommand varSqlCommand = new SqlCommand("[PROC_STAFF_IMPORT]", tmpspcall.objConn);
                varSqlCommand.CommandType = CommandType.StoredProcedure;
                varSqlCommand.Parameters.AddWithValue("@paraProcess", paraProcess);
                varSqlCommand.Parameters.AddWithValue("@paramr_Staff", paramr_Staff);
                varSqlCommand.Parameters.AddWithValue("@paraUserID", paraUserID);
                varSqlCommand.Parameters.AddWithValue("@paraOriginator", paraOriginator);
                varSqlCommand.CommandTimeout = 0;
                result = varSqlCommand.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
            finally
            {
                tmpspcall.CloseConnection();
            }
            return result;
        }
        //--SENDER MASTER --
        public string udfnsenderidmaster(string paraprocess,string parasenderid, string parasendername, string parastatus,string paraUserID,string paraOriginator)
        {   
            string result = "";
            try
            {
                tmpspcall = new SPCall();
                SqlCommand varSqlCommand = new SqlCommand("[PROC_SENDER]", tmpspcall.objConn);
                varSqlCommand.CommandType = CommandType.StoredProcedure;
                varSqlCommand.Parameters.AddWithValue("@paraProcess", paraprocess);
                varSqlCommand.Parameters.AddWithValue("@parasendername", parasendername);
                varSqlCommand.Parameters.AddWithValue("@parasenderid", parasenderid);  
                varSqlCommand.Parameters.AddWithValue("@parastatus", parastatus);
                varSqlCommand.Parameters.AddWithValue("@paraUserID", paraUserID); 
                varSqlCommand.Parameters.AddWithValue("@paraOriginator", paraOriginator);

                varSqlCommand.CommandTimeout = 0;
                result = varSqlCommand.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
            finally
            {
                tmpspcall.CloseConnection();
            }
            return result;
        }
         
             public DataSet udfnsenderidmasterlist(string paraprocess, string parasenderid, string paraUserID)
        {
            DataSet ds = new DataSet();
            try
            {
                tmpspcall = new SPCall();
                SqlCommand varSqlCommand = new SqlCommand("[PROC_SENDER_list]", tmpspcall.objConn);
                varSqlCommand.CommandType = CommandType.StoredProcedure;
                varSqlCommand.Parameters.AddWithValue("@paraProcess", paraprocess); 
                varSqlCommand.Parameters.AddWithValue("@parasenderid", parasenderid);  
                varSqlCommand.Parameters.AddWithValue("@paraUserID", paraUserID); 

                varSqlCommand.CommandTimeout = 0;
                SqlDataAdapter sa = new SqlDataAdapter(varSqlCommand);
                sa.Fill(ds);
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
            finally
            {
                tmpspcall.CloseConnection();
            }
            return ds;
        }
        //--TEMPLATE MASTER
        public string udfntemplatemaster(string paraprocess, string paratemplateid, string paratempname,string paratemplatevalue, string paraconenttype, string parasender, string paratempconent, string parastatus, string paraUserID, string paraOriginator)
        {
            string result = "";
            try
            {
                tmpspcall = new SPCall();
                SqlCommand varSqlCommand = new SqlCommand("[PROC_TEMPLATE]", tmpspcall.objConn);
                varSqlCommand.CommandType = CommandType.StoredProcedure;
                varSqlCommand.Parameters.AddWithValue("@paraProcess", paraprocess);
                varSqlCommand.Parameters.AddWithValue("@paratempname", paratempname);
                varSqlCommand.Parameters.AddWithValue("@paratemplateid", paratemplateid);
                varSqlCommand.Parameters.AddWithValue("@paratemplatevalue", paratemplatevalue);
                varSqlCommand.Parameters.AddWithValue("@paraconenttype", paraconenttype); 
                varSqlCommand.Parameters.AddWithValue("@parasender", parasender);
                varSqlCommand.Parameters.AddWithValue("@paratempconent", paratempconent);
                varSqlCommand.Parameters.AddWithValue("@parastatus", parastatus); 
                varSqlCommand.Parameters.AddWithValue("@paraUserID", paraUserID);
                varSqlCommand.Parameters.AddWithValue("@paraOriginator", paraOriginator);

                varSqlCommand.CommandTimeout = 0;
                result = varSqlCommand.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
            finally
            {
                tmpspcall.CloseConnection();
            }
            return result;
        }

        public DataSet udfnTemplatemasterlist(string paraprocess, string paratemplateid, string paraUserID)
        {
            DataSet ds = new DataSet();
            try
            {
                tmpspcall = new SPCall();
                SqlCommand varSqlCommand = new SqlCommand("[PROC_TEMPLATE_LIST]", tmpspcall.objConn);
                varSqlCommand.CommandType = CommandType.StoredProcedure;
                varSqlCommand.Parameters.AddWithValue("@paraProcess", paraprocess);
                varSqlCommand.Parameters.AddWithValue("@paratemplateid", paratemplateid);
                varSqlCommand.Parameters.AddWithValue("@paraUserID", paraUserID);

                varSqlCommand.CommandTimeout = 0;
                SqlDataAdapter sa = new SqlDataAdapter(varSqlCommand);
                sa.Fill(ds);
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
            finally
            {
                tmpspcall.CloseConnection();
            }
            return ds;
        }

        //--Genreal settings--
        public string udfngenralsettings(string paraprocess, string parasettingid, string paranumbers, string paraUserID, string paraOriginator)
        {
            string result = ""; 
            try
            {
                tmpspcall = new SPCall();
                SqlCommand varSqlCommand = new SqlCommand("[PROC_GenralSetting]", tmpspcall.objConn);
                varSqlCommand.CommandType = CommandType.StoredProcedure;
                varSqlCommand.Parameters.AddWithValue("@paraProcess", paraprocess); 
                varSqlCommand.Parameters.AddWithValue("@paranumbers", paranumbers);
                varSqlCommand.Parameters.AddWithValue("@parasettingid", parasettingid); 
                varSqlCommand.Parameters.AddWithValue("@paraUserID", paraUserID);
                varSqlCommand.Parameters.AddWithValue("@paraOriginator", paraOriginator);

                varSqlCommand.CommandTimeout = 0;
                result = varSqlCommand.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
            finally
            {
                tmpspcall.CloseConnection();
            }
            return result;
        }
        //--SMS MASTER LIST
        public DataSet udfnsmsstudentmasterlist(string paraprocess, string paratudentid, string paraUserID,string paratotime,string parafromtime,string parastudentleft)
        {
            DataSet ds = new DataSet();
            try
            {
                tmpspcall = new SPCall();
                SqlCommand varSqlCommand = new SqlCommand("[PROC_STUDENT_ATTENDANCE_LIST]", tmpspcall.objConn);
                varSqlCommand.CommandType = CommandType.StoredProcedure;
                varSqlCommand.Parameters.AddWithValue("@paraProcess", paraprocess);
                varSqlCommand.Parameters.AddWithValue("@paratudentid", paratudentid);
                varSqlCommand.Parameters.AddWithValue("@paraUserID", paraUserID);
                varSqlCommand.Parameters.AddWithValue("@parafromtime", parafromtime);
                varSqlCommand.Parameters.AddWithValue("@paratotime", paratotime); 
                varSqlCommand.Parameters.AddWithValue("@parastudentleft", parastudentleft);

                varSqlCommand.CommandTimeout = 0;
                SqlDataAdapter sa = new SqlDataAdapter(varSqlCommand);
                sa.Fill(ds);
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
            finally
            {
                tmpspcall.CloseConnection();
            }
            return ds;
        }

        public DataSet udfnsmsstaffmasterlist(string paraprocess, string parastaffid, string paraUserID, string paratotime, string parafromtime,string parastudentleft)
        {
            DataSet ds = new DataSet();
            try
            {
                tmpspcall = new SPCall();
                SqlCommand varSqlCommand = new SqlCommand("[PROC_STAFF_ATTENDANCE_LIST]", tmpspcall.objConn);
                varSqlCommand.CommandType = CommandType.StoredProcedure;
                varSqlCommand.Parameters.AddWithValue("@paraProcess", paraprocess);
                varSqlCommand.Parameters.AddWithValue("@parastaffid", parastaffid);
                varSqlCommand.Parameters.AddWithValue("@paraUserID", paraUserID);
                varSqlCommand.Parameters.AddWithValue("@parafromtime", parafromtime);
                varSqlCommand.Parameters.AddWithValue("@paratotime", paratotime); 
                varSqlCommand.Parameters.AddWithValue("@parastudentleft", parastudentleft);

                varSqlCommand.CommandTimeout = 0;
                SqlDataAdapter sa = new SqlDataAdapter(varSqlCommand);
                sa.Fill(ds);
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
            finally
            {
                tmpspcall.CloseConnection();
            }
            return ds;
        }

        //-- SNED SMS--FOR STUDENT //

        public string udfnsendsms(string paraProcess, string paradate, string paraintime, string paraabsent, string paraouttime, string parasmscount, string paraUserID, string paraOriginator,string parastudentleft)
        {
            string result = "";
            try
            {
                tmpspcall = new SPCall();
                SqlCommand varSqlCommand = new SqlCommand("[PROC_SENDSMS_STUDENT]", tmpspcall.objConn);
                varSqlCommand.CommandType = CommandType.StoredProcedure;
                varSqlCommand.Parameters.AddWithValue("@paraProcess", paraProcess);
                varSqlCommand.Parameters.AddWithValue("@paradate", paradate);
                varSqlCommand.Parameters.AddWithValue("@paraintime", paraintime);
                varSqlCommand.Parameters.AddWithValue("@paraabsent", paraabsent);
                varSqlCommand.Parameters.AddWithValue("@paraouttime", paraouttime);
                varSqlCommand.Parameters.AddWithValue("@parasmscount", parasmscount);
                varSqlCommand.Parameters.AddWithValue("@paraUserID", paraUserID);
                varSqlCommand.Parameters.AddWithValue("@paraOriginator", paraOriginator);
                varSqlCommand.Parameters.AddWithValue("@parastudentleft", parastudentleft);

                varSqlCommand.CommandTimeout = 0;
                result = varSqlCommand.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
            finally
            {
                tmpspcall.CloseConnection();
            }
            return result;
        }


        public string udfnsendsmsSTAFF(string paraProcess, string paradate, string paraintime, string parasendernumber,string paraouttime, string parasmscount, string paraUserID, string paraOriginator )
        {
            string result = "";
            try
            {
                tmpspcall = new SPCall();
                SqlCommand varSqlCommand = new SqlCommand("[PROC_SENDSMS_STAFF]", tmpspcall.objConn);
                varSqlCommand.CommandType = CommandType.StoredProcedure;
                varSqlCommand.Parameters.AddWithValue("@paraProcess", paraProcess);
                varSqlCommand.Parameters.AddWithValue("@paradate", paradate);
                varSqlCommand.Parameters.AddWithValue("@paraintime", paraintime); 
                varSqlCommand.Parameters.AddWithValue("@parasendernumber", parasendernumber);
                varSqlCommand.Parameters.AddWithValue("@paraouttime", paraouttime); 
                varSqlCommand.Parameters.AddWithValue("@parasmscount", parasmscount);
                varSqlCommand.Parameters.AddWithValue("@paraUserID", paraUserID);
                varSqlCommand.Parameters.AddWithValue("@paraOriginator", paraOriginator); 

                varSqlCommand.CommandTimeout = 0;
                result = varSqlCommand.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
            finally
            {
                tmpspcall.CloseConnection();
            }
            return result;
        }
    }
}
