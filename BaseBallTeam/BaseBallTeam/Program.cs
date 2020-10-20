using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp189
{
    class Tournament
    {
        public string TournamentName { get; set; }
        public string BestPerformerTeamName { get; set; }
        public double TournamentBattingAVG { get; set; }
        private bool tournamentAvgFlag { get; set; } = false;
        private List<Team> teamList;
        public Tournament(string name)
        {
            TournamentName = name;
            teamList = new List<Team>();
        }
        public void Add(Team t)
        {
            teamList.Add(t);
            tournamentAvgFlag = false;
        }
        public void Remove(string name)
        {
            Team tObj = teamList.Find(t => t.TeamName == name);
            teamList.Remove(tObj);
            tournamentAvgFlag = false;
        }
        public double CalculateTournamentBattingAverageAndBestTeam()
        {
            //claculating Tournament Batting AVG
            double sum = 0;
            foreach (var team in teamList)
            {
                sum += team.GetBattingAVG();
            }
            TournamentBattingAVG = sum / teamList.Count();

            //claculating best Team
            double maxBattingAvg = teamList[0].GetBattingAVG();
            int bestTeamId = 0;
            for (int i = 1; i < teamList.Count(); i++)
            {
                if (teamList[i].GetBattingAVG() > maxBattingAvg)
                {
                    maxBattingAvg = teamList[i].GetBattingAVG();
                    bestTeamId = i;
                }
            }
            BestPerformerTeamName = teamList[bestTeamId].TeamName;
            tournamentAvgFlag = true;
            return TournamentBattingAVG;
        }
        public void Display()
        {
            Console.WriteLine("::: ------------>" + TournamentName + "<--------------- :::");
            if (tournamentAvgFlag == false)
            {
                CalculateTournamentBattingAverageAndBestTeam();
            }
            Console.WriteLine("Tournament Batting Average: " + TournamentBattingAVG);
            Console.WriteLine("Best Performer Team: " + BestPerformerTeamName);
            Console.WriteLine("Team Information: ");
            foreach (var team in teamList)
            {
                team.Display();
            }
        }
    }
    class Team
    {
        public string TeamName { get; set; }
        public double TeamBattingAVG { get; set; }
        private bool battingAvgFlag { get; set; } = false;
        private List<Player> playerList;
        public Team(string name)
        {
            TeamName = name;
            playerList = new List<Player>();
        }
        public void Add(Player p)
        {
            playerList.Add(p);
            battingAvgFlag = false;
        }
        public void Remove(string name)
        {
            Player pObj = playerList.Find(p => p.Name == name);
            playerList.Remove(pObj);
            battingAvgFlag = false;
        }
        public double CalculateTeamBattingAverage()
        {
            double sum = 0;
            foreach (var player in playerList)
            {
                sum += player.battingAVG;
            }
            TeamBattingAVG = sum / playerList.Count();
            battingAvgFlag = true;
            return TeamBattingAVG;
        }
        public void Display()
        {
            Console.WriteLine("::: " + TeamName + " :::");
            if (battingAvgFlag == false)
            {
                CalculateTeamBattingAverage();
            }
            Console.WriteLine("Team Batting Average: " + TeamBattingAVG);
            Console.WriteLine("Player Information: ");
            foreach (var player in playerList)
            {
                Console.WriteLine("Player Name: {0}, Batting Average: {1:0.00}", player.Name, player.battingAVG);
            }
        }
        public double GetBattingAVG()
        {
            if (battingAvgFlag == false)
            {
                CalculateTeamBattingAverage();
            }
            return TeamBattingAVG;
        }
    }
    class Player
    {
        public string Name { get; set; }
        public double battingAVG { get; set; }
    }
    class Program
    {
        static Random r = new Random();
        static Player CreateRandomPlayer(int i)
        {
            string rName;
            double rBatting;
            rName = "Player " + i.ToString() + "-" + ((char)(65 + r.Next(0, 26))).ToString() + ((char)(65 + r.Next(0, 26))).ToString() + ((char)(65 + r.Next(0, 26))).ToString();
            rBatting = r.NextDouble() * 75 + 25;
            var newPlayer = new Player { Name = rName, battingAVG = rBatting };
            return newPlayer;
        }
        static void Main(string[] args)
        {
            Tournament myTournament = new Tournament("Canada Cricket Championship - 2020");
            string[] TeamName = { "Team Calgary", "Team Toronto", "Team Edmonton", "Team Victoria", "Team Quebec City" };
            Console.WriteLine("How Many Players?");
            int n = int.Parse(Console.ReadLine());
            foreach (var teamTitle in TeamName)
            {
                Team myTeam = new Team(teamTitle);
                Player samplePlayer = new Player { Name = "Test Player", battingAVG = 50.5 };
                myTeam.Add(samplePlayer);
                for (int i = 1; i < n; i++)
                {
                    var player = CreateRandomPlayer(i);
                    myTeam.Add(player);
                }
                myTournament.Add(myTeam);
            }
            myTournament.Display();
            Console.Read();
            //please add required code to add a new new or remove an existing team. Thank you.
        }
    }
}