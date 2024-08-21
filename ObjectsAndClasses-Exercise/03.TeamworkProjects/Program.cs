using System.Text;

namespace _03.TeamworkProjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            int countCreators = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int count = 0; count < countCreators; count++)
            {
                string[] teamInfo = Console.ReadLine().Split("-");

                string teamCreator = teamInfo[0];
                string teamName = teamInfo[1];

                if (teams.Any(t => t.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teams.Any(t => t.Creator == teamCreator))
                {
                    Console.WriteLine($"{teamCreator} cannot create another team!");
                }
                else
                {
                    Team team = new Team(teamName, teamCreator);

                    teams.Add(team);

                Console.WriteLine($"Team {teamName} has been created by {teamCreator}!");
                }
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split("->");

                string candidateName = input[0];

                if (candidateName == "end of assignment")
                {
                    break;
                }

                string teamNameToJoin = input[1];

                if (!teams.Any(t => t.Name == teamNameToJoin))
                {
                    Console.WriteLine($"Team {teamNameToJoin} does not exist!");
                }
                else if (teams.Any(t => t.Members.Contains(candidateName) || teams.Any(t => t.Creator == candidateName)))
                {
                    Console.WriteLine($"Member {candidateName} cannot join team {teamNameToJoin}!");
                }
                else
                {
                    Team teamInWhichCandidateWillJoin = teams.First(t => t.Name == teamNameToJoin);
                    teamInWhichCandidateWillJoin.Members.Add(candidateName);
                }
            }

            List<Team> validTeams = teams.Where(t => t.Members.Count > 0).ToList();
            List<Team> disbandTeams = teams.Where(t => t.Members.Count == 0).ToList();

            foreach (Team team in validTeams.OrderByDescending(t => t.Members.Count).ThenBy(t => t.Name))
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine(team.Name);
                sb.AppendLine($"- {team.Creator}");

                foreach(string member in team.Members.OrderBy(m => m))
                {
                    sb.AppendLine($"-- {member}");
                }

               Console.WriteLine(sb.ToString().Trim());
            }

            Console.WriteLine("Teams to disband:");

            foreach (var team in disbandTeams.OrderBy(t => t.Name))
            {
                Console.WriteLine(team.Name);
            }
        }
    }
}
