//通讯类接口
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationDevice
{
    public interface ICommunication
    {
        bool Open();
        bool Close();

        bool Command(string command, out string response);
        bool Command(byte[] command, out string[] response);
    }
}
