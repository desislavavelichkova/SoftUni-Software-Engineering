using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int countTeams = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < countTeams; i++)
            {
                string input = Console.ReadLine();
                string[] newTeam = input.Split("-", StringSplitOptions.RemoveEmptyEntries);
                string nameOfCreator = newTeam[0];
                string nameOfTeam = newTeam[1];

                Team team = new Team(nameOfCreator, nameOfTeam);

                bool isTeamNameExist = teams.Select(x => x.NameOfTeam)
                                            .Contains(nameOfTeam);
                bool isCreatorNameExist = teams.Select(x => x.NameOfCreator)
                                            .Contains(nameOfCreator);

                if (!isTeamNameExist)
                {
                    if (!isCreatorNameExist)
                    {
                        teams.Add(team);
                        Console.WriteLine($"Team {nameOfTeam} has been created by {nameOfCreator}!");
                    }
                    else
                    {
                        Console.WriteLine($"{nameOfCreator} cannot create another team!");
                    }
                }

                else
                {
                    Console.WriteLine($"Team {nameOfTeam} was already created!");
                }
            }

            string teamMembers = Console.ReadLine();

            while (teamMembers != "end of assignment")
            {
                string[] cmndArg = teamMembers
                                    .Split("->", StringSplitOptions.RemoveEmptyEntries)
                                    .ToArray();

                string newUser = cmndArg[0];
                string teamName = cmndArg[1];

                bool isTeamExist = teams.Select(x => x.NameOfTeam)
                                        .Contains(teamName);
                bool isCreatorExist = teams.Select(x => x.NameOfCreator)
                                           .Contains(newUser);
                bool isMemberExist = teams.Select(x => x.Members)
                                          .Any(x => x.Contains(newUser));
                if (!isTeamExist)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (isCreatorExist || isMemberExist)
                {
                    Console.WriteLine($"Member {newUser} cannot join team {teamName}!");
                }
                else
                {
                    int index = teams.FindIndex(x => x.NameOfTeam == teamName);
                    teams[index].Members.Add(newUser);
                }
                teamMembers = Console.ReadLine();
            }

            Team[] teamsToDisband = teams.OrderBy(x => x.NameOfTeam)
                                         .Where(x => x.Members.Count == 0)
                                         .ToArray();

            Team[] fullTeam = teams.OrderByDescending(x => x.Members.Count)
                                    .ThenBy(x => x.NameOfTeam)
                                    .Where(x => x.Members.Count > 0)
                                    .ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (Team team  in fullTeam)
            {
                sb.AppendLine($"{team.NameOfTeam}");
                sb.AppendLine($"- {team.NameOfCreator}");

                foreach (var member in team.Members.OrderBy(x => x))
                {
                    sb.AppendLine($"-- {member}");
                }
            }
            sb.AppendLine("Teams to disband:");
            foreach (Team item in teamsToDisband)
            {
                sb.AppendLine(item.NameOfTeam);
            }

            Console.WriteLine(sb.ToString());
        }
    }
    class Team
    {
        public Team(string nameOfCreator, string nameOfTeam)
        {
            NameOfCreator = nameOfCreator;
            NameOfTeam = nameOfTeam;
            Members = new List<string>();          
            
        }
        public string NameOfCreator { get; set; }
        public string NameOfTeam { get; set; }
        public List<string> Members { get; set; }
    }
}
