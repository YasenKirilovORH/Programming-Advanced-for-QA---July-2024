namespace _01.Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Song> songList = new List<Song>();
            int countOfSongs = int.Parse(Console.ReadLine());

            for (int count = 1; count <= countOfSongs; count++)
            {
                string data = Console.ReadLine();

                string[] songData = data.Split("_");

                string typeList = songData[0];
                string name = songData[1];
                string time = songData[2];
                
                Song song = new Song(typeList, name, time);
                songList.Add(song);
            }

            string typeOfSongsToPrint = Console.ReadLine();

            foreach (Song song in songList)
            {
                if (typeOfSongsToPrint == "all" || typeOfSongsToPrint == song.TypeList)
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }
}
