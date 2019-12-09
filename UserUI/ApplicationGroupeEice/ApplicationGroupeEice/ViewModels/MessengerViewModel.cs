using Caliburn.Micro;
using MCG_Library;
using MCG_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ApplicationGroupeEice.ViewModels
{
    class MessengerViewModel : Conductor<object>
    {

        //private static MainWindowViewModel s_Instance = null;
        IWindowManager manager = new WindowManager();


        private UserModel _targetData = new UserModel();
        private UserModel _userData = new UserModel();
        private int _userId;
        private int _targetId;
        private string _txxxt;
        private List<Private_MsgModel> myMessages;
        private BindableCollection<Private_MsgModel> _myMessages = new BindableCollection<Private_MsgModel>();
        private string _textBoxEnvois;

        public BindableCollection<Private_MsgModel> MyMessages
        {
            get { return _myMessages; }
            set { _myMessages = value; }
        }

        public int UserId
        {
            get { return _userId; }
            set
            {
                _userId = value;
                NotifyOfPropertyChange(() => UserId);
            }
        }
        public int TargetId
        {
            get { return _targetId; }
            set
            {
                _targetId = value;
                NotifyOfPropertyChange(() => TargetId);
            }
        }

        public string Txxxt
        {
            get { return _txxxt; }
            set
            {
                _txxxt = value;
                NotifyOfPropertyChange(() => Txxxt);
            }
        }

        public UserModel UserData
        {
            get { return _userData; }
            set
            {
                _userData = value;
                NotifyOfPropertyChange(() => UserData);
            }
        }
        public UserModel TargetData
        {
            get { return _targetData; }
            set
            {
                _targetData = value;
                NotifyOfPropertyChange(() => TargetData);
            }
        }

        public string TextBoxEnvois
        {
            get { return _textBoxEnvois; }
            set
            {
                _textBoxEnvois = value;
                NotifyOfPropertyChange(() => TextBoxEnvois);
            }
        }


        public MessengerViewModel(int userId, int targetId)
        {

            int etatLastMessage = 2;
            Txxxt = "";
            UserId = userId;
            TargetId = targetId;
            UserData = GlobalConfig.Connection.GetUser_Info(UserId);
            TargetData = GlobalConfig.Connection.GetUser_Info(targetId);
            myMessages = GlobalConfig.Connection.GetPrivate_msg_refSender_refReceiver(UserId, TargetId);
            foreach (var private_msg in myMessages)
            {
                MyMessages.Add(private_msg);

                if (private_msg.Ref_sender == UserId)
                {
                    if (etatLastMessage != 0)
                    {
                        Txxxt += "\n\n" + UserData.UserPublicName.ToUpper() + " " + private_msg.Sent_at;
                    }

                    Txxxt += "  \n->" + private_msg.Content.ToString() + "";


                    etatLastMessage = 0;
                }
                else
                {
                    if (etatLastMessage != 1)
                    {
                        Txxxt += "\n\n" + TargetData.UserPublicName.ToUpper() + "  " + private_msg.Sent_at;
                    }

                    Txxxt += "  \n->" + private_msg.Content.ToString() + "";
                    etatLastMessage = 1;


                }
                //Txxxt = MyMessages.Count.ToString();
            }
        }
        public void bouton_Actualiser()
        {
            int etatLastMessage = 2;
            Txxxt = "";

            UserData = GlobalConfig.Connection.GetUser_Info(UserId);
            TargetData = GlobalConfig.Connection.GetUser_Info(TargetId);
            myMessages = GlobalConfig.Connection.GetPrivate_msg_refSender_refReceiver(UserId, TargetId);
            foreach (var private_msg in myMessages)
            {
                MyMessages.Add(private_msg);

                if (private_msg.Ref_sender == UserId)
                {
                    if (etatLastMessage != 0)
                    {
                        Txxxt += "\n\n" + UserData.UserPublicName.ToUpper() + " " + private_msg.Sent_at;
                    }

                    Txxxt += "  \n->" + private_msg.Content.ToString() + "";


                    etatLastMessage = 0;
                }
                else
                {
                    if (etatLastMessage != 1)
                    {
                        Txxxt += "\n\n" + TargetData.UserPublicName.ToUpper() + "  " + private_msg.Sent_at;
                    }

                    Txxxt += "  \n->" + private_msg.Content.ToString() + "";
                    etatLastMessage = 1;
                }



            }
        }

        public void bouton_Envois()
        {

            string eq = TextBoxEnvois;
            string eq2 = null;
            string eq3 = "";
            Private_MsgModel msgModel = new Private_MsgModel();
            msgModel.Is_seen = false;
            msgModel.Content = TextBoxEnvois;
            msgModel.Ref_sender = UserId;
            msgModel.Ref_receiver = TargetId;
            msgModel.Sent_at = DateTime.Now;
            if ((String.Compare(eq, eq2) == 0) || (String.Compare(eq, eq3) <= 0))
            {

            }
            else
            {
                GlobalConfig.Connection.CreerPrivate_Msg(msgModel);
            }


            int etatLastMessage = 2;
            Txxxt = "";

            UserData = GlobalConfig.Connection.GetUser_Info(UserId);
            TargetData = GlobalConfig.Connection.GetUser_Info(TargetId);
            myMessages = GlobalConfig.Connection.GetPrivate_msg_refSender_refReceiver(UserId, TargetId);
            foreach (var private_msg in myMessages)
            {
                MyMessages.Add(private_msg);

                if (private_msg.Ref_sender == UserId)
                {
                    if (etatLastMessage != 0)
                    {
                        Txxxt += "\n\n" + UserData.UserPublicName.ToUpper() + " " + private_msg.Sent_at;
                    }

                    Txxxt += "  \n->" + private_msg.Content.ToString() + "";


                    etatLastMessage = 0;
                }
                else
                {
                    if (etatLastMessage != 1)
                    {
                        Txxxt += "\n\n" + TargetData.UserPublicName.ToUpper() + "  " + private_msg.Sent_at;
                    }

                    Txxxt += "  \n->" + private_msg.Content.ToString() + "";
                    etatLastMessage = 1;
                }



            }

        }
    }
}
