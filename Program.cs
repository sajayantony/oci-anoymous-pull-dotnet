using System;

namespace OCIArtifact.Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            var loginUri = "x"; 
            var repo = "x";
            var tag = "x";
            var t = ContentStore.Pull(loginUri, repo, tag);
            t.GetAwaiter().GetResult();
        }
    }
}
