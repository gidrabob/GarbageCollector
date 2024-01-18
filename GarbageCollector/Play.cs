namespace GarbageCollector
{
    public class Play: IDisposable
    {
        public string TitleOfPlay { get; set; }
        public string AutorName { get; set; }
        public string GenreOfPlay { get; set; }
        public int DataOfPlay { get; set; }
        public Play(string titleOfPlay, string autorName, string genreOfPlay, int dataOfPlay) 
        {
            TitleOfPlay = titleOfPlay;
            AutorName = autorName;
            GenreOfPlay = genreOfPlay;
            DataOfPlay = dataOfPlay;
        }
        public void ShowPlay()
        {
            Console.WriteLine($"Name of play: {TitleOfPlay}\nName of autor: {AutorName}\nGenre of play: {GenreOfPlay}\nData of play: {DataOfPlay}");
        }
        ~Play () => Console.WriteLine($"{TitleOfPlay} has deleted");
        public void Dispose() => Console.WriteLine($"{TitleOfPlay} was dispose");        
    }
}
