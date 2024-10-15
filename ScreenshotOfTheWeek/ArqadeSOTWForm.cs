using System.Windows.Forms.Design;

namespace ScreenshotOfTheWeek
{
    public partial class ArqadeSOTWForm : Form
    {
        private int SOTWNumber { get; set; }

        private string ThemeTitle { get; set; } = "No theme";

        private string ThemeText { get; set; } = "There is no theme this week.";

        private string Winner { get; set; }

        private string GameTag { get; set; }

        private int Upvotes { get; set; }

        private int PreviousPostId { get; set; }

        private int WinningPostId { get; set; }

        private string WinningScreenshot { get; set; }

        private string ThemeFull
        {
            get
            {
                return $"\r\n\r\n# {ThemeTitle}" +
                    $"\r\n\r\n{ThemeText}";
            }
        }

        private string SOTWNumberWithPostFix
        {
            get
            {
                var lastDigit = SOTWNumber % 10;
                var postFix = "th";
                if (lastDigit == 2)
                    postFix = "nd";
                else if (lastDigit == 3)
                    postFix = "rd";
                else if (lastDigit == 4 || lastDigit == 5 || lastDigit == 6
                    || lastDigit == 7 || lastDigit == 8 || lastDigit == 9)
                    postFix = "th";

                return $"{SOTWNumber}<sup>{postFix}</sup>";
            }
        }

        public ArqadeSOTWForm()
        {
            InitializeComponent();
        }

        private void copyToClickboard_Click(object sender, EventArgs e)
        { 
            var closeDate = DateTime.Now.AddDays(7).ToLongDateString();
            var finishDate = DateTime.Now.AddDays(14).ToLongDateString();

            var template = "<!-- # This contest is over." +
                "\r\n\r\n*[previous contest][contest prev] | [next contest][contest next]* -->" + 
                $"\r\n\r\nHello and welcome to the **{SOTWNumberWithPostFix}** edition of the Screenshot of the Week!" +
                $"\r\n\r\nTo start with, congratulations to the winner of the previous contest! [{Winner}][winning post]'s screenshot from [tag:{GameTag}] won with {Upvotes} upvotes! " +
                "\r\n\r\n[![Last week's winning screenshot one][winning screenshot]][winning screenshot]" +
                "\r\n\r\n---" +
                "\r\n\r\nTo submit a screenshot, simply post it as an answer to this question, but please take note of the following:" +
                "\r\n\r\n- One screenshot per post, and one post per person, please!" +
                "\r\n- Limited picture modifications are allowed, such as cropping, simple filters, and blurring of identifying info such as names, but not adding other images or text. " +
                "\r\n- To ensure a fair playing field, please post screenshots you've taken yourself rather than ones you found online. " +
                "\r\n- Stack Exchange’s [Code of Conduct][code of conduct] still applies - so if it would be unacceptable to post normally, it’s unacceptable here. " +
                "\r\n\r\nAlso, try to avoid pictures that include spoilers. We want everyone to be able to enjoy this contest, so the less spoilers the better." +
                $"\r\n\r\n### How long will the contest run?\r\nWe will accept submissions for a week, until {closeDate}, then have a second week-long period where only voting will be accepted. This is to give every submission, even those posted at the end of the first week, a chance to be voted on by everyone. " +
                $"\r\n\r\nAfter the end of the second week, at {finishDate}, we will count upvotes only to determine the winning screenshot, which will be featured for a week on the main site's photo widget." +
                "\r\n\r\n------------------------" +
                $"{ThemeFull}" +
                "\r\n\r\nAs a reminder, we're always accepting suggestions for themed weeks, and have compiled that suggestion process into a [question of its own][themes collection].  Additionally, there is the [hall of fame][hall of fame] you can check out that contains all the previous contest winners." +
                $"\r\n\r\n  [contest prev]:       //meta.arqade.com/q/{PreviousPostId}" +
                "\r\n  [contest next]:       //meta.arqade.com/q/17226" +
                $"\r\n\r\n  [winning post]:       https://gaming.meta.stackexchange.com/a/{PreviousPostId}/{WinningPostId}" +
                $"\r\n  [winning screenshot]: {WinningScreenshot}" +
                "\r\n\r\n  [code of conduct]:   //arqade.com/conduct" +
                "\r\n  [themes collection]: //meta.arqade.com/q/15029" +
                "\r\n  [hall of fame]:      //meta.arqade.com/q/14939";
            Clipboard.SetText(template);
        }

        private void sotwNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox ?? new TextBox();
            if (int.TryParse(textBox.Text, out int value))
                SOTWNumber = value;
        }

        private void themeBodyRichTextBox_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as RichTextBox ?? new RichTextBox();
            ThemeText = textBox.Text;
        }

        private void prevPostTextBox_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox ?? new TextBox();
            if (int.TryParse(textBox.Text, out int value))
                PreviousPostId = value;
        }

        private void winningPostTextBox_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox ?? new TextBox();
            if (int.TryParse(textBox.Text, out int value))
                WinningPostId = value;
        }

        private void gameTagTextBox_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox ?? new TextBox();
            GameTag = textBox.Text;
        }

        private void winningUserTextBox_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox ?? new TextBox();
            Winner = textBox.Text;
        }

        private void winningScreenshotTextBox_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox ?? new TextBox();
            WinningScreenshot = textBox.Text;
        }

        private void winningUpvotesTextBox_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox ?? new TextBox();
            if (int.TryParse(textBox.Text, out int value))
                Upvotes = value;
        }
    }
}
