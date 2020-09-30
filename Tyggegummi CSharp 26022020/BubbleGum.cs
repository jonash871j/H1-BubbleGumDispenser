
public enum BubbleGumTastes
{
    Blueberry,
    Blackberry,
    Truttifrutti,
    Orange,
    Stawberry,
    Apple,
};
public enum BubbleGumColors
{
    Indigo,
    Purple,
    Yellow,
    Orange,
    Red,
    Green,
};

public class BubbleGum
{
    private BubbleGumTastes taste;
    private BubbleGumColors color;
    private string[] tasteNames = new string[]
    {
        "blueberry",
        "blackberry",
        "truttifrutti",
        "orange",
        "stawberry",
        "apple",
    };
    private string[] tasteColors = new string[]
    {
        "indigo",
        "purple",
        "yellow",
        "orange",
        "red",
        "green",
    };

    public BubbleGumTastes Taste
    {
        get { return taste; }
    }
    public BubbleGumColors Color
    {
        get { return color; }
    }

    public BubbleGum(BubbleGumTastes taste, BubbleGumColors color)
    {
        this.taste = taste;
        this.color = color;
    }

    /// <summary>
    /// Used to get bubblegum taste
    /// </summary>
    /// <returns>message</returns>
    public string GetTaste()
    {
        return tasteNames[(int)taste];
    }
    /// <summary>
    /// Used to get bubblegum color
    /// </summary>
    /// <returns>message</returns>
    public string GetColor()
    {
        return tasteColors[(int)color];
    }
}