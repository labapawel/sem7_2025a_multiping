using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sem7_2025a_multiping
{
    public class TaskPing 
    {
        public string Host = "10.40.60.165";
        public int interval = 10;
        public bool active = true;
        public bool startstop = true;
        public int pingSend = 0;
        public int pingReceive = 0;
        public DateTime? lastTime = null;
        public TaskPing(string host, int interval) { 
            this.interval = interval;
            this.Host = host;
        }

        public PingReply Ping()
        {
            using (var ping = new Ping()) { 
                var odp = ping.Send(this.Host);
                return odp;    
            
            }

        }

    }
}
