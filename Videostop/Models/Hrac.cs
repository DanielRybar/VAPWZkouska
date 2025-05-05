namespace Videostop.Models
{
    public class Hrac
    {
        public string? Jmeno { get; set; }
        public int Skore { get; set; } = 0;
        public override string ToString()
        {
            return $"{Jmeno} - {Skore}";
        }
    }
}
