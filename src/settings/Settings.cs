using System;
using System.IO;

namespace ManageEdge
{
    public static class Settings
    {
        public static string connpgpb = "Server=" + Entry.HOST.ToString() + ";Port=" + Entry.PORT.ToString() + ";User Id=" + Entry.USER.ToString() + ";Password=" + Entry.PASS.ToString() + ";Database=" + Entry.DB.ToString() + ";";
        public static string PATH = @"Configs/Settings.ini";
        public static string accountsCOLUMN, cashCOLUMN;
        public static void Configs()
        {

        }
    }
}
