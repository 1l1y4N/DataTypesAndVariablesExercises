using System;


namespace P19Thea
{
    class Program
    {
        static void Main(string[] args)
        {
            int photos = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());

            int filteredPhotos = (int)Math.Ceiling((filterFactor / 100.0) * photos);
            int timeNeeded = photos * filterTime;
            timeNeeded += filteredPhotos * uploadTime;

            int days = timeNeeded / 86400;
            timeNeeded %= 86400;
            int hours = timeNeeded / 3600;
            String hoursStr = (hours < 10) ? ("0" + hours.ToString()) : hours.ToString();
            timeNeeded %= 3600;
            int minutes = timeNeeded / 60;
            String minutesStr = (minutes < 10) ? ("0" + minutes.ToString()) : minutes.ToString();
            int seconds = timeNeeded % 60;
            String secondsStr = (seconds < 10) ? ("0" + seconds.ToString()) : seconds.ToString();

            Console.WriteLine("{0}:{1}:{2}:{3}", days, hoursStr, minutesStr, secondsStr);
        }
    }
}
