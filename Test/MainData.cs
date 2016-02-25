using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class MainData
    {
        public static int userID;
        public static int selectedMessage;
        public static int messageType;
        public static int replyId;
        public static bool reply = false;
        public static DateTime lastIncMsgDate;
        public static DateTime lastSentMsgDate;
        //classMainData = this;

        public class Messages
        {
            public int sender_id;
            public int recipient_id;
            public string header;
            public string text;
            public DateTime date;
        }

        public static String GetDateWithoutMilliseconds(DateTime d)
        {

            string z = (d.Year + "-" + d.Month + "-" + d.Day + " " + d.Hour + ":" + d.Minute + ":" + d.Second);
            return z;
        }

    }
}
