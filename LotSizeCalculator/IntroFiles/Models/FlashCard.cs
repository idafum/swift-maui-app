/*
    FlashCard Model

    This model represents the data displayes on the Intro pages
*/

namespace LotSizeCalculator.IntroFiles.Models;

public class FlashCard
{
    //Automatic properties
    public string Image { get; set; }
    public string Title { get; set; }
    public string Subtitle { get; set; }

    public FlashCard(string image, string title, string subtitle)
    {
        Image = image;
        Title = title;
        Subtitle = subtitle;
    }
}