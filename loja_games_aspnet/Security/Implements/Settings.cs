namespace loja_games.Security.Implements
{
    public class Settings
    {
        private static string secret = "8597c17eb68d074b2b3e016dfb79c9aa3219acc3b710c9c7e573715fbbb3c68e";

        public static string Secret { get => secret; set => secret = value; }

    }
}
