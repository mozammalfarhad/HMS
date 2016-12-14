using System.Data;
using System.Collections;
using VIT.DataLogicLayer;
using System.Data.SqlClient;

namespace HMS.DAL
{
    public class dalCommon
    {
       
        public DataTable GetMsgList(string module)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@Module", module));
            DataTable dt = DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("USP_CustomMessage_GetAll", altParams);
            return dt;
        }
        public DataTable GetMsg(int ID, string strHeader)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@NUMID", ID));
            altParams.Add(new SqlParameter("@strHeader", ID));
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("USP_CustomMessage_Get", altParams);
        }       

        public int UpdateMsg(int ID, string strMessage)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@NUMID", ID));
            altParams.Add(new SqlParameter("@strMessage", strMessage));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("USP_CustomMessage_Update", altParams);           
        }

        #region Import Data

        public DataTable GetImportHistory()
        {
            ArrayList altParams = new ArrayList();
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("USP_ImportHistory_GetByModule", altParams);           
        }

        public int InsertImportHistory(string  UserName, string DataFileName, int ItemsSuccedded, int ItemsFailed)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@UserName", UserName));
            altParams.Add(new SqlParameter("@DataFileName", DataFileName));
            altParams.Add(new SqlParameter("@ItemsSuccedded", ItemsSuccedded));
            altParams.Add(new SqlParameter("@ItemsFailed", ItemsFailed));

            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("USP_ImportHistory_Insert", altParams);
        }

        #endregion

        #region Offline Data Upload

        public DataSet GetOfflineData(int clubId)
         {
            DataSet ds = new DataSet("dsOfflineData");   
            ArrayList altParams = new ArrayList();

            altParams.Add(new SqlParameter("@ClubID", clubId));

            ds.Tables.Add(DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("USP_Score_Deleted_GetOfflineEntries_GetByClubID", altParams));
            ds.Tables.Add(DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("USP_Tournament_Deleted_GetOfflineEntries_ByClub", altParams));
            ds.Tables.Add(DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("USP_Tournament_GetOfflineEntries_ByClub", altParams));
            ds.Tables.Add(DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("USP_Score_GetOfflineEntries_GetByClubID", altParams));
            ds.Tables.Add(DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("USP_Score_GetOfflineEntriesGuestScores_GetByClubID", altParams));
            ds.Tables.Add(DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("USP_MemberHandicapRecords_GetOfflineEntries_GetByClubID", altParams));
            ds.Tables.Add(DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("USP_Log_GetOfflineEntries", altParams));
                                                                                            

            return ds;
        }

        public DataSet GetOfflineMember(int clubId)
        {
            DataSet ds = new DataSet("dsOfflineData");
            ArrayList altParams = new ArrayList();

            altParams.Add(new SqlParameter("@ClubID", clubId));
            ds.Tables.Add(DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("USP_Member_Deleted_GetOfflineEntries_GetByClubID", altParams));
            ds.Tables.Add(DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("USP_Member_GetOfflineEntries_GetByClubID", altParams));

            return ds;
        }

        public DataSet GetErrorDownloadData(string SessionID)
        {
            DataSet ds = new DataSet("dsOfflineData");

            ArrayList altParams = new ArrayList();

            altParams.Add(new SqlParameter("@Error_SessionID", SessionID));

            ds.Tables.Add(DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("USP_DB_Error_Log_GetErrorData_GetBySessionID", altParams));

            return ds;
        }

        public int InsertOfflineData(string XMLData, string ImportedBy )
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@XMLData", XMLData));
            altParams.Add(new SqlParameter("@ImportedBy", ImportedBy));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("USP_ImportOfflineData", altParams);
        }

        public int InsertOfflineMemeberUploadHistory(string UploadedBy, string FileName, int ClubID)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@UploadedBy", UploadedBy));
            altParams.Add(new SqlParameter("@FileName", FileName));
            altParams.Add(new SqlParameter("@ClubID", ClubID));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("USP_OffLineMemberUploadHistory_Insert", altParams);
        }
        public int InsertOfflineDataUploadHistory(string UploadedBy, string FileName, int ClubID)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@UploadedBy", UploadedBy));
            altParams.Add(new SqlParameter("@FileName", FileName));
            altParams.Add(new SqlParameter("@ClubID", ClubID));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("USP_OffLineDataUploadHistory_Insert", altParams);
        }

        public DataTable GetOfflineDataUploadHistory(int ClubID)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@ClubID", ClubID));
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("USP_OffLineDataUploadHistory_Get", altParams);
        }
        public DataTable GetOfflineMemberUploadHistory(int ClubID)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@ClubID", ClubID));
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("USP_OffLineMemberUploadHistory_Get", altParams);
        }

        public int InsertOfflineClubDataDownloadHistory(string downloadedBy, int ClubID, bool clubinfo)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@DownloadedBy", downloadedBy));
            altParams.Add(new SqlParameter("@ClubID", ClubID));
            altParams.Add(new SqlParameter("@ClubInfo", clubinfo));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("USP_OffLineClubDataDownloadHistory_Insert", altParams);
        }

        public int InsertOfflineDataDownloadHistory(string downloadedBy, int ClubID, bool clubinfo)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@DownloadedBy", downloadedBy));
            altParams.Add(new SqlParameter("@ClubID", ClubID));
            altParams.Add(new SqlParameter("@ClubInfo", clubinfo));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("USP_OffLineDataDownloadHistory_Insert", altParams);
        }

        public int InsertOfflineMemberDownloadHistory(string downloadedBy, int ClubID, bool clubinfo)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@DownloadedBy", downloadedBy));
            altParams.Add(new SqlParameter("@ClubID", ClubID));
            altParams.Add(new SqlParameter("@ClubInfo", clubinfo));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("USP_OffLineMemberDownloadHistory_Insert", altParams);
        }

        public DataTable GetOfflineDataDownloadHistory(int ClubID)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@ClubID", ClubID));

            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("USP_OffLineDataDownloadHistory_Get", altParams);
        }

        public DataTable GetOfflineMemberDownloadHistory(int ClubID)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@ClubID", ClubID));

            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("USP_OffLineMemberDownloadHistory_Get", altParams);
        }

        public DataTable GetOfflineClubDataDownloadHistory(int ClubID)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@ClubID", ClubID));

            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("USP_OffLineClubDataDownloadHistory_Get", altParams);
        }

        public int SetOfflineDataEntryDoneFlag(int clubId)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@ClubID", clubId));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("USP_SetOfflineDataEntryDoneFlag_Club", altParams);

        }

        public int SetOfflineMemeberEntryDoneFlag(int clubId)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@ClubID", clubId));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("USP_SetOfflineMemberEntryDoneFlag_Club", altParams);

        }

        public int UnSetOfflineEntryDoneFlag(int clubId, string XMLData)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@ClubID", clubId));
            altParams.Add(new SqlParameter("@XMLData", XMLData));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("USP_UnSetOfflineEntryDoneFlag_Club", altParams);

        }

        public int ResetUnSentFlag(int clubId)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@ClubID", clubId));
            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("USP_ResetOfflineEntryDoneFlag_Club", altParams);

        }


        #endregion

        #region Backup Database

        public DataTable GetBackupHistory()
        {
            ArrayList altParams = new ArrayList();
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("USP_BackupHistory_Get", altParams);
        }

        public int InsertBackupHistory(string BackupBy, string FileName)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@BackupBy", BackupBy));
            altParams.Add(new SqlParameter("@FileName", FileName));

            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("USP_BackupHistory_Insert", altParams);
        }

        public int DeleteBackupHistory(string filename)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@FileName", filename));

            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("USP_BackupHistory_Delete", altParams);
        }

        public DataTable GetLogHistory(string FromDate, string ToDate)
        {
            ArrayList altParams = new ArrayList();            
            altParams.Add(new SqlParameter("@FromDate", FromDate));
            altParams.Add(new SqlParameter("@ToDate", ToDate));

            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("USP_LogHistory_GetAll", altParams);

        }

        #endregion

        public int DeleteLogHistory(int id)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@Id", id));

            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("USP_LogHistory_Delete", altParams);
        }

        public int DeleteImportHistory(int id)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@Id", id));

            return DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("USP_ImportHistory_Delete", altParams);
        }

        public void DeleteUploadDataHistory(string filename)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@FileName", filename));

            DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("USP_UploadDataHistory_Delete", altParams);
        }

        public void DeleteUploadMemberHistory(string filename)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@FileName", filename));

            DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("USP_UploadMemberHistory_Delete", altParams);
        }

        public void DeleteClubDownloadHistory(int id)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@ID", id));

            DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("USP_ClubDownloadHistory_Delete", altParams);
        }

        public void DeleteDownloadDataHistory(int id)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@ID", id));

            DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("USP_DownloadDataHistory_Delete", altParams);
        }

        public void DeleteDownloadMemberHistory(int id)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@ID", id));

            DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("USP_DownloadMemberHistory_Delete", altParams);
        }

        public DataTable GetDefaultSettings()
        {
            ArrayList altParams = new ArrayList();
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("USP_DefaultSettings_Get", altParams);
        }

        public void InsertDefaultSettings(int OldScorePeriodYear, int MinimimumNScores, int MemberDeactivatePeriodDay)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@OldScorePeriodYear", OldScorePeriodYear));
            altParams.Add(new SqlParameter("@MinimimumNScores", MinimimumNScores));
            altParams.Add(new SqlParameter("@MemberDeactivatePeriodDay", MemberDeactivatePeriodDay));

            DatabaseManager.GetInstance().ExecuteNonQueryStoredProcedure("USP_DefaultSettings_InsertUpdate", altParams);
        }


        public DataTable InsertOrUpdateDateFormat(string DateForamt)
        {
            ArrayList altParams = new ArrayList();
            altParams.Add(new SqlParameter("@DateFormat", DateForamt));
            //altParams.Add(new SqlParameter("@MinimimumNScores", MinimimumNScores));
            return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("USP_DefaultDateFormatSettings_InsertUpdate", altParams);
        }


        public DataTable DateFormatGetAll()
        {
            try
            {
                ArrayList altParams = new ArrayList();
                return DatabaseManager.GetInstance().ExecuteStoredProcedureDataTable("USP_DateFormatGetAll", altParams);
            }
            catch (System.Exception)
            {
                return null;
            }
        }
    }
}
