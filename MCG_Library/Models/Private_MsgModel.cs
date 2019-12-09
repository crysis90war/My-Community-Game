using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCG_Library.Models
{
    public class Private_MsgModel
    {
        #region Private Fields
        private int _private_msg_id;
        private bool _is_seen;
        private string _content;
        private int _ref_sender;
        private int _ref_receiver;
        private DateTime _sent_at;
        #endregion


        #region Public Properties
        public int Private_msg_id
        {
            get { return _private_msg_id; }
            set { _private_msg_id = value; }
        }

        public bool Is_seen
        {
            get { return _is_seen; }
            set { _is_seen = value; }
        }

        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }

        public int Ref_sender
        {
            get { return _ref_sender; }
            set { _ref_sender = value; }
        }



        public int Ref_receiver
        {
            get { return _ref_receiver; }
            set { _ref_receiver = value; }
        }



        public DateTime Sent_at
        {
            get { return _sent_at; }
            set { _sent_at = value; }
        }

        #endregion


        #region Constructors

        public Private_MsgModel()
        {

        }

        public Private_MsgModel(int private_msg_id, bool is_seen, string content, int ref_sender, int ref_receiver, DateTime sent_at)
        {
            this.Private_msg_id = private_msg_id;
            this.Is_seen = is_seen;
            this.Content = content;
            this.Ref_sender = ref_sender;
            this.Ref_receiver = ref_receiver;
            this.Sent_at = sent_at;

        }
        #endregion

        #region Others
        // ...
        #endregion

    }
}
