using System;

namespace messy_inventory
{
    public class GameData
    {
        private string title;
        private string console;
        private string developer;
        private string publisher;
        private string condition;
        private float price;

        // Default constructor
        public GameData()
        {
            title = "";
            console = "";
            developer = "";
            publisher = "";
            condition = "";
            price = 0.00F;
        }

        // Other possible constructors
        public GameData(string gameTitle, string gameConsole)
        {
            title = gameTitle;
            console = gameConsole;
        }

        public GameData(string gameTitle, string gameConsole, string gameCondition, float gamePrice)
        {
            title = gameTitle;
            console = gameConsole;
            condition = gameCondition;
            price = gamePrice;
        }

        public GameData(string gameTitle, string gameConsole, string gameDev, string gamePublisher,
            string gameCondition, float gamePrice)
        {
            title = gameTitle;
            console = gameConsole;
            developer = gameDev;
            publisher = gamePublisher;
            condition = gameCondition;
            price = gamePrice;
        }

        // Getters and setters
        public string Title { get; set; }
        public string Console { get; set; }
        public string Developer { get; set; }
        public string Publisher { get; set; }
        public string Condition { get; set; }
        public float Price { get; set; }
    }
}
