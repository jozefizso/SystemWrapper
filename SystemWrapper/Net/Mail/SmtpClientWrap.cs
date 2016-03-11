namespace SystemWrapper.Net.Mail
{
    using System;
    using System.ComponentModel;
    using System.Net;
    using System.Net.Mail;
    using SystemInterface.Net.Mail;

    public sealed class SmtpClientWrap : ISmtpClient
    {
        public event SendCompletedEventHandler SendCompleted;

        internal bool HandlerAdded;
        internal bool _Disposed;

        internal SmtpClient Instance
        {
            get { return _Instance ?? (_Instance = new SmtpClient()); }
            set { _Instance = value; }
        } private SmtpClient _Instance;

        public SmtpClientWrap()
        {
        }

        public SmtpClientWrap(string host)
        {
            Instance = new SmtpClient(host);
        }

        public SmtpClientWrap(SmtpClient smtpClient)
        {
            Instance = smtpClient;
        }

        public void Send(string from, string recipients, string subject, string body)
        {
            Instance.Send(from, recipients, subject, body);
        }

        public void Send(MailMessage message)
        {
            Instance.Send(message);
        }

        public void SendAsync(MailMessage message, object userToken)
        {
            AddHandler();
            Instance.SendAsync(message, userToken);
        }

        public void SendAsync(string from, string recipients, string subject, string body, object userToken)
        {
            AddHandler();
            Instance.SendAsync(from, recipients, subject, body, userToken);
        }

        internal void OnSendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            OnSendCompleted(e);
        }

        internal void OnSendCompleted(AsyncCompletedEventArgs e)
        {
            SendCompleted?.Invoke(this, e);
        }

        public ICredentialsByHost Credentials
        {
            get { return Instance.Credentials; }
            set { Instance.Credentials = value; }
        }

        public SendCompletedEventHandler OnSendCompletedHandler
        {
            get { return _Handler ?? (_Handler = OnSendCompleted); }
        } private SendCompletedEventHandler _Handler;

        internal void AddHandler()
        {
            if (!HandlerAdded)
            {
                Instance.SendCompleted += OnSendCompletedHandler;
                HandlerAdded = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        internal void Dispose(bool disposing)
        {
            if (_Disposed)
            {
                return;
            }
            if (!disposing)
            {
                Instance.Dispose();
            }
            _Disposed = true;
        }
    }
}