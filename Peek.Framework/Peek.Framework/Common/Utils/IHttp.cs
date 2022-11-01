using System.Threading.Tasks;

namespace Peek.Framework.Common.Utils
{
    public interface IHttp
    {
        Task<T1> Get<T1>(string uri, string path);

        Task<T1> Post<T1, T2>(string uri, string path, T2 body);

        Task<T1> Put<T1, T2>(string uri, string path, T2 body);

        Task<T1> Delete<T1>(string uri, string path);

    }
}