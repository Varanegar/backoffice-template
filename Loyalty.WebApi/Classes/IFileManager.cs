using System.Threading.Tasks;
using System.Collections.Generic;

namespace Loyalty.WebApi.Classes
{
    public interface IFileManager
    {
        Task Save(System.Web.HttpPostedFileBase file, string imagetype , string token, string imageName);
        Task SaveWithMagick(System.Web.HttpPostedFileBase file, string imagetype , string token, string imageName);
        Task Remove(string token, string imagetype, string fileName);
        string GetPath(string token, string imagetype, string fileName);
        List<string> GetFileNames(string token, string imagetype);
    }
}