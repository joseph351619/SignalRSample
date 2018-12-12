using System.Threading.Tasks;

namespace SignalRSample
{
    public interface IChatHub
    {
        // 這個方法是用來發出 Message 給 Client
        Task ServerMessage(string message);
    }
}