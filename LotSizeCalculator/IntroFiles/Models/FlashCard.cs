/*
    FlashCard Model

    This model represents the data displayes on the Intro pages
*/

namespace LotSizeCalculator.IntroFiles.Models;

public class FlashCard
{
    string image;
    string title;
    string subtitle;

    public FlashCard(string Image, string Title, string Subtitle)
    {
        image = Image;
        title = Title;
        subtitle = Subtitle;
    }
}