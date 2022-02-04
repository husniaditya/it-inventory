using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace KASLibrary
{
    public class FTPClient
    {
        private string m_uri;
        private string m_username;
        private string m_password;

        #region " Public Accessors "
        public string URI
        {
            get { return m_uri; }
        }

        public string Username
        {
            get { return m_username; }
        }
        #endregion

        public FTPClient(string uri, string username, string password)
        {
            m_uri = uri;
            m_username = username;
            m_password = password;
        }

        public ArrayList GetFTPFileList(string uri)
        {
            return GetFTPFileList(uri, m_username, m_password);
        }

        public ArrayList GetFTPFileList(string uri, string username, string password)
        {
            FtpWebRequest ftpReq = (FtpWebRequest)WebRequest.Create(uri);
            ftpReq.Credentials = new NetworkCredential(username, password);
            ftpReq.Method = WebRequestMethods.Ftp.ListDirectory;

            ArrayList list = new ArrayList();

            try
            {
                FtpWebResponse ftpRes = (FtpWebResponse)ftpReq.GetResponse();
                StreamReader sreader = new StreamReader(ftpRes.GetResponseStream());

                while (!sreader.EndOfStream)
                {
                    list.Add(sreader.ReadLine());
                }

                ftpRes.Close();
            }
            catch
            {

            }

            return list;
        }

        public ArrayList GetFTPFolderList(string uri)
        {
            return GetFTPFolderList(uri, m_username, m_password);
        }

        public ArrayList GetFTPFolderList(string uri, string username, string password)
        {
            FtpWebRequest ftpReq = (FtpWebRequest)WebRequest.Create(uri);
            ftpReq.Credentials = new NetworkCredential(username, password);
            ftpReq.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

            ArrayList list = new ArrayList();

            try
            {
                FtpWebResponse ftpRes = (FtpWebResponse)ftpReq.GetResponse();
                StreamReader sreader = new StreamReader(ftpRes.GetResponseStream());

                while (!sreader.EndOfStream)
                {
                    string line = sreader.ReadLine();
                    if (line[0] == 'd')
                        list.Add(line.Substring(55));
                }

                ftpRes.Close();
            }
            catch(Exception ex)
            {
                return new ArrayList();
            }

            return list;
        }

        public string FTPDownload(string fileToDownload, string fileLocal)
        {
            FtpWebRequest ftpReq;
            try
            {
                FileStream outputStream = new FileStream(fileLocal, FileMode.Create);

                ftpReq = (FtpWebRequest)FtpWebRequest.Create(fileToDownload);
                ftpReq.Credentials = new NetworkCredential(m_username, m_password);
                ftpReq.Method = WebRequestMethods.Ftp.DownloadFile;
                ftpReq.UseBinary = true;

                FtpWebResponse response = (FtpWebResponse)ftpReq.GetResponse();
                Stream ftpStream = response.GetResponseStream();
                long cl = response.ContentLength;
                int bufferSize = 2048;
                int readCount;
                byte[] buffer = new byte[bufferSize];

                readCount = ftpStream.Read(buffer, 0, bufferSize);
                while (readCount > 0)
                {
                    outputStream.Write(buffer, 0, readCount);
                    readCount = ftpStream.Read(buffer, 0, bufferSize);
                }

                ftpStream.Close();
                outputStream.Close();
                response.Close();
                return "Downloaded to: " + fileLocal;
            }
            catch (Exception ex)
            {
                return "Download Error: " + ex.Message;
            }
        }

        public string FTPUpload(string fileToUpload, string ftpLocation)
        {
            FileInfo fileInf = new FileInfo(fileToUpload);
            string uri = fileToUpload;
            FtpWebRequest ftpReq;

            // Create FtpWebRequest object from the Uri provided
            ftpReq = (FtpWebRequest)FtpWebRequest.Create
                     (new Uri(ftpLocation + "/" + fileInf.Name));

            ftpReq.Credentials = new NetworkCredential(m_username, m_password);
            ftpReq.KeepAlive = false;
            ftpReq.Method = WebRequestMethods.Ftp.UploadFile;
            ftpReq.UseBinary = true;

            // Notify the server about the size of the uploaded file
            ftpReq.ContentLength = fileInf.Length;

            // The buffer size is set to 2kb
            int buffLength = 2048;
            byte[] buff = new byte[buffLength];
            int contentLen;

            // Opens a file stream (System.IO.FileStream) to read the file
            // to be uploaded
            FileStream fs = fileInf.OpenRead();

            try
            {
                // Stream to which the file to be upload is written
                Stream strm = ftpReq.GetRequestStream();

                // Read from the file stream 2kb at a time
                contentLen = fs.Read(buff, 0, buffLength);

                // Till Stream content ends
                while (contentLen != 0)
                {
                    // Write Content from the file stream to the FTP Upload
                    // Stream
                    strm.Write(buff, 0, contentLen);
                    contentLen = fs.Read(buff, 0, buffLength);
                }

                // Close the file stream and the Request Stream
                strm.Close();
                fs.Close();

                return "Uploaded To: " + ftpLocation;
            }
            catch (Exception ex)
            {
                return "Upload Error: " + ex.Message;
            }
        }
    }
}
