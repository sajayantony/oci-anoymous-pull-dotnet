using System;
using System.Threading.Tasks;

namespace OCIArtifact.Samples
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var loginUri = "x"; 
            var repo = "x";
            var tag = "x";
            await ContentStore.PullAsync(loginUri, repo, tag);
        }
    }
}
