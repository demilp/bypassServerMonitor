using BypassServer;
using BypassServerMonitor.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BypassServerMonitor
{
    public partial class ServerMonitor : Form
    {

        private int port;
        private string ip;
        private string delim;
        private TCPClientManager socket;
        public int requestTime = 45;
        private delegate void TcpDelegateConnection(ConnectEventArgs args);
        private delegate void TcpDelegateDisconnection(DisconnectEventArgs args);
        private delegate void TcpDelegateDataArrived(CommandEventArgs args);
        private TcpDelegateConnection connection;
        private TcpDelegateDisconnection disconnection;
        private TcpDelegateDataArrived dataArrived;

        private string[] semaphoreIds;
        private Label[] semaphoreLabels;

        public ServerMonitor()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;            
            socket = new TCPClientManager();
            ip = ConfigurationManager.AppSettings["ip"];
            port = int.Parse(ConfigurationManager.AppSettings["port"]);
            delim = ConfigurationManager.AppSettings["delimitador"];
            int j = 0;
            List<string> sem = new List<string>();
            bool ex = false;
            while (!ex)
            {
                
                string s = ConfigurationManager.AppSettings["semaphoreId."+j];
                if (s == null)
                {
                    ex = true;
                }
                else
                {
                    sem.Add(s);
                    j++;
                }
                    
                
            }
            semaphoreIds = sem.ToArray();
            socket.ConnectEvent += OnConnected;
            socket.DisconnectEvent += OnDisconnected;
            socket.CommandReceivedEvent += OnData;
            connection += DrawConnected;
            disconnection += DrawDisconnected;
            dataArrived += DrawData;
            socket.Initialize(ip, port, delim);
            request = new BypassData(BypassData.Types.STATUS, "", "", new string[0]);
            refreshRateLabel.Text = requestTime + " seconds";


            Font f = new Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Point);
            semaphoreLabels = new Label[semaphoreIds.Length];
            for (int i = 0; i < semaphoreIds.Length; i++)
            {
                Label l = new Label();
                semaphoreLabels[i] = l;
                l.Text = semaphoreIds[i];
                l.Location = new Point(0, i*20+10);
                semaphorePanel.Controls.Add(l);
                l.Font = f;
                l.ForeColor = Color.Red;
                l.AutoSize = true;
            }

            
        }
        BypassData request;
        System.Threading.Timer timer;
        private void OnConnected(object sender, ConnectEventArgs args)
        {
            BypassData data = new BypassData(BypassData.Types.REGISTER, "serverMonitor", "tool", new string[0]);
            socket.SendData(data.ToJson());
            socket.SendData(request.ToJson());
            Invoke(connection, args);

        }
        private void OnDisconnected(object sender, DisconnectEventArgs args)
        {
            Invoke(disconnection, args);            
        }
        private void OnData(object sender, CommandEventArgs args)
        {
            Invoke(dataArrived, args);            
        }
        private void DrawData(CommandEventArgs args)
        {
            try
            {
                
                JSONNode json = JSONNode.Parse(args.comando);
                // = receivedData.status;
                JSONArray status = json["status"].AsArray;
                grid.DataSource = JsonConvert.DeserializeObject<ClientInfo[]>(json["status"].ToString());
                
                for (int i = 0; i < semaphoreIds.Length; i++)
                {
                    bool exists = false;
                    for (int j = 0; j < status.Count; j++)
                    {
                        if ("\""+semaphoreIds[i]+"\"" == status[j]["id"].ToString())
                        {
                            exists = true;
                        }
                    }
                    if (exists)
                    {
                        semaphoreLabels[i].ForeColor = Color.Green;
                    }
                    else
                    {
                        semaphoreLabels[i].ForeColor = Color.Red;
                    }
                }
                JSONArray messages = json["lastMessages"].AsArray;
                string s = "";
                for (int i = messages.Count - 1; i >= 0; i--)
                {
                    s += messages[i]+"\r\n";
                }
                
                messagesTb.Text = s;
                StartTimer();
            }
            catch(Exception e)
            {
                messagesTb.Text = e.Message;
            }
        }
        private void DrawConnected(ConnectEventArgs args)
        {
            connectedLabel.ForeColor = Color.Green;
        }
        private void DrawDisconnected(DisconnectEventArgs args)
        {
            connectedLabel.ForeColor = Color.Red;
        }
        private void StartTimer()
        {
            if (timer != null)
            {
                timer.Dispose();
            }
            timer = new System.Threading.Timer(RequestUpdate, null, requestTime * 1000, Timeout.Infinite);
        }
        //Status receivedData;
        private void RequestUpdate(object state)
        {
            socket.SendData(request.ToJson());
        }
        private void manualRefreshBtn_Click(object sender, EventArgs e)
        {
            socket.SendData(request.ToJson());
        }

        private void setRefreshRateBtn_Click(object sender, EventArgs e)
        {
            int r;
            if(int.TryParse(requestTimeTB.Text, out r))
            {
                if (r <= 0 || r > Int32.MaxValue/1000)
                {
                    return;
                }
                requestTime = r;
                if (requestTime > 1)
                {
                    refreshRateLabel.Text = requestTime + " seconds";
                }
                else
                {
                    refreshRateLabel.Text = requestTime + " second";
                }
                
                StartTimer();
            }
            
        }

        private void connectedLabel_HandleCreated(object sender, EventArgs e)
        {
            if(socket.conectado)
            {
                connectedLabel.ForeColor = Color.Green;
            }
        }

        private void ServerMonitor_FormClosing(object sender, FormClosingEventArgs e)
        {
            socket.Close();
        }
    }
    public struct Status
    {
        public ClientInfo[] status;
        public string[] lastMessages;
    }
    public struct ClientInfo
    {
        public string number{get; set;}
        public string ip { get; set; }
        public string id { get; set; }
        public string tag { get; set; }
    }
}
