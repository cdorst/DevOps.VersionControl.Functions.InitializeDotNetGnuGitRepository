using DevOps.VersionControl.Structures.GitCommitUser;
using System;
using static DevOps.VersionControl.Functions.AddNewRepositoryFiles.NewRepositoryFilesAdder;
using static DevOps.VersionControl.Functions.AddOriginGitRemoteAndPush.RemoteAdderAndChangePusher;
using static DevOps.VersionControl.Functions.RunGitInitCommand.GitInitCommandRunner;

namespace DevOps.VersionControl.Functions.InitializeDotNetGnuGitRepository
{
    public static class GitRepositoryInitializer
    {
        public static void InitializeRepository(string directory, Uri remote, UserInfo? user = null)
        {
            Init(directory);
            AddAndCommitNewRepositoryFiles(directory, user);
            AddRemoteAndPush(directory, remote);
        }
    }
}
