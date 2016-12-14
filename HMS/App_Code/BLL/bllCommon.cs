using System.Data;
using HMS.DAL;
using System;
using System.Linq;

namespace HMS.BLL
{
    public class bllCommon
    {
        dalCommon objCommon = new dalCommon();
        public bllCommon()
        {
        }

        public DataTable GetMsgList(string module)
        {
            return objCommon.GetMsgList(module);
        }

        public DataTable GetMsg(int ID, string strHeader)
        {
            return objCommon.GetMsg(ID,strHeader);
        }
       
        public int UpdateMsg(int ID, string strMessage)
        {
            return objCommon.UpdateMsg(ID, strMessage);
        }

        public DataTable GetImportHistory()
        {
            return objCommon.GetImportHistory();
        }

        public int DeleteImportHistory(int id)
        {
            return objCommon.DeleteImportHistory(id);
        }

        public int InsertImportHistory(string  UserName, string DataFileName, int ItemsSuccedded, int ItemsFailed)
        {
            return objCommon.InsertImportHistory( UserName, DataFileName, ItemsSuccedded, ItemsFailed);
        }

        public DataSet GetOfflineData(int clubId)
        {
            return objCommon.GetOfflineData(clubId);
        }

        public DataSet GetOfflineMember(int clubId)
        {
            return objCommon.GetOfflineMember(clubId);
        }

        public string GetErrorDownloadData(string SessionID)
        {
            string s= objCommon.GetErrorDownloadData(SessionID).GetXml();
            return s;

        }

        public int InsertOfflineData(string XMLData, string ImportedBy)
        {
            return objCommon.InsertOfflineData(XMLData, ImportedBy);
        }

        public int InsertOfflineDataUploadHistory(string UploadedBy, string FileName, int ClubID)
        {
            return objCommon.InsertOfflineDataUploadHistory(UploadedBy, FileName, ClubID);
        }

        public int InsertOfflineMemberUploadHistory(string UploadedBy, string FileName, int ClubID)
        {
            return objCommon.InsertOfflineMemeberUploadHistory(UploadedBy, FileName, ClubID);
        }

        public DataTable GetOfflineDataUploadHistory(int ClubID )
        {
            return objCommon.GetOfflineDataUploadHistory(ClubID);
        }

        public DataTable GetOfflineMemberUploadHistory(int ClubID)
        {
            return objCommon.GetOfflineMemberUploadHistory(ClubID);
        }

        public int InsertOfflineClubDataDownloadHistory(string downloadedBy, int ClubID, bool clubinfo = false)
        {
            return objCommon.InsertOfflineClubDataDownloadHistory(downloadedBy, ClubID, clubinfo);
        }

        public int InsertOfflineDataDownloadHistory(string downloadedBy, int ClubID, bool clubinfo = false)
        {
            return objCommon.InsertOfflineDataDownloadHistory(downloadedBy, ClubID, clubinfo);
        }

        public int InsertOfflineMemberDownloadHistory(string downloadedBy, int ClubID, bool clubinfo = false)
        {
            return objCommon.InsertOfflineMemberDownloadHistory(downloadedBy, ClubID, clubinfo);
        }
        public DataTable GetOfflineDataDownloadHistory(int ClubID)
        {
            return objCommon.GetOfflineDataDownloadHistory(ClubID);
        }

        public DataTable GetOfflineMemberDownloadHistory(int ClubID)
        {
            return objCommon.GetOfflineMemberDownloadHistory(ClubID);
        }

        public DataTable GetOfflineClubDataDownloadHistory(int ClubID)
        {
            return objCommon.GetOfflineClubDataDownloadHistory(ClubID);
        }

        public int SetOfflineDataEntryDoneFlag(int clubId)
        {
            return objCommon.SetOfflineDataEntryDoneFlag(clubId);
        }
        public int SetOfflineMemberEntryDoneFlag(int clubId)
        {
            return objCommon.SetOfflineMemeberEntryDoneFlag(clubId);
        }


        public int UnSetOfflineEntryDoneFlag(int clubId, string XMLData)
        {
            return objCommon.UnSetOfflineEntryDoneFlag(clubId, XMLData);
        }
        public int ResetUnSentFlag(int clubId)
        {
            return objCommon.ResetUnSentFlag(clubId);
        }


        #region Backup Database

        public DataTable GetBackupHistory()
        {
            return objCommon.GetBackupHistory();
        }

        public int InsertBackupHistory(string BackupBy, string FileName)
        {
            return objCommon.InsertBackupHistory(BackupBy, FileName);
        }

        public int DeleteBackupHistory(string filename)
        {
            return objCommon.DeleteBackupHistory(filename);
        }

        public DataTable GetLogHistory(string FromDate, string ToDate)
        {
            return objCommon.GetLogHistory(FromDate,ToDate);
        }

        public int DeleteLogHistory(int id)
        {
            return objCommon.DeleteLogHistory(id);
        }

        #endregion

        public void DeleteUploadDataHistory(string filename)
        {
            objCommon.DeleteUploadDataHistory(filename);
        }

        public void DeleteUploadMemberHistory(string filename)
        {
            objCommon.DeleteUploadMemberHistory(filename);
        }

        public void DeleteClubDownloadHistory(int id)
        {
            objCommon.DeleteClubDownloadHistory(id);
        }

        public void DeleteDownloadDataHistory(int id)
        {
            objCommon.DeleteDownloadDataHistory(id);
        }

        public void DeleteDownloadMemberHistory(int id)
        {
            objCommon.DeleteDownloadMemberHistory(id);
        }
        public DataTable GetDefaultSettings()
        {
            return objCommon.GetDefaultSettings();
        }

        public void InsertDefaultSettings(int OldScorePeriodYear, int MinimimumNScores, int MemberDeactivatePeriodDay)
        {
            objCommon.InsertDefaultSettings(OldScorePeriodYear, MinimimumNScores, MemberDeactivatePeriodDay);
        }


        public DataTable InsertOrUpdateDateFormat(string DateForamt)
        {
           return objCommon.InsertOrUpdateDateFormat(DateForamt);             
        }


        public DataTable DateFormatGetAll()
        {
            try
            {
                return objCommon.DateFormatGetAll();
            }
            catch (Exception)
            {
                return null;
            }
        }
        public string RandomDigits(int length)
        { 
            DateTime date = DateTime.Now;

            string uniqueID = String.Format(
              "{0:0000}{1:00}{2:00}{3:00}",
              date.Year, date.Month, date.Day,date.Millisecond
              );
            uniqueID = new string(uniqueID.Take(length).ToArray());
            return uniqueID;
        }
    }
}
